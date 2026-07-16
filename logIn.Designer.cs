using System.Drawing;

namespace GUI
{
    partial class Dashboard
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
            this.title_pan = new System.Windows.Forms.Panel();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.LTCTYA = new System.Windows.Forms.TextBox();
            this.welcome = new System.Windows.Forms.TextBox();
            this.pIcon = new System.Windows.Forms.Panel();
            this.uIcon = new System.Windows.Forms.Panel();
            this.forgot_pass = new System.Windows.Forms.Button();
            this.rememberme = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.account_question = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.icon = new System.Windows.Forms.Panel();
            this.title_pan.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_pan
            // 
            this.title_pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(22)))));
            this.title_pan.Controls.Add(this.loginpanel);
            this.title_pan.Location = new System.Drawing.Point(12, 12);
            this.title_pan.Name = "title_pan";
            this.title_pan.Size = new System.Drawing.Size(858, 657);
            this.title_pan.TabIndex = 1;
            this.title_pan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginpanel.Controls.Add(this.LTCTYA);
            this.loginpanel.Controls.Add(this.icon);
            this.loginpanel.Controls.Add(this.welcome);
            this.loginpanel.Controls.Add(this.pIcon);
            this.loginpanel.Controls.Add(this.uIcon);
            this.loginpanel.Controls.Add(this.forgot_pass);
            this.loginpanel.Controls.Add(this.rememberme);
            this.loginpanel.Controls.Add(this.signup_btn);
            this.loginpanel.Controls.Add(this.account_question);
            this.loginpanel.Controls.Add(this.Login_btn);
            this.loginpanel.Controls.Add(this.password);
            this.loginpanel.Controls.Add(this.username);
            this.loginpanel.Location = new System.Drawing.Point(441, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(417, 657);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LTCTYA
            // 
            this.LTCTYA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.LTCTYA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LTCTYA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LTCTYA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(168)))), ((int)(((byte)(190)))));
            this.LTCTYA.Location = new System.Drawing.Point(122, 273);
            this.LTCTYA.Name = "LTCTYA";
            this.LTCTYA.ReadOnly = true;
            this.LTCTYA.Size = new System.Drawing.Size(183, 16);
            this.LTCTYA.TabIndex = 11;
            this.LTCTYA.Text = "Login to continue to your account";
            this.LTCTYA.TextChanged += new System.EventHandler(this.LTCTYA_TextChanged);
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.welcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            this.welcome.Location = new System.Drawing.Point(107, 228);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(217, 39);
            this.welcome.TabIndex = 10;
            this.welcome.Text = "Welcome Back!";
            this.welcome.TextChanged += new System.EventHandler(this.welcome_TextChanged);
            // 
            // pIcon
            // 
            this.pIcon.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Password_Icon;
            this.pIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pIcon.Location = new System.Drawing.Point(61, 396);
            this.pIcon.Name = "pIcon";
            this.pIcon.Size = new System.Drawing.Size(40, 36);
            this.pIcon.TabIndex = 9;
            // 
            // uIcon
            // 
            this.uIcon.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Password_eye_Icon;
            this.uIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uIcon.Location = new System.Drawing.Point(61, 341);
            this.uIcon.Name = "uIcon";
            this.uIcon.Size = new System.Drawing.Size(40, 36);
            this.uIcon.TabIndex = 8;
            // 
            // forgot_pass
            // 
            this.forgot_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.forgot_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot_pass.FlatAppearance.BorderSize = 0;
            this.forgot_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgot_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.forgot_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.forgot_pass.Location = new System.Drawing.Point(217, 438);
            this.forgot_pass.Name = "forgot_pass";
            this.forgot_pass.Size = new System.Drawing.Size(123, 26);
            this.forgot_pass.TabIndex = 7;
            this.forgot_pass.Text = "Forgot Password";
            this.forgot_pass.UseVisualStyleBackColor = false;
            this.forgot_pass.Click += new System.EventHandler(this.forgot_pass_Click);
            // 
            // rememberme
            // 
            this.rememberme.AutoSize = true;
            this.rememberme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.rememberme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rememberme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(188)))), ((int)(((byte)(205)))));
            this.rememberme.Location = new System.Drawing.Point(107, 443);
            this.rememberme.Name = "rememberme";
            this.rememberme.Size = new System.Drawing.Size(104, 19);
            this.rememberme.TabIndex = 6;
            this.rememberme.Text = "Remember Me";
            this.rememberme.UseVisualStyleBackColor = false;
            this.rememberme.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.signup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.signup_btn.Location = new System.Drawing.Point(220, 546);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(73, 29);
            this.signup_btn.TabIndex = 5;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.signup_btn_MouseClick);
            // 
            // account_question
            // 
            this.account_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.account_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account_question.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.account_question.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.account_question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(168)))), ((int)(((byte)(190)))));
            this.account_question.Location = new System.Drawing.Point(107, 553);
            this.account_question.Name = "account_question";
            this.account_question.ReadOnly = true;
            this.account_question.Size = new System.Drawing.Size(117, 16);
            this.account_question.TabIndex = 4;
            this.account_question.Text = "do you have account";
            this.account_question.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(91)))), ((int)(((byte)(255)))));
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(77, 488);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(263, 46);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "LOGIN";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(188)))), ((int)(((byte)(205)))));
            this.password.Location = new System.Drawing.Point(107, 396);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(233, 36);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(188)))), ((int)(((byte)(205)))));
            this.username.Location = new System.Drawing.Point(107, 341);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(233, 36);
            this.username.TabIndex = 1;
            this.username.Text = "Email or Username";
            this.username.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.icon.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.User_Icon;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Location = new System.Drawing.Point(122, 61);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(183, 161);
            this.icon.TabIndex = 0;
            this.icon.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(882, 681);
            this.Controls.Add(this.title_pan);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crud";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.title_pan.ResumeLayout(false);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel title_pan;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Panel icon;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox account_question;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.CheckBox rememberme;
        private System.Windows.Forms.Button forgot_pass;
        private System.Windows.Forms.Panel pIcon;
        private System.Windows.Forms.Panel uIcon;
        private System.Windows.Forms.TextBox LTCTYA;
        private System.Windows.Forms.TextBox welcome;
    }
}
