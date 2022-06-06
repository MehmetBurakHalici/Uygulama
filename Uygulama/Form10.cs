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
    public partial class KöstebekOyunu : Form
    {
        public KöstebekOyunu()
        {
            InitializeComponent();
        }

        int puan = 0;
        Random rnd = new Random();

        private void Form10_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            timer1.Stop();

            comboBox1.Text = comboBox1.Items[0].ToString();

            for (int i = 1; i < 99; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.Width = 50;
                btn.Height = 50;
                btn.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int rastgele = rnd.Next(0, 99);
            foreach (var a in flowLayoutPanel1.Controls)
            {
                Button btn = a as Button;
                if (btn.Text == rastgele.ToString())
                {
                    btn.BackColor = Color.DarkRed;
                    btn.Click += new EventHandler(btn_click);
                }
                else
                {
                    btn.BackColor = Color.White;
                }
            }
            label5.Text = (Int32.Parse(label5.Text) - 1).ToString();
            if(Int32.Parse(label5.Text) == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz Bitti!");
            }
        }

        void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.BackColor == Color.DarkRed)
            {
                puan++;
            }
            else
            {
                puan--;
            }
            label2.Text = puan.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Uygulama().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                timer1.Interval = 1000;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                timer1.Interval = 750;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                timer1.Interval = 500;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.Text = 0.ToString();
            label5.Text = 100.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = (int.Parse(label5.Text) + 20).ToString();
            button4.Enabled = false;
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
    }
}
