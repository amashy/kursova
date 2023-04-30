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
    public partial class FadeFract : Form
    {
        public FadeFract()
        {
            InitializeComponent();
        }

        private void FadeFractALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=900");
        }

        private void FadeFractABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=900");
        }

        private void FadeFractBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=316");
        }

        private void FadeFractBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=316");
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
