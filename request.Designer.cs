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
            this.navPan = new System.Windows.Forms.Panel();
            this.NmaintenanceReq = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.cardPan = new System.Windows.Forms.Panel();
            this.reqInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rLoc = new System.Windows.Forms.Label();
            this.RoomBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FaciEquip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProbCat = new System.Windows.Forms.ComboBox();
            this.prioLev = new System.Windows.Forms.Label();
            this.prioBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.messaGe = new System.Windows.Forms.TextBox();
            this.charCountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.attachBtn = new System.Windows.Forms.Button();
            this.clearAttachment = new System.Windows.Forms.Button();
            this.attachmentLabel = new System.Windows.Forms.Label();
            this.Submit_req = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.Formpic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.navPan.SuspendLayout();
            this.cardPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Formpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // navPan
            // 
            this.navPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.navPan.Controls.Add(this.NmaintenanceReq);
            this.navPan.Controls.Add(this.backBtn);
            this.navPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPan.Location = new System.Drawing.Point(0, 0);
            this.navPan.Name = "navPan";
            this.navPan.Size = new System.Drawing.Size(984, 64);
            this.navPan.TabIndex = 0;
            // 
            // NmaintenanceReq
            // 
            this.NmaintenanceReq.AutoSize = true;
            this.NmaintenanceReq.BackColor = System.Drawing.Color.Transparent;
            this.NmaintenanceReq.Font = new System.Drawing.Font("Segoe UI Semibold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NmaintenanceReq.ForeColor = System.Drawing.Color.White;
            this.NmaintenanceReq.Location = new System.Drawing.Point(76, 19);
            this.NmaintenanceReq.Name = "NmaintenanceReq";
            this.NmaintenanceReq.Size = new System.Drawing.Size(241, 25);
            this.NmaintenanceReq.TabIndex = 0;
            this.NmaintenanceReq.Text = "New Maintenance Request";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(58)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(196)))));
            this.backBtn.Location = new System.Drawing.Point(18, 14);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(44, 36);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cardPan
            // 
            this.cardPan.BackColor = System.Drawing.Color.White;
            this.cardPan.Controls.Add(this.Formpic);
            this.cardPan.Controls.Add(this.reqInfo);
            this.cardPan.Controls.Add(this.label4);
            this.cardPan.Controls.Add(this.pictureBox1);
            this.cardPan.Controls.Add(this.rLoc);
            this.cardPan.Controls.Add(this.RoomBox);
            this.cardPan.Controls.Add(this.pictureBox2);
            this.cardPan.Controls.Add(this.label1);
            this.cardPan.Controls.Add(this.FaciEquip);
            this.cardPan.Controls.Add(this.pictureBox4);
            this.cardPan.Controls.Add(this.label2);
            this.cardPan.Controls.Add(this.ProbCat);
            this.cardPan.Controls.Add(this.pictureBox3);
            this.cardPan.Controls.Add(this.prioLev);
            this.cardPan.Controls.Add(this.prioBox);
            this.cardPan.Controls.Add(this.pictureBox5);
            this.cardPan.Controls.Add(this.label5);
            this.cardPan.Controls.Add(this.messaGe);
            this.cardPan.Controls.Add(this.charCountLabel);
            this.cardPan.Controls.Add(this.pictureBox6);
            this.cardPan.Controls.Add(this.label6);
            this.cardPan.Controls.Add(this.attachBtn);
            this.cardPan.Controls.Add(this.clearAttachment);
            this.cardPan.Controls.Add(this.attachmentLabel);
            this.cardPan.Controls.Add(this.Submit_req);
            this.cardPan.Controls.Add(this.cancelBtn);
            this.cardPan.Location = new System.Drawing.Point(24, 88);
            this.cardPan.Name = "cardPan";
            this.cardPan.Size = new System.Drawing.Size(672, 578);
            this.cardPan.TabIndex = 1;
            // 
            // reqInfo
            // 
            this.reqInfo.AutoSize = true;
            this.reqInfo.BackColor = System.Drawing.Color.Transparent;
            this.reqInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.reqInfo.Location = new System.Drawing.Point(78, 18);
            this.reqInfo.Name = "reqInfo";
            this.reqInfo.Size = new System.Drawing.Size(188, 25);
            this.reqInfo.TabIndex = 1;
            this.reqInfo.Text = "Request Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.label4.Location = new System.Drawing.Point(80, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Please provide the details of the maintenance issue.";
            // 
            // rLoc
            // 
            this.rLoc.AutoSize = true;
            this.rLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.rLoc.Location = new System.Drawing.Point(70, 97);
            this.rLoc.Name = "rLoc";
            this.rLoc.Size = new System.Drawing.Size(114, 19);
            this.rLoc.TabIndex = 4;
            this.rLoc.Text = "Room / Location";
            // 
            // RoomBox
            // 
            this.RoomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomBox.FormattingEnabled = true;
            this.RoomBox.Location = new System.Drawing.Point(238, 92);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(404, 27);
            this.RoomBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(70, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Facility / Equipment";
            // 
            // FaciEquip
            // 
            this.FaciEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FaciEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FaciEquip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaciEquip.FormattingEnabled = true;
            this.FaciEquip.Location = new System.Drawing.Point(238, 148);
            this.FaciEquip.Name = "FaciEquip";
            this.FaciEquip.Size = new System.Drawing.Size(404, 27);
            this.FaciEquip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(70, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Problem Category";
            // 
            // ProbCat
            // 
            this.ProbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProbCat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbCat.FormattingEnabled = true;
            this.ProbCat.Location = new System.Drawing.Point(238, 204);
            this.ProbCat.Name = "ProbCat";
            this.ProbCat.Size = new System.Drawing.Size(404, 27);
            this.ProbCat.TabIndex = 2;
            // 
            // prioLev
            // 
            this.prioLev.AutoSize = true;
            this.prioLev.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioLev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.prioLev.Location = new System.Drawing.Point(70, 265);
            this.prioLev.Name = "prioLev";
            this.prioLev.Size = new System.Drawing.Size(91, 19);
            this.prioLev.TabIndex = 10;
            this.prioLev.Text = "Priority Level";
            // 
            // prioBox
            // 
            this.prioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prioBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prioBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioBox.FormattingEnabled = true;
            this.prioBox.Location = new System.Drawing.Point(238, 260);
            this.prioBox.Name = "prioBox";
            this.prioBox.Size = new System.Drawing.Size(404, 27);
            this.prioBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(70, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            // 
            // messaGe
            // 
            this.messaGe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messaGe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messaGe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.messaGe.Location = new System.Drawing.Point(238, 316);
            this.messaGe.MaxLength = 400;
            this.messaGe.Multiline = true;
            this.messaGe.Name = "messaGe";
            this.messaGe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messaGe.Size = new System.Drawing.Size(404, 92);
            this.messaGe.TabIndex = 4;
            this.messaGe.TextChanged += new System.EventHandler(this.messaGe_TextChanged);
            // 
            // charCountLabel
            // 
            this.charCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(163)))), ((int)(((byte)(166)))));
            this.charCountLabel.Location = new System.Drawing.Point(238, 411);
            this.charCountLabel.Name = "charCountLabel";
            this.charCountLabel.Size = new System.Drawing.Size(404, 16);
            this.charCountLabel.TabIndex = 13;
            this.charCountLabel.Text = "400 characters left";
            this.charCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.label6.Location = new System.Drawing.Point(70, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Photo (optional)";
            // 
            // attachBtn
            // 
            this.attachBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(58)))));
            this.attachBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attachBtn.FlatAppearance.BorderSize = 0;
            this.attachBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.attachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachBtn.ForeColor = System.Drawing.Color.White;
            this.attachBtn.Location = new System.Drawing.Point(238, 436);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(116, 33);
            this.attachBtn.TabIndex = 5;
            this.attachBtn.Text = "Choose Photo";
            this.attachBtn.UseVisualStyleBackColor = false;
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // clearAttachment
            // 
            this.clearAttachment.BackColor = System.Drawing.Color.White;
            this.clearAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAttachment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.clearAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAttachment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAttachment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.clearAttachment.Location = new System.Drawing.Point(362, 436);
            this.clearAttachment.Name = "clearAttachment";
            this.clearAttachment.Size = new System.Drawing.Size(80, 33);
            this.clearAttachment.TabIndex = 6;
            this.clearAttachment.Text = "Remove";
            this.clearAttachment.UseVisualStyleBackColor = false;
            this.clearAttachment.Click += new System.EventHandler(this.clearAttachment_Click);
            // 
            // attachmentLabel
            // 
            this.attachmentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.attachmentLabel.Location = new System.Drawing.Point(238, 473);
            this.attachmentLabel.Name = "attachmentLabel";
            this.attachmentLabel.Size = new System.Drawing.Size(404, 18);
            this.attachmentLabel.TabIndex = 16;
            this.attachmentLabel.Text = "No photo attached";
            // 
            // Submit_req
            // 
            this.Submit_req.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.Submit_req.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit_req.FlatAppearance.BorderSize = 0;
            this.Submit_req.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(58)))));
            this.Submit_req.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_req.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_req.ForeColor = System.Drawing.Color.White;
            this.Submit_req.Location = new System.Drawing.Point(238, 510);
            this.Submit_req.Name = "Submit_req";
            this.Submit_req.Size = new System.Drawing.Size(260, 46);
            this.Submit_req.TabIndex = 7;
            this.Submit_req.Text = "Submit Request";
            this.Submit_req.UseVisualStyleBackColor = false;
            this.Submit_req.Click += new System.EventHandler(this.Submit_req_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.cancelBtn.Location = new System.Drawing.Point(508, 510);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(134, 46);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Formpic
            // 
            this.Formpic.BackColor = System.Drawing.Color.Transparent;
            this.Formpic.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.request_information;
            this.Formpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Formpic.Location = new System.Drawing.Point(24, 18);
            this.Formpic.Name = "Formpic";
            this.Formpic.Size = new System.Drawing.Size(44, 40);
            this.Formpic.TabIndex = 0;
            this.Formpic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.request_location;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(26, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.request_computer;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(26, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.request_options;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(26, 204);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 28);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.request_flag;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(26, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 28);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.request_decription;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(26, 316);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 28);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.request_file;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(26, 438);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 28);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(984, 725);
            this.Controls.Add(this.cardPan);
            this.Controls.Add(this.navPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Maintenance Request";
            this.navPan.ResumeLayout(false);
            this.navPan.PerformLayout();
            this.cardPan.ResumeLayout(false);
            this.cardPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Formpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPan;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label NmaintenanceReq;
        private System.Windows.Forms.Panel cardPan;
        private System.Windows.Forms.PictureBox Formpic;
        private System.Windows.Forms.Label reqInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label rLoc;
        private System.Windows.Forms.ComboBox RoomBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FaciEquip;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProbCat;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label prioLev;
        private System.Windows.Forms.ComboBox prioBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox messaGe;
        private System.Windows.Forms.Label charCountLabel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button attachBtn;
        private System.Windows.Forms.Button clearAttachment;
        private System.Windows.Forms.Label attachmentLabel;
        private System.Windows.Forms.Button Submit_req;
        private System.Windows.Forms.Button cancelBtn;
    }
}
