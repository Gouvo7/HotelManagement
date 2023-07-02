using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
            typeCombo.SelectedIndex = 0;
            searchPanel.Show();
            resultsPanel.Hide();
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
                string userType = "-1";
                if (reader.Read())
                {
                    string userName = reader["usr_FName"].ToString();
                    userType = reader["usr_Type"].ToString();
                    welcomeLabel.Text = welcomeLabel.Text + " " + userName;
                }
                con.Close();
                Console.WriteLine(userType);
                if (userType.Equals("1")){
                    employeePanel.Show();
                    //customerPanel.Hide();
                }
                else if (userType.Equals("2"))
                {
                    employeePanel.Hide();
                    //customerPanel.Show();
                }
                else
                {
                    MessageBox.Show("Πρόβλημα στις ρυθμίσεις του λογαριασμού του χρήστη. Η εφαρμογή θα τερματιστεί.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();

                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Πρόβλημα επικοινωνίας με την βάση δεδομένων. Η εφαρμογή θα τερματιστεί.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }

        void searchDate_Click(object sender, EventArgs e)
        {
            if (typeCombo.SelectedIndex > -1 && dateBox.SelectedIndex > -1 && monthBox.SelectedIndex > -1 && yearBox.SelectedIndex > -1)
            {
                DB db = new DB();
                MySqlConnection con = new MySqlConnection(db.getConnString());
                con.Open();
                MySqlCommand comm = con.CreateCommand();
                string input = monthBox.Text;
                string monthNumber = input.Substring(0, 2);
                string checkinDate = yearBox.Text + "-" + monthNumber + "-" + dateBox.Text;
                string grFormatDate = dateBox.Text + "-" + monthNumber + "-" +  yearBox.Text;
                comm.CommandText = "SELECT booking_ID,concat(usr_fname,' ',usr_lname) as usr_ID,room_ID," +
                    "booking_Date, checkin_Date FROM hot_bookings " +
                    "INNER JOIN hot_usr ON hot_bookings.usr_ID = hot_usr.usr_ID " +
                    "where checkin_Date = @checkinDate";
                comm.Parameters.AddWithValue("@checkinDate", checkinDate);
                Console.WriteLine(checkinDate);
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                    dataTable.Columns["booking_ID"].ColumnName = "Αρ. Κράτησης";
                    dataTable.Columns["usr_ID"].ColumnName = "Όνομα Κράτησης";
                    dataTable.Columns["room_ID"].ColumnName = "Αριθμός Δωματίου";
                    dataTable.Columns["booking_Date"].ColumnName = "Ημερομηνία Κράτησης";
                    dataTable.Columns["checkin_Date"].ColumnName = "Ημερομηνία Check-in";
                }
                searchPanel.Hide();
                resultsPanel.Show();
                resultsLabel.Text = "Αποτελέσματα για " + typeCombo.SelectedText + " : " + grFormatDate ;
                con.Close();

            }
            else
            {
                MessageBox.Show("Πρέπει να επιλέξεις μία από τις επιλογές για όλα τα πεδία!", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultsPanel.Hide();
            searchPanel.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
