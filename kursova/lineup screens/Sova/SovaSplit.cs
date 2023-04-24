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
    public partial class SovaSplit : Form
    {
        public SovaSplit()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SovaSplitBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=131");

        }

        private void SovaSplitBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=131");

        }

        private void SovaSplitALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1882");

        }

        private void SovaSplitABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1882");

        }
    }
}
