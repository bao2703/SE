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
			comboBoxRoomType.Items.AddRange(new object[] { "None", TypeOfRoom.A, TypeOfRoom.B, TypeOfRoom.C, TypeOfRoom.D });
			comboBoxRoomType.SelectedIndex = 0;
			dgvReservationList.DataSource = BookingBUS.GetBookingsAndCustomersForBinding();
			
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			DataGridView[] dataGridViews = new DataGridView[2];
			dataGridViews[0] = dgvReservationList;
			dataGridViews[1] = dgvAvailableRooms;
			foreach (var item in dataGridViews)
			{
				item.MultiSelect = false;
				item.RowHeadersVisible = false;
			}
		}

		private void btnAddBooking_Click(object sender, EventArgs e)
		{

		}

		private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			TypeOfRoom? typeOfRoom = null;
			if (!comboBoxRoomType.SelectedItem.Equals("None"))
			{
				typeOfRoom = (TypeOfRoom)comboBoxRoomType.SelectedItem;
			}
			dgvAvailableRooms.DataSource = RoomBUS.GetAvailableRoomsForBinding(typeOfRoom, dateTimePickerBookingStart.Value, dateTimePickerBookingEnd.Value);
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
	}
}
