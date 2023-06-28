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
            switch (error)
            {
                case 0:
                    MessageBox.Show("Οι κωδικοί πρόσβασης δεν είναι οι ίδιοι!", "Λανθασμένα Στοιχεία", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case -1: case -2:
                    MessageBox.Show("Το όνομα και το επώνυμο πρέπει να αποτελούνται αποκλειστικά από χαρακτήρες του ελληνικού ή του αγγλικού" +
                        "αλφάβητου.", "Λανθασμένα Στοιχεία", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case -3:
                    MessageBox.Show("Το email δεν βρίσκεται στον σωστό μορφότυπο.", "Λανθασμένα Στοιχεία", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    MySqlConnection con = new MySqlConnection(cs.getConnString());
                    try
                    {
                        con.Open();
                        MySqlCommand comm = con.CreateCommand();
                        comm.CommandText = "INSERT INTO hot_usr (usr_FName, usr_LName, usr_username, usr_password, usr_Email) VALUES (@name, @surname, @username, @pass, @email)";
                        comm.Parameters.AddWithValue("@name", name);
                        comm.Parameters.AddWithValue("@surname", surname);
                        comm.Parameters.AddWithValue("@username", username);
                        comm.Parameters.AddWithValue("@pass", email);
                        comm.Parameters.AddWithValue("@email", pass1);
                        comm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Η εγγραφή του νέου χρήστη ολοκληρώθηκε επιτυχώς!", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Πρόβλημα επικοινωνίας με την βάση δεδομένων. Η εφαρμογή θα τερματιστεί.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    break;
            }
            
        }
        int checkValidity(string name, string surname, string username, string email, string pass1, string pass2)
        {
            Regex real_name_reg = new Regex(@"^[A-z]([A-z])+[A-z]$");
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
            if (pass1.Equals(pass2))
                return 1;
            else
                return 0;
        }
    }
}
