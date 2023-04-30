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

namespace kursova
{
    public partial class ViperIceb : Form
    {
        public ViperIceb()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViperIcebALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=262");

        }

        private void ViperIcebABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=262");

        }

        private void ViperIcebBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=185");

        }

        private void ViperIcebBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=185");

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
