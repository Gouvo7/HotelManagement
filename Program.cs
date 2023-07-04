using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            
            /*
            Login loginForm = new Login();
            DialogResult loginResult = loginForm.ShowDialog();
            if (loginResult == DialogResult.OK)
            {

                int userID = loginForm.getID();
                MainMenu anotherForm = new MainMenu(userID);
                Application.Run(anotherForm);
                

            }
            else
            {
            }
            */

            MainMenu anotherForm = new MainMenu(2);
            Application.Run(anotherForm);

        }
    }
}
