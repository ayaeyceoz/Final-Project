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
    //Tug of War 2 Players: Play tug of war using the force against a friend
{
    public partial class ToW2 : Form
    {
       
        public ToW2()
        {
            InitializeComponent(); //tells the user the instructions
            MessageBox.Show("Use either the 'A' key or the 'L' key to force your enemy into the void");
        }
   
        private void ToW2_KeyDown(object sender, KeyEventArgs e)
        {
            //a random variable was put into the code in order for there to be an element of luck
            Random r = new Random(); 
            int move = r.Next(1, 15);
            //it will move randomally from 1 - 15 every time one of the players presses their key
            if (e.KeyCode == Keys.A) //everytime player one presses the A key
            {
                picCharR.Left = picCharR.Left - move;
                picRope.Left = picRope.Left - move;
                picCharL.Left = picCharL.Left - move;
            }
            if (e.KeyCode == Keys.L) //everytime player two presses the L key
            {
                picCharR.Left = picCharR.Left + move;
                picRope.Left = picRope.Left + move;
                picCharL.Left = picCharL.Left + move;
            }

            //decides if the left or right player wins based on which character intersects with the middle line
            //takes the user back to the main menu
            if (picCharL.Bounds.IntersectsWith(picVoid.Bounds))
            {
                MessageBox.Show("Congratulations Player 2! You forced your opponent into the void! You win!");
                frmMainMenu obj19 = new frmMainMenu();
                obj19.Show();
                this.Hide();
            }
            if (picCharR.Bounds.IntersectsWith(picVoid.Bounds))
            {
                MessageBox.Show("Congratulations Player 1! You forced your opponent into the void! You win!");
                frmMainMenu obj19 = new frmMainMenu();
                obj19.Show();
                this.Hide();
            }
        }
    }
}
