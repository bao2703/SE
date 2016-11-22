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
		public MainForm()
		{
			InitializeComponent();
			comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxRoomType.Items.AddRange(new object[] { "Type", "Type A", "Type B", "Type C", "Type D" });
			comboBoxRoomType.SelectedIndex = 0;
			dgvReservationList.DataSource = BookingBUS.GetBookingsAndCustomersForBinding();
			
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}

		private void btnAddBooking_Click(object sender, EventArgs e)
		{

		}

		private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			TypeOfRoom typeOfRoom = 0;
			if (comboBoxRoomType.SelectedIndex == 1)
			{
				typeOfRoom = TypeOfRoom.A;
			}
			else if(comboBoxRoomType.SelectedIndex == 2)
			{
				typeOfRoom = TypeOfRoom.B;
			}
			else if(comboBoxRoomType.SelectedIndex == 3)
			{
				typeOfRoom = TypeOfRoom.C;
			}
			else if (comboBoxRoomType.SelectedIndex == 4)
			{
				typeOfRoom = TypeOfRoom.D;
			}
			var rooms = RoomBUS.GetAvailableRoomsForBinding(typeOfRoom, dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value);
			dgvAvailableRooms.DataSource = rooms;
		}

		private void dateTimePickerBookingStart_ValueChanged(object sender, EventArgs e)
		{
			var start = dateTimePickerBookingStart.Value;
			var end = dateTimePickerBookingEnd.Value;
			if (start.CompareTo(end) == 1 || start.CompareTo(end) == 0)
			{
				dateTimePickerBookingEnd.Value = start;
			}
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}
		 
		private void dateTimePickerBookingEnd_ValueChanged(object sender, EventArgs e)
		{
			var start = dateTimePickerBookingStart.Value;
			var end = dateTimePickerBookingEnd.Value;
			if (start.CompareTo(end) == 1 || start.CompareTo(end) == 0)
			{
				dateTimePickerBookingStart.Value = end;
			}
			comboBoxRoomType_SelectedIndexChanged(sender, e);
		}
	}
}
