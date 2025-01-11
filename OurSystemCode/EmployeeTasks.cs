using System;
using System.Windows.Forms;

namespace OurSystemCode
{
    public partial class EmployeeTasks : Form
    {
        public EmployeeTasks()
        {
            InitializeComponent();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void BtnDataEntry_Click(object sender, EventArgs e)
        {
            DataEntry dataEntry = new DataEntry();
            dataEntry.Show();
            this.Hide();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();
            this.Hide();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            InventoryMan inventory = new InventoryMan();
            inventory.Show();
            this.Hide();
        }

        private void BtnEmployeeManagement_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Sittings settings = new Sittings();
            settings.Show();
            this.Hide();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void BtnFinishTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task finished successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}




