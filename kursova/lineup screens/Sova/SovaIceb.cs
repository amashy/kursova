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

namespace kursova.lineup_screens.Sova
{
    public partial class SovaIceb : Form
    {
        public SovaIceb()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SovaIcebALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1070");

        }

        private void SovaIcebABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1070");

        }

        private void SovaIcebBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1100");

        }

        private void SovaIcebBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=1100");

        }
    }
}