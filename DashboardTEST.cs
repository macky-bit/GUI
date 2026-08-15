//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace WindowsFormsApp1
//{
//    public partial class DashboardTEST : Form
//    {
//        public DashboardTEST()
//        {
//            InitializeComponent();
//        }

//        private void viewReq_Click(object sender, EventArgs e)
//        {

//        }

//        private void viewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
//        {

//        }

//        private void announPan1_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void panel8_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void com_Click(object sender, EventArgs e)
//        {

//        }

//        private void comCount_Click(object sender, EventArgs e)
//        {

//        }

//        private void panel5_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void inProgTxt_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>Home screen: summary counts, recent activity and navigation (basePan only — no sidebar).</summary>
    public partial class DashboardTEST : Form
    {
        private const int RecentRequestLimit = 5;

        public DashboardTEST()
        {
            InitializeComponent();
        }

        private void DashboardTEST_Load(object sender, EventArgs e)
        {
            ShowSignedInUser();
            MakeCardsClickable();
            RefreshDashboard();
        }

        /// <summary>Re-reads stored requests so counts stay correct after filing or cancelling.</summary>
        private void RefreshDashboard()
        {
            string today = DateTime.Now.ToString("MMMM d, yyyy");
            // TODO: point these at whatever date/last-updated labels exist on basePan in this form
            // label1.Text = today;
            // lastUpdateLabel.Text = "Last updated: " + today;

            var requests = MaintenanceStore.GetRequestsFor(CurrentUsername());

            // TODO: confirm these label names in DashboardTEST's Designer.cs
            myReqCount.Text = requests.Count.ToString();
            inProgTxt.Text = requests.Count(r => r.Status == RequestStatus.InProgress).ToString();
            comCount.Text = requests.Count(r => r.Status == RequestStatus.Completed).ToString();
            canCount.Text = requests.Count(r => r.Status == RequestStatus.Cancelled).ToString();

            FillRecentRequests(requests);
        }

        private void ShowSignedInUser()
        {
            string fullName = AppSession.DisplayName;
            // TODO: wire to the actual name/role/avatar labels on this form, if present
            // studentName.Text = fullName;
            // studentLabel.Text = AppSession.IsSignedIn ? AppSession.CurrentUser.Role : "Guest";
            // welcomeLabel.Text = "Welcome back " + FirstNameOf(fullName) + "!";
            // avatarInitials.Text = InitialsOf(fullName);
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

                recentReq.Rows[index].Cells[2].ToolTipText = request.Description;
                TintStatusRow(recentReq.Rows[index], request);
            }

            bool hasRows = recentReq.Rows.Count > 0;
            recentReq.Visible = hasRows;
            // emptyGridLabel.Visible = !hasRows; // TODO: only if this form has that label
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

        #region Navigation (basePan quick-action / summary cards)

        private void MakeCardsClickable()
        {
            // TODO: replace with the actual panel names on this form's basePan
            // AttachCardClick(myReqPan, () => OpenMyRequests(null));
            // AttachCardClick(inProgPan, () => OpenMyRequests(RequestStatus.InProgress));
            // AttachCardClick(comPan, () => OpenMyRequests(RequestStatus.Completed));
            // AttachCardClick(canPan, () => OpenMyRequests(RequestStatus.Cancelled));
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

        #endregion

        #region Existing designer stubs (already on this form)

        private void viewReq_Click(object sender, EventArgs e)
        {
            OpenMyRequests(null);
        }

        private void viewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenMyRequests(null);
        }

        private void announPan1_Paint(object sender, PaintEventArgs e) { }

        private void panel8_Paint(object sender, PaintEventArgs e) { }

        private void panel5_Paint(object sender, PaintEventArgs e) { }

        private void com_Click(object sender, EventArgs e)
        {
            OpenMyRequests(RequestStatus.Completed);
        }

        private void comCount_Click(object sender, EventArgs e)
        {
            OpenMyRequests(RequestStatus.Completed);
        }

        private void inProgTxt_Click(object sender, EventArgs e)
        {
            OpenMyRequests(RequestStatus.InProgress);
        }

        #endregion
    }
}