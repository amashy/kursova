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
    public partial class HarborSplit : Form
    {
        public HarborSplit()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HarborSplitALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/oBW3N7fD00o?t=4");
        }

        private void HarborSplitABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/oBW3N7fD00o?t=4");
        }

        private void HarborSplitBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/oBW3N7fD00o?t=261");
        }

        private void HarborSplitBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/oBW3N7fD00o?t=261");
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
