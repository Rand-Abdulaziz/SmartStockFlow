using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;  // ✅ Added for Interaction.InputBox

namespace OurSystemCode
{
    public partial class Employees : Form
    {
        private bool isDragging = false;
        private Point mouseOffset;
        private string name;
        private string role;

        public Employees()
        {
            
            InitializeComponent();
            this.Size = new Size(811, 490);

        }

        public Employees(string role, string name)
        {
           
            InitializeComponent();
            this.Size = new Size(811, 490);
            this.role = role;
            this.name = name;
            
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            Form1.ApplyRoundedCorners(this, 20);
            this.Size = new Size(811, 490);
            usernameBox.Text = name;
            userroleBox.Text = role;
            usernameBox.TabStop = false;
            userroleBox.TabStop = false;

            this.MouseDown += new MouseEventHandler(Employees_MouseDown);
            this.MouseMove += new MouseEventHandler(Employees_MouseMove);
            this.MouseUp += new MouseEventHandler(Employees_MouseUp);

            LoadEmployeeTasks();
            dgvEmployeeTasks.CellDoubleClick += dgvEmployeeTasks_CellDoubleClick;

            btnEmployeesTasks.Visible = false;
            btnEmployeeMang.Location = new System.Drawing.Point(5, 459);
            btnSittings.Location = new System.Drawing.Point(5, 509);

            toolTip1.SetToolTip(button8, "Close applacation");
            toolTip1.SetToolTip(buttonMinimize, "Minimize window");
           

        }



        private void Employees_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = e.Location;
            }
        }

        private void Employees_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - mouseOffset.X;
                this.Top += e.Y - mouseOffset.Y;
            }
        }

        private void Employees_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        // Load Initial Employee Tasks
        private void LoadEmployeeTasks()
        {
            dgvEmployeeTasks.Rows.Clear();

            // Example task data
            dgvEmployeeTasks.Rows.Add("Stock Shelves", "John Doe", "In Progress", "2025-01-15");
            dgvEmployeeTasks.Rows.Add("Inventory Check", "Jane Smith", "Completed", "2025-01-12");
            dgvEmployeeTasks.Rows.Add("Order Supplies", "Michael Brown", "Pending", "2025-01-20");
        }

        // Assign New Task
        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            // ✅ FIXED: Using Microsoft.VisualBasic.Interaction.InputBox
            string taskName = Microsoft.VisualBasic.Interaction.InputBox("Enter Task Name:", "Assign New Task", "");
            string assignedTo = Microsoft.VisualBasic.Interaction.InputBox("Assign to Employee:", "Assign New Task", "");
            string deadline = Microsoft.VisualBasic.Interaction.InputBox("Enter Deadline (YYYY-MM-DD):", "Assign New Task", "");

            DateTime taskDeadline;
            if (!string.IsNullOrEmpty(taskName) && !string.IsNullOrEmpty(assignedTo) && DateTime.TryParse(deadline, out taskDeadline))
            {
                dgvEmployeeTasks.Rows.Add(taskName, assignedTo, "Pending", taskDeadline.ToString("yyyy-MM-dd"));
            }
            else
            {
                MessageBox.Show("Please enter valid task details.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Update Task Status on Double Click
        private void dgvEmployeeTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployeeTasks.Rows[e.RowIndex];
                string[] statuses = { "Pending", "In Progress", "Completed" };

                // ✅ FIXED: Using Microsoft.VisualBasic.Interaction.InputBox
                string currentStatus = row.Cells["Status"].Value.ToString();
                string newStatus = Microsoft.VisualBasic.Interaction.InputBox("Update Status (Pending/In Progress/Completed):", "Update Task Status", currentStatus);

                if (statuses.Contains(newStatus))
                {
                    row.Cells["Status"].Value = newStatus;
                }
                else
                {
                    MessageBox.Show("Invalid Status. Please enter one of: Pending, In Progress, Completed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Button Click Events (Navigation)

      

        private void button8_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboardScreen = new Dashboard(role, name);
            this.Hide();
            dashboardScreen.Show();
        }

        private void BtnDataEntry_Click(object sender, EventArgs e)
        {
            DataEntry dataEntryScreen = new DataEntry(role, name);
            this.Hide();
            dataEntryScreen.Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Reports reportsScreen = new Reports(role, name);
            this.Hide();
            reportsScreen.Show();
        }

        private void BtnSuoliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliersScreen = new Suppliers(role, name);
            this.Hide();
            suppliersScreen.Show();
        }

        private void BtnInventoryMan_Click(object sender, EventArgs e)
        {
            InventoryMan inventoryManScreen = new InventoryMan(role, name);
            this.Hide();
            inventoryManScreen.Show();
        }

        private void btnEmployeesTasks_Click(object sender, EventArgs e)
        {
            Employees_tasks EmployeesTasksScreen = new Employees_tasks(role, name);
            this.Hide();
            EmployeesTasksScreen.Show();
        }

        private void btnEmployeeMang_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnSittings_Click(object sender, EventArgs e)
        {
            AdminSittings ASittingsScreen = new AdminSittings(role, name);
            this.Hide();
            ASittingsScreen.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 logoutScreen = new Form1();
            this.Close();
            logoutScreen.Show();
        }
    }
}








