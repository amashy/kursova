﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova.lineup_screens.Raze
{
    public partial class RazeIceb : Form
    {
        public RazeIceb()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
