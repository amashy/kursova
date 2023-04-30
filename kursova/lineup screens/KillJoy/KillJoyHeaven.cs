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
    public partial class KillJoyHeaven : Form
    {
        public KillJoyHeaven()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KillJoyHeavenALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=74");
        }

        private void KillJoyHeavenABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=74");
        }

        private void KillJoyHeavenBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=75");
        }

        private void KillJoyHeavenBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=75");
        }

        private void KillJoyHeavenCLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=76");

        }

        private void KillJoyHeavenCBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=76");

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
