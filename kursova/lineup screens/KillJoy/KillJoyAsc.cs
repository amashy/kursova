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
    public partial class KillJoyAsc : Form
    {
        public KillJoyAsc()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KillJoyAscALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1252");
        }

        private void KillJoyAscABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1252");
        }

        private void KillJoyAscBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=668");
        }

        private void KillJoyAscBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=668");
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
