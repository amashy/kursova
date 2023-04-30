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
    public partial class BrimSplit : Form
    {
        public BrimSplit()
        {
            InitializeComponent();
        }

        private void BrimSplitALAb_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=132");
        }

        private void BrimSplitABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=132");
        }

        private void BrimSplitBLab_Click(object sender, EventArgs e)
        {

            Process.Start("https://lineupsvalorant.com/?id=1852");
        }

        private void BrimSplitBBut_Click(object sender, EventArgs e)
        {

            Process.Start("https://lineupsvalorant.com/?id=1852");
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
