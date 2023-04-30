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
    public partial class ViperPeral : Form
    {
        public ViperPeral()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViperPeralALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=951");

        }

        private void ViperPeralABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=951");

        }

        private void ViperPeralBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=735");

        }

        private void ViperPeralBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=735");

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
