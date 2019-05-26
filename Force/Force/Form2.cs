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

        int MoveMe = 15; //variable to decide how fast the lasers move
        int count = 0; //variable to hold how many times the lasers have passed (lasers dodged successfully)
        int score = 0; //variable to hold the score of the player
        private void tmr1_Tick(object sender, EventArgs e)
        {
            tmr1.Start();
            //array of pictureboxes to hold the lasers
            PictureBox[] lasers = new PictureBox[10];
            lasers[0] = piclaser1;
            lasers[1] = piclaser4;
            lasers[2] = piclaser5;
            lasers[3] = piclaser6;
            lasers[4] = piclaser7;
            lasers[5] = piclaser8;
            lasers[6] = piclaser9;
            lasers[7] = piclaser10;
            lasers[8] = piclaser3;
            lasers[9] = piclaser2;

            //everytime the timer ticks, a random number picks one laser to move forward
            //the interval of the timer is so small, the lasers will appear to be moving at the same time
            Random r = new Random();
            int pick = r.Next(0, 10);
            lasers[pick].Left = lasers[pick].Left - MoveMe;
            
            //when the lasers go past the bounds of the form, they reset and the score goes up 100 points
            if (lasers[pick].Left > this.Width || lasers[pick].Left <= 0)
            {
                lasers[pick].Left = 653;
                count++;
                score = score + 100;
                lblScore.Text = "Score: " + score;
            }

            //every time the number of lasers that crossed divided by 10000, the lasers will move faster
            //as the game continues, the lasers will move faster and faster so the game will get harder
            if (count%10000 == 1)
            {
                MoveMe++;
            }
            
            //if statement to decide what happens when the rocket gets hit by a laser
            if (picChar1.Bounds.IntersectsWith(lasers[pick].Bounds))
            {
                lasers[pick].Left = 653; //laser resets to original position
                //depending on how many lives left, the next heart will disappear (another life lost)
                if (picheart1.Visible == false && picheart2.Visible == false) 
                {
                    //once all lives are lost, the game ends, tells the user their score, and goes back to the main menu
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

        private void move(object sender, KeyEventArgs e) //event handler for KeyDown
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
    }
}
