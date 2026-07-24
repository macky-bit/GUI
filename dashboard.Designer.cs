namespace WindowsFormsApp1
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navbar = new System.Windows.Forms.Panel();
            this.slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnpan = new System.Windows.Forms.Panel();
            this.shwpanBtn = new System.Windows.Forms.Button();
            this.btnpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(962, 72);
            this.navbar.TabIndex = 0;
            // 
            // slidebar
            // 
            this.slidebar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(0, 72);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(205, 621);
            this.slidebar.TabIndex = 1;
            // 
            // btnpan
            // 
            this.btnpan.Controls.Add(this.shwpanBtn);
            this.btnpan.Location = new System.Drawing.Point(352, 160);
            this.btnpan.Name = "btnpan";
            this.btnpan.Size = new System.Drawing.Size(97, 37);
            this.btnpan.TabIndex = 2;
            this.btnpan.Paint += new System.Windows.Forms.PaintEventHandler(this.btnpan_Paint);
            // 
            // shwpanBtn
            // 
            this.shwpanBtn.Location = new System.Drawing.Point(-27, 0);
            this.shwpanBtn.Name = "shwpanBtn";
            this.shwpanBtn.Size = new System.Drawing.Size(152, 37);
            this.shwpanBtn.TabIndex = 3;
            this.shwpanBtn.Text = "button1";
            this.shwpanBtn.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 693);
            this.Controls.Add(this.btnpan);
            this.Controls.Add(this.slidebar);
            this.Controls.Add(this.navbar);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.btnpan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.FlowLayoutPanel slidebar;
        private System.Windows.Forms.Panel btnpan;
        private System.Windows.Forms.Button shwpanBtn;
    }
}