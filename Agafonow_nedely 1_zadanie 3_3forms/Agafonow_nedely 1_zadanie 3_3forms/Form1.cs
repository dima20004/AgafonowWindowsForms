using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agafonow_nedely_1_zadanie_3_3forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    

    static void f(double x, double y)
    {

        string str = "X=" + Convert.ToString(x) +"  "+ "Y=" + Convert.ToString(y) + " ";
        MessageBox.Show(str);
    }
    static double f(double x)
    {
        MessageBox.Show("X=" + Convert.ToString(x));
        return x;
    }

    static void f(double x, out double y)
    {
        y = 0;
        x = 0;  
       
        
        string str = "Обнулили X=" + Convert.ToString(x) +" "+ "Y=" + Convert.ToString(y) + " ";
        MessageBox.Show(str);

    }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
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
                    return;
                }
            }
            if (textBox1.Text != "")
            {
                try
                {
                    Convert.ToDouble(textBox1.Text);
                   


                }
                catch (FormatException)
                {
                    MessageBox.Show("Введено не число!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    return;
                }
            }


            if (textBox1.Text == "" && textBox2.Text == "") { MessageBox.Show("Введите данные!");
                textBox1.Text ="";
                textBox2.Text ="";
                return;
            }
            if(textBox2.Text!=""&&textBox1.Text=="") { MessageBox.Show("Введите Все данные!");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }


            if (textBox2.Text == "")
            {
                double a = Convert.ToDouble(textBox1.Text);
                f(a); return;
            }
            else if (checkBox1.Checked == true)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);

                f(a, out b); return;
            }
            else
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);

                f(a, b); return;
            }




        }

     
       

    private void button2_Click(object sender, EventArgs e)
    {
        textBox1.Text = "";
        textBox2.Text = "";
        checkBox1.Checked=false;
    }


    }
}
