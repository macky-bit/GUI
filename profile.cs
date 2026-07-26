using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>Account details for the signed-in student, with editable name and password.</summary>
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void profile_Load(object sender, EventArgs e)
        {
            UiTheme.MakeCircular(avatarPan);

            if (!AppSession.IsSignedIn)
            {
                Close();
                return;
            }

            var user = AppSession.CurrentUser;
            avatarInitials.Text = InitialsOf(user.FullName);
            nameHeading.Text = user.FullName;
            roleLabel.Text = user.Role + "  -  @" + user.Username;
            fullNameField.Text = user.FullName;
            usernameValue.Text = user.Username;
            memberSinceValue.Text = user.RegisteredOn.ToString("MMMM d, yyyy");

            ShowRequestSummary(user.Username);
        }

        private void ShowRequestSummary(string username)
        {
            var requests = MaintenanceStore.GetRequestsFor(username);

            totalValue.Text = requests.Count.ToString();
            openValue.Text = requests.Count(r => r.Status == RequestStatus.Pending
                                              || r.Status == RequestStatus.InProgress).ToString();
            completedValue.Text = requests.Count(r => r.Status == RequestStatus.Completed).ToString();

            lastFiledValue.Text = requests.Count == 0
                ? "No requests filed yet"
                : requests.First().FiledOn.ToString("MMMM d, yyyy") + "  (" + requests.First().RequestId + ")";
        }

        private void saveNameBtn_Click(object sender, EventArgs e)
        {
            string newName = fullNameField.Text.Trim();

            if (newName.Length < 3 || !newName.Any(char.IsLetter))
            {
                ShowStatus("Please enter your full name.", isError: true);
                fullNameField.Focus();
                return;
            }

            MaintenanceStore.UpdateFullName(AppSession.CurrentUser.Username, newName);
            nameHeading.Text = newName;
            avatarInitials.Text = InitialsOf(newName);
            ShowStatus("Your name has been updated.", isError: false);
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            using (var reset = new resetPassword(AppSession.CurrentUser.Username))
            {
                if (reset.ShowDialog(this) == DialogResult.OK)
                {
                    ShowStatus("Your password has been changed.", isError: false);
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowStatus(string message, bool isError)
        {
            statusLabel.ForeColor = isError ? UiTheme.CancelledText : UiTheme.AccentGreen;
            statusLabel.Text = message;
        }

        private static string InitialsOf(string fullName)
        {
            var parts = (fullName ?? string.Empty)
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 0) return "?";
            if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpper();
            return (parts[0].Substring(0, 1) + parts[parts.Length - 1].Substring(0, 1)).ToUpper();
        }
    }
}
