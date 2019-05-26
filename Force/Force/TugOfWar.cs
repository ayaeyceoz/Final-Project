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
    //Tug of War One Player: Play tug of war using the force against a CPU
{
    public partial class TugOfWar : Form
    {
        public TugOfWar()
        {
            InitializeComponent(); //tells the user the instructions
            MessageBox.Show("Use the 'J' key to force your enemy into the void!");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           //the cpu moves a random amount every time the timer ticks 
            timer1.Start();
            Random r = new Random();
            int move = r.Next(1, 10);
            picCharL.Left = picCharL.Left - move;
            picRope.Left = picRope.Left - move;
            picCharR.Left = picCharR.Left - move;

            //if the CPU pulls the user all the way to the midpoint line, the user loses
            if (picCharR.Bounds.IntersectsWith(picVoid.Bounds))
            {
                timer1.Stop(); //the game stops, and brings the user back to the main menu
                MessageBox.Show("Your opponent forced you into the void! You lose!");
                frmMainMenu obj81 = new frmMainMenu();
                obj81.Show();
                this.Hide();
            }
        }

        private void TugOfWar_KeyDown(object sender, KeyEventArgs e)
        {
            //everytime the user presses "J", they move
            if (e.KeyCode == Keys.J)
            {
                picCharR.Left = picCharR.Left + 15;
                picRope.Left = picRope.Left + 15;
                picCharL.Left = picCharL.Left + 15;
            }
            //if the user pulls the CPU to the midpoint line, the user wins
            if (picCharL.Bounds.IntersectsWith(picVoid.Bounds))
            {
                timer1.Stop(); //the game stops, and brings the user back to the main menu
                MessageBox.Show("Congratulations! You forced your opponent into the void! You win!");
                frmMainMenu obj80 = new frmMainMenu(); 
                obj80.Show();
                this.Hide();
            }
           
        }
    }
}
