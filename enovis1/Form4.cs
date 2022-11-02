using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace enovis1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                    while (satir != null)
                    {
                     int i, j;
                    double c;

                    for (i = 0; i <= listBox1.Items.Count - 1; i++)
                        for (j = i; j <= listBox1.Items.Count - 1; j++)
                            if (Double.Parse(listBox1.Items[j].ToString()) >
                    Double.Parse(listBox1.Items[i].ToString()))
                            {

                                c = Double.Parse(listBox1.Items[i].ToString());
                                listBox1.Items[i] = listBox1.Items[j];
                                listBox1.Items[j] = c.ToString();
                            }
                        listBox1.Items.Add(satir);
                        satir = oku.ReadLine();
                    }

            }
           

        }
        
      /*  private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            double c;
           
            for (i = 0; i <= listBox1.Items.Count - 1; i++) 
                for (j = i; j <= listBox1.Items.Count - 1; j++) 
                    if (Double.Parse(listBox1.Items[j].ToString()) >
            Double.Parse(listBox1.Items[i].ToString()))
                    {
                        
                        c =Double.Parse(listBox1.Items[i].ToString());
                        listBox1.Items[i] = listBox1.Items[j];
                        listBox1.Items[j] = c.ToString();
                    }
        }
        */
        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa h = new Anasayfa();
            h.Show();
            this.Hide();
        }
    }
}