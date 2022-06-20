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
using System.Configuration;

namespace Game_Rental_System
{
    public partial class SearchGames : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public SearchGames()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            sda =new SqlDataAdapter(@"Select * FROM GAME where GNAME like '%" + textBox1.Text+"%' OR CATEGORY like '%"+ textBox4.Text+ "%'OR DATECREATED like '%" + dateTimePicker1.Value.Date + "%';", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void SearchGames_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'game_rentalFINAL.GAME' table. You can move, or remove it, as needed.
            //this.gAMETableAdapter1.Fill(this.game_rentalFINAL.GAME);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            sda = new SqlDataAdapter(@"  update GAME set STAT ='Rented' , NoRented=NoRented+1 where GAMEID=" + textBox5.Text + " ;", con);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            con.Open();
            DateTime time = DateTime.Now;              // Use current time
            string format = "yyyy-MM-dd HH:mm:ss";    // modify the format depending upon input required in the column in database 
            sqlCommand.CommandText = " insert into RENT(CLIENTID,GAMEID,RENTALDATE) VALUES (" + textBox2.Text + "," + textBox5.Text + ",'" + time.ToString(format) + "');";
            sqlCommand.ExecuteNonQuery();
            con.Close(); dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Game RENTED Successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            sda = new SqlDataAdapter(@"  update GAME set STAT ='AVAIALBLE' where GAMEID=" + textBox5.Text + " ;", con);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            con.Open();
            DateTime time2 = DateTime.Now;              // Use current time
            string format = "yyyy-MM-dd HH:mm:ss";    // modify the format depending upon input required in the column in database 
            sqlCommand.CommandText = " UPDATE RENT set RETURNDATE = '" + time2.ToString(format) + "' where GAMEID=" + textBox5.Text + " AND CLIENTID = "+textBox2.Text+";";
            sqlCommand.ExecuteNonQuery();
            con.Close(); dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Game Returned Successfully");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
