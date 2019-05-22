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
            InitializeComponent();
            MessageBox.Show("Use either the 'A' key or the 'L' key to force your enemy into the void");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }
   
        private void ToW2_KeyDown(object sender, KeyEventArgs e)
        {
            Random r = new Random();
            int move = r.Next(1, 15);
            if (e.KeyCode == Keys.A)
            {
                picCharR.Left = picCharR.Left - move;
                picRope.Left = picRope.Left - move;
                picCharL.Left = picCharL.Left - move;
            }
            if (e.KeyCode == Keys.L)
            {
                picCharR.Left = picCharR.Left + move;
                picRope.Left = picRope.Left + move;
                picCharL.Left = picCharL.Left + move;
            }
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
