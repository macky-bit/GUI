namespace WindowsFormsApp1
{
    partial class request
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
            this.basePan = new System.Windows.Forms.Panel();
            this.contentPan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rLoc = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reqInfoPan = new System.Windows.Forms.Panel();
            this.reqInfo = new System.Windows.Forms.Label();
            this.Formpic = new System.Windows.Forms.PictureBox();
            this.navPan = new System.Windows.Forms.Panel();
            this.NmaintenanceReq = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.basePan.SuspendLayout();
            this.contentPan.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.reqInfoPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Formpic)).BeginInit();
            this.navPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePan
            // 
            this.basePan.Controls.Add(this.contentPan);
            this.basePan.Controls.Add(this.navPan);
            this.basePan.Location = new System.Drawing.Point(12, 12);
            this.basePan.Name = "basePan";
            this.basePan.Size = new System.Drawing.Size(729, 597);
            this.basePan.TabIndex = 0;
            // 
            // contentPan
            // 
            this.contentPan.Controls.Add(this.panel1);
            this.contentPan.Controls.Add(this.reqInfoPan);
            this.contentPan.Location = new System.Drawing.Point(6, 65);
            this.contentPan.Name = "contentPan";
            this.contentPan.Size = new System.Drawing.Size(720, 529);
            this.contentPan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rLoc);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(44, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 389);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Priority level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Problem Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Facility/ Equipment";
            // 
            // rLoc
            // 
            this.rLoc.AutoSize = true;
            this.rLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLoc.Location = new System.Drawing.Point(168, 23);
            this.rLoc.Name = "rLoc";
            this.rLoc.Size = new System.Drawing.Size(150, 24);
            this.rLoc.TabIndex = 10;
            this.rLoc.Text = "Room/Location";
            this.rLoc.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(389, 205);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(228, 28);
            this.comboBox4.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(389, 142);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(228, 28);
            this.comboBox3.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(389, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 28);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(389, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(81, 270);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 45);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(81, 205);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 45);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(81, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 45);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(81, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 45);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(81, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 45);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // reqInfoPan
            // 
            this.reqInfoPan.Controls.Add(this.reqInfo);
            this.reqInfoPan.Controls.Add(this.Formpic);
            this.reqInfoPan.Location = new System.Drawing.Point(43, 8);
            this.reqInfoPan.Name = "reqInfoPan";
            this.reqInfoPan.Size = new System.Drawing.Size(631, 67);
            this.reqInfoPan.TabIndex = 0;
            // 
            // reqInfo
            // 
            this.reqInfo.AutoSize = true;
            this.reqInfo.BackColor = System.Drawing.Color.Transparent;
            this.reqInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.reqInfo.Location = new System.Drawing.Point(113, 17);
            this.reqInfo.Name = "reqInfo";
            this.reqInfo.Size = new System.Drawing.Size(102, 13);
            this.reqInfo.TabIndex = 3;
            this.reqInfo.Text = "Request Information";
            // 
            // Formpic
            // 
            this.Formpic.Location = new System.Drawing.Point(52, 8);
            this.Formpic.Name = "Formpic";
            this.Formpic.Size = new System.Drawing.Size(55, 45);
            this.Formpic.TabIndex = 0;
            this.Formpic.TabStop = false;
            // 
            // navPan
            // 
            this.navPan.Controls.Add(this.NmaintenanceReq);
            this.navPan.Controls.Add(this.backBtn);
            this.navPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPan.Location = new System.Drawing.Point(0, 0);
            this.navPan.Name = "navPan";
            this.navPan.Size = new System.Drawing.Size(729, 59);
            this.navPan.TabIndex = 1;
            this.navPan.Paint += new System.Windows.Forms.PaintEventHandler(this.navPan_Paint);
            // 
            // NmaintenanceReq
            // 
            this.NmaintenanceReq.BackColor = System.Drawing.SystemColors.Menu;
            this.NmaintenanceReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NmaintenanceReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NmaintenanceReq.Location = new System.Drawing.Point(85, 19);
            this.NmaintenanceReq.Name = "NmaintenanceReq";
            this.NmaintenanceReq.Size = new System.Drawing.Size(264, 24);
            this.NmaintenanceReq.TabIndex = 2;
            this.NmaintenanceReq.Text = "New Maintenance Request";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(15, 9);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(58, 41);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "button1";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 621);
            this.Controls.Add(this.basePan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "request";
            this.Text = "request";
            this.basePan.ResumeLayout(false);
            this.contentPan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.reqInfoPan.ResumeLayout(false);
            this.reqInfoPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Formpic)).EndInit();
            this.navPan.ResumeLayout(false);
            this.navPan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel basePan;
        private System.Windows.Forms.Panel contentPan;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel navPan;
        private System.Windows.Forms.Panel reqInfoPan;
        private System.Windows.Forms.PictureBox Formpic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label rLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reqInfo;
        private System.Windows.Forms.TextBox NmaintenanceReq;
    }
}