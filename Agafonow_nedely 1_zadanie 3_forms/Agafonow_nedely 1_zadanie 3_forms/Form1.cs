using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_1_zadanie_3_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double min(double a, double b)
        {
            if (a < b) return a;
            else if (b < a) return b;
            else return a;
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
                MessageBox.Show("Введено не число или не все поля заполнены, будьте внимательны!");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            textBox7.Text = Convert.ToString(min(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            try
            {
                Convert.ToDouble(textBox3.Text);
                Convert.ToDouble(textBox4.Text);
                Convert.ToDouble(textBox5.Text);
                Convert.ToDouble(textBox6.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!");
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                return;
            }
            textBox8.Text = Convert.ToString(min(min(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text)), min(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text))));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

       
    }
}
