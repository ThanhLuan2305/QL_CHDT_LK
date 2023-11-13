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
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_DT_LK.View
{
    public partial class FormDashboar : Form
    {
        public FormDashboar()
        {
            InitializeComponent();
        }

        private void FormDashboar_Load(object sender, EventArgs e)
        {
            NhanVienBUS qlNhanVien = new NhanVienBUS();
            SanPhamBUS qlSanPham = new SanPhamBUS();
            labelSumNhanVien.Text = qlNhanVien.GetListNV().Count.ToString();
            label2.Text = qlSanPham.GetListSP().Count.ToString();
            PopulateChart();
        }

        private void Query()
        {
           
        }

        private void PopulateChart()
        {
            DSDonHangDAL tk = new DSDonHangDAL();

            var donHangData = tk.GetRecentDonHang();

            label1.Text =(donHangData.Count).ToString();

            Series series = chart1.Series.Add("Đơn hàng được đặt");
            series.ChartType = SeriesChartType.Spline;

            for (int i = 0; i < donHangData.Count; i++)
            {
                series.Points.AddXY(donHangData[i].NgayMua.ToShortDateString(), donHangData[i].tongtien);
            }

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            series.BorderWidth = 2;
            series.Color = System.Drawing.Color.Red;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;

            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();
            for (int i = 0; i < donHangData.Count; i++)
            {
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(i + 0.5, i + 1.5, donHangData[i].NgayMua.ToShortDateString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
