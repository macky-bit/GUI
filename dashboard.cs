using GUI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>Shell only: sidebar + topbar. All content forms load as MDI children.</summary>
    public partial class shwpanBtn : Form
    {
        public shwpanBtn()
        {
            InitializeComponent();
        }

        private void shwpanBtn_Load(object sender, EventArgs e)
        {
            OpenDashboardChild();
        }

        #region MDI content
        private T OpenMdiChild<T>(Func<T> factory) where T : Form
        {
            foreach (var mdiChild in MdiChildren)
            {
                if (!(mdiChild is T))
                {
                    mdiChild.Hide();
                }
            }

            var existing = MdiChildren.OfType<T>().FirstOrDefault();
            if (existing != null)
            {
                existing.Show();
                existing.Activate();
                PinToTopLeft(existing);
                return existing;
            }

            var child = factory();
            child.MdiParent = this;
            child.Show();
            PinToTopLeft(child);
            return child;
        }


        private static void PinToTopLeft(Form mdiChild)
        {
            mdiChild.Location = new System.Drawing.Point(0, 0);
        }

    
        private void OpenDashboardChild()
        {
            OpenMdiChild(() => new DashboardTEST());
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
            OpenMdiChild(() => new profile());
        }

        private void OpenNewRequest()
        {
            OpenMdiChild(() => new request());
        }

        private void OpenMyRequests(string statusFilter)
        {
            OpenMdiChild(() => new myRequests(statusFilter));
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