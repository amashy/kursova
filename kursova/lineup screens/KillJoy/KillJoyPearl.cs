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
    public partial class KillJoyPearl : Form
    {
        public KillJoyPearl()
        {
            InitializeComponent();
        }
        

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KillJoyPearlALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=754");


        }

        private void KillJoyPearlABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=754");


        }

        private void KillJoyPearlBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/bW4C0EowVXU");
        }

        private void KillJoyPearlBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/shorts/bW4C0EowVXU");
        }
    }
}
