using System;
using System.Drawing;
using System.Windows.Forms;

namespace SystemSmart
{
    public partial class MainForm : Form
    {

        private Timer timerClock;


        public MainForm()
        {
            InitializeComponent();

            Load += MainForm_Load;
            FormClosing += MainForm_FormClosing;

            btnAccounts.Click += btnAccounts_Click;
            btnTransfers.Click += btnTransfers_Click;
            btnCustomers.Click += btnCustomers_Click;
            btnExchange.Click += btnExchange_Click;
            btnSettings.Click += btnSettings_Click;

        }


        //==================================================
        // Form Load
        //==================================================

        private void MainForm_Load(object sender, EventArgs e)
        {

            InitializeClock();

            lblUser.Text =
                "User : Admin";

            lblDatabase.Text =
                "Database : Connected";

            lblBranch.Text =
                "Branch : Main";


        }



        //==================================================
        // Clock
        //==================================================

        private void InitializeClock()
        {

            timerClock = new Timer();

            timerClock.Interval = 1000;

            timerClock.Tick += TimerClock_Tick;

            timerClock.Start();

        }


        private void TimerClock_Tick(object sender, EventArgs e)
        {

            lblClock.Text =
                DateTime.Now.ToString("HH:mm:ss");

        }



        //==================================================
        // Buttons Events
        //==================================================


        private void btnAccounts_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "فتح شاشة الحسابات",
                "System Smart",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }



        private void btnTransfers_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "فتح شاشة التحويلات",
                "System Smart",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }



        private void btnCustomers_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "فتح شاشة العملاء",
                "System Smart",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }



        private void btnExchange_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "فتح شاشة الصرافة",
                "System Smart",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }



        private void btnSettings_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                "فتح الإعدادات",
                "System Smart",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }



        //==================================================
        // Form Closing
        //==================================================

        private void MainForm_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {

            if(timerClock != null)
            {
                timerClock.Stop();
                timerClock.Dispose();
            }


        }



    }
}
