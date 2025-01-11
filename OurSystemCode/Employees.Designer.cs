namespace OurSystemCode
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// UI Components
        /// </summary>
        private System.Windows.Forms.DataGridView dgvEmployeeTasks;
        private System.Windows.Forms.ProgressBar progressBarTaskCompletion;
        private System.Windows.Forms.Button btnAssignTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox userroleBox;
        private System.Windows.Forms.PictureBox pictureBox1;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.userroleBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvEmployeeTasks = new System.Windows.Forms.DataGridView();
            this.progressBarTaskCompletion = new System.Windows.Forms.ProgressBar();
            this.btnAssignTask = new System.Windows.Forms.Button();

            // Panel1 (Sidebar)
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Size = new System.Drawing.Size(250, 600);
            this.panel1.Controls.Add(this.panel2);

            // Panel2 (User Info)
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Size = new System.Drawing.Size(250, 150);
            this.panel2.Controls.Add(this.usernameBox);
            this.panel2.Controls.Add(this.userroleBox);
            this.panel2.Controls.Add(this.pictureBox1);

            // Username TextBox
            this.usernameBox.Location = new System.Drawing.Point(70, 100);
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
            this.usernameBox.ReadOnly = true;

            // Userrole TextBox
            this.userroleBox.Location = new System.Drawing.Point(70, 120);
            this.userroleBox.Size = new System.Drawing.Size(100, 20);
            this.userroleBox.ReadOnly = true;

            // Profile Picture
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 20);
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // DataGridView for Tasks
            this.dgvEmployeeTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeTasks.Location = new System.Drawing.Point(270, 50);
            this.dgvEmployeeTasks.Size = new System.Drawing.Size(600, 300);
            this.dgvEmployeeTasks.Columns.Add("TaskName", "Task Name");
            this.dgvEmployeeTasks.Columns.Add("AssignedTo", "Assigned To");
            this.dgvEmployeeTasks.Columns.Add("Status", "Status");
            this.dgvEmployeeTasks.Columns.Add("Deadline", "Deadline");


            // Assign Task Button
            this.btnAssignTask.Location = new System.Drawing.Point(880, 50);
            this.btnAssignTask.Size = new System.Drawing.Size(100, 30);
            this.btnAssignTask.Text = "Assign Task";
            this.btnAssignTask.UseVisualStyleBackColor = true;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);

            // Employees Form Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dgvEmployeeTasks);
            this.Controls.Add(this.progressBarTaskCompletion);
            this.Controls.Add(this.btnAssignTask);
            this.Controls.Add(this.panel1);
            this.Name = "Employees";
            this.Text = "Employees Management";
            this.Load += new System.EventHandler(this.Employees_Load);

            // Finalizing Layout
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTasks)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
