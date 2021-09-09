using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhammed_sefa_yolcu_193201023_ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 kaydol = new Form2();
            kaydol.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 giris_yap = new Form3();
            giris_yap.ShowDialog();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TrackBar1.Minimum = 0;
            TrackBar1.Maximum = 255;
            TrackBar2.Minimum = 0;
            TrackBar2.Maximum = 255;
            TrackBar3.Minimum = 0;
            TrackBar3.Maximum = 255;
            TrackBar1.TickStyle = TickStyle.BottomRight;
            TrackBar2.TickStyle = TickStyle.TopLeft;
            TrackBar3.TickStyle = TickStyle.Both;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value);
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value);
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İSTEKLERİNİZ BAŞARIYLA ULAŞMIŞTIR.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {

                string saat = DateTime.Now.ToLongTimeString();

                label5.Text = saat;

            }
        }
    }
    
}
