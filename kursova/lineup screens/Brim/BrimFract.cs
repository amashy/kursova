using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace kursova
{
    public partial class BrimFract : Form
    {
        public BrimFract()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=619");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=619");
        }

        private void BrimFractBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1119");
        }

        private void BrimFractBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1119");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=472");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=472");
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
