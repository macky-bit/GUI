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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.title_pan = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.TextBox();
            this.log_in = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.Panel();
            this.signup_btn = new System.Windows.Forms.Button();
            this.rememberme = new System.Windows.Forms.CheckBox();
            this.account_question = new System.Windows.Forms.TextBox();
            this.forgot_pass = new System.Windows.Forms.Button();
            this.LTCTYA = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.title_pan.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_pan
            // 
            this.title_pan.BackColor = System.Drawing.Color.Transparent;
            this.title_pan.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dmmsu1;
            resources.ApplyResources(this.title_pan, "title_pan");
            this.title_pan.Controls.Add(this.Title);
            this.title_pan.Controls.Add(this.logo);
            this.title_pan.Controls.Add(this.loginpanel);
            this.title_pan.Name = "title_pan";
            this.title_pan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Title
            // 
            this.Title.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._2;
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            this.Title.Paint += new System.Windows.Forms.PaintEventHandler(this.Title_Paint);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dmmsu_logo__1_;
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            // 
            // loginpanel
            // 
            resources.ApplyResources(this.loginpanel, "loginpanel");
            this.loginpanel.BackColor = System.Drawing.Color.Transparent;
            this.loginpanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._123;
            this.loginpanel.Controls.Add(this.login);
            this.loginpanel.Controls.Add(this.flowLayoutPanel1);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            resources.ApplyResources(this.login, "login");
            this.login.Name = "login";
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.pass, "pass");
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.log_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.log_in, "log_in");
            this.log_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.log_in.Name = "log_in";
            this.log_in.TextChanged += new System.EventHandler(this.welcome_TextChanged);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.username, "username");
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(188)))), ((int)(((byte)(205)))));
            this.username.Name = "username";
            this.username.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.password, "password");
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(188)))), ((int)(((byte)(205)))));
            this.password.Name = "password";
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.user, "user");
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Login_btn, "Login_btn");
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.User_Icon;
            resources.ApplyResources(this.icon, "icon");
            this.icon.Name = "icon";
            this.icon.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.signup_btn, "signup_btn");
            this.signup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            this.signup_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.signup_btn_MouseClick);
            // 
            // rememberme
            // 
            resources.ApplyResources(this.rememberme, "rememberme");
            this.rememberme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.rememberme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rememberme.Name = "rememberme";
            this.rememberme.UseVisualStyleBackColor = false;
            this.rememberme.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // account_question
            // 
            this.account_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.account_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account_question.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.account_question, "account_question");
            this.account_question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.account_question.Name = "account_question";
            this.account_question.ReadOnly = true;
            this.account_question.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // forgot_pass
            // 
            this.forgot_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.forgot_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot_pass.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.forgot_pass, "forgot_pass");
            this.forgot_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.forgot_pass.Name = "forgot_pass";
            this.forgot_pass.UseVisualStyleBackColor = false;
            this.forgot_pass.Click += new System.EventHandler(this.forgot_pass_Click);
            // 
            // LTCTYA
            // 
            this.LTCTYA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.LTCTYA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.LTCTYA, "LTCTYA");
            this.LTCTYA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.LTCTYA.Name = "LTCTYA";
            this.LTCTYA.ReadOnly = true;
            this.LTCTYA.TextChanged += new System.EventHandler(this.LTCTYA_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.transparent_bg;
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Controls.Add(this.title_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.title_pan.ResumeLayout(false);
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
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Title;
    }
}
