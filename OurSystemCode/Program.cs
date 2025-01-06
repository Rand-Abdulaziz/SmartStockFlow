using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurSystemCode
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());

            //Application.Run(new Dashboard());

            //Application.Run(new AdminSittings());

            //Application.Run(new DataEntry());

            //Application.Run(new Employees());

            //Application.Run(new InventoryMan());

            //Application.Run(new Reports());

            //Application.Run(new Sittings());

            //Application.Run(new Suppliers());

            //Application.Run(new ForgetPassword());



        }
    }
}
