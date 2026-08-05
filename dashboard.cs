using GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>Home screen: summary counts, recent activity and navigation.</summary>
    public partial class shwpanBtn : Form
    {
        private const int RecentRequestLimit = 5;

        public shwpanBtn()
        {
            InitializeComponent();
        }

        private void shwpanBtn_Load(object sender, EventArgs e)
        {
            UiTheme.MakeCircular(bulletPan);
            UiTheme.MakeCircular(panel1);

            ShowSignedInUser();
            MakeCardsClickable();
            RefreshDashboard();
        }

        /// <summary>Re-reads stored requests so counts stay correct after filing or cancelling.</summary>
        private void RefreshDashboard()
        {
            string today = DateTime.Now.ToString("MMMM d, yyyy");
            label1.Text = today;
            lastUpdateLabel.Text = "Last updated: " + today;

            var requests = MaintenanceStore.GetRequestsFor(CurrentUsername());

            myReqCount.Text = requests.Count.ToString();
            inProgCount.Text = requests.Count(r => r.Status == RequestStatus.InProgress).ToString();
            comCount.Text = requests.Count(r => r.Status == RequestStatus.Completed).ToString();
            canCount.Text = requests.Count(r => r.Status == RequestStatus.Cancelled).ToString();

            FillRecentRequests(requests);
        }

        private void ShowSignedInUser()
        {
            string fullName = AppSession.DisplayName;
            studentName.Text = fullName;
            studentLabel.Text = AppSession.IsSignedIn ? AppSession.CurrentUser.Role : "Guest";
            welcomeLabel.Text = "Welcome back " + FirstNameOf(fullName) + "!";
            avatarInitials.Text = InitialsOf(fullName);
        }

        private void FillRecentRequests(List<MaintenanceRequest> requests)
        {
            recentReq.Rows.Clear();

            foreach (var request in requests.Take(RecentRequestLimit))
            {
                int index = recentReq.Rows.Add(
                    request.RequestId,
                    request.Room,
                    request.Facility,
                    request.Status,
                    request.Priority,
                    request.FiledOn.ToString("MMM d, yyyy"));

                // The full description is one click away on the My Requests page
                recentReq.Rows[index].Cells[2].ToolTipText = request.Description;
                TintStatusRow(recentReq.Rows[index], request);
            }

            bool hasRows = recentReq.Rows.Count > 0;
            recentReq.Visible = hasRows;
            emptyGridLabel.Visible = !hasRows;
        }

        private void TintStatusRow(DataGridViewRow row, MaintenanceRequest request)
        {
            Color statusFill, statusText;
            UiTheme.StatusColors(request.Status, out statusFill, out statusText);

            var statusCell = row.Cells[3];
            statusCell.Style.BackColor = statusFill;
            statusCell.Style.ForeColor = statusText;
            statusCell.Style.SelectionBackColor = statusFill;
            statusCell.Style.SelectionForeColor = statusText;
            statusCell.Style.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);

            var priorityCell = row.Cells[4];
            priorityCell.Style.ForeColor = UiTheme.PriorityColor(request.Priority);
            priorityCell.Style.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        }

        private static string FirstNameOf(string fullName)
        {
            var parts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return parts.Length > 0 ? parts[0] : fullName;
        }

        private static string InitialsOf(string fullName)
        {
            var parts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return "?";
            if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpper();
            return (parts[0].Substring(0, 1) + parts[parts.Length - 1].Substring(0, 1)).ToUpper();
        }

        private static string CurrentUsername()
        {
            return AppSession.IsSignedIn ? AppSession.CurrentUser.Username : string.Empty;
        }

        #region Navigation

        /// <summary>
        /// The summary cards and quick-action tiles are plain panels, so their whole
        /// surface — including child labels — is turned into one clickable target.
        /// </summary>
        private void MakeCardsClickable()
        {
            AttachCardClick(myReqPan, () => OpenMyRequests(null));
            AttachCardClick(inProgPan, () => OpenMyRequests(RequestStatus.InProgress));
            AttachCardClick(comPan, () => OpenMyRequests(RequestStatus.Completed));
            AttachCardClick(canPan, () => OpenMyRequests(RequestStatus.Cancelled));

            AttachCardClick(panel6, OpenNewRequest);
            AttachCardClick(panel12, () => OpenMyRequests(null));
            AttachCardClick(panel14, ShowAdminContact);
        }

        private void AttachCardClick(Control card, Action action)
        {
            card.Cursor = Cursors.Hand;
            card.Click += (s, e) => action();

            foreach (Control child in card.Controls)
            {
                child.Cursor = Cursors.Hand;
                child.Click += (s, e) => action();
            }
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void myReqbtn_Click(object sender, EventArgs e)
        {
            OpenMyRequests(null);
        }

        private void newReqbtn_Click(object sender, EventArgs e)
        {
            OpenNewRequest();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            using (var page = new profile())
            {
                page.ShowDialog(this);
            }
            ShowSignedInUser();
        }

        private void viewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenMyRequests(null);
        }

        private void OpenNewRequest()
        {
            using (var form = new request())
            {
                form.ShowDialog(this);
            }
            RefreshDashboard();
        }

        private void OpenMyRequests(string statusFilter)
        {
            using (var form = new myRequests(statusFilter))
            {
                form.ShowDialog(this);
            }
            RefreshDashboard();
        }

        private void ShowAdminContact()
        {
            MessageBox.Show(
                "Facilities & Maintenance Office\r\n" +
                "DMMMSU - Mid La Union Campus\r\n\r\n" +
                "Location:  Administration Building, Ground Floor\r\n" +
                "Hours:     Monday to Friday, 8:00 AM - 5:00 PM\r\n" +
                "Telephone: (072) 888-0000 local 123\r\n" +
                "Email:     facilities@dmmmsu.edu.ph",
                "Contact Administration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to log out?", "Log Out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            AppSession.SignOut();

            var signIn = new Dashboard();
            signIn.FormClosed += (s, args) => Close();
            signIn.Show();
            Hide();
        }

        #endregion

        #region Designer event stubs

        private void btnpan_Paint(object sender, PaintEventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void sidebarTransition_Tick(object sender, EventArgs e) { }

        private void btnHam_Click(object sender, EventArgs e) { }

        private void basePan_Paint(object sender, PaintEventArgs e) { }

        private void slidebar_Paint(object sender, PaintEventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void newReqLabel_Click(object sender, EventArgs e) { }

        private void myReqPan_Paint(object sender, PaintEventArgs e) { }

        #endregion

        bool menuExpand = false;
        private void dropDownReq_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 177)
                {
                    dropDownReq.Stop();
                    menuExpand = true;
                }
                else
                {
                    menuContainer.Height -= 10;
                    if (menuContainer.Height <= 59)
                        dropDownReq.Stop();
                    menuExpand = false;
                }
            }
        }
private void reqButton_Click(object sender, EventArgs e)
        {
            dropDownReq.Start();
        }

        private void reqBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpan3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpan2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
