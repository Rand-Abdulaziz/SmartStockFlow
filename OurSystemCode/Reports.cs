using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace OurSystemCode
{
   
    public partial class Reports : Form
    {

        private bool isDragging = false;
        private Point mouseOffset;
        public Reports()
        {
            InitializeComponent();
         
        }

        String name;
        String role;
        public Reports(String role ,String name)
        {

            // DEBUG: Check if DataEntryGrid is assigned
            if (DataEntryGrid == null)
            {
                Console.WriteLine("DataEntryGrid is null. Did you forget to assign it?");
            }

            InitializeComponent();
            this.Size = new Size(811, 490);
            this.role = role;
            this.name = name;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Reports_Load(object sender, EventArgs e)
        {
            usernameBox.Text = name;
            userroleBox.Text = role;
            usernameBox.TabStop = false;
            userroleBox.TabStop = false;

            int cornerRadius = 20;
            Form1.ApplyRoundedCorners(this, cornerRadius);


            this.MouseDown += new MouseEventHandler(Reports_MouseDown);
            this.MouseMove += new MouseEventHandler(Reports_MouseMove);
            this.MouseUp += new MouseEventHandler(Reports_MouseUp);

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
                btnEmployeesTasks.Visible = false;
                btnEmployeeMang.Location = new System.Drawing.Point(5, 459);
                btnSittings.Location = new System.Drawing.Point(5, 509);
            }

            toolTip1.SetToolTip(button8, "Close applacation");
            toolTip1.SetToolTip(buttonMinimize, "Minimize window");
           

        }

        private void Reports_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = e.Location;
            }
        }


        private void Reports_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = this.Left + (e.X - mouseOffset.X);
                this.Top = this.Top + (e.Y - mouseOffset.Y);
            }
        }


        private void Reports_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }

        private void panel6_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }

        private void panel5_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }

        private void panel7_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);

        }

        private void button9_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel4, 20);
        }

        #region Helper Functions

        private string GetSelectedReportType()
        {
            if (radioButton1.Checked) return "Items";
            if (radioButton2.Checked) return "Expiry Items";
            if (radioButton5.Checked) return "Suppliers";
            return string.Empty;
        }

        private string GetSelectedReportDuration()
        {
            if (radioButton4.Checked) return "Daily";
            if (radioButton3.Checked) return "Weekly";
            if (radioButton6.Checked) return "Monthly";
            return string.Empty;
        }


        #endregion
        private void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            // Validate that the user has selected report type and duration
            if (string.IsNullOrEmpty(GetSelectedReportType()) || string.IsNullOrEmpty(GetSelectedReportDuration()))
            {
                MessageBox.Show("Please select both a report type and duration before exporting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set license context for EPPlus BEFORE using ExcelPackage
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Create a SaveFileDialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save Report as Excel File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var package = new OfficeOpenXml.ExcelPackage())
                        {
                            // Add a new worksheet
                            var worksheet = package.Workbook.Worksheets.Add("Report");

                            // Add report type and duration
                            worksheet.Cells[1, 1].Value = "Report Type";
                            worksheet.Cells[1, 2].Value = "Report Duration";
                            worksheet.Cells[2, 1].Value = GetSelectedReportType();
                            worksheet.Cells[2, 2].Value = GetSelectedReportDuration();

                            // Fetch data from DataEntryGrid
                            if (DataEntryGrid != null && DataEntryGrid.Rows.Count > 0)
                            {
                                // Add headers from DataEntryGrid
                                var headers = GetDataEntryViewHeaders();
                                for (int col = 0; col < headers.Length; col++)
                                {
                                    worksheet.Cells[4, col + 1].Value = headers[col]; // Start writing headers from row 4
                                }

                                // Add data from DataEntryGrid
                                var data = GetDataEntryViewData();
                                for (int row = 0; row < data.Count; row++)
                                {
                                    for (int col = 0; col < data[row].Length; col++)
                                    {
                                        worksheet.Cells[row + 5, col + 1].Value = data[row][col]; // Start writing data from row 5
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data available to export from Data Entry.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            // Save the file
                            package.SaveAs(new FileInfo(saveFileDialog.FileName));
                            MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        public DataGridView DataEntryGrid { get; set; }

        private List<string[]> GetDataEntryViewData()
        {
            if (DataEntryGrid == null)
            {
                MessageBox.Show("No data is available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string[]>();
            }

            var data = new List<string[]>();

            foreach (DataGridViewRow row in DataEntryGrid.Rows)
            {
                if (!row.IsNewRow) // Exclude the blank row used for new data
                {
                    var rowData = new string[DataEntryGrid.ColumnCount];
                    for (int col = 0; col < DataEntryGrid.ColumnCount; col++)
                    {
                        rowData[col] = row.Cells[col].Value?.ToString() ?? ""; // Null-safe
                    }
                    data.Add(rowData);
                }
            }

            return data;
        }

        private string[] GetDataEntryViewHeaders()
        {
            if (DataEntryGrid == null)
            {
                MessageBox.Show("No data is available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new string[0];
            }

            var headers = new string[DataEntryGrid.ColumnCount];
            for (int col = 0; col < DataEntryGrid.ColumnCount; col++)
            {
                headers[col] = DataEntryGrid.Columns[col].HeaderText;
            }
            return headers;
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
            this.Show();
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
            Form1 logoutScreen = new Form1();
            this.Close();
            logoutScreen.Show();
        }
    }
}





    
