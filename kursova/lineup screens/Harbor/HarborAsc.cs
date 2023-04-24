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
    public partial class HarborAsc : Form
    {
        public HarborAsc()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HarborAscALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=wKlDVV54skg");
        }

        private void HarborAscABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=wKlDVV54skg");
        }

        private void HarborAscBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=wKlDVV54skg");
        }

        private void HarborAscBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=wKlDVV54skg");
        }
    }
}
