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
    public partial class FormThongKe : Form
    {
        ThongkeDAL tk = new ThongkeDAL();
        public FormThongKe()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            dtgrvHienThiListALLDH.DataSource = tk.GetAllDonHang();
        }
        public double TinhTong()
        {
            double tong = 0;
            foreach (DataGridViewRow row in dtgrvHienThiListALLDH.Rows)
            {
                double values = double.Parse(row.Cells[5].Value.ToString());
                tong = tong + values;
            }
            return tong;
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "  Tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "  Tìm kiếm";
                txtTimKiem.ForeColor = Color.DarkGray;
                LoadDataGridView();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "  Tìm kiếm" || txtTimKiem.Text != "")
            {
                List<dynamic> TG = tk.Timkiem(txtTimKiem.Text);
                if (TG.Count > 0)
                {
                    dtgrvHienThiListALLDH.DataSource = TG;

                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn hàng nào !", "Thông báo");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm !", "Thông báo");
            }
        }
        public class Chitiet1DH
        {
            static public DonHang dh;
            static public List<ObjectSP> listsp;
        }

        private void dtgrvHienThiListALLDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgrvHienThiListALLDH.SelectedRows.Count > 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow selectedRow = dtgrvHienThiListALLDH.SelectedRows[0];

                // Kiểm tra xem có đủ số cột không
                if (selectedRow.Cells.Count > 1)
                {
                    btnXemchitiet.Visible = true;
                    // Lấy dữ liệu của cột thứ 2
                    string MaDH = selectedRow.Cells[0].Value.ToString();
                    Chitiet1DH.dh = tk.GetThongTin1Donhang(MaDH);
                    Chitiet1DH.listsp = tk.GetListSPmua(MaDH);



                }
            }
        }

        private void dtgrvHienThiListALLDH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgrvHienThiListALLDH.CurrentCell = null;
        }
        private void btnXemchitiet_Click(object sender, EventArgs e)
        {
            FormChiTietDH a = new FormChiTietDH(Chitiet1DH.dh, Chitiet1DH.listsp);
            a.ShowDialog();
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            XuatExcel a = new XuatExcel();
            string[] listcoLuml = { "Mã ĐH", "Tên KH", "Địa chỉ", "Ngày mua", "Mã NV", "Tồng hóa đơn" };
            a.ExportToExcel(dtgrvHienThiListALLDH, "Danh sách tất cả đơn hàng tại quán", listcoLuml, "danhsachdonhang");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
