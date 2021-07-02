using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8ball
{
    public partial class Form2 : Form
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
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
