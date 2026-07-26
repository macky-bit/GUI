using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Local password reset. The portal has no mail server, so the user proves
    /// ownership with their existing password and chooses a replacement.
    /// </summary>
    public partial class resetPassword : Form
    {
        public string Username { get; private set; }

        public resetPassword(string suggestedUsername)
        {
            InitializeComponent();

            AcceptButton = saveBtn;
            CancelButton = cancelBtn;

            usernameField.Text = suggestedUsername ?? string.Empty;
            Username = usernameField.Text;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string account = usernameField.Text.Trim();
            string current = currentField.Text;
            string replacement = newField.Text;
            string repeated = confirmField.Text;

            if (account.Length == 0)
            {
                ShowProblem("Please enter your username.", usernameField);
                return;
            }

            if (!MaintenanceStore.UsernameExists(account))
            {
                ShowProblem("No account is registered under that username.", usernameField);
                return;
            }

            if (current.Length == 0)
            {
                ShowProblem("Please enter your current password.", currentField);
                return;
            }

            if (replacement.Length < 6)
            {
                ShowProblem("Your new password must be at least 6 characters long.", newField);
                return;
            }

            if (!replacement.Any(char.IsLetter) || !replacement.Any(char.IsDigit))
            {
                ShowProblem("Your new password must include both a letter and a number.", newField);
                return;
            }

            if (replacement != repeated)
            {
                ShowProblem("The two new passwords do not match.", confirmField);
                return;
            }

            string error;
            if (!MaintenanceStore.TryChangePassword(account, current, replacement, out error))
            {
                ShowProblem(error, currentField);
                return;
            }

            Username = account;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ShowProblem(string message, TextBox fieldToFocus)
        {
            statusLabel.Text = message;
            fieldToFocus.SelectAll();
            fieldToFocus.Focus();
        }
    }
}
