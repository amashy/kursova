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
    public partial class RazeFract : Form
    {
        public RazeFract()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RazeFractALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=485");


        }

        private void RazeFractABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=485");


        }

        private void RazeFractBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=486");


        }

        private void RazeFractBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=486");


        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
