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
    public partial class HesapMakinesi : Form
    {
        bool move;
        int mouse_x;
        int mouse_y;

        private char _islem;
        private bool _ekranTemizlenecekMi;
        private int _ilkSayi;

        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void HesapMakinesi_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void HesapMakinesi_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void HesapMakinesi_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new Uygulama().Show();
            this.Hide();
        }

        private void sayı1_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi)
            {
                ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if(ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text += "1"; 
        }

        private void sayı2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text += "2";
        }

        private void sayı3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text += "3";
        }

        private void sayı4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text += "4";
        }

        private void sayı5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text += "5";
        }

        private void sayı6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text += "6";
        }

        private void sayı7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text += "7";
        }

        private void sayı8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text += "8";
        }

        private void sayı9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text += "9";
        }

        private void sayı0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text += "0";
        }

        private void Artı_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekran.Text);
        }

        private void Eşittir_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekran.Text);
            int sonuc;

            switch(_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            ekran.Text = Convert.ToString(sonuc);
        }

        private void Eksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekran.Text);
        }

        private void Çarpı_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekran.Text);
        }

        private void Bölü_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekran.Text);
        }

        private void C_Click(object sender, EventArgs e)
        {
            ekran.Text = "0";
        }
    }
}
