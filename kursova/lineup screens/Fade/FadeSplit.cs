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
    public partial class FadeSplit : Form
    {
        public FadeSplit()
        {
            InitializeComponent();
        }

        private void FadeSplitALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=210");
        }

        private void FadeSplitABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=210");
        }

        private void FadeSplitBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=666");
        }

        private void FadeSplitBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=666");
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
