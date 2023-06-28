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

            Login loginForm = new Login();
            DialogResult loginResult = loginForm.ShowDialog();
            if (loginResult == DialogResult.OK)
            {
                // Retrieve the user ID from the login form
                int userID = loginForm.getID();

                // Continue to call another form and pass the user ID as an argument
                //MainMenu anotherForm = new MainMenu(userID);
                //Application.Run(anotherForm);
            }
            //int userID = login.getID();
            //Application.Run(new MainMenu(userID));
        }
    }
}
