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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        int k=0;
        private void button1_Click(object sender, EventArgs e)
        {
            while (k < 200)
            {
                
                k++;
                if (k <= 100)
                {
                    if ( k % 15 == 0 ) { listBox1.Items.Add("zigzag"); }
                    else { 
                    if ( k % 3 == 0 )
                    {
                        listBox1.Items.Add("zig");
                    }
                    else if ( k % 5 == 0 )
                    {
                        listBox1.Items.Add("zag");
                    }
                    else { listBox1.Items.Add(k.ToString()); }
                }   
                }
                else if (k > 100)
                {
                    if (k % 15 == 0) { listBox1.Items.Add("zagzig"); }
                    else
                    {
                        if (k % 3 == 0)
                        {
                            listBox1.Items.Add("zig");
                        }
                        else if (k % 5 == 0)
                        {
                            listBox1.Items.Add("zag");
                        }
                        else { listBox1.Items.Add(k.ToString()); }
                    }   

                }                    
          }
            

       }
        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa an = new Anasayfa();
            an.Show();
            this.Hide();
        }
   }
}
