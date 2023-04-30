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

namespace kursova.lineup_screens.Kayo
{
    public partial class KayoHeaven : Form
    {
        public KayoHeaven()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KayoHeavenALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=261");


        }

        private void KayoHeavenABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=261");


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=223");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=223");
        }

        private void KayoHeavenCLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=725");


        }

        private void KayoHeavenCBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=725");


        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
