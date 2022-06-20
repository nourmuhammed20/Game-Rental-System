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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            DateTime time = DateTime.Now;              // Use current time
            string format = "yyyy-MM-dd HH:mm:ss";    // modify the format depending upon input required in the column in database
            sqlCommand.CommandText = "insert into GAME (PRICE,CATEGORY,DATECREATED,GAMEID,VENDORID,GNAME,ADMINID,DATEPUBLISHED,STAT,NoRented) values(" + textBox3.Text+",'"+textBox6.Text+"','" + dateTimePicker1.Value.Date + "'," +textBox4.Text+","+textBox5.Text +",'"+ textBox1.Text+"',"+ textBox2.Text + ",'" + time.ToString(format) + "','AVAILABLE',0);";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Game added Successfully");
        }

        private void AddGame_Load(object sender, EventArgs e)
        {

        }
    }
}
