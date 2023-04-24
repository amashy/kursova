using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace kursova
{
    public partial class MapSelect : Form
    {
        public MapSelect()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgentSelectScreen agentSelectScreen = new AgentSelectScreen();
            agentSelectScreen.Show();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void info_icon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут представлені лише ті карти, які присутні в поточному 'мап-пулі'");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
