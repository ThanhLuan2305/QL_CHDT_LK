using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DT_LK.Business;
using QL_DT_LK.Properties;

namespace QL_DT_LK.View
{
    public partial class FormSanPham : Form
    {
        SanPhamBUS ql = new SanPhamBUS();
        NCCBUS ncc = new NCCBUS();
        List<NhaCC> listncc;
        List<SanPham> listSP;
        private dynamic GetDSNCC()
        {
            listncc = ncc.GetList();
            var returnMaNCC = listncc.Select(s => s.MaNCC).ToList();
            return returnMaNCC;
        }
        private void LoadComboBoxNCC()
        {
            foreach (var x in GetDSNCC())
            {
                cbbNCC.Items.Add(x);
            }
        }
        public FormSanPham()
        {
            InitializeComponent();
        }
        public dynamic GetListSP()
        {
            listSP = ql.GetListSP().ToList();
            var ListSPNew = listSP.Select(p => new { p.MaSP, p.MaNCC, p.HangSP, p.TenSP, p.TheLoai, p.XuatXu, p.Giaban, p.HinhAnh }).ToList();
            return ListSPNew;
        }
        public void LoadDataGridView()
        {
            dtgrvHienThiListSP.DataSource = GetListSP();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LoadComboBoxNCC();
            LoadDataGridView();
        }
        public bool CheckTextBox()
        {
            if 
            (
                cbbNCC.Text != "  Chọn nhà cung cấp" &&
                cbbHangSP.Text != "  Chọn hãng sản phẩm" &&
                cbbXuatxu.Text != "  Chọn xuất xứ" &&
                cbbTheloai.Text != "Chọn thể loại" &&
                txtGiaBan.Text != ""
            )
            {
                return true;
            }
            return false;
        }
        public SanPham ObjectSP()
        {
            SanPham sp = new SanPham();
            if (CheckTextBox())
            {
                if (!string.IsNullOrEmpty(txtMaSP.Text))
                {
                    sp.MaSP = txtMaSP.Text;
                } else
                {
                    GenerateRandomString ramdom = new GenerateRandomString();
                    sp.MaSP = ramdom.RandomString(5);
                }
                sp.Giaban = float.Parse(txtGiaBan.Text);
                sp.MaNCC = cbbNCC.Text;
                sp.XuatXu = cbbXuatxu.Text;
                sp.TheLoai = cbbTheloai.Text;
                sp.HangSP = cbbHangSP.Text;
                sp.TenSP = txtTenSP.Text;
                return sp;
            }
            else
            {
                sp = null;
                return sp;
            }

        }
        public bool checkItemCombobox()
        {
            bool TestTG = false;

            foreach (var i in GetDSNCC())
            {
                if (cbbNCC.Text == i.ToString())
                {
                    TestTG = true;
                    break;
                }
            }

            return TestTG;

        }
        private void dtgrvHienThiListSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSP.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbbNCC.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbHangSP.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTenSP.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbbTheloai.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbbXuatxu.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtGiaBan.Text = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[6].Value.ToString();
                string TenAnh = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[7].Value?.ToString();
                if (!string.IsNullOrEmpty(TenAnh))
                {
                    Image image = Image.FromFile(@"..\..\Image\" + TenAnh);
                    PTB_SP.Image = image;
                } 


            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi thực hiện chức năng này !. Lỗi: " + ex);
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (ObjectSP() != null)
            {
                SanPham a = ObjectSP();
                if (checkItemCombobox())
                {
                    if (ql.AddSP(a))
                    {
                        listSP.Add(a);
                        LoadDataGridView();
                        MessageBox.Show("Thêm sản phẩm thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Mã sản phẩm này đã tồn tại !");
                    }


                }
                else
                {
                    MessageBox.Show("Chỉ chọn dữ liệu nhà cung cấp có trong cửa hàng !");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");
            }
        }

        private void btnReplaceNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjectSP() != null)
                {
                    if (checkItemCombobox())
                    {
                        if (ql.ReplaceSP(ObjectSP()))
                        {
                            LoadDataGridView();
                            MessageBox.Show("Sửa sản phẩm thành công !");
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm này không tồn tại !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chỉ chọn dữ liệu nhà cung cấp có trong cửa hàng !");
                    }
                }

                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin của 1 sản phẩm !");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi sửa sản phẩm !");
            }
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "")
            {
                if (!ql.KiemTraKhoaNgoai(txtMaSP.Text))
                {
                    if (ql.DeleteSP(ObjectSP().MaSP))
                    {
                        listSP.Remove(ObjectSP());
                        LoadDataGridView();
                        MessageBox.Show("Xóa sản phẩm thành công !");

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm cần xóa !");
                    }


                }
                else
                {
                    MessageBox.Show("Sản phẩm này đang là khóa ngoại của bảng khác nên không thể xóa vào lúc này !");
                }

            }
            else
            {

                MessageBox.Show("Vui lòng nhập mã sản phẩm cần xóa !");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cbbNCC.Text = "  Chọn nhà cung cấp";
            cbbHangSP.Text = "  Chọn hãng sản phẩm";
            cbbXuatxu.Text = "  Chọn xuất xứ";
            cbbTheloai.Text = "Chọn thể loại";
            txtGiaBan.Text = "";
            PTB_SP.Image = null;
            LoadDataGridView();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text != "")
                {
                    List<SanPham> list = ql.Insert(txtTimKiem.Text);
                    if (list.Count > 0)
                    {
                        var listTG = list.Select(p => new { p.MaSP, p.MaNCC, p.HangSP, p.TenSP, p.TheLoai, p.XuatXu, p.Giaban });
                        dtgrvHienThiListSP.DataSource = listTG.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm nào !");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập từ khóa để tìm kiếm !");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi tìm kiếm sản phẩm !");
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "    Tìm kiếm";
                txtTimKiem.ForeColor = Color.DarkGray;

            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "    Tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
