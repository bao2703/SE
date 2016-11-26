namespace GUI
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Linq;
	using System.Reflection;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Forms;
	using AutoMapper;
	using BUS;
	using DTO;

	public partial class MainForm : Form
	{
		private EmployeeDTO employee;
		private List<RoomDTO> availableRoom;
		private List<BookingDetailDTO> bookingRoomDetails;

		public MainForm(EmployeeDTO employee)
		{
			this.InitializeComponent();
			this.employee = employee;
			this.comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBoxRoomType.Items.AddRange(new object[] { "None", TypeOfRoom.A, TypeOfRoom.B, TypeOfRoom.C, TypeOfRoom.D });

			this.bookingDTOBindingSource.DataSource = BookingBUS.GetBookings();
			this.ReloadGridViewRoomAndBookingDetail();
		}

		private void CellFormatting(object sender, DataGridViewCellFormattingEventArgs e, DataGridView dataGridView)
		{
			if (dataGridView.Rows[e.RowIndex].DataBoundItem != null && dataGridView.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
			{
				e.Value = this.BindProperty(dataGridView.Rows[e.RowIndex].DataBoundItem, dataGridView.Columns[e.ColumnIndex].DataPropertyName);
			}
		}

		private void dgvBookingList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			this.CellFormatting(sender, e, this.dgvBookingList);
		}

		private void dgvAvailableRooms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			this.CellFormatting(sender, e, this.dgvAvailableRooms);
		}

		private void dgvBookingDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			this.CellFormatting(sender, e, this.dgvBookingDetail);
		}

		private string BindProperty(object property, string propertyName)
		{
			string retValue = string.Empty;

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
						retValue = this.BindProperty(propertyInfo.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
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
			dt.Columns.Add("roomId");
			dt.Columns.Add("roomType");
			dt.Columns.Add("numOfCustomer");
			if (bookingRoomDetails == null)
			{
				return dt;
			}
			foreach (var item in bookingRoomDetails)
			{
				DataRow row = dt.NewRow();
				row["roomId"] = item.RoomId;
				row["roomType"] = item.Room.RoomType.TypeName;
				row["numOfCustomer"] = item.NumOfCustomer;
				dt.Rows.Add(row);
			}
			return dt;
		}

		private void ReloadGridViewRoomAndBookingDetail()
		{
			this.comboBoxRoomType.SelectedIndex = 0;
			this.availableRoom = RoomBUS.GetAvailableRooms(this.dateTimePickerBookingStart.Value, this.dateTimePickerBookingEnd.Value);
			this.roomDTOBindingSource.DataSource = this.availableRoom;
			this.bookingRoomDetails = new List<BookingDetailDTO>();
			this.dgvBookingDetail.DataSource = this.BookingRoomTale(this.bookingRoomDetails);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			DataGridView[] dataGridViews = new DataGridView[3];
			dataGridViews[0] = this.dgvBookingList;
			dataGridViews[1] = this.dgvAvailableRooms;
			dataGridViews[2] = this.dgvBookingDetail;
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
			if (bookingRoomDetails.Count == 0)
			{
				MessageBox.Show("Please add booking room", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			var newBooking = new BookingDTO()
			{
				BookingId = BookingBUS.NextId(),
				EmployeeId = this.employee.EmployeeId,
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
				BookingDetails = this.bookingRoomDetails
			};
			newBooking.BookingDetails.ForEach(b => b.Room = null);
			BookingBUS.AddBooking(newBooking);
			this.bookingDTOBindingSource.DataSource = BookingBUS.GetBookings();
			this.ReloadGridViewRoomAndBookingDetail();
		}

		private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!this.comboBoxRoomType.SelectedItem.Equals("None"))
			{
				TypeOfRoom roomType = (TypeOfRoom)this.comboBoxRoomType.SelectedItem;
				var selectedTypeRoom = this.availableRoom.Where(r => r.RoomType.TypeName == roomType).ToList();
				this.roomDTOBindingSource.DataSource = selectedTypeRoom;
			}
			else
			{
				this.roomDTOBindingSource.DataSource = this.availableRoom;
				this.dgvAvailableRooms.Refresh();
			}
		}

		private void dateTimePickerBookingStart_ValueChanged(object sender, EventArgs e)
		{
			if (!Utilities.IsValidStartAndEndDate(this.dateTimePickerBookingStart.Value, this.dateTimePickerBookingEnd.Value))
			{
				this.dateTimePickerBookingEnd.Value = this.dateTimePickerBookingStart.Value;
			}
			this.ReloadGridViewRoomAndBookingDetail();
		}

		private void dateTimePickerBookingEnd_ValueChanged(object sender, EventArgs e)
		{
			if (!Utilities.IsValidStartAndEndDate(this.dateTimePickerBookingStart.Value, this.dateTimePickerBookingEnd.Value))
			{
				this.dateTimePickerBookingStart.Value = this.dateTimePickerBookingEnd.Value;
			}
			this.ReloadGridViewRoomAndBookingDetail();
		}

		private void btnAddBookingRoom_Click(object sender, EventArgs e)
		{
			if (this.dgvAvailableRooms.Rows.Count <= 0)
			{
				return;
			}
			var selectedRoomId = this.dgvAvailableRooms.CurrentRow.Cells["roomId"].Value.ToString();
			var selectedRoom = this.availableRoom.Single(r => r.RoomId == selectedRoomId);

			this.bookingRoomDetails.Add(new BookingDetailDTO()
			{
				RoomId = selectedRoomId,
				BookingStart = this.dateTimePickerBookingStart.Value,
				BookingEnd = this.dateTimePickerBookingStart.Value,
				NumOfCustomer = int.Parse(this.numericUpDownCustomerAmount.Value.ToString()),
				Room = selectedRoom
			});
			this.availableRoom.Remove(selectedRoom);
			this.roomDTOBindingSource.DataSource = this.availableRoom;
			this.dgvBookingDetail.DataSource = this.BookingRoomTale(this.bookingRoomDetails);

			this.comboBoxRoomType_SelectedIndexChanged(sender, e);
		}

		private void btnRemoveBookingRoom_Click(object sender, EventArgs e)
		{
			if (this.dgvBookingDetail.Rows.Count <= 0)
			{
				return;
			}
			var selectedRoomId = this.dgvBookingDetail.CurrentRow.Cells["roomId"].Value.ToString();
			var selectedBookingDetail = this.bookingRoomDetails.Single(r => r.RoomId == selectedRoomId);

			this.availableRoom.Add(selectedBookingDetail.Room);
			this.bookingRoomDetails.Remove(selectedBookingDetail);
			this.dgvBookingDetail.DataSource = this.BookingRoomTale(this.bookingRoomDetails);

			this.comboBoxRoomType_SelectedIndexChanged(sender, e);
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			this.bookingDTOBindingSource.DataSource = BookingBUS.GetBookingsByContainsId(txtSearch.Text);
		}

		private void dgvBookingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (MessageBox.Show("Make a check in?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}
			string selectedBookingId = this.dgvBookingList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
		}
	}
}
