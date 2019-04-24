using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.DataViz;

namespace CarRentalApp.View.UserControls
{
    public partial class HomePageUserControl : UserControl
    {
        private readonly Random _rand = new Random();
        public HomePageUserControl()
        {
            InitializeComponent();
        }

        private void LoadWeeklyChart()
        {
            var canvas = new Canvas();
            var dataPoint = new DataPoint(BunifuDataViz._type.Bunifu_splineArea);
            dataPoint.addLabely("JAN",_rand.Next(0,500).ToString());
            dataPoint.addLabely("FEB",_rand.Next(0,500).ToString());
            dataPoint.addLabely("MAR",_rand.Next(0,500).ToString());
            dataPoint.addLabely("APR",_rand.Next(0,500).ToString());
            dataPoint.addLabely("MAY",_rand.Next(0,500).ToString());
            dataPoint.addLabely("JUN",_rand.Next(0,500).ToString());
            dataPoint.addLabely("JUL",_rand.Next(0,500).ToString());
            dataPoint.addLabely("AUG",_rand.Next(0,500).ToString());
            dataPoint.addLabely("SEPT",_rand.Next(0,500).ToString());
            dataPoint.addLabely("OCT",_rand.Next(0,500).ToString());

            canvas.addData(dataPoint);
            reportChartDataViz.colorSet.Add(Color.Coral);
            reportChartDataViz.Render(canvas);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadWeeklyChart();
        }
    }
}
