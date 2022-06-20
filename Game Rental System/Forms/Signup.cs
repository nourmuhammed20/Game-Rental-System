using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Game_Rental_System
{
    public partial class Signup : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
  int nLeftRect,     // x-coordinate of upper-left corner
  int nTopRect,      // y-coordinate of upper-left corner
  int nRightRect,    // x-coordinate of lower-right corner
  int nBottomRect,   // y-coordinate of lower-right corner
  int nWidthEllipse, // width of ellipse
  int nHeightEllipse // height of ellipse
);
        public Signup()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO ADMIN Values ('" + textBox6.Text + "'," + textBox5.Text + ",'" + textBox1.Text + "','" + textBox2.Text + "'," + textBox4.Text + ",'" + textBox3.Text + "');";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            this.Hide();
            adminProfile f2 = new adminProfile();
            f2.ShowDialog();
            this.Close();

        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-H3U9SJP;Initial Catalog=Game_rental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO CLIENT Values ('"+textBox1.Text+"','"+textBox2.Text+"','"+ textBox6.Text+"',"+textBox4.Text+","+textBox5.Text+",'"+textBox3.Text+"');";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            this.Hide();
            ClientProfile f3 = new ClientProfile();
            f3.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
