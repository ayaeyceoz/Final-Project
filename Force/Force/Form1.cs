using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Aya and Amelia
//5.4.2019
//Programming Honors Period 2
//HackExeter 2019
//Force Freeway
namespace Force //This for is the main menu where you can go to different minigames
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //moves the character
            {
                picChar.Left = picChar.Left - 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                picChar.Left = picChar.Left + 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                picChar.Top = picChar.Top - 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                picChar.Top = picChar.Top + 10;
            }
            if (picChar.Bounds.IntersectsWith(picmgAvoid.Bounds)) //visit different minigames (go to different forms)
            {
                mgAvoid obj1 = new mgAvoid();
                obj1.Show();
                this.Hide();
            }            if (picChar.Bounds.IntersectsWith(mgMaze.Bounds))
            {
                Maze obj2 = new Maze();
                obj2.Show();
                this.Hide();
            }
            if (picChar.Bounds.IntersectsWith(mgToW.Bounds))
            {
                Hallway obj5 = new Hallway();
                obj5.Show();
                this.Hide();
            }
            if (picChar.Bounds.IntersectsWith(mgProtect.Bounds))
            {
                Protect obj52 = new Protect();
                obj52.Show();
                this.Hide();
            }


        }
    }
}

