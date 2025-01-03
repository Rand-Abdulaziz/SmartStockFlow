using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OurSystemCode.Properties;


namespace OurSystemCode
{
    public partial class Dashboard : Form
    {
            
        private bool isDragging = false;
        private Point mouseOffset;
        public Dashboard()
        {
            InitializeComponent();
            this.Size = new Size(811, 490);

        }

        String role;
        public Dashboard(String role)
        {
            InitializeComponent();
            this.Size = new Size(811, 490); 
            this.role = role;
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
            int cornerRadius = 20; 

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // الزاوية العلوية اليسرى
            path.AddArc(this.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // الزاوية العلوية اليمنى
            path.AddArc(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // الزاوية السفلية اليمنى
            path.AddArc(0, this.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // الزاوية السفلية اليسرى
            path.CloseFigure();

           
            this.Region = new Region(path);

            // ربط الأحداث بالـ Form
            this.MouseDown += new MouseEventHandler(Dash_MouseDown);
            this.MouseMove += new MouseEventHandler(Dash_MouseMove);
            this.MouseUp += new MouseEventHandler(Dash_MouseUp);

         
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Role is not set properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine("SSSS Role: " + role);
            if ("EMPLOYEE".Equals(role, StringComparison.OrdinalIgnoreCase))
            {

                DashTitle.Text = "Employee Dashboard ";
                btnEmployeeMang.Visible = false;
                btnSittings.Location = new System.Drawing.Point(5, 459);
            }
            else
            {

                DashTitle.Text = "Welcome Admin !";
                btnEmployeeMang.Visible = true;
                btnSittings.Location = new System.Drawing.Point(5, 509);
            }


        }

        private void Dash_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = e.Location;  
            }
        }

        // عند تحريك الماوس
        private void Dash_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging) 
            {
                this.Left = this.Left + (e.X - mouseOffset.X);  
                this.Top = this.Top + (e.Y - mouseOffset.Y);    
            }
        }

        // عند رفع زر الماوس
        private void Dash_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;  // إيقاف السحب
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
          
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel3, 20);
        }

        private void panel4_Resize(object sender, EventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel4, 20);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Resize(object sender, EventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel5, 20);
        }

        private void panel6_Resize(object sender, EventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel6, 20);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel7, 20);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel8, 20);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel11, 20);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel12, 20);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel9, 20);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel10, 20);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel13, 20);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel14, 20);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel15, 20);
        }
    }



}

        

