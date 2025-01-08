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
        public Suppliers()
        {
            InitializeComponent();
            this.Size = new Size(811, 490);
        }

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

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard DashboardScreen = new Dashboard(role, name);
            this.Hide();
            DashboardScreen.Show();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            usernameBox.Text = name;
            userroleBox.Text = role;
            usernameBox.TabStop = false;
            userroleBox.TabStop = false;

            OBSuppliersPan.Visible = false;


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

        private void button1_Click(object sender, EventArgs e)
        {
            DataEntry DataEntryScreen = new DataEntry(role, name);
            this.Hide();
            DataEntryScreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports ReportsScreen = new Reports(role, name);
            this.Hide();
            ReportsScreen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InventoryMan InventoryManScreen = new InventoryMan(role, name);
            this.Hide();
            InventoryManScreen.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employees EmployeesScreen = new Employees(role, name);
            this.Hide();
            EmployeesScreen.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Role is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if ("EMPLOYEE".Equals(role, StringComparison.OrdinalIgnoreCase))
            {
                Sittings SittingsScreen = new Sittings(role, name);
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

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 LogoutScreen = new Form1();
            this.Close();
            LogoutScreen.Show();
        }

        private void OBcloseSup_Click(object sender, EventArgs e)
        {
            OBSuppliersPan.Visible = false;
        }

        private void pictureEye_Click(object sender, EventArgs e)
        {
            OBSuppliersPan.Visible = true;
            tableLayoutPanelAddSup.Visible = true;
            DeleteSupPan.Visible = false;
            tableLayoutFilterSup.Visible = false;
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OBSuppliersPan.Visible = true;
            DeleteSupPan.Visible = true;
            OBbuttonSup.Text = "Delete";
            OBlapelSup.Text = "Delete Suppler";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OBSuppliersPan.Visible = true;
            tableLayoutFilterSup.Visible = true;
            OBbuttonSup.Text = "Filter";
            OBlapelSup.Text = "Filtering Suppler";
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PrintEntryData();
        }

        private void SearchBoxSuppliers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM whms_schema.Suppliers " +
                        "WHERE Supplier_ID LIKE '%" + SearchBoxSuppliers.Text + "%' " +
                        "OR SupplierName LIKE '%" + SearchBoxSuppliers.Text + "%' " +
                        "OR SupplierLocation LIKE '%" + SearchBoxSuppliers.Text + "%' " +
                        "OR SupplierContact LIKE '%" + SearchBoxSuppliers.Text + "%'";

                DatabaseOperations dbOps = new DatabaseOperations();
                DataSet ds = dbOps.getData(query);
                SuppliersView.DataSource = ds.Tables[0];
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
            try
            {
                string supplierName = InsertNameBoxSup.Text;
                string supplierLocation = IsertSizeBoxS.Text;
                string supplierContact = QuantityNameBox.Text;

               
                if (!string.IsNullOrEmpty(supplierName) &&
                    !string.IsNullOrEmpty(supplierLocation) &&
                    !string.IsNullOrEmpty(supplierContact))
                {
                   
                    string query = $"INSERT INTO whms_schema.Suppliers (SupplierName, SupplierLocation, SupplierContact) " +
                                   $"VALUES ('{supplierName}', '{supplierLocation}', '{supplierContact}')";
                    DatabaseOperations dbOps = new DatabaseOperations();
                    dbOps.setData(query, "Supplier added successfully.");

                  
                    SuppliersView.Update();

                    MessageBox.Show("Supplier added successfully.");

                    // إضافة بيانات إلى الجداول المرتبطة (مثل AuditTrail أو PurchaseOrders)
                    //int supplierID = dbOps.GetLastInsertedID(); // افترض وجود طريقة للحصول على الـ ID الأخير المضاف
                    //if (supplierID > 0)
                    //{
                    //    // إضافة بيانات إلى جدول AuditTrail
                    //    query = $"INSERT INTO whms_schema.AuditTrail (Supplier_ID, User_ID, ActionType) " +
                    //            $"VALUES ({supplierID}, {userID}, 'Added')";
                    //    dbOps.setData(query, "Audit trail created.");

                    //    // إضافة بيانات إلى جدول PurchaseOrders (إذا لزم الأمر)
                    //    query = $"INSERT INTO whms_schema.PurchaseOrders (Supplier_ID) " +
                    //            $"VALUES ({supplierID})";
                    //    dbOps.setData(query, "Purchase order linked to supplier.");
                    //}

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
                    }

                    
                    SuppliersView.Update();

                    //// حذف البيانات المرتبطة بالمورد من الجداول الأخرى
                    //// افترض أن لدينا طريقة للحصول على الـ SupplierID بعد الحذف
                    //int supplierIDToDelete = int.Parse(supplierID); // استخدم الـ SupplierID المأخوذ من المدخلات
                    //if (supplierIDToDelete > 0)
                    //{
                    //    // حذف بيانات المورد من جداول أخرى مثل AuditTrail أو PurchaseOrders
                    //    query = $"DELETE FROM whms_schema.AuditTrail WHERE Supplier_ID = {supplierIDToDelete}";
                    //    dbOps.setData(query, "Audit trail deleted.");

                    //    query = $"DELETE FROM whms_schema.PurchaseOrders WHERE Supplier_ID = {supplierIDToDelete}";
                    //    dbOps.setData(query, "Purchase order deleted.");
                    //}

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
    }
}
