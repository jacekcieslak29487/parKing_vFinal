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
    public partial class addReserv : Form
    {
        public addReserv()
        {
            InitializeComponent();
        }

        private void addReserv_Load(object sender, EventArgs e)
        {
            LoadCars();
            LoadClients();
        }







        private void LoadClients()
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

        private void LoadCars()
        {
            var connectionString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT carID, carBrand, carModel, registrationNumber FROM cars";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            string output = reader.GetString("carID") + ") " + reader.GetString("carBrand") + " " + reader.GetString("carModel") + " " + reader.GetString("registrationNumber");
                            comboBox2.Items.Add(output);


                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            var query1 = "SELECT name, surName, pesel FROM clients WHERE clientID=" + textBox2.Text +";";
            MySqlCommand command1 = new MySqlCommand(query1, conn);

            var reader1 = command1.ExecuteReader();

            reader1.Read();   
                string nameValue = reader1.GetString("name");
                string surnameValue = reader1.GetString("surname");
                string peselValue = reader1.GetString("pesel");
            conn.Close();


            conn.Open();
            var query2 = "SELECT registrationNumber FROM cars WHERE carID = " + textBox3.Text +"; ";
            MySqlCommand command2 = new MySqlCommand(query2, conn);

            var reader2 = command2.ExecuteReader();

            reader2.Read();
            string elo = reader2.GetString("registrationNumber");
            conn.Close();



       

            command1.CommandText = "INSERT INTO parkingSpot (name, surName, pesel, registrationNumber, days) VALUES ('" + nameValue + "','" + surnameValue + "', '" + peselValue + "','" + elo  + "','" + textBox2.Text + "')";
            conn.Open();
            command1.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Added successfully");
            this.Close();




        }

        private void button3_Click(object sender, EventArgs e)
        {

            

        }
    }
}
