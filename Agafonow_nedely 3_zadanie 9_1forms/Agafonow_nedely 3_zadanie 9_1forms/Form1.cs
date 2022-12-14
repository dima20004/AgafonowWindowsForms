using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_3_zadanie_9_1forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void create()
        {
            try
            {
                int s = 0;
                bool a = true;
                while (a)
                {
                    s = Convert.ToInt32(textBox2.Text);
                    if (s < 0)
                    {
                        MessageBox.Show("Введите корректную степень 3!");
                        textBox2.Text = "";
                        return;
                    }
                    else a = false;
                }
                if (s != 0)
                {
                    using (StreamWriter sw = new StreamWriter(@"D:\" + textBox1.Text + ".bin"))
                    {
                        for (double i = 0; i <= s; i++)
                        {
                            sw.WriteLine(Math.Pow(3, i) + " ");
                        }
                    }
                    MessageBox.Show("Файл успешно создан!");
                }
                else
                {
                    MessageBox.Show("Введите корректную степень 3!");
                    textBox2.Text = "";
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            create();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"D:\"+textBox1.Text+".bin"))
            {
                while (!sr.EndOfStream)
                {
                    string str;

                    str = sr.ReadLine();
                    sr.ReadLine();
                    textBox3.Text = textBox3.Text + str + " ";
                }
                MessageBox.Show("Файл успешно считан!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }

}
