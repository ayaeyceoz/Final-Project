using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Force
    //Planet Protection Pavilion: Protect your planet from asteroids using the force!
{
    public partial class Protect : Form
    {
        public Protect()
        {
            InitializeComponent();
            MessageBox.Show("By controlling your character with the arrow keys, use the force to repel the asteroids before they hit your planet!");
        }
        int lives = 10;
        int days = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            int reset = 31;
            int change = 10;
            PictureBox[] lasers = new PictureBox[9];
            lasers[0] = pictureBox3;
            lasers[1] = pictureBox1;
            lasers[2] = pictureBox2;
            lasers[3] = pictureBox4;
            lasers[4] = pictureBox5;
            lasers[5] = pictureBox6;
            lasers[6] = pictureBox7;
            lasers[7] = pictureBox8;
            lasers[8] = pictureBox9;
            Random r = new Random();
            int move = r.Next(0, 9);
            lasers[move].Top = lasers[move].Top + change;

            if (lasers[move].Top >= 374)
            {
                lives--;
                lbllives.Text = "Lives: " + lives;
                lasers[move].Top = reset;
                days++;
                lblDays.Text = "Days: " + days;
                if (lives < 1)
                {
                    timer1.Stop();
                    MessageBox.Show("Your planet got destroyed after " + days + " days.");
                    frmMainMenu obj42 = new frmMainMenu();
                    obj42.Show();
                    this.Hide();
                }
            }


            if (lasers[move].Bounds.IntersectsWith(picChar.Bounds))
            {
                lasers[move].Top = reset;
            }
            
        }

        private void Protect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                picChar.Left = picChar.Left - 15;
            }
            if (e.KeyCode == Keys.Right)
            {
                picChar.Left = picChar.Left + 15;
            }
        }

     
    }
}

