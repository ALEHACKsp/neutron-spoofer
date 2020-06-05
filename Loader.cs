using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatality_Menu
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void Loader_Load(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {
            Menu FrmMain = new Menu();
            this.Hide();
            FrmMain.ShowDialog();
            this.Close();
        }
        private void Picturebox1_Paint(object sender, PaintEventArgs e)
        {
            using (Brush rainbow_brush2 = Rainbow.RainbowBrush2(
            new Point(0, 0),
            new Point(Middle.ClientSize.Width, Middle.ClientSize.Height)))
            {
                e.Graphics.FillRectangle(rainbow_brush2, Middle.ClientRectangle);
            }
        }

        private void header4_Load(object sender, EventArgs e)
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
    }
}