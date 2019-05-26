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
//The Maze Mansion: This minigame is about forcing your son back home.
//Use the arrow keys to move your son, and don't run into the walls of the maze (the void)!
{
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent(); //shows the user the instructions
            MessageBox.Show("You've lost your son! Use the arrow keys to force him back home, but don't lose him in space!");
        }
        int tries = 1; //initializes a variable for the number of tries
        private void Maze_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //moves the son left
            {
                picSon.Left = picSon.Left - 5;
            }
            if (e.KeyCode == Keys.Right) //moves the son right
            {
                picSon.Left = picSon.Left + 5;
            }
            if (e.KeyCode == Keys.Up) //moves the son up
            {
                picSon.Top = picSon.Top - 5;
            }
            if (e.KeyCode == Keys.Down) //moves the son down
            {
                picSon.Top = picSon.Top + 5;
            }
            //initializes an array of pictureboxes to hold all the barriers
            PictureBox[] barriers = new PictureBox[23];
            barriers[0] = barrier17;
            barriers[1] = barrier1;
            barriers[2] = barrier21;
            barriers[3] = barrier11;
            barriers[4] = barrier22;
            barriers[5] = barrier3;
            barriers[6] = barrier18;
            barriers[7] = barrier8;
            barriers[8] = barrier2;
            barriers[9] = barrier20;
            barriers[10] = barrier10;
            barriers[11] = barrier16;
            barriers[12] = barrier19;
            barriers[13] = barrier7;
            barriers[14] = barrier23;
            barriers[15] = barrier9;
            barriers[16] = barrier14;
            barriers[17] = barrier15;
            barriers[18] = barrier6;
            barriers[19] = barrier12;
            barriers[20] = barrier13;
            barriers[21] = barrier4;
            barriers[22] = barrier5;
            //everytime the son moves, a for loop checks to see if the son's bounds intersected with any of the barriers bounds
            for (int i = 0; i < 23; i++)
            {
                if (picSon.Bounds.IntersectsWith(barriers[i].Bounds))
                {
                    //if the user runs into the wall, the son resets, a message box shows up, and the number of tries goes up one
                    tries++;
                    picSon.Left = 688;
                    picSon.Top = 44;
                    MessageBox.Show("You lost your son to the depths of space! Try again.");
                    lbltries.Text = "Tries: " + tries;
                }
                if (picSon.Bounds.IntersectsWith(picChar.Bounds))
                {
                    //if the son makes it to his dad
                    picSon.Left = 688;
                    picSon.Top = 44;
                    //a message is shown congratulating the user (says either "try" or "tries")
                    if (tries == 1)
                    {
                        MessageBox.Show("Congratulations! You forced your son to come home for dinner in " + tries + " try!");
                    }
                    else
                    {
                        MessageBox.Show("Congratulations! You forced your son to come home for dinner in " + tries + " tries!");
                    }
                    //goes back to the main menu
                    frmMainMenu obj4 = new frmMainMenu();
                    obj4.Show();
                    this.Hide();
                }
            }
        
        }
     
    }

}
