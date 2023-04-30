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
    public partial class SovaAsc : Form
    {
        public SovaAsc()
        {
            InitializeComponent();
        }

        private void SovaAscALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=15");


        }

        private void SovaAscABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=15");


        }

        private void SovaAscBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=286");

        }

        private void SovaAscBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=286");

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
