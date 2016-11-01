namespace GUI
{
	partial class FormChiTietDatPhong
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblTongSoKhach = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxLoaiPhong = new System.Windows.Forms.ComboBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSoLuongKhach = new System.Windows.Forms.TextBox();
			this.txtSoLuongPhong = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSoLuongKhach);
			this.groupBox1.Controls.Add(this.txtSoLuongPhong);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.lblTongSoKhach);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBoxLoaiPhong);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(684, 634);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chi tiết đặt phòng";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(154, 117);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Lưu";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// lblTongSoKhach
			// 
			this.lblTongSoKhach.AutoSize = true;
			this.lblTongSoKhach.Location = new System.Drawing.Point(9, 30);
			this.lblTongSoKhach.Name = "lblTongSoKhach";
			this.lblTongSoKhach.Size = new System.Drawing.Size(110, 17);
			this.lblTongSoKhach.TabIndex = 8;
			this.lblTongSoKhach.Text = "Số lượng khách:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(54, 237);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(537, 255);
			this.dataGridView1.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Loại phòng:";
			// 
			// comboBoxLoaiPhong
			// 
			this.comboBoxLoaiPhong.FormattingEnabled = true;
			this.comboBoxLoaiPhong.Location = new System.Drawing.Point(154, 83);
			this.comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
			this.comboBoxLoaiPhong.Size = new System.Drawing.Size(156, 24);
			this.comboBoxLoaiPhong.TabIndex = 4;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(235, 117);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "Số lượng phòng:";
			// 
			// txtSoLuongKhach
			// 
			this.txtSoLuongKhach.Location = new System.Drawing.Point(154, 27);
			this.txtSoLuongKhach.Name = "txtSoLuongKhach";
			this.txtSoLuongKhach.Size = new System.Drawing.Size(124, 22);
			this.txtSoLuongKhach.TabIndex = 20;
			// 
			// txtSoLuongPhong
			// 
			this.txtSoLuongPhong.Location = new System.Drawing.Point(154, 55);
			this.txtSoLuongPhong.Name = "txtSoLuongPhong";
			this.txtSoLuongPhong.Size = new System.Drawing.Size(124, 22);
			this.txtSoLuongPhong.TabIndex = 21;
			// 
			// FormChiTietDatPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 686);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormChiTietDatPhong";
			this.Text = "FormChiTietDatPhong";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxLoaiPhong;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblTongSoKhach;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSoLuongKhach;
		private System.Windows.Forms.TextBox txtSoLuongPhong;
	}
}