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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ok1 = 0, ok5 = 0, ok2 = 0, ok3 = 0, ok4 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
             Form2 copil1 = new Form2();

                copil1.Show();
                ok1++;
                button1.BackColor = Color.White;
            button2.Enabled = true;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.toolStripStatusLabel1.Text = dt.ToShortDateString();
            this.toolStripStatusLabel2.Text = dt.ToShortTimeString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form3 copil2 = new Form3();

                copil2.Show();
                ok2++;
                button2.BackColor = Color.White;
            button3.Enabled = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ok1 = 0; ok2 = 0; ok3 = 0; ok4 = 0; ok5 = 0;
            button1.BackColor = Color.LightSlateGray; button1.Enabled = true;
            button2.BackColor = Color.LightSlateGray; button2.Enabled = true;
            button3.BackColor = Color.LightSlateGray; button3.Enabled = true;
            button4.BackColor = Color.LightSlateGray; button4.Enabled = true;
            button5.BackColor = Color.LightSlateGray; button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 copil1=new Form4();
            copil1.Show();
            ok3++;
            button3.BackColor = Color.White;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 copil1 = new Form5();
            copil1.Show();
            ok4++;
            button4.BackColor = Color.White;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 copil1 = new Form10();
            copil1.Show();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button5.BackColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 copil1 = new Form14();
            copil1.Show();
        }

      
  
    }
}
