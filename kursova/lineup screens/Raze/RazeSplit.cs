﻿using System;
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
    public partial class RazeSplit : Form
    {
        public RazeSplit()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RazeSplitBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=2");


        }

        private void RazeSplitBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=2");


        }

        private void RazeSplitBBut_Click_1(object sender, EventArgs e)
        {

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapSelect mapSelect = new MapSelect();
            mapSelect.Show();
        }
    }
}
