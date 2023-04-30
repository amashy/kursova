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
    public partial class YoruFract : Form
    {
        public YoruFract()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void YoruFractALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=572");

        }

        private void YoruFractABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=572");

        }

        private void YoruFractBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=570");

        }

        private void YoruFractBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=570");

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
