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
    public partial class YoruIceb : Form
    {
        public YoruIceb()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void YoruIcebALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=349");

        }

        private void YoruIcebABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=349");

        }

        private void YoruIcebBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=351");

        }

        private void YoruIcebBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=351");

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
