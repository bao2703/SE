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
using DTO.Domain;

namespace GUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			dgvReservationList.DataSource = CustomerBUS.GetAll();
		}

		private void btnAddBooking_Click(object sender, EventArgs e)
		{

		}
	}
}
