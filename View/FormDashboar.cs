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
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            QLPKDTEntities db = new QLPKDTEntities();
            dtgrvNhanVienDoanhThu.DataSource = db.GetEmployeeOrderStatistics().ToList();
        }

        private void FormDashboar_Load(object sender, EventArgs e)
        {
            SanPhamBUS qlSanPham = new SanPhamBUS();
            label2.Text = qlSanPham.GetListSP().Count.ToString();
            PopulateChart();
        }

        private void PopulateChart()
        {
            DSDonHangDAL tk = new DSDonHangDAL();

            var TonDonHang = tk.GetRecentDonHang();

            label1.Text = (TonDonHang.Count).ToString();
            QLPKDTEntities db = new QLPKDTEntities();
            var donHangData = db.GetLast7DaysOrderTotal().ToList();

            chart1.Series.Clear();

            Series series = chart1.Series.Add("Thu nhập");
            series.ChartType = SeriesChartType.Spline;

            for (int i = 0; i < donHangData.Count; i++)
            {
                if (donHangData[i].NgayMua != null && donHangData[i].TongTien != null)
                {
                    series.Points.AddXY(donHangData[i].NgayMua, donHangData[i].TongTien);
                }
            }

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            series.BorderWidth = 2;
            series.Color = System.Drawing.Color.Red;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;

            chart1.Invalidate();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
