using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProiectFibonacci
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int a;
        long  p,m,i,l;
        String s;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Int32.Parse(textBox1.Text);
                if (a == 1) textBox2.Text = "0";
                else if (a == 2) textBox2.Text = "0 1";
                else
                {
                    p = 0; m = 1;
                    s = s + p.ToString(); s = s + " ";
                    s = s + m.ToString(); s = s + " ";
                    for (i = 3; i <= a; i++)
                    {
                        l = p + m;
                        s = s + l.ToString(); s = s + " ";
                        p = m; m = l;
                    }
                    textBox2.Text = s;
                }
            }
            else { textBox2.Text = ""; s = ""; }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
