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

namespace kursova
{
    public partial class FadeIceb : Form
    {
        public FadeIceb()
        {
            InitializeComponent();
        }

        private void FadeIcebALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=380");
        }

        private void FadeIcebABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=380");
        }

        private void FadeIcebBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=406");
        }

        private void FadeIcebBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?id=406");
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
