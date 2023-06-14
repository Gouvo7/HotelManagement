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

namespace HotelManagement
{
    public partial class Login : Form
    {

        private int userID;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userTB.Text;
            string password = passTB.Text;
            DB cs = new DB();
            MySqlConnection con = new MySqlConnection(cs.getConnString()); //open connection
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from hot_usr where usr_username = '" + username + "' AND usr_password = '" + password + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Επιτυχής είσοδος!", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userID = reader.GetInt32("usr_ID");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Τα στοιχεία που δώσατε δεν είναι έγκυρα.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                userTB.Text = string.Empty;
                passTB.Text = string.Empty;
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

        public int getID()
        {
            return userID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup a = new Signup();
            //this.Hide();
            a.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
