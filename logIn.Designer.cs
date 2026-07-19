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
            this.logo_title = new System.Windows.Forms.TextBox();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.LTCTYA = new System.Windows.Forms.TextBox();
            this.log_in = new System.Windows.Forms.TextBox();
            this.forgot_pass = new System.Windows.Forms.Button();
            this.rememberme = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.account_question = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.tag_line = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.icon = new System.Windows.Forms.Panel();
            this.title_pan.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_pan
            // 
            this.title_pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.title_pan.Controls.Add(this.logo);
            this.title_pan.Controls.Add(this.tag_line);
            this.title_pan.Controls.Add(this.logo_title);
            this.title_pan.Controls.Add(this.loginpanel);
            this.title_pan.Location = new System.Drawing.Point(0, 1);
            this.title_pan.Margin = new System.Windows.Forms.Padding(4);
            this.title_pan.Name = "title_pan";
            this.title_pan.Size = new System.Drawing.Size(1280, 853);
            this.title_pan.TabIndex = 1;
            this.title_pan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // logo_title
            // 
            this.logo_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.logo_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logo_title.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(177)))));
            this.logo_title.Location = new System.Drawing.Point(139, 461);
            this.logo_title.Margin = new System.Windows.Forms.Padding(4);
            this.logo_title.Name = "logo_title";
            this.logo_title.Size = new System.Drawing.Size(364, 50);
            this.logo_title.TabIndex = 14;
            this.logo_title.Text = "Welcome to TITLE";
            this.logo_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logo_title.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginpanel.Controls.Add(this.login);
            this.loginpanel.Controls.Add(this.flowLayoutPanel1);
            this.loginpanel.Location = new System.Drawing.Point(626, 0);
            this.loginpanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(673, 853);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pass.Location = new System.Drawing.Point(48, 337);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Size = new System.Drawing.Size(244, 27);
            this.pass.TabIndex = 13;
            this.pass.Text = "Password";
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.user.Location = new System.Drawing.Point(48, 242);
            this.user.Margin = new System.Windows.Forms.Padding(4);
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Size = new System.Drawing.Size(244, 27);
            this.user.TabIndex = 12;
            this.user.Text = "Username";
            // 
            // LTCTYA
            // 
            this.LTCTYA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.LTCTYA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LTCTYA.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTCTYA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.LTCTYA.Location = new System.Drawing.Point(82, 192);
            this.LTCTYA.Margin = new System.Windows.Forms.Padding(4);
            this.LTCTYA.Name = "LTCTYA";
            this.LTCTYA.ReadOnly = true;
            this.LTCTYA.Size = new System.Drawing.Size(324, 24);
            this.LTCTYA.TabIndex = 11;
            this.LTCTYA.Text = "Welcome back! Please enter your details.";
            this.LTCTYA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LTCTYA.TextChanged += new System.EventHandler(this.LTCTYA_TextChanged);
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.log_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_in.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.log_in.Location = new System.Drawing.Point(82, 129);
            this.log_in.Margin = new System.Windows.Forms.Padding(4);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(324, 50);
            this.log_in.TabIndex = 10;
            this.log_in.Text = "Log In";
            this.log_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.log_in.TextChanged += new System.EventHandler(this.welcome_TextChanged);
            // 
            // forgot_pass
            // 
            this.forgot_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.forgot_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot_pass.FlatAppearance.BorderSize = 0;
            this.forgot_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgot_pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.forgot_pass.Location = new System.Drawing.Point(300, 432);
            this.forgot_pass.Margin = new System.Windows.Forms.Padding(4);
            this.forgot_pass.Name = "forgot_pass";
            this.forgot_pass.Size = new System.Drawing.Size(138, 32);
            this.forgot_pass.TabIndex = 7;
            this.forgot_pass.Text = "Forgot Password";
            this.forgot_pass.UseVisualStyleBackColor = false;
            this.forgot_pass.Click += new System.EventHandler(this.forgot_pass_Click);
            // 
            // rememberme
            // 
            this.rememberme.AutoSize = true;
            this.rememberme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.rememberme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rememberme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rememberme.Location = new System.Drawing.Point(48, 437);
            this.rememberme.Margin = new System.Windows.Forms.Padding(4);
            this.rememberme.Name = "rememberme";
            this.rememberme.Size = new System.Drawing.Size(129, 24);
            this.rememberme.TabIndex = 6;
            this.rememberme.Text = "Remember Me";
            this.rememberme.UseVisualStyleBackColor = false;
            this.rememberme.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.signup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.signup_btn.Location = new System.Drawing.Point(256, 588);
            this.signup_btn.Margin = new System.Windows.Forms.Padding(4);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(79, 36);
            this.signup_btn.TabIndex = 5;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            this.signup_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.signup_btn_MouseClick);
            // 
            // account_question
            // 
            this.account_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.account_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account_question.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.account_question.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.account_question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.account_question.Location = new System.Drawing.Point(119, 596);
            this.account_question.Margin = new System.Windows.Forms.Padding(4);
            this.account_question.Name = "account_question";
            this.account_question.ReadOnly = true;
            this.account_question.Size = new System.Drawing.Size(156, 20);
            this.account_question.TabIndex = 4;
            this.account_question.Text = "Don\'t have account?";
            this.account_question.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(46, 506);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(391, 57);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "LOGIN";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(188)))), ((int)(((byte)(205)))));
            this.password.Location = new System.Drawing.Point(47, 379);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(390, 52);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(188)))), ((int)(((byte)(205)))));
            this.username.Location = new System.Drawing.Point(47, 284);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(390, 52);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tag_line
            // 
            this.tag_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.tag_line.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tag_line.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag_line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(177)))));
            this.tag_line.Location = new System.Drawing.Point(139, 518);
            this.tag_line.Margin = new System.Windows.Forms.Padding(4);
            this.tag_line.Name = "tag_line";
            this.tag_line.ReadOnly = true;
            this.tag_line.Size = new System.Drawing.Size(324, 27);
            this.tag_line.TabIndex = 14;
            this.tag_line.Text = "tag line ";
            this.tag_line.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(139, 137);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(350, 303);
            this.logo.TabIndex = 15;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.login.Controls.Add(this.pass);
            this.login.Controls.Add(this.log_in);
            this.login.Controls.Add(this.username);
            this.login.Controls.Add(this.password);
            this.login.Controls.Add(this.user);
            this.login.Controls.Add(this.Login_btn);
            this.login.Controls.Add(this.icon);
            this.login.Controls.Add(this.signup_btn);
            this.login.Controls.Add(this.rememberme);
            this.login.Controls.Add(this.account_question);
            this.login.Controls.Add(this.forgot_pass);
            this.login.Controls.Add(this.LTCTYA);
            this.login.Location = new System.Drawing.Point(88, 118);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(475, 635);
            this.login.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(162)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 646);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.User_Icon;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Location = new System.Drawing.Point(189, 26);
            this.icon.Margin = new System.Windows.Forms.Padding(4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(118, 95);
            this.icon.TabIndex = 0;
            this.icon.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.title_pan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crud";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.title_pan.ResumeLayout(false);
            this.title_pan.PerformLayout();
            this.loginpanel.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel title_pan;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox account_question;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.CheckBox rememberme;
        private System.Windows.Forms.Button forgot_pass;
        private System.Windows.Forms.TextBox LTCTYA;
        private System.Windows.Forms.TextBox log_in;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Panel icon;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox logo_title;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.TextBox tag_line;
        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
