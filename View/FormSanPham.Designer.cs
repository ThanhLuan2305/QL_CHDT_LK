namespace QL_DT_LK.View
{
    partial class FormSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrvHienThiListSP = new System.Windows.Forms.DataGridView();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHangSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbXuatxu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTheloai = new System.Windows.Forms.ComboBox();
            this.cbbHangSP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PTB_SP = new System.Windows.Forms.PictureBox();
            this.btnAddNV = new CustomButton.VBButton();
            this.btnDeleteNV = new CustomButton.VBButton();
            this.btnReplaceNV = new CustomButton.VBButton();
            this.btnReset = new CustomButton.VBButton();
            this.btnTimkiem = new CustomButton.VBButton();
            this.PTRIn = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_SP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTRIn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrvHienThiListSP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 13, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(874, 324);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các sản phẩm";
            // 
            // dtgrvHienThiListSP
            // 
            this.dtgrvHienThiListSP.AllowUserToResizeColumns = false;
            this.dtgrvHienThiListSP.AllowUserToResizeRows = false;
            this.dtgrvHienThiListSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHienThiListSP.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgrvHienThiListSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgrvHienThiListSP.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgrvHienThiListSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgrvHienThiListSP.ColumnHeadersHeight = 33;
            this.dtgrvHienThiListSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrvHienThiListSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSP,
            this.clTenNV,
            this.clHangSP,
            this.clTenSP,
            this.clTheloai,
            this.clXuatXu,
            this.clGiaBan,
            this.HinhAnh});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvHienThiListSP.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgrvHienThiListSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrvHienThiListSP.EnableHeadersVisualStyles = false;
            this.dtgrvHienThiListSP.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtgrvHienThiListSP.Location = new System.Drawing.Point(2, 15);
            this.dtgrvHienThiListSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgrvHienThiListSP.Name = "dtgrvHienThiListSP";
            this.dtgrvHienThiListSP.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgrvHienThiListSP.RowHeadersVisible = false;
            this.dtgrvHienThiListSP.RowHeadersWidth = 62;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtgrvHienThiListSP.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgrvHienThiListSP.RowTemplate.Height = 28;
            this.dtgrvHienThiListSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvHienThiListSP.Size = new System.Drawing.Size(870, 307);
            this.dtgrvHienThiListSP.TabIndex = 0;
            this.dtgrvHienThiListSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvHienThiListSP_CellClick);
            // 
            // clMaSP
            // 
            this.clMaSP.DataPropertyName = "MaSP";
            this.clMaSP.FillWeight = 62.88284F;
            this.clMaSP.HeaderText = "Mã SP";
            this.clMaSP.MinimumWidth = 8;
            this.clMaSP.Name = "clMaSP";
            this.clMaSP.ReadOnly = true;
            // 
            // clTenNV
            // 
            this.clTenNV.DataPropertyName = "MaNCC";
            this.clTenNV.FillWeight = 74.69347F;
            this.clTenNV.HeaderText = "Mã NCC";
            this.clTenNV.MinimumWidth = 8;
            this.clTenNV.Name = "clTenNV";
            this.clTenNV.ReadOnly = true;
            // 
            // clHangSP
            // 
            this.clHangSP.DataPropertyName = "HangSP";
            this.clHangSP.FillWeight = 73.68264F;
            this.clHangSP.HeaderText = "Hãng SP";
            this.clHangSP.MinimumWidth = 8;
            this.clHangSP.Name = "clHangSP";
            this.clHangSP.ReadOnly = true;
            // 
            // clTenSP
            // 
            this.clTenSP.DataPropertyName = "TenSP";
            this.clTenSP.FillWeight = 139.2045F;
            this.clTenSP.HeaderText = "Tên Sản Phẩm";
            this.clTenSP.MinimumWidth = 8;
            this.clTenSP.Name = "clTenSP";
            this.clTenSP.ReadOnly = true;
            // 
            // clTheloai
            // 
            this.clTheloai.DataPropertyName = "TheLoai";
            this.clTheloai.FillWeight = 138.8195F;
            this.clTheloai.HeaderText = "Thể loại";
            this.clTheloai.MinimumWidth = 8;
            this.clTheloai.Name = "clTheloai";
            this.clTheloai.ReadOnly = true;
            // 
            // clXuatXu
            // 
            this.clXuatXu.DataPropertyName = "XuatXu";
            this.clXuatXu.FillWeight = 84.30445F;
            this.clXuatXu.HeaderText = "Xuất Xứ";
            this.clXuatXu.MinimumWidth = 8;
            this.clXuatXu.Name = "clXuatXu";
            this.clXuatXu.ReadOnly = true;
            // 
            // clGiaBan
            // 
            this.clGiaBan.DataPropertyName = "GiaBan";
            this.clGiaBan.FillWeight = 126.4124F;
            this.clGiaBan.HeaderText = "Giá Bán";
            this.clGiaBan.MinimumWidth = 8;
            this.clGiaBan.Name = "clGiaBan";
            this.clGiaBan.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình SP";
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            this.HinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNV);
            this.panel1.Controls.Add(this.btnDeleteNV);
            this.panel1.Controls.Add(this.btnReplaceNV);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(760, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 194);
            this.panel1.TabIndex = 26;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaBan.Location = new System.Drawing.Point(461, 61);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(104, 21);
            this.txtGiaBan.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(459, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giá Bán";
            // 
            // cbbXuatxu
            // 
            this.cbbXuatxu.BackColor = System.Drawing.Color.White;
            this.cbbXuatxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbXuatxu.ForeColor = System.Drawing.Color.Black;
            this.cbbXuatxu.FormattingEnabled = true;
            this.cbbXuatxu.Items.AddRange(new object[] {
            "Việt Nam",
            "Mĩ",
            "Lào",
            "Campuchia",
            "Thái Lan",
            "Nhật",
            "Đức",
            "Hàn Quốc",
            "Nga"});
            this.cbbXuatxu.Location = new System.Drawing.Point(304, 123);
            this.cbbXuatxu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbXuatxu.Name = "cbbXuatxu";
            this.cbbXuatxu.Size = new System.Drawing.Size(133, 21);
            this.cbbXuatxu.TabIndex = 23;
            this.cbbXuatxu.Text = "  Chọn xuất xứ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(302, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Xuất Xứ";
            // 
            // cbbTheloai
            // 
            this.cbbTheloai.BackColor = System.Drawing.Color.White;
            this.cbbTheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTheloai.ForeColor = System.Drawing.Color.Black;
            this.cbbTheloai.FormattingEnabled = true;
            this.cbbTheloai.Items.AddRange(new object[] {
            "Ốp Lứng",
            "Tai Nghe",
            "Cáp Sạc",
            "Củ Sạc",
            "Ốp lưng",
            "Loa Blutooth",
            "Kính cường lực"});
            this.cbbTheloai.Location = new System.Drawing.Point(154, 123);
            this.cbbTheloai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTheloai.Name = "cbbTheloai";
            this.cbbTheloai.Size = new System.Drawing.Size(127, 21);
            this.cbbTheloai.TabIndex = 21;
            this.cbbTheloai.Text = "  Chọn thể loại";
            // 
            // cbbHangSP
            // 
            this.cbbHangSP.BackColor = System.Drawing.Color.White;
            this.cbbHangSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbHangSP.ForeColor = System.Drawing.Color.Black;
            this.cbbHangSP.FormattingEnabled = true;
            this.cbbHangSP.ItemHeight = 13;
            this.cbbHangSP.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Intel",
            "Oppo",
            "Xiaomi",
            "Nokia",
            "Sony",
            "Vivo",
            "Huawei",
            ""});
            this.cbbHangSP.Location = new System.Drawing.Point(304, 60);
            this.cbbHangSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbHangSP.Name = "cbbHangSP";
            this.cbbHangSP.Size = new System.Drawing.Size(133, 21);
            this.cbbHangSP.TabIndex = 20;
            this.cbbHangSP.Text = "  Chọn hãng sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(152, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nhà Cung Cấp";
            // 
            // cbbNCC
            // 
            this.cbbNCC.BackColor = System.Drawing.Color.White;
            this.cbbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbNCC.ForeColor = System.Drawing.Color.Black;
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(154, 60);
            this.cbbNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(127, 21);
            this.cbbNCC.TabIndex = 18;
            this.cbbNCC.Text = "  Chọn nhà cung cấp";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(22, 168);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(269, 37);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.Text = "    Tìm kiếm";
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Location = new System.Drawing.Point(22, 123);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(104, 21);
            this.txtTenSP.TabIndex = 12;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Location = new System.Drawing.Point(22, 61);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(104, 21);
            this.txtMaSP.TabIndex = 7;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã SP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(152, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thể Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(302, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hãng Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PTRIn);
            this.groupBox1.Controls.Add(this.PTB_SP);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbXuatxu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbTheloai);
            this.groupBox1.Controls.Add(this.cbbHangSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbNCC);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 13);
            this.groupBox1.Size = new System.Drawing.Size(874, 223);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // PTB_SP
            // 
            this.PTB_SP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PTB_SP.Location = new System.Drawing.Point(586, 18);
            this.PTB_SP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PTB_SP.Name = "PTB_SP";
            this.PTB_SP.Size = new System.Drawing.Size(158, 187);
            this.PTB_SP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PTB_SP.TabIndex = 27;
            this.PTB_SP.TabStop = false;
            // 
            // btnAddNV
            // 
            this.btnAddNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNV.BorderColor = System.Drawing.Color.White;
            this.btnAddNV.BorderRadius = 14;
            this.btnAddNV.BorderSize = 0;
            this.btnAddNV.FlatAppearance.BorderSize = 0;
            this.btnAddNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNV.ForeColor = System.Drawing.Color.White;
            this.btnAddNV.Image = global::QL_DT_LK.Properties.Resources.add_user;
            this.btnAddNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNV.Location = new System.Drawing.Point(6, 15);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnAddNV.Size = new System.Drawing.Size(99, 38);
            this.btnAddNV.TabIndex = 14;
            this.btnAddNV.Text = "    Thêm";
            this.btnAddNV.TextColor = System.Drawing.Color.White;
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteNV.BorderRadius = 14;
            this.btnDeleteNV.BorderSize = 0;
            this.btnDeleteNV.FlatAppearance.BorderSize = 0;
            this.btnDeleteNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNV.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNV.Image = global::QL_DT_LK.Properties.Resources.delete;
            this.btnDeleteNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNV.Location = new System.Drawing.Point(6, 100);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDeleteNV.Size = new System.Drawing.Size(99, 34);
            this.btnDeleteNV.TabIndex = 15;
            this.btnDeleteNV.Text = "    Xóa";
            this.btnDeleteNV.TextColor = System.Drawing.Color.White;
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnReplaceNV
            // 
            this.btnReplaceNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReplaceNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReplaceNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReplaceNV.BorderRadius = 14;
            this.btnReplaceNV.BorderSize = 0;
            this.btnReplaceNV.FlatAppearance.BorderSize = 0;
            this.btnReplaceNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceNV.ForeColor = System.Drawing.Color.White;
            this.btnReplaceNV.Image = global::QL_DT_LK.Properties.Resources.wrench;
            this.btnReplaceNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceNV.Location = new System.Drawing.Point(6, 57);
            this.btnReplaceNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplaceNV.Name = "btnReplaceNV";
            this.btnReplaceNV.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnReplaceNV.Size = new System.Drawing.Size(99, 40);
            this.btnReplaceNV.TabIndex = 16;
            this.btnReplaceNV.Text = "    Sửa";
            this.btnReplaceNV.TextColor = System.Drawing.Color.White;
            this.btnReplaceNV.UseVisualStyleBackColor = false;
            this.btnReplaceNV.Click += new System.EventHandler(this.btnReplaceNV_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 14;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::QL_DT_LK.Properties.Resources.reset__1_;
            this.btnReset.Location = new System.Drawing.Point(6, 137);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 38);
            this.btnReset.TabIndex = 17;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.BackgroundColor = System.Drawing.Color.White;
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimkiem.BorderRadius = 0;
            this.btnTimkiem.BorderSize = 1;
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimkiem.Image = global::QL_DT_LK.Properties.Resources.search__1_;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(281, 167);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(94, 37);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.TextColor = System.Drawing.Color.Black;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // PTRIn
            // 
            this.PTRIn.Location = new System.Drawing.Point(482, 97);
            this.PTRIn.Name = "PTRIn";
            this.PTRIn.Size = new System.Drawing.Size(83, 107);
            this.PTRIn.TabIndex = 29;
            this.PTRIn.TabStop = false;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSanPham";
            this.Text = "Sản Phầm";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB_SP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTRIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrvHienThiListSP;
        private System.Windows.Forms.Panel panel1;
        private CustomButton.VBButton btnAddNV;
        private CustomButton.VBButton btnDeleteNV;
        private CustomButton.VBButton btnReplaceNV;
        private CustomButton.VBButton btnReset;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbXuatxu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTheloai;
        private System.Windows.Forms.ComboBox cbbHangSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.TextBox txtTimKiem;
        private CustomButton.VBButton btnTimkiem;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PTB_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHangSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaBan;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
        private System.Windows.Forms.PictureBox PTRIn;
    }
}