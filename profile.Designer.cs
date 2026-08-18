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
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.headerPan.SuspendLayout();
            this.avatarPan.SuspendLayout();
            this.detailsPan.SuspendLayout();
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
            this.headerPan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headerPan.Name = "headerPan";
            this.headerPan.Size = new System.Drawing.Size(993, 132);
            this.headerPan.TabIndex = 0;
            // 
            // avatarPan
            // 
            this.avatarPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.avatarPan.Controls.Add(this.avatarInitials);
            this.avatarPan.Location = new System.Drawing.Point(43, 7);
            this.avatarPan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avatarPan.Name = "avatarPan";
            this.avatarPan.Size = new System.Drawing.Size(96, 89);
            this.avatarPan.TabIndex = 0;
            // 
            // avatarInitials
            // 
            this.avatarInitials.BackColor = System.Drawing.Color.Transparent;
            this.avatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 21.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarInitials.ForeColor = System.Drawing.Color.White;
            this.avatarInitials.Location = new System.Drawing.Point(0, 0);
            this.avatarInitials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avatarInitials.Name = "avatarInitials";
            this.avatarInitials.Size = new System.Drawing.Size(96, 89);
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
            this.nameHeading.Location = new System.Drawing.Point(165, 22);
            this.nameHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameHeading.Name = "nameHeading";
            this.nameHeading.Size = new System.Drawing.Size(177, 32);
            this.nameHeading.TabIndex = 1;
            this.nameHeading.Text = "Juan Dela Cruz";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(198)))));
            this.roleLabel.Location = new System.Drawing.Point(168, 66);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(128, 17);
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
            this.detailsPan.Location = new System.Drawing.Point(24, 163);
            this.detailsPan.Name = "detailsPan";
            this.detailsPan.Size = new System.Drawing.Size(931, 286);
            this.detailsPan.TabIndex = 1;
            // 
            // detailsHeading
            // 
            this.detailsHeading.AutoSize = true;
            this.detailsHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsHeading.ForeColor = System.Drawing.Color.Black;
            this.detailsHeading.Location = new System.Drawing.Point(27, 16);
            this.detailsHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailsHeading.Name = "detailsHeading";
            this.detailsHeading.Size = new System.Drawing.Size(124, 21);
            this.detailsHeading.TabIndex = 0;
            this.detailsHeading.Text = "Account Details";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.fullNameLabel.Location = new System.Drawing.Point(27, 51);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(69, 17);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Full Name";
            // 
            // fullNameField
            // 
            this.fullNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameField.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.fullNameField.Location = new System.Drawing.Point(27, 76);
            this.fullNameField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullNameField.MaxLength = 60;
            this.fullNameField.Name = "fullNameField";
            this.fullNameField.Size = new System.Drawing.Size(420, 26);
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
            this.saveNameBtn.Location = new System.Drawing.Point(692, 76);
            this.saveNameBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveNameBtn.Name = "saveNameBtn";
            this.saveNameBtn.Size = new System.Drawing.Size(187, 33);
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
            this.usernameLabel.Location = new System.Drawing.Point(27, 114);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(69, 17);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // usernameValue
            // 
            this.usernameValue.AutoSize = true;
            this.usernameValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.usernameValue.Location = new System.Drawing.Point(267, 114);
            this.usernameValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(56, 19);
            this.usernameValue.TabIndex = 5;
            this.usernameValue.Text = "student";
            // 
            // memberSinceLabel
            // 
            this.memberSinceLabel.AutoSize = true;
            this.memberSinceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSinceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.memberSinceLabel.Location = new System.Drawing.Point(27, 151);
            this.memberSinceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberSinceLabel.Name = "memberSinceLabel";
            this.memberSinceLabel.Size = new System.Drawing.Size(94, 17);
            this.memberSinceLabel.TabIndex = 6;
            this.memberSinceLabel.Text = "Member Since";
            // 
            // memberSinceValue
            // 
            this.memberSinceValue.AutoSize = true;
            this.memberSinceValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSinceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.memberSinceValue.Location = new System.Drawing.Point(267, 151);
            this.memberSinceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberSinceValue.Name = "memberSinceValue";
            this.memberSinceValue.Size = new System.Drawing.Size(15, 19);
            this.memberSinceValue.TabIndex = 7;
            this.memberSinceValue.Text = "-";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.statusLabel.Location = new System.Drawing.Point(20, 141);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(760, 32);
            this.statusLabel.TabIndex = 8;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.White;
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.changePasswordBtn.Location = new System.Drawing.Point(32, 722);
            this.changePasswordBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(253, 52);
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
            this.closeBtn.Location = new System.Drawing.Point(790, 722);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(173, 52);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(993, 842);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.detailsPan);
            this.Controls.Add(this.headerPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}
