using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Persistence;
using CarRentalApp.View.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class HomePageUserControl : UserControl
    {
        private readonly Random _rand = new Random();
        private readonly UnitOfWork _unitOfWork;

        public HomePageUserControl()
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
        }

        private void UpdateChartUi()
        {
            monthlyTakingChart.Series[0].Points.Clear();
            var months = Enumerable.Range(1, 12)
                .Select(i => new
                {
                    I = i,
                    M = DateTimeFormatInfo.CurrentInfo != null
                        ? DateTimeFormatInfo.CurrentInfo.GetMonthName(i)
                        : DateTimeFormatInfo.InvariantInfo.GetMonthName(i)
                }).ToList();
            foreach (var month in months)
            {
                var monthRentsCount = _rand.Next(0, 100);
                monthlyTakingChart.Series[0].Points.AddXY(month.M, monthRentsCount);
            }
        }

        private void UpdateIndicatorUi()
        {
//            var clientList = _unitOfWork.Clients.GetAll().Select(c => new {c.Id, c.FullName, RentCount = c.Rents.Count})
//                .ToList();
//            var top3Client = clientList.AsParallel().OrderByDescending(c => c.RentCount).Take(3).ToList();
//
//            var carList = _unitOfWork.Cars.GetAll().Select(c => new {c.Id, c.Name, RentCount = c.Rents.Count}).ToList();
//            var top3Cars = carList.AsParallel().OrderByDescending(c => c.RentCount).Take(3).ToList();
//
//            var userList = _unitOfWork.Users.GetAll().Select(u => new {u.Id, u.Username, RentCount = u.Rents.Count})
//                .ToList();
//            var top3User = userList.AsParallel().OrderByDescending(c => c.RentCount).Take(3).ToList();
//
//            top3ClientListBox.DataSource = top3Client;
//            top3CarListBox.DataSource = top3Cars;
//            top3EmployeeListBox.DataSource = top3User;
//
//            var rentsList = _unitOfWork.Rents.GetAll().ToList();
//            var rentsInPendingList = rentsList.AsParallel().Where(r => r.State == RentState.Pending).ToList();
//
//            rentsCountLabel.Text = rentsList.Count.ToString("N0");
//            rentsInPendingCountLabel.Text = rentsInPendingList.Count.ToString("N0");
//            clientsCountLabel.Text = clientList.Count.ToString("N0");
        }

        private void LoadingScreen()
        {
            for (var i = 0; i < 30; i++) Thread.Sleep(100);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateChartUi();
        }

        private void HomePageUserControl_Load(object sender, EventArgs e)
        {
            UpdateChartUi();
            using (var waitForm = new WaitForm(LoadingScreen))
            {
                waitForm.ShowDialog(this);
            }
            UpdateIndicatorUi();
        }
    }
}