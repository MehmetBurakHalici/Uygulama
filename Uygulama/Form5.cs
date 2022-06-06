using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Uygulama
{
    public partial class MailUygulaması : Form
    {
        public MailUygulaması()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void MailUygulaması_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void MailUygulaması_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void MailUygulaması_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxMail.Text = "";
            textBoxAlıcı.Text = "";
            textBoxBaşlık.Text = "";
            textBoxMetin.Text = "";
            textBoxMailŞifre.Text = "";
            textBoxMail.Focus();
        }

        private void buttonGönder_Click(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "")
            {
                Uyarı1.Visible = true;
            }
            else
            {
                Uyarı1.Visible = false;
            }
            if (textBoxMailŞifre.Text == "")
            {
                Uyarı4.Visible = true;
            }
            else
            {
                Uyarı4.Visible = false;
            }
            if (textBoxAlıcı.Text == "")
            {
                Uyarı2.Visible = true;
            }
            else
            {
                Uyarı2.Visible = false;
            }
            if (textBoxBaşlık.Text == "")
            {
                Uyarı3.Visible = true;
            }
            else
            {
                Uyarı3.Visible = false;
            }
            if (textBoxMetin.Text == "")
            {
                DialogResult secim = MessageBox.Show("Boş Metin Yollamak İstediğinize Emin Misiniz?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (secim == DialogResult.Yes)
                {
                    MailMessage mesaj = new MailMessage();
                    SmtpClient istemci = new SmtpClient();
                    istemci.Credentials = new System.Net.NetworkCredential(textBoxMail.Text, textBoxMailŞifre.Text);
                    istemci.Port = 587;
                    istemci.Host = "smtp.gmail.com";
                    istemci.EnableSsl = true;
                    mesaj.To.Add(textBoxAlıcı.Text);
                    mesaj.From = new MailAddress(textBoxAlıcı.Text);
                    mesaj.Subject = textBoxBaşlık.Text;
                    mesaj.Body = textBoxMetin.Text;
                    istemci.Send(mesaj);
                    MessageBox.Show("Mesajınız Başarılı Bir Şekilde Gönderildi.", "Mail Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxMail.Text = "";
                    textBoxAlıcı.Text = "";
                    textBoxBaşlık.Text = "";
                    textBoxMetin.Text = "";
                    textBoxMailŞifre.Text = "";
                }
            }
            else
            {
                MailMessage mesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential(textBoxMail.Text, textBoxMailŞifre.Text);
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                mesaj.To.Add(textBoxAlıcı.Text);
                mesaj.From = new MailAddress(textBoxAlıcı.Text);
                mesaj.Subject = textBoxBaşlık.Text;
                mesaj.Body = textBoxMetin.Text;
                istemci.Send(mesaj);
                MessageBox.Show("Mesajınız Başarılı Bir Şekilde Gönderildi.", "Mail Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMail.Text = "";
                textBoxAlıcı.Text = "";
                textBoxBaşlık.Text = "";
                textBoxMetin.Text = "";
                textBoxMailŞifre.Text = "";
            }
        }

        private void CheckBoxŞifre_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxŞifre.Checked)
            {
                textBoxMailŞifre.PasswordChar = '\0';
            }
            else
            {
                textBoxMailŞifre.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMetin.Text = "";
            textBoxMetin.Focus();
        }

        private void Çıkış_Click(object sender, EventArgs e)
        {
            new Uygulama().Show();
            this.Hide();
        }
    }
}
