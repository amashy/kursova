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
    public partial class HarborFract : Form
    {
        public HarborFract()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HarborFractALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=l4dfQY6IKnc");
        }

        private void HarborFractABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=l4dfQY6IKnc");
        }

        private void HarborFractBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=l4dfQY6IKnc");
        }

        private void HarborFractBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=l4dfQY6IKnc");
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
