namespace WindowsFormsApp1
{
    partial class myRequests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navPan = new System.Windows.Forms.Panel();
            this.headingLabel = new System.Windows.Forms.Label();
            this.subheadingLabel = new System.Windows.Forms.Label();
            this.cardPan = new System.Windows.Forms.Panel();
            this.filterLabel = new System.Windows.Forms.Label();
            this.statusFilter = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.requestGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewBtn = new System.Windows.Forms.Button();
            this.cancelRequestBtn = new System.Windows.Forms.Button();
            this.newRequestBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.navPan.SuspendLayout();
            this.cardPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // navPan
            // 
            this.navPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.navPan.Controls.Add(this.headingLabel);
            this.navPan.Controls.Add(this.subheadingLabel);
            this.navPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPan.Location = new System.Drawing.Point(0, 0);
            this.navPan.Name = "navPan";
            this.navPan.Size = new System.Drawing.Size(984, 80);
            this.navPan.TabIndex = 0;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.White;
            this.headingLabel.Location = new System.Drawing.Point(28, 16);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(139, 30);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "My Requests";
            // 
            // subheadingLabel
            // 
            this.subheadingLabel.AutoSize = true;
            this.subheadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.subheadingLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subheadingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(198)))));
            this.subheadingLabel.Location = new System.Drawing.Point(30, 48);
            this.subheadingLabel.Name = "subheadingLabel";
            this.subheadingLabel.Size = new System.Drawing.Size(325, 17);
            this.subheadingLabel.TabIndex = 1;
            this.subheadingLabel.Text = "Every maintenance request you have filed, newest first.";
            // 
            // cardPan
            // 
            this.cardPan.BackColor = System.Drawing.Color.White;
            this.cardPan.Controls.Add(this.filterLabel);
            this.cardPan.Controls.Add(this.statusFilter);
            this.cardPan.Controls.Add(this.searchLabel);
            this.cardPan.Controls.Add(this.searchField);
            this.cardPan.Controls.Add(this.countLabel);
            this.cardPan.Controls.Add(this.emptyLabel);
            this.cardPan.Controls.Add(this.requestGrid);
            this.cardPan.Location = new System.Drawing.Point(24, 100);
            this.cardPan.Name = "cardPan";
            this.cardPan.Size = new System.Drawing.Size(892, 424);
            this.cardPan.TabIndex = 1;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.filterLabel.Location = new System.Drawing.Point(20, 20);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(46, 17);
            this.filterLabel.TabIndex = 0;
            this.filterLabel.Text = "Status";
            // 
            // statusFilter
            // 
            this.statusFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.statusFilter.FormattingEnabled = true;
            this.statusFilter.Location = new System.Drawing.Point(20, 40);
            this.statusFilter.Name = "statusFilter";
            this.statusFilter.Size = new System.Drawing.Size(196, 27);
            this.statusFilter.TabIndex = 0;
            this.statusFilter.SelectedIndexChanged += new System.EventHandler(this.statusFilter_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.searchLabel.Location = new System.Drawing.Point(236, 20);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(48, 17);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search";
            // 
            // searchField
            // 
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.searchField.Location = new System.Drawing.Point(236, 40);
            this.searchField.MaxLength = 60;
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(340, 26);
            this.searchField.TabIndex = 1;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // countLabel
            // 
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.countLabel.Location = new System.Drawing.Point(672, 44);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(200, 20);
            this.countLabel.TabIndex = 4;
            this.countLabel.Text = "0 requests";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emptyLabel
            // 
            this.emptyLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.emptyLabel.Location = new System.Drawing.Point(20, 190);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(852, 40);
            this.emptyLabel.TabIndex = 5;
            this.emptyLabel.Text = "No requests match the current filter.";
            this.emptyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emptyLabel.Visible = false;
            // 
            // requestGrid
            // 
            this.requestGrid.AllowUserToAddRows = false;
            this.requestGrid.AllowUserToDeleteRows = false;
            this.requestGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.requestGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.requestGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestGrid.BackgroundColor = System.Drawing.Color.White;
            this.requestGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.requestGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.requestGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.requestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.roomColumn,
            this.facilityColumn,
            this.categoryColumn,
            this.priorityColumn,
            this.statusColumn,
            this.dateColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.requestGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.requestGrid.EnableHeadersVisualStyles = false;
            this.requestGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(230)))));
            this.requestGrid.Location = new System.Drawing.Point(20, 84);
            this.requestGrid.MultiSelect = false;
            this.requestGrid.Name = "requestGrid";
            this.requestGrid.ReadOnly = true;
            this.requestGrid.RowHeadersVisible = false;
            this.requestGrid.RowTemplate.Height = 30;
            this.requestGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestGrid.Size = new System.Drawing.Size(852, 320);
            this.requestGrid.TabIndex = 2;
            this.requestGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestGrid_CellDoubleClick);
            this.requestGrid.SelectionChanged += new System.EventHandler(this.requestGrid_SelectionChanged);
            // 
            // idColumn
            // 
            this.idColumn.FillWeight = 90F;
            this.idColumn.HeaderText = "Request ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // roomColumn
            // 
            this.roomColumn.FillWeight = 110F;
            this.roomColumn.HeaderText = "Room";
            this.roomColumn.Name = "roomColumn";
            this.roomColumn.ReadOnly = true;
            // 
            // facilityColumn
            // 
            this.facilityColumn.FillWeight = 120F;
            this.facilityColumn.HeaderText = "Facility";
            this.facilityColumn.Name = "facilityColumn";
            this.facilityColumn.ReadOnly = true;
            // 
            // categoryColumn
            // 
            this.categoryColumn.FillWeight = 110F;
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.ReadOnly = true;
            // 
            // priorityColumn
            // 
            this.priorityColumn.FillWeight = 75F;
            this.priorityColumn.HeaderText = "Priority";
            this.priorityColumn.Name = "priorityColumn";
            this.priorityColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.FillWeight = 90F;
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Date Filed";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.White;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.viewBtn.Location = new System.Drawing.Point(24, 540);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(150, 42);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "View Details";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // cancelRequestBtn
            // 
            this.cancelRequestBtn.BackColor = System.Drawing.Color.White;
            this.cancelRequestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelRequestBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.cancelRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelRequestBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelRequestBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(38)))), ((int)(((byte)(30)))));
            this.cancelRequestBtn.Location = new System.Drawing.Point(182, 540);
            this.cancelRequestBtn.Name = "cancelRequestBtn";
            this.cancelRequestBtn.Size = new System.Drawing.Size(166, 42);
            this.cancelRequestBtn.TabIndex = 4;
            this.cancelRequestBtn.Text = "Cancel Request";
            this.cancelRequestBtn.UseVisualStyleBackColor = false;
            this.cancelRequestBtn.Click += new System.EventHandler(this.cancelRequestBtn_Click);
            // 
            // newRequestBtn
            // 
            this.newRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            this.newRequestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newRequestBtn.FlatAppearance.BorderSize = 0;
            this.newRequestBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(58)))));
            this.newRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRequestBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRequestBtn.ForeColor = System.Drawing.Color.White;
            this.newRequestBtn.Location = new System.Drawing.Point(608, 540);
            this.newRequestBtn.Name = "newRequestBtn";
            this.newRequestBtn.Size = new System.Drawing.Size(170, 42);
            this.newRequestBtn.TabIndex = 5;
            this.newRequestBtn.Text = "New Request";
            this.newRequestBtn.UseVisualStyleBackColor = false;
            this.newRequestBtn.Click += new System.EventHandler(this.newRequestBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.closeBtn.Location = new System.Drawing.Point(786, 540);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(130, 42);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // myRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(984, 725);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.newRequestBtn);
            this.Controls.Add(this.cancelRequestBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.cardPan);
            this.Controls.Add(this.navPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "myRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Requests - DMMMSU Maintenance Portal";
            this.Load += new System.EventHandler(this.myRequests_Load);
            this.navPan.ResumeLayout(false);
            this.navPan.PerformLayout();
            this.cardPan.ResumeLayout(false);
            this.cardPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPan;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label subheadingLabel;
        private System.Windows.Forms.Panel cardPan;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox statusFilter;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.DataGridView requestGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.Label emptyLabel;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button cancelRequestBtn;
        private System.Windows.Forms.Button newRequestBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}
