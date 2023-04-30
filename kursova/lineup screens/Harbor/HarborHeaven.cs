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
    public partial class HarborHeaven : Form
    {
        public HarborHeaven()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HarborHeavenALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/GIe2xLWKnVQ");
        }

        private void HarborHeavenABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/GIe2xLWKnVQ");
        }

        private void HarborHeavenBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/GIe2xLWKnVQ");
        }

        private void HarborHeavenBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/GIe2xLWKnVQ");
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
