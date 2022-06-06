using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Uygulama
{
    public partial class Giriş : Form
    {
        bool move;
        int mouse_x;
        int mouse_y;

        public Giriş()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Casper\Desktop\Bilgiler.mdb");

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new KayıtOl().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBoxŞifre_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxŞifre.Checked)
            {
                textBoxŞifre.PasswordChar = '\0';
            }
            else
            {
                textBoxŞifre.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxKullanıcıAdı.Text = "";
            textBoxŞifre.Text = "";
            textBoxKullanıcıAdı.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxKullanıcıAdı.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
            if(textBoxŞifre.Text == "")
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;

                if(textBoxKullanıcıAdı.Text != "" && textBoxŞifre.Text != "")
                {
                    girisYap();

                    textBoxKullanıcıAdı.Text = "";
                    textBoxŞifre.Text = "";
                    textBoxKullanıcıAdı.Focus();
                }
            }
        }

        private void girisYap()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("SELECT * FROM Bilgiler");
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (textBoxKullanıcıAdı.Text == oku["KullaniciAdi"].ToString()
                    && textBoxŞifre.Text == oku["Sifre"].ToString() || textBoxKullanıcıAdı.Text == oku["MailAdresi"].ToString()
                    && textBoxŞifre.Text == oku["Sifre"].ToString())
                {
                    label8.Visible = false;
                    label9.Visible = false;

                    MessageBox.Show("Giriş Başarılı Bir Şekilde Gerçekleştirildi.", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Uygulama().Show();
                    this.Hide();
                }
                else
                {
                    label8.Visible = true;
                    label9.Visible = true;
                }
            }
            baglanti.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new ŞifreDeğiştirme().Show();
            this.Hide();
        }
    }
}
