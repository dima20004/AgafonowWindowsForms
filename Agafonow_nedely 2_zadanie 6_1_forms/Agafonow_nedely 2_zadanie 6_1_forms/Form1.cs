using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agafonow_nedely_2_zadanie_6_1_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button3.Enabled = false;
        }
        int[] arr;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox3.Text;
                string[] strings = s.Split(' ');
                arr = new int[strings.Length];
                for (int i = 0; i < strings.Length; i++)
                {
                    arr[i] = Convert.ToInt32(strings[i]);
                }
                richTextBox1.Clear();
                for (int i = 0; i < arr.Length; i++)
                {
                    richTextBox1.AppendText($"{arr[i]}\n");
                }
                button3.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < 1)
            {
                MessageBox.Show("Введите корректный размер массива!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                try
                {
                    int lenth = Convert.ToInt32(textBox1.Text);
                    Random r = new Random();
                    arr = new int[lenth];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = r.Next(-10, 10);
                    }
                    richTextBox1.Clear();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        richTextBox1.AppendText($"{arr[i]}\n");
                    }
                    button3.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("АШИПКА");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(textBox2.Text);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < k)
                    {
                        arr[i] = k;
                    }
                }
                richTextBox1.Clear();
                for (int i = 0; i < arr.Length; i++)
                {
                    richTextBox1.AppendText($"{arr[i]}\n");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            textBox2.Text = "";

            textBox3.Text = "";

            richTextBox1.Text = "";

           
        }
    }
}