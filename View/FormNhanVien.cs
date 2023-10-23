using QL_DT_LK.Business;
using QL_DT_LK.DataAcsess;
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
    public partial class FormNhanVien : Form
    {
        NhanVienBUS ql = new NhanVienBUS();
        NhanVienDAL nv = new NhanVienDAL();
        TaiKhoanBUS qltk = new TaiKhoanBUS();
        List<NhanVien> listNV;

        public FormNhanVien()
        {
            InitializeComponent();
        }

        public dynamic GetListNV()
        {
            listNV = ql.GetListNV().ToList();
            var ListNVNew = listNV.Select(p => new { p.MaNV, p.TenNV, p.SDT, p.QueQuan, p.Email }).ToList();
            return ListNVNew;
        }

        public bool CheckTextBox()
        {
            if (txtMaNV.Text != "" && txtName.Text != "" && txtSDT.Text != "" && txtQueQuan.Text != "" && txtEmail.Text != "" && txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                return true;
            }
            return false;
        }
        public bool CheckTextBox2()
        {
            if (txtMaNV.Text != "" && txtName.Text != "" && txtSDT.Text != "" && txtQueQuan.Text != "" && txtEmail.Text != "")
            {
                return true;
            }
            return false;
        }

        public void LoadDataGridView()
        {
            dtgrvHienThiListNV.DataSource = GetListNV();
        }

        public NhanVien ObjectNV()
        {
            NhanVien nv = new NhanVien();
            if (CheckTextBox())
            {
                nv.MaNV = txtMaNV.Text;
                nv.TenNV = txtName.Text;
                nv.SDT = txtSDT.Text;
                nv.QueQuan = txtQueQuan.Text;
                nv.Email = txtEmail.Text;
                nv.Tentk = txtTaiKhoan.Text;
                return nv;

            }
            else
            {
                nv = null;
                return nv;
            }

        }
        public NhanVien ObjectNV2()
        {
            NhanVien nv = new NhanVien();
            if (CheckTextBox2())
            {
                nv.MaNV = txtMaNV.Text;
                nv.TenNV = txtName.Text;
                nv.SDT = txtSDT.Text;
                nv.QueQuan = txtQueQuan.Text;
                nv.Email = txtEmail.Text;
                nv.Tentk = txtTaiKhoan.Text;
                return nv;

            }
            else
            {
                nv = null;
                return nv;
            }

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "    Tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {

            if (ObjectNV() != null)
            {
                if (listNV.Find(s => s.MaNV == ObjectNV().MaNV) == null)
                {
                    TaiKhoan tgxx = qltk.TimkiemTK(txtTaiKhoan.Text);
                    if (tgxx == null)
                    {
                        TaiKhoan tg = new TaiKhoan();
                        tg.TaiKhoan1 = txtTaiKhoan.Text;
                        tg.MatKhau = txtMatKhau.Text;
                        tg.PhanQuyen = "Nhân Viên";
                        qltk.AddTaiKhoan(tg);
                        ql.AddNV(ObjectNV());
                        listNV.Add(ObjectNV());
                        LoadDataGridView();
                        MessageBox.Show("Thêm nhân viên thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản này đã tồn tại hãy nhập lại !");
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại hãy nhập lại !");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường dữ liệu của một nhân viên !");
            }
        }

        private void btnReplaceNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjectNV2() != null)
                {
                    if (listNV.Find(s => s.MaNV == ObjectNV2().MaNV) != null)
                    {
                        ql.Replace(ObjectNV2());
                        listNV.Remove(ObjectNV2());
                        listNV.Add(ObjectNV2());
                        MessageBox.Show("Sửa thành công !");
                        LoadDataGridView();

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên cần sửa!");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các trường dữ liệu của một nhân viên !");
                }
            }
            catch { MessageBox.Show("Có lỗi khi thực hiện chức năng này !"); }
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {

            NhanVien tg = new NhanVien();
            tg = listNV.Find(s => s.MaNV == txtMaNV.Text);
            if (tg != null)
            {
                string Tentkx = ql.GetTentk(txtMaNV.Text);
                if (!ql.KiemTraKhoaNgoai(txtMaNV.Text))
                {
                    listNV.Remove(tg);
                    ql.DeteleNV(tg);
                    qltk.DeleteTaiKhoan(Tentkx);
                    MessageBox.Show("Xóa thành công nhân viên này");
                    LoadDataGridView();

                }
                else
                {
                    MessageBox.Show("Không thể xóa một nhân viên có liên kết khóa ngoại đến bảng khác !: ", "Thông báo");
                }

            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên này");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtName.Text = "";
            txtSDT.Text = "";
            txtQueQuan.Text = "";
            txtEmail.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtMaNV.Focus();
            LoadDataGridView();
        }

        private void dtgrvHienThiListNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dtgrvHienThiListNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dtgrvHienThiListNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dtgrvHienThiListNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQueQuan.Text = dtgrvHienThiListNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dtgrvHienThiListNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện chức năng này !");
            }
        }
    }
}
