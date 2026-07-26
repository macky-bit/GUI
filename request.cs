using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>Form used to file a new maintenance request.</summary>
    public partial class request : Form
    {
        private const int MinimumDescriptionLength = 15;

        private string attachedPhotoPath = string.Empty;

        public request()
        {
            InitializeComponent();
            FillDropdowns();
        }

        private void FillDropdowns()
        {
            UiTheme.StyleCombo(RoomBox,
                "Room 101", "Room 102", "Room 105", "Room 201", "Room 202",
                "Comp Lab 1", "Comp Lab 2", "Science Laboratory", "Library",
                "Gymnasium", "Canteen", "Administration Building", "Comfort Room",
                "Corridor / Hallway", "Grounds / Outdoor Area");

            UiTheme.StyleCombo(FaciEquip,
                "Air Conditioner", "Electric Fan", "Ceiling Light", "Wall Outlet",
                "Desktop Computer", "Projector", "Printer", "Network / Wi-Fi",
                "Chair", "Table", "Door", "Window", "Whiteboard",
                "Faucet", "Toilet", "Drainage", "Roof / Ceiling", "Other");

            UiTheme.StyleCombo(ProbCat,
                "Electrical", "Plumbing", "Carpentry", "IT Equipment",
                "Air Conditioning", "Cleaning / Sanitation", "Structural", "Other");

            UiTheme.StyleCombo(prioBox, "Low", "Medium", "High", "Urgent");
        }

        private void Submit_req_Click(object sender, EventArgs e)
        {
            string problem = FindMissingDetail();
            if (problem != null)
            {
                MessageBox.Show(problem, "Incomplete Request",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filed = MaintenanceStore.AddRequest(new MaintenanceRequest
            {
                Username = AppSession.IsSignedIn ? AppSession.CurrentUser.Username : string.Empty,
                Room = RoomBox.Text,
                Facility = FaciEquip.Text,
                Category = ProbCat.Text,
                Priority = prioBox.Text,
                Description = messaGe.Text.Trim(),
                AttachmentPath = attachedPhotoPath
            });

            MessageBox.Show(
                "Your request has been submitted.\r\n\r\n" +
                "Reference number: " + filed.RequestId + "\r\n" +
                "Status: " + filed.Status + "\r\n\r\n" +
                "The maintenance office will review it shortly.",
                "Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>Returns the first missing or invalid detail, or null when the form is complete.</summary>
        private string FindMissingDetail()
        {
            if (RoomBox.SelectedIndex < 0) return "Please select the room or location.";
            if (FaciEquip.SelectedIndex < 0) return "Please select the facility or equipment involved.";
            if (ProbCat.SelectedIndex < 0) return "Please select the problem category.";
            if (prioBox.SelectedIndex < 0) return "Please select a priority level.";

            string description = messaGe.Text.Trim();
            if (description.Length == 0) return "Please describe the problem.";
            if (description.Length < MinimumDescriptionLength)
                return "Please describe the problem in a little more detail (at least "
                       + MinimumDescriptionLength + " characters).";

            return null;
        }

        private void attachBtn_Click(object sender, EventArgs e)
        {
            using (var picker = new OpenFileDialog())
            {
                picker.Title = "Attach a photo of the problem";
                picker.Filter = "Image files|*.png;*.jpg;*.jpeg;*.bmp;*.gif|All files|*.*";

                if (picker.ShowDialog(this) != DialogResult.OK) return;

                attachedPhotoPath = picker.FileName;
                attachmentLabel.Text = "Attached: " + Path.GetFileName(attachedPhotoPath);
                attachmentLabel.ForeColor = UiTheme.AccentGreen;
            }
        }

        private void clearAttachment_Click(object sender, EventArgs e)
        {
            attachedPhotoPath = string.Empty;
            attachmentLabel.Text = "No photo attached";
            attachmentLabel.ForeColor = UiTheme.MutedText;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (HasUnsavedInput())
            {
                var confirm = MessageBox.Show("Discard this request?", "Cancel Request",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;
            }

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool HasUnsavedInput()
        {
            return RoomBox.SelectedIndex >= 0 || FaciEquip.SelectedIndex >= 0
                   || ProbCat.SelectedIndex >= 0 || prioBox.SelectedIndex >= 0
                   || messaGe.Text.Trim().Length > 0 || attachedPhotoPath.Length > 0;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            cancelBtn_Click(sender, e);
        }

        private void messaGe_TextChanged(object sender, EventArgs e)
        {
            int remaining = messaGe.MaxLength - messaGe.Text.Length;
            charCountLabel.Text = remaining + " characters left";
        }

        #region Designer event stubs

        private void navPan_Paint(object sender, PaintEventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        #endregion
    }
}
