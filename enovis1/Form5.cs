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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int sayı;


        private void button1_Click(object sender, EventArgs e)
        {

            
            sayı = Convert.ToInt32(textBox1.Text);

            if (sayı == 0)
            {
                listBox1.Items.Add("0");

            }
            else if (sayı == 1)
            {
                listBox1.Items.Add("1");
            }

            else
                listBox1.Items.Add((sayı - 1) + (sayı - 2));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa dg = new Anasayfa();
            dg.Show();
            this.Hide();

        }
    }
}
