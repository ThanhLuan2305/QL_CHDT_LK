using QL_DT_LK.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DT_LK.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public class GetDataUser
        {
            static public string tentaikhoan;
            static public string phanquyen;
            static public byte[] tenAnh;
            static public string hoTen;
            static public string SDT;
            static public string QuenQuan;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkViewPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViewPassWord.Checked)
            {
                txtPassWoud.PasswordChar = '\0';
            }
            else
            {
                txtPassWoud.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "Admin";
            txtPassWoud.Text = "123";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            WaitFormFunc waitForm = new WaitFormFunc();
            waitForm.Show(this);
            try
            {
                if (txtUserName.Text == "" || txtPassWoud.Text == "")
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không được để trống !");

                }
                else
                {
                    TaiKhoanBUS ql = new TaiKhoanBUS();
                    TaiKhoan tg = ql.TimkiemTK(txtUserName.Text);
                    NhanVienBUS qlnv = new NhanVienBUS();
                    NhanVien nv = qlnv.searchNV(txtUserName.Text);

                    if (tg != null)
                    {
                        if (tg.MatKhau == txtPassWoud.Text)
                        {
                            FormMenu a = new FormMenu();
                            GetDataUser.tentaikhoan = tg.TaiKhoan1;
                            GetDataUser.phanquyen = tg.PhanQuyen;
                            GetDataUser.tenAnh = tg.HinhAnh;
                            GetDataUser.hoTen = nv.TenNV;
                            GetDataUser.SDT = nv.SDT;
                            GetDataUser.QuenQuan = nv.QueQuan;
                            waitForm.Close();
                            a.Show();
                            this.Hide();
                            a.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác hãy nhập lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi máy chủ!");
                waitForm.Close();
            }
        }

        private void checkViewPassWord_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkViewPassWord.Checked)
            {
                txtPassWoud.PasswordChar = '\0';
            }
            else
            {
                txtPassWoud.PasswordChar = '*';
            }
        }

        private void txtPassWoud_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
