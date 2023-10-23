﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DT_LK.Business;

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
            var ListSPNew = listSP.Select(p => new { p.MaSP, p.MaNCC, p.HangSP, p.TenSP, p.TheLoai, p.XuatXu, p.Giaban }).ToList();
            return ListSPNew;

        }
        public void LoadDataGridView()
        {
            dtgrvHienThiListSP.DataSource = GetListSP();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {

        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LoadComboBoxNCC();
            LoadDataGridView();
        }
        public bool CheckTextBox()
        {
            if (txtMaSP.Text != "" &&
                cbbNCC.Text != "  Chọn nhà cung cấp" &&
                 cbbHangSP.Text != "  Chọn hãng sản phẩm" &&
                  cbbXuatxu.Text != "  Chọn xuất xứ" &&
                  cbbTheloai.Text != "Chọn thể loại" &&
                  txtGiaBan.Text != "")
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
                sp.MaSP = txtMaSP.Text;
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

            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện chức năng này !");
            }
        }
    }
}
