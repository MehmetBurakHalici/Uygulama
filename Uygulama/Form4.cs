using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama
{
    public partial class Uygulama : Form
    {
        bool move;
        int mouse_x;
        int mouse_y;

        public Uygulama()
        {
            InitializeComponent();
        }

        private void Uygulama_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Uygulama_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Uygulama_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new MailUygulaması().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Uygulamadan Çıkış Yapmak İstediğinize Emin Misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(secim == DialogResult.Yes)
            {
                new Giriş().Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.tr/?hl=tr");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://translate.google.com/?hl=tr");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.binance.com/tr");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.udemy.com/");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.netflix.com/");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.blutv.com/");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.exxen.com/");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            new AtYarışı().Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            new ZarOyunu().Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            new MüzikÇalar().Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            new Paint2().Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            new KöstebekOyunu().Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            new HesapMakinesi().Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            new HafızaOyunu().Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin Misiniz?","ÇIKIŞ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(secenek == DialogResult.Yes)
            {
                new Giriş().Show();
                this.Hide();
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            new DörtİşlemOyunu().Show();
            this.Hide();
        }
    }
}
