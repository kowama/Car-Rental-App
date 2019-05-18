using CarRentalApp.Persistence;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.View.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class HomePageUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Random _rand = new Random();
        public HomePageUserControl()
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
        }

        private void UpdateChartUi()
        {
            monthlyTakingChart.Series[0].Points.Clear();
            var months = Enumerable.Range(1, 12)
                .Select(i => new {I = i, M = DateTimeFormatInfo.CurrentInfo?.GetMonthName(i)}).ToList();
            foreach (var month in months)
            {
                var monthRentsCount = _rand.Next(0, 100);
                monthlyTakingChart.Series[0].Points.AddXY(month.M, monthRentsCount);
            }
        }

        private void UpdateIndicatorUi()
        {
            try
            {

//                var clientList = _unitOfWork.Clients.GetAll().Select(c=> new {c.Id, c.FullName,RentCount = c.Rents.Count}).ToList();
//                var top3Client = clientList.OrderByDescending(c => c.RentCount).Take(3).ToList();
//
//                var carList = _unitOfWork.Cars.GetAll().Select(c => new { c.Id,c.Name, RentCount= c.Rents.Count }).ToList();
//                var top3Cars = carList.OrderByDescending(c => c.RentCount).Take(3).ToList();
//
//                var userList = _unitOfWork.Users.GetAll().Select(u => new { u.Id,u.Username ,RentCount =u.Rents.Count }).ToList();
//                var top3User = userList.OrderByDescending(c => c.RentCount).Take(3).ToList();
//
//                top3ClientListBox.DataSource = top3Client;
//                top3CarListBox.DataSource = top3Cars;
//                top3EmployeeListBox.DataSource = top3User;
//
//                var rentsList = _unitOfWork.Rents.GetAll().ToList();
//                var rentsInPendingList = rentsList.Where(r => r.State == RentState.Pending).ToList();
//
//                rentsCountLabel.Text = rentsList.Count.ToString("N0");
//                rentsInPendingCountLabel.Text = rentsInPendingList.Count.ToString("N0");
//                clientsCountLabel.Text = clientList.Count.ToString("N0");
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateChartUi();
        }

        private void HomePageUserControl_Load(object sender, EventArgs e)
        {
            UpdateChartUi();
            using (var waitForm = new WaitForm(UpdateIndicatorUi))
            {
                waitForm.ShowDialog(this);
            }

        }
    }
}
