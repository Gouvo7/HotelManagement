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
            var z;
            while (true)
            {
                Login loginForm = new Login();
                DialogResult loginResult = new DialogResult();
                z = loginForm.ShowDialog();
                if (z == DialogResult.OK)
                {

                    int userID = loginForm.getID();
                    MainMenu anotherForm = new MainMenu(userID);
                    //Application.Run(anotherForm);
                }
                z = null;
            }
            */
            MainMenu anotherForm = new MainMenu(1);
            Application.Run(anotherForm);

        }
    }
}