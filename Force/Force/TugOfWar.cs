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
            InitializeComponent();
            MessageBox.Show("Use the 'J' key to force your enemy into the void!");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timer1.Start();
            Random r = new Random();
            int move = r.Next(1, 10);
            picCharL.Left = picCharL.Left - move;
            picRope.Left = picRope.Left - move;
            picCharR.Left = picCharR.Left - move;
            if (picCharR.Bounds.IntersectsWith(picVoid.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Your opponent forced you into the void! You lose!");
                frmMainMenu obj81 = new frmMainMenu();
                obj81.Show();
                this.Hide();
            }
        }

        private void TugOfWar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J)
            {
                picCharR.Left = picCharR.Left + 15;
                picRope.Left = picRope.Left + 15;
                picCharL.Left = picCharL.Left + 15;
            }
            if (picCharL.Bounds.IntersectsWith(picVoid.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Congratulations! You forced your opponent into the void! You win!");
                frmMainMenu obj80 = new frmMainMenu();
                obj80.Show();
                this.Hide();
            }
           
        }
    }
}
