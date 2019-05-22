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
//Maze Mansion: This minigame is about forcing your son back home. 
{
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
            MessageBox.Show("You've lost your son! Use the arrow keys to force him back home, but don't lose him in space!");
        }
        int tries = 1;
        private void Maze_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                picSon.Left = picSon.Left - 5;
            }
            if (e.KeyCode == Keys.Right)
            {
                picSon.Left = picSon.Left + 5;
            }
            if (e.KeyCode == Keys.Up)
            {
                picSon.Top = picSon.Top - 5;
            }
            if (e.KeyCode == Keys.Down)
            {
                picSon.Top = picSon.Top + 5;
            }
            PictureBox[] barriers = new PictureBox[23];
            barriers[0] = pictureBox23;
            barriers[1] = pictureBox1;
            barriers[2] = pictureBox2;
            barriers[3] = pictureBox3;
            barriers[4] = pictureBox4;
            barriers[5] = pictureBox5;
            barriers[6] = pictureBox6;
            barriers[7] = pictureBox7;
            barriers[8] = pictureBox8;
            barriers[9] = pictureBox9;
            barriers[10] = pictureBox10;
            barriers[11] = pictureBox11;
            barriers[12] = pictureBox12;
            barriers[13] = pictureBox13;
            barriers[14] = pictureBox14;
            barriers[15] = pictureBox15;
            barriers[16] = pictureBox16;
            barriers[17] = pictureBox17;
            barriers[18] = pictureBox18;
            barriers[19] = pictureBox19;
            barriers[20] = pictureBox20;
            barriers[21] = pictureBox21;
            barriers[22] = pictureBox22;
            for (int i = 0; i < 7; i++)
            {
                if (picSon.Bounds.IntersectsWith(barriers[i].Bounds))
                {
                    tries++;
                    picSon.Left = 688;
                    picSon.Top = 44;
                    MessageBox.Show("You lost your son to the depths of space! Try again.");
                    lbltries.Text = "Tries: " + tries;
                }
                if (picSon.Bounds.IntersectsWith(picChar.Bounds))
                {
                    picSon.Left = 688;
                    picSon.Top = 44;
                    if (tries == 1)
                    {
                        MessageBox.Show("Congratulations! You forced your son to come home for dinner in " + tries + " try!");
                    }
                    else
                    {
                        MessageBox.Show("Congratulations! You forced your son to come home for dinner in " + tries + " tries!");
                    }
                    frmMainMenu obj4 = new frmMainMenu();
                    obj4.Show();
                    this.Hide();
                }



                for (int k = 22; i > 8; i--)
                {
                    if (picSon.Bounds.IntersectsWith(barriers[k].Bounds))
                    {
                        tries++;
                        picSon.Left = 688;
                        picSon.Top = 44;
                        MessageBox.Show("You lost your son to the depths of space! Try again.");
                        lbltries.Text = "Tries: " + tries;
                    }
                    if (picSon.Bounds.IntersectsWith(picChar.Bounds))
                    {
                        picSon.Left = 688;
                        picSon.Top = 44;
                        if (tries == 1)
                        {
                            MessageBox.Show("Congratulations! You forced your son to come home for dinner in " + tries + " try!");
                        }
                        else
                        {
                            MessageBox.Show("Congratulations! You forced your son to come home for dinner in " + tries + " tries!");
                        }
                        frmMainMenu obj4 = new frmMainMenu();
                        obj4.Show();
                        this.Hide();
                    }
                }
            }
        
        }
        int count = 0;
      

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Start();
            count++;
            if (count % 10 <= 0 || count % 10 >= 5)
            {
                pictureBox7.Visible = false;
            }
            else
            {
                pictureBox7.Visible = true;
            }
        }
    }

}
