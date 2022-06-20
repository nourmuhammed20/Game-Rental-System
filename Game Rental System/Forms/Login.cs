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
    public partial class Login : Form
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
        public string conString = "Data Source=DESKTOP-H3U9SJP;Initial Catalog=Game_rental;Integrated Security=True";


        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Above code Closes current Form And Open Next form (Signup)
            this.Hide();
            Signup f1 = new Signup();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM ADMIN WHERE ADMINID=" + textBox1.Text + " AND PASS='" + textBox2.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT COUNT(*) FROM CLIENT WHERE CLIENTID=" + textBox1.Text + " AND CPASS='" + textBox2.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt2 = new DataTable(); //this is creating a virtual table  
            sda2.Fill(dt2);
            adminProfile obj = new adminProfile();
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                adminProfile f2 = new adminProfile();
                f2.ShowDialog();
                this.Close();
            }
            if (dt2.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                ClientProfile f3 = new ClientProfile();
                f3.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Invalid username or password");

        }
    }
}


