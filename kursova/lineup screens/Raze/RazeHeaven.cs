using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova.lineup_screens.Raze
{
    public partial class RazeHeaven : Form
    {
        public RazeHeaven()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RazeHeavenALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=857");


        }

        private void RazeHeavenABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=857");


        }

        private void RazeHeavenBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=4");


        }

        private void RazeHeavenBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=4");
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
