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
    public partial class CypherAsc : Form
    {
        public CypherAsc()
        {
            InitializeComponent();
        }

        private void CypherAscALab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=2");
        }

        private void CypherAscABut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=2");
        }

        private void CypherAscBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=3");
        }

        private void CypherAscBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=3");
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
