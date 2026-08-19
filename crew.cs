using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class crew : Form
    {
        public crew()
        {
            InitializeComponent();

            cmbProgress.Items.Add("Pending");
            cmbProgress.Items.Add("In Progress");
            cmbProgress.Items.Add("Waiting for Parts");
            cmbProgress.Items.Add("Completed");

            cmbProgress.SelectedItem = "In Progress";
        }

        private void pnlTaskDetails_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cmbProgress_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtUpdateNotes_TextChanged(object sender, EventArgs e)
        {
        }

        private void pnlUpload_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select a Photo";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblUpload.Text = Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void txtProgress_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
        }

        private void dgvPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}