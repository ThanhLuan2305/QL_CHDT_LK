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
    public partial class FormNhapHang : Form
    {
        SanPhamBUS qlsp = new SanPhamBUS();
        KhoHangBUS qlkh = new KhoHangBUS();
        List<KhoHang> ListKH;
        List<SanPham> listSP;
        public List<KhoHang> GetlistKhoHang()
        {
            ListKH = qlkh.GetAllSP();
            return ListKH;

        }
        public dynamic GetDSSP()
        {
            listSP = qlsp.GetListSP().ToList();
            var ListSPNew = listSP.Select(p => new { p.MaSP, p.MaNCC, p.HangSP, p.TenSP, p.TheLoai, p.XuatXu, p.Giaban }).ToList();
            return ListSPNew;
        }
        public void LoadDataGridView()
        {
            dtgrvHienThiListSP.DataSource = GetDSSP();
        }
        public FormNhapHang()
        {
            InitializeComponent();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string MaSPNew, TenSP;
        private void dtgrvHienThiListSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgrvHienThiListSP.Rows[e.RowIndex].Selected = true;
                MaSPNew = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                TenSP = dtgrvHienThiListSP.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void txtSoluong_Enter(object sender, EventArgs e)
        {
            if (txtSoluong.Text == "Số lượng")
            {
                txtSoluong.Text = "";
                txtSoluong.ForeColor = Color.Black;
            }
        }

        private void txtSoluong_Leave(object sender, EventArgs e)
        {
            if (txtSoluong.Text == "")
            {
                txtSoluong.Text = "Số lượng";
                txtSoluong.ForeColor = Color.Gray;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (dtgrvHienThiListSP.SelectedRows.Count > 0)
            {
                if (txtSoluong.Text != "Số lượng")
                {
                    try
                    {
                        ListKH = qlkh.GetAllSP();
                        if (ListKH.Find(s => s.MaSP == MaSPNew) == null)
                        {
                            KhoHang spneww = new KhoHang();
                            spneww.MaSP = MaSPNew;
                            spneww.TenSP = TenSP;
                            spneww.Soluong = int.Parse(txtSoluong.Text);
                            spneww.NgayNhap = DateTime.Now.Date;
                            qlkh.AddSanPham(spneww);

                            MessageBox.Show($"Nhập hàng thành công với {MaSPNew} có số lượng là {txtSoluong.Text}");
                        }
                        if (ListKH.Find(s => s.MaSP == MaSPNew) != null)
                        {
                            KhoHang spneww = new KhoHang();
                            spneww.MaSP = MaSPNew;
                            spneww.TenSP = TenSP;
                            spneww.Soluong = int.Parse(txtSoluong.Text);
                            spneww.NgayNhap = DateTime.Now.Date;
                            qlkh.UpdateKhoHang(spneww);

                            MessageBox.Show($"Sản phẩm này đã có trong kho hàng nên sẽ cập nhật số lượng và ngày nhập với {MaSPNew} thêm số lượng là  {txtSoluong.Text}");
                        }
                    }
                    catch { MessageBox.Show("Số lượng phải là số kiểu !", "Thông báo"); }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng nhập");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần nhập !", "Thông báo");
            }
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }


        private void dtgrvHienThiListSP_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgrvHienThiListSP.CurrentCell = null;
        }
    }
}
