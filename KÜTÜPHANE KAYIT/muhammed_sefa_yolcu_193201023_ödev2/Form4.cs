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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seciliDeğerler = "";
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    seciliDeğerler += checkedListBox1.CheckedItems[i].ToString() + " , ";
                }
                MessageBox.Show(seciliDeğerler);
            }
        }
    }
}
