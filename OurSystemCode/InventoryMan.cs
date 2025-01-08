using System;
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
    public partial class InventoryMan : Form
    {
        private bool isDragging = false;
        private Point mouseOffset;

        public InventoryMan()
        {
            InitializeComponent();
            this.Size = new Size(811, 490);
        }

        String name;
        String role;
        public InventoryMan(String role, String name)
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
            Dashboard DashboardScreen = new Dashboard(role, name);
            this.Hide();
            DashboardScreen.Show();
        }

        private void InventoryMan_Load(object sender, EventArgs e)
        {
            usernameBox.Text = name;
            userroleBox.Text = role;
            usernameBox.TabStop = false;
            userroleBox.TabStop = false;

            LoadInventoryData();

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

            this.MouseDown += new MouseEventHandler(InventoryMan_MouseDown);
            this.MouseMove += new MouseEventHandler(InventoryMan_MouseMove);
            this.MouseUp += new MouseEventHandler(InventoryMan_MouseUp);
        }

        private void InventoryMan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = e.Location;
            }
        }

        private void InventoryMan_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = this.Left + (e.X - mouseOffset.X);
                this.Top = this.Top + (e.Y - mouseOffset.Y);
            }
        }

        private void InventoryMan_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void LoadInventoryData()
        {
            try
            {
               
                string query = "SELECT Name, Quantity, Locational_ID, ExpirationDate FROM whms_schema.Item";
                DatabaseOperations dbOps = new DatabaseOperations();
                DataSet ds = dbOps.getData(query);

              
                if (!ds.Tables[0].Columns.Contains("Product State (Expiration)"))
                    ds.Tables[0].Columns.Add("Product State (Expiration)", typeof(string));

                if (!ds.Tables[0].Columns.Contains("Product State (Stock)"))
                    ds.Tables[0].Columns.Add("Product State (Stock)", typeof(string));

                if (!ds.Tables[0].Columns.Contains("Location Name"))
                    ds.Tables[0].Columns.Add("Location Name", typeof(string));

                
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    
                    var expirationDateObj = row["ExpirationDate"];
                    row["Product State (Expiration)"] = GetExpirationState(expirationDateObj);

                   
                    int quantity = row["Quantity"] == DBNull.Value ? 0 : Convert.ToInt32(row["Quantity"]);
                    row["Product State (Stock)"] = GetStockState(quantity);

                   
                    int locationID = row["Locational_ID"] == DBNull.Value ? 0 : Convert.ToInt32(row["Locational_ID"]);
                    row["Location Name"] = GetLocationName(locationID);
                }

               
                InventoryView.DataSource = ds.Tables[0];
               
                InventoryView.CellFormatting += InventoryView_CellFormatting;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }


        private void InventoryView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            if (InventoryView.Columns[e.ColumnIndex].Name == "Product State (Stock)")
            {
                if (e.Value != null)  
                {
                    string state = e.Value.ToString();
                    state = e.Value.ToString();

                    switch (state)
                    {
                        case "In Stock":
                            e.CellStyle.BackColor = Color.Green;
                            e.CellStyle.ForeColor = Color.White;
                            break;
                        case "Low Stock":
                            e.CellStyle.BackColor = Color.Yellow;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                        case "Out of Stock":
                            e.CellStyle.BackColor = Color.Red;
                            e.CellStyle.ForeColor = Color.White;
                            break;
                        default:
                            e.CellStyle.BackColor = Color.White;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                    }

                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                    e.CellStyle.ForeColor = Color.Black;
                }

              
                
            }

          
            if (InventoryView.Columns[e.ColumnIndex].Name == "Product State (Expiration)")
            {
                
                if (e.Value != null) 
                {
                    string state = e.Value.ToString();
                    state = e.Value.ToString();

                   
                    switch (state)
                    {
                        case "Good":
                            e.CellStyle.BackColor = Color.Green;
                            e.CellStyle.ForeColor = Color.White;
                            break;
                        case "Expiring Soon":
                            e.CellStyle.BackColor = Color.Orange;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                        case "Expired":
                            e.CellStyle.BackColor = Color.Red;
                            e.CellStyle.ForeColor = Color.White;
                            break;
                        default:
                            e.CellStyle.BackColor = Color.White;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
                else
                {
                  
                    e.CellStyle.BackColor = Color.White;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }



        private string GetExpirationState(object expirationDateObj)
        {
            if (expirationDateObj == DBNull.Value)
            {
                return "No Expiration Date";
            }

            DateTime expirationDate = Convert.ToDateTime(expirationDateObj);
            TimeSpan timeToExpire = expirationDate - DateTime.Now;

            if (timeToExpire.TotalDays <= 0)
                return "Expired"; 
            else if (timeToExpire.TotalDays <= 30)
                return "Expiring Soon"; 
            else
                return "Good";
        }


        
        private string GetStockState(int quantity)
        {
            if (quantity == 0)
                return "Out of Stock";
            else if (quantity < 50)
                return "Low Stock"; 
            else
                return "In Stock"; 
        }


       
        private string GetLocationName(int locationID)
        {
            try
            {
                string query = $"SELECT Location_Name FROM whms_schema.Locations WHERE Location_ID = {locationID}";
                DatabaseOperations dbOps = new DatabaseOperations();
                DataSet ds = dbOps.getData(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0]["Location_Name"].ToString();
                }
                else
                {
                    return "Unknown"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching location name: " + ex.Message);
                return "Error";
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
            Bitmap bitmap = new Bitmap(this.InventoryView.Width, this.InventoryView.Height);
            InventoryView.DrawToBitmap(bitmap, new Rectangle(0, 0, this.InventoryView.Width, this.InventoryView.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
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
            Suppliers SuppliersScreen = new Suppliers(role, name);
            this.Hide();
            SuppliersScreen.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Show();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PrintEntryData();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OBInvenPan.Visible = true;
            tableLayoutFilterInven.Visible = true;
            OBbuttonInven.Text = "Filter";
            OBlapelInven.Text = "Filtering Items";
        }

        private void OBclose_Click(object sender, EventArgs e)
        {
            OBInvenPan.Visible = false;
        }
    }
}
