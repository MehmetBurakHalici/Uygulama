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
    public partial class MüzikÇalar : Form
    {
        public MüzikÇalar()
        {
            InitializeComponent();

            URL.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            for(int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
            {
                Müzikler.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                URL.Items.Add(openFileDialog1.FileNames[i].ToString());
            }
        }

        private void Müzikler_SelectedIndexChanged(object sender, EventArgs e)
        {
            URL.SelectedIndex = Müzikler.SelectedIndex;
            axWindowsMediaPlayer1.URL = URL.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 5;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Müzikler.Items.Clear();
            URL.Items.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Uygulama().Show();
            this.Hide();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void MüzikÇalar_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void MüzikÇalar_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void MüzikÇalar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
    }
}
