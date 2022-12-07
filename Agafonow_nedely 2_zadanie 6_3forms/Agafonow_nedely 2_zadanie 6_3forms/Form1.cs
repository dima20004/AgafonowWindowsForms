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

namespace Agafonow_nedely_2_zadanie_6_3forms
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
                button2.Enabled = true;
                dataGridView1.Visible = true;
                int m = Convert.ToInt32(textBox1.Text);
                int[,] arr;
                arr = new int[m, m];
                dataGridView1.RowCount = m;
                dataGridView1.ColumnCount = m;
                if (m < 2) { MessageBox.Show("Введите число больше 3!");
                    textBox1.Text = "";
                    dataGridView1.RowCount = 0;
                    dataGridView1.ColumnCount = 0;
                    return;

                }

            }
            catch
            {
                MessageBox.Show("Ошибка!");
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try { 
                 int m = Convert.ToInt32(textBox1.Text);
                int[,] arr;
                arr = new int[m, m];
               
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                    }
                }
                int s=0;
                int g = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (arr[i, j]%2==0) {
                            s = s + arr[i, j];
                            g++;
                        
                        }
                    }
                }
                s = s / g;
                textBox2.Text = Convert.ToString(s);

             for (int i = 0; i < m; i++)
               {
                 for (int j = 0; j < m; j++)
                    {
                        richTextBox1.AppendText($"{arr[i, j]} ");
                    }
                   richTextBox1.AppendText("\n");
                }

            }
            catch
            {
                int m = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Введите число!");
                dataGridView1.RowCount = 0;
                dataGridView1.ColumnCount = 0;
                dataGridView1.RowCount = m;
                dataGridView1.ColumnCount = m;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.RowCount = 0;
            dataGridView1.ColumnCount = 0;
            textBox2.Text = "";
            richTextBox1.Text = "";
        }
    }
}
