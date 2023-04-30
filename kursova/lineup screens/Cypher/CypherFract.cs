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
    public partial class CypherFract : Form
    {
        public CypherFract()
        {
            InitializeComponent();
        }

        private void CypherFractALab_Click(object sender, EventArgs e)
        {

            Process.Start("https://lineupsvalorant.com/?setup=26");
        }

        private void CypherFractABut_Click(object sender, EventArgs e)
        {

            Process.Start("https://lineupsvalorant.com/?setup=26");
        }

        private void CypherFractBLab_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=27");
        }

        private void CypherFractBBut_Click(object sender, EventArgs e)
        {
            Process.Start("https://lineupsvalorant.com/?setup=27");
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
