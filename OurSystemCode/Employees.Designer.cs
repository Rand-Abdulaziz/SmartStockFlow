namespace OurSystemCode
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAssignTask;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.btnAssignTask = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.DashTitle = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteSelectedTasks = new System.Windows.Forms.Button();
            this.dgvEmployeeTasks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSittings = new System.Windows.Forms.Button();
            this.btnEmployeeMang = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnEmployeesTasks = new System.Windows.Forms.Button();
            this.BtnInventoryMan = new System.Windows.Forms.Button();
            this.BtnSuoliers = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            this.BtnDataEntry = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userroleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRFIDConfigure = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTasks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.Location = new System.Drawing.Point(477, 650);
            this.btnAssignTask.Margin = new System.Windows.Forms.Padding(6);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(200, 58);
            this.btnAssignTask.TabIndex = 2;
            this.btnAssignTask.Text = "Assign Task";
            this.btnAssignTask.UseVisualStyleBackColor = true;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.buttonMinimize);
            this.panel4.Controls.Add(this.DashTitle);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Location = new System.Drawing.Point(340, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1269, 208);
            this.panel4.TabIndex = 7;
            this.panel4.Resize += new System.EventHandler(this.panel4_Resize);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1196, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.Location = new System.Drawing.Point(1155, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(35, 39);
            this.buttonMinimize.TabIndex = 5;
            this.buttonMinimize.Text = "-";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click_1);
            // 
            // DashTitle
            // 
            this.DashTitle.AutoSize = true;
            this.DashTitle.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.DashTitle.Location = new System.Drawing.Point(30, 29);
            this.DashTitle.Name = "DashTitle";
            this.DashTitle.Size = new System.Drawing.Size(448, 50);
            this.DashTitle.TabIndex = 3;
            this.DashTitle.Text = "Employees management";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1228, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 39);
            this.button8.TabIndex = 4;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnDeleteSelectedTasks);
            this.panel3.Controls.Add(this.dgvEmployeeTasks);
            this.panel3.Controls.Add(this.btnAssignTask);
            this.panel3.Location = new System.Drawing.Point(356, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1239, 792);
            this.panel3.TabIndex = 9;
            // 
            // btnDeleteSelectedTasks
            // 
            this.btnDeleteSelectedTasks.Location = new System.Drawing.Point(477, 720);
            this.btnDeleteSelectedTasks.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteSelectedTasks.Name = "btnDeleteSelectedTasks";
            this.btnDeleteSelectedTasks.Size = new System.Drawing.Size(200, 58);
            this.btnDeleteSelectedTasks.TabIndex = 5;
            this.btnDeleteSelectedTasks.Text = "Delete Tasks";
            this.btnDeleteSelectedTasks.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedTasks.Visible = false;
            this.btnDeleteSelectedTasks.Click += new System.EventHandler(this.btnDeleteSelectedTasks_Click);
            // 
            // dgvEmployeeTasks
            // 
            this.dgvEmployeeTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeTasks.Location = new System.Drawing.Point(3, 1);
            this.dgvEmployeeTasks.Name = "dgvEmployeeTasks";
            this.dgvEmployeeTasks.RowHeadersWidth = 82;
            this.dgvEmployeeTasks.RowTemplate.Height = 35;
            this.dgvEmployeeTasks.Size = new System.Drawing.Size(1236, 581);
            this.dgvEmployeeTasks.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnRFIDConfigure);
            this.panel1.Controls.Add(this.btnSittings);
            this.panel1.Controls.Add(this.btnEmployeeMang);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnEmployeesTasks);
            this.panel1.Controls.Add(this.BtnInventoryMan);
            this.panel1.Controls.Add(this.BtnSuoliers);
            this.panel1.Controls.Add(this.BtnReports);
            this.panel1.Controls.Add(this.BtnDataEntry);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(330, 911);
            this.panel1.TabIndex = 14;
            // 
            // btnSittings
            // 
            this.btnSittings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSittings.FlatAppearance.BorderSize = 0;
            this.btnSittings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSittings.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSittings.Image = ((System.Drawing.Image)(resources.GetObject("btnSittings.Image")));
            this.btnSittings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSittings.Location = new System.Drawing.Point(5, 559);
            this.btnSittings.Margin = new System.Windows.Forms.Padding(10);
            this.btnSittings.Name = "btnSittings";
            this.btnSittings.Size = new System.Drawing.Size(320, 50);
            this.btnSittings.TabIndex = 3;
            this.btnSittings.Text = "Settings";
            this.btnSittings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSittings.UseVisualStyleBackColor = true;
            this.btnSittings.Click += new System.EventHandler(this.btnSittings_Click);
            // 
            // btnEmployeeMang
            // 
            this.btnEmployeeMang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeMang.FlatAppearance.BorderSize = 0;
            this.btnEmployeeMang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeMang.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEmployeeMang.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeMang.Image")));
            this.btnEmployeeMang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeMang.Location = new System.Drawing.Point(5, 509);
            this.btnEmployeeMang.Margin = new System.Windows.Forms.Padding(10);
            this.btnEmployeeMang.Name = "btnEmployeeMang";
            this.btnEmployeeMang.Size = new System.Drawing.Size(320, 50);
            this.btnEmployeeMang.TabIndex = 2;
            this.btnEmployeeMang.Text = "Employees management";
            this.btnEmployeeMang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeMang.UseVisualStyleBackColor = true;
            this.btnEmployeeMang.Click += new System.EventHandler(this.btnEmployeeMang_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(5, 856);
            this.button7.Margin = new System.Windows.Forms.Padding(10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(320, 50);
            this.button7.TabIndex = 1;
            this.button7.Text = "Logout";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnEmployeesTasks
            // 
            this.btnEmployeesTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeesTasks.FlatAppearance.BorderSize = 0;
            this.btnEmployeesTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesTasks.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEmployeesTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeesTasks.Image")));
            this.btnEmployeesTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeesTasks.Location = new System.Drawing.Point(5, 459);
            this.btnEmployeesTasks.Margin = new System.Windows.Forms.Padding(10);
            this.btnEmployeesTasks.Name = "btnEmployeesTasks";
            this.btnEmployeesTasks.Size = new System.Drawing.Size(320, 50);
            this.btnEmployeesTasks.TabIndex = 1;
            this.btnEmployeesTasks.Text = "Employees tasks";
            this.btnEmployeesTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeesTasks.UseVisualStyleBackColor = true;
            this.btnEmployeesTasks.Click += new System.EventHandler(this.btnEmployeesTasks_Click);
            // 
            // BtnInventoryMan
            // 
            this.BtnInventoryMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInventoryMan.FlatAppearance.BorderSize = 0;
            this.BtnInventoryMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventoryMan.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BtnInventoryMan.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventoryMan.Image")));
            this.BtnInventoryMan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventoryMan.Location = new System.Drawing.Point(5, 409);
            this.BtnInventoryMan.Margin = new System.Windows.Forms.Padding(10);
            this.BtnInventoryMan.Name = "BtnInventoryMan";
            this.BtnInventoryMan.Size = new System.Drawing.Size(320, 50);
            this.BtnInventoryMan.TabIndex = 1;
            this.BtnInventoryMan.Text = "Invontry management";
            this.BtnInventoryMan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInventoryMan.UseVisualStyleBackColor = true;
            this.BtnInventoryMan.Click += new System.EventHandler(this.BtnInventoryMan_Click);
            // 
            // BtnSuoliers
            // 
            this.BtnSuoliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSuoliers.FlatAppearance.BorderSize = 0;
            this.BtnSuoliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuoliers.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BtnSuoliers.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuoliers.Image")));
            this.BtnSuoliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSuoliers.Location = new System.Drawing.Point(5, 359);
            this.BtnSuoliers.Margin = new System.Windows.Forms.Padding(10);
            this.BtnSuoliers.Name = "BtnSuoliers";
            this.BtnSuoliers.Size = new System.Drawing.Size(320, 50);
            this.BtnSuoliers.TabIndex = 1;
            this.BtnSuoliers.Text = "Suppliers management";
            this.BtnSuoliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSuoliers.UseVisualStyleBackColor = true;
            this.BtnSuoliers.Click += new System.EventHandler(this.BtnSuoliers_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReports.FlatAppearance.BorderSize = 0;
            this.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReports.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BtnReports.Image = ((System.Drawing.Image)(resources.GetObject("BtnReports.Image")));
            this.BtnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReports.Location = new System.Drawing.Point(5, 309);
            this.BtnReports.Margin = new System.Windows.Forms.Padding(10);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(320, 50);
            this.BtnReports.TabIndex = 1;
            this.BtnReports.Text = "Reports";
            this.BtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReports.UseVisualStyleBackColor = true;
            this.BtnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // BtnDataEntry
            // 
            this.BtnDataEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDataEntry.FlatAppearance.BorderSize = 0;
            this.BtnDataEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDataEntry.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BtnDataEntry.Image = ((System.Drawing.Image)(resources.GetObject("BtnDataEntry.Image")));
            this.BtnDataEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDataEntry.Location = new System.Drawing.Point(5, 259);
            this.BtnDataEntry.Margin = new System.Windows.Forms.Padding(10);
            this.BtnDataEntry.Name = "BtnDataEntry";
            this.BtnDataEntry.Size = new System.Drawing.Size(320, 50);
            this.BtnDataEntry.TabIndex = 1;
            this.BtnDataEntry.Text = "Data Entry";
            this.BtnDataEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDataEntry.UseVisualStyleBackColor = true;
            this.BtnDataEntry.Click += new System.EventHandler(this.BtnDataEntry_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(5, 209);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(320, 50);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userroleLabel);
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 204);
            this.panel2.TabIndex = 0;
            // 
            // userroleLabel
            // 
            this.userroleLabel.AutoSize = true;
            this.userroleLabel.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.userroleLabel.Location = new System.Drawing.Point(114, 170);
            this.userroleLabel.Name = "userroleLabel";
            this.userroleLabel.Size = new System.Drawing.Size(73, 21);
            this.userroleLabel.TabIndex = 8;
            this.userroleLabel.Text = "User role";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.Location = new System.Drawing.Point(107, 146);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 21);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "User name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRFIDConfigure
            // 
            this.btnRFIDConfigure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRFIDConfigure.FlatAppearance.BorderSize = 0;
            this.btnRFIDConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRFIDConfigure.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRFIDConfigure.Image = ((System.Drawing.Image)(resources.GetObject("btnRFIDConfigure.Image")));
            this.btnRFIDConfigure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRFIDConfigure.Location = new System.Drawing.Point(5, 609);
            this.btnRFIDConfigure.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnRFIDConfigure.Name = "btnRFIDConfigure";
            this.btnRFIDConfigure.Size = new System.Drawing.Size(320, 53);
            this.btnRFIDConfigure.TabIndex = 6;
            this.btnRFIDConfigure.Text = "RFID Reader";
            this.btnRFIDConfigure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRFIDConfigure.UseVisualStyleBackColor = true;
            this.btnRFIDConfigure.Click += new System.EventHandler(this.btnRFIDConfigure_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 911);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees Management";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTasks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label DashTitle;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSittings;
        private System.Windows.Forms.Button btnEmployeeMang;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnEmployeesTasks;
        private System.Windows.Forms.Button BtnInventoryMan;
        private System.Windows.Forms.Button BtnSuoliers;
        private System.Windows.Forms.Button BtnReports;
        private System.Windows.Forms.Button BtnDataEntry;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDeleteSelectedTasks;
        private System.Windows.Forms.DataGridView dgvEmployeeTasks;
        private System.Windows.Forms.Label userroleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button btnRFIDConfigure;
    }
}
