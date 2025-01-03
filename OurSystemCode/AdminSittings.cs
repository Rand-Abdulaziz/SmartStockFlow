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
        public AdminSittings()
        {
            InitializeComponent();
            this.Size = new Size(811, 490);
        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel3, 20);
        }

        private void panel7_Resize(object sender, EventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel7, 20);
        }

        private void panel8_Resize(object sender, EventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel8, 20);
        }

        private void panel6_Resize(object sender, EventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel6, 20);
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
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel5, 20);
        }
    }
}
