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
    public partial class HafızaOyunu : Form
    {
        public HafızaOyunu()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            new Uygulama().Show();
            this.Hide();
        }

        int süre = 5;
        Random rastgele = new Random();

        private void BAŞLAT_Click(object sender, EventArgs e)
        {
            timer1.Start();
            BAŞLAT.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;

            int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8, sayi9, sayi10, sayi11, sayi12;

            sayi1 = rastgele.Next(0, 50);
            sayi2 = rastgele.Next(0, 50);
            sayi3 = rastgele.Next(0, 50);
            sayi4 = rastgele.Next(0, 50);
            sayi5 = rastgele.Next(0, 50);
            sayi6 = rastgele.Next(0, 50);
            sayi7 = rastgele.Next(0, 50);
            sayi8 = rastgele.Next(0, 50);
            sayi9 = rastgele.Next(0, 50);
            sayi10 = rastgele.Next(0, 50);
            sayi11 = rastgele.Next(0, 50);
            sayi12 = rastgele.Next(0, 50);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();
            label5.Text = sayi5.ToString();
            label6.Text = sayi6.ToString();
            label7.Text = sayi7.ToString();
            label8.Text = sayi8.ToString();
            label9.Text = sayi9.ToString();
            label10.Text = sayi10.ToString();
            label11.Text = sayi11.ToString();
            label12.Text = sayi12.ToString();

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            if(label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text && label6.Text == textBox6.Text && label7.Text == textBox7.Text && label8.Text == textBox8.Text && label9.Text == textBox9.Text && label10.Text == textBox10.Text && label11.Text == textBox11.Text && label12.Text == textBox12.Text)
            {
                MessageBox.Show("Tebrikler! Oyunu Kazandınız. Hafızanız Çok Kuvvetli :)");
            }
            else
            {
                MessageBox.Show("Maalesef Oyunu Kaybettiniz! Bir Dahaki Sefere Hafızanızı Daha Güçlü Tutun :(");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            BAŞLAT.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            label15.Text = süre.ToString();
            if(süre == 0)
            {
                timer1.Stop();
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                süre = 5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;

            timer1.Start();
            button2.Enabled = false;
        }
    }
}
