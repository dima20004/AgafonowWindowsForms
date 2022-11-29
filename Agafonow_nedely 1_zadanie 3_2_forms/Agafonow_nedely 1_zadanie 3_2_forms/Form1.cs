using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agafonow_nedely_1_zadanie_3_2_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            double y;
            if (Math.Abs(x) < Math.PI / 2) y = Math.Sin(x);
            else if (Math.Abs(x) > Math.PI) y = 0;
            else y = Math.Cos(x);
            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(textBox1.Text);
                Convert.ToDouble(textBox2.Text);
              

            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }

            if (textBox1.Text==""||textBox1.Text==" ") { MessageBox.Show("Вы не ввели A!"); return; }
            if (textBox2.Text == "" || textBox2.Text == " ") { MessageBox.Show("Вы не ввели A!");return; }
            if (textBox3.Text == "" || textBox3.Text == " ") { MessageBox.Show("Вы не ввели A!");return; }
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double h = Convert.ToDouble(textBox3.Text);
            int j = 0;
            int g = 1;
            for (double i = a; i < b; i = i + h)
            {
                j++;
                i = Math.Round(i, 3);
                double x = Math.Round(f(i), 3);
                textBox4.Text = textBox4.Text +"f("+i+")="+Convert.ToString(x)+"    ";
                if (j == 3 * g) { textBox4.Text = textBox4.Text + '\r' + '\n'; g++;}
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
