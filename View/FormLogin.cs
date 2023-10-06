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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

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

                    if (tg != null)
                    {
                        if (tg.MatKhau == txtPassWoud.Text)
                        {
                            FormMenu a = new FormMenu();
                            GetDataUser.tentaikhoan = tg.TaiKhoan1;
                            GetDataUser.phanquyen = tg.PhanQuyen;
                            MessageBox.Show("Đăng nhập thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Hide();
                            a.ShowDialog();
                            a.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác hãy nhập lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Hiện không có tài khoản nào giống như quý khách đã cung cấp !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bạn cần xem lại các thao tác vừa làm !");
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
