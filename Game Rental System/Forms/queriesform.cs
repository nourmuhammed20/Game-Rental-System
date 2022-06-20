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
    public partial class queriesform : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public queriesform()
        {
            InitializeComponent();
        }

        private void queriesform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'game_rentalFINAL.VENDOR' table. You can move, or remove it, as needed.
            //this.vENDORTableAdapter1.Fill(this.game_rentalFINAL.VENDOR);
            // TODO: This line of code loads data into the 'game_rentalFINAL.CLIENT' table. You can move, or remove it, as needed.
            //this.cLIENTTableAdapter1.Fill(this.game_rentalFINAL.CLIENT);
            // TODO: This line of code loads data into the 'game_rentalFINAL.GAME' table. You can move, or remove it, as needed.
            //this.gAMETableAdapter1.Fill(this.game_rentalFINAL.GAME);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            sda = new SqlDataAdapter(@"select* from GAME where NoRented = (select max(NoRented) from GAME);", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            sda = new SqlDataAdapter(@"select GNAME ,GAME.GAMEID from GAME except select   GNAME ,GAME.GAMEID from GAME full join RENT on RENT.GAMEID = GAME.GAMEID where RENT.RENTALDATE >= DATEADD(month, datediff(month, 0, getdate())-1, 0) AND RENTALDATE <  DATEADD(DAY, DATEDIFF(day, 0, getdate()), 1) ;", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            sda = new SqlDataAdapter(@"select TOP 1 CLIENT.CLIENTID,AGE,EMAIL,FNAME,LNAME from CLIENT  full join RENT on RENT.CLIENTID = CLIENT.CLIENTID where RENT.RENTALDATE >= DATEADD(month, datediff(month, 0, getdate())-1, 0) AND RENTALDATE <  DATEADD(DAY, DATEDIFF(day, 0, getdate()), 1) ORDER BY (select count(CLIENTID) from CLIENT) DESC;", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            sda = new SqlDataAdapter(@"select TOP 1 VNAME,VENDOR.VENDORID From VENDOR join GAME on VENDOR.VENDORID = GAME.VENDORID join RENT on GAME.GAMEID = RENT.GAMEID where RENT.RENTALDATE >= DATEADD(month, datediff(month, 0, getdate())-1, 0) AND RENTALDATE<DATEADD(DAY, DATEDIFF(day, 0, getdate()), 1) ORDER BY(select count(GAME.GAMEID) from GAME) DESC;", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView6.DataSource = dt;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            sda = new SqlDataAdapter(@"select VNAME, VENDOR.VENDORID From VENDOR except select VNAME, VENDOR.VENDORID From VENDOR join GAME on VENDOR.VENDORID = GAME.VENDORID join RENT on GAME.GAMEID = RENT.GAMEID where RENT.RENTALDATE >= DATEADD(month, datediff(month, 0, getdate())-1, 0) AND RENTALDATE<DATEADD(DAY, DATEDIFF(day, 0, getdate()), 1) ;", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView6.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            sda = new SqlDataAdapter(@"select VNAME, VENDOR.VENDORID From VENDOR except select VNAME, VENDOR.VENDORID From VENDOR join GAME on VENDOR.VENDORID = GAME.VENDORID WHERE YEAR(GAME.DATEPUBLISHED) = YEAR(GETDATE()) - 1;", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView6.DataSource = dt;
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
