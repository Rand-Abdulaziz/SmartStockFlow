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
            usernameLabel.Text = name;
            userroleLabel.Text = role;
            usernameLabel.TabStop = false;
            userroleLabel.TabStop = false;

            this.MouseDown += new MouseEventHandler(Employees_MouseDown);
            this.MouseMove += new MouseEventHandler(Employees_MouseMove);
            this.MouseUp += new MouseEventHandler(Employees_MouseUp);

            LoadEmployeeTasks();
            dgvEmployeeTasks.CellDoubleClick += dgvEmployeeTasks_CellDoubleClick;
            AddDeleteButtonToGrid();

            btnEmployeesTasks.Visible = false;
            btnEmployeeMang.Location = new System.Drawing.Point(5, 459);
            btnSittings.Location = new System.Drawing.Point(5, 509);

            toolTip1.SetToolTip(button8, "Close applacation");
            toolTip1.SetToolTip(buttonMinimize, "Minimize window");
            toolTip1.SetToolTip(btnAssignTask, "Assign Task");
            toolTip1.SetToolTip(btnDeleteSelectedTasks, "Delete Selected Tasks");


            foreach (DataGridViewColumn column in dgvEmployeeTasks.Columns)
            {
               
                column.ReadOnly = (column.Index != 0);
            }


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
            dgvEmployeeTasks.AutoGenerateColumns = true;
            dgvEmployeeTasks.DataSource = null;

            DatabaseOperations dbOps = new DatabaseOperations();
            DataSet ds = dbOps.getData("SELECT * FROM whms_schema.EmployeeTasks");

            if (ds != null && ds.Tables.Count > 0)
            {
                dgvEmployeeTasks.DataSource = ds.Tables[0];
            }

            dgvEmployeeTasks.Refresh();
        }


        // Assign New Task
        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            string taskName = Microsoft.VisualBasic.Interaction.InputBox("Enter Task Name:", "Assign New Task", "");
            string assignedTo = Microsoft.VisualBasic.Interaction.InputBox("Assign to Employee:", "Assign New Task", "");

            
            if (string.IsNullOrEmpty(taskName) || string.IsNullOrEmpty(assignedTo))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

       
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd"); 

           
            string status = "Pending";

     
            string query = "INSERT INTO whms_schema.EmployeeTasks (TaskName, AssignedTo, DateAssigned, Status , LastModifiedBy) VALUES (@TaskName, @AssignedTo, @DateAssigned, @Status,@LastModifiedBy)";

            var parameters = new Dictionary<string, object>
            {
                { "@TaskName", taskName },
                { "@AssignedTo", assignedTo },
                { "@DateAssigned", currentDate },
                { "@Status", status },
                { "@LastModifiedBy", name }
            };

        
            DatabaseOperations dbOps = new DatabaseOperations();
            int rowsAffected = dbOps.setDataWithParameter(query, parameters); 

          
            if (rowsAffected > 0)
            {
                LoadEmployeeTasks();
            }
            else
            {
                MessageBox.Show("An error occurred while assigning the task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        // Update Task Status on Double Click

       
       private void dgvEmployeeTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0)
    {
        DataGridViewRow row = dgvEmployeeTasks.Rows[e.RowIndex];
        string currentStatus = row.Cells["Status"].Value.ToString();

        // Check if the new status is the same as the current one
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
}


        private void dgvEmployeeTasks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
       
            foreach (DataGridViewColumn column in dgvEmployeeTasks.Columns)
            {
                column.ReadOnly = true;
            }
        }


        //Delete Tasks
        private void AddDeleteButtonToGrid()
        {
            DatabaseOperations dbOps = new DatabaseOperations();
         
            DataSet ds = dbOps.getData("SELECT * FROM whms_schema.EmployeeTasks");
            if (ds != null && ds.Tables.Count > 0)
            {
                dgvEmployeeTasks.DataSource = ds.Tables[0];

               
                if (!dgvEmployeeTasks.Columns.Contains("Select"))
                {
                    DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn
                    {
                        Name = "Select",
                        HeaderText = "🗑️",
                        Width = 50
                    };
                    dgvEmployeeTasks.Columns.Insert(0, selectColumn);
                }

               
                dgvEmployeeTasks.CellValueChanged += DgvEmployeeTasks_CellValueChanged;
                dgvEmployeeTasks.CurrentCellDirtyStateChanged += DgvEmployeeTasks_CurrentCellDirtyStateChanged;
            }

          
            btnDeleteSelectedTasks.Visible = false;
        }

        private void DgvEmployeeTasks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmployeeTasks.Columns["Select"].Index)
            {
                
                bool anySelected = dgvEmployeeTasks.Rows.Cast<DataGridViewRow>()
                    .Any(row => Convert.ToBoolean(row.Cells["Select"].Value) == true);

               
                btnDeleteSelectedTasks.Visible = anySelected;
            }
        }

        private void DgvEmployeeTasks_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvEmployeeTasks.IsCurrentCellDirty)
            {
                dgvEmployeeTasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }



        private void DeleteSelectedTasks()
        {
            try
            {
                List<string> selectedTaskNames = new List<string>();
                int lastRowIndex = dgvEmployeeTasks.Rows.Count - 1;

                foreach (DataGridViewRow row in dgvEmployeeTasks.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                    {
                        string taskName = row.Cells["TaskName"].Value?.ToString();
                        if (!string.IsNullOrEmpty(taskName))
                        {
                            selectedTaskNames.Add($"'{taskName}'");
                        }
                    }
                }

                if (selectedTaskNames.Count > 0)
                {
                    DatabaseOperations dbOps = new DatabaseOperations();
                    string taskNamesCondition = string.Join(",", selectedTaskNames);
                    string query = $"DELETE FROM whms_schema.EmployeeTasks WHERE TaskName IN ({taskNamesCondition})";
                    dbOps.setData(query, "Selected tasks deleted successfully.");
                    MessageBox.Show("Selected tasks deleted successfully.");
                    btnDeleteSelectedTasks.Visible = true;
                    LoadEmployeeTasks(); 
                }
                else
                {
                    MessageBox.Show("Please select tasks to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting selected tasks: " + ex.Message);
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
            Sittings SittingsScreen = new Sittings(role, name);
            this.Hide();
            SittingsScreen.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 logoutScreen = new Form1();
            this.Close();
            logoutScreen.Show();
        }

        private void btnDeleteSelectedTasks_Click(object sender, EventArgs e)
        {
            DeleteSelectedTasks();
        }

       
    }
}









