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
    public partial class cprofile : Form
    {
        public cprofile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE CLIENT SET CPASS ='" + textBox6.Text + "' , FNAME ='" + textBox1.Text + "' ,LNAME = '" + textBox2.Text + "',AGE =" + textBox4.Text + " , Email='" + textBox3.Text + "' WHERE CLIENTID =" + textBox5.Text + "  ;";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Profile Updated Successfully");
        }
    }
}
