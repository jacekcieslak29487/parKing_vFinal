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

namespace parKing_new
{
    public partial class editClient : Form
    {
       

        public editClient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command1 = conn.CreateCommand();

            command1.CommandText = ("DELETE FROM clients WHERE clientID='" + textBox1.Text) +"'";           
            conn.Open();
            command1.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted successfully");
            this.Close();



        }

       

        //Load customer ID to a combobox
        private void LoadCustomersId()
        {
            var connectionString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT clientID, name, surName, pesel FROM clients";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            string output = reader.GetString("clientID") + ") " + reader.GetString("name") + " " + reader.GetString("surName") + " " + reader.GetString("pesel");
                            comboBox1.Items.Add(output);

                            
                        }
                    }
                }
            }
        }

        //Load customer details using the ID
        private void LoadCustomerDetailsById(int id)
        {
            var connectionString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT clientID, name, surName FROM clients WHERE clientID = @clientID";
                using (var command = new MySqlCommand(query, connection))
                {
                    //Always use SQL parameters to avoid SQL injection and it automatically escapes characters
                    command.Parameters.AddWithValue("@clientID", id);
                    using (var reader = command.ExecuteReader())
                    {
                        //No customer found by supplied ID
                        if (!reader.HasRows)
                            return;
                        
                        
                        
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clientID = Convert.ToInt32(comboBox1.Text);
            




        }



        private void editClient_Load_1(object sender, EventArgs e)
        {
            LoadCustomersId();
        }
    }
}
