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

namespace kursova.lineup_screens.Yoru
{
    public partial class YoruSplit : Form
    {
        public YoruSplit()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void YoruSplitALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=509");

        }

        private void YoruSplitABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=509");

        }

        private void YoruSplitBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=44");

        }

        private void YoruSplitBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=44");

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
