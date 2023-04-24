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

namespace kursova.lineup_screens.Sova
{
    public partial class SovaHeaven : Form
    {
        public SovaHeaven()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SovaHeavenALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=364");

        }

        private void SovaHeavenABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=364");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=382");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=382");

        }

        private void SovaHeavenBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1257");

        }

        private void SovaHeavenBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1257");

        }
    }
}
