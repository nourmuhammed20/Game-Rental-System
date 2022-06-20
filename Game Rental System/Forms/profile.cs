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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=NOUR-LAPTOP;Initial Catalog=Game_rental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE ADMIN SET PASS ='"+textBox6.Text+ "' , FirstName ='" + textBox1.Text + "' ,LastName = '" + textBox2.Text + "',Age =" + textBox4.Text +" , Email='" + textBox3.Text + "' WHERE ADMINID =" + textBox5.Text + "  ;";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Information Updated Successfully");
        }
    }
}
