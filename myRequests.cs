using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>Full history of the signed-in student's requests, with filtering.</summary>
    public partial class myRequests : Form
    {
        private const string AllStatuses = "All Statuses";

        private List<MaintenanceRequest> shownRequests = new List<MaintenanceRequest>();

        public myRequests() : this(null) { }

        public myRequests(string initialStatusFilter)
        {
            InitializeComponent();

            statusFilter.Items.Add(AllStatuses);
            statusFilter.Items.AddRange(new object[]
            {
                RequestStatus.Pending, RequestStatus.InProgress,
                RequestStatus.Completed, RequestStatus.Cancelled
            });
            statusFilter.SelectedItem = initialStatusFilter ?? AllStatuses;
        }

        private void myRequests_Load(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void ReloadList()
        {
            string username = AppSession.IsSignedIn ? AppSession.CurrentUser.Username : string.Empty;
            var all = MaintenanceStore.GetRequestsFor(username);

            string wanted = statusFilter.SelectedItem as string ?? AllStatuses;
            string search = searchField.Text.Trim();

            shownRequests = all
                .Where(r => wanted == AllStatuses || r.Status == wanted)
                .Where(r => search.Length == 0 || MatchesSearch(r, search))
                .ToList();

            requestGrid.Rows.Clear();
            foreach (var request in shownRequests)
            {
                int index = requestGrid.Rows.Add(
                    request.RequestId,
                    request.Room,
                    request.Facility,
                    request.Category,
                    request.Priority,
                    request.Status,
                    request.FiledOn.ToString("MMM d, yyyy"));

                TintRow(requestGrid.Rows[index], request);
            }

            countLabel.Text = shownRequests.Count == 1
                ? "1 request"
                : shownRequests.Count + " requests";

            bool hasRows = shownRequests.Count > 0;
            requestGrid.Visible = hasRows;
            emptyLabel.Visible = !hasRows;
            emptyLabel.Text = all.Count == 0
                ? "You have not filed any maintenance requests yet."
                : "No requests match the current filter.";

            UpdateActionButtons();
        }

        private static bool MatchesSearch(MaintenanceRequest request, string search)
        {
            var comparison = StringComparison.OrdinalIgnoreCase;
            return (request.RequestId ?? "").IndexOf(search, comparison) >= 0
                || (request.Room ?? "").IndexOf(search, comparison) >= 0
                || (request.Facility ?? "").IndexOf(search, comparison) >= 0
                || (request.Category ?? "").IndexOf(search, comparison) >= 0
                || (request.Description ?? "").IndexOf(search, comparison) >= 0;
        }

        private void TintRow(DataGridViewRow row, MaintenanceRequest request)
        {
            Color statusFill, statusText;
            UiTheme.StatusColors(request.Status, out statusFill, out statusText);

            var statusCell = row.Cells[5];
            statusCell.Style.BackColor = statusFill;
            statusCell.Style.ForeColor = statusText;
            statusCell.Style.SelectionBackColor = statusFill;
            statusCell.Style.SelectionForeColor = statusText;
            statusCell.Style.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);

            var priorityCell = row.Cells[4];
            priorityCell.Style.ForeColor = UiTheme.PriorityColor(request.Priority);
            priorityCell.Style.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        }

        private MaintenanceRequest SelectedRequest()
        {
            if (requestGrid.CurrentRow == null) return null;

            int index = requestGrid.CurrentRow.Index;
            return index >= 0 && index < shownRequests.Count ? shownRequests[index] : null;
        }

        private void UpdateActionButtons()
        {
            var selected = SelectedRequest();
            viewBtn.Enabled = selected != null;
            cancelRequestBtn.Enabled = selected != null
                && selected.Status != RequestStatus.Completed
                && selected.Status != RequestStatus.Cancelled;
        }

        private void statusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void requestGrid_SelectionChanged(object sender, EventArgs e)
        {
            UpdateActionButtons();
        }

        private void requestGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDetails();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ShowDetails();
        }

        private void ShowDetails()
        {
            var request = SelectedRequest();
            if (request == null) return;

            string attachment = string.IsNullOrEmpty(request.AttachmentPath)
                ? "None"
                : System.IO.Path.GetFileName(request.AttachmentPath);

            MessageBox.Show(
                "Reference:   " + request.RequestId + "\r\n" +
                "Status:      " + request.Status + "\r\n" +
                "Priority:    " + request.Priority + "\r\n" +
                "Filed on:    " + request.FiledOn.ToString("MMMM d, yyyy h:mm tt") + "\r\n\r\n" +
                "Room:        " + request.Room + "\r\n" +
                "Facility:    " + request.Facility + "\r\n" +
                "Category:    " + request.Category + "\r\n" +
                "Attachment:  " + attachment + "\r\n\r\n" +
                "Description:\r\n" + request.Description,
                "Request " + request.RequestId, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelRequestBtn_Click(object sender, EventArgs e)
        {
            var request = SelectedRequest();
            if (request == null) return;

            var confirm = MessageBox.Show(
                "Cancel request " + request.RequestId + "?\r\n\r\nThis cannot be undone.",
                "Cancel Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            if (MaintenanceStore.CancelRequest(request.RequestId))
            {
                ReloadList();
            }
            else
            {
                MessageBox.Show("This request can no longer be cancelled.", "Cancel Request",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void newRequestBtn_Click(object sender, EventArgs e)
        {
            using (var form = new request())
            {
                form.ShowDialog(this);
            }
            ReloadList();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
