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
using System.Data.SqlClient;
using System.Collections;

namespace OurSystemCode
{
   
    public partial class Reports : Form
    {

        private bool isDragging = false;
        private Point mouseOffset;
        String name;
        String role;
        public Reports(String role ,String name)
        {


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

            DatabaseOperations dbOps = new DatabaseOperations();
            DataSet ds = dbOps.getData("SELECT * FROM whms_schema.Item");
            DataSet dsSup = dbOps.getData("SELECT * FROM whms_schema.Suppliers");

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
            if (radioButtonItems.Checked) return "Items";
        
            if (radioButtonSuppliers.Checked) return "Suppliers";
            return string.Empty;
        }

        private string GetSelectedReportDuration()
        {
            if (radioButtonDaily.Checked) return "Daily";
            if (radioButtonWeekly.Checked) return "Weekly";
            if (radioButtonMonthly.Checked) return "Monthly";
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

                            // Fetch data based on selected report type and duration
                            var data = FetchDataBasedOnSelection();
                            if (data.Count > 0)
                            {
                                // Add headers
                                var headers = data.First().Keys.ToList();
                                for (int col = 0; col < headers.Count; col++)
                                {
                                    worksheet.Cells[4, col + 1].Value = headers[col]; // Start writing headers from row 4
                                }

                                int rowIndex = 5;
                                foreach (var row in data)
                                {
                                    for (int colIndex = 0; colIndex < headers.Count; colIndex++)
                                    {
                                        var cell = worksheet.Cells[rowIndex, colIndex + 1];
                                        var value = row[headers[colIndex]];

                                        // Check if the value is a DateTime and format accordingly
                                        if (value is DateTime dateValue)
                                        {
                                            cell.Value = dateValue;
                                            cell.Style.Numberformat.Format = "yyyy-MM-dd"; // Change format as needed
                                        }
                                        else
                                        {
                                            cell.Value = value;
                                        }
                                    }
                                    rowIndex++;
                                }

                                // Adjust column widths to fit content
                                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();



                                // Save the file
                                package.SaveAs(new FileInfo(saveFileDialog.FileName));
                                MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No data available to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private List<Dictionary<string, object>> FetchDataBasedOnSelection()
        {
            var data = new List<Dictionary<string, object>>();

            // Determine the report type
            string reportType = GetSelectedReportType();
            string reportDuration = GetSelectedReportDuration();
            DateTime currentDate = DateTime.Now;

            // SQL query for different report types and durations
            string query = "";

            if (reportType == "Items")
            {
                query = BuildQueryForItems(reportDuration, currentDate);
            }
            else if (reportType == "Suppliers")
            {
                query = BuildQueryForSuppliers(reportDuration, currentDate);
            }

            // Fetch the data from database
            data = FetchDataFromDatabase(query);

            return data;
        }

        private string BuildQueryForItems(string duration, DateTime currentDate)
        {
            string query = "SELECT * FROM whms_schema.Item WHERE 1=1";

            // Add date filtering based on the selected duration
            if (duration == "Daily")
            {
                query += $" AND CreatedDate >= '{currentDate.Date}'";
            }

            else if (duration == "Weekly")
            {
                var startOfWeek = currentDate.AddDays(-7);
                query += $" AND CreatedDate >= '{startOfWeek.Date}' AND CreatedDate < '{currentDate.Date}'";
            }
            else if (duration == "Monthly")
            {
                var startOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
                query += $" AND CreatedDate >= '{startOfMonth.Date}' AND CreatedDate < '{currentDate.AddMonths(1).Date}'";
            }

            return query;
        }

        private string BuildQueryForSuppliers(string duration, DateTime currentDate)
        {
            string query = "SELECT * FROM whms_schema.Suppliers WHERE 1=1";

            // Add date filtering based on the selected duration
            if (duration == "Daily")
            {
                query += $" AND CreatedDate >= '{currentDate.Date}' AND CreatedDate < '{currentDate.Date.AddDays(1)}'";
            }
            else if (duration == "Weekly")
            {
                var startOfWeek = currentDate.AddDays(-7);
                query += $" AND CreatedDate >= '{startOfWeek.Date}' AND CreatedDate < '{currentDate.Date}'";
            }
            else if (duration == "Monthly")
            {
                var startOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
                query += $" AND CreatedDate >= '{startOfMonth.Date}' AND CreatedDate < '{currentDate.AddMonths(1).Date}'";
            }

            return query;
        }

        private List<Dictionary<string, object>> FetchDataFromDatabase(string query, Dictionary<string, object> parameters = null)
        {
            var data = new List<Dictionary<string, object>>();

            // Create an instance of the DatabaseOperations class
            DatabaseOperations dbOps = new DatabaseOperations();

            // Use getData or getDataWithParameter to retrieve data from the database
            DataSet ds = parameters == null ? dbOps.getData(query) : dbOps.getDataWithParameter(query, parameters);

            // Convert the DataSet to List<Dictionary<string, object>>
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    var rowData = new Dictionary<string, object>();
                    foreach (DataColumn column in ds.Tables[0].Columns)
                    {
                        rowData[column.ColumnName] = row[column];
                    }
                    data.Add(rowData);
                }
            }

            return data;
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
    }
}





    
