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

namespace kursova.lineup_screens.Cypher
{
    public partial class CypherPearl : Form
    {
        public CypherPearl()
        {
            InitializeComponent();
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

        private void CypherPearlALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=61");
        }

        private void CypherPearlABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=61");
        }

        private void CypherPearlBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=62");
        }

        private void CypherPearlBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=62");
        }
    }
}
