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
    public partial class ZarOyunu : Form
    {
        public ZarOyunu()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();

        int toplamBirinciOyuncu = 0;
        int toplamİkinciOyuncu = 0;

        private void GirişYap_Click(object sender, EventArgs e)
        {
            Başla1.Enabled = false;
            Başla2.Enabled = true;

            int birinciZar = rastgele.Next(1, 7);
            int ikinciZar = rastgele.Next(1, 7);

            toplamBirinciOyuncu = toplamBirinciOyuncu + birinciZar + ikinciZar;
            label11.Text = toplamBirinciOyuncu.ToString();
            label16.Text = toplamBirinciOyuncu.ToString();

            if(birinciZar == 1)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar1.jpg";
            }
            if (birinciZar == 2)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar2.jpg";
            }
            if (birinciZar == 3)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar3.jpg";
            }
            if (birinciZar == 4)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar4.jpg";
            }
            if (birinciZar == 5)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar5.jpg";
            }
            if (birinciZar == 6)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar6.jpg";
            }

            if (ikinciZar == 1)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar1.jpg";
            }
            if (ikinciZar == 2)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar2.jpg";
            }
            if (ikinciZar == 3)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar3.jpg";
            }
            if (ikinciZar == 4)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar4.jpg";
            }
            if (ikinciZar == 5)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar5.jpg";
            }
            if (ikinciZar == 6)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar6.jpg";
            }

            label3.Text = birinciZar.ToString();
            label4.Text = ikinciZar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Başla1.Enabled = true;
            Başla2.Enabled = false;

            int birinciZar2 = rastgele.Next(1, 7);
            int ikinciZar2 = rastgele.Next(1, 7);

            toplamİkinciOyuncu = toplamİkinciOyuncu + birinciZar2 + ikinciZar2;
            label12.Text = toplamİkinciOyuncu.ToString();
            label15.Text = toplamİkinciOyuncu.ToString();

            if (birinciZar2 == 1)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar1.jpg";
            }
            if (birinciZar2 == 2)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar2.jpg";
            }
            if (birinciZar2 == 3)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar3.jpg";
            }
            if (birinciZar2 == 4)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar4.jpg";
            }
            if (birinciZar2 == 5)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar5.jpg";
            }
            if (birinciZar2 == 6)
            {
                Zar1.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar6.jpg";
            }

            if (ikinciZar2 == 1)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar1.jpg";
            }
            if (ikinciZar2 == 2)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar2.jpg";
            }
            if (ikinciZar2 == 3)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar3.jpg";
            }
            if (ikinciZar2 == 4)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar4.jpg";
            }
            if (ikinciZar2 == 5)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar5.jpg";
            }
            if (ikinciZar2 == 6)
            {
                Zar2.ImageLocation = @"D:\Lessons\Gazi University - Faculty of Technology - Computer Engineering\2nd Class\2nd Semester (Spring Semester)\Visual Programming\14.Hafta\Uygulama\Uygulama\Resimler\Zar6.jpg";
            }

            label8.Text = birinciZar2.ToString();
            label7.Text = ikinciZar2.ToString();

            if(toplamBirinciOyuncu > 100 && toplamBirinciOyuncu > toplamİkinciOyuncu)
            {
                MessageBox.Show("OYUN BİTTİ!", "YARIŞMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kazanan.Text = "BİRİNCİ OYUNCU";
                button1.Enabled = true;
                Başla1.Enabled = false;
                Başla2.Enabled = false;
            }
            if (toplamİkinciOyuncu > 100 && toplamİkinciOyuncu > toplamBirinciOyuncu)
            {
                MessageBox.Show("OYUN BİTTİ!", "YARIŞMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kazanan.Text = "İKİNCİ OYUNCU";
                button1.Enabled = true;
                Başla1.Enabled = false;
                Başla2.Enabled = false;
            }
        }

        private void ZarOyunu_Load(object sender, EventArgs e)
        {
            Başla1.Enabled = true;
            Başla2.Enabled = false;
            button1.Enabled = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            new Uygulama().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Başla1.Enabled = true;
            Başla2.Enabled = false;
            button1.Enabled = false;

            label3.Text = "0";
            label4.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            Kazanan.Text = "";

            toplamBirinciOyuncu = 0;
            toplamİkinciOyuncu = 0;
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void ZarOyunu_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ZarOyunu_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void ZarOyunu_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
    }
}
