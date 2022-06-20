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
using Game_Rental_System;
using System.Data.SqlClient;

namespace Game_Rental_System
{
    public partial class adminProfile : Form
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
        private void adminProfile_Load(object sender, EventArgs e)
        {

        }

        public adminProfile()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

 
        public void loadform(object Form)
        {
            if (this.panel4.Controls.Count > 0)
                this.panel4.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Right;
            this.panel4.Controls.Add(f);
            this.panel4.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new profile());
            pnlNav.Height = button1.Height;
            pnlNav.Top = button1.Top;
            pnlNav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button2.Height;
            pnlNav.Top = button2.Top;
            pnlNav.Left = button2.Left;
            button2.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new AddGame());

        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            
            
            pnlNav.Height = button3.Height;
            pnlNav.Top = button3.Top;
            pnlNav.Left = button2.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new UpdateGame());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login f2 = new Login();
            f2.ShowDialog();
            this.Close();
            pnlNav.Height = button4.Height;
            pnlNav.Top = button4.Top;
            pnlNav.Left = button4.Left;
            button4.BackColor = Color.FromArgb(46, 51, 73);
        }




        private void button5_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button5.Height;
            pnlNav.Top = button5.Top;
            pnlNav.Left = button5.Left;
            button5.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new BrowseGames());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = searchBtn.Height;
            pnlNav.Top = searchBtn.Top;
            pnlNav.Left = searchBtn.Left;
            searchBtn.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new SearchGames());
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button7.Height;
            pnlNav.Top = button7.Top;
            pnlNav.Left = button7.Left;
            button7.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new queriesform());
        }


        private void label2_Click(object sender, EventArgs e)
        {
            string ADMINID = null;
            label2.Text = ADMINID;
        }
    }
}
