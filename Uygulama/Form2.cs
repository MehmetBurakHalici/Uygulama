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
    public partial class KayıtOl : Form
    {
        bool move;
        int mouse_x;
        int mouse_y;

        public KayıtOl()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Casper\Desktop\Bilgiler.accdb");

        private void KayıtOl_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void KayıtOl_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void KayıtOl_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Giriş().Show();
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
                textBoxŞifreTekrar.PasswordChar = '\0';
            }
            else
            {
                textBoxŞifre.PasswordChar = '*';
                textBoxŞifreTekrar.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxKullanıcıAdı.Text = "";
            textBoxMailAdresi.Text = "";
            textBoxŞifre.Text = "";
            textBoxŞifreTekrar.Text = "";
            textBoxKullanıcıAdı.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxKullanıcıAdı.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
            if(textBoxMailAdresi.Text == "")
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }
            if (!Sözleşme.Checked)
            {
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;
            }
            if (textBoxŞifre.Text == "")
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
            if (textBoxŞifreTekrar.Text == "")
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;

                if(textBoxŞifre.Text == textBoxŞifreTekrar.Text)
                {
                    verileriKaydet();

                    textBoxKullanıcıAdı.Text = "";
                    textBoxMailAdresi.Text = "";
                    textBoxŞifre.Text = "";
                    textBoxŞifreTekrar.Text = "";

                    MessageBox.Show("Hesabınız Başarılı Bir Şekilde Oluşturuldu.", "Kayıt Başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Şifreler Eşleşmemektedir. Lütfe Tekrar Deneyiniz!", "Kayıt Başarısız!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxŞifre.Focus();
                }
            }
        }

        private void verileriKaydet()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO Bilgiler (KullaniciAdi,MailAdresi,Sifre) VALUES" +
                "('"+ textBoxKullanıcıAdı.Text.ToString() +"','"+ textBoxMailAdresi.Text.ToString() +"'," +
                "'"+ textBoxŞifre.Text.ToString() +"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kvkk.gov.tr/yayinlar/K%C4%B0%C5%9E%C4%B0SEL%20VER%C4%B0LER%C4%B0N%20KORUNMASI%20KANUNU%20VE%20UYGULAMASI.pdf");
        }
    }
}
