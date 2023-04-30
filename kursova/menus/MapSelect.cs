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
using kursova.lineup_screens.Cypher;
using kursova.menus;
using kursova.lineup_screens.Kayo;
using kursova.lineup_screens.Raze;
using kursova.lineup_screens.Sova;
using kursova.lineup_screens.Yoru;

namespace kursova
{
    public partial class MapSelect : Form
    {
        private string selectedAgent;

        PictureBox mapPictureBox = null;

        public MapSelect(string agent)
        {
            InitializeComponent();
            selectedAgent = agent;
        }

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

        public void Fracture_Click(object sender, EventArgs e)
        {
            mapPictureBox = Fracture;
        }

        public void MapSelect_Load(object sender, EventArgs e)
        {
            
        }

        public void Ascent_Click(object sender, EventArgs e)
        {
            mapPictureBox = Ascent;
        }

        public void Icebox_Click(object sender, EventArgs e)
        {
            mapPictureBox = Icebox; 
        }

        public void Pearl_Click(object sender, EventArgs e)
        {
            mapPictureBox = Pearl;  
        }

        public void Split_Click(object sender, EventArgs e)
        {
            mapPictureBox = Split;
        }

        public void Haven_Click(object sender, EventArgs e)
        {
            mapPictureBox = Haven;
        }

        private void label6_Click(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedMap = mapPictureBox.Name;



            if (selectedAgent == "Brimstone")
            {
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    BrimFract brimFract = new BrimFract();
                    brimFract.Show();

                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    BrimAsc brimAsc = new BrimAsc();
                    brimAsc.Show();
                } 
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    BrimFract brimFract = new BrimFract();
                    brimFract.Show();
                    
                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    BrimAsc brimAsc = new BrimAsc();
                    brimAsc.Show();
                }
                if (selectedMap == "Haven")
                {
                    this.Hide();
                    BrimHeaven brimHeaven = new BrimHeaven();
                    brimHeaven.Show();
                }
                if (selectedMap == "Icebox")
                {
                    this.Hide();
                    BrimIceb brimIceb = new BrimIceb();
                    brimIceb.Show();
                }
                if (selectedMap == "Pearl")
                {
                    this.Hide();
                    BrimPearl brimPearl = new BrimPearl();
                    brimPearl.Show();
                }
                if (selectedMap == "Split")
                {
                    this.Hide();
                    BrimSplit brimSplit = new BrimSplit();
                    brimSplit.Show();
                }
            }
            if (selectedAgent == "Cypher")
            {
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    CypherFract cypherFract = new CypherFract();
                    cypherFract.Show();
                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    CypherAsc cypherAsc = new CypherAsc();
                    cypherAsc.Show();
                }
                if (selectedMap == "Haven")
                {
                    this.Hide();
                    CypherHeaven cypherHeaven = new CypherHeaven();
                    cypherHeaven.Show();
                }
                if (selectedMap == "Icebox")
                {
                    this.Hide();
                    CypherIceb cypherIceb = new CypherIceb();
                    cypherIceb.Show();
                }
                if (selectedMap == "Pearl")
                {
                    this.Hide();
                    CypherPearl cypherPearl = new CypherPearl();
                    cypherPearl.Show();
                }
                if (selectedMap == "Split")
                {
                    this.Hide();
                    CypherSplit cypherSplit = new CypherSplit();
                    cypherSplit.Show();
                }
            }
            if (selectedAgent == "Fade")
            {
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    FadeFract fadeFract = new FadeFract();
                    fadeFract.Show();
                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    FadeAsc fadeAsc = new FadeAsc();
                    fadeAsc.Show();
                }
                if (selectedMap == "Haven")
                {
                    this.Hide();
                    FadeHeaven fadeHeaven = new FadeHeaven();
                    fadeHeaven.Show();
                }
                if (selectedMap == "Icebox")
                {
                    this.Hide();
                    FadeIceb fadeIceb = new FadeIceb();
                    fadeIceb.Show();
                }
                if (selectedMap == "Pearl")
                {
                    this.Hide();
                    FadePearl fadePearl = new FadePearl();
                    fadePearl.Show();
                }
                if (selectedMap == "Split")
                {
                    this.Hide();
                    FadeSplit fadeSplit = new FadeSplit();
                    fadeSplit.Show();
                }
            }
            if (selectedAgent == "Harbor")
            {
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    HarborFract harborFract = new HarborFract();
                    harborFract.Show();
                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    HarborAsc harborAsc = new HarborAsc();
                    harborAsc.Show();
                }
                if (selectedMap == "Haven")
                {
                    this.Hide();
                    HarborHeaven harborHeaven = new HarborHeaven();
                    harborHeaven.Show();
                }
                if (selectedMap == "Icebox")
                {
                    this.Hide();
                    HarborIceb harborIceb = new HarborIceb();
                    harborIceb.Show();
                }
                if (selectedMap == "Pearl")
                {
                    this.Hide();
                    HarborPearl harborPearl = new HarborPearl();
                    harborPearl.Show();
                }
                if (selectedMap == "Split")
                {
                    this.Hide();
                    HarborSplit harborSplit = new HarborSplit();
                    harborSplit.Show();
                }
            }
            if (selectedAgent == "Kayo")
            {
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    KayoFract kayoFract = new KayoFract();
                    kayoFract.Show();
                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    KayoAsc kayoAsc = new KayoAsc();
                    kayoAsc.Show();
                }
                if (selectedMap == "Haven")
                {
                    this.Hide();
                    KayoHeaven kayoHeaven = new KayoHeaven();
                    kayoHeaven.Show();
                }
                if (selectedMap == "Icebox")
                {
                    this.Hide();
                    KayoIceb kayoIceb = new KayoIceb();
                    kayoIceb.Show();
                }
                if (selectedMap == "Pearl")
                {
                    this.Hide();
                    KayoPearl kayoPearl = new KayoPearl();
                    kayoPearl.Show();
                }
                if (selectedMap == "Split")
                {
                    this.Hide();
                    KayoSplit kayoSplit = new KayoSplit();
                    kayoSplit.Show();
                }
            }
            if (selectedAgent == "KillJoy")
            {
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    KillJoyFract killJoyFract = new KillJoyFract();
                    killJoyFract.Show();
                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    KillJoyAsc killJoyAsc = new KillJoyAsc();
                    killJoyAsc.Show();
                }
                if (selectedMap == "Haven")
                {
                    this.Hide();
                    KillJoyHeaven killJoyHeaven = new KillJoyHeaven();
                    killJoyHeaven.Show();
                }
                if (selectedMap == "Icebox")
                {
                    this.Hide();
                    KillJoyIceb killJoyIceb = new KillJoyIceb();
                    killJoyIceb.Show();
                }
                if (selectedMap == "Pearl")
                {
                    this.Hide();
                    KillJoyPearl killJoyPearl = new KillJoyPearl();
                    killJoyPearl.Show();
                }
                if (selectedMap == "Split")
                {
                    this.Hide();
                    KillJoySplit killJoySplit = new KillJoySplit();
                    killJoySplit.Show();
                }
            }
            if (selectedAgent == "Raze")
            {
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    RazeFract razeFract = new RazeFract();
                    razeFract.Show();
                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    RazeAsc razeAsc = new RazeAsc();
                    razeAsc.Show();
                }
                if (selectedMap == "Haven")
                {
                    this.Hide();
                    RazeHeaven razeHeaven = new RazeHeaven();
                    razeHeaven.Show();
                }
                if (selectedMap == "Icebox")
                {
                    this.Hide();
                    RazeIceb razeIceb = new RazeIceb();
                    razeIceb.Show();
                }
                if (selectedMap == "Pearl")
                {
                    this.Hide();
                    RazePearl razePearl = new RazePearl();
                    razePearl.Show();
                }
                if (selectedMap == "Split")
                {
                    this.Hide();
                    RazeSplit razeSplit = new RazeSplit();
                    razeSplit.Show();
                }
            }
            if (selectedAgent == "Sova")
            {
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    SovaFract sovaFract = new SovaFract();
                    sovaFract.Show();
                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    SovaAsc sovaAsc = new SovaAsc();
                    sovaAsc.Show();
                }
                if (selectedMap == "Haven")
                {
                    this.Hide();
                    SovaHeaven sovaHeaven = new SovaHeaven();
                    sovaHeaven.Show();
                }
                if (selectedMap == "Icebox")
                {
                    this.Hide();
                    SovaIceb sovaIceb = new SovaIceb();
                    sovaIceb.Show();
                }
                if (selectedMap == "Pearl")
                {
                    this.Hide();
                    SovaPearl sovaPearl = new SovaPearl();
                    sovaPearl.Show();
                }
                if (selectedMap == "Split")
                {
                    this.Hide();
                    SovaSplit sovaSplit = new SovaSplit();
                    sovaSplit.Show();
                }
            }
            if (selectedAgent == "Viper")
            {
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    ViperFract viperFract = new ViperFract();
                    viperFract.Show();
                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    ViperAsc viperAsc = new ViperAsc();
                    viperAsc.Show();
                }
                if (selectedMap == "Haven")
                {
                    this.Hide();
                    ViperHeaven viperHeaven = new ViperHeaven();
                    viperHeaven.Show();
                }
                if (selectedMap == "Icebox")
                {
                    this.Hide();
                    ViperIceb viperIceb = new ViperIceb();
                    viperIceb.Show();
                }
                if (selectedMap == "Pearl")
                {
                    this.Hide();
                    ViperPeral viperPeral = new ViperPeral();
                    viperPeral.Show();
                }
                if (selectedMap == "Split")
                {
                    this.Hide();
                    ViperSplit viperSplit = new ViperSplit();
                    viperSplit.Show();
                }
            }
            if (selectedAgent == "Yoru")
            {
                if (selectedMap == "Fracture")
                {
                    this.Hide();
                    YoruFract yoruFract = new YoruFract();
                    yoruFract.Show();
                }
                if (selectedMap == "Ascent")
                {
                    this.Hide();
                    YoruAsc yoruAsc = new YoruAsc();
                    yoruAsc.Show();
                }
                if (selectedMap == "Haven")
                {
                    this.Hide();
                    YoruHeaven yoruHeaven = new YoruHeaven();
                    yoruHeaven.Show();
                }
                if (selectedMap == "Icebox")
                {
                    this.Hide();
                    YoruIceb yoruIceb = new YoruIceb();
                    yoruIceb.Show();
                }
                if (selectedMap == "Pearl")
                {
                    this.Hide();
                    YoruPearl yoruPearl = new YoruPearl();
                    yoruPearl.Show();
                }
                if (selectedMap == "Split")
                {
                    this.Hide();
                    YoruSplit yoruSplit = new YoruSplit();
                    yoruSplit.Show();
                }
            }
        }
    }
}
