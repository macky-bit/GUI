namespace WindowsFormsApp1
{
    partial class profile
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
            this.headerPan = new System.Windows.Forms.Panel();
            this.avatarPan = new System.Windows.Forms.Panel();
            this.avatarInitials = new System.Windows.Forms.Label();
            this.nameHeading = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.detailsPan = new System.Windows.Forms.Panel();
            this.detailsHeading = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNameField = new System.Windows.Forms.TextBox();
            this.saveNameBtn = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameValue = new System.Windows.Forms.Label();
            this.memberSinceLabel = new System.Windows.Forms.Label();
            this.memberSinceValue = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.activityPan = new System.Windows.Forms.Panel();
            this.activityHeading = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.openLabel = new System.Windows.Forms.Label();
            this.openValue = new System.Windows.Forms.Label();
            this.completedLabel = new System.Windows.Forms.Label();
            this.completedValue = new System.Windows.Forms.Label();
            this.lastFiledLabel = new System.Windows.Forms.Label();
            this.lastFiledValue = new System.Windows.Forms.Label();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.headerPan.SuspendLayout();
            this.avatarPan.SuspendLayout();
            this.detailsPan.SuspendLayout();
            this.activityPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPan
            // 
            this.headerPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.headerPan.Controls.Add(this.avatarPan);
            this.headerPan.Controls.Add(this.nameHeading);
            this.headerPan.Controls.Add(this.roleLabel);
            this.headerPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPan.Location = new System.Drawing.Point(0, 0);
            this.headerPan.Margin = new System.Windows.Forms.Padding(5);
            this.headerPan.Name = "headerPan";
            this.headerPan.Size = new System.Drawing.Size(1324, 162);
            this.headerPan.TabIndex = 0;
            // 
            // avatarPan
            // 
            this.avatarPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.avatarPan.Controls.Add(this.avatarInitials);
            this.avatarPan.Location = new System.Drawing.Point(57, 9);
            this.avatarPan.Margin = new System.Windows.Forms.Padding(5);
            this.avatarPan.Name = "avatarPan";
            this.avatarPan.Size = new System.Drawing.Size(128, 110);
            this.avatarPan.TabIndex = 0;
            // 
            // avatarInitials
            // 
            this.avatarInitials.BackColor = System.Drawing.Color.Transparent;
            this.avatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 21.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarInitials.ForeColor = System.Drawing.Color.White;
            this.avatarInitials.Location = new System.Drawing.Point(0, 0);
            this.avatarInitials.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.avatarInitials.Name = "avatarInitials";
            this.avatarInitials.Size = new System.Drawing.Size(128, 110);
            this.avatarInitials.TabIndex = 0;
            this.avatarInitials.Text = "JD";
            this.avatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameHeading
            // 
            this.nameHeading.AutoSize = true;
            this.nameHeading.BackColor = System.Drawing.Color.Transparent;
            this.nameHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 17.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHeading.ForeColor = System.Drawing.Color.White;
            this.nameHeading.Location = new System.Drawing.Point(220, 27);
            this.nameHeading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameHeading.Name = "nameHeading";
            this.nameHeading.Size = new System.Drawing.Size(222, 41);
            this.nameHeading.TabIndex = 1;
            this.nameHeading.Text = "Juan Dela Cruz";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(198)))));
            this.roleLabel.Location = new System.Drawing.Point(224, 81);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(170, 23);
            this.roleLabel.TabIndex = 2;
            this.roleLabel.Text = "Student  -  @student";
            // 
            // detailsPan
            // 
            this.detailsPan.BackColor = System.Drawing.Color.White;
            this.detailsPan.Controls.Add(this.detailsHeading);
            this.detailsPan.Controls.Add(this.fullNameLabel);
            this.detailsPan.Controls.Add(this.fullNameField);
            this.detailsPan.Controls.Add(this.saveNameBtn);
            this.detailsPan.Controls.Add(this.usernameLabel);
            this.detailsPan.Controls.Add(this.usernameValue);
            this.detailsPan.Controls.Add(this.memberSinceLabel);
            this.detailsPan.Controls.Add(this.memberSinceValue);
            this.detailsPan.Controls.Add(this.statusLabel);
            this.detailsPan.Location = new System.Drawing.Point(43, 203);
            this.detailsPan.Margin = new System.Windows.Forms.Padding(5);
            this.detailsPan.Name = "detailsPan";
            this.detailsPan.Size = new System.Drawing.Size(1241, 352);
            this.detailsPan.TabIndex = 1;
            // 
            // detailsHeading
            // 
            this.detailsHeading.AutoSize = true;
            this.detailsHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsHeading.ForeColor = System.Drawing.Color.Black;
            this.detailsHeading.Location = new System.Drawing.Point(36, 20);
            this.detailsHeading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.detailsHeading.Name = "detailsHeading";
            this.detailsHeading.Size = new System.Drawing.Size(153, 28);
            this.detailsHeading.TabIndex = 0;
            this.detailsHeading.Text = "Account Details";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.fullNameLabel.Location = new System.Drawing.Point(36, 63);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(88, 23);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Full Name";
            // 
            // fullNameField
            // 
            this.fullNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameField.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.fullNameField.Location = new System.Drawing.Point(36, 94);
            this.fullNameField.Margin = new System.Windows.Forms.Padding(5);
            this.fullNameField.MaxLength = 60;
            this.fullNameField.Name = "fullNameField";
            this.fullNameField.Size = new System.Drawing.Size(559, 30);
            this.fullNameField.TabIndex = 0;
            // 
            // saveNameBtn
            // 
            this.saveNameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.saveNameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveNameBtn.FlatAppearance.BorderSize = 0;
            this.saveNameBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.saveNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNameBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNameBtn.ForeColor = System.Drawing.Color.White;
            this.saveNameBtn.Location = new System.Drawing.Point(923, 94);
            this.saveNameBtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveNameBtn.Name = "saveNameBtn";
            this.saveNameBtn.Size = new System.Drawing.Size(249, 41);
            this.saveNameBtn.TabIndex = 1;
            this.saveNameBtn.Text = "Save Name";
            this.saveNameBtn.UseVisualStyleBackColor = false;
            this.saveNameBtn.Click += new System.EventHandler(this.saveNameBtn_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.usernameLabel.Location = new System.Drawing.Point(36, 140);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 23);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // usernameValue
            // 
            this.usernameValue.AutoSize = true;
            this.usernameValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.usernameValue.Location = new System.Drawing.Point(356, 140);
            this.usernameValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(68, 23);
            this.usernameValue.TabIndex = 5;
            this.usernameValue.Text = "student";
            // 
            // memberSinceLabel
            // 
            this.memberSinceLabel.AutoSize = true;
            this.memberSinceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSinceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.memberSinceLabel.Location = new System.Drawing.Point(36, 186);
            this.memberSinceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.memberSinceLabel.Name = "memberSinceLabel";
            this.memberSinceLabel.Size = new System.Drawing.Size(120, 23);
            this.memberSinceLabel.TabIndex = 6;
            this.memberSinceLabel.Text = "Member Since";
            // 
            // memberSinceValue
            // 
            this.memberSinceValue.AutoSize = true;
            this.memberSinceValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSinceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.memberSinceValue.Location = new System.Drawing.Point(356, 186);
            this.memberSinceValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.memberSinceValue.Name = "memberSinceValue";
            this.memberSinceValue.Size = new System.Drawing.Size(17, 23);
            this.memberSinceValue.TabIndex = 7;
            this.memberSinceValue.Text = "-";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.statusLabel.Location = new System.Drawing.Point(36, 214);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1013, 39);
            this.statusLabel.TabIndex = 8;
            // 
            // activityPan
            // 
            this.activityPan.BackColor = System.Drawing.Color.White;
            this.activityPan.Controls.Add(this.activityHeading);
            this.activityPan.Controls.Add(this.totalLabel);
            this.activityPan.Controls.Add(this.totalValue);
            this.activityPan.Controls.Add(this.openLabel);
            this.activityPan.Controls.Add(this.openValue);
            this.activityPan.Controls.Add(this.completedLabel);
            this.activityPan.Controls.Add(this.completedValue);
            this.activityPan.Controls.Add(this.lastFiledLabel);
            this.activityPan.Controls.Add(this.lastFiledValue);
            this.activityPan.Location = new System.Drawing.Point(43, 593);
            this.activityPan.Margin = new System.Windows.Forms.Padding(5);
            this.activityPan.Name = "activityPan";
            this.activityPan.Size = new System.Drawing.Size(1241, 271);
            this.activityPan.TabIndex = 2;
            // 
            // activityHeading
            // 
            this.activityHeading.AutoSize = true;
            this.activityHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityHeading.ForeColor = System.Drawing.Color.Black;
            this.activityHeading.Location = new System.Drawing.Point(36, 17);
            this.activityHeading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.activityHeading.Name = "activityHeading";
            this.activityHeading.Size = new System.Drawing.Size(157, 28);
            this.activityHeading.TabIndex = 0;
            this.activityHeading.Text = "Request Activity";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.totalLabel.Location = new System.Drawing.Point(36, 134);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(320, 27);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Total requests filed";
            // 
            // totalValue
            // 
            this.totalValue.Font = new System.Drawing.Font("Segoe UI Semibold", 21.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.totalValue.Location = new System.Drawing.Point(32, 62);
            this.totalValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(320, 66);
            this.totalValue.TabIndex = 2;
            this.totalValue.Text = "0";
            // 
            // openLabel
            // 
            this.openLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.openLabel.Location = new System.Drawing.Point(388, 134);
            this.openLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(320, 27);
            this.openLabel.TabIndex = 3;
            this.openLabel.Text = "Still open";
            // 
            // openValue
            // 
            this.openValue.Font = new System.Drawing.Font("Segoe UI Semibold", 21.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.openValue.Location = new System.Drawing.Point(384, 62);
            this.openValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.openValue.Name = "openValue";
            this.openValue.Size = new System.Drawing.Size(320, 66);
            this.openValue.TabIndex = 4;
            this.openValue.Text = "0";
            // 
            // completedLabel
            // 
            this.completedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.completedLabel.Location = new System.Drawing.Point(740, 134);
            this.completedLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.completedLabel.Name = "completedLabel";
            this.completedLabel.Size = new System.Drawing.Size(320, 27);
            this.completedLabel.TabIndex = 5;
            this.completedLabel.Text = "Completed";
            // 
            // completedValue
            // 
            this.completedValue.Font = new System.Drawing.Font("Segoe UI Semibold", 21.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.completedValue.Location = new System.Drawing.Point(736, 62);
            this.completedValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.completedValue.Name = "completedValue";
            this.completedValue.Size = new System.Drawing.Size(320, 66);
            this.completedValue.TabIndex = 6;
            this.completedValue.Text = "0";
            // 
            // lastFiledLabel
            // 
            this.lastFiledLabel.AutoSize = true;
            this.lastFiledLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastFiledLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.lastFiledLabel.Location = new System.Drawing.Point(36, 186);
            this.lastFiledLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lastFiledLabel.Name = "lastFiledLabel";
            this.lastFiledLabel.Size = new System.Drawing.Size(145, 23);
            this.lastFiledLabel.TabIndex = 7;
            this.lastFiledLabel.Text = "Most recent filing";
            // 
            // lastFiledValue
            // 
            this.lastFiledValue.AutoSize = true;
            this.lastFiledValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastFiledValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.lastFiledValue.Location = new System.Drawing.Point(356, 185);
            this.lastFiledValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lastFiledValue.Name = "lastFiledValue";
            this.lastFiledValue.Size = new System.Drawing.Size(17, 23);
            this.lastFiledValue.TabIndex = 8;
            this.lastFiledValue.Text = "-";
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.White;
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.changePasswordBtn.Location = new System.Drawing.Point(43, 889);
            this.changePasswordBtn.Margin = new System.Windows.Forms.Padding(5);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(337, 64);
            this.changePasswordBtn.TabIndex = 3;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(58)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1053, 889);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(231, 64);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1324, 1036);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.activityPan);
            this.Controls.Add(this.detailsPan);
            this.Controls.Add(this.headerPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Profile - DMMMSU Maintenance Portal";
            this.Load += new System.EventHandler(this.profile_Load);
            this.headerPan.ResumeLayout(false);
            this.headerPan.PerformLayout();
            this.avatarPan.ResumeLayout(false);
            this.detailsPan.ResumeLayout(false);
            this.detailsPan.PerformLayout();
            this.activityPan.ResumeLayout(false);
            this.activityPan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPan;
        private System.Windows.Forms.Panel avatarPan;
        private System.Windows.Forms.Label avatarInitials;
        private System.Windows.Forms.Label nameHeading;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Panel detailsPan;
        private System.Windows.Forms.Label detailsHeading;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox fullNameField;
        private System.Windows.Forms.Button saveNameBtn;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label usernameValue;
        private System.Windows.Forms.Label memberSinceLabel;
        private System.Windows.Forms.Label memberSinceValue;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel activityPan;
        private System.Windows.Forms.Label activityHeading;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.Label openValue;
        private System.Windows.Forms.Label completedLabel;
        private System.Windows.Forms.Label completedValue;
        private System.Windows.Forms.Label lastFiledLabel;
        private System.Windows.Forms.Label lastFiledValue;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}
