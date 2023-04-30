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
    public partial class BrimHeaven : Form
    {
        public BrimHeaven()
        {
            InitializeComponent();
        }

        private void BrimHeavenALAb_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=6");
        }

        private void BrimHeavenABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=6");
        }

        private void BrimHeavenBLAb_Click(object sender, EventArgs e)
        {

            Process.Start("https://lineupsvalorant.com/?id=1145");
        }

        private void BrimHeavenBBut_Click(object sender, EventArgs e)
        {

            Process.Start("https://lineupsvalorant.com/?id=1145");
        }

        private void BrimHeavenCLAb_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=5");
        }

        private void BrimHeavenCBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=5");
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
