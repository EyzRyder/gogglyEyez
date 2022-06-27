using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gogglyEyez
{
    public partial class zoinho : Form
    {
        string[] anime = { "ANIMATAC 001.ICO", "ANIMATAC 002.ICO",
            "ANIMATAC 003.ICO", "ANIMATAC 004.ICO", "ANIMATAC 005.ICO", 
            "ANIMATAC 006.ICO", "ANIMATAC 007.ICO", "ANIMATAC 008.ICO", 
            "ANIMATAC 009.ICO", "ANIMATAC 010.ICO", "ANIMATAC 011.ICO" };
        int i = 0;
        public zoinho()
        {
            InitializeComponent();
        }

        private void zoinho_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i >= anime.Length) i = 0;
            pictureBox1.Load(anime[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
