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
    public partial class Form1 : Form
    {
        SqlDataAdapter sda1;
        SqlCommandBuilder scb1;
        DataTable dt1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'game_rentalFINAL.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.game_rentalFINAL.CLIENT);
            // TODO: This line of code loads data into the 'game_rentalFINAL.GAME' table. You can move, or remove it, as needed.
            this.gAMETableAdapter.Fill(this.game_rentalFINAL.GAME);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H3U9SJP;Initial Catalog=Game_rental;Integrated Security=True");
            sda1 = new SqlDataAdapter(@"select* from GAME where NoRented = (select max(NoRented) from GAME);", con);
            dt1 = new DataTable();
            sda1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
    }
}
