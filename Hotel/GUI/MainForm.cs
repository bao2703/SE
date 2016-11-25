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
			BindingSource bs = new BindingSource();
			bs.DataSource = BookingBUS.GetBookings();
			dgvBookingList.DataSource = bs;
			//ReloadRoomTable();
		}
		private void dgvBookingList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if ((dgvBookingList.Rows[e.RowIndex].DataBoundItem != null) && (dgvBookingList.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
				e.Value = BindProperty(dgvBookingList.Rows[e.RowIndex].DataBoundItem, dgvBookingList.Columns[e.ColumnIndex].DataPropertyName);
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

		private DataTable RoomTable(List<RoomDTO> rooms)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("RoomId");
			dt.Columns.Add("Type");
			if (rooms == null)
			{
				return dt;
			}
			foreach (var item in rooms)
			{
				DataRow row = dt.NewRow();
				row["RoomId"] = item.RoomId;
				row["Type"] = item.RoomType.TypeName;
				dt.Rows.Add(row);
			}
			return dt;
		}

		private DataTable BookingRoomTale(List<BookingDetailDTO> bookingRoomDetails)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("RoomId");
			dt.Columns.Add("Type");
			dt.Columns.Add("NumOfCustomer");
			if (bookingRoomDetails == null)
			{
				return dt;
			}
			foreach (var item in bookingRoomDetails)
			{
				DataRow row = dt.NewRow();
				row["RoomId"] = item.RoomId;
				row["Type"] = item.Room.RoomType.TypeName;
				row["NumOfCustomer"] = item.NumOfCustomer;
				dt.Rows.Add(row);
			}
			return dt;
		}

		private DataTable BookingTable(List<BookingDTO> bookings)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("BookingId");
			dt.Columns.Add("TotalRoom");
			dt.Columns.Add("CreatedDate");
			dt.Columns.Add("EmployeeId");
			dt.Columns.Add("CustomerId");
			dt.Columns.Add("Name");
			dt.Columns.Add("Address");
			dt.Columns.Add("Phone");
			dt.Columns.Add("Fax");
			dt.Columns.Add("Telex");
			foreach (var item in bookings)
			{
				DataRow row = dt.NewRow();
				row["BookingId"] = item.BookingId;
				row["TotalRoom"] = item.BookingDetails.Count;
				row["CreatedDate"] = item.CreatedDate;
				row["EmployeeId"] = item.EmployeeId;
				row["CustomerId"] = item.Customer.CustomerId;
				row["Name"] = item.Customer.Name;
				row["Address"] = item.Customer.Address;
				row["Phone"] = item.Customer.Phone;
				row["Fax"] = item.Customer.Fax;
				row["Telex"] = item.Customer.Telex;
				dt.Rows.Add(row);
			}
			return dt;
		}

		private void ReloadRoomTable()
		{
			//this.comboBoxRoomType.SelectedIndex = 0;
			//availableRoom = RoomBUS.GetAvailableRooms(dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value);
			//bookingRoomDetails = new List<BookingDetailDTO>();
			//dgvAvailableRooms.DataSource = RoomTable(availableRoom);
			//dgvBookingRooms.DataSource = BookingRoomTale(bookingRoomDetails);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			DataGridView[] dataGridViews = new DataGridView[3];
			dataGridViews[0] = dgvBookingList;
			dataGridViews[1] = dgvAvailableRooms;
			dataGridViews[2] = dgvBookingRooms;
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
					Address = txtName.Text,
					Phone = txtPhone.Text,
					Fax = txtFax.Text,
					Telex = txtFax.Text
				},
				CreatedDate = DateTime.Now,
				BookingDetails = bookingRoomDetails
			};
			BookingBUS.Add(newBooking);
		}

		private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!comboBoxRoomType.SelectedItem.Equals("None"))
			{
				TypeOfRoom roomType = (TypeOfRoom)comboBoxRoomType.SelectedItem;
				var selectedTypeRoom = availableRoom.Where(r => r.RoomType.TypeName == roomType).ToList();
				dgvAvailableRooms.DataSource = RoomTable(selectedTypeRoom);
			}
			else
			{
				dgvAvailableRooms.DataSource = RoomTable(availableRoom);
			}
		}

		private void dateTimePickerBookingStart_ValueChanged(object sender, EventArgs e)
		{
			if (!Utilities.IsValidStartAndEndDate(dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value))
			{
				dateTimePickerBookingEnd.Value = dateTimePickerBookingStart.Value;
			}
			ReloadRoomTable();
		}

		private void dateTimePickerBookingEnd_ValueChanged(object sender, EventArgs e)
		{
			if (!Utilities.IsValidStartAndEndDate(dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value))
			{
				dateTimePickerBookingStart.Value = dateTimePickerBookingEnd.Value;
			}
			ReloadRoomTable();
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
				NumOfCustomer = int.Parse(numericUpDownCustomerAmount.Value.ToString()),
				Room = selectedRoom
			});
			availableRoom.Remove(selectedRoom);
			dgvBookingRooms.DataSource = BookingRoomTale(bookingRoomDetails);
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}

		private void btnRemoveBookingRoom_Click(object sender, EventArgs e)
		{
			if (dgvBookingRooms.Rows.Count <= 0)
			{
				return;
			}
			var selectedRoomId = dgvBookingRooms.CurrentRow.Cells["RoomId"].Value.ToString();
			var selectedBookingDetail = bookingRoomDetails.Single(r => r.RoomId == selectedRoomId);
			availableRoom.Add(selectedBookingDetail.Room);
			bookingRoomDetails.Remove(selectedBookingDetail);
			dgvBookingRooms.DataSource = BookingRoomTale(bookingRoomDetails);
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}
	}
}
