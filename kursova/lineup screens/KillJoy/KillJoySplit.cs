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
    public partial class KillJoySplit : Form
    {
        public KillJoySplit()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KillJoySplitALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=23");
        }

        private void KillJoySplitABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=23");
        }

        private void KillJoySplitBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=21");
        }

        private void KillJoySplitBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=21");
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
