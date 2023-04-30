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
    public partial class SovaPearl : Form
    {
        public SovaPearl()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SovaPearlALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=2121");

        }

        private void SovaPearlABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=2121");

        }

        private void SovaPearlBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1420");

        }

        private void SovaPearlBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1420");

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
