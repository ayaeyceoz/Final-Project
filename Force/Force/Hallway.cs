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
{
    public partial class Hallway : Form
    {
        public Hallway()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu obj8 = new frmMainMenu();
            obj8.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TugOfWar obj9 = new TugOfWar();
            obj9.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToW2 obj83 = new ToW2();
            obj83.Show();
            this.Hide();
        }
    }
}
