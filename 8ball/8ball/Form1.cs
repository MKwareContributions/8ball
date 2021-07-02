using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace _8ball
{
    public partial class Form1 : Form
    {
        private const int WM_NCHITTEST = 0x84;                                   // Making form be able to drag
        private const int HTCLIENT = 0x1;                                        // To be honest, I have no idea what any of these are mean. I've copypasted code from stackoverflow (big thanks to it's community).
        private const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rand = RandomNumber(1, 6);
            ball.Location = new Point(ball.Location.X, ball.Location.Y + 5);        // Shaking animation
            System.Threading.Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 10);
            System.Threading.Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X, ball.Location.Y + 10);
            System.Threading.Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 10);
            System.Threading.Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X, ball.Location.Y + 10);
            System.Threading.Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 10);
            System.Threading.Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X, ball.Location.Y + 10);
            System.Threading.Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 10);
            System.Threading.Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X, ball.Location.Y + 10);
            System.Threading.Thread.Sleep(50);
            ball.Location = new Point(ball.Location.X, ball.Location.Y - 5);
            ball.Image = _8ball.Properties.Resources.ball;
            if (rand == 1) 
            {
                ball.BackgroundImage = _8ball.Properties.Resources.ball;
                ball.Image = _8ball.Properties.Resources.no;
            }
            if (rand == 2)
            {
                ball.BackgroundImage = _8ball.Properties.Resources.ball;
                ball.Image = _8ball.Properties.Resources.tryagain;
            }
            if (rand == 3)
            {
                ball.BackgroundImage = _8ball.Properties.Resources.ball;
                ball.Image = _8ball.Properties.Resources.yes;
            }
            if (rand == 4)
            {
                ball.BackgroundImage = _8ball.Properties.Resources.ball;
                ball.Image = _8ball.Properties.Resources.maybe;
            }
            if (rand == 5)
            {
                ball.BackgroundImage = _8ball.Properties.Resources.ball;
                ball.Image = _8ball.Properties.Resources.really;
            }
            if (rand == 6)
            {
                ball.BackgroundImage = _8ball.Properties.Resources.ball;
                ball.Image = _8ball.Properties.Resources.hellno;
            }
        }
        private readonly Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void ball_Click(object sender, EventArgs e)
        {
            ball.Image = _8ball.Properties.Resources._8ball;
        }
    }
}
