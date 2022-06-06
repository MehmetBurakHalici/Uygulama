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
using System.Net.Mail;

namespace Uygulama
{
    public partial class ŞifreDeğiştirme : Form
    {
        bool move;
        int mouse_x;
        int mouse_y;

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Casper\Desktop\Bilgiler.accdb");

        public ŞifreDeğiştirme()
        {
            InitializeComponent();
        }

        private void ŞifreDeğiştirme_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ŞifreDeğiştirme_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void ŞifreDeğiştirme_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Giriş().Show();
            this.Hide();
        }

        private void CheckBoxŞifre_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxŞifre.Checked)
            {
                textBoxYeniŞifre.PasswordChar = '\0';
                textBoxYeniŞifreTekrar.PasswordChar = '\0';
            }
            else
            {
                textBoxYeniŞifre.PasswordChar = '*';
                textBoxYeniŞifreTekrar.PasswordChar = '*';
            }
        }

        Random rnd = new Random();
        string onayKodu;

        private void KodAl_Click(object sender, EventArgs e)
        {
            if(textBoxMail.Text == "")
            {
                MailUyarı.Visible = true;
            }
            else
            {
                MailUyarı.Visible = false;

                onayKodu = rnd.Next(10000, 99999).ToString();

                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = ("SELECT * FROM Bilgiler");
                OleDbDataReader oku = komut.ExecuteReader();

                bool a = true, b = true;

                while (a)
                {
                    a = false;
                    while (oku.Read())
                    {
                        if (textBoxMail.Text == oku["MailAdresi"].ToString())
                        {
                            b = false;
                            MailMessage kod = new MailMessage();
                            SmtpClient istemci = new SmtpClient();
                            istemci.Credentials = new System.Net.NetworkCredential("kodgonderici00@gmail.com", "KoduGonder123");
                            istemci.Port = 587;
                            istemci.Host = "smtp.gmail.com";
                            istemci.EnableSsl = true;
                            kod.To.Add(textBoxMail.Text);
                            kod.From = new MailAddress(textBoxMail.Text);
                            kod.Subject = "Şifre Değiştirme Kodu";
                            kod.Body = "ŞİFRE DEĞİŞTİRME KODUNUZ: " + onayKodu;
                            istemci.Send(kod);
                            MessageBox.Show("Şifre Değiştirme Kodunuz Mail Adresinize Başarılı Bir Şekilde Gönderildi." +
                                "Gelen Kodu Kullanarak Yeni Şifrenizi Belirleyebilirsiniz.", "İşlem Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (b == true)
                    {
                        MessageBox.Show("Sisteme Kayıtlı Böyle Bir Mail Adresi Bulunmamakta!", "İşlem Başarısız!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxMail.Focus();
                    }
                }
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxYeniŞifre.Text == "")
            {
                YeniŞifreUyarı.Visible = true;
            }
            else
            {
                YeniŞifreUyarı.Visible = false;
            }
            if (textBoxYeniŞifreTekrar.Text == "")
            {
                YeniŞifreTekrarUyarı.Visible = true;
            }
            else
            {
                YeniŞifreTekrarUyarı.Visible = false;
            }
            if (textBoxKod.Text == "")
            {
                KodUyarı.Visible = true;
            }
            else
            {
                KodUyarı.Visible = false;

                if (textBoxKod.Text != onayKodu)
                {
                    MessageBox.Show("Şifre Değiştirme Kodunuz Hatalı! Lütfen Tekrar Deneyiniz.", "İşlem Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (textBoxYeniŞifre.Text == textBoxYeniŞifreTekrar.Text)
                    {
                        baglanti.Open();
                        OleDbCommand komut = new OleDbCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "UPDATE Bilgiler set Sifre='" + textBoxYeniŞifre.Text + "'WHERE MailAdresi = '" + textBoxMail.Text + "'";
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Şifre Değiştirme İşleminiz Başarılı Bir Şekilde Gerçekleştirildi. Yeni Şifreniz ile Giriş Yapabilirsiniz.", "Şifre Değiştirme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Şifreler Eşleşmemekte! Lütfen Tekrar Deneyiniz.", "Şifre Değiştirme İşlemi Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
