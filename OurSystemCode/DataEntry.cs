using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
//using WMS;

namespace OurSystemCode
{
    public partial class DataEntry : Form
    {
        DatabaseOperations dbOps = new DatabaseOperations();
        string query;
        DataSet ds;

        private bool isDragging = false;
        private Point mouseOffset;

       
        public DataEntry()
        {
            InitializeComponent();
            this.Size = new Size(811, 490);
            this.StartPosition = FormStartPosition.CenterScreen;
           
        }

        String name;
        String role;
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

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard DashboardScreen = new Dashboard(role,name);
            this.Hide();
            DashboardScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void DataEntry_Load(object sender, EventArgs e)
        {
            usernameBox.Text = name;
            userroleBox.Text = role;
            usernameBox.TabStop = false;
            userroleBox.TabStop = false;

            OBItemPan.Visible = false;

            FilExpirationDateInsertBox.Format = DateTimePickerFormat.Custom;
            FilExpirationDateInsertBox.CustomFormat = " "; 
            FilExpirationDateInsertBox.ShowCheckBox = true;

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Role is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            if ("EMPLOYEE".Equals(role, StringComparison.OrdinalIgnoreCase) || "IT".Equals(role, StringComparison.OrdinalIgnoreCase))
            {

                btnEmployeeMang.Visible = false;
                btnSittings.Location = new System.Drawing.Point(5, 459);
            }
            else
            {

                btnEmployeeMang.Visible = true;
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


        }

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
           
            //from raghad
            var reportsForm = new Reports(role, name);//Rand : I pass the role and name to the reports form
            reportsForm.DataEntryGrid = this.DataEntryView; // Pass the DataGridView reference
            this.Hide();
            reportsForm.Show();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            Suppliers SuppliersScreen = new Suppliers(role, name);
            this.Hide();
            SuppliersScreen.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InventoryMan InventoryManScreen = new InventoryMan(role, name);
            this.Hide();
            InventoryManScreen.Show();
        }

        private void btnSittings_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Role is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if ("EMPLOYEE".Equals(role, StringComparison.OrdinalIgnoreCase))
            {
                Sittings SittingsScreen = new Sittings(role , name );
                this.Hide();
                SittingsScreen.Show();

            }
            else
            {

                AdminSittings ASittingsScreen = new AdminSittings(role, name);
                this.Hide();
                ASittingsScreen.Show();
            }

        }

        private void btnEmployeeMang_Click(object sender, EventArgs e)
        {
            Employees EmployeesScreen = new Employees(role, name);
            this.Hide();
            EmployeesScreen.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 LogoutScreen = new Form1();
            this.Close();
            LogoutScreen.Show();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                string query = "SELECT * FROM whms_schema.Item " +
                        "WHERE Name LIKE '%" + SearchBoxEntry.Text + "%' " +
                        "OR Item_ID LIKE '%" + SearchBoxEntry.Text + "%' " +
                        "OR Size LIKE '%" + SearchBoxEntry.Text + "%' " +
                        "OR Locational_ID LIKE '%" + SearchBoxEntry.Text + "%' " +
                         "OR Cost LIKE '%" + SearchBoxEntry.Text + "%' " +
                         "OR ExpirationDate LIKE '%" + SearchBoxEntry.Text + "%' " +
                         "OR Category_ID LIKE '%" + SearchBoxEntry.Text + "%' " +
                        "OR Quantity LIKE '%" + SearchBoxEntry.Text + "%'";

                DatabaseOperations dbOps = new DatabaseOperations();
                DataSet ds = dbOps.getData(query);
                DataEntryView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OBItemPan.Visible = false;
            
        }

        private void pictureEye_Click(object sender, EventArgs e)
        {
            OBItemPan.Visible = true;
            DeleteItemPan.Visible = false;
            tableLayoutFilter.Visible = false;
            tableLayoutPanelAdd.Visible = true;
           
        }

        private void AddItemPan_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }

        private void AddItem()
        {
            try
            {
                string itemName = InsertNameBox.Text;
                decimal cost = decimal.Parse(CostInsertBox.Text);
                string expirationText = ExpirationDateInsertBox.Text;
                string size = IsertSizeBox.Text;
                string quantity = QuantityNameBox.Text;
                string category = CatogeryIDInsertBox.Text;
                string location = LocationIDInsertBox.Text;

               
                if (!string.IsNullOrEmpty(itemName) &&
                    !string.IsNullOrEmpty(quantity) &&
                    !string.IsNullOrEmpty(expirationText) &&
                    !string.IsNullOrEmpty(size) &&
                    decimal.TryParse(cost.ToString(), out cost) &&
                    int.TryParse(category, out int categoryID) &&
                    int.TryParse(quantity, out int quantityCount) &&
                    int.TryParse(location, out int locationID))
                {
                    DateTime expirationDate;
                    if (DateTime.TryParse(expirationText, out expirationDate))
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

                       
                        query = $"INSERT INTO whms_schema.Item (Name, Size, Quantity, Cost, ExpirationDate, Category_ID, Locational_ID) " +
                                $"VALUES ('{itemName}', '{size}', {quantityCount}, {cost}, '{expirationDate.ToString("yyyy-MM-dd")}', {categoryID}, {locationID})";
                        dbOps.setData(query, "Item added successfully.");

                        DataEntryView.Update();

                        MessageBox.Show("Item added successfully.");

                        // إضافة بيانات إلى الجداول المرتبطة (InventoryAlerts, AuditTrail, PurchaseOrders)
                        //int itemID = dbOps.GetLastInsertedID(); // افترض وجود طريقة للحصول على الـ ID الأخير المضاف
                        //if (itemID > 0)
                        //{
                        //    // إضافة بيانات إلى جدول InventoryAlerts
                        //    query = $"INSERT INTO whms_schema.InventoryAlerts (Item_ID) VALUES ({itemID})";
                        //    dbOps.setData(query, "Inventory alert created.");

                        //    // إضافة بيانات إلى جدول AuditTrail
                        //    query = $"INSERT INTO whms_schema.AuditTrail (Item_ID, User_ID, ActionType) " +
                        //            $"VALUES ({itemID}, {userID}, 'Added')";
                        //    dbOps.setData(query, "Audit trail created.");

                        //    // إضافة بيانات إلى جدول PurchaseOrders
                        //    query = $"INSERT INTO whms_schema.PurchaseOrders (Item_ID, Supplier_ID) " +
                        //            $"VALUES ({itemID}, {supplierID})"; // افترض أنه لديك Supplier_ID
                        //    dbOps.setData(query, "Purchase order created.");
                        //}

                    }
                    else
                    {
                        MessageBox.Show("Invalid date format. Please enter a valid date.");
                    }
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
                    }

                  
                    DataEntryView.Update();

                    //// حذف البيانات المرتبطة بالعنصر من الجداول الأخرى
                    //// افترض أن لدينا طريقة للحصول على الـ ItemID بعد الحذف
                    //int itemIDToDelete = int.Parse(itemID); // استخدم الـ ItemID المأخوذ من المدخلات
                    //if (itemIDToDelete > 0)
                    //{
                    //    // حذف بيانات العنصر من جداول أخرى مثل InventoryAlerts, AuditTrail, PurchaseOrders
                    //    query = $"DELETE FROM whms_schema.InventoryAlerts WHERE Item_ID = {itemIDToDelete}";
                    //    dbOps.setData(query, "Inventory alert deleted.");

                    //    query = $"DELETE FROM whms_schema.AuditTrail WHERE Item_ID = {itemIDToDelete}";
                    //    dbOps.setData(query, "Audit trail deleted.");

                    //    query = $"DELETE FROM whms_schema.PurchaseOrders WHERE Item_ID = {itemIDToDelete}";
                    //    dbOps.setData(query, "Purchase order deleted.");
                    //}

                    MessageBox.Show("Item and related data deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Please provide either Item ID or Item Name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }
        }

        private void FilterItem()
        {
            try
            {
                string itemmID = FilterIDBox.Text;
                string itemName = FilterNameBox.Text;
                string costText = FilCostInsertBox.Text;
                string expirationText = FilExpirationDateInsertBox.Text;
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
                if (!string.IsNullOrWhiteSpace(expirationText) &&
                            DateTime.TryParse(expirationText, out DateTime expirationDate) &&
                            expirationDate != DateTime.MinValue)
                {
                    query += $" AND ExpirationDate = '{expirationDate.ToString("yyyy-MM-dd")}'";
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (OBbutton.Text == "Add")
                {
                    AddItem();
                }
                else if (OBbutton.Text == "Delete")
                {
                    DeleteItem();
                }
                else if (OBbutton.Text == "Filter")
                {
                    FilterItem();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Custom item: " + ex.Message);
            }
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
            Bitmap bitmap = new Bitmap(this.DataEntryView.Width, this.DataEntryView.Height);
            DataEntryView.DrawToBitmap(bitmap, new Rectangle(0, 0, this.DataEntryView.Width, this.DataEntryView.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }


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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OBItemPan.Visible = true;
            DeleteItemPan.Visible = true;
            tableLayoutFilter.Visible = false;
            tableLayoutPanelAdd.Visible = false;
            OBbutton.Text= "Delete";
            OBlapel.Text = "Delete Item";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OBItemPan.Visible = true;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            OBItemPan.Visible = true;
            tableLayoutFilter.Visible = true;
            DeleteItemPan.Visible = false;
            tableLayoutPanelAdd.Visible = false;
            OBbutton.Text = "Filter";
            OBlapel.Text = "Filtering Items";
        }

        private void FilExpirationDateInsertBox_ValueChanged(object sender, EventArgs e)
        {
            FilExpirationDateInsertBox.CustomFormat = "yyyy-MM-dd";
        }

        private void EntryDataPrint_Click(object sender, EventArgs e)
        {
            PrintEntryData();
        }

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
    }
}
