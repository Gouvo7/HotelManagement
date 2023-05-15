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
    public partial class Form1 : Form
    {
        private string cs = @"server=localhost;userid=root;password=1234;database=hotel";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userTB.Text;
            string password = passTB.Text;

            MySqlConnection con = new MySqlConnection(cs); //open connection
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from hot_usr where usr_username = '" + username + "' AND usr_password = '" + password + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Successfully Sign In!", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Username And Password Not Match!", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                userTB.Text = string.Empty;
                passTB.Text = string.Empty;
                reader.Close();
                cmd.Dispose();
                con.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("Gamhthikes");
            }
        }
    }
}
