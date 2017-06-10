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
    public partial class showCars : Form
    {
        public showCars()
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
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from cars", connString);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["carID"].ToString());
                listitem.SubItems.Add(dr["carBrand"].ToString());
                listitem.SubItems.Add(dr["carModel"].ToString());
                listitem.SubItems.Add(dr["registrationNumber"].ToString());
                listView1.Items.Add(listitem);
            }
        }
    }
}
