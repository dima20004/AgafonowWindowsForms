using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_2_zadanie_4_2_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void Rec(double n, ref double x, double d, ref double s)
        {
            if (n > 0)
            {
                s += x;
                x += d;

                Rec(n - 1, ref x, d, ref s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(textBox1.Text);
                Convert.ToDouble(textBox2.Text);
                Convert.ToDouble(textBox3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }



            double n1 = Convert.ToDouble(textBox1.Text);
            double d = Convert.ToDouble(textBox2.Text);
            bool a = true;
            double n = 0;
            while (a)
            {
                n = Convert.ToDouble(textBox3.Text);
                if (n < 1) { MessageBox.Show("n>1!");textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    return; }
                if (n >= 1) { a = false; }
            }

            double s = 0;
            Rec(n, ref n1, d, ref s);
            textBox4.Text = Convert.ToString(n1 - d);
            textBox5.Text = Convert.ToString(s);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
