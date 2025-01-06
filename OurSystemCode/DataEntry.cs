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

            AddItemPan.Visible = false;


            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Role is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            if ("EMPLOYEE".Equals(role, StringComparison.OrdinalIgnoreCase))
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
            Reports ReportsScreen = new Reports(role,name);
            this.Hide();
            ReportsScreen.Show();
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
            AddItemPan.Visible = false;
        }

        private void pictureEye_Click(object sender, EventArgs e)
        {
            AddItemPan.Visible = true;
        }

        private void AddItemPan_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = InsertNameBox.Text;
                decimal cost = decimal.Parse(CostInsertBox.Text);
                string expirationText = ExpirationDateInsertBox.Text;  // تاريخ الانتهاء كنص
                string size = IsertSizeBox.Text;
                string quantity = QuantityNameBox.Text;

                // التأكد من صحة البيانات المدخلة
                if (!string.IsNullOrEmpty(itemName) &&
                    !string.IsNullOrEmpty(quantity) &&
                    !string.IsNullOrEmpty(expirationText) &&
                    !string.IsNullOrEmpty(size) &&
                    decimal.TryParse(cost.ToString(), out cost) &&
                    int.TryParse(quantity, out int quantityCount))
                {
                    // محاولة تحويل النص إلى تاريخ
                    DateTime expirationDate;
                    if (DateTime.TryParse(expirationText, out expirationDate))
                    {
                        query = $"SELECT * FROM whms_schema.Item WHERE Item_ID = '{ItemIDInsert.Text}'";
                        ds = dbOps.getData(query);

                        if (ds != null && ds.Tables[0].Rows.Count == 0)
                        {
                            // إدخال البيانات الجديدة
                            query = $"INSERT INTO whms_schema.Item (Name, Size, Quantity, Cost, ExpirationDate) " +
                                    "VALUES ('" + itemName + "', '" + size + "', '" + quantityCount + "', '" + cost + "', '" + expirationDate.ToString("yyyy-MM-dd") + "')";
                            dbOps.setData(query, null);

                            MessageBox.Show("Item added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("This item already exists in the database.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format. Please enter a valid date.");
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure all fields are filled correctly, and that Quantity and Cost are numeric.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Add item: " + ex.Message);
            }
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
    }
}
