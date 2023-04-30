using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova
{
    public partial class AgentSelectScreen : Form
    {
       
        public AgentSelectScreen()
        {
            InitializeComponent();
        }

        private void close_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("У виборі представлені лише агнети, яким є сенс дізнаватися про 'Лайнапи', тобто мають метальні здібності");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Brimstone_Click(object sender, EventArgs e)
        {
            PictureBox selectedAgentPictureBox = (PictureBox)sender;
            MapSelect mapSelectForm = new MapSelect(selectedAgentPictureBox.Name);
            mapSelectForm.Show();
            this.Hide();
        }

        private void Cypher_Click(object sender, EventArgs e)
        {
            PictureBox selectedAgentPictureBox = (PictureBox)sender;
            MapSelect mapSelectForm = new MapSelect(selectedAgentPictureBox.Name);
            mapSelectForm.Show();
            this.Hide();
        }

        private void Fade_Click(object sender, EventArgs e)
        {
            PictureBox selectedAgentPictureBox = (PictureBox)sender;
            MapSelect mapSelectForm = new MapSelect(selectedAgentPictureBox.Name);
            mapSelectForm.Show();
            this.Hide();
        }

        private void Harbor_Click(object sender, EventArgs e)
        {
            PictureBox selectedAgentPictureBox = (PictureBox)sender;
            MapSelect mapSelectForm = new MapSelect(selectedAgentPictureBox.Name);
            mapSelectForm.Show();
            this.Hide();
        }

        private void Sova_Click(object sender, EventArgs e)
        {
            PictureBox selectedAgentPictureBox = (PictureBox)sender;
            MapSelect mapSelectForm = new MapSelect(selectedAgentPictureBox.Name);
            mapSelectForm.Show();
            this.Hide();
        }

        private void Raze_Click(object sender, EventArgs e)
        {
            PictureBox selectedAgentPictureBox = (PictureBox)sender;
            MapSelect mapSelectForm = new MapSelect(selectedAgentPictureBox.Name);
            mapSelectForm.Show();
            this.Hide();
        }

        private void Killjoy_Click(object sender, EventArgs e)
        {
            PictureBox selectedAgentPictureBox = (PictureBox)sender;
            MapSelect mapSelectForm = new MapSelect(selectedAgentPictureBox.Name);
            mapSelectForm.Show();
            this.Hide();
        }

        private void Kayo_Click(object sender, EventArgs e)
        {
            PictureBox selectedAgentPictureBox = (PictureBox)sender;
            MapSelect mapSelectForm = new MapSelect(selectedAgentPictureBox.Name);
            mapSelectForm.Show();
            this.Hide();
        }

        private void Viper_Click(object sender, EventArgs e)
        {
            PictureBox selectedAgentPictureBox = (PictureBox)sender;
            MapSelect mapSelectForm = new MapSelect(selectedAgentPictureBox.Name);
            mapSelectForm.Show();
            this.Hide();
        }

        private void Yoru_Click(object sender, EventArgs e)
        {
            PictureBox selectedAgentPictureBox = (PictureBox)sender;
            MapSelect mapSelectForm = new MapSelect(selectedAgentPictureBox.Name);
            mapSelectForm.Show();
            this.Hide();
        }

        private void back_arrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeScreen welcomeScreen = new WelcomeScreen();
            welcomeScreen.Show();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
