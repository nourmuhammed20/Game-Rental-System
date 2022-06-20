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


namespace Game_Rental_System
{
    public partial class ClientProfile : Form
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
        public ClientProfile()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        public void loadform(object Form)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Right;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }

        private void ClientProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new cprofile());
            pnlNav.Height = button1.Height;
            pnlNav.Top = button1.Top;
            pnlNav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new BrowseGames());
            pnlNav.Height = button5.Height;
            pnlNav.Top = button5.Top;
            pnlNav.Left = button5.Left;
            button5.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new SearchGames());
            pnlNav.Height = button7.Height;
            pnlNav.Top = button7.Top;
            pnlNav.Left = button7.Left;
            button7.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
