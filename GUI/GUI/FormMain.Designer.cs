namespace GUI
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBoxThongTinNhanVien = new System.Windows.Forms.GroupBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblTenNhanVien = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBoxThongTinKhachHang = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtSoLuongKhach = new System.Windows.Forms.TextBox();
			this.txtSoLuongPhong = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnChiTiet = new System.Windows.Forms.Button();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimeNgayDi = new System.Windows.Forms.DateTimePicker();
			this.dateTimeNgayDen = new System.Windows.Forms.DateTimePicker();
			this.txtTelex = new System.Windows.Forms.TextBox();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.txtSoDienThoai = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewDatPhong = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnXem = new System.Windows.Forms.Button();
			this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
			this.groupBoxThongTinNhanVien.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBoxThongTinKhachHang.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatPhong)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxThongTinNhanVien
			// 
			this.groupBoxThongTinNhanVien.Controls.Add(this.btnLogout);
			this.groupBoxThongTinNhanVien.Controls.Add(this.lblTenNhanVien);
			this.groupBoxThongTinNhanVien.Location = new System.Drawing.Point(1000, 12);
			this.groupBoxThongTinNhanVien.Name = "groupBoxThongTinNhanVien";
			this.groupBoxThongTinNhanVien.Size = new System.Drawing.Size(227, 48);
			this.groupBoxThongTinNhanVien.TabIndex = 10;
			this.groupBoxThongTinNhanVien.TabStop = false;
			this.groupBoxThongTinNhanVien.Text = "Tên nhân viên";
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(135, 15);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(86, 23);
			this.btnLogout.TabIndex = 10;
			this.btnLogout.Text = "Đăng xuất";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// lblTenNhanVien
			// 
			this.lblTenNhanVien.AutoSize = true;
			this.lblTenNhanVien.Location = new System.Drawing.Point(6, 18);
			this.lblTenNhanVien.Name = "lblTenNhanVien";
			this.lblTenNhanVien.Size = new System.Drawing.Size(109, 17);
			this.lblTenNhanVien.TabIndex = 8;
			this.lblTenNhanVien.Text = "lblTenNhanVien";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 64);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1215, 653);
			this.tabControl1.TabIndex = 11;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBoxThongTinKhachHang);
			this.tabPage1.Controls.Add(this.dataGridViewDatPhong);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1207, 624);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Quản lý đặt phòng";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBoxThongTinKhachHang
			// 
			this.groupBoxThongTinKhachHang.Controls.Add(this.label8);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtSoLuongKhach);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtSoLuongPhong);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label9);
			this.groupBoxThongTinKhachHang.Controls.Add(this.btnChiTiet);
			this.groupBoxThongTinKhachHang.Controls.Add(this.btnXacNhan);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label6);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label7);
			this.groupBoxThongTinKhachHang.Controls.Add(this.dateTimeNgayDi);
			this.groupBoxThongTinKhachHang.Controls.Add(this.dateTimeNgayDen);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtTelex);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtFax);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtSoDienThoai);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtDiaChi);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtHoTen);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label5);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label3);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label4);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label2);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label1);
			this.groupBoxThongTinKhachHang.Location = new System.Drawing.Point(597, 6);
			this.groupBoxThongTinKhachHang.Name = "groupBoxThongTinKhachHang";
			this.groupBoxThongTinKhachHang.Size = new System.Drawing.Size(275, 336);
			this.groupBoxThongTinKhachHang.TabIndex = 1;
			this.groupBoxThongTinKhachHang.TabStop = false;
			this.groupBoxThongTinKhachHang.Text = "Số lượng khách:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 234);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(110, 17);
			this.label8.TabIndex = 17;
			this.label8.Text = "Số lượng khách:";
			// 
			// txtSoLuongKhach
			// 
			this.txtSoLuongKhach.Location = new System.Drawing.Point(138, 231);
			this.txtSoLuongKhach.Name = "txtSoLuongKhach";
			this.txtSoLuongKhach.Size = new System.Drawing.Size(124, 22);
			this.txtSoLuongKhach.TabIndex = 16;
			// 
			// txtSoLuongPhong
			// 
			this.txtSoLuongPhong.Location = new System.Drawing.Point(138, 259);
			this.txtSoLuongPhong.Name = "txtSoLuongPhong";
			this.txtSoLuongPhong.Size = new System.Drawing.Size(124, 22);
			this.txtSoLuongPhong.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 262);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 17);
			this.label9.TabIndex = 18;
			this.label9.Text = "Số lượng phòng:";
			// 
			// btnChiTiet
			// 
			this.btnChiTiet.Location = new System.Drawing.Point(9, 296);
			this.btnChiTiet.Name = "btnChiTiet";
			this.btnChiTiet.Size = new System.Drawing.Size(124, 23);
			this.btnChiTiet.TabIndex = 15;
			this.btnChiTiet.Text = "Chi tiết";
			this.btnChiTiet.UseVisualStyleBackColor = true;
			this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.Location = new System.Drawing.Point(138, 296);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(124, 23);
			this.btnXacNhan.TabIndex = 14;
			this.btnXacNhan.Text = "Xác nhận";
			this.btnXacNhan.UseVisualStyleBackColor = true;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "Ngày đi:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 178);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Ngày đến:";
			// 
			// dateTimeNgayDi
			// 
			this.dateTimeNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeNgayDi.Location = new System.Drawing.Point(138, 203);
			this.dateTimeNgayDi.Name = "dateTimeNgayDi";
			this.dateTimeNgayDi.Size = new System.Drawing.Size(124, 22);
			this.dateTimeNgayDi.TabIndex = 11;
			// 
			// dateTimeNgayDen
			// 
			this.dateTimeNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeNgayDen.Location = new System.Drawing.Point(138, 173);
			this.dateTimeNgayDen.Name = "dateTimeNgayDen";
			this.dateTimeNgayDen.Size = new System.Drawing.Size(124, 22);
			this.dateTimeNgayDen.TabIndex = 10;
			// 
			// txtTelex
			// 
			this.txtTelex.Location = new System.Drawing.Point(138, 146);
			this.txtTelex.Name = "txtTelex";
			this.txtTelex.Size = new System.Drawing.Size(124, 22);
			this.txtTelex.TabIndex = 9;
			// 
			// txtFax
			// 
			this.txtFax.Location = new System.Drawing.Point(138, 116);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(124, 22);
			this.txtFax.TabIndex = 8;
			// 
			// txtSoDienThoai
			// 
			this.txtSoDienThoai.Location = new System.Drawing.Point(138, 86);
			this.txtSoDienThoai.Name = "txtSoDienThoai";
			this.txtSoDienThoai.Size = new System.Drawing.Size(124, 22);
			this.txtSoDienThoai.TabIndex = 7;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(138, 56);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(124, 22);
			this.txtDiaChi.TabIndex = 6;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(138, 26);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(124, 22);
			this.txtHoTen.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Số telex:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Số fax:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Số điện thoại:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Địa chỉ:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ tên:";
			// 
			// dataGridViewDatPhong
			// 
			this.dataGridViewDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDatPhong.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewDatPhong.Name = "dataGridViewDatPhong";
			this.dataGridViewDatPhong.RowTemplate.Height = 24;
			this.dataGridViewDatPhong.Size = new System.Drawing.Size(585, 612);
			this.dataGridViewDatPhong.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1207, 624);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Quản lý thuê phòng";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dateTimePicker2);
			this.tabPage3.Controls.Add(this.dateTimePicker1);
			this.tabPage3.Controls.Add(this.comboBox1);
			this.tabPage3.Controls.Add(this.btnXem);
			this.tabPage3.Controls.Add(this.dataGridViewPhong);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1207, 624);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Quản lý phòng";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(960, 186);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(121, 22);
			this.dateTimePicker2.TabIndex = 4;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(811, 186);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(811, 116);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 2;
			// 
			// btnXem
			// 
			this.btnXem.Location = new System.Drawing.Point(680, 116);
			this.btnXem.Name = "btnXem";
			this.btnXem.Size = new System.Drawing.Size(75, 23);
			this.btnXem.TabIndex = 1;
			this.btnXem.Text = "Xem";
			this.btnXem.UseVisualStyleBackColor = true;
			this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
			// 
			// dataGridViewPhong
			// 
			this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPhong.Location = new System.Drawing.Point(41, 46);
			this.dataGridViewPhong.Name = "dataGridViewPhong";
			this.dataGridViewPhong.RowTemplate.Height = 24;
			this.dataGridViewPhong.Size = new System.Drawing.Size(565, 456);
			this.dataGridViewPhong.TabIndex = 0;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1239, 729);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBoxThongTinNhanVien);
			this.Name = "FormMain";
			this.Text = "Form";
			this.groupBoxThongTinNhanVien.ResumeLayout(false);
			this.groupBoxThongTinNhanVien.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBoxThongTinKhachHang.ResumeLayout(false);
			this.groupBoxThongTinKhachHang.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatPhong)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxThongTinNhanVien;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblTenNhanVien;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBoxThongTinKhachHang;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateTimeNgayDi;
		private System.Windows.Forms.DateTimePicker dateTimeNgayDen;
		private System.Windows.Forms.TextBox txtTelex;
		private System.Windows.Forms.TextBox txtFax;
		private System.Windows.Forms.TextBox txtSoDienThoai;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewDatPhong;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnChiTiet;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtSoLuongKhach;
		private System.Windows.Forms.TextBox txtSoLuongPhong;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnXem;
		private System.Windows.Forms.DataGridView dataGridViewPhong;
	}
}

