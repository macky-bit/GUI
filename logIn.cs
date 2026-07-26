using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GUI
{
    /// <summary>Sign-in screen and the entry point of the portal.</summary>
    public partial class Dashboard : Form
    {
        private static readonly string RememberedUserFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "DMMMSU_Maintenance", "remembered.txt");

        public Dashboard()
        {
            InitializeComponent();
            AcceptButton = Login_btn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestoreRememberedUser();
            username.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = username.Text.Trim();
            string secret = password.Text;

            if (account.Length == 0)
            {
                ShowProblem("Please enter your username.");
                username.Focus();
                return;
            }

            if (secret.Length == 0)
            {
                ShowProblem("Please enter your password.");
                password.Focus();
                return;
            }

            var user = MaintenanceStore.Authenticate(account, secret);
            if (user == null)
            {
                ShowProblem("Incorrect username or password.");
                password.SelectAll();
                password.Focus();
                return;
            }

            SaveRememberedUser(rememberme.Checked ? account : null);
            AppSession.SignIn(user);

            var home = new shwpanBtn();
            home.FormClosed += (s, args) => Close();
            home.Show();
            Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            var signUp = new register();
            signUp.FormClosed += (s, args) => Close();
            signUp.Show();
            Hide();
        }

        private void forgot_pass_Click(object sender, EventArgs e)
        {
            using (var reset = new resetPassword(username.Text.Trim()))
            {
                if (reset.ShowDialog(this) != DialogResult.OK) return;

                username.Text = reset.Username;
                password.Clear();
                password.Focus();
                ShowNotice("Password updated. Please log in with your new password.");
            }
        }

        private void ShowProblem(string message)
        {
            statusLabel.ForeColor = UiTheme.CancelledText;
            statusLabel.Text = message;
        }

        private void ShowNotice(string message)
        {
            statusLabel.ForeColor = UiTheme.AccentGreen;
            statusLabel.Text = message;
        }

        private void RestoreRememberedUser()
        {
            if (!File.Exists(RememberedUserFile)) return;

            string remembered = File.ReadAllText(RememberedUserFile).Trim();
            if (remembered.Length == 0) return;

            username.Text = remembered;
            rememberme.Checked = true;
            password.Focus();
        }

        private void SaveRememberedUser(string account)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(RememberedUserFile));
            File.WriteAllText(RememberedUserFile, account ?? string.Empty);
        }

        #region Designer event stubs

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void textBox1_TextChanged_2(object sender, EventArgs e) { }

        private void textBox1_TextChanged_3(object sender, EventArgs e) { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void signup_btn_MouseClick(object sender, MouseEventArgs e) { }

        private void LTCTYA_TextChanged(object sender, EventArgs e) { }

        private void welcome_TextChanged(object sender, EventArgs e) { }

        private void dots_Paint(object sender, PaintEventArgs e) { }

        private void password_TextChanged(object sender, EventArgs e) { }

        private void Title_Paint(object sender, PaintEventArgs e) { }

        private void user_TextChanged(object sender, EventArgs e) { }

        #endregion
    }
}
