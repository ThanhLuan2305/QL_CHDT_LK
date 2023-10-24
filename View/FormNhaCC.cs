using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QL_DT_LK.Business;
using QL_DT_LK.DataAcsess;

namespace QL_DT_LK.View
{
    public partial class FormNhaCC : Form
    {
        NCCBUS ql = new NCCBUS();
        List<NhaCC> listNCC;
        public FormNhaCC()
        {
            InitializeComponent();
        }

        public bool CheckTextBox()
        {
            if (txtMaNhaCC.Text != "" && txtTenNhaCC.Text != "" && txtSDT.Text != "" && txtEmail.Text != "")
            {
                return true;
            }
            return false;
        }

        public NhaCC ObjectNCC()
        {
            NhaCC ncc = new NhaCC();
            if (CheckTextBox())
            {
                ncc.MaNCC = txtMaNhaCC.Text;
                ncc.TenNCC = txtTenNhaCC.Text;
                ncc.SDTLH = txtSDT.Text;
                ncc.Email = txtEmail.Text;

                return ncc;

            }
            else
            {
                ncc = null;
                return ncc;
            }

        }

        public void LoadDataGridView()
        {
            listNCC = ql.GetList();
            var TG = ql.GetList().Select(s => new { s.MaNCC, s.TenNCC, s.SDTLH, s.Email }).ToList();
            dtgrvHienThiListNCC.DataSource = TG;
        }

        private void FormNhaCC_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjectNCC() != null)
                {
                    if (listNCC.Find(s => s.MaNCC == ObjectNCC().MaNCC) == null)
                    {
                        ql.Add(ObjectNCC());
                        listNCC.Add(ObjectNCC());
                        LoadDataGridView();
                        MessageBox.Show("Thêm nhà cung cấp thành công");
                    }
                    else
                    {
                        MessageBox.Show("Nhà cung cấp này đã tồn tại vui lòng nhập lại !");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu của một nhà cung cấp !");
                }
            }
            catch { MessageBox.Show("Có lỗi khi thực hiện chức năng này !"); }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (ObjectNCC() != null)
            {
                if (listNCC.Find(s => s.MaNCC == ObjectNCC().MaNCC) != null)
                {
                    ql.Replace(ObjectNCC());
                    listNCC.Remove(ObjectNCC());
                    listNCC.Add(ObjectNCC());
                    MessageBox.Show("Sửa thành công !");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp cần sửa!");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường dữ liệu của một nhà cung cấp !");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCC tg = new NhaCC();
                tg = listNCC.Find(s => s.MaNCC == txtMaNhaCC.Text);
                if (tg != null)
                {
                    if (!ql.KiemTraKhoaNgoai(txtMaNhaCC.Text))
                    {
                        if (ql.Detele(tg))
                        {
                            listNCC.Remove(tg);
                            MessageBox.Show("Xóa thành công !");
                            LoadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhà cung cấp cần xóa!");
                        }
                    }
                    else { MessageBox.Show("Nhà cung cấp này đang là khóa ngoại của bảng khác nên không thế xóa vào bây giờ !"); }

                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp này");
                }
            }
            catch { MessageBox.Show("Có lỗi khi thực hiện chức năng này !"); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtMaNhaCC.Text = "";
            txtTenNhaCC.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtMaNhaCC.Focus();
            LoadDataGridView();
        }

        private void dtgrvHienThiListNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNhaCC.Text = dtgrvHienThiListNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNhaCC.Text = dtgrvHienThiListNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dtgrvHienThiListNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dtgrvHienThiListNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện chức năng này !");
            }
        }

    }
}
