using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Game_Rental_System
{
    public partial class BrowseGames : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public BrowseGames()
        {
            InitializeComponent();
        }

        private void BrowseGames_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            sda = new SqlDataAdapter(@"SELECT * FROM GAME;", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
