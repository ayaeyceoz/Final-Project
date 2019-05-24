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
    //Avoid Academy: This minigame is about avoiding the lasers the stroomtroopers send at you by using the force.
    //Use the arrow keys to move the ship up or down. The lasers get faster as the game continues.
{
    public partial class mgAvoid : Form
    {
        public mgAvoid() //tells the instructions and goal in a message box before the game begins 
        {
            InitializeComponent();
            MessageBox.Show("The Stormtroopers are shooting lasers at your ship. Use the force (the arrow keys) to avoid them.");
        }

        private void mgAvoid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) //moves the character only up and down
            {
                picChar1.Top = picChar1.Top - 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                picChar1.Top = picChar1.Top + 10;
            }
            if (picChar1.Top < 0) //if the character goes too far up, then it will be teleported to the bottom 
            {
                picChar1.Top = 555;
            }
            if (picChar1.Top > 555) //if the character goes too far down, it will be teleported to the top
            {
                picChar1.Top = 0;
            }
        }

        int MoveMe = 15;
        int count = 0;
        int score = 0;
        private void tmr1_Tick(object sender, EventArgs e)
        {
            tmr1.Start();
   
            PictureBox[] lasers = new PictureBox[10];
            lasers[0] = picAvoid;
            lasers[1] = pictureBox9;
            lasers[2] = pictureBox11;
            lasers[3] = pictureBox15;
            lasers[4] = pictureBox17;
            lasers[5] = pictureBox19;
            lasers[6] = pictureBox23;
            lasers[7] = pictureBox25;
            lasers[8] = pictureBox7;
            lasers[9] = pictureBox2;

            Random r = new Random();
            int pick = r.Next(0, 10);
            lasers[pick].Left = lasers[pick].Left - MoveMe;
            

            if (lasers[pick].Left > this.Width || lasers[pick].Left <= 0)
            {
                lasers[pick].Left = 653;
                count++;
                score = score + 100;
                lblScore.Text = "Score: " + score;
            }
            if (count%10000 == 1)
            {
                MoveMe++;
            }
            

            if (picChar1.Bounds.IntersectsWith(lasers[pick].Bounds))
            {
                lasers[pick].Left = 653;
                if (picheart1.Visible == false && picheart2.Visible == false)
                {
                    picheart3.Visible = false;
                    tmr1.Enabled = false;
                    MessageBox.Show("You lose! Your score is " + score.ToString() + "!");
                    frmMainMenu obj3 = new frmMainMenu();
                    obj3.Show();
                    this.Hide();
                }
                else if (picheart1.Visible == false)
                {
                    picheart2.Visible = false;
                }
                else
                {
                    picheart1.Visible = false;
                }

            }
        }
    }
}
