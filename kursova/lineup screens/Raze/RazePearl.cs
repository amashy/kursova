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

namespace kursova.lineup_screens.Raze
{
    public partial class RazePearl : Form
    {
        public RazePearl()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RazePearlALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1409");


        }

        private void RazePearlABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1409");
        }
    }
}
