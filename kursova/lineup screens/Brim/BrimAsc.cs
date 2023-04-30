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
    public partial class BrimAsc : Form
    {
        public BrimAsc()
        {
            InitializeComponent();
        }

        private void BrimAscA_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=91");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=91");
        }

        private void BrimAscBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=192");
        }

        private void BrimAscBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=192");
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
