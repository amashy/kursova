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
    public partial class YoruPearl : Form
    {
        public YoruPearl()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FadeAscBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=745");

        }

        private void FadeAscBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=745");

        }

        private void FadeAscALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=778");

        }

        private void FadeAscABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=778");

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
