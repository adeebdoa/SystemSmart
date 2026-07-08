
namespace SystemSmart
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picUser;

        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyright;

        private System.Windows.Forms.GroupBox grpLogin;

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblLanguage;

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbLanguage;

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.ToolTip toolTip1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();

            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();

            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();

            this.grpLogin = new System.Windows.Forms.GroupBox();

            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();

            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();

            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();

            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.grpLogin.SuspendLayout();

            this.SuspendLayout();

            //==========================
            // LoginForm
            //==========================

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(980,560);

            this.MinimumSize = new System.Drawing.Size(980,560);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Name = "LoginForm";

            this.Text = "SystemSmart - تسجيل الدخول";

            this.BackColor = System.Drawing.Color.White;

            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            this.RightToLeftLayout = true;

            this.Font = new System.Drawing.Font("Segoe UI",9F);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.MinimizeBox = false;

            this.ShowIcon = true;

            this.ShowInTaskbar = true;

            this.AcceptButton = this.btnLogin;

            this.CancelButton = this.btnCancel;

            this.DoubleBuffered = true;

            this.KeyPreview = true;

            //==========================
            // pnlHeader
            //==========================

            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;

            this.pnlHeader.Height = 120;

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(180,35,35);

            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //==========================
            // pnlMain
            //==========================

            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;

            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;

            //==========================
            // pnlFooter
            //==========================

            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;

            this.pnlFooter.Height = 28;

            this.pnlFooter.BackColor = System.Drawing.Color.Gainsboro;
          //==========================
// picLogo
//==========================

this.picLogo.Location = new System.Drawing.Point(20, 10);
this.picLogo.Name = "picLogo";
this.picLogo.Size = new System.Drawing.Size(180, 100);
this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
this.picLogo.TabStop = false;

// ضع الصورة لاحقاً
// this.picLogo.Image = global::SystemSmart.Properties.Resources.Logo;

//==========================
// lblSystemName
//==========================

this.lblSystemName.AutoSize = true;
this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
this.lblSystemName.ForeColor = System.Drawing.Color.White;
this.lblSystemName.Location = new System.Drawing.Point(670,18);
this.lblSystemName.Name = "lblSystemName";
this.lblSystemName.Size = new System.Drawing.Size(250,35);
this.lblSystemName.Text = "System Smart ERP";

//==========================
// lblVersion
//==========================

this.lblVersion.AutoSize = true;
this.lblVersion.Font = new System.Drawing.Font("Segoe UI",9F);
this.lblVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
this.lblVersion.Location = new System.Drawing.Point(760,60);
this.lblVersion.Name = "lblVersion";
this.lblVersion.Text = "Version 1.0";

//==========================
// lblCopyright
//==========================

this.lblCopyright.AutoSize = true;
this.lblCopyright.ForeColor = System.Drawing.Color.White;
this.lblCopyright.Font = new System.Drawing.Font("Segoe UI",8F);
this.lblCopyright.Location = new System.Drawing.Point(600,85);
this.lblCopyright.Size = new System.Drawing.Size(0,0);
this.lblCopyright.Text =
"جميع الحقوق محفوظة © 2026\r\nSystem Smart";

//==========================
// GroupBox
//==========================

this.grpLogin.Location = new System.Drawing.Point(280,150);
this.grpLogin.Name = "grpLogin";
this.grpLogin.Size = new System.Drawing.Size(650,320);
this.grpLogin.TabStop = false;
this.grpLogin.Text = "بيانات تسجيل الدخول";
this.grpLogin.Font = new System.Drawing.Font("Segoe UI",10F,System.Drawing.FontStyle.Bold);

//==========================
// picUser
//==========================

this.picUser.Location = new System.Drawing.Point(35,40);
this.picUser.Name = "picUser";
this.picUser.Size = new System.Drawing.Size(120,120);
this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
this.picUser.TabStop = false;

// this.picUser.Image = global::SystemSmart.Properties.Resources.User;

//==========================
// lblUserName
//==========================

this.lblUserName.AutoSize = true;
this.lblUserName.Font = new System.Drawing.Font("Segoe UI",10F,System.Drawing.FontStyle.Bold);
this.lblUserName.Location = new System.Drawing.Point(560,45);
this.lblUserName.Text = "اسم المستخدم";

//==========================
// txtUserName
//==========================

this.txtUserName.Location = new System.Drawing.Point(190,40);
this.txtUserName.Name = "txtUserName";
this.txtUserName.Size = new System.Drawing.Size(350,30);
this.txtUserName.Font = new System.Drawing.Font("Segoe UI",10F);
this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

//==========================
// lblPassword
//==========================

this.lblPassword.AutoSize = true;
this.lblPassword.Font = new System.Drawing.Font("Segoe UI",10F,System.Drawing.FontStyle.Bold);
this.lblPassword.Location = new System.Drawing.Point(560,90);
this.lblPassword.Text = "كلمة المرور";

//==========================
// txtPassword
//==========================

this.txtPassword.Location = new System.Drawing.Point(190,85);
this.txtPassword.Name = "txtPassword";
this.txtPassword.Size = new System.Drawing.Size(350,30);
this.txtPassword.PasswordChar='*';
this.txtPassword.Font = new System.Drawing.Font("Segoe UI",10F);
this.txtPassword.TextAlign=System.Windows.Forms.HorizontalAlignment.Right;

//==========================
// lblBranch
//==========================

this.lblBranch.AutoSize = true;
this.lblBranch.Font = new System.Drawing.Font("Segoe UI",10F,System.Drawing.FontStyle.Bold);
this.lblBranch.Location = new System.Drawing.Point(560,135);
this.lblBranch.Text = "الفرع";

//==========================
// cmbBranch
//==========================

this.cmbBranch.DropDownStyle =
System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cmbBranch.Location =
new System.Drawing.Point(190,130);
this.cmbBranch.Size =
new System.Drawing.Size(350,31);
this.cmbBranch.Font =
new System.Drawing.Font("Segoe UI",10F);

//==========================
// lblLanguage
//==========================

this.lblLanguage.AutoSize=true;
this.lblLanguage.Font=
new System.Drawing.Font("Segoe UI",10F,System.Drawing.FontStyle.Bold);
this.lblLanguage.Location=
new System.Drawing.Point(560,180);
this.lblLanguage.Text="اللغة";

//==========================
// cmbLanguage
//==========================

this.cmbLanguage.DropDownStyle=
System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cmbLanguage.Location=
new System.Drawing.Point(190,175);
this.cmbLanguage.Size=
new System.Drawing.Size(350,31);
this.cmbLanguage.Font=
new System.Drawing.Font("Segoe UI",10F);

//==========================
// btnLogin
//==========================

this.btnLogin.Location =
new System.Drawing.Point(350,245);
this.btnLogin.Size =
new System.Drawing.Size(190,42);
this.btnLogin.Font =
new System.Drawing.Font("Segoe UI",10F,System.Drawing.FontStyle.Bold);
this.btnLogin.BackColor =
System.Drawing.Color.FromArgb(0,120,215);
this.btnLogin.ForeColor =
System.Drawing.Color.White;
this.btnLogin.FlatStyle =
System.Windows.Forms.FlatStyle.Flat;
this.btnLogin.Text = "دخول";

//==========================
// btnCancel
//==========================

this.btnCancel.Location =
new System.Drawing.Point(150,245);
this.btnCancel.Size =
new System.Drawing.Size(180,42);
this.btnCancel.Font =
new System.Drawing.Font("Segoe UI",10F,System.Drawing.FontStyle.Bold);
this.btnCancel.BackColor =
System.Drawing.Color.Firebrick;
this.btnCancel.ForeColor =
System.Drawing.Color.White;
this.btnCancel.FlatStyle =
System.Windows.Forms.FlatStyle.Flat;
this.btnCancel.Text = "إلغاء";

//==========================
// ToolTip
//==========================

this.toolTip1.SetToolTip(this.txtPassword,
"يجب أن تحتوي كلمة المرور على أحرف وأرقام");

//==========================
// إضافة العناصر
//==========================

this.pnlHeader.Controls.Add(this.picLogo);
this.pnlHeader.Controls.Add(this.lblSystemName);
this.pnlHeader.Controls.Add(this.lblVersion);
this.pnlHeader.Controls.Add(this.lblCopyright);

this.grpLogin.Controls.Add(this.picUser);

this.grpLogin.Controls.Add(this.lblUserName);
this.grpLogin.Controls.Add(this.txtUserName);

this.grpLogin.Controls.Add(this.lblPassword);
this.grpLogin.Controls.Add(this.txtPassword);

this.grpLogin.Controls.Add(this.lblBranch);
this.grpLogin.Controls.Add(this.cmbBranch);

this.grpLogin.Controls.Add(this.lblLanguage);
this.grpLogin.Controls.Add(this.cmbLanguage);

this.grpLogin.Controls.Add(this.btnLogin);
this.grpLogin.Controls.Add(this.btnCancel);

this.pnlMain.Controls.Add(this.grpLogin);

this.Controls.Add(this.pnlMain);
this.Controls.Add(this.pnlFooter);
this.Controls.Add(this.pnlHeader);

this.pnlHeader.ResumeLayout(false);
this.pnlHeader.PerformLayout();

this.grpLogin.ResumeLayout(false);
this.grpLogin.PerformLayout();

this.pnlMain.ResumeLayout(false);

((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();

this.ResumeLayout(false);

}
}
}
