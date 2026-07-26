using GUI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();

            // Enter submits the form, Escape clears it
            AcceptButton = register_btn;
            CancelButton = cancel_btn;
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string name = fullName.Text.Trim();
            string account = username.Text.Trim();
            string secret = password.Text;
            string repeated = confirmPassword.Text;

            string problem = FindInvalidDetail(name, account, secret, repeated);
            if (problem != null)
            {
                ShowProblem(problem);
                return;
            }

            string storeError;
            if (!MaintenanceStore.TryRegister(account, name, secret, out storeError))
            {
                ShowProblem(storeError);
                username.Focus();
                return;
            }

            MessageBox.Show(
                "Welcome, " + name + "! Your account has been created.\r\n\r\nYou can now log in with your username and password.",
                "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GoToLogin();
        }

        /// <summary>Returns the first problem found with the entered details, or null when valid.</summary>
        private string FindInvalidDetail(string name, string account, string secret, string repeated)
        {
            if (name.Length == 0) return "Please enter your full name.";
            if (name.Length < 3) return "Your full name looks too short.";
            if (!name.Any(char.IsLetter)) return "Your full name should contain letters.";

            if (account.Length == 0) return "Please choose a username.";
            if (account.Length < 4) return "Your username must be at least 4 characters long.";
            if (account.Any(char.IsWhiteSpace)) return "Your username cannot contain spaces.";
            if (!account.All(c => char.IsLetterOrDigit(c) || c == '_' || c == '.'))
                return "Your username may only use letters, numbers, dots and underscores.";

            if (secret.Length == 0) return "Please enter a password.";
            if (secret.Length < 6) return "Your password must be at least 6 characters long.";
            if (!secret.Any(char.IsLetter) || !secret.Any(char.IsDigit))
                return "Your password must include both a letter and a number.";

            if (repeated.Length == 0) return "Please confirm your password.";
            if (secret != repeated) return "The two passwords do not match.";

            return null;
        }

        private void ShowProblem(string message)
        {
            statusLabel.Text = message;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            fullName.Clear();
            username.Clear();
            password.Clear();
            confirmPassword.Clear();
            statusLabel.Text = string.Empty;
            fullName.Focus();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            GoToLogin();
        }

        private void GoToLogin()
        {
            var signIn = new Dashboard();
            signIn.FormClosed += (s, args) => Close();
            signIn.Show();
            Hide();
        }
    }
}
