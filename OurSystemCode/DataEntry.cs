using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
//using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace OurSystemCode
{
    public partial class DataEntry : Form
    {
        DatabaseOperations dbOps = new DatabaseOperations();
        string query;
        DataSet ds;
        String name;
        String role;

        private bool isDragging = false;
        private Point mouseOffset;

       
     
        public DataEntry(String role , String name)
        {
            InitializeComponent();
            this.Size = new Size(811, 490);
            this.role = role;
            this.name = name;
           

        }



        private void panel4_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //Start DataEntry Load
        private void DataEntry_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = name;
            userroleLabel.Text = role;
            usernameLabel.TabStop = false;
            userroleLabel.TabStop = false;
            OBItemPan.Visible = false;


            //Exparation date for Filtering
            FilExpirationDateInsertBox.Format = DateTimePickerFormat.Custom;
            FilExpirationDateInsertBox.CustomFormat = " "; 
            FilExpirationDateInsertBox.ShowCheckBox = true;
            
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Role is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

 
            if ("EMPLOYEE".Equals(role, StringComparison.OrdinalIgnoreCase))
            {

                btnEmployeeMang.Visible = false;
                btnSittings.Location = new System.Drawing.Point(5, 509);
            }
            else if ("IT".Equals(role, StringComparison.OrdinalIgnoreCase))
            {

                btnEmployeeMang.Visible = false;
                btnSittings.Location = new System.Drawing.Point(5, 509);
                pictureEye.Visible = false;
                pictureBox2.Visible=false;
              

            }
            else
            {
                AddDeleteButtonToGrid();

                btnEmployeeMang.Visible = true;
                btnEmployeesTasks.Visible = false;
                btnEmployeeMang.Location = new System.Drawing.Point(5, 459);
                btnSittings.Location = new System.Drawing.Point(5, 509);
            }

            int cornerRadius = 20;
            Form1.ApplyRoundedCorners(this, cornerRadius);

         
            this.MouseDown += new MouseEventHandler(DataEntry_MouseDown);
            this.MouseMove += new MouseEventHandler(DataEntry_MouseMove);
            this.MouseUp += new MouseEventHandler(DataEntry_MouseUp);

            try
            {

                string query = "SELECT * FROM whms_schema.Item;";


                DatabaseOperations dbOps = new DatabaseOperations();
                DataSet ds = dbOps.getData(query);
                DataEntryView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            toolTip1.SetToolTip(button8, "Close applacation");
            toolTip1.SetToolTip(buttonMinimize, "Minimize window");
            toolTip1.SetToolTip(pictureEye, "Add Item");
            toolTip1.SetToolTip(pictureBox2, "Delete Item");
            toolTip1.SetToolTip(DeleteSelectedItemsBtn, "Delete Items");
            toolTip1.SetToolTip(pictureBox4, "Filtering Items");
            toolTip1.SetToolTip(EntryDataPrint, "Print");


            foreach (DataGridViewColumn column in DataEntryView.Columns)
            {

                column.ReadOnly = (column.Index != 0);
            }
        }//End DataEntry Load

        private void DataEntry_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = e.Location;
            }
        }


        private void DataEntry_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = this.Left + (e.X - mouseOffset.X);
                this.Top = this.Top + (e.Y - mouseOffset.Y);
            }
        }


        private void DataEntry_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            var reportsForm = new Reports(role, name);
            this.Hide();
            reportsForm.Show();
        }
       
      
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Start Search Box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SaveSelectedItems();

                DatabaseOperations dbOps = new DatabaseOperations();
                string searchText = SearchBoxEntry.Text;

                DateTime searchDate;
                bool isDate = DateTime.TryParse(searchText, out searchDate);

                string query = "SELECT * FROM whms_schema.Item " +
                               "WHERE Name LIKE @Search " +
                               "OR Item_ID LIKE @Search " +
                               "OR Size LIKE @Search " +
                               "OR Locational_ID LIKE @Search " +
                               "OR Cost LIKE @Search " +
                               "OR Category_ID LIKE @Search " +
                               "OR Quantity LIKE @Search ";

                if (isDate)
                {
                    query += "OR ExpirationDate = @SearchDate " +
                             "OR CreatedDate = @SearchDate";
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
                DataEntryView.DataSource = ds.Tables[0];

                RestoreSelectedItems(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //End Search Box



        //Close Panel
        private void button6_Click(object sender, EventArgs e)
        {
            OBItemPan.Visible = false;
            ResetButton();

            string query = "SELECT * FROM whms_schema.Item;";
            DatabaseOperations dbOps = new DatabaseOperations();
            DataSet ds = dbOps.getData(query);
            DataEntryView.DataSource = ds.Tables[0];

        
        }

        String opeartion;
       //Add Icon
        private void pictureEye_Click(object sender, EventArgs e)
        {
           
            ResetButton();
            OBItemPan.Visible = true;
            DeleteItemPan.Visible = false;
            tableLayoutFilter.Visible = false;
            tableLayoutPanelAdd.Visible = true;
            DeleteSelectedItemsBtn.Visible = false;
            OBbutton.Visible = true;
            opeartion = "Add";
            OBlapel.Text = "Add Item";
            OBbutton.Text = "ADD";
        }
        //End Add Icon
        private void AddItemPan_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }

        //Refresh view
       private void LoadDataIntoView()
        {
            DataEntryView.AutoGenerateColumns = true;
            DataEntryView.DataSource = null;

            DataSet ds2 = dbOps.getData("SELECT * FROM whms_schema.Item");
            if (ds2 != null && ds2.Tables.Count > 0)
            {
                DataEntryView.DataSource = ds2.Tables[0];
            }
            DataEntryView.Refresh();
        }
        //End Refresh view

        //// This function checks if any rows are selected in the DataGridView 
        ///and updates the visibility of UI elements accordingly. 
        private void CheckSelectionAndTogglePanel()
        {
            bool hasSelection = false;
           

            foreach (DataGridViewRow row in DataEntryView.Rows)
            {
                if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    hasSelection = true;

                    break;
                }
            }

            
            OBItemPan.Visible = hasSelection;
            DeleteSelectedItemsBtn.Visible = hasSelection;

            OBbutton.Visible = !hasSelection;
            DeleteItemPan.Visible = !hasSelection;
            tableLayoutFilter.Visible = !hasSelection;
            tableLayoutPanelAdd.Visible = !hasSelection;
            opeartion = "CustomDelete";
            OBlapel.Text = "Delete Items";
            
        }
        //End CheckSelectionAndTogglePanel

        //Select
        private void DataEntryView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DataEntryView.IsCurrentCellDirty)
            {
                DataEntryView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void DataEntryView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DataEntryView.Columns[e.ColumnIndex].Name == "Select")
            {
                CheckSelectionAndTogglePanel();
            }
        }
        //Select

        //Add Select Button
        private void AddDeleteButtonToGrid()
        {
            DataSet ds = dbOps.getData("SELECT * FROM whms_schema.Item");
            if (ds != null && ds.Tables.Count > 0)
            {
                
                DataEntryView.DataSource = ds.Tables[0];

               
                if (!DataEntryView.Columns.Contains("Select"))
                {
                    DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn
                    {
                        Name = "Select",
                        HeaderText = "🗑️",
                        Width = 50
                    };
                    DataEntryView.Columns.Insert(0, selectColumn);
                }

            
                DataEntryView.CellValueChanged += DataEntryView_CellValueChanged;
                DataEntryView.CurrentCellDirtyStateChanged += DataEntryView_CurrentCellDirtyStateChanged;
            }

           
            OBItemPan.Visible = false;
            DeleteSelectedItemsBtn.Visible = false;
           


        }
        //End Add Select Button

        //Save ItemIDs for selected items
        private List<string> selectedItemIDs = new List<string>();

        private void SaveSelectedItems()
        {
            selectedItemIDs.Clear();

            foreach (DataGridViewRow row in DataEntryView.Rows)
            {
                if (row.Cells["Select"].Value != null && Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    string itemID = row.Cells["Item_ID"].Value?.ToString();
                    if (!string.IsNullOrEmpty(itemID))
                    {
                        selectedItemIDs.Add(itemID);
                    }
                }
            }
        }
        
        private void RestoreSelectedItems()
        {
            foreach (DataGridViewRow row in DataEntryView.Rows)
            {
                string itemID = row.Cells["Item_ID"].Value?.ToString();
                if (!string.IsNullOrEmpty(itemID) && selectedItemIDs.Contains(itemID))
                {
                    row.Cells["Select"].Value = true;
                }
            }
        }

        //delete selected items
        private void DeleteSelectedItems()
        {
            try
            {
                SaveSelectedItems();
                List<string> selectedIDs = new List<string>();

               
                foreach (DataGridViewRow row in DataEntryView.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                    {
                        string itemID = row.Cells["Item_ID"].Value?.ToString();
                        if (!string.IsNullOrEmpty(itemID))
                        {
                            selectedIDs.Add($"'{itemID}'");
                        }
                    }
                }

                if (selectedIDs.Count > 0)
                {
                   
                    string idsCondition = string.Join(",", selectedIDs);
                    string query = $"DELETE FROM whms_schema.Item WHERE Item_ID IN ({idsCondition})";
                    dbOps.setData(query, "Selected items deleted successfully.");
                    MessageBox.Show("Selected items deleted successfully.");

                    LoadDataIntoView();

                    RestoreSelectedItems();

                }
                else
                {
                    MessageBox.Show("Please select items to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting selected items: " + ex.Message);
            }
        }
        //End delete selected items

        //Add Item
        private void AddItem()
        {
            try
            {
                string itemName = InsertNameBox.Text;
                decimal cost = decimal.Parse(CostInsertBox.Text);
                string size = IsertSizeBox.Text;
                string quantity = QuantityNameBox.Text;
                string category = CatogeryIDInsertBox.Text;
                string location = LocationIDInsertBox.Text;

          
                DateTime createdDate = DateTime.Now;
                DateTime currentDate = DateTime.Now;

                if (!string.IsNullOrEmpty(itemName) &&
                    !string.IsNullOrEmpty(quantity) &&
                    !string.IsNullOrEmpty(size) &&
                    decimal.TryParse(cost.ToString(), out cost) &&
                    int.TryParse(category, out int categoryID) &&
                    int.TryParse(quantity, out int quantityCount) &&
                    int.TryParse(location, out int locationID))
                {
                   
                        query = $"SELECT * FROM whms_schema.Categories WHERE Category_ID = '{categoryID}'";
                        ds = dbOps.getData(query);
                        if (ds == null || ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("The specified Category ID does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        query = $"SELECT * FROM whms_schema.Locations WHERE Location_ID = '{locationID}'";
                        ds = dbOps.getData(query);
                        if (ds == null || ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("The specified Location ID does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                  
                    query = $"INSERT INTO whms_schema.Item (Name, Size, Quantity, Cost, ExpirationDate, Category_ID, Locational_ID ,CreatedDate) " +
                                $"VALUES ('{itemName}', '{size}', {quantityCount}, {cost},'{createdDate.ToString("yyyy-MM-dd")}', {categoryID}, {locationID},'{currentDate.ToString("yyyy-MM-dd")}')";

                        dbOps.setData(query, "Item added successfully.");
                         LoadDataIntoView();
                        MessageBox.Show("Item added successfully.");

                    ResetButton();


                }
                else
                {
                    MessageBox.Show("Please ensure all fields are filled correctly, and that Quantity, Category ID, Location ID, and Cost are numeric.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Add item: " + ex.Message);
            }
        }
        //End Add Item


        //Delete one item
        private void DeleteItem()
        {
            try
            {
                string itemName = ItemNameDelete.Text; 
                string itemID = ItemIDDelete.Text; 

             
                if (!string.IsNullOrEmpty(itemID) || !string.IsNullOrEmpty(itemName))
                {
                    
                    if (!string.IsNullOrEmpty(itemID))
                    {
                        query = $"SELECT * FROM whms_schema.Item WHERE Item_ID = '{itemID}'";
                        ds = dbOps.getData(query);
                        if (ds == null || ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("The specified Item ID does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                       
                        query = $"DELETE FROM whms_schema.Item WHERE Item_ID = '{itemID}'";
                        dbOps.setData(query, "Item deleted successfully.");
                        DataEntryView.DataSource = dbOps.getData("SELECT * FROM whms_schema.Item");
                        DataEntryView.AutoGenerateColumns = true;
                        DataEntryView.DataSource = null;

                        

                        DataSet ds2 = dbOps.getData("SELECT * FROM whms_schema.Item");
                        LoadDataIntoView();
                    }
                    
                    else if (!string.IsNullOrEmpty(itemName))
                    {
                        query = $"SELECT * FROM whms_schema.Item WHERE Name = '{itemName}'";
                        ds = dbOps.getData(query);
                        if (ds == null || ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("The specified Item Name does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        
                        query = $"DELETE FROM whms_schema.Item WHERE Name = '{itemName}'";
                        dbOps.setData(query, "Item deleted successfully.");
                        DataEntryView.AutoGenerateColumns = true;
                        DataEntryView.DataSource = null;

                  

                        DataSet ds2 = dbOps.getData("SELECT * FROM whms_schema.Item");
                        LoadDataIntoView();
                    }


                    MessageBox.Show("Item and related data deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Please provide either Item ID or Item Name.");
                }

                ResetButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }
        }
        //delete one item

        //Filter Item
        private void FilterItem()
        {
            try
            {
                string itemmID = FilterIDBox.Text;
                string itemName = FilterNameBox.Text;
                string costText = FilCostInsertBox.Text;
                string size = FilSizeBox.Text;
                string quantityText = FilQuantityNameBox.Text;
                string categoryText = FilCatogeryIDInsertBox.Text;
                string locationText = FilLocationIDInsertBox.Text;

                string query = "SELECT * FROM whms_schema.Item WHERE 1=1";
                bool hasCondition = false;

                if (!string.IsNullOrEmpty(itemmID) && int.TryParse(itemmID, out int ItemID))
                {
                    query += $" AND Item_ID LIKE '%{ItemID}%'";
                    hasCondition = true;
                }
                if (!string.IsNullOrEmpty(itemName))
                {
                    query += $" AND Name LIKE '%{itemName}%'";
                    hasCondition = true;
                }
                if (!string.IsNullOrEmpty(costText) && decimal.TryParse(costText, out decimal cost))
                {
                    query += $" AND Cost = {cost}";
                    hasCondition = true;
                }
                if (FilExpirationDateInsertBox.Checked)
                {
                    query += $" AND ExpirationDate = '{FilExpirationDateInsertBox.Value.ToString("yyyy-MM-dd")}'";
                    hasCondition = true;
                }
                if (!string.IsNullOrEmpty(size))
                {
                    query += $" AND Size LIKE '%{size}%'";
                    hasCondition = true;
                }
                if (!string.IsNullOrEmpty(quantityText) && int.TryParse(quantityText, out int quantity))
                {
                    query += $" AND Quantity = {quantity}";
                    hasCondition = true;
                }
                if (!string.IsNullOrEmpty(categoryText) && int.TryParse(categoryText, out int categoryID))
                {
                    query += $" AND Category_ID = {categoryID}";
                    hasCondition = true;
                }
                if (!string.IsNullOrEmpty(locationText) && int.TryParse(locationText, out int locationID))
                {
                    query += $" AND Locational_ID = {locationID}";
                    hasCondition = true;
                }

                if (!hasCondition)
                {
                    query = "SELECT * FROM whms_schema.Item";
                }

                ResetButton();

                var ds = dbOps.getData(query);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DataEntryView.DataSource = ds.Tables[0];
                    FilExpirationDateInsertBox.CustomFormat = " ";
                }
                else
                {
                    MessageBox.Show("No items found with the given filters.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering items: " + ex.Message);
            }
        }
        //end Filter Item

        private void ResetButton()
        {
            InsertNameBox.Text = "";
            CostInsertBox.Text = "";
            IsertSizeBox.Text = "";
            QuantityNameBox.Text = "";
            CatogeryIDInsertBox.Text = "";
            LocationIDInsertBox.Text = "";
            ItemNameDelete.Text = "";
            ItemIDDelete.Text = "";
            InsertNameBox.Text = "";
            CostInsertBox.Text = "";
            IsertSizeBox.Text = "";
            QuantityNameBox.Text = "";
            CatogeryIDInsertBox.Text = "";
            LocationIDInsertBox.Text = "";
            FilExpirationDateInsertBox.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (opeartion == "Add")
                {
                    AddItem();
                }
                else if (opeartion == "Delete")
                {
                    DeleteItem();
                    
                }
                else if (opeartion == "Filter")
                {
                    FilterItem();
                }
                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Custom item: " + ex.Message);
            }
        }

        //print
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
            Bitmap bitmap = new Bitmap(this.DataEntryView.Width, this.DataEntryView.Height);
            DataEntryView.DrawToBitmap(bitmap, new Rectangle(0, 0, this.DataEntryView.Width, this.DataEntryView.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        //End print


        //Only Number
        private void ItemIDInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void CatogeryIDInsertBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void LocationIDInsertBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void CostInsertBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void QuantityNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }
        //End Only Number

        //Delete icon
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            ResetButton();
            OBItemPan.Visible = true;
            DeleteItemPan.Visible = true;
            tableLayoutFilter.Visible = false;
            tableLayoutPanelAdd.Visible = false;
            DeleteSelectedItemsBtn.Visible = false;
            OBbutton.Visible = true;
            opeartion = "Delete";
            OBbutton.Text= "Delete";
            OBlapel.Text = "Delete Item";
          
        }
        //End Delete icon


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OBItemPan.Visible = true;
        }

        //Filter icon
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            ResetButton();
            OBItemPan.Visible = true;
            tableLayoutFilter.Visible = true;
            DeleteItemPan.Visible = false;
            tableLayoutPanelAdd.Visible = false;
            OBbutton.Visible = true;
            opeartion = "Filter";
            OBbutton.Text = "Filter";
            OBlapel.Text = "Filtering Items";
           
        }
        //End Filter icon


        private void FilExpirationDateInsertBox_ValueChanged(object sender, EventArgs e)
        {

            FilExpirationDateInsertBox.CustomFormat = "yyyy-MM-dd";


        }

        //print icon
        private void EntryDataPrint_Click(object sender, EventArgs e)
        {
            PrintEntryData();
        }
        //End print icon
        private void ItemIDDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void FilterIDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void FilQuantityNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void FilCatogeryIDInsertBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void FilLocationIDInsertBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        //Navigation
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboardScreen = new Dashboard(role, name);
            this.Hide();
            dashboardScreen.Show();
        }

        private void BtnDataEntry_Click(object sender, EventArgs e)
        {
            this.Show();
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
        //End navigation

        //// Toggle expiration date selection and format
        private void FilExpirationDateInsertBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FilExpirationDateInsertBox.Checked)
            {

                FilExpirationDateInsertBox.Checked = false;
                FilExpirationDateInsertBox.CustomFormat = " ";
            }
            else
            {

                FilExpirationDateInsertBox.Checked = true;
                FilExpirationDateInsertBox.Value = DateTime.Now;
                FilExpirationDateInsertBox.CustomFormat = "yyyy-MM-dd";
            }

        }
        //End Toggle expiration date selection and format

        //Selected items icon
        private void DeleteSelectedItemsBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedItems();
        }
        //End Selected items icon




    }//End class
}
