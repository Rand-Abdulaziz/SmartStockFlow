using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurSystemCode
{
    public partial class AdminSittings : Form
    {

        private bool isDragging = false;
        private Point mouseOffset;
        public AdminSittings()
        {
            InitializeComponent();
            this.Size = new Size(811, 490);
        }

        String name;
        String role;
        public AdminSittings(String role,String name)
        {
            InitializeComponent();
            this.Size = new Size(811, 490);
            this.role = role;
            this.name = name;

        }

       

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel3, 20);
        }

        private void panel7_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel7, 20);
        }

        private void panel8_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel8, 20);
        }

        private void panel6_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel6, 20);
        }

        private void panel5_Resize(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Resize(object sender, EventArgs e)
        {
            OurSystemCode.Form1.ApplyRoundedCorners(panel5, 20);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard DashboardScreen = new Dashboard(role, name);
            this.Hide();
            DashboardScreen.Show();
        }

        private void AdminSittings_Load_1(object sender, EventArgs e)
        {
         
            usernameBox.Text = name;
            userroleBox.Text = role;
            usernameBox.TabStop = false;
            userroleBox.TabStop = false;

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Role is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine("SSSS Role: " + role);
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


            this.MouseDown += new MouseEventHandler(AdminSittings_MouseDown);
            this.MouseMove += new MouseEventHandler(AdminSittings_MouseMove);
            this.MouseUp += new MouseEventHandler(AdminSittings_MouseUp);


        }

        private void AdminSittings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = e.Location;
            }
        }


        private void AdminSittings_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = this.Left + (e.X - mouseOffset.X);
                this.Top = this.Top + (e.Y - mouseOffset.Y);
            }
        }


        private void AdminSittings_MouseUp(object sender, MouseEventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Employees EmployeesScreen = new Employees(role, name);
            this.Hide();
            EmployeesScreen.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Show();
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
    }
}
