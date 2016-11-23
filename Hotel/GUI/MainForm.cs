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
		private List<Room> rooms;
		private List<Room> bookingRooms;
		private BindingList<RoomBindingModel> availableRoomBindingList;
		private BindingList<BookingRoomBindingModel> bookingRoomsBindingList;

		public MainForm()
		{
			InitializeComponent();
			this.comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBoxRoomType.Items.AddRange(new object[] { "None", TypeOfRoom.A, TypeOfRoom.B, TypeOfRoom.C, TypeOfRoom.D });
			this.comboBoxRoomType.SelectedIndex = 0;

			rooms = RoomBUS.GetAll();
			bookingRooms = new List<Room>();
			availableRoomBindingList = Adapter.Exec(RoomBUS.GetAvailableRooms(rooms, dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value));
			bookingRoomsBindingList = new BindingList<BookingRoomBindingModel>();

			dgvAvailableRooms.DataSource = availableRoomBindingList;
			dgvBookingRooms.DataSource = bookingRoomsBindingList;
			dgvReservationList.DataSource = BookingBUS.GetBookingsForBinding();
		}
		private void AdjustColumnOrder()
		{
			dgvBookingRooms.Columns["RoomId"].DisplayIndex = 0;
			dgvBookingRooms.Columns["TypeName"].DisplayIndex = 1;
			dgvBookingRooms.Columns["BookingStart"].DisplayIndex = 2;
			dgvBookingRooms.Columns["BookingEnd"].DisplayIndex = 3;
			dgvBookingRooms.Columns["NumOfCustomer"].DisplayIndex = 4;
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
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}

		private void dateTimePickerBookingEnd_ValueChanged(object sender, EventArgs e)
		{
			if (!Utilities.IsValidStartAndEndDate(dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value))
			{
				dateTimePickerBookingStart.Value = dateTimePickerBookingEnd.Value;
			}
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}

		private void btnAddBookingRoom_Click(object sender, EventArgs e)
		{
			if (dgvAvailableRooms.Rows.Count <= 0)
			{
				return;
			}

			var selectedRoomId = dgvAvailableRooms.CurrentRow.Cells["RoomId"].Value.ToString();
			var selectedRoom = rooms.Single(r => r.RoomId == selectedRoomId);

			bookingRoomsBindingList.Add(new BookingRoomBindingModel()
			{
				RoomId = selectedRoom.RoomId,
				TypeName = selectedRoom.RoomType.TypeName,
				BookingStart = dateTimePickerBookingStart.Value,
				BookingEnd = dateTimePickerBookingEnd.Value,
				NumOfCustomer = int.Parse(numericUpDownCustomerAmount.Value.ToString())
			});

			rooms.Remove(selectedRoom);
			bookingRooms.Add(selectedRoom);
			Reload();
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}

		private void btnRemoveBookingRoom_Click(object sender, EventArgs e)
		{
			if (dgvBookingRooms.Rows.Count <= 0)
			{
				return;
			}
			var selectedRoomId = dgvBookingRooms.CurrentRow.Cells["RoomId"].Value.ToString();
			var selectedRoom = bookingRooms.Single(r => r.RoomId == selectedRoomId);

			availableRoomBindingList.Add(new RoomBindingModel()
			{
				RoomId = selectedRoom.RoomId,
				TypeName = selectedRoom.RoomType.TypeName,
			});

			bookingRooms.Remove(selectedRoom);
			availableRoomBindingList = new BindingList<RoomBindingModel>(availableRoomBindingList.OrderBy(r => r.RoomId.Length).ThenBy(r => r.RoomId).ToList());
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}

		private void Reload()
		{
			availableRoomBindingList = Adapter.Exec(RoomBUS.GetAvailableRooms(rooms, dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value));
			//bookingRoomsBindingList = Adapter.Exec(bookingRooms);
		}
	}
}
