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
    public partial class FadeAsc : Form
    {
        public FadeAsc()
        {
            InitializeComponent();
        }

        private void FadeAscALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=263");
        }

        private void FadeAscABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=263");
        }

        private void FadeAscBLab_Click(object sender, EventArgs e)
        {

            Process.Start("https://lineupsvalorant.com/?id=291");
        }

        private void FadeAscBBut_Click(object sender, EventArgs e)
        {

            Process.Start("https://lineupsvalorant.com/?id=291");
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
