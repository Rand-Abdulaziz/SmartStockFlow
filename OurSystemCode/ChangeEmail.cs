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
    public partial class ChangeEmail : Form
    {
        DatabaseOperations databaseOperation = new DatabaseOperations();
        String query;

        private bool isDragging = false;
        private Point mouseOffset;

        public ChangeEmail()
        {
            InitializeComponent();
        }

        public void ChangeEmail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = e.Location;
            }
        }

        public void ChangeEmail_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = this.Left + (e.X - mouseOffset.X);
                this.Top = this.Top + (e.Y - mouseOffset.Y);
            }
        }
        public void ChangeEmail_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM whms_schema.Users WHERE Email = '{textBoxEmailChange.Text}'";

                DataSet ds = databaseOperation.getData(query);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Console.WriteLine("User found.");

                    string newEmail = textBoxNewEmail.Text;
                    

                    if (string.IsNullOrWhiteSpace(newEmail) || string.IsNullOrWhiteSpace(textBoxEmailChange.Text))
                    {
                        MessageBox.Show("Please fill in both Email fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                   
                    query = $"UPDATE whms_schema.Users SET Email = '{newEmail}' WHERE Email = '{textBoxEmailChange.Text}'";
                    int rowsAffected = databaseOperation.setData(query, null);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Email updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Email. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No user found with this email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in updating password: " + ex);
                MessageBox.Show("Something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ChangeEmail_Load(object sender, EventArgs e)
        {
            int cornerRadius = 20;
            Form1.ApplyRoundedCorners(this, cornerRadius);

            this.MouseDown += new MouseEventHandler(ChangeEmail_MouseDown);
            this.MouseMove += new MouseEventHandler(ChangeEmail_MouseMove);
            this.MouseUp += new MouseEventHandler(ChangeEmail_MouseUp);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panelBlogin_Resize(object sender, EventArgs e)
        {
            int cornerRadius = 20;
            Form1.ApplyRoundedCorners(this, cornerRadius);
        }
    }
}
