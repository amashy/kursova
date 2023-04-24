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
    public partial class FadePearl : Form
    {
        public FadePearl()
        {
            InitializeComponent();
        }

        private void FadePearlALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=697");
        }

        private void FadePearlABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=697");
        }

        private void FadePearlBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=726");
        }

        private void FadePearlBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=726");
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
