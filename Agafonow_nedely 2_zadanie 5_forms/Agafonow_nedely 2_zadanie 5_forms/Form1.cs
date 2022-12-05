using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_2_zadanie_5_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            try
            {
                //если х не попадает в область определения, то генерируется исключение 
                if (x == -1 || x == 1) throw new Exception();
                else return 1 / (x * x - 1);
            }
            catch
            {
                throw;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Convert.ToDouble(textBox1.Text);
                Convert.ToDouble(textBox2.Text);
                Convert.ToDouble(textBox3.Text);

            }
            catch {
                MessageBox.Show("Введите число, а не символы!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            
            }




            try
            {

                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double h = Convert.ToDouble(textBox3.Text);

                for (double i = a; i <= b; i += h)
                    try
                    {
                        textBox4.Text = textBox4.Text +"y("+Convert.ToString(i)+")="+Convert.ToString(Math.Round(f(i),3))+'\r'+'\n';
                    }
                    catch
                    {
                        textBox4.Text=textBox4.Text+"y("+Convert.ToString(i)+")=Не имееет значения"+'\r'+'\n';
                    }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат ввода данных");
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка");
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
