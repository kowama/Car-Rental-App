using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp.View.Forms
{
    public partial class WaitForm : Form
    {
        public WaitForm(Action worker)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException(nameof(worker));
            progressBar.Value = 0;
        }

        public Action Worker { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            timer.Start();
            Task.Factory.StartNew(Worker)
                .ContinueWith(t =>
                {
                    timer.Dispose();
                    Close();
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(progressBar.Value < 100)
                progressBar.Value += 5;

        }
    }
}