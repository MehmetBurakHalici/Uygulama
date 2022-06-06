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
    public partial class AtYarışı : Form
    {
        bool move;
        int mouse_x;
        int mouse_y;

        public AtYarışı()
        {
            InitializeComponent();
        }

        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();

            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            int bitisuzakligi = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if(pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left)
            {
                label6.Text = "1 Numaralı At Şu Anda Yarışı Önde Götürüyor!";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left)
            {
                label6.Text = "2 Numaralı At İyi Bir Atakla Öne Geçti!";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left)
            {
                label6.Text = "3 Numaralı At Liderliği Ele Geçirdi!";
            }

            if (birinciatingenisligi + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = true;
                label6.Text = "1 Numaralı At Yarışı Kazandı.";
            }
            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = true;
                label6.Text = "2 Numaralı At Yarışı Kazandı.";
            }
            if (ucuncuatingenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = true;
                label6.Text = "3 Numaralı At Yarışı Kazandı.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;

            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;

            label6.Text = "";
            label7.Text = "0";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new Uygulama().Show();
            this.Hide();
        }

        private void AtYarışı_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void AtYarışı_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void AtYarışı_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        Random rastgele = new Random();

        private void AtYarışı_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox1.Left;
            ucuncuatsolauzaklik = pictureBox1.Left;
        }
    }
}
