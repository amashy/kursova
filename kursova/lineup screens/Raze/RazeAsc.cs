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
    public partial class RazeAsc : Form
    {
        public RazeAsc()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RazeAscALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=721");


        }

        private void RazeAscABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=721");


        }

        private void RazeAscBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1258");


        }

        private void RazeAscBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1258");


        }
    }
}
