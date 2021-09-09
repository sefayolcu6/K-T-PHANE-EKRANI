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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox2.Text;
            string sıfre = textBox3.Text;
            if (ad == "sefa yolcu" && sıfre == "123")

            {
                MessageBox.Show("Hoşgeldiniz " + ad);
                Form4 islemekranı = new Form4();
                islemekranı.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı İşlem Yaptınız!!!!");

            }




        }
    }
}
