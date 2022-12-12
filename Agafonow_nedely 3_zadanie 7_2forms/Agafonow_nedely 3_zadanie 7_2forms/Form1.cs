using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_3_zadanie_7_2forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myArr = textBox1.Text;
                string[] myStrings;
                myStrings = myArr.Split(' ');

                if (Convert.ToInt32(textBox2.Text) < 0)
                {
                    MessageBox.Show("Введите корректное число!");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    return;
                }


                int n = Convert.ToInt32(textBox2.Text);

                for (int i = 0; i < myStrings.Length; i++)
                {
                    if (myStrings[i].Length > n)
                    {

                    }
                    else
                    {
                        textBox3.Text = textBox3.Text + myStrings[i] + " ";
                    }

                }
            }
            catch
            {
                MessageBox.Show("Ошибка, введите корректный данные!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
