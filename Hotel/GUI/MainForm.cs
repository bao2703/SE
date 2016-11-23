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
using DTO.Domain;
using DTO.BindingModel;

namespace GUI
{
	public partial class MainForm : Form
	{
		private BindingList<RoomBindingModel> availableRoomBindingList;
		private BindingList<BookingRoomBindingModel> bookingRoomsBindingList;

		public MainForm()
		{
			InitializeComponent();
			this.comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBoxRoomType.Items.AddRange(new object[] { "None", TypeOfRoom.A, TypeOfRoom.B, TypeOfRoom.C, TypeOfRoom.D });
			this.comboBoxRoomType.SelectedIndex = 0;
			Reload();
			dgvReservationList.DataSource = BookingBUS.GetBookingsForBinding();
		}

		private void Reload()
		{
			this.comboBoxRoomType.SelectedIndex = 0;
			availableRoomBindingList = RoomBUS.GetAvailableRoomsForBinding(dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value);
			bookingRoomsBindingList = new BindingList<BookingRoomBindingModel>();
			dgvAvailableRooms.DataSource = availableRoomBindingList;
			dgvBookingRooms.DataSource = bookingRoomsBindingList;
		}

		private void AdjustColumnOrder()
		{
			dgvBookingRooms.Columns["RoomId"].DisplayIndex = 0;
			dgvBookingRooms.Columns["TypeName"].DisplayIndex = 1;
			dgvBookingRooms.Columns["NumOfCustomer"].DisplayIndex = 2;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			DataGridView[] dataGridViews = new DataGridView[3];
			dataGridViews[0] = dgvReservationList;
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
			AdjustColumnOrder();
		}

		private void btnAddBooking_Click(object sender, EventArgs e)
		{

		}

		private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!comboBoxRoomType.SelectedItem.Equals("None"))
			{
				TypeOfRoom typeOfRoom = (TypeOfRoom)comboBoxRoomType.SelectedItem;
				dgvAvailableRooms.DataSource = new BindingList<RoomBindingModel>(availableRoomBindingList.Where(r => r.TypeName == typeOfRoom).ToList());
			}
			else
			{
				dgvAvailableRooms.DataSource = availableRoomBindingList;
			}
		}


		private void dateTimePickerBookingStart_ValueChanged(object sender, EventArgs e)
		{
			if (!Utilities.IsValidStartAndEndDate(dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value))
			{
				dateTimePickerBookingEnd.Value = dateTimePickerBookingStart.Value;
			}
			Reload();
		}

		private void dateTimePickerBookingEnd_ValueChanged(object sender, EventArgs e)
		{
			if (!Utilities.IsValidStartAndEndDate(dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value))
			{
				dateTimePickerBookingStart.Value = dateTimePickerBookingEnd.Value;
			}
			Reload();
		}

		private void btnAddBookingRoom_Click(object sender, EventArgs e)
		{
			if (dgvAvailableRooms.Rows.Count <= 0)
			{
				return;
			}

			var selectedRoomId = dgvAvailableRooms.CurrentRow.Cells["RoomId"].Value.ToString();
			var selectedRoom = availableRoomBindingList.Single(r => r.RoomId == selectedRoomId);

			bookingRoomsBindingList.Add(new BookingRoomBindingModel()
			{
				RoomId = selectedRoom.RoomId,
				TypeName = selectedRoom.TypeName,
				NumOfCustomer = int.Parse(numericUpDownCustomerAmount.Value.ToString())
			});
			
			availableRoomBindingList.Remove(selectedRoom);

			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}

		private void btnRemoveBookingRoom_Click(object sender, EventArgs e)
		{
			if (dgvBookingRooms.Rows.Count <= 0)
			{
				return;
			}
			var selectedRoomId = dgvBookingRooms.CurrentRow.Cells["RoomId"].Value.ToString();
			var selectedRoom = bookingRoomsBindingList.Single(r => r.RoomId == selectedRoomId);

			availableRoomBindingList.Add(new RoomBindingModel()
			{
				RoomId = selectedRoom.RoomId,
				TypeName = selectedRoom.TypeName,
			});

			bookingRoomsBindingList.Remove(selectedRoom);
			availableRoomBindingList = new BindingList<RoomBindingModel>(availableRoomBindingList.OrderBy(r => r.RoomId.Length).ThenBy(r => r.RoomId).ToList());
			dgvAvailableRooms.DataSource = availableRoomBindingList;

			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}
	}
}
