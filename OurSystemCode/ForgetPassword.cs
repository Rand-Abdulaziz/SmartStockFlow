using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS;

namespace OurSystemCode
{
    public partial class ForgetPassword : MetroFramework.Forms.MetroForm
    {
        DatabaseOperations databaseOperation = new DatabaseOperations();
        String query;

       
        private bool isDragging = false;
        private Point mouseOffset;

        public ForgetPassword()
        {
            InitializeComponent();
        }

      
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
           
            this.MouseDown += new MouseEventHandler(ForgetPassword_MouseDown);
            this.MouseMove += new MouseEventHandler(ForgetPassword_MouseMove);
            this.MouseUp += new MouseEventHandler(ForgetPassword_MouseUp);
        }

        private void ForgetPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = e.Location;
            }
        }

        private void ForgetPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = this.Left + (e.X - mouseOffset.X);  
                this.Top = this.Top + (e.Y - mouseOffset.Y);    
            }
        }

        private void ForgetPassword_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                query = $"SELECT * FROM whms_schema.Users WHERE Email = '{textBoxEmail.Text}'";

                DataSet ds = databaseOperation.getData(query);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Console.WriteLine("User found.");

                    string newPassword = textBoxPassword.Text;
                    string confirmPassword = textBoxConfirm.Text;

                    if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
                    {
                        MessageBox.Show("Please fill in both password fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (newPassword != confirmPassword)
                    {
                        MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    query = $"UPDATE whms_schema.Users SET Password = '{newPassword}' WHERE Email = '{textBoxEmail.Text}'";
                    int rowsAffected = databaseOperation.setData(query, null);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FormLogin Loginform = new FormLogin();
                        Loginform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

      
        private void pictureEye_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar != '\0')
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar != '\0')
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
}
