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
    public partial class ViperFract : Form
    {
        public ViperFract()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViperFractALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1223");

        }

        private void ViperFractABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1223");

        }

        private void ViperFractBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=772");

        }

        private void ViperFractBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=772");

        }
    }
}
