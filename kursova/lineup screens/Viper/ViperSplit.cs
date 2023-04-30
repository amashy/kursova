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
    public partial class ViperSplit : Form
    {
        public ViperSplit()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViperSplitBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=245");

        }

        private void ViperSplitBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=245");

        }

        private void ViperSplitALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=612");

        }

        private void ViperSplitABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=612");

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
