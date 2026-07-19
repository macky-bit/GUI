namespace WindowsFormsApp1
{
    partial class register
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
            this.loginpanel = new System.Windows.Forms.Panel();
            this.title_pan = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.TextBox();
            this.createacc = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_question = new System.Windows.Forms.TextBox();
            this.createaccbaba = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.icon = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.moto = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.loginpanel.SuspendLayout();
            this.title_pan.SuspendLayout();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginpanel.Controls.Add(this.login);
            this.loginpanel.Controls.Add(this.flowLayoutPanel1);
            this.loginpanel.Location = new System.Drawing.Point(619, 4);
            this.loginpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(662, 853);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // title_pan
            // 
            this.title_pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.title_pan.Controls.Add(this.textBox3);
            this.title_pan.Controls.Add(this.moto);
            this.title_pan.Controls.Add(this.loginpanel);
            this.title_pan.Location = new System.Drawing.Point(1, -1);
            this.title_pan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.title_pan.Name = "title_pan";
            this.title_pan.Size = new System.Drawing.Size(1285, 857);
            this.title_pan.TabIndex = 2;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.login.Controls.Add(this.cancel_btn);
            this.login.Controls.Add(this.textBox1);
            this.login.Controls.Add(this.textBox2);
            this.login.Controls.Add(this.pass);
            this.login.Controls.Add(this.createacc);
            this.login.Controls.Add(this.username);
            this.login.Controls.Add(this.password);
            this.login.Controls.Add(this.user);
            this.login.Controls.Add(this.register_btn);
            this.login.Controls.Add(this.icon);
            this.login.Controls.Add(this.login_btn);
            this.login.Controls.Add(this.register_question);
            this.login.Controls.Add(this.createaccbaba);
            this.login.Location = new System.Drawing.Point(94, 64);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(475, 722);
            this.login.TabIndex = 18;
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
            // createacc
            // 
            this.createacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.createacc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createacc.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createacc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.createacc.Location = new System.Drawing.Point(48, 129);
            this.createacc.Margin = new System.Windows.Forms.Padding(4);
            this.createacc.Name = "createacc";
            this.createacc.Size = new System.Drawing.Size(389, 50);
            this.createacc.TabIndex = 10;
            this.createacc.Text = "Create Your Account";
            this.createacc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(47, 546);
            this.register_btn.Margin = new System.Windows.Forms.Padding(4);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(391, 52);
            this.register_btn.TabIndex = 3;
            this.register_btn.Text = "REGISTER";
            this.register_btn.UseVisualStyleBackColor = false;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.login_btn.Location = new System.Drawing.Point(269, 675);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(79, 36);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Sign Up";
            this.login_btn.UseVisualStyleBackColor = false;
            // 
            // register_question
            // 
            this.register_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.register_question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.register_question.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.register_question.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.register_question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.register_question.Location = new System.Drawing.Point(93, 683);
            this.register_question.Margin = new System.Windows.Forms.Padding(4);
            this.register_question.Name = "register_question";
            this.register_question.ReadOnly = true;
            this.register_question.Size = new System.Drawing.Size(168, 20);
            this.register_question.TabIndex = 4;
            this.register_question.Text = "Already have a account?";
            // 
            // createaccbaba
            // 
            this.createaccbaba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.createaccbaba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createaccbaba.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccbaba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.createaccbaba.Location = new System.Drawing.Point(82, 192);
            this.createaccbaba.Margin = new System.Windows.Forms.Padding(4);
            this.createaccbaba.Name = "createaccbaba";
            this.createaccbaba.ReadOnly = true;
            this.createaccbaba.Size = new System.Drawing.Size(324, 24);
            this.createaccbaba.TabIndex = 11;
            this.createaccbaba.Text = "Join us today! It\'s quick and easy";
            this.createaccbaba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(162)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(86, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 733);
            this.flowLayoutPanel1.TabIndex = 19;
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
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox1.Location = new System.Drawing.Point(49, 433);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(244, 27);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Confirm Password";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(188)))), ((int)(((byte)(205)))));
            this.textBox2.Location = new System.Drawing.Point(48, 475);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(390, 52);
            this.textBox2.TabIndex = 14;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(47, 606);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(391, 42);
            this.cancel_btn.TabIndex = 16;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = false;
            // 
            // moto
            // 
            this.moto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.moto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moto.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(177)))));
            this.moto.Location = new System.Drawing.Point(125, 293);
            this.moto.Margin = new System.Windows.Forms.Padding(4);
            this.moto.Name = "moto";
            this.moto.Size = new System.Drawing.Size(364, 50);
            this.moto.TabIndex = 15;
            this.moto.Text = "Collage shit";
            this.moto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(177)))));
            this.textBox3.Location = new System.Drawing.Point(125, 418);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(364, 50);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Collage shit";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.title_pan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "register";
            this.Text = "Form1";
            this.loginpanel.ResumeLayout(false);
            this.title_pan.ResumeLayout(false);
            this.title_pan.PerformLayout();
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Panel title_pan;
        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox createacc;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Panel icon;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox register_question;
        private System.Windows.Forms.TextBox createaccbaba;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox moto;
    }
}