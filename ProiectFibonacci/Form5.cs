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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 copil1 = new Form12();
            copil1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 copil1 = new Form13();
            copil1.Show();
        }
    }
}
