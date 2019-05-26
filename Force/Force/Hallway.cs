using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this is a hallway that acts as a mini menu
//it allows the user to go back to the main menu, or choose 1 player/2 player tug of war
namespace Force
{
    public partial class Hallway : Form
    {
        public Hallway()
        {
            InitializeComponent();
        }
        private void btnmainmenu_Click(object sender, EventArgs e)
        {
                frmMainMenu obj8 = new frmMainMenu();
                obj8.Show();
                this.Hide();
        }

        private void btn1player_Click(object sender, EventArgs e)
        {
            TugOfWar obj9 = new TugOfWar();
            obj9.Show();
            this.Hide();
        }

        private void btn2player_Click(object sender, EventArgs e)
        {
            ToW2 obj83 = new ToW2(); //brings to two player tug of war
            obj83.Show();
            this.Hide();
        }
    }
}
