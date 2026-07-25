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
    public partial class shwpanBtn : Form
    {
        public shwpanBtn()
        {
            InitializeComponent();
        }

        private void btnpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if(sidebar.Width <= 10) {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    btnpan1.Width = sidebar.Width;
                    btnpan2.Width = sidebar.Width;
                    btnpan3.Width = sidebar.Width;
                    btnpan4.Width = sidebar.Width;
                    btnpan5.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                    if (sidebar.Width >= 273)
                    {
                        sidebarExpand = true;
                        sidebarTransition.Stop();

                    btnpan1.Width = sidebar.Width;
                    btnpan2.Width = sidebar.Width;
                    btnpan3.Width = sidebar.Width;
                    btnpan4.Width = sidebar.Width;
                    btnpan5.Width = sidebar.Width;
                }
                }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void shwpanBtn_Load(object sender, EventArgs e)
        {

        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
