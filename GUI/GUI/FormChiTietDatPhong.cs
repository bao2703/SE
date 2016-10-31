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

namespace GUI
{
	public partial class FormChiTietDatPhong : Form
	{
		private List<ChiTietDatPhong> chiTietDatPhong;
		public FormChiTietDatPhong(List<ChiTietDatPhong> chiTietDatPhong)
		{
			InitializeComponent();
			this.chiTietDatPhong = chiTietDatPhong;
			comboBoxLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxLoaiPhong.Items.AddRange(new object[] { LoaiPhong.A, LoaiPhong.B, LoaiPhong.C, LoaiPhong.D });
			comboBoxLoaiPhong.SelectedIndex = 0;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			
		}
	}
}
