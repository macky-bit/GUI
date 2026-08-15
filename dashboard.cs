using GUI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>Shell only: sidebar + topbar. Dashboard content lives in DashboardTEST, loaded as an MDI child.</summary>
    public partial class shwpanBtn : Form
    {
        public shwpanBtn()
        {
            InitializeComponent();
        }

        private void shwpanBtn_Load(object sender, EventArgs e)
        {
            UiTheme.MakeCircular(panel1); // bulletPan no longer exists on this form — panel1 is the avatar circle

            ShowSignedInUser();
            OpenDashboardChild();
        }

        private void ShowSignedInUser()
        {
            string fullName = AppSession.DisplayName;
            studentName.Text = fullName;
            studentLabel.Text = AppSession.IsSignedIn ? AppSession.CurrentUser.Role : "Guest";
            avatarInitials.Text = InitialsOf(fullName);
        }

        private static string InitialsOf(string fullName)
        {
            var parts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return "?";
            if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpper();
            return (parts[0].Substring(0, 1) + parts[parts.Length - 1].Substring(0, 1)).ToUpper();
        }

        #region MDI content

        // TODO: rename DashboardTEST here if your relocated content form has a different class name
        private void OpenDashboardChild()
        {
            var existing = MdiChildren.OfType<DashboardTEST>().FirstOrDefault();
            if (existing != null)
            {
                existing.Activate();
                return;
            }

            var child = new DashboardTEST();
            child.MdiParent = this;
            child.Show();
        }

        #endregion

        #region Navigation

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            OpenDashboardChild();
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

        private void OpenNewRequest()
        {
            using (var form = new request())
            {
                form.ShowDialog(this);
            }
        }

        private void OpenMyRequests(string statusFilter)
        {
            using (var form = new myRequests(statusFilter))
            {
                form.ShowDialog(this);
            }
        }

        #endregion

        #region Sidebar "Request" dropdown submenu

        bool menuExpand = false;

        private void dropDownReq_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 177)
                {
                    menuContainer.Height = 177; // clamp, avoid overshoot
                    dropDownReq.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 59)
                {
                    menuContainer.Height = 59; // clamp
                    dropDownReq.Stop();
                    menuExpand = false;
                }
            }
        }

        private void reqButton_Click(object sender, EventArgs e)
        {
            dropDownReq.Start();
        }

        #endregion

        #region Designer paint stubs (still wired, kept empty)

        private void btnpan_Paint(object sender, PaintEventArgs e) { }
        private void btnpan2_Paint(object sender, PaintEventArgs e) { }
        private void btnpan3_Paint(object sender, PaintEventArgs e) { }
        private void reqBtn_Paint(object sender, PaintEventArgs e) { }

        #endregion
    }
}