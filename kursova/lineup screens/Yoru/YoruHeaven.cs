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
    public partial class YoruHeaven : Form
    {
        public YoruHeaven()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void YoruHeavenALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=536");

        }

        private void YoruHeavenABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=536");

        }

        private void YoruHeavenBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=537");

        }

        private void YoruHeavenBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=537");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=533");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=533");

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
