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
    public partial class BrimIceb : Form
    {
        public BrimIceb()
        {
            InitializeComponent();
        }

        private void BrimIcebALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=21");
        }

        private void BrimIcebABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=21");
        }

        private void BrimIcebBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1457");
        }

        private void BrimIcebBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1457");
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
