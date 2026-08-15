namespace WindowsFormsApp1
{
    partial class resetPassword
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerPan = new System.Windows.Forms.Panel();
            this.headingLabel = new System.Windows.Forms.Label();
            this.subheadingLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.currentLabel = new System.Windows.Forms.Label();
            this.currentField = new System.Windows.Forms.TextBox();
            this.newLabel = new System.Windows.Forms.Label();
            this.newField = new System.Windows.Forms.TextBox();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.confirmField = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.headerPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPan
            // 
            this.headerPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.headerPan.Controls.Add(this.headingLabel);
            this.headerPan.Controls.Add(this.subheadingLabel);
            this.headerPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPan.Location = new System.Drawing.Point(0, 0);
            this.headerPan.Margin = new System.Windows.Forms.Padding(4);
            this.headerPan.Name = "headerPan";
            this.headerPan.Size = new System.Drawing.Size(567, 100);
            this.headerPan.TabIndex = 0;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.White;
            this.headingLabel.Location = new System.Drawing.Point(32, 20);
            this.headingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(181, 32);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Reset Password";
            // 
            // subheadingLabel
            // 
            this.subheadingLabel.AutoSize = true;
            this.subheadingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subheadingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(198)))));
            this.subheadingLabel.Location = new System.Drawing.Point(35, 55);
            this.subheadingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subheadingLabel.Name = "subheadingLabel";
            this.subheadingLabel.Size = new System.Drawing.Size(374, 20);
            this.subheadingLabel.TabIndex = 1;
            this.subheadingLabel.Text = "Confirm your current password, then choose a new one.";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.usernameLabel.Location = new System.Drawing.Point(35, 118);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 23);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // usernameField
            // 
            this.usernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameField.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.usernameField.Location = new System.Drawing.Point(35, 143);
            this.usernameField.Margin = new System.Windows.Forms.Padding(4);
            this.usernameField.MaxLength = 30;
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(490, 30);
            this.usernameField.TabIndex = 0;
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.currentLabel.Location = new System.Drawing.Point(35, 190);
            this.currentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(145, 23);
            this.currentLabel.TabIndex = 3;
            this.currentLabel.Text = "Current Password";
            // 
            // currentField
            // 
            this.currentField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentField.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.currentField.Location = new System.Drawing.Point(35, 214);
            this.currentField.Margin = new System.Windows.Forms.Padding(4);
            this.currentField.MaxLength = 60;
            this.currentField.Name = "currentField";
            this.currentField.Size = new System.Drawing.Size(490, 30);
            this.currentField.TabIndex = 1;
            this.currentField.UseSystemPasswordChar = true;
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.newLabel.Location = new System.Drawing.Point(35, 261);
            this.newLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(122, 23);
            this.newLabel.TabIndex = 5;
            this.newLabel.Text = "New Password";
            // 
            // newField
            // 
            this.newField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newField.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.newField.Location = new System.Drawing.Point(35, 286);
            this.newField.Margin = new System.Windows.Forms.Padding(4);
            this.newField.MaxLength = 60;
            this.newField.Name = "newField";
            this.newField.Size = new System.Drawing.Size(490, 30);
            this.newField.TabIndex = 2;
            this.newField.UseSystemPasswordChar = true;
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.confirmLabel.Location = new System.Drawing.Point(35, 332);
            this.confirmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(189, 23);
            this.confirmLabel.TabIndex = 7;
            this.confirmLabel.Text = "Confirm New Password";
            // 
            // confirmField
            // 
            this.confirmField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmField.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.confirmField.Location = new System.Drawing.Point(35, 357);
            this.confirmField.Margin = new System.Windows.Forms.Padding(4);
            this.confirmField.MaxLength = 60;
            this.confirmField.Name = "confirmField";
            this.confirmField.Size = new System.Drawing.Size(490, 30);
            this.confirmField.TabIndex = 3;
            this.confirmField.UseSystemPasswordChar = true;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(38)))), ((int)(((byte)(30)))));
            this.statusLabel.Location = new System.Drawing.Point(35, 400);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(491, 39);
            this.statusLabel.TabIndex = 9;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(58)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(317, 446);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(208, 47);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Update Password";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.cancelBtn.Location = new System.Drawing.Point(187, 446);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(123, 47);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // resetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 548);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.confirmField);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.newField);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.currentField);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.headerPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "resetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reset Password";
            this.headerPan.ResumeLayout(false);
            this.headerPan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPan;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label subheadingLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.TextBox currentField;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.TextBox newField;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox confirmField;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
