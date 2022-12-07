using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_2_zadanie_6_4forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < 1 || Convert.ToInt32(textBox2.Text) < 1)
            {
                MessageBox.Show("Введите корректные размеры массива!");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            else
            {
                try
                {
                    button2.Enabled = true;
                    dataGridView1.Visible = true;
                    int m = Convert.ToInt32(textBox1.Text);
                    int n = Convert.ToInt32(textBox2.Text);

                    if (m < 1 || n < 1)
                    {
                        MessageBox.Show("Введите числa больше 0!");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        dataGridView1.RowCount = 0;
                        dataGridView1.ColumnCount = 0;
                        button2.Enabled = false;
                        dataGridView1.Visible = false;
                        return;

                    }
                    dataGridView1.RowCount = m;
                    dataGridView1.ColumnCount = n;

                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                    textBox1.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Convert.ToInt32(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);
                int[,] arr;
                arr = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                    }
                }

               
                for (int j = 0; j < n; j++)
                {
                    int min =arr[0, j];
                    for (int i = 0; i < m; i++)
                    {
                        if (min > arr[i, j])
                        {
                            min = arr[i,j ];
                        }
                        
                    }
                    richTextBox2.AppendText($"{min} ");
                }
               

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        richTextBox1.AppendText($"{arr[i, j]} ");
                    }
                    richTextBox1.AppendText("\n");
                }

            }
            catch
            {
                int m = Convert.ToInt32(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);
                MessageBox.Show("Введите число!");
                dataGridView1.RowCount = 0;
                dataGridView1.ColumnCount = 0;
                dataGridView1.RowCount = m;
                dataGridView1.ColumnCount = n;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.RowCount = 0;
            dataGridView1.ColumnCount = 0;
            textBox2.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

       
    }
}
