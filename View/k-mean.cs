using QL_DT_LK.Business;
using QL_DT_LK.k_mean;
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
    public partial class k_mean : Form
    {
        /// <summary>
        /// Finished the iteration
        /// </summary>
        private bool isFinished;

        /// <summary>
        /// Number of iteration
        /// </summary>
        private int iterationNumber;

        /// <summary>
        /// List of DataPoint objects
        /// </summary>
        private List<DataPoint> listDataPoint;

        /// <summary>
        /// List of Cluster objects
        /// </summary>
        private List<Cluster> listCluster;

        /// <summary>
        /// List of DataPointLimit objects
        /// </summary>
        private List<DPLimit> listDPLimit;

        /// <summary>
        /// Color list for cluster repsresenting color
        /// </summary>
        private List<Color> listColor;

        /// <summary>
        /// Number of DataPoints
        /// </summary>
        private long numberOfDataPoints;

        /// <summary>
        /// Number of Clusters
        /// </summary>
        private long numberOfClusters;

        /// <summary>
        /// Random Type of Generation DataPoints
        /// </summary>
        private int randType;

        /// <summary>
        /// enum Random Type of Generation DataPoints
        /// </summary>
        private enum RANDOMTYPE_DP
        {
            Random = 1,
            GoodRandom = 2
        }

        #region Constructor
        /// <summary>
        /// Main Form
        /// </summary>
        public k_mean()
        {
            InitializeComponent();

            InitializeVariables();
        }

        #endregion

        #region Functional Methods

        /// <summary>
        /// Initilaize the initial variables for program
        /// </summary>
        private void InitializeVariables()
        {
            // Set number of DataPoints
            numberOfDataPoints = 1000;

            // Set number of Clusters
            numberOfClusters = 4;

            // Set randType to default
            randType = (int)RANDOMTYPE_DP.Random;

            // Create lists
            listCluster = new List<Cluster>();
            listDataPoint = new List<DataPoint>();
            listDPLimit = new List<DPLimit>();

            // Create list of color and add colors to it
            listColor = new List<Color>();
            listColor.Add(System.Drawing.Color.Yellow);
            listColor.Add(System.Drawing.Color.Red);
            listColor.Add(System.Drawing.Color.Black);
            listColor.Add(System.Drawing.Color.Blue);
            listColor.Add(System.Drawing.Color.Gray);
            listColor.Add(System.Drawing.Color.Orange);
            listColor.Add(System.Drawing.Color.Navy);
            listColor.Add(System.Drawing.Color.Pink);
            listColor.Add(System.Drawing.Color.Azure);
            listColor.Add(System.Drawing.Color.Chocolate);
            listColor.Add(System.Drawing.Color.SteelBlue);

            // Create DataPoints
            CreateDataPoints();
        }

        public class Product
        {
            public string TenSanPham { get; set; }
            public string HangSanPham { get; set; }
            public string XuatXu { get; set; }
            public double GiaBan { get; set; }
            public string TheLoai { get; set; }
        }


        /// <summary>
        /// Creates data points
        /// </summary>
        /// 
        static int HashStringToInt(string input)
        {
            int hash = 17; // Giá trị ban đầu
            foreach (char c in input)
            {
                hash = hash * 31 + c; // 31 là một số nguyên tố thường được sử dụng trong hàm băm
            }
            return hash % 500;
        }
        List<SanPham> listSP;
        SanPhamBUS ql = new SanPhamBUS();

        public dynamic GetListSP()
        {
            listSP = ql.GetListSP().ToList();
            var ListSPNew = listSP.Select(p => new { p.MaSP, p.MaNCC, p.HangSP, p.TenSP, p.TheLoai, p.XuatXu, p.Giaban, p.HinhAnh }).ToList();
            return ListSPNew;
        }
        private void CreateDataPoints()
        {
            GetListSP();
            // Recreate lists for reset
            listDataPoint = new List<DataPoint>();
            listCluster = new List<Cluster>();
            listDPLimit = new List<DPLimit>();

            // Check randomtype and create datapoints for randtype
            for (int i = 0; i < listSP.Count(); i++)
            {
                int xPoint = (int)listSP[i].Giaban;
                int yPoint = HashStringToInt(listSP[i].HangSP);

                DataPoint dataPoint = new DataPoint(i + 1, xPoint, yPoint, null);
                listDataPoint.Add(dataPoint);
            }
        }

        /// <summary>
        /// Create clusters with improving
        /// </summary>
        private void CreateClustersWithImproving()
        {
            // Recreate list of cluster for reset
            listCluster = new List<Cluster>();

            // Starting point of space
            int XCenter = 0;
            int YCenter = 0;

            // Calculate distance of each datapoint and keep
            foreach (DataPoint dataPoint in listDataPoint)
            {
                int xdis = (dataPoint.XPoint - XCenter);
                int ydis = (dataPoint.YPoint - YCenter);
                int tot = (xdis * xdis + ydis * ydis);
                double distance = Math.Sqrt(tot);
                dataPoint.Distace = distance;
            }

            // Sort datapoints using distance
            for (int i = 0; i < listDataPoint.Count; i++)
            {
                for (int j = 0; j < listDataPoint.Count - 1; j++)
                {
                    if (listDataPoint[j].Distace > listDataPoint[j + 1].Distace)
                    {
                        DataPoint tempDP = listDataPoint[j];
                        listDataPoint[j] = listDataPoint[j + 1];
                        listDataPoint[j + 1] = tempDP;
                    }
                }
            }


            // Create clusters for dividing cluster number to datapoint list
            // and choose middle datapoint x,y coordinates for ecah cluster center
            for (int i = 0; i < numberOfClusters; i++)
            {
                int index = Convert.ToInt16(listDataPoint.Count / (numberOfClusters * 2) * (2 * i + 1));
                int xPoint = listDataPoint[index].XPoint;
                int yPoint = listDataPoint[index].YPoint;

                // Create cluster and add to list
                Cluster cluster = new Cluster(i + 1, xPoint, yPoint, listColor[i]);
                listCluster.Add(cluster);
            }
        }

        /// <summary>
        /// Create cluster (Default Algorithm)
        /// </summary>
        private void CreateClusters()
        {
            // Recreate list of cluster for reset
            listCluster = new List<Cluster>();
            Random rand = new Random();

            // Create clusters and add to list
            for (int i = 0; i < numberOfClusters; i++)
            {
                int xPoint = rand.Next(panel1.Size.Width);
                int yPoint = rand.Next(panel1.Size.Height);

                Cluster cluster = new Cluster(i + 1, xPoint, yPoint, listColor[i]);
                listCluster.Add(cluster);
            }
        }

        /// <summary>
        /// Paints datapoints and clusters in panel
        /// </summary>
        private void PaintInPanel()
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = panel1.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Red, 5);

            // Draw datapoints
            foreach (DataPoint dataPoint in listDataPoint)
            {
                if (dataPoint.Cluster != null)
                {
                    myPen.Color = dataPoint.Cluster.ColorOfPoint;
                }

                Rectangle rect = new Rectangle(dataPoint.XPoint, dataPoint.YPoint, 1, 1);
                graphicsObj.DrawEllipse(myPen, rect);
            }

            // Draw clusters
            foreach (Cluster cluster in listCluster)
            {
                Rectangle rect = new Rectangle(cluster.XPoint, cluster.YPoint, 10, 10);
                myPen.Color = cluster.ColorOfPoint;
                graphicsObj.DrawRectangle(myPen, rect);
            }
        }

        /// <summary>
        /// Reset datapoints and remove clusters
        /// </summary>
        private void Reset()
        {
            CreateDataPoints();

            // redraw
            panel1.Invalidate();
        }

        /// <summary>
        /// Initialize clusters
        /// </summary>
        private void InitializeCluster()
        {
            // Set iteration number to 0
            iterationNumber = 0;

            numberOfClusters = Convert.ToInt64(tfNumberOfCluster.Text);

            // Create clusters
            CreateClusters();

            //Assigns datapoints to clusters randomly
            SetClustersOfDataPointsRandomly();

            // redraw
            panel1.Invalidate();
        }

        /// <summary>
        /// Assigns datapoints to clusters randomly
        /// </summary>
        private void SetClustersOfDataPointsRandomly()
        {
            // Set clusters of datapoints randomly
            Random rand = new Random();
            foreach (DataPoint dataPoint in listDataPoint)
            {
                dataPoint.Cluster = listCluster[rand.Next((int)numberOfClusters)];
            }
        }

        /// <summary>
        /// Initializes clusters with improving
        /// </summary>
        private void InitializeClusterWithImproving()
        {
            numberOfClusters = Convert.ToInt64(tfNumberOfCluster.Text);

            CreateClustersWithImproving();

            SetClustersOfDataPointsRandomly();
        }

        /// <summary>
        /// Assigns datapoints to closest clusters
        /// </summary>
        private void AssignDataPointsToCloserCluster()
        {
            iterationNumber++;
            foreach (DataPoint dataPoint in listDataPoint)
            {
                Cluster nearestCluster = null;
                double distance = 999999999999;
                foreach (Cluster cluster in listCluster)
                {
                    double tempDistance = GetDistance(dataPoint, cluster);
                    if (tempDistance < distance)
                    {
                        nearestCluster = cluster;
                        distance = tempDistance;
                    }
                }
                dataPoint.Cluster = nearestCluster;
            }


            // redraw
            panel1.Invalidate();
        }

        /// <summary>
        /// Calculates center of clusters
        /// </summary>
        private void CalculateCenterOfEachCluster()
        {
            foreach (DataPoint dataPoint in listDataPoint)
            {
                dataPoint.Cluster.XTotal += dataPoint.XPoint;
                dataPoint.Cluster.YTotal += dataPoint.YPoint;

                dataPoint.Cluster.TotalDataPoints++;
            }

            bool isSame = true;
            foreach (Cluster cluster in listCluster)
            {
                if (cluster.TotalDataPoints > 0)
                {
                    cluster.setXPoint(Convert.ToInt16(cluster.XTotal / cluster.TotalDataPoints));
                    cluster.setYPoint(Convert.ToInt16(cluster.YTotal / cluster.TotalDataPoints));

                    if (!(cluster.XPoint == cluster.OldXPoint &&
                        cluster.YPoint == cluster.OldYPoint &&
                        cluster.OldTotalDataPoints == cluster.OldTotalDataPoints))
                    {
                        isSame = false;
                    }

                    cluster.SetToDefaultTotal();
                }
            }

            if (isSame)
            {
                isFinished = true;
                string msg = "Hoành thành" + Environment.NewLine;

                foreach (Cluster cluster in listCluster)
                {
                    msg += "Khu vực" + cluster.Number + "(" + cluster.ColorOfPoint.ToString() + ")" +
                        " = " + cluster.OldTotalDataPoints.ToString() + "điểm dữ liệu" + Environment.NewLine;
                }

                msg += "Số lần lặp : " + iterationNumber.ToString();
                MessageBox.Show(msg);
            }


            // redraw
            panel1.Invalidate();
        }

        /// <summary>
        /// Returns distance of datapoint and cluster
        /// </summary>
        /// <param name="dataPoint">datapoint</param>
        /// <param name="cluster">cluster</param>
        /// <returns></returns>
        private double GetDistance(DataPoint dataPoint, Cluster cluster)
        {
            int xdis = (dataPoint.XPoint - cluster.XPoint);
            int ydis = (dataPoint.YPoint - cluster.YPoint);
            int tot = (xdis * xdis + ydis * ydis);
            double distance = Math.Sqrt(tot);

            return distance;
        }

        /// <summary>
        /// Find the result by iteration all iteration
        /// </summary>
        private void FintTheResult()
        {
            isFinished = false;
            while (!isFinished)
            {
                AssignDataPointsToCloserCluster();
                CalculateCenterOfEachCluster();
            }
        }

        #endregion

        #region Button Actions

        /// <summary>
        /// Paint Action of Panel1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PaintInPanel();
        }

        /// <summary>
        /// Reset button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            //CreateDataPointsFromYourData();
        }

        /// <summary>
        /// Initialize Cluster button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInitializeCluster_Click(object sender, EventArgs e)
        {
            // Initilialize clusters
            InitializeCluster();
        }

        /// <summary>
        /// Iterate button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIterate_Click(object sender, EventArgs e)
        {
            AssignDataPointsToCloserCluster();
        }

        /// <summary>
        /// Calculate Center Of Each Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateCenterOfEachCluster_Click(object sender, EventArgs e)
        {
            CalculateCenterOfEachCluster();
        }

        /// <summary>
        /// Find the result button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindTheResult_Click(object sender, EventArgs e)
        {
            FintTheResult();
        }

        /// <summary>
        /// Initialize Cluster With Improving Button Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInitializeClusterWithImproving_Click(object sender, EventArgs e)
        {
            iterationNumber = 0;

            InitializeClusterWithImproving();

            // redraw
            panel1.Invalidate();
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbGoodRandom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tfNumberOfCluster_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tfNumberOfDataPoints_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
