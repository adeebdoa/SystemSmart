namespace SystemSmart
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        #region Designer

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.StatusStrip statusMain;

        private System.Windows.Forms.ToolStripStatusLabel lblDatabase;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblBranch;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlWorkspace;

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picBackground;

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblClock;

        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnTransfers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Button btnSettings;

        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuGeneral;
        private System.Windows.Forms.ToolStripMenuItem mnuSecurity;
        private System.Windows.Forms.ToolStripMenuItem mnuAccounts;
        private System.Windows.Forms.ToolStripMenuItem mnuTransfers;
        private System.Windows.Forms.ToolStripMenuItem mnuNetwork;
        private System.Windows.Forms.ToolStripMenuItem mnuSales;
        private System.Windows.Forms.ToolStripMenuItem mnuManagement;
        private System.Windows.Forms.ToolStripMenuItem mnuCentralBank;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.statusMain = new System.Windows.Forms.StatusStrip();

            this.lblDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBranch = new System.Windows.Forms.ToolStripStatusLabel();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlWorkspace = new System.Windows.Forms.Panel();

            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();

            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();

            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnTransfers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();

            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransfers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCentralBank = new System.Windows.Forms.ToolStripMenuItem();

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();

            this.SuspendLayout();

            //==================================================
            // MainForm
            //==================================================

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366,768);
            this.Name = "MainForm";
            this.Text = "System Smart ERP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI",9F);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.DoubleBuffered = true;

            //==================================================
            // Header
            //==================================================

            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 42;
            this.pnlHeader.BackColor =
                System.Drawing.Color.FromArgb(0,110,0);

            //==================================================
            // Left Panel
            //==================================================

            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 72;
            this.pnlLeft.BackColor =
                System.Drawing.Color.Gainsboro;

            //==================================================
            // Workspace
            //==================================================

            this.pnlWorkspace.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.pnlWorkspace.BackColor =
                System.Drawing.Color.WhiteSmoke;            //==================================================
            // Logo
            //==================================================

            this.picLogo.Location =
                new System.Drawing.Point(10, 5);

            this.picLogo.Size =
                new System.Drawing.Size(32, 32);

            this.picLogo.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.picLogo.BackColor =
                System.Drawing.Color.Transparent;


            //==================================================
            // Background
            //==================================================

            this.picBackground.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.picBackground.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.picBackground.BackColor =
                System.Drawing.Color.WhiteSmoke;


            //==================================================
            // Welcome Label
            //==================================================

            this.lblWelcome.AutoSize = true;

            this.lblWelcome.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    14F,
                    System.Drawing.FontStyle.Bold);

            this.lblWelcome.ForeColor =
                System.Drawing.Color.White;

            this.lblWelcome.Location =
                new System.Drawing.Point(60,8);

            this.lblWelcome.Text =
                "مرحباً بك في نظام System Smart";


            //==================================================
            // Clock Label
            //==================================================

            this.lblClock.AutoSize = true;

            this.lblClock.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblClock.ForeColor =
                System.Drawing.Color.White;

            this.lblClock.Location =
                new System.Drawing.Point(300,12);

            this.lblClock.Text =
                "00:00:00";


            //==================================================
            // Buttons
            //==================================================

            this.btnAccounts.Text =
                "الحسابات";

            this.btnAccounts.Size =
                new System.Drawing.Size(65,55);

            this.btnAccounts.Location =
                new System.Drawing.Point(3,10);

            this.btnAccounts.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnAccounts.BackColor =
                System.Drawing.Color.White;

            this.btnAccounts.Cursor =
                System.Windows.Forms.Cursors.Hand;



            this.btnTransfers.Text =
                "التحويلات";

            this.btnTransfers.Size =
                new System.Drawing.Size(65,55);

            this.btnTransfers.Location =
                new System.Drawing.Point(3,75);

            this.btnTransfers.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnTransfers.BackColor =
                System.Drawing.Color.White;



            this.btnCustomers.Text =
                "العملاء";

            this.btnCustomers.Size =
                new System.Drawing.Size(65,55);

            this.btnCustomers.Location =
                new System.Drawing.Point(3,140);

            this.btnCustomers.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCustomers.BackColor =
                System.Drawing.Color.White;



            this.btnExchange.Text =
                "الصرافة";

            this.btnExchange.Size =
                new System.Drawing.Size(65,55);

            this.btnExchange.Location =
                new System.Drawing.Point(3,205);

            this.btnExchange.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnExchange.BackColor =
                System.Drawing.Color.White;



            this.btnSettings.Text =
                "إعدادات";

            this.btnSettings.Size =
                new System.Drawing.Size(65,55);

            this.btnSettings.Location =
                new System.Drawing.Point(3,270);

            this.btnSettings.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnSettings.BackColor =
                System.Drawing.Color.White;


            //==================================================
            // Menu
            //==================================================

            this.menuMain.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.mnuFile.Text =
                "ملف";

            this.mnuTools.Text =
                "أدوات";

            this.mnuGeneral.Text =
                "عام";

            this.mnuSecurity.Text =
                "الأمان";

            this.mnuAccounts.Text =
                "الحسابات";

            this.mnuTransfers.Text =
                "التحويلات";

            this.mnuNetwork.Text =
                "الشبكات";

            this.mnuSales.Text =
                "المبيعات";

            this.mnuManagement.Text =
                "الإدارة";

            this.mnuCentralBank.Text =
                "البنك المركزي";


            this.menuMain.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.mnuFile,
                    this.mnuTools,
                    this.mnuManagement
                });


            //==================================================
            // Status Bar
            //==================================================

            this.statusMain.Dock =
                System.Windows.Forms.DockStyle.Bottom;


            this.lblDatabase.Text =
                "Database : Connected";


            this.lblUser.Text =
                "User : Admin";


            this.lblBranch.Text =
                "Branch : Main";


            this.statusMain.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.lblDatabase,
                    this.lblUser,
                    this.lblBranch
                });


            //==================================================
            // Add Controls
            //==================================================

            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.lblClock);


            this.pnlLeft.Controls.Add(this.btnAccounts);
            this.pnlLeft.Controls.Add(this.btnTransfers);
            this.pnlLeft.Controls.Add(this.btnCustomers);
            this.pnlLeft.Controls.Add(this.btnExchange);
            this.pnlLeft.Controls.Add(this.btnSettings);


            this.pnlWorkspace.Controls.Add(
                this.picBackground);


            this.Controls.Add(
                this.pnlWorkspace);

            this.Controls.Add(
                this.pnlLeft);

            this.Controls.Add(
                this.pnlHeader);

            this.Controls.Add(
                this.statusMain);

            this.Controls.Add(
                this.menuMain);


            ((System.ComponentModel.ISupportInitialize)
                (this.picLogo)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.picBackground)).EndInit();


            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
