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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPending = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.pnlCompleted = new System.Windows.Forms.Panel();
            this.lblPending = new System.Windows.Forms.Label();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblActiveTask = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.penRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penAssignedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvActive = new System.Windows.Forms.DataGridView();
            this.actRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCompetedTask = new System.Windows.Forms.Label();
            this.comRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comFixed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTaskDetails = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPriorityT = new System.Windows.Forms.Label();
            this.lblFacilityT = new System.Windows.Forms.Label();
            this.lblReportedByT = new System.Windows.Forms.Label();
            this.lblScheduledDateT = new System.Windows.Forms.Label();
            this.lblFacility = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblReportedBy = new System.Windows.Forms.Label();
            this.lblScheduledDate = new System.Windows.Forms.Label();
            this.lblIssueDes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotesFromAd = new System.Windows.Forms.Label();
            this.lblUpdateFixes = new System.Windows.Forms.Label();
            this.pnlUpdateFixes = new System.Windows.Forms.Panel();
            this.tblProgress = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWorkProgress = new System.Windows.Forms.Panel();
            this.lblWorkProgress = new System.Windows.Forms.Label();
            this.cmbProgress = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblProgressPercentage = new System.Windows.Forms.Label();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.lblUpdateNotes = new System.Windows.Forms.Label();
            this.txtUpdateNotes = new System.Windows.Forms.TextBox();
            this.lblPhotos = new System.Windows.Forms.Label();
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.lblUpload = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTakeActions = new System.Windows.Forms.Label();
            this.lblMarksAsCompleted = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlPending.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.pnlCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlTaskDetails.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnlUpdateFixes.SuspendLayout();
            this.tblProgress.SuspendLayout();
            this.pnlWorkProgress.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlUpload.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTaskDetails, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1303, 988);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnlPending, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlActive, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pnlCompleted, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(775, 982);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlPending
            // 
            this.pnlPending.BackColor = System.Drawing.Color.White;
            this.pnlPending.Controls.Add(this.panel8);
            this.pnlPending.Controls.Add(this.dgvPending);
            this.pnlPending.Controls.Add(this.lblPending);
            this.pnlPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPending.Location = new System.Drawing.Point(5, 5);
            this.pnlPending.Margin = new System.Windows.Forms.Padding(5);
            this.pnlPending.Name = "pnlPending";
            this.pnlPending.Size = new System.Drawing.Size(765, 314);
            this.pnlPending.TabIndex = 0;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.White;
            this.pnlActive.Controls.Add(this.dgvActive);
            this.pnlActive.Controls.Add(this.panel1);
            this.pnlActive.Controls.Add(this.lblActiveTask);
            this.pnlActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActive.Location = new System.Drawing.Point(5, 329);
            this.pnlActive.Margin = new System.Windows.Forms.Padding(5);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(765, 323);
            this.pnlActive.TabIndex = 1;
            // 
            // pnlCompleted
            // 
            this.pnlCompleted.BackColor = System.Drawing.Color.White;
            this.pnlCompleted.Controls.Add(this.panel2);
            this.pnlCompleted.Controls.Add(this.dataGridView1);
            this.pnlCompleted.Controls.Add(this.lblCompetedTask);
            this.pnlCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompleted.Location = new System.Drawing.Point(5, 662);
            this.pnlCompleted.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCompleted.Name = "pnlCompleted";
            this.pnlCompleted.Size = new System.Drawing.Size(765, 315);
            this.pnlCompleted.TabIndex = 2;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.Black;
            this.lblPending.Location = new System.Drawing.Point(53, 18);
            this.lblPending.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(210, 28);
            this.lblPending.TabIndex = 1;
            this.lblPending.Text = "Pending Assignments";
            // 
            // dgvPending
            // 
            this.dgvPending.AllowUserToAddRows = false;
            this.dgvPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPending.BackgroundColor = System.Drawing.Color.White;
            this.dgvPending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.penRequest,
            this.penTask,
            this.penSchedule,
            this.penAssignedBy,
            this.penPriority,
            this.penActions});
            this.dgvPending.EnableHeadersVisualStyles = false;
            this.dgvPending.Location = new System.Drawing.Point(4, 59);
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.ReadOnly = true;
            this.dgvPending.RowHeadersVisible = false;
            this.dgvPending.RowHeadersWidth = 51;
            this.dgvPending.RowTemplate.Height = 24;
            this.dgvPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPending.Size = new System.Drawing.Size(758, 252);
            this.dgvPending.TabIndex = 2;
            this.dgvPending.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPending_CellContentClick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._52;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(11, 18);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(33, 29);
            this.panel8.TabIndex = 18;
            // 
            // lblActiveTask
            // 
            this.lblActiveTask.AutoSize = true;
            this.lblActiveTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveTask.ForeColor = System.Drawing.Color.Black;
            this.lblActiveTask.Location = new System.Drawing.Point(53, 18);
            this.lblActiveTask.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblActiveTask.Name = "lblActiveTask";
            this.lblActiveTask.Size = new System.Drawing.Size(146, 28);
            this.lblActiveTask.TabIndex = 19;
            this.lblActiveTask.Text = "My Active Task";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._52;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(11, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 29);
            this.panel1.TabIndex = 19;
            // 
            // penRequest
            // 
            this.penRequest.HeaderText = "Request ID";
            this.penRequest.MinimumWidth = 6;
            this.penRequest.Name = "penRequest";
            this.penRequest.ReadOnly = true;
            // 
            // penTask
            // 
            this.penTask.HeaderText = "Task / Facility";
            this.penTask.MinimumWidth = 6;
            this.penTask.Name = "penTask";
            this.penTask.ReadOnly = true;
            // 
            // penSchedule
            // 
            this.penSchedule.HeaderText = "Scheduled Date";
            this.penSchedule.MinimumWidth = 6;
            this.penSchedule.Name = "penSchedule";
            this.penSchedule.ReadOnly = true;
            // 
            // penAssignedBy
            // 
            this.penAssignedBy.HeaderText = "Assigned By";
            this.penAssignedBy.MinimumWidth = 6;
            this.penAssignedBy.Name = "penAssignedBy";
            this.penAssignedBy.ReadOnly = true;
            // 
            // penPriority
            // 
            this.penPriority.HeaderText = "Priority";
            this.penPriority.MinimumWidth = 6;
            this.penPriority.Name = "penPriority";
            this.penPriority.ReadOnly = true;
            // 
            // penActions
            // 
            this.penActions.HeaderText = "Actions";
            this.penActions.MinimumWidth = 6;
            this.penActions.Name = "penActions";
            this.penActions.ReadOnly = true;
            // 
            // dgvActive
            // 
            this.dgvActive.AllowUserToAddRows = false;
            this.dgvActive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActive.BackgroundColor = System.Drawing.Color.White;
            this.dgvActive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actRequest,
            this.actTask,
            this.actStatus,
            this.actProgress,
            this.actActions});
            this.dgvActive.EnableHeadersVisualStyles = false;
            this.dgvActive.Location = new System.Drawing.Point(4, 64);
            this.dgvActive.Name = "dgvActive";
            this.dgvActive.ReadOnly = true;
            this.dgvActive.RowHeadersVisible = false;
            this.dgvActive.RowHeadersWidth = 51;
            this.dgvActive.RowTemplate.Height = 24;
            this.dgvActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActive.Size = new System.Drawing.Size(758, 252);
            this.dgvActive.TabIndex = 19;
            // 
            // actRequest
            // 
            this.actRequest.HeaderText = "Request ID\n";
            this.actRequest.MinimumWidth = 6;
            this.actRequest.Name = "actRequest";
            this.actRequest.ReadOnly = true;
            // 
            // actTask
            // 
            this.actTask.HeaderText = "Task / Facility\n";
            this.actTask.MinimumWidth = 6;
            this.actTask.Name = "actTask";
            this.actTask.ReadOnly = true;
            // 
            // actStatus
            // 
            this.actStatus.HeaderText = "Status";
            this.actStatus.MinimumWidth = 6;
            this.actStatus.Name = "actStatus";
            this.actStatus.ReadOnly = true;
            // 
            // actProgress
            // 
            this.actProgress.HeaderText = "Progress";
            this.actProgress.MinimumWidth = 6;
            this.actProgress.Name = "actProgress";
            this.actProgress.ReadOnly = true;
            // 
            // actActions
            // 
            this.actActions.HeaderText = "Actions";
            this.actActions.MinimumWidth = 6;
            this.actActions.Name = "actActions";
            this.actActions.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._52;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 29);
            this.panel2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comRequest,
            this.comTask,
            this.comDate,
            this.comFixed,
            this.comStatus});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(758, 252);
            this.dataGridView1.TabIndex = 20;
            // 
            // lblCompetedTask
            // 
            this.lblCompetedTask.AutoSize = true;
            this.lblCompetedTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetedTask.ForeColor = System.Drawing.Color.Black;
            this.lblCompetedTask.Location = new System.Drawing.Point(52, 11);
            this.lblCompetedTask.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCompetedTask.Name = "lblCompetedTask";
            this.lblCompetedTask.Size = new System.Drawing.Size(238, 28);
            this.lblCompetedTask.TabIndex = 19;
            this.lblCompetedTask.Text = "Completed Task (Recent)";
            // 
            // comRequest
            // 
            this.comRequest.HeaderText = "Request ID\n";
            this.comRequest.MinimumWidth = 6;
            this.comRequest.Name = "comRequest";
            this.comRequest.ReadOnly = true;
            // 
            // comTask
            // 
            this.comTask.HeaderText = "Task / Facility\n";
            this.comTask.MinimumWidth = 6;
            this.comTask.Name = "comTask";
            this.comTask.ReadOnly = true;
            // 
            // comDate
            // 
            this.comDate.HeaderText = "Date Completed\n";
            this.comDate.MinimumWidth = 6;
            this.comDate.Name = "comDate";
            this.comDate.ReadOnly = true;
            // 
            // comFixed
            // 
            this.comFixed.HeaderText = "Fixed By\n";
            this.comFixed.MinimumWidth = 6;
            this.comFixed.Name = "comFixed";
            this.comFixed.ReadOnly = true;
            // 
            // comStatus
            // 
            this.comStatus.HeaderText = "Status";
            this.comStatus.MinimumWidth = 6;
            this.comStatus.Name = "comStatus";
            this.comStatus.ReadOnly = true;
            // 
            // pnlTaskDetails
            // 
            this.pnlTaskDetails.BackColor = System.Drawing.Color.White;
            this.pnlTaskDetails.Controls.Add(this.pnlUpdateFixes);
            this.pnlTaskDetails.Controls.Add(this.label2);
            this.pnlTaskDetails.Controls.Add(this.lblNotesFromAd);
            this.pnlTaskDetails.Controls.Add(this.label1);
            this.pnlTaskDetails.Controls.Add(this.lblIssueDes);
            this.pnlTaskDetails.Controls.Add(this.tableLayoutPanel3);
            this.pnlTaskDetails.Controls.Add(this.lblTask);
            this.pnlTaskDetails.Controls.Add(this.label4);
            this.pnlTaskDetails.Controls.Add(this.panel3);
            this.pnlTaskDetails.Controls.Add(this.label3);
            this.pnlTaskDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTaskDetails.Location = new System.Drawing.Point(786, 5);
            this.pnlTaskDetails.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTaskDetails.Name = "pnlTaskDetails";
            this.pnlTaskDetails.Size = new System.Drawing.Size(512, 978);
            this.pnlTaskDetails.TabIndex = 1;
            this.pnlTaskDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTaskDetails_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Back to all task";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._52;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(13, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 29);
            this.panel3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "In Progress";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTask.ForeColor = System.Drawing.Color.Black;
            this.lblTask.Location = new System.Drawing.Point(19, 86);
            this.lblTask.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(147, 28);
            this.lblTask.TabIndex = 22;
            this.lblTask.Text = "AC not cooling\n";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblScheduledDate, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblReportedBy, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblPriority, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblFacility, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPriorityT, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblFacilityT, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblReportedByT, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblScheduledDateT, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 127);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(506, 187);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // lblPriorityT
            // 
            this.lblPriorityT.AutoSize = true;
            this.lblPriorityT.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPriorityT.ForeColor = System.Drawing.Color.Black;
            this.lblPriorityT.Location = new System.Drawing.Point(263, 10);
            this.lblPriorityT.Margin = new System.Windows.Forms.Padding(10);
            this.lblPriorityT.Name = "lblPriorityT";
            this.lblPriorityT.Size = new System.Drawing.Size(65, 23);
            this.lblPriorityT.TabIndex = 26;
            this.lblPriorityT.Text = "Priority";
            // 
            // lblFacilityT
            // 
            this.lblFacilityT.AutoSize = true;
            this.lblFacilityT.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFacilityT.ForeColor = System.Drawing.Color.Black;
            this.lblFacilityT.Location = new System.Drawing.Point(10, 10);
            this.lblFacilityT.Margin = new System.Windows.Forms.Padding(10);
            this.lblFacilityT.Name = "lblFacilityT";
            this.lblFacilityT.Size = new System.Drawing.Size(62, 23);
            this.lblFacilityT.TabIndex = 27;
            this.lblFacilityT.Text = "Facility";
            // 
            // lblReportedByT
            // 
            this.lblReportedByT.AutoSize = true;
            this.lblReportedByT.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblReportedByT.ForeColor = System.Drawing.Color.Black;
            this.lblReportedByT.Location = new System.Drawing.Point(10, 102);
            this.lblReportedByT.Margin = new System.Windows.Forms.Padding(10);
            this.lblReportedByT.Name = "lblReportedByT";
            this.lblReportedByT.Size = new System.Drawing.Size(105, 23);
            this.lblReportedByT.TabIndex = 28;
            this.lblReportedByT.Text = "Reported By";
            // 
            // lblScheduledDateT
            // 
            this.lblScheduledDateT.AutoSize = true;
            this.lblScheduledDateT.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblScheduledDateT.ForeColor = System.Drawing.Color.Black;
            this.lblScheduledDateT.Location = new System.Drawing.Point(263, 102);
            this.lblScheduledDateT.Margin = new System.Windows.Forms.Padding(10);
            this.lblScheduledDateT.Name = "lblScheduledDateT";
            this.lblScheduledDateT.Size = new System.Drawing.Size(130, 23);
            this.lblScheduledDateT.TabIndex = 29;
            this.lblScheduledDateT.Text = "Scheduled Date";
            // 
            // lblFacility
            // 
            this.lblFacility.AutoSize = true;
            this.lblFacility.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFacility.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFacility.Location = new System.Drawing.Point(10, 61);
            this.lblFacility.Margin = new System.Windows.Forms.Padding(10);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(132, 20);
            this.lblFacility.TabIndex = 25;
            this.lblFacility.Text = "Building B - Lobby";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPriority.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPriority.Location = new System.Drawing.Point(263, 61);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(10);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(64, 20);
            this.lblPriority.TabIndex = 30;
            this.lblPriority.Text = "Medium";
            // 
            // lblReportedBy
            // 
            this.lblReportedBy.AutoSize = true;
            this.lblReportedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReportedBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReportedBy.Location = new System.Drawing.Point(10, 153);
            this.lblReportedBy.Margin = new System.Windows.Forms.Padding(10);
            this.lblReportedBy.Name = "lblReportedBy";
            this.lblReportedBy.Size = new System.Drawing.Size(90, 20);
            this.lblReportedBy.TabIndex = 31;
            this.lblReportedBy.Text = "Mark Santos";
            // 
            // lblScheduledDate
            // 
            this.lblScheduledDate.AutoSize = true;
            this.lblScheduledDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblScheduledDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblScheduledDate.Location = new System.Drawing.Point(263, 153);
            this.lblScheduledDate.Margin = new System.Windows.Forms.Padding(10);
            this.lblScheduledDate.Name = "lblScheduledDate";
            this.lblScheduledDate.Size = new System.Drawing.Size(170, 20);
            this.lblScheduledDate.TabIndex = 32;
            this.lblScheduledDate.Text = "May 19, 2024 - 01:00 PM";
            // 
            // lblIssueDes
            // 
            this.lblIssueDes.AutoSize = true;
            this.lblIssueDes.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblIssueDes.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDes.Location = new System.Drawing.Point(19, 322);
            this.lblIssueDes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIssueDes.Name = "lblIssueDes";
            this.lblIssueDes.Size = new System.Drawing.Size(158, 25);
            this.lblIssueDes.TabIndex = 24;
            this.lblIssueDes.Text = "Issue Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(30, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "The air conditioning unit in the lobby is not cooling properly. \r\nTemperature is " +
    "too high.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(30, 432);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 40);
            this.label2.TabIndex = 28;
            this.label2.Text = "Please inspect the AC unit and fix the issue. Ensure proper \r\ncooling before clos" +
    "ing the request.";
            // 
            // lblNotesFromAd
            // 
            this.lblNotesFromAd.AutoSize = true;
            this.lblNotesFromAd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNotesFromAd.ForeColor = System.Drawing.Color.Black;
            this.lblNotesFromAd.Location = new System.Drawing.Point(19, 402);
            this.lblNotesFromAd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotesFromAd.Name = "lblNotesFromAd";
            this.lblNotesFromAd.Size = new System.Drawing.Size(172, 25);
            this.lblNotesFromAd.TabIndex = 27;
            this.lblNotesFromAd.Text = "Notes from Admin\n";
            // 
            // lblUpdateFixes
            // 
            this.lblUpdateFixes.AutoSize = true;
            this.lblUpdateFixes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateFixes.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateFixes.Location = new System.Drawing.Point(16, 4);
            this.lblUpdateFixes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUpdateFixes.Name = "lblUpdateFixes";
            this.lblUpdateFixes.Size = new System.Drawing.Size(129, 28);
            this.lblUpdateFixes.TabIndex = 29;
            this.lblUpdateFixes.Text = "Update Fixes";
            // 
            // pnlUpdateFixes
            // 
            this.pnlUpdateFixes.Controls.Add(this.panel5);
            this.pnlUpdateFixes.Controls.Add(this.tableLayoutPanel4);
            this.pnlUpdateFixes.Controls.Add(this.pnlUpload);
            this.pnlUpdateFixes.Controls.Add(this.lblPhotos);
            this.pnlUpdateFixes.Controls.Add(this.txtUpdateNotes);
            this.pnlUpdateFixes.Controls.Add(this.lblUpdateNotes);
            this.pnlUpdateFixes.Controls.Add(this.tblProgress);
            this.pnlUpdateFixes.Controls.Add(this.lblUpdateFixes);
            this.pnlUpdateFixes.Location = new System.Drawing.Point(3, 490);
            this.pnlUpdateFixes.Name = "pnlUpdateFixes";
            this.pnlUpdateFixes.Size = new System.Drawing.Size(506, 485);
            this.pnlUpdateFixes.TabIndex = 30;
            // 
            // tblProgress
            // 
            this.tblProgress.ColumnCount = 2;
            this.tblProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProgress.Controls.Add(this.pnlWorkProgress, 0, 0);
            this.tblProgress.Controls.Add(this.panel4, 1, 0);
            this.tblProgress.Location = new System.Drawing.Point(3, 37);
            this.tblProgress.Name = "tblProgress";
            this.tblProgress.RowCount = 1;
            this.tblProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProgress.Size = new System.Drawing.Size(499, 82);
            this.tblProgress.TabIndex = 30;
            // 
            // pnlWorkProgress
            // 
            this.pnlWorkProgress.Controls.Add(this.cmbProgress);
            this.pnlWorkProgress.Controls.Add(this.lblWorkProgress);
            this.pnlWorkProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkProgress.Location = new System.Drawing.Point(3, 3);
            this.pnlWorkProgress.Name = "pnlWorkProgress";
            this.pnlWorkProgress.Size = new System.Drawing.Size(243, 76);
            this.pnlWorkProgress.TabIndex = 0;
            // 
            // lblWorkProgress
            // 
            this.lblWorkProgress.AutoSize = true;
            this.lblWorkProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblWorkProgress.ForeColor = System.Drawing.Color.Black;
            this.lblWorkProgress.Location = new System.Drawing.Point(8, 4);
            this.lblWorkProgress.Margin = new System.Windows.Forms.Padding(10);
            this.lblWorkProgress.Name = "lblWorkProgress";
            this.lblWorkProgress.Size = new System.Drawing.Size(121, 23);
            this.lblWorkProgress.TabIndex = 31;
            this.lblWorkProgress.Text = "Work Progress";
            // 
            // cmbProgress
            // 
            this.cmbProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgress.FormattingEnabled = true;
            this.cmbProgress.Items.AddRange(new object[] {
            "Pending",
            "",
            "In Progress",
            "",
            "Waiting for Parts",
            "",
            "Completed"});
            this.cmbProgress.Location = new System.Drawing.Point(4, 34);
            this.cmbProgress.Name = "cmbProgress";
            this.cmbProgress.Size = new System.Drawing.Size(236, 24);
            this.cmbProgress.TabIndex = 32;
            this.cmbProgress.SelectedIndexChanged += new System.EventHandler(this.cmbProgress_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtProgress);
            this.panel4.Controls.Add(this.lblProgressPercentage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(252, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 76);
            this.panel4.TabIndex = 1;
            // 
            // lblProgressPercentage
            // 
            this.lblProgressPercentage.AutoSize = true;
            this.lblProgressPercentage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblProgressPercentage.ForeColor = System.Drawing.Color.Black;
            this.lblProgressPercentage.Location = new System.Drawing.Point(8, 4);
            this.lblProgressPercentage.Margin = new System.Windows.Forms.Padding(10);
            this.lblProgressPercentage.Name = "lblProgressPercentage";
            this.lblProgressPercentage.Size = new System.Drawing.Size(165, 23);
            this.lblProgressPercentage.TabIndex = 33;
            this.lblProgressPercentage.Text = "Progress Percentage";
            // 
            // txtProgress
            // 
            this.txtProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgress.Location = new System.Drawing.Point(12, 36);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(211, 25);
            this.txtProgress.TabIndex = 34;
            this.txtProgress.Text = "60%";
            this.txtProgress.TextChanged += new System.EventHandler(this.txtProgress_TextChanged);
            // 
            // lblUpdateNotes
            // 
            this.lblUpdateNotes.AutoSize = true;
            this.lblUpdateNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateNotes.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateNotes.Location = new System.Drawing.Point(16, 126);
            this.lblUpdateNotes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUpdateNotes.Name = "lblUpdateNotes";
            this.lblUpdateNotes.Size = new System.Drawing.Size(138, 28);
            this.lblUpdateNotes.TabIndex = 31;
            this.lblUpdateNotes.Text = "Update Notes";
            // 
            // txtUpdateNotes
            // 
            this.txtUpdateNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateNotes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateNotes.Location = new System.Drawing.Point(14, 160);
            this.txtUpdateNotes.Multiline = true;
            this.txtUpdateNotes.Name = "txtUpdateNotes";
            this.txtUpdateNotes.Size = new System.Drawing.Size(474, 100);
            this.txtUpdateNotes.TabIndex = 32;
            this.txtUpdateNotes.Text = "Checked the thermostat and refrigerant level. Cleaned the filter and reset the sy" +
    "stem. Cooling improved but still monitoring.";
            this.txtUpdateNotes.TextChanged += new System.EventHandler(this.txtUpdateNotes_TextChanged);
            // 
            // lblPhotos
            // 
            this.lblPhotos.AutoSize = true;
            this.lblPhotos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhotos.ForeColor = System.Drawing.Color.Black;
            this.lblPhotos.Location = new System.Drawing.Point(16, 268);
            this.lblPhotos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhotos.Name = "lblPhotos";
            this.lblPhotos.Size = new System.Drawing.Size(174, 28);
            this.lblPhotos.TabIndex = 33;
            this.lblPhotos.Text = "Photos (Optional)";
            // 
            // pnlUpload
            // 
            this.pnlUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpload.Controls.Add(this.lblUpload);
            this.pnlUpload.Location = new System.Drawing.Point(10, 299);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(478, 70);
            this.pnlUpload.TabIndex = 34;
            this.pnlUpload.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUpload_Paint);
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblUpload.ForeColor = System.Drawing.Color.Black;
            this.lblUpload.Location = new System.Drawing.Point(132, 23);
            this.lblUpload.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(187, 19);
            this.lblUpload.TabIndex = 32;
            this.lblUpload.Text = "Click here to upload a photo";
            this.lblUpload.Click += new System.EventHandler(this.lblUpload_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnSaveUpdate, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 375);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(478, 39);
            this.tableLayoutPanel4.TabIndex = 35;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(5, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(229, 29);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.btnSaveUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSaveUpdate.Location = new System.Drawing.Point(244, 5);
            this.btnSaveUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(229, 29);
            this.btnSaveUpdate.TabIndex = 1;
            this.btnSaveUpdate.Text = "Save Update";
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lblMarksAsCompleted);
            this.panel5.Controls.Add(this.lblTakeActions);
            this.panel5.Location = new System.Drawing.Point(6, 420);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(493, 61);
            this.panel5.TabIndex = 36;
            // 
            // lblTakeActions
            // 
            this.lblTakeActions.AutoSize = true;
            this.lblTakeActions.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTakeActions.ForeColor = System.Drawing.Color.Black;
            this.lblTakeActions.Location = new System.Drawing.Point(10, 5);
            this.lblTakeActions.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTakeActions.Name = "lblTakeActions";
            this.lblTakeActions.Size = new System.Drawing.Size(94, 20);
            this.lblTakeActions.TabIndex = 37;
            this.lblTakeActions.Text = "Take Actions";
            // 
            // lblMarksAsCompleted
            // 
            this.lblMarksAsCompleted.AutoSize = true;
            this.lblMarksAsCompleted.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarksAsCompleted.ForeColor = System.Drawing.Color.Black;
            this.lblMarksAsCompleted.Location = new System.Drawing.Point(63, 32);
            this.lblMarksAsCompleted.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMarksAsCompleted.Name = "lblMarksAsCompleted";
            this.lblMarksAsCompleted.Size = new System.Drawing.Size(141, 20);
            this.lblMarksAsCompleted.TabIndex = 38;
            this.lblMarksAsCompleted.Text = "Mark as Completed";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._52;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(24, 26);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(33, 29);
            this.panel6.TabIndex = 22;
            // 
            // crew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 988);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "crew";
            this.Text = "crew";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlPending.ResumeLayout(false);
            this.pnlPending.PerformLayout();
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            this.pnlCompleted.ResumeLayout(false);
            this.pnlCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlTaskDetails.ResumeLayout(false);
            this.pnlTaskDetails.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pnlUpdateFixes.ResumeLayout(false);
            this.pnlUpdateFixes.PerformLayout();
            this.tblProgress.ResumeLayout(false);
            this.pnlWorkProgress.ResumeLayout(false);
            this.pnlWorkProgress.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlPending;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Panel pnlCompleted;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn penRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn penTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn penSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn penAssignedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn penPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn penActions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActiveTask;
        private System.Windows.Forms.DataGridView dgvActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn actRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn actTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn actStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn actProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn actActions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn comTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn comDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn comFixed;
        private System.Windows.Forms.DataGridViewTextBoxColumn comStatus;
        private System.Windows.Forms.Label lblCompetedTask;
        private System.Windows.Forms.Panel pnlTaskDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblScheduledDateT;
        private System.Windows.Forms.Label lblReportedByT;
        private System.Windows.Forms.Label lblPriorityT;
        private System.Windows.Forms.Label lblFacilityT;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Label lblScheduledDate;
        private System.Windows.Forms.Label lblReportedBy;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblIssueDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNotesFromAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpdateFixes;
        private System.Windows.Forms.Panel pnlUpdateFixes;
        private System.Windows.Forms.TableLayoutPanel tblProgress;
        private System.Windows.Forms.Panel pnlWorkProgress;
        private System.Windows.Forms.ComboBox cmbProgress;
        private System.Windows.Forms.Label lblWorkProgress;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblProgressPercentage;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.TextBox txtUpdateNotes;
        private System.Windows.Forms.Label lblUpdateNotes;
        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.Label lblPhotos;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblMarksAsCompleted;
        private System.Windows.Forms.Label lblTakeActions;
    }
}