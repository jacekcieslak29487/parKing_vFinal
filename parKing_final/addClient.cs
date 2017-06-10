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
    public partial class addClient : Form
    {
        public addClient()
        {
            InitializeComponent();
        }

        private void addClient_Load(object sender, EventArgs e)
        {

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

            command1.CommandText = "INSERT INTO Clients (name, surName, pesel) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "')";
            conn.Open();
            command1.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Added successfully");
            this.Close();
        }
    }
}
