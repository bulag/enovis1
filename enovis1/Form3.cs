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
    public partial class Form3 : Form
    {
       
        
        public Form3()
        {
            InitializeComponent();
          
        }

        int sayi;
        int j,i;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            if (sayi > 0 && sayi <= 15)
            {
                
                           for ( i = 1; i <= sayi; i++)
                            {


                                for (j = 1; j <= sayi; j++)
                                {
                                        int pro = i * j;
                                        richTextBox1.AppendText(string.Format("{0}\t", pro));

                                    }
                                  
                                    richTextBox1.AppendText("\n");
                                }     
                    }
            
            else
            {
                MessageBox.Show("Lütfen aralıkta bir sayı giriniz!");

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1 ile 15 arasında sayı giriniz...";
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa sayf = new Anasayfa();
            sayf.Show();
            this.Hide();
        }

      
    }
}
