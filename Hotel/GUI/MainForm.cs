using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using AutoMapper;
using System.Reflection;

namespace GUI
{
	public partial class MainForm : Form
	{
		private EmployeeDTO employee;
		private List<RoomDTO> availableRoom;
		private List<BookingDetailDTO> bookingRoomDetails;

		public MainForm(EmployeeDTO employee)
		{
			InitializeComponent();
			this.employee = employee;
			this.comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBoxRoomType.Items.AddRange(new object[] { "None", TypeOfRoom.A, TypeOfRoom.B, TypeOfRoom.C, TypeOfRoom.D });

			bookingDTOBindingSource.DataSource = BookingBUS.GetBookings();

			ReloadGridViewRoomAndBookingDetail();
		}
		private void CellFormatting(object sender, DataGridViewCellFormattingEventArgs e, DataGridView dataGridView)
		{
			if ((dataGridView.Rows[e.RowIndex].DataBoundItem != null) && (dataGridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
				e.Value = BindProperty(dataGridView.Rows[e.RowIndex].DataBoundItem, dataGridView.Columns[e.ColumnIndex].DataPropertyName);
		}

		private void dgvBookingList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			CellFormatting(sender, e, dgvBookingList);
		}

		private void dgvAvailableRooms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			CellFormatting(sender, e, dgvAvailableRooms);
		}

		private void dgvBookingDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			CellFormatting(sender, e, dgvBookingDetail);
		}

		private string BindProperty(object property, string propertyName)
		{
			string retValue;

			retValue = "";

			if (propertyName.Contains("."))
			{
				PropertyInfo[] arrayProperties;
				string leftPropertyName;

				leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
				arrayProperties = property.GetType().GetProperties();

				foreach (PropertyInfo propertyInfo in arrayProperties)
				{
					if (propertyInfo.Name == leftPropertyName)
					{
						retValue = BindProperty(propertyInfo.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
						break;
					}
				}
			}
			else
			{
				Type propertyType;
				PropertyInfo propertyInfo;

				propertyType = property.GetType();
				propertyInfo = propertyType.GetProperty(propertyName);
				retValue = propertyInfo.GetValue(property, null).ToString();
			}

			return retValue;
		}

		private DataTable BookingRoomTale(List<BookingDetailDTO> bookingRoomDetails)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("RoomId");
			dt.Columns.Add("RoomType");
			dt.Columns.Add("NumOfCustomer");
			if (bookingRoomDetails == null)
			{
				return dt;
			}
			foreach (var item in bookingRoomDetails)
			{
				DataRow row = dt.NewRow();
				row["RoomId"] = item.RoomId;
				row["RoomType"] = item.Room.RoomType.TypeName;
				row["NumOfCustomer"] = item.NumOfCustomer;
				dt.Rows.Add(row);
			}
			return dt;
		}

		private void ReloadGridViewRoomAndBookingDetail()
		{
			this.comboBoxRoomType.SelectedIndex = 0;
			availableRoom = RoomBUS.GetAvailableRooms(dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value);
			roomDTOBindingSource.DataSource = availableRoom;
			bookingRoomDetails = new List<BookingDetailDTO>();
			dgvBookingDetail.DataSource = BookingRoomTale(bookingRoomDetails);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			DataGridView[] dataGridViews = new DataGridView[3];
			dataGridViews[0] = dgvBookingList;
			dataGridViews[1] = dgvAvailableRooms;
			dataGridViews[2] = dgvBookingDetail;
			foreach (var item in dataGridViews)
			{
				item.MultiSelect = false;
				item.RowHeadersVisible = false;
				item.ReadOnly = true;
				item.AllowUserToResizeRows = false;
				item.AllowUserToAddRows = false;
				item.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
			}
		}

		private void btnAddBooking_Click(object sender, EventArgs e)
		{
			var newBooking = new BookingDTO()
			{
				BookingId = BookingBUS.NextId(),
				EmployeeId = employee.EmployeeId,
				Customer = new CustomerDTO()
				{
					CustomerId = CustomerBUS.NextId(),
					Name = txtName.Text,
					Address = txtAddress.Text,
					Phone = txtPhone.Text,
					Fax = txtFax.Text,
					Telex = txtTelex.Text
				},
				CreatedDate = DateTime.Now,
				BookingDetails = bookingRoomDetails
			};
			BookingBUS.Add(newBooking);
			bookingDTOBindingSource.DataSource = BookingBUS.GetBookings();
		}

		private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!comboBoxRoomType.SelectedItem.Equals("None"))
			{
				TypeOfRoom roomType = (TypeOfRoom)comboBoxRoomType.SelectedItem;
				var selectedTypeRoom = availableRoom.Where(r => r.RoomType.TypeName == roomType).ToList();
				roomDTOBindingSource.DataSource = selectedTypeRoom;
			}
			else
			{
				roomDTOBindingSource.DataSource = availableRoom;
			}
		}

		private void dateTimePickerBookingStart_ValueChanged(object sender, EventArgs e)
		{
			if (!Utilities.IsValidStartAndEndDate(dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value))
			{
				dateTimePickerBookingEnd.Value = dateTimePickerBookingStart.Value;
			}
			ReloadGridViewRoomAndBookingDetail();
		}

		private void dateTimePickerBookingEnd_ValueChanged(object sender, EventArgs e)
		{
			if (!Utilities.IsValidStartAndEndDate(dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value))
			{
				dateTimePickerBookingStart.Value = dateTimePickerBookingEnd.Value;
			}
			ReloadGridViewRoomAndBookingDetail();
		}

		private void btnAddBookingRoom_Click(object sender, EventArgs e)
		{
			if (dgvAvailableRooms.Rows.Count <= 0)
			{
				return;
			}
			var selectedRoomId = dgvAvailableRooms.CurrentRow.Cells["RoomId"].Value.ToString();
			var selectedRoom = availableRoom.Single(r => r.RoomId == selectedRoomId);
			bookingRoomDetails.Add(new BookingDetailDTO()
			{
				RoomId = selectedRoomId,
				BookingStart = dateTimePickerBookingStart.Value,
				BookingEnd = dateTimePickerBookingStart.Value,
				NumOfCustomer = int.Parse(numericUpDownCustomerAmount.Value.ToString()),
				Room = selectedRoom
			});
			availableRoom.Remove(selectedRoom);
			roomDTOBindingSource.DataSource = availableRoom;
			dgvBookingDetail.DataSource = BookingRoomTale(bookingRoomDetails);
			dgvAvailableRooms.Refresh();
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}

		private void btnRemoveBookingRoom_Click(object sender, EventArgs e)
		{
			if (dgvBookingDetail.Rows.Count <= 0)
			{
				return;
			}
			var selectedRoomId = dgvBookingDetail.CurrentRow.Cells["RoomId"].Value.ToString();
			var selectedBookingDetail = bookingRoomDetails.Single(r => r.RoomId == selectedRoomId);
			availableRoom.Add(selectedBookingDetail.Room);
			bookingRoomDetails.Remove(selectedBookingDetail);
			dgvBookingDetail.DataSource = BookingRoomTale(bookingRoomDetails);
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}
	}
}
