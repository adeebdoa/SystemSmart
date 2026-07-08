using System;
using System.Windows.Forms;

namespace SystemSmart
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            InitializeForm();

            RegisterEvents();

            LoadBranches();

            LoadLanguages();
        }

        #region Initialize

        private void InitializeForm()
        {
            txtPassword.UseSystemPasswordChar = true;

            txtUserName.Focus();

            btnLogin.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;

            this.AcceptButton = btnLogin;
            this.CancelButton = btnCancel;
        }

        private void RegisterEvents()
        {
            btnLogin.Click += BtnLogin_Click;
            btnCancel.Click += BtnCancel_Click;

            txtUserName.KeyDown += Txt_KeyDown;
            txtPassword.KeyDown += Txt_KeyDown;

            this.Load += LoginForm_Load;

            txtPassword.Enter += TxtPassword_Enter;
            txtPassword.Leave += TxtPassword_Leave;
        }

        #endregion

        #region Load Data

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void LoadBranches()
        {
            cmbBranch.Items.Clear();

            cmbBranch.Items.Add("الفرع الرئيسي");
            cmbBranch.Items.Add("فرع تعز");
            cmbBranch.Items.Add("فرع صنعاء");
            cmbBranch.Items.Add("فرع عدن");

            cmbBranch.SelectedIndex = 0;
        }

        private void LoadLanguages()
        {
            cmbLanguage.Items.Clear();

            cmbLanguage.Items.Add("العربية");
            cmbLanguage.Items.Add("English");

            cmbLanguage.SelectedIndex = 0;
        }

        #endregion

        #region Events

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            toolTip1.Show(
                "يفضل أن تحتوي كلمة المرور على أحرف كبيرة وصغيرة وأرقام.",
                txtPassword,
                0,
                txtPassword.Height + 2,
                3000);
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            toolTip1.Hide(txtPassword);
        }

        #endregion

        #region Login

        private void Login()
        {
            string userName = txtUserName.Text.Trim();

            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show(
                    "يرجى إدخال اسم المستخدم.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "يرجى إدخال كلمة المرور.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            if (cmbBranch.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "يرجى اختيار الفرع.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbBranch.Focus();
                return;
            }

            // سيتم استبدال هذا لاحقاً بالتحقق من Oracle
            if (userName == "admin" && password == "123")
            {
                MessageBox.Show(
                    "تم تسجيل الدخول بنجاح.",
                    "SystemSmart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // MainForm frm = new MainForm();
                // frm.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "اسم المستخدم أو كلمة المرور غير صحيحة.",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        #endregion
    }
}
