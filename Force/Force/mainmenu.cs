using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Final Project
//Aya Eyceoz and Amelia Ballingall
//June 6th, 2019
//Programming Honors Period 2
//HackExeter 2019
//Force Freeway
//The theme for this Hackathon was force. We have created a world called Force Freeway, a freeway filled with force related minigames. 
//Move the character to the desired minigame and explore Force Freeway!
namespace Force
//This form is the main menu that allows you to go to different minigames.
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //moves the character left 
            {
                picChar.Left = picChar.Left - 10;
            }
            if (e.KeyCode == Keys.Right) //moves the character right
            {
                picChar.Left = picChar.Left + 10;
            }
            if (e.KeyCode == Keys.Up) //moves the character up
            {
                picChar.Top = picChar.Top - 10;
            }
            if (e.KeyCode == Keys.Down) //moves the character down
            {
                picChar.Top = picChar.Top + 10;
            }

            if (picChar.Bounds.IntersectsWith(picmgAvoid.Bounds))
            {
                mgAvoid obj1 = new mgAvoid(); //goes to Minigame Avoid Academy
                obj1.Show(); //mg stands for minigame
                this.Hide();
            }            if (picChar.Bounds.IntersectsWith(mgMaze.Bounds))
            {
                Maze obj2 = new Maze(); //goes to Maze Mansion
                obj2.Show();
                this.Hide();
            }
            if (picChar.Bounds.IntersectsWith(mgToW.Bounds))
            {
                Hallway obj5 = new Hallway(); //goes to the Hallway for the two different Tug of War games
                obj5.Show();
                this.Hide();
            }
            if (picChar.Bounds.IntersectsWith(mgProtect.Bounds))
            {
                Protect obj52 = new Protect(); //goes to Planet Protection Pavilion 
                obj52.Show();
                this.Hide();
            }
        }
    }
}

