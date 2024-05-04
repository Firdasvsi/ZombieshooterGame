using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieshooterGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\user\Desktop\ZombieshooterGame\ZombieshooterGame\Resources\background sound.wav");
            sound.Play();
        }

        private void btn_option_MouseHover(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.option_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\user\Desktop\ZombieshooterGame\ZombieshooterGame\Resources\background sound.wav");
            sound.Play();
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\user\Desktop\ZombieshooterGame\ZombieshooterGame\Resources\background sound.wav");
            sound.Play();
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_normal;
        }

        private void btn_option_MouseLeave(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.option_normal;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_normal;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            StartScreenGame startScreen = new StartScreenGame();
            startScreen.ShowDialog();
        }

        private void btn_option_Click(object sender, EventArgs e)
        {
            option_page option = new option_page();
            option.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
