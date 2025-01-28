//Start laibrary
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//End laibrary

namespace OurSystemCode
{
    public partial class Employees_tasks : Form
    {
        private bool isDragging = false;
        private Point mouseOffset;
        private string name;
        private string role;

        public Employees_tasks(string role, string name)
        {

            InitializeComponent();
            this.Size = new Size(811, 490);
            this.role = role;
            this.name = name;

            usernameLabel.Text = name;
            userroleLabel.Text = role;
            usernameLabel.TabStop = false;
            userroleLabel.TabStop = false;

            this.MouseDown += new MouseEventHandler(Employees_tasks_MouseDown);
            this.MouseMove += new MouseEventHandler(Employees_tasks_MouseMove);
            this.MouseUp += new MouseEventHandler(Employees_tasks_MouseUp);

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Role is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if ("EMPLOYEE".Equals(role, StringComparison.OrdinalIgnoreCase) || "IT".Equals(role, StringComparison.OrdinalIgnoreCase))
            {

                btnEmployeeMang.Visible = false;
                btnSittings.Location = new System.Drawing.Point(5, 509);
            }
            else
            {

                btnEmployeeMang.Visible = true;
                btnSittings.Location = new System.Drawing.Point(5, 559);
            }

            toolTip1.SetToolTip(button8, "Close applacation");
            toolTip1.SetToolTip(buttonMinimize, "Minimize window");

            LoadEmployeeTasks();

            
            EmployeesTasksView.ReadOnly = true; 

        }

        // Load Employee Tasks View
        private void LoadEmployeeTasks()
        {
            EmployeesTasksView.AutoGenerateColumns = true;
            EmployeesTasksView.DataSource = null;

            DatabaseOperations dbOps = new DatabaseOperations();
            DataSet ds = dbOps.getData("SELECT * FROM whms_schema.EmployeeTasks");

            if (ds != null && ds.Tables.Count > 0)
            {
                EmployeesTasksView.DataSource = ds.Tables[0];
            }

            EmployeesTasksView.Refresh();
        }
        //End Employees Tasks View

        // Update Task Status on Double Click
        private void EmployeesTasksView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = EmployeesTasksView.Rows[e.RowIndex];
            string currentStatus = row.Cells["Status"].Value.ToString();

            ComboBox statusComboBox = new ComboBox();
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Items.AddRange(new string[] { "Pending", "In Progress", "Completed" });
            statusComboBox.SelectedItem = currentStatus;

            Form statusForm = new Form();
            statusForm.Text = "Update Task Status";
            statusForm.Size = new Size(300, 150);
            statusForm.StartPosition = FormStartPosition.CenterScreen;
            statusComboBox.Location = new Point(20, 20);

            statusComboBox.SelectedIndexChanged += (s, args) =>
            {
                string newStatus = statusComboBox.SelectedItem.ToString();

                // Check if the status has actually changed
                if (newStatus == currentStatus)
                {
                    MessageBox.Show("The task status is already the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusForm.Close();
                    return;
                }

                string taskName = row.Cells["TaskName"].Value.ToString();
                string lastModifiedBy = name;

                string query = "UPDATE whms_schema.EmployeeTasks SET Status = @Status, LastModifiedBy = @LastModifiedBy WHERE TaskName = @TaskName";
                Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Status", newStatus },
                { "@TaskName", taskName },
                { "@LastModifiedBy", lastModifiedBy }
            };

                DatabaseOperations dbOps = new DatabaseOperations();
                int result = dbOps.setDataWithParameter(query, parameters);

                if (result > 0)
                {
                    row.Cells["Status"].Value = newStatus;
                    MessageBox.Show("Task Status Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployeeTasks();
                    statusForm.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update Task Status. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            statusForm.Controls.Add(statusComboBox);
            statusForm.ShowDialog();
        }
        //End Update Task Status


        private void Employees_tasks_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = e.Location;
            }
        }

        private void Employees_tasks_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - mouseOffset.X;
                this.Top += e.Y - mouseOffset.Y;
            }
        }

        private void Employees_tasks_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Employees_tasks_Load(object sender, EventArgs e)
        {
            this.Size = new Size(811, 490);
            Form1.ApplyRoundedCorners(this, 20);

        }


        //Navigation
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboardScreen = new Dashboard(role, name);
            this.Hide();
            dashboardScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataEntry dataEntryScreen = new DataEntry(role, name);
            this.Hide();
            dataEntryScreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports reportsScreen = new Reports(role, name);
            this.Hide();
            reportsScreen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Suppliers suppliersScreen = new Suppliers(role, name);
            this.Hide();
            suppliersScreen.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InventoryMan inventoryManScreen = new InventoryMan(role, name);
            this.Hide();
            inventoryManScreen.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 logoutScreen = new Form1();
            this.Close();
            logoutScreen.Show();
        }


        private void btnSittings_Click(object sender, EventArgs e)
        {
            Sittings SittingsScreen = new Sittings(role, name);
            this.Hide();
            SittingsScreen.Show();

        }

        private void btnEmployeeMang_Click(object sender, EventArgs e)
        {
            Employees EmployeesScreen = new Employees(role, name);
            this.Hide();
            EmployeesScreen.Show();
        }

        private void btnEmployeesTasks_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        //End Navigation

    }//End class
}

