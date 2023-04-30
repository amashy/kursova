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

namespace kursova.menus
{
    public partial class HarborPearl : Form
    {
        public HarborPearl()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HarborPearlALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/tlHAosHRiJw");
        }

        private void HarborPearlABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/tlHAosHRiJw");
        }

        private void HarborPearlBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/tlHAosHRiJw");
        }

        private void HarborPearlBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/tlHAosHRiJw");
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
