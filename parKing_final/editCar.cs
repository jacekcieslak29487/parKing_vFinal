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
    public partial class editCar : Form
    {
        public editCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command1 = conn.CreateCommand();

            command1.CommandText = ("DELETE FROM cars WHERE carID='" + textBox1.Text) + "'";
            conn.Open();
            command1.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted successfully");
            this.Close();
        }

        private void LoadCustomersId()
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
                            comboBox1.Items.Add(output);


                        }
                    }
                }
            }
        }

        private void editCar_Load(object sender, EventArgs e)
        {
            LoadCustomersId();
        }
    }
}
