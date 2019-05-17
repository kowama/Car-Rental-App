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
        }

        public Action Worker { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker)
                .ContinueWith(t => { Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}