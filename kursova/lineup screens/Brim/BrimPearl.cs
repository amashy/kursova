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
    public partial class BrimPearl : Form
    {
        public BrimPearl()
        {
            InitializeComponent();
        }

        private void BrimPearlALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=720");
        }

        private void BrimPearlABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=720");
        }

        private void BrimPearlBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1188");
        }

        private void BrimPearlBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1188");
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
