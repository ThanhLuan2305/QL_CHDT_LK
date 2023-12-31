﻿namespace QL_DT_LK.View
{
    partial class FormThongKe
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXuatExcel = new CustomButton.VBButton();
            this.btnTimkiem = new CustomButton.VBButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXemchitiet = new CustomButton.VBButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrvHienThiListALLDH = new System.Windows.Forms.DataGridView();
            this.quequanNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListALLDH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(705, 7);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(51, 24);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Refesh";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXuatExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXuatExcel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuatExcel.BorderRadius = 20;
            this.btnXuatExcel.BorderSize = 0;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(553, 2);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnXuatExcel.Size = new System.Drawing.Size(140, 34);
            this.btnXuatExcel.TabIndex = 12;
            this.btnXuatExcel.Text = "Xuất ALL Ra Excel ";
            this.btnXuatExcel.TextColor = System.Drawing.Color.White;
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimkiem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimkiem.BorderRadius = 0;
            this.btnTimkiem.BorderSize = 0;
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Image = global::QL_DT_LK.Properties.Resources.search__1_;
            this.btnTimkiem.Location = new System.Drawing.Point(342, 8);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(28, 20);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.TextColor = System.Drawing.Color.White;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnXuatExcel);
            this.panel2.Controls.Add(this.btnXemchitiet);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 41);
            this.panel2.TabIndex = 15;
            // 
            // btnXemchitiet
            // 
            this.btnXemchitiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXemchitiet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXemchitiet.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXemchitiet.BorderRadius = 20;
            this.btnXemchitiet.BorderSize = 0;
            this.btnXemchitiet.FlatAppearance.BorderSize = 0;
            this.btnXemchitiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemchitiet.ForeColor = System.Drawing.Color.White;
            this.btnXemchitiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemchitiet.Location = new System.Drawing.Point(387, 2);
            this.btnXemchitiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemchitiet.Name = "btnXemchitiet";
            this.btnXemchitiet.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnXemchitiet.Size = new System.Drawing.Size(162, 34);
            this.btnXemchitiet.TabIndex = 11;
            this.btnXemchitiet.Text = "Xem Chi Tiết Đơn Hàng";
            this.btnXemchitiet.TextColor = System.Drawing.Color.White;
            this.btnXemchitiet.UseVisualStyleBackColor = false;
            this.btnXemchitiet.Visible = false;
            this.btnXemchitiet.Click += new System.EventHandler(this.btnXemchitiet_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(6, 5);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(378, 26);
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.Text = "  Tìm kiếm";
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.FillWeight = 113.9686F;
            this.tongtien.HeaderText = "Tổng hóa đơn (VNĐ)";
            this.tongtien.MinimumWidth = 8;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // EmailNV
            // 
            this.EmailNV.DataPropertyName = "MaNV";
            this.EmailNV.FillWeight = 85.10628F;
            this.EmailNV.HeaderText = "Mã NV";
            this.EmailNV.MinimumWidth = 8;
            this.EmailNV.Name = "EmailNV";
            this.EmailNV.ReadOnly = true;
            // 
            // sdtNV
            // 
            this.sdtNV.DataPropertyName = "DiaChi";
            this.sdtNV.FillWeight = 95.76552F;
            this.sdtNV.HeaderText = "Địa chỉ";
            this.sdtNV.MinimumWidth = 8;
            this.sdtNV.Name = "sdtNV";
            this.sdtNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenKH";
            this.TenNV.FillWeight = 143.8535F;
            this.TenNV.HeaderText = "Tên KH";
            this.TenNV.MinimumWidth = 8;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaDH";
            this.MaNV.FillWeight = 58.27938F;
            this.MaNV.HeaderText = "Mã ĐH";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrvHienThiListALLDH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(760, 312);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các hóa đơn tại cửa hàng";
            // 
            // dtgrvHienThiListALLDH
            // 
            this.dtgrvHienThiListALLDH.AllowUserToResizeColumns = false;
            this.dtgrvHienThiListALLDH.AllowUserToResizeRows = false;
            this.dtgrvHienThiListALLDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHienThiListALLDH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgrvHienThiListALLDH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrvHienThiListALLDH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgrvHienThiListALLDH.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgrvHienThiListALLDH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListALLDH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrvHienThiListALLDH.ColumnHeadersHeight = 33;
            this.dtgrvHienThiListALLDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrvHienThiListALLDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.sdtNV,
            this.quequanNV,
            this.EmailNV,
            this.tongtien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvHienThiListALLDH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvHienThiListALLDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrvHienThiListALLDH.EnableHeadersVisualStyles = false;
            this.dtgrvHienThiListALLDH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgrvHienThiListALLDH.Location = new System.Drawing.Point(2, 17);
            this.dtgrvHienThiListALLDH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgrvHienThiListALLDH.Name = "dtgrvHienThiListALLDH";
            this.dtgrvHienThiListALLDH.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListALLDH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrvHienThiListALLDH.RowHeadersVisible = false;
            this.dtgrvHienThiListALLDH.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            this.dtgrvHienThiListALLDH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrvHienThiListALLDH.RowTemplate.Height = 28;
            this.dtgrvHienThiListALLDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvHienThiListALLDH.Size = new System.Drawing.Size(756, 293);
            this.dtgrvHienThiListALLDH.TabIndex = 1;
            this.dtgrvHienThiListALLDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvHienThiListALLDH_CellClick);
            this.dtgrvHienThiListALLDH.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgrvHienThiListALLDH_DataBindingComplete);
            // 
            // quequanNV
            // 
            this.quequanNV.DataPropertyName = "NgayMua";
            this.quequanNV.FillWeight = 128.657F;
            this.quequanNV.HeaderText = "Ngày mua";
            this.quequanNV.MinimumWidth = 8;
            this.quequanNV.Name = "quequanNV";
            this.quequanNV.ReadOnly = true;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThongKe";
            this.Text = "FormKhongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListALLDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private CustomButton.VBButton btnXuatExcel;
        private CustomButton.VBButton btnTimkiem;
        private System.Windows.Forms.Panel panel2;
        private CustomButton.VBButton btnXemchitiet;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrvHienThiListALLDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequanNV;
    }
}