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

namespace ExoUtil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) => Hide();

        private void killSpotifyToolStripMenuItem1_Click(object sender, EventArgs e) => Process.Start("cmd", "/c taskkill /im Spotify.exe /t /f");
        
        private void killRobloxToolStripMenuItem1_Click(object sender, EventArgs e) => Process.Start("cmd", "/c taskkill /im robloxplayerbeta.exe /t /f");

        private void killDiscordToolStripMenuItem1_Click(object sender, EventArgs e) => Process.Start("cmd", "/c taskkill /im Discord.exe /t /f");

        private void showToolStripMenuItem_Click(object sender, EventArgs e) => Show();

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) => Process.Start("cmd", "/c taskkill /im ExoUtil.exe /t /f");
    }
}
