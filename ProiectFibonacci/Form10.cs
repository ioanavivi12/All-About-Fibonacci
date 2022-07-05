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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        int ok,rez;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acest test conține 5 întrebări tip grilă din informațiile prezentate anterior. Fiecare întrebare valoreaza 2 puncte. Doar UN raspuns este corect!","Reguli", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            label1.Visible = true;
            checkBox1.Visible = true; checkBox2.Visible = true; checkBox3.Visible = true; checkBox4.Visible = true;
            button1.Enabled = false; button2.Enabled = true; button3.Enabled = false; button4.Enabled = true;
            pictureBox1.Image = Image.FromFile(@"intrebare1.jpg");
            label1.Text = "Unde s-a născut Fibonacci?";
            checkBox1.Text = "Paris";
            checkBox2.Text = "Londra";
            checkBox3.Text = "București";
            checkBox4.Text = "Pisa";
            ok = 1;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        int nr = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            nr = 0;
            if (checkBox1.Checked == true) nr++;
            if (checkBox2.Checked == true) nr++;
            if (checkBox3.Checked == true) nr++;
            if (checkBox4.Checked == true) nr++;
            if (nr >= 2) { MessageBox.Show("Ai ales prea multe variante!", "Atenție!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation); checkBox1.Checked=false ; checkBox2.Checked=false;; checkBox3.Checked=false; checkBox4.Checked = false; }
            else if (nr == 0) MessageBox.Show("Nu ai ales nicio variantă!", "Atenție!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            else
            {
                if (ok == 1)
                {
                    if (checkBox4.Checked == true) { pictureBox1.Image = Image.FromFile(@"corect.jpg"); rez += 2; button2.Enabled = true; }
                    else pictureBox1.Image = Image.FromFile(@"gresit.png");
                    button2.Enabled = true; 
                }
                else
                    if (ok == 2)
                    {
                        if (checkBox2.Checked == true) { pictureBox1.Image = Image.FromFile(@"corect.jpg"); rez += 2; button2.Enabled = true; }
                        else pictureBox1.Image = Image.FromFile(@"gresit.png");
                        button2.Enabled = true; 

                    }
                    else
                        if (ok == 3)
                        {

                            if (checkBox3.Checked == true) { pictureBox1.Image = Image.FromFile(@"corect.jpg"); rez += 2; }
                            else pictureBox1.Image = Image.FromFile(@"gresit.png");
                            button2.Enabled = true; 
                        }
                    else
                        if (ok == 4)
                            {
                                if (checkBox4.Checked == true) { pictureBox1.Image = Image.FromFile(@"corect.jpg"); rez += 2; button2.Enabled = true; }
                                else pictureBox1.Image = Image.FromFile(@"gresit.png");
                                button2.Enabled = true; 
                            }
                    else
                        if(ok==5)
                            {
                                if (checkBox3.Checked == true) { pictureBox1.Image = Image.FromFile(@"corect.jpg"); rez += 2; button2.Enabled = true; }
                                else pictureBox1.Image = Image.FromFile(@"gresit.png");
                                button4.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true; 
                            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ok++;
            checkBox1.Checked=false ; checkBox2.Checked=false;; checkBox3.Checked=false; checkBox4.Checked = false; 
            if (ok == 2) {
                pictureBox1.Image = Image.FromFile(@"intrebare1.jpg");
                label1.Text = "Care sunt primii 5 termeni ai șirului lui Fibonacci?";
                checkBox1.Text = "1 2 3 4 5"; 
                checkBox2.Text = "0 1 1 2 3";
                checkBox3.Text = "2 4 6 8 10";
                checkBox4.Text = "1 3 5 7 9";
            } else
            if (ok == 3){
                pictureBox1.Image = Image.FromFile(@"intrebare1.jpg");
                label1.Text = "Cu cât este egal numărul de aur?";
                checkBox1.Text = "3.14";
                checkBox2.Text = "25";
                checkBox3.Text = "1.61";
                checkBox4.Text = "7";
            } else
            if (ok == 4){
                pictureBox1.Image = Image.FromFile(@"intrebare1.jpg");
                label1.Text = "Calculați care este al 10-lea termen al șirului lui Fibonacci.";
                checkBox1.Text = "10";
                checkBox2.Text = "20";
                checkBox3.Text = "55";
                checkBox4.Text = "34";
            } else
            if (ok == 5){
                pictureBox1.Image = Image.FromFile(@"intrebare1.jpg");
                label1.Text = "Șirul lui Fibonacci și raportul de aur au o legâturâ deoarece:";
                checkBox1.Text = "primul termen al șirului este egal cu acesta";
                checkBox2.Text = "diferența dintre oricare 2 termeni alăturați este egală cu acesta";
                checkBox3.Text = "raportul dintre 2 termeni aflați pe poziții consecutive se apropie de acesta";
                checkBox4.Text = "produsul tuturor termenilor din șir este egal cu acesta";  
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitări! Ai obținut nota " + rez + "!", "Ai terminat testul", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            this.Close();
        }

    }
}
