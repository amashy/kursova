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
    public partial class FadeHeaven : Form
    {
        public FadeHeaven()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=877");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=877");
        }

        private void FadeIHeavenALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=201");
        }

        private void FadeIHeavenABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=201");
        }

        private void FadeIHeavenBLab_Click(object sender, EventArgs e)
        {

        }

        private void FadeIHeavenBBut_Click(object sender, EventArgs e)
        {

        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
