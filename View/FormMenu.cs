﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QL_DT_LK.View;

namespace QL_DT_LK.View
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private Form formNow;

        private void LoadForm(Form formnew)
        {
            if (formNow != null)
            {
                formNow.Close();
            }
            formNow = formnew;
            formnew.TopLevel = false;
            formnew.FormBorderStyle = FormBorderStyle.None;
            formnew.Dock = DockStyle.Fill;
            panel6.Controls.Add(formnew);
            panel6.Tag = formnew;
            formnew.BringToFront();
            formnew.Show();
        }

        private Button ButtonNow;


        private void ActiveColor(Button ButtonNew)
        {
            if (ButtonNow != null)
            {
                ButtonNow.ForeColor = Color.White;
                ButtonNow = ButtonNew;
                ButtonNew.ForeColor = Color.FromArgb(225, 82, 61);

            }
        }

        private void btnNhacc_Click(object sender, EventArgs e)
        {
            FormNhaCC a = new FormNhaCC();
            LoadForm(a);
            ActiveColor(btnNhacc);
        }

        static string GetTimeNow()
        {
            DateTime date = DateTime.Now; // Lấy thời điểm hiện tại

            string dayOfWeek = date.ToString("dddd"); // Lấy thứ trong tuần
            string dayOfMonth = date.Day.ToString(); // Lấy ngày trong tháng
            string month = date.Month.ToString(); // Lấy tên của tháng
            string year = date.Year.ToString(); // Lấy năm

            return $"{dayOfWeek}, ngày {dayOfMonth}/{month}/{year}";
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            FormDashboar a = new FormDashboar();
            LoadForm(a);
            ActiveColor(btnTrangchu);

            lblPhanQuyen.Text = FormLogin.GetDataUser.phanquyen;
            lblHoTen.Text = FormLogin.GetDataUser.hoTen; 
            lblSDT.Text = FormLogin.GetDataUser.SDT;
            lblQQ.Text = FormLogin.GetDataUser.QuenQuan;
            //Gettime
            lblDateTime.Text = GetTimeNow();
            if (lblPhanQuyen.Text == "Nhân Viên")
            {
                btnNhanvien.Visible = false;
                btnThongke.Visible = false;
            }
            ButtonNow = btnTrangchu;
            ButtonNow.ForeColor = Color.FromArgb(225, 82, 61);
            byte[] check = FormLogin.GetDataUser.tenAnh;
            if (check != null)
            {
                PTB_Ava.Image = ByteArrayToImg(FormLogin.GetDataUser.tenAnh);
            }
        }
        Image ByteArrayToImg(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddDH_Click(object sender, EventArgs e)
        {
            FormDonhang a = new FormDonhang();
            LoadForm(a);
            ActiveColor(btnAddDH);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FormSanPham a = new FormSanPham();
            LoadForm(a);
            ActiveColor(btnSanPham);
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            FormNhanVien a = new FormNhanVien();
            LoadForm(a);
            ActiveColor(btnNhanvien);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất tài khoản không  ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin a = new FormLogin();
                a.ShowDialog();
            }
        }

        private void btnKhohang_Click(object sender, EventArgs e)
        {
            FormKhoHang a = new FormKhoHang();
            LoadForm(a);
            ActiveColor(btnKhohang);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            FormDSDonHang a = new FormDSDonHang();
            LoadForm(a);
            ActiveColor(btnThongke);
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            FormDashboar a = new FormDashboar();
            LoadForm(a);
            ActiveColor(btnTrangchu);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void lbTenHinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
