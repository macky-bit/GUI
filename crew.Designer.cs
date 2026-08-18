namespace WindowsFormsApp1
{
    partial class crew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.upMain = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCal = new System.Windows.Forms.LinkLabel();
            this.lblUpMaintenance = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.emptyGridLabel = new System.Windows.Forms.Label();
            this.recentReq = new System.Windows.Forms.DataGridView();
            this.requestIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewAll = new System.Windows.Forms.LinkLabel();
            this.recReqLabel = new System.Windows.Forms.Label();
            this.topbar = new System.Windows.Forms.Panel();
            this.studentLabel = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.avatarInitials = new System.Windows.Forms.Label();
            this.dashBLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upMain)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentReq)).BeginInit();
            this.topbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.linkLabel2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(2, 614);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 218);
            this.panel3.TabIndex = 28;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.linkLabel2.Location = new System.Drawing.Point(569, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(61, 19);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "View All";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(5, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 99);
            this.dataGridView1.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Task";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Facility";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Assigned";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.linkLabel1.Location = new System.Drawing.Point(843, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 19);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Calendar";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "History";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.linkLabel3);
            this.panel2.Controls.Add(this.upMain);
            this.panel2.Controls.Add(this.viewCal);
            this.panel2.Controls.Add(this.lblUpMaintenance);
            this.panel2.Location = new System.Drawing.Point(1, 99);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 171);
            this.panel2.TabIndex = 27;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.linkLabel3.Location = new System.Drawing.Point(568, 9);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(61, 19);
            this.linkLabel3.TabIndex = 19;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "View All";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            // 
            // upMain
            // 
            this.upMain.BackgroundColor = System.Drawing.Color.White;
            this.upMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.upMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.Facility,
            this.Date,
            this.Assigned,
            this.Status});
            this.upMain.Location = new System.Drawing.Point(5, 35);
            this.upMain.Margin = new System.Windows.Forms.Padding(2);
            this.upMain.Name = "upMain";
            this.upMain.RowHeadersWidth = 51;
            this.upMain.RowTemplate.Height = 24;
            this.upMain.Size = new System.Drawing.Size(677, 99);
            this.upMain.TabIndex = 18;
            // 
            // Task
            // 
            this.Task.Frozen = true;
            this.Task.HeaderText = "Task";
            this.Task.MinimumWidth = 6;
            this.Task.Name = "Task";
            this.Task.Width = 125;
            // 
            // Facility
            // 
            this.Facility.Frozen = true;
            this.Facility.HeaderText = "Facility";
            this.Facility.MinimumWidth = 6;
            this.Facility.Name = "Facility";
            this.Facility.Width = 125;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Assigned
            // 
            this.Assigned.Frozen = true;
            this.Assigned.HeaderText = "Assigned";
            this.Assigned.MinimumWidth = 6;
            this.Assigned.Name = "Assigned";
            this.Assigned.Width = 125;
            // 
            // Status
            // 
            this.Status.Frozen = true;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // viewCal
            // 
            this.viewCal.AutoSize = true;
            this.viewCal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.viewCal.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.viewCal.Location = new System.Drawing.Point(843, 10);
            this.viewCal.Name = "viewCal";
            this.viewCal.Size = new System.Drawing.Size(99, 19);
            this.viewCal.TabIndex = 17;
            this.viewCal.TabStop = true;
            this.viewCal.Text = "View Calendar";
            this.viewCal.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            // 
            // lblUpMaintenance
            // 
            this.lblUpMaintenance.AutoSize = true;
            this.lblUpMaintenance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpMaintenance.Location = new System.Drawing.Point(11, 10);
            this.lblUpMaintenance.Name = "lblUpMaintenance";
            this.lblUpMaintenance.Size = new System.Drawing.Size(194, 21);
            this.lblUpMaintenance.TabIndex = 17;
            this.lblUpMaintenance.Text = "Upcoming Maintenance";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.emptyGridLabel);
            this.panel8.Controls.Add(this.recentReq);
            this.panel8.Controls.Add(this.viewAll);
            this.panel8.Controls.Add(this.recReqLabel);
            this.panel8.Location = new System.Drawing.Point(2, 275);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(690, 334);
            this.panel8.TabIndex = 26;
            // 
            // emptyGridLabel
            // 
            this.emptyGridLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyGridLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.emptyGridLabel.Location = new System.Drawing.Point(3, 120);
            this.emptyGridLabel.Name = "emptyGridLabel";
            this.emptyGridLabel.Size = new System.Drawing.Size(627, 46);
            this.emptyGridLabel.TabIndex = 16;
            this.emptyGridLabel.Text = "You have not filed any maintenance requests yet.\r\nUse New Request to report a fac" +
    "ility issue.";
            this.emptyGridLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emptyGridLabel.Visible = false;
            // 
            // recentReq
            // 
            this.recentReq.AllowUserToAddRows = false;
            this.recentReq.AllowUserToDeleteRows = false;
            this.recentReq.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.recentReq.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.recentReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recentReq.BackgroundColor = System.Drawing.Color.White;
            this.recentReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recentReq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.recentReq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recentReq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.recentReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recentReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIdColumn,
            this.roomColumn,
            this.facilityColumn,
            this.statusColumn,
            this.priorityColumn,
            this.dateColumn});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recentReq.DefaultCellStyle = dataGridViewCellStyle15;
            this.recentReq.EnableHeadersVisualStyles = false;
            this.recentReq.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.recentReq.Location = new System.Drawing.Point(3, 54);
            this.recentReq.MultiSelect = false;
            this.recentReq.Name = "recentReq";
            this.recentReq.ReadOnly = true;
            this.recentReq.RowHeadersVisible = false;
            this.recentReq.RowHeadersWidth = 51;
            this.recentReq.RowTemplate.Height = 28;
            this.recentReq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recentReq.Size = new System.Drawing.Size(626, 203);
            this.recentReq.TabIndex = 15;
            // 
            // requestIdColumn
            // 
            this.requestIdColumn.HeaderText = "Request ID";
            this.requestIdColumn.MinimumWidth = 6;
            this.requestIdColumn.Name = "requestIdColumn";
            this.requestIdColumn.ReadOnly = true;
            // 
            // roomColumn
            // 
            this.roomColumn.HeaderText = "Room";
            this.roomColumn.MinimumWidth = 6;
            this.roomColumn.Name = "roomColumn";
            this.roomColumn.ReadOnly = true;
            // 
            // facilityColumn
            // 
            this.facilityColumn.FillWeight = 115F;
            this.facilityColumn.HeaderText = "Facility";
            this.facilityColumn.MinimumWidth = 6;
            this.facilityColumn.Name = "facilityColumn";
            this.facilityColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.FillWeight = 95F;
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // priorityColumn
            // 
            this.priorityColumn.FillWeight = 80F;
            this.priorityColumn.HeaderText = "Priority";
            this.priorityColumn.MinimumWidth = 6;
            this.priorityColumn.Name = "priorityColumn";
            this.priorityColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            this.dateColumn.FillWeight = 105F;
            this.dateColumn.HeaderText = "Date Filed";
            this.dateColumn.MinimumWidth = 6;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // viewAll
            // 
            this.viewAll.AutoSize = true;
            this.viewAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.viewAll.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.viewAll.Location = new System.Drawing.Point(568, 19);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(61, 19);
            this.viewAll.TabIndex = 1;
            this.viewAll.TabStop = true;
            this.viewAll.Text = "View All";
            this.viewAll.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            // 
            // recReqLabel
            // 
            this.recReqLabel.AutoSize = true;
            this.recReqLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recReqLabel.Location = new System.Drawing.Point(9, 10);
            this.recReqLabel.Name = "recReqLabel";
            this.recReqLabel.Size = new System.Drawing.Size(96, 21);
            this.recReqLabel.TabIndex = 0;
            this.recReqLabel.Text = "All Request";
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.White;
            this.topbar.Controls.Add(this.studentLabel);
            this.topbar.Controls.Add(this.studentName);
            this.topbar.Controls.Add(this.panel1);
            this.topbar.Controls.Add(this.dashBLabel);
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Margin = new System.Windows.Forms.Padding(4);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(979, 89);
            this.topbar.TabIndex = 29;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.studentLabel.Location = new System.Drawing.Point(848, 47);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(48, 13);
            this.studentLabel.TabIndex = 16;
            this.studentLabel.Text = "Student";
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(847, 25);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(107, 19);
            this.studentName.TabIndex = 15;
            this.studentName.Text = "Juan Dela Cruz";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.avatarInitials);
            this.panel1.Location = new System.Drawing.Point(791, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 38);
            this.panel1.TabIndex = 13;
            // 
            // avatarInitials
            // 
            this.avatarInitials.BackColor = System.Drawing.Color.Transparent;
            this.avatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarInitials.ForeColor = System.Drawing.Color.White;
            this.avatarInitials.Location = new System.Drawing.Point(0, 0);
            this.avatarInitials.Name = "avatarInitials";
            this.avatarInitials.Size = new System.Drawing.Size(38, 38);
            this.avatarInitials.TabIndex = 0;
            this.avatarInitials.Text = "JD";
            this.avatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashBLabel
            // 
            this.dashBLabel.AutoSize = true;
            this.dashBLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBLabel.Location = new System.Drawing.Point(24, 26);
            this.dashBLabel.Name = "dashBLabel";
            this.dashBLabel.Size = new System.Drawing.Size(120, 30);
            this.dashBLabel.TabIndex = 0;
            this.dashBLabel.Text = "Dashboard";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(706, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 729);
            this.panel4.TabIndex = 30;
            // 
            // crew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 842);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crew";
            this.Text = "crew";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upMain)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentReq)).EndInit();
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.DataGridView upMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facility;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.LinkLabel viewCal;
        private System.Windows.Forms.Label lblUpMaintenance;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label emptyGridLabel;
        private System.Windows.Forms.DataGridView recentReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.LinkLabel viewAll;
        private System.Windows.Forms.Label recReqLabel;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label avatarInitials;
        private System.Windows.Forms.Label dashBLabel;
        private System.Windows.Forms.Panel panel4;
    }
}