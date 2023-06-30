using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class MainMenu : Form
    {
        private int userID;
        public MainMenu(int x)
        {
            InitializeComponent();
            this.CenterToScreen();
            userID = x;
            DB db = new DB();
            try
            {
                MySqlConnection con = new MySqlConnection(db.getConnString());
                con.Open();
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "SELECT * FROM hot_usr where usr_ID = @userID";
                comm.Parameters.AddWithValue("@userID", userID);
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    string userName = reader["usr_FName"].ToString();
                    welcomeLabel.Text = welcomeLabel.Text + " " + userName;
                }
                con.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Πρόβλημα επικοινωνίας με την βάση δεδομένων. Η εφαρμογή θα τερματιστεί.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void searchDate_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (typeCombo.SelectedIndex > -1 && dateBox.SelectedIndex > -1 && monthBox.SelectedIndex > -1 && yearBox.SelectedIndex > -1)
            {

            }
            else
            {
                MessageBox.Show("Πρέπει να επιλέξεις μία από τις επιλογές για όλα τα πεδία!.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            try
            {
                MySqlConnection con = new MySqlConnection(db.getConnString());
                con.Open();
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "SELECT * FROM hot_usr where usr_ID = @userID";
                comm.Parameters.AddWithValue("@userID", userID);
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    string userName = reader["usr_FName"].ToString();
                    welcomeLabel.Text = welcomeLabel.Text + " " + userName;
                }
                con.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Πρόβλημα επικοινωνίας με την βάση δεδομένων. Η εφαρμογή θα τερματιστεί.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }*/
        }

        private void searchCustDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
