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
    public partial class HarborIceb : Form
    {
        public HarborIceb()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HarborIcebALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/2pAPaRkUWb8");
        }

        private void HarborIcebABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/2pAPaRkUWb8");
        }

        private void HarborIcebBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/2pAPaRkUWb8?t=45");
        }

        private void HarborIcebBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/2pAPaRkUWb8?t=45");
        }
    }
}
