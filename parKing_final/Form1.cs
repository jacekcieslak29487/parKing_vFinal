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

namespace parKing_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClient addClient = new addClient();
            addClient.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editClient editClient = new editClient();
            editClient.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editCar editCar = new editCar();
            editCar.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showClient show = new showClient();
            show.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Authors:\n Sylwia Modrzejewska\n Andrzej Majcher\n Maciej Karol\n Michał Ratajczyk\n Jacek Cieślak\n Tomasz Kaczmarek\n\n kierunek:\n Informatyka sem. IV niestacjonarne\n\n przedmiot:\n Zarządzanie Jakością Oprogramowania");
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addCar addCar = new addCar();
            addCar.Show();
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showCars showCars = new showCars();
            showCars.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addReserv addReserv = new addReserv();
            addReserv.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from parkingSpot WHERE spotID=1", connString);
            listView1.Items.Clear();
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["spotID"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["surname"].ToString());
                listitem.SubItems.Add(dr["pesel"].ToString());
                listitem.SubItems.Add(dr["registrationNumber"].ToString());
                listitem.SubItems.Add(dr["days"].ToString());
                listView1.Items.Add(listitem);
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from parkingSpot WHERE spotID=1", connString);
            listView1.Items.Clear();
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["spotID"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["surname"].ToString());
                listitem.SubItems.Add(dr["pesel"].ToString());
                listitem.SubItems.Add(dr["registrationNumber"].ToString());
                listitem.SubItems.Add(dr["days"].ToString());
                listView1.Items.Add(listitem);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from parkingSpot WHERE spotID=2", connString);
            listView1.Items.Clear();
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["spotID"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["surname"].ToString());
                listitem.SubItems.Add(dr["pesel"].ToString());
                listitem.SubItems.Add(dr["registrationNumber"].ToString());
                listitem.SubItems.Add(dr["days"].ToString());
                listView1.Items.Add(listitem);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from parkingSpot WHERE spotID=3", connString);
            listView1.Items.Clear();
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["spotID"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["surname"].ToString());
                listitem.SubItems.Add(dr["pesel"].ToString());
                listitem.SubItems.Add(dr["registrationNumber"].ToString());
                listitem.SubItems.Add(dr["days"].ToString());
                listView1.Items.Add(listitem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from parkingSpot WHERE spotID=4", connString);
            listView1.Items.Clear();
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["spotID"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["surname"].ToString());
                listitem.SubItems.Add(dr["pesel"].ToString());
                listitem.SubItems.Add(dr["registrationNumber"].ToString());
                listitem.SubItems.Add(dr["days"].ToString());
                listView1.Items.Add(listitem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
            string connString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from parkingSpot WHERE spotID=5", connString);
            listView1.Items.Clear();

            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["spotID"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["surname"].ToString());
                listitem.SubItems.Add(dr["pesel"].ToString());
                listitem.SubItems.Add(dr["registrationNumber"].ToString());
                listitem.SubItems.Add(dr["days"].ToString());
                listView1.Items.Add(listitem);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=ewisys;Uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from parkingSpot WHERE spotID=6", connString);
            listView1.Items.Clear();
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["spotID"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["surname"].ToString());
                listitem.SubItems.Add(dr["pesel"].ToString());
                listitem.SubItems.Add(dr["registrationNumber"].ToString());
                listitem.SubItems.Add(dr["days"].ToString());
                listView1.Items.Add(listitem);
            }
        }
    }
}
