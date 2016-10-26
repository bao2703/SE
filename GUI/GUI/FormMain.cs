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
	public partial class FormMain : Form
	{
		private NhanVien nhanVien;

		public FormMain(NhanVien nhanVien)
		{
			this.nhanVien = nhanVien;
			InitializeComponent();
		}
	}
}
