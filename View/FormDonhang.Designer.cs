namespace QL_DT_LK.View
{
    partial class FormDonhang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrvHienThiListSPChon = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vbButton1 = new CustomButton.VBButton();
            this.btnXemchitiet = new CustomButton.VBButton();
            this.btnTaoDonHang = new CustomButton.VBButton();
            this.btnHuyDH = new CustomButton.VBButton();
            this.btnXuatHoadon = new CustomButton.VBButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemSP = new CustomButton.VBButton();
            this.btnXoaSanPham = new CustomButton.VBButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSPChon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ĐH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(120, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrvHienThiListSPChon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 215);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(736, 102);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm đã chọn";
            // 
            // dtgrvHienThiListSPChon
            // 
            this.dtgrvHienThiListSPChon.AllowUserToResizeColumns = false;
            this.dtgrvHienThiListSPChon.AllowUserToResizeRows = false;
            this.dtgrvHienThiListSPChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHienThiListSPChon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrvHienThiListSPChon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgrvHienThiListSPChon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgrvHienThiListSPChon.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgrvHienThiListSPChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSPChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrvHienThiListSPChon.ColumnHeadersHeight = 33;
            this.dtgrvHienThiListSPChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrvHienThiListSPChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.soluong,
            this.clGiaban,
            this.Thanhtien});
            this.dtgrvHienThiListSPChon.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvHienThiListSPChon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvHienThiListSPChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrvHienThiListSPChon.EnableHeadersVisualStyles = false;
            this.dtgrvHienThiListSPChon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgrvHienThiListSPChon.Location = new System.Drawing.Point(2, 15);
            this.dtgrvHienThiListSPChon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgrvHienThiListSPChon.Name = "dtgrvHienThiListSPChon";
            this.dtgrvHienThiListSPChon.ReadOnly = true;
            this.dtgrvHienThiListSPChon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSPChon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrvHienThiListSPChon.RowHeadersVisible = false;
            this.dtgrvHienThiListSPChon.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.dtgrvHienThiListSPChon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrvHienThiListSPChon.RowTemplate.Height = 28;
            this.dtgrvHienThiListSPChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvHienThiListSPChon.Size = new System.Drawing.Size(732, 85);
            this.dtgrvHienThiListSPChon.TabIndex = 1;
            this.dtgrvHienThiListSPChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvHienThiListSPChon_CellContentClick);
            this.dtgrvHienThiListSPChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvHienThiListSPChon_CellContentClick);
            this.dtgrvHienThiListSPChon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgrvHienThiListSPChon_DataBindingComplete);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.FillWeight = 62.88284F;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.FillWeight = 74.69347F;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 8;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // clGiaban
            // 
            this.clGiaban.DataPropertyName = "Giaban";
            this.clGiaban.HeaderText = "Giá Bán";
            this.clGiaban.MinimumWidth = 8;
            this.clGiaban.Name = "clGiaban";
            this.clGiaban.ReadOnly = true;
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành Tiền";
            this.Thanhtien.MinimumWidth = 8;
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(29, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thời gian";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 138);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(349, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(279, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã NV Xử Lý";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(281, 88);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(99, 21);
            this.cboMaNV.TabIndex = 10;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cboMaNV);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtDiaChi);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtSDTKH);
            this.groupBox4.Controls.Add(this.txtMaDH);
            this.groupBox4.Controls.Add(this.txtTenKH);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(7, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(393, 190);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(29, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(31, 90);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(217, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(279, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT Khách Hàng";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(281, 40);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(99, 20);
            this.txtSDTKH.TabIndex = 8;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(31, 40);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(66, 20);
            this.txtMaDH.TabIndex = 6;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(123, 40);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(126, 20);
            this.txtTenKH.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Controls.Add(this.btnXemchitiet);
            this.panel1.Controls.Add(this.btnTaoDonHang);
            this.panel1.Controls.Add(this.btnHuyDH);
            this.panel1.Controls.Add(this.btnXuatHoadon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 43);
            this.panel1.TabIndex = 9;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 8;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vbButton1.Location = new System.Drawing.Point(38, 9);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(2);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.vbButton1.Size = new System.Drawing.Size(108, 26);
            this.vbButton1.TabIndex = 13;
            this.vbButton1.Text = "Refesh";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // btnXemchitiet
            // 
            this.btnXemchitiet.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXemchitiet.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXemchitiet.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXemchitiet.BorderRadius = 8;
            this.btnXemchitiet.BorderSize = 0;
            this.btnXemchitiet.FlatAppearance.BorderSize = 0;
            this.btnXemchitiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemchitiet.ForeColor = System.Drawing.Color.White;
            this.btnXemchitiet.Location = new System.Drawing.Point(583, 9);
            this.btnXemchitiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemchitiet.Name = "btnXemchitiet";
            this.btnXemchitiet.Size = new System.Drawing.Size(122, 26);
            this.btnXemchitiet.TabIndex = 12;
            this.btnXemchitiet.Text = "Xem chi tiết DH";
            this.btnXemchitiet.TextColor = System.Drawing.Color.White;
            this.btnXemchitiet.UseVisualStyleBackColor = false;
            this.btnXemchitiet.Visible = false;
            this.btnXemchitiet.Click += new System.EventHandler(this.btnXemchitiet_Click);
            // 
            // btnTaoDonHang
            // 
            this.btnTaoDonHang.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTaoDonHang.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTaoDonHang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTaoDonHang.BorderRadius = 8;
            this.btnTaoDonHang.BorderSize = 0;
            this.btnTaoDonHang.FlatAppearance.BorderSize = 0;
            this.btnTaoDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoDonHang.ForeColor = System.Drawing.Color.White;
            this.btnTaoDonHang.Location = new System.Drawing.Point(304, 9);
            this.btnTaoDonHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoDonHang.Name = "btnTaoDonHang";
            this.btnTaoDonHang.Size = new System.Drawing.Size(122, 26);
            this.btnTaoDonHang.TabIndex = 9;
            this.btnTaoDonHang.Text = "Tạo Đơn Hàng";
            this.btnTaoDonHang.TextColor = System.Drawing.Color.White;
            this.btnTaoDonHang.UseVisualStyleBackColor = false;
            this.btnTaoDonHang.Click += new System.EventHandler(this.btnTaoDonHang_Click);
            // 
            // btnHuyDH
            // 
            this.btnHuyDH.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHuyDH.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHuyDH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuyDH.BorderRadius = 8;
            this.btnHuyDH.BorderSize = 0;
            this.btnHuyDH.FlatAppearance.BorderSize = 0;
            this.btnHuyDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDH.ForeColor = System.Drawing.Color.White;
            this.btnHuyDH.Location = new System.Drawing.Point(163, 9);
            this.btnHuyDH.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyDH.Name = "btnHuyDH";
            this.btnHuyDH.Size = new System.Drawing.Size(122, 26);
            this.btnHuyDH.TabIndex = 10;
            this.btnHuyDH.Text = "Hủy đơn hàng";
            this.btnHuyDH.TextColor = System.Drawing.Color.White;
            this.btnHuyDH.UseVisualStyleBackColor = false;
            this.btnHuyDH.Click += new System.EventHandler(this.btnHuyDH_Click);
            // 
            // btnXuatHoadon
            // 
            this.btnXuatHoadon.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXuatHoadon.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXuatHoadon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuatHoadon.BorderRadius = 8;
            this.btnXuatHoadon.BorderSize = 0;
            this.btnXuatHoadon.FlatAppearance.BorderSize = 0;
            this.btnXuatHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoadon.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoadon.Location = new System.Drawing.Point(443, 9);
            this.btnXuatHoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatHoadon.Name = "btnXuatHoadon";
            this.btnXuatHoadon.Size = new System.Drawing.Size(122, 26);
            this.btnXuatHoadon.TabIndex = 11;
            this.btnXuatHoadon.Text = "Xuất hóa đơn";
            this.btnXuatHoadon.TextColor = System.Drawing.Color.White;
            this.btnXuatHoadon.UseVisualStyleBackColor = false;
            this.btnXuatHoadon.Visible = false;
            this.btnXuatHoadon.Click += new System.EventHandler(this.btnXuatHoadon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(736, 215);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThemSP);
            this.groupBox3.Controls.Add(this.btnXoaSanPham);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSoluong);
            this.groupBox3.Controls.Add(this.cboSanPham);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(400, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(329, 190);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn sản phẩm";
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThemSP.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThemSP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemSP.BorderRadius = 15;
            this.btnThemSP.BorderSize = 0;
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(48, 136);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(122, 26);
            this.btnThemSP.TabIndex = 10;
            this.btnThemSP.Text = "Thêm Sản Phẩm";
            this.btnThemSP.TextColor = System.Drawing.Color.White;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoaSanPham.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoaSanPham.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaSanPham.BorderRadius = 15;
            this.btnXoaSanPham.BorderSize = 0;
            this.btnXoaSanPham.FlatAppearance.BorderSize = 0;
            this.btnXoaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSanPham.ForeColor = System.Drawing.Color.White;
            this.btnXoaSanPham.Location = new System.Drawing.Point(207, 136);
            this.btnXoaSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(122, 26);
            this.btnXoaSanPham.TabIndex = 9;
            this.btnXoaSanPham.Text = "Xóa Sản Phẩm";
            this.btnXoaSanPham.TextColor = System.Drawing.Color.White;
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(23, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã SP | Tên sản phẩm | Số lượng tồn";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(26, 97);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(73, 20);
            this.txtSoluong.TabIndex = 8;
            // 
            // cboSanPham
            // 
            this.cboSanPham.ForeColor = System.Drawing.Color.DarkGray;
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(26, 47);
            this.cboSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(301, 21);
            this.cboSanPham.TabIndex = 0;
            this.cboSanPham.Text = "  Chọn sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(23, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số lượng mua";
            // 
            // FormDonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonhang";
            this.Text = "FormDonhang";
            this.Load += new System.EventHandler(this.FormDonhang_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSPChon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrvHienThiListSPChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Panel panel1;
        private CustomButton.VBButton vbButton1;
        private CustomButton.VBButton btnXemchitiet;
        private CustomButton.VBButton btnTaoDonHang;
        private CustomButton.VBButton btnHuyDH;
        private CustomButton.VBButton btnXuatHoadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private CustomButton.VBButton btnThemSP;
        private CustomButton.VBButton btnXoaSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label label8;
    }
}