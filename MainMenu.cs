using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.IO;
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
            searchPanel.Hide();
            resultsPanel.Hide();
            homePanel.Show();
            roomPanel.Hide();
            resultsLabelCust.Hide();
            dataGridView4.Hide();
            userID = x;
            updateUserPanel();
            updateHome();
            
        }

        void hideInfoCust()
        {

        }

        void updateUserPanel()
        {
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
                    welcomeLabelCust.Text = welcomeLabelCust.Text + " " + userName;
                }
                con.Close();
                Console.WriteLine(userType);
                if (userType.Equals("1"))
                {
                    employeePanel.Show();
                    customerPanel.Hide();
                }
                else if (userType.Equals("2"))
                {
                    employeePanel.Hide();
                    customerPanel.Show();
                    searchRoomDatePanel.Hide();
                    showRoomBtn.Hide();
                    custHomePanel.Show();
                    roomDetailsPanel.Hide();
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

        void updateHome()
        {
            DB db = new DB();
            try
            {
                MySqlConnection con = new MySqlConnection(db.getConnString());
                con.Open();
                MySqlCommand comm1 = con.CreateCommand();
                string currDate = DateTime.Now.ToString("yyyy-MM-dd");
                comm1.CommandText = "SELECT booking_ID , concat(usr_FName,' ',usr_LName) as 'Name', "+
                    "checkout_Date,hot_bookings.room_ID,room_TypeN,booking_Comments,usr_Email,usrID_Phone FROM hot_bookings " +
                    "INNER JOIN hot_usr ON hot_usr.usr_ID = hot_bookings.usr_ID " +
                    "INNER JOIN hot_usr_det ON hot_usr_det.usr_ID = hot_bookings.usr_ID " +
                    "INNER JOIN hot_rooms ON hot_bookings.room_ID = hot_rooms.room_ID " +
                    "WHERE checkin_Date = @currDate AND hasArrived = 0";
                comm1.Parameters.AddWithValue("@currDate", currDate);
                bool hasResults1;
                using (MySqlDataReader reader1 = comm1.ExecuteReader())
                {
                    DataTable dataTable1 = new DataTable();
                    dataTable1.Load(reader1);
                    dataGridView2.DataSource = dataTable1;
                    dataTable1.Columns["booking_ID"].ColumnName = "Αρ. Κράτησης";
                    dataTable1.Columns["Name"].ColumnName = "Όνομα Κράτησης";
                    dataTable1.Columns["room_ID"].ColumnName = "Αρ. Δωματίου";
                    dataTable1.Columns["room_TypeN"].ColumnName = "Τύπος Δωματίου";
                    dataTable1.Columns["checkout_Date"].ColumnName = "Ημ/νία Check-out";
                    dataTable1.Columns["booking_Comments"].ColumnName = "Σχόλια Κράτησης"; 
                    dataTable1.Columns["usrID_Phone"].ColumnName = "Τηλέφωνο Επικοινωνίας";
                    dataTable1.Columns["usr_Email"].ColumnName = "Email Επικοινωνίας";
                    
                    hasResults1 = dataTable1.Rows.Count > 0;
                }
                if (hasResults1)
                {
                    noArrivalsLabel.Hide();
                    dataGridView2.Show();
                    markArrivalButton.Show();
                }
                else
                {
                    dataGridView2.Hide();
                    noArrivalsLabel.Show();
                    markArrivalButton.Hide();
                }
                MySqlCommand comm2 = con.CreateCommand();
                comm2.CommandText = "SELECT booking_ID , concat(usr_FName,' ',usr_LName) as 'Name', " +
                    "checkout_Date-checkin_Date as 'Nights',format((checkout_Date-checkin_Date)*room_Price,2) as 'Total Cost',hot_bookings.room_ID,room_TypeN,booking_Comments,usr_Email,usrID_Phone FROM hot_bookings " +
                    "INNER JOIN hot_usr ON hot_usr.usr_ID = hot_bookings.usr_ID " +
                    "INNER JOIN hot_usr_det ON hot_usr_det.usr_ID = hot_bookings.usr_ID " +
                    "INNER JOIN hot_rooms ON hot_bookings.room_ID = hot_rooms.room_ID " +
                    "WHERE checkout_Date = @currDate AND hasDeparted = 0";
                comm2.Parameters.AddWithValue("@currDate", currDate);
                bool hasResults2;
                using (MySqlDataReader reader2 = comm2.ExecuteReader())
                {
                    DataTable dataTable2 = new DataTable();
                    dataTable2.Load(reader2);
                    dataGridView3.DataSource = dataTable2;
                    dataTable2.Columns["booking_ID"].ColumnName = "Αρ. Κράτησης";
                    dataTable2.Columns["Name"].ColumnName = "Όνομα Κράτησης";
                    dataTable2.Columns["Nights"].ColumnName = "Διανυκτερεύσεις";
                    dataTable2.Columns["Total Cost"].ColumnName = "Συνολικό Κόστος";
                    dataTable2.Columns["room_ID"].ColumnName = "Αρ. Δωματίου";
                    dataTable2.Columns["room_TypeN"].ColumnName = "Τύπος Δωματίου";
                    dataTable2.Columns["booking_Comments"].ColumnName = "Σχόλια Κράτησης";
                    dataTable2.Columns["usrID_Phone"].ColumnName = "Τηλέφωνο Επικοινωνίας";
                    dataTable2.Columns["usr_Email"].ColumnName = "Email Επικοινωνίας";
                    hasResults2 = dataTable2.Rows.Count > 0;
                    if (hasResults2)
                    {
                        noDeparturesLabel.Hide();
                        dataGridView3.Show();
                        markDepartureButton.Show();
                    }
                    else
                    {
                        dataGridView3.Hide();
                        noDeparturesLabel.Show();
                        markDepartureButton.Hide();
                    }
                }
                con.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Kostas:" + e, "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    "booking_Date, checkin_Date, usrID_Phone FROM hot_bookings " +
                    "INNER JOIN hot_usr ON hot_bookings.usr_ID = hot_usr.usr_ID " +
                    "INNER JOIN hot_usr_det on hot_usr.usr_ID = hot_usr_det.usr_ID " +
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
                    dataTable.Columns["room_ID"].ColumnName = "Αρ. Δωματίου";
                    dataTable.Columns["booking_Date"].ColumnName = "Ημ/νία Κράτησης";
                    dataTable.Columns["checkin_Date"].ColumnName = "Ημ/νία Check-in";
                    dataTable.Columns["usrID_Phone"].ColumnName = "Τηλέφωνο Επικοινωνίας";
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
        }

        private void searchCustDetails_Click(object sender, EventArgs e)
        {
            if (!nameField.Text.Equals("") || !surnameField.Text.Equals("") || !phoneField.Text.Equals("") || !emailField.Text.Equals(""))
            {
                DB db = new DB();
                MySqlConnection con = new MySqlConnection(db.getConnString());
                con.Open();
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "SELECT booking_ID,concat(usr_fname,' ',usr_lname) as usr_ID,room_ID," +
                    "CAST(booking_Date AS DATE), checkin_Date, usrID_Phone FROM hot_bookings " +
                    "INNER JOIN hot_usr ON hot_bookings.usr_ID = hot_usr.usr_ID " +
                    "INNER JOIN hot_usr_det on hot_usr.usr_ID = hot_usr_det.usr_ID " +
                    "WHERE 1=1 ";
                if (!nameField.Text.Equals("")) {
                    comm.CommandText = comm.CommandText + "AND usr_FName LIKE CONCAT('%', @fname, '%') ";
                    comm.Parameters.AddWithValue("@fname", nameField.Text);
                }
                if (!surnameField.Text.Equals(""))
                {
                    comm.CommandText = comm.CommandText + "AND usr_LName LIKE CONCAT('%', @lname, '%') ";
                    comm.Parameters.AddWithValue("@lname", surnameField.Text);
                }
                if (!phoneField.Text.Equals(""))
                {
                    comm.CommandText = comm.CommandText + "AND usrID_Phone LIKE CONCAT('%', @phone, '%') ";
                    comm.Parameters.AddWithValue("@phone", phoneField.Text);
                }
                if (!emailField.Text.Equals(""))
                {
                    comm.CommandText = comm.CommandText + "AND usr_Email LIKE CONCAT('%', @email, '%') ";
                    comm.Parameters.AddWithValue("@email", emailField.Text);
                }
                
                Console.WriteLine(comm.CommandText);
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                    dataTable.Columns["booking_ID"].ColumnName = "Αρ. Κράτησης";
                    dataTable.Columns["usr_ID"].ColumnName = "Όνομα Κράτησης";
                    dataTable.Columns["room_ID"].ColumnName = "Αριθμός Δωματίου";
                    dataTable.Columns["CAST(booking_Date AS DATE)"].ColumnName = "Ημερομηνία Κράτησης";
                    dataTable.Columns["checkin_Date"].ColumnName = "Ημερομηνία Check-in";
                    dataTable.Columns["usrID_Phone"].ColumnName = "Τηλέφωνο Επικοινωνίας";
                }
                searchPanel.Hide();
                resultsPanel.Show();
                resultsLabel.Text = "Αποτελέσματα για αναζήτηση με στοιχεία:";
                con.Close();
            }
            else 
            {
                MessageBox.Show("Πρέπει να συμπληρώσεις τουλάχιστον ένα από τα πεδία!", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homePanel.Show();
            resultsPanel.Hide();
            searchPanel.Hide();
            roomPanel.Hide();
            updateHome();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void searchBookingsClick(object sender, EventArgs e)
        {
            homePanel.Hide();
            resultsPanel.Hide();
            searchPanel.Show();
            roomPanel.Hide();
        }

        private void markArrivalClick(object sender, EventArgs e)
        {
            if (dataGridView2.Visible)
            {
                DataGridViewRow selectedRow = dataGridView2.CurrentRow;
                if (selectedRow != null)
                {
                    DataGridViewCell cell1 = selectedRow.Cells[0];
                    // Retrieve the value from the cell
                    object value1 = cell1.Value;
                    // Check if the value is not null
                    if (value1 != null)
                    {
                        // Convert the value to the desired data type
                        string stringValue1 = value1.ToString();
                        DialogResult result = MessageBox.Show("Είστε σίγουροι πως η κράτηση με αριθμό: " + stringValue1 + " έχει πραγματοποιήσει check-in;", "Ενημέρωση δεδομένων εφαρμογής", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            DB db = new DB();
                            try
                            {
                                MySqlConnection con = new MySqlConnection(db.getConnString());
                                con.Open();
                                MySqlCommand update1 = con.CreateCommand();
                                update1.CommandText = "UPDATE hot_bookings " +
                                    "SET hasArrived = 1 WHERE booking_ID = @bookingID";
                                update1.Parameters.AddWithValue("@bookingID", stringValue1);
                                update1.ExecuteNonQuery();
                                con.Close();
                                updateHome();
                            }
                            catch (MySqlException)
                            {
                                MessageBox.Show("Πρόβλημα επικοινωνίας με την βάση δεδομένων. Η εφαρμογή θα τερματιστεί.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Δεν υπάρχουν αποτελέσματα για να πραγματοποιηθούν τροποποιήσεις", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void markDeparture_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Visible)
            {
                DataGridViewRow selectedRow = dataGridView3.CurrentRow;
                if (selectedRow != null)
                {
                    DataGridViewCell cell1 = selectedRow.Cells[0];
                    // Retrieve the value from the cell
                    object value1 = cell1.Value;
                    // Check if the value is not null
                    if (value1 != null)
                    {
                        // Convert the value to the desired data type
                        string stringValue1 = value1.ToString();
                        DialogResult result = MessageBox.Show("Είστε σίγουροι πως η κράτηση με αριθμό: " + stringValue1 + " έχει πραγματοποιήσει check-out;", "Ενημέρωση δεδομένων εφαρμογής", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            DB db = new DB();
                            try
                            {
                                MySqlConnection con = new MySqlConnection(db.getConnString());
                                con.Open();
                                MySqlCommand update1 = con.CreateCommand();
                                update1.CommandText = "UPDATE hot_bookings " +
                                    "SET hasDeparted = 1 WHERE booking_ID = @bookingID";
                                update1.Parameters.AddWithValue("@bookingID", stringValue1);
                                update1.ExecuteNonQuery();
                                con.Close();
                                updateHome();
                            }
                            catch (MySqlException)
                            {
                                MessageBox.Show("Πρόβλημα επικοινωνίας με την βάση δεδομένων. Η εφαρμογή θα τερματιστεί.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Δεν υπάρχουν αποτελέσματα για να πραγματοποιηθούν τροποποιήσεις", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roomSearch_Click(object sender, EventArgs e)
        {
            roomPanel.Show();
            homePanel.Hide();
            resultsPanel.Hide();
            searchPanel.Hide();
        }

        private void searchCustBtn_Click(object sender, EventArgs e)
        {
            custHomePanel.Hide();
            searchRoomDatePanel.Show();
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            dataGridView4.Hide();
            showRoomBtn.Hide();
            resultsLabelCust.Hide();
            roomDetailsPanel.Hide();
        }

        private void bookingsCustBtn_Click(object sender, EventArgs e)
        {

        }

        private void custAccBtn_Click(object sender, EventArgs e)
        {

        }

        private void homeButtonCustBtn_Click(object sender, EventArgs e)
        {
            custHomePanel.Show();
            searchRoomDatePanel.Hide();
            roomDetailsPanel.Hide();
        }

        private void searchDatesBtn_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            dataGridView4.Show();
            string date1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            resultsLabelCust.Text = "Αποτελέσματα μεταξύ ημερομηνιών: " + dateTimePicker1.Value.Date.ToString("dd-MM-yyyy") + " και " + dateTimePicker2.Value.Date.ToString("dd-MM-yyyy");
            resultsLabelCust.Show();
            dataGridView4.Columns.Add("RoomNumber", "Room Number");
            dataGridView4.Columns.Add("RommType", "Τύπος Δωματίου");
            dataGridView4.Columns.Add("Cost", "Κόστος ανά βραδιά");
            DB db = new DB();
            try
            {
                MySqlConnection con = new MySqlConnection(db.getConnString());
                con.Open();
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "select distinct hot_rooms.room_ID, room_TypeN, room_Price from hot_rooms left join hot_bookings on hot_rooms.room_ID = hot_bookings.room_ID " +
                "WHERE (@wantin >= checkout_Date OR @wantout <= checkin_Date) OR (hot_rooms.room_ID not in (select distinct room_ID from hot_bookings));";
                comm.Parameters.AddWithValue("@wantin", date1);
                comm.Parameters.AddWithValue("@wantout", date2);
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    string roomNumber = reader.GetString(0); // Assuming room number is retrieved from the first column
                    string picturePath = reader.GetString(1); // Assuming picture path is retrieved from the second column
                    string cost = reader.GetString(2)+ " €"; // Assuming cost is retrieved from the third column

                    // Add a new row and populate the cells
                    dataGridView4.Rows.Add(roomNumber, picturePath, cost);
                }
                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView4.AutoResizeColumns();
                showRoomBtn.Show();



                con.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Πρόβλημα επικοινωνίας με την βάση δεδομένων. Η εφαρμογή θα τερματιστεί.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void showRoomBtn_Click(object sender, EventArgs e)
        {
            resetText();
            MyList.list.Clear();
            if (dataGridView4.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView4.SelectedRows[0];
                DataGridViewCell cell = selectedRow.Cells[0];
                object value = cell.Value;
                string room_ID;
                if (value != null)
                {
                    room_ID = value.ToString();
                    roomDetailsPanel.Show();
                    roomInfoLabel.Text = "Πληροφορίες για το δωμάτιο " + room_ID;
                    DB db = new DB();
                    List<string> pic_path = new List<string>();
                    try
                    {
                        MySqlConnection con = new MySqlConnection(db.getConnString());
                        con.Open();
                        MySqlCommand comm1 = con.CreateCommand();
                        comm1.CommandText = "select * from hot_rooms_pics where room_ID = @roomID ";
                        comm1.Parameters.AddWithValue("@roomID", room_ID);
                        MySqlDataReader reader1 = comm1.ExecuteReader();
                        bool has_img = false;
                        while (reader1.Read())
                        {
                            MyList.list.Add(reader1.GetString(2));
                            has_img = true;
                        }
                        reader1.Close();
                        MySqlCommand comm2 = con.CreateCommand();
                        comm2.CommandText = "select * from hot_rooms where room_ID = @roomID1";
                        comm2.Parameters.AddWithValue("@roomID1", room_ID);
                        MySqlDataReader reader2 = comm2.ExecuteReader();
                        while (reader2.Read())
                        {
                            int hasAC = (reader2.GetInt32(3));
                            int canSmoke = (reader2.GetInt32(4));
                            int hasHeater = (reader2.GetInt32(5));
                            int forFamily = (reader2.GetInt32(6));
                            int forAmea = (reader2.GetInt32(7));
                            int hasBalcony = (reader2.GetInt32(8));
                            int hasView = (reader2.GetInt32(9));
                            int hasWIFI = (reader2.GetInt32(10));
                            if (hasAC == 0) { acLabel.Text = acLabel.Text + " Όχι"; } else { acLabel.Text = acLabel.Text + " Ναι"; }
                            if (canSmoke == 0) { smokersLabel.Text = smokersLabel.Text + " Όχι"; } else { smokersLabel.Text = smokersLabel.Text + " Ναι"; }
                            if (hasHeater == 0) { heaterLabel.Text = heaterLabel.Text + " Όχι"; } else { heaterLabel.Text = heaterLabel.Text + " Ναι"; }
                            if (forFamily == 0) { familyLabel.Text = familyLabel.Text + " Όχι"; } else { familyLabel.Text = familyLabel.Text + " Ναι"; }
                            if (forAmea == 0) { ameaLabel.Text = ameaLabel.Text + " Όχι"; } else { ameaLabel.Text = ameaLabel.Text + " Ναι"; }
                            if (hasBalcony == 0) { balconyLabel.Text = balconyLabel.Text + " Όχι"; } else { balconyLabel.Text = balconyLabel.Text + " Ναι"; }
                            if (hasView == 0) { seaViewLabel.Text = seaViewLabel.Text + " Όχι"; } else { seaViewLabel.Text = seaViewLabel.Text + " Ναι"; }
                            if (hasWIFI == 0) { wifiLabel.Text = wifiLabel.Text + " Όχι"; } else { wifiLabel.Text = wifiLabel.Text + " Ναι"; }
                        }
                        reader2.Close();
                        con.Close();
                        MyList.index = -1;
                        if (has_img) { 
                            roomPicBox.ImageLocation = "/Rerources/Rooms/" + MyList.list[0].ToString();
                            MyList.index = 0;
                        }
                    }
                    catch (MySqlException z)
                    {
                        MessageBox.Show("Πρόβλημα επικοινωνίας με την βάση δεδομένων!", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(z);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Πρέπει να επιλέξεις ένα δωμάτιο!.", "Μήνυμα εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetText()
        {
            this.acLabel.Text = "Κλιματισμός:";
            this.smokersLabel.Text = "Χώρος Καπνιστών:";
            this.balconyLabel.Text = "Μπαλκόνι:";
            this.heaterLabel.Text = "Θέρμανση:";
            this.familyLabel.Text = "Οικογενειακό:";
            this.ameaLabel.Text = "Κατάλληλο για ΑμεΑ:";
            this.seaViewLabel.Text = "Θέα στην θάλασσα:";
            this.wifiLabel.Text = "Δωρεάν Wi-Fi:";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            roomDetailsPanel.Hide();
            searchRoomDatePanel.Show();
            roomPicBox.Image = null;
        }

        private void prevImage_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            workingDirectory = Directory.GetParent(workingDirectory).Parent.FullName + "\\Resources\\Rooms\\";
            
            if (MyList.index == 0)
            {
                Console.WriteLine("Μάγκα δεν πάει");
            }
            else if (MyList.index == -1) { }
            else
            {

                roomPicBox.ImageLocation = workingDirectory + MyList.list[MyList.index - 1];
                MyList.index = MyList.index - 1;
            }

        }

        private void nextImage_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            workingDirectory = Directory.GetParent(workingDirectory).Parent.FullName + "\\Resources\\Rooms\\";
            if (MyList.index == MyList.list.Count() - 1)
            {
                Console.WriteLine("Μάγκα δεν πάει");
            }
            else if (MyList.index == -1) { }
            else
            {
                roomPicBox.ImageLocation = workingDirectory + MyList.list[MyList.index + 1];
                MyList.index = MyList.index + 1;
                Console.WriteLine("Πάει: " + MyList.index);
            }
        }
    }
}


//select distinct hot_rooms.room_ID, room_TypeN, room_Price from hot_rooms
//left join hot_bookings on hot_rooms.room_ID = hot_bookings.room_ID
//WHERE (@wantin >= checkout_Date OR @wantout <= checkin_Date) OR(hot_rooms.room_ID not in (select distinct room_ID from hot_bookings))
