using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace enovis1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int toplam, sayı1, sayı2, sayı3,sonuc;
        
        private void button1_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            sayı3 = Convert.ToInt32(textBox3.Text);

            toplam = sayı1 + sayı2;
            sonuc = toplam * sayı3;

            textBox4.Text = sonuc.ToString();
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa an1 = new Anasayfa();
            an1.Show();
            this.Hide();

        }
    }
}
