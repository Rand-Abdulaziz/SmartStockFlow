using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurSystemCode
{
    public partial class Suppliers : Form
    {
        DatabaseOperations dbOps = new DatabaseOperations();
        string query;
        DataSet ds;

        private bool isDragging = false;
        private Point mouseOffset;
     

        String name;
        String role;
        public Suppliers(String role , String name)
        {
            InitializeComponent();
            this.Size = new Size(811, 490);
            this.role = role;
            this.name= name;
           
        }

        private void panel4_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void Suppliers_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = name;
            userroleLabel.Text = role;
            usernameLabel.TabStop = false;
            userroleLabel.TabStop = false;

            OBSuppliersPan.Visible = false;


            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Role is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if ("EMPLOYEE".Equals(role, StringComparison.OrdinalIgnoreCase) || "IT".Equals(role, StringComparison.OrdinalIgnoreCase))
            {

                btnEmployeeMan.Visible = false;
                btnSittings.Location = new System.Drawing.Point(5, 509);
            }
            else
            {

                btnEmployeeMan.Visible = true;
                btnEmployeesTasks.Visible = false;
                btnEmployeeMan.Location = new System.Drawing.Point(5, 459);
                btnSittings.Location = new System.Drawing.Point(5, 509);
            }

            int cornerRadius = 20;
            Form1.ApplyRoundedCorners(this, cornerRadius);


            this.MouseDown += new MouseEventHandler(Suppliers_MouseDown);
            this.MouseMove += new MouseEventHandler(Suppliers_MouseMove);
            this.MouseUp += new MouseEventHandler(Suppliers_MouseUp);


            try
            {
               
                string query = "SELECT * FROM whms_schema.Suppliers;;";


                DatabaseOperations dbOps = new DatabaseOperations();
                DataSet ds = dbOps.getData(query);
                SuppliersView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            toolTip1.SetToolTip(button8, "Close applacation");
            toolTip1.SetToolTip(buttonMinimize, "Minimize window");
            toolTip1.SetToolTip(pictureEye, "Add Item");
            toolTip1.SetToolTip(pictureBox2, "Delete Item");
            toolTip1.SetToolTip(pictureBox4, "Filtering Supliers");
            toolTip1.SetToolTip(pictureBox3, "Print");

            AddDeleteButtonToSuppliersGrid();

            foreach (DataGridViewColumn column in SuppliersView.Columns)
            {

                column.ReadOnly = (column.Index != 0);
            }
        }

        private void Suppliers_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = e.Location;
            }
        }


        private void Suppliers_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = this.Left + (e.X - mouseOffset.X);
                this.Top = this.Top + (e.Y - mouseOffset.Y);
            }
        }

        private void Suppliers_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        private void PrintEntryData()
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.ShowDialog();
        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.SuppliersView.Width, this.SuppliersView.Height);
            SuppliersView.DrawToBitmap(bitmap, new Rectangle(0, 0, this.SuppliersView.Width, this.SuppliersView.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        private void OBcloseSup_Click(object sender, EventArgs e)
        {
            ResetSupliersButton();
            OBSuppliersPan.Visible = false;

            string query = "SELECT * FROM whms_schema.Suppliers;;";
            DatabaseOperations dbOps = new DatabaseOperations();
            DataSet ds = dbOps.getData(query);
            SuppliersView.DataSource = ds.Tables[0];
        }

        private void pictureEye_Click(object sender, EventArgs e)
        {
            ResetSupliersButton();
            OBSuppliersPan.Visible = true;
            tableLayoutPanelAddSup.Visible = true;
            DeleteSupPan.Visible = false;
            tableLayoutFilterSup.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ResetSupliersButton();
            OBSuppliersPan.Visible = true;
            DeleteSupPan.Visible = true;
            tableLayoutPanelAddSup.Visible = false;
            tableLayoutFilterSup.Visible = false;
            OBbuttonSup.Text = "Delete";
            OBlapelSup.Text = "Delete Suppler";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ResetSupliersButton();
            OBSuppliersPan.Visible = true;
            tableLayoutFilterSup.Visible = true;
            DeleteSupPan.Visible = false;
            tableLayoutPanelAddSup.Visible = false;
            OBbuttonSup.Text = "Filter";
            OBlapelSup.Text = "Filtering Suppler";
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PrintEntryData();
        }

        private void CheckSupplierSelectionAndTogglePanel()
        {
            bool hasSelection = false;

            foreach (DataGridViewRow row in SuppliersView.Rows)
            {
                if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    hasSelection = true;
                    break;
                }
            }

            OBSuppliersPan.Visible = hasSelection;
            DeleteSelectedSuppliersBtn.Visible = hasSelection;

            OBbuttonSup.Visible = !hasSelection;
            DeleteSupPan.Visible = !hasSelection;
            tableLayoutFilterSup.Visible = !hasSelection;
            tableLayoutPanelAddSup.Visible = !hasSelection;
            OBlapelSup.Text = "Delete Suppliers";
        }

        private void SuppliersView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (SuppliersView.IsCurrentCellDirty)
            {
                SuppliersView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void SuppliersView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && SuppliersView.Columns[e.ColumnIndex].Name == "Select")
            {
                SaveSelectedSuppliers();
                CheckSupplierSelectionAndTogglePanel();
            }
        }

        private void AddDeleteButtonToSuppliersGrid()
        {
            try
            {
                string query = "SELECT * FROM whms_schema.Suppliers";
                DataSet ds = dbOps.getData(query);

                if (ds != null && ds.Tables.Count > 0)
                {
                    SuppliersView.DataSource = ds.Tables[0];

                    if (!SuppliersView.Columns.Contains("Select"))
                    {
                        DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn
                        {
                            Name = "Select",
                            HeaderText = "🗑️",
                            Width = 50
                        };
                        SuppliersView.Columns.Insert(0, selectColumn);
                    }

                    SuppliersView.CellValueChanged += SuppliersView_CellValueChanged;
                    SuppliersView.CurrentCellDirtyStateChanged += SuppliersView_CurrentCellDirtyStateChanged;
                }

                OBSuppliersPan.Visible = false;
                DeleteSelectedSuppliersBtn.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }

        private void DeleteSelectedSuppliers()
        {
            try
            {
                List<string> selectedIDs = new List<string>();

                foreach (DataGridViewRow row in SuppliersView.Rows)
                {
                    if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value) == true)
                    {
                        string supplierID = row.Cells["Supplier_ID"].Value?.ToString();
                        if (!string.IsNullOrEmpty(supplierID))
                        {
                            selectedIDs.Add($"'{supplierID}'");
                        }
                    }
                }

                if (selectedIDs.Count > 0)
                {
                    string idsCondition = string.Join(",", selectedIDs);
                    string query = $"DELETE FROM whms_schema.Suppliers WHERE Supplier_ID IN ({idsCondition})";
                    dbOps.setData(query, "Selected suppliers deleted successfully.");
                    MessageBox.Show("Selected suppliers deleted successfully.");

                    AddDeleteButtonToSuppliersGrid(); 
                }
                else
                {
                    MessageBox.Show("Please select suppliers to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting selected suppliers: " + ex.Message);
            }
        }

        private List<string> selectedSupplierIDs = new List<string>();

        private void SaveSelectedSuppliers()
        {
            selectedSupplierIDs.Clear();

            foreach (DataGridViewRow row in SuppliersView.Rows)
            {
                if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    string supplierID = row.Cells["Supplier_ID"].Value?.ToString();
                    if (!string.IsNullOrEmpty(supplierID))
                    {
                        selectedSupplierIDs.Add(supplierID);
                    }
                }
            }
        }

       private void RestoreSelectedSuppliers()
{
    foreach (DataGridViewRow row in SuppliersView.Rows)
    {
        string supplierID = row.Cells["Supplier_ID"].Value?.ToString();
        if (!string.IsNullOrEmpty(supplierID) && selectedSupplierIDs.Contains(supplierID))
        {
            row.Cells["Select"].Value = true;
        }
    }
}



        private void SearchBoxSuppliers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SaveSelectedSuppliers();

                DatabaseOperations dbOps = new DatabaseOperations();

       
                string searchText = SearchBoxSuppliers.Text;

                DateTime searchDate;
                bool isDate = DateTime.TryParse(searchText, out searchDate);

                string query = "SELECT Supplier_ID, SupplierName, SupplierLocation, SupplierContact, CreatedDate " +
                               "FROM whms_schema.Suppliers " +
                               "WHERE Supplier_ID LIKE @Search " +
                               "OR SupplierName LIKE @Search " +
                               "OR SupplierLocation LIKE @Search " +
                               "OR SupplierContact LIKE @Search ";

          
                if (isDate)
                {
                    query += "OR CAST(CreatedDate AS DATE) = @SearchDate"; 
                }

               
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
            { "@Search", "%" + searchText + "%" }
                };

                
                if (isDate)
                {
                    parameters.Add("@SearchDate", searchDate.ToString("yyyy-MM-dd"));
                }

               
                DataSet ds = dbOps.getDataWithParameter(query, parameters);

                
                SuppliersView.DataSource = ds.Tables[0];

                RestoreSelectedSuppliers();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void OBSuppliersPan_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }

        private void AddSupplier()
        {
            DateTime currentDate = DateTime.Now;
            try
            {
                string supplierName = InsertNameBoxSup.Text;
                string supplierLocation = IsertSizeBoxS.Text;
                string supplierContact = QuantityNameBox.Text;

               
                if (!string.IsNullOrEmpty(supplierName) &&
                    !string.IsNullOrEmpty(supplierLocation) &&
                    !string.IsNullOrEmpty(supplierContact))
                {
                   
                    string query = $"INSERT INTO whms_schema.Suppliers (SupplierName, SupplierLocation, SupplierContact,CreatedDate) " +
                                   $"VALUES ('{supplierName}', '{supplierLocation}', '{supplierContact}','{currentDate.ToString("yyyy-MM-dd")}')";
                    DatabaseOperations dbOps = new DatabaseOperations();
                    dbOps.setData(query, "Supplier added successfully.");

                    DataSet ds2 = dbOps.getData("SELECT * FROM whms_schema.Suppliers");
                    if (ds2 != null && ds2.Tables.Count > 0)
                    {
                        SuppliersView.DataSource = ds2.Tables[0];
                    }
                    SuppliersView.Refresh();
                    MessageBox.Show("Supplier added successfully.");

                    ResetSupliersButton();
                }
                else
                {
                    MessageBox.Show("Please ensure all fields are filled correctly.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Add supplier: " + ex.Message);
            }
        }

      
        private void DeleteSupplier()
        {
            
            try
            {
                string supplierName = SupNameDelete.Text; 
                string supplierID = SupIDDelete.Text; 

                
                if (!string.IsNullOrEmpty(supplierID) || !string.IsNullOrEmpty(supplierName))
                {
                    
                    if (!string.IsNullOrEmpty(supplierID))
                    {
                        query = $"SELECT * FROM whms_schema.Suppliers WHERE Supplier_ID = '{supplierID}'";
                        ds = dbOps.getData(query);
                        if (ds == null || ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("The specified Supplier ID does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        
                        query = $"DELETE FROM whms_schema.Suppliers WHERE Supplier_ID = '{supplierID}'";
                        dbOps.setData(query, "Supplier deleted successfully.");

                        DataSet ds2 = dbOps.getData("SELECT * FROM whms_schema.Suppliers");
                        if (ds2 != null && ds2.Tables.Count > 0)
                        {
                            SuppliersView.DataSource = ds2.Tables[0];
                        }
                        SuppliersView.Refresh();
                        MessageBox.Show("Supplier deleted successfully.");
                        ResetSupliersButton();
                    }
                   
                    else if (!string.IsNullOrEmpty(supplierName))
                    {
                        query = $"SELECT * FROM whms_schema.Suppliers WHERE SupplierName = '{supplierName}'";
                        ds = dbOps.getData(query);
                        if (ds == null || ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("The specified Supplier Name does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                      
                        query = $"DELETE FROM whms_schema.Suppliers WHERE SupplierName = '{supplierName}'";
                        dbOps.setData(query, "Supplier deleted successfully.");

                        DataSet ds2 = dbOps.getData("SELECT * FROM whms_schema.Suppliers");
                        if (ds2 != null && ds2.Tables.Count > 0)
                        {
                            SuppliersView.DataSource = ds2.Tables[0];
                        }
                        SuppliersView.Refresh();
                        MessageBox.Show("Supplier deleted successfully.");
                        ResetSupliersButton();
                    }

                    ResetSupliersButton();

                    MessageBox.Show("Supplier and related data deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Please provide either Supplier ID or Supplier Name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting supplier: " + ex.Message);
            }
        }

        private void FilterSupplier()
        {
          

            try
            {
                string SupID = SupplierIDFilBox.Text;
                string supplierName = SupplierNameFilBox.Text;
                string supplierLocation = SupplierLocationFilBox.Text;
                string supplierContact = SupplierContactFilBox.Text;

              
                string query = "SELECT * FROM whms_schema.Suppliers WHERE 1=1"; 

                bool hasCondition = false;  

              
                if (!string.IsNullOrEmpty(SupID) && int.TryParse(SupID, out int SuppID))
                {
                    query += $" AND Item_ID LIKE '%{SuppID}%'";
                    hasCondition = true;
                }
                if (!string.IsNullOrEmpty(supplierName))
                {
                    query += $" AND SupplierName LIKE '%{supplierName}%'";
                    hasCondition = true;
                }
                if (!string.IsNullOrEmpty(supplierLocation))
                {
                    query += $" AND SupplierLocation LIKE '%{supplierLocation}%'";
                    hasCondition = true;
                }
                if (!string.IsNullOrEmpty(supplierContact))
                {
                    query += $" AND SupplierContact LIKE '%{supplierContact}%'";
                    hasCondition = true;
                }

               
                if (!hasCondition)
                {
                    query = "SELECT * FROM whms_schema.Suppliers"; 
                }

               
                var ds = dbOps.getData(query);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                   
                    SuppliersView.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No suppliers found with the given filters.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering suppliers: " + ex.Message);
            }
        }

        private void OBbuttonSup_Click(object sender, EventArgs e)
        {
            try
            {
                if (OBbuttonSup.Text == "Add")
                {
                    AddSupplier();
                }
                else if (OBbuttonSup.Text == "Delete")
                {
                    DeleteSupplier();
                }
                else if (OBbuttonSup.Text == "Filter")
                {
                    FilterSupplier();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Custom item: " + ex.Message);
            }
        }

        private void SupIDInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void SupplierIDFilBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void SupIDDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
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
           this.Show();
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
            Employees EmployeesScreen = new Employees(role, name);
            this.Hide();
            EmployeesScreen.Show();
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

        private void ResetSupliersButton()
        {
            InsertNameBoxSup.Text = "";
            IsertSizeBoxS.Text = "";
            QuantityNameBox.Text = "";
            SupIDDelete.Text = "";
            SupNameDelete.Text = "";
            SupplierContactFilBox.Text = "";
            SupplierLocationFilBox.Text = "";
            SupplierNameFilBox.Text = "";
            SupplierIDFilBox.Text = "";
        }

        private void DeleteSelectedSuppliersBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedSuppliers();
        }
    }
}
