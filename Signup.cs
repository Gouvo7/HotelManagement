using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;


namespace HotelManagement
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = fNameBox.Text;
            string surname = lNameBox.Text;
            string username = userBox.Text;
            string email = emailBox.Text;
            string pass1 = pass1Box.Text;
            string pass2 = pass2Box.Text;
            DB cs = new DB();
            int error = 0;
            error = checkValidity(name,surname,username,email,pass1,pass2);
            MySqlConnection con = new MySqlConnection(cs.getConnString()); //open connection
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from hot_usr where usr_username = '" + username + "' AND usr_password = '" + pass1 + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Επιτυχής είσοδος!", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Τα στοιχεία που δώσατε δεν είναι έγκυρα.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                reader.Close();
                cmd.Dispose();
                con.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Πρόβλημα επικοινωνίας με την βάση δεδομένων", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        int checkValidity(string name, string surname, string username, string email, string pass1, string pass2)
        {
            Regex real_name_reg = new Regex(@"^[A-zΑ-ζ]([Α-ζA-z])+[Α-ζA-z]$");
            Regex email_reg = new Regex(@"(^\w|^\d)(\d|\w)*@(\d|\w)*\.(\d|\w)+");
            if (!real_name_reg.IsMatch(name))
            {
                return -1;
            }
            if (!real_name_reg.IsMatch(surname))
            {
                return -2;
            }
            if (!email_reg.IsMatch(email))
            {
                return -3;
            }
            return 1;
        }
    }
}
