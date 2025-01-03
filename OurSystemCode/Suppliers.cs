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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
            this.Size = new Size(811, 490);
        }

        private void panel4_Resize(object sender, EventArgs e)
        {
            OurSystemCode.FormLogin.ApplyRoundedCorners(panel4, 20);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
