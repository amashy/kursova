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

namespace kursova
{
    public partial class KillJoyFract : Form
    {
        public KillJoyFract()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KillJoyFractALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=2098");
        }

        private void KillJoyFractABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=2098");
        }

        private void KillJoyFractBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=13");
        }

        private void KillJoyFractBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=13");
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
