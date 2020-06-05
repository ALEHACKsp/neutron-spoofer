using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatality_Menu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;
        public Boolean isFlash;

        private void Picturebox1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }
        private void T_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void T_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void T_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            Loader FrmMain = new Loader();
            this.Hide();
            FrmMain.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isFlash)
            {
              
            }
            else
            {
               
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void header4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            
           
            WebClient wb = new WebClient();


            string HWIDLIST = wb.DownloadString("http://kobhook.000webhostapp.com/loader/neutronisbest.txt");


            if (passbox.Text == "")
            {
                MessageBox.Show("Please Enter Field with ur key ");
                return;

            }



            if (HWIDLIST.Contains(passbox.Text))
            {
                this.Hide();

                Loader FrmMain = new Loader();
                this.Hide();
                FrmMain.ShowDialog();
                this.Close();

            }
            else
            {

                MessageBox.Show("Invalid key");
            }
        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}