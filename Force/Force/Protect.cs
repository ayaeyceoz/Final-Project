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
{   //move your player left and right to block the asteroids
    public partial class Protect : Form
    {
        public Protect()
        {
            InitializeComponent();
            MessageBox.Show("By controlling your character with the arrow keys, use the force to repel the asteroids before they hit your planet!");
        }
        int lives = 10; //variables to hold the number of lives and days
        int days = 0;
        int hold = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            int reset = 31; //variable to hold the position of the respawn point
            int change = 10; //variable to hold the speed of the asteroids
            hold++; //a variable to hold the time that has passed
            if (hold %1000 == 1) //after a certain amount of time, the number of days goes up and is displayed
            {
                days++;
                lblDays.Text = "Days: " + days;
            }

            //an array of pictureboxes to hold the asteroids
            PictureBox[] aster = new PictureBox[9];
            aster[0] = ast8;
            aster[1] = ast1;
            aster[2] = ast9;
            aster[3] = ast7;
            aster[4] = ast6;
            aster[5] = ast5;
            aster[6] = ast4;
            aster[7] = ast3;
            aster[8] = ast2;

            //picks a random asteroid to move each time the timer ticks
            //interval is so small that it will appear all the asteroids are moving at the same time
            Random r = new Random();
            int move = r.Next(0, 9);
            aster[move].Top = aster[move].Top + change;

            //every time an asteroid successfully hits, you lose a life, and it resets
            if (aster[move].Top >= 374)
            {
                lives--;
                lbllives.Text = "Lives: " + lives;
                aster[move].Top = reset;
                if (lives < 1) //when you run out of lives, the game is over
                {
                    timer1.Stop();
                    MessageBox.Show("Your planet got destroyed after " + days + " days.");
                    frmMainMenu obj42 = new frmMainMenu();
                    obj42.Show();
                    this.Hide();
                }
            }

            //if the asteroid is blocked by the character, it simply resets
            if (aster[move].Bounds.IntersectsWith(picChar.Bounds))
            {
                aster[move].Top = reset;
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

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmMainMenu obj3 = new frmMainMenu();
            obj3.Show();
            this.Hide();
        }
    }
}

