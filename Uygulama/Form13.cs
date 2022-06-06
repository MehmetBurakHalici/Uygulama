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
    public partial class DörtİşlemOyunu : Form
    {
        public DörtİşlemOyunu()
        {
            InitializeComponent();
        }

        int süre = 25;
        int puan = 0;
        int doğru = 0, yanlış = 0;
        Random rastgele = new Random();

        private void GirişYap_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Clear();

            int sayi1, sayi2, islem;
            int a, b;
            int topla, çarp, çıkar, böl;

            sayi1 = rastgele.Next(0, 101);
            sayi2 = rastgele.Next(0, 101);
            islem = rastgele.Next(0, 4);

            label1.Text = sayi1.ToString();
            label3.Text = sayi2.ToString();

            a = Convert.ToInt32(label1.Text);
            b = Convert.ToInt32(label3.Text);

            if (islem == 1)
            {
                label2.Text = "+";
                topla = a + b;
                label5.Text = topla.ToString();
            }
            if (islem == 2)
            {
                label2.Text = "-";
                çıkar = a - b;
                label5.Text = çıkar.ToString();
            }
            if (islem == 3)
            {
                label2.Text = "*";
                çarp = a * b;
                label5.Text = çarp.ToString();
            }
            if (islem == 4)
            {
                label2.Text = "/";
                böl = a / b;
                label5.Text = böl.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;

            if (label5.Text == textBox1.Text)
            {
                puan += 10;
                doğru += 1;
                label6.Text = puan.ToString();
                label14.Text = doğru.ToString();
            }
            else
            {
                puan -= 10;
                yanlış += 1;
                label6.Text = puan.ToString();
                label16.Text = yanlış.ToString();
            }
        }

        private void DörtİşlemOyunu_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Start();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            label9.Text = süre.ToString();

            if(süre == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                timer1.Stop();
                süre = 25;
                button3.Enabled = true;
                MessageBox.Show("Süreniz Bitti!", "SÜRE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            timer1.Start();
            süre = 25;
            button3.Enabled = false;
            puan = 0;
            doğru = 0;
            yanlış = 0;
            label6.Text = puan.ToString();
            label14.Text = puan.ToString();
            label16.Text = puan.ToString();
            label1.Text = "";
            label3.Text = "";
            textBox1.Clear();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            new Uygulama().Show();
            this.Hide();
        }
    }
}
