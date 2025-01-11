namespace OurSystemCode
{
    partial class EmployeeTasks
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTasks));

            // Initialize panels and buttons
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnDataEntry = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.userroleBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnFinishTask = new System.Windows.Forms.Button();

            // Panel1 (Sidebar)
            this.panel1.BackColor = System.Drawing.Color.FromArgb(215, 237, 255);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnEmployeeManagement);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnSuppliers);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnDataEntry);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Size = new System.Drawing.Size(250, 720);

            // Panel2 (User Info)
            this.panel2.Controls.Add(this.usernameBox);
            this.panel2.Controls.Add(this.userroleBox);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Size = new System.Drawing.Size(250, 150);

            // Username TextBox
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.usernameBox.Location = new System.Drawing.Point(50, 100);
            this.usernameBox.Size = new System.Drawing.Size(150, 25);
            this.usernameBox.Text = "Employee";

            // User Role TextBox
            this.userroleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userroleBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.userroleBox.Location = new System.Drawing.Point(50, 120);
            this.userroleBox.Size = new System.Drawing.Size(150, 25);
            this.userroleBox.Text = "Employee";

            // Profile Picture
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("profile_icon")));
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.Location = new System.Drawing.Point(80, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // Sidebar Buttons
            InitializeSidebarButton(this.btnDashboard, "Dashboard", 150, BtnDashboard_Click);
            InitializeSidebarButton(this.btnDataEntry, "Data Entry", 200, BtnDataEntry_Click);
            InitializeSidebarButton(this.btnReports, "Reports", 250, BtnReports_Click);
            InitializeSidebarButton(this.btnSuppliers, "Suppliers", 300, BtnSuppliers_Click);
            InitializeSidebarButton(this.btnInventory, "Inventory", 350, BtnInventory_Click);
            InitializeSidebarButton(this.btnEmployeeManagement, "Employee Management", 400, BtnEmployeeManagement_Click);
            InitializeSidebarButton(this.btnSettings, "Settings", 450, BtnSettings_Click);
            InitializeSidebarButton(this.buttonLogout, "Logout", 500, ButtonLogout_Click);

            // Panel3 (Main Content)
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.labelTitle);
            this.panel3.Controls.Add(this.btnFinishTask);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;

            // Title Label
            this.labelTitle.Text = "Employee Tasks";
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(270, 30);

            // Finish Task Button
            this.btnFinishTask.Text = "Finish Task";
            this.btnFinishTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFinishTask.Size = new System.Drawing.Size(150, 40);
            this.btnFinishTask.Location = new System.Drawing.Point(270, 100);
            this.btnFinishTask.Click += new System.EventHandler(this.BtnFinishTask_Click);

            // EmployeeTasks Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeTasks";
        }

        private void InitializeSidebarButton(System.Windows.Forms.Button button, string text, int top, System.EventHandler clickEvent)
        {
            button.Dock = System.Windows.Forms.DockStyle.Top;
            button.Text = text;
            button.Size = new System.Drawing.Size(250, 50);
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Click += clickEvent;
            button.Top = top;
            button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogout, btnSettings, btnEmployeeManagement, btnInventory, btnSuppliers, btnReports, btnDataEntry, btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernameBox, userroleBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnFinishTask;
    }
}
