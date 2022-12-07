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

namespace Agafonow_nedely_2_zadanie_6_1_2_forms
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
            if (Convert.ToInt32(textBox2.Text) < 1 || Convert.ToInt32(textBox3.Text) < 0)
            {
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Введите корректные n и m!");
                return;
            }
            try
            {
               
                button2.Enabled = true;
                dataGridView1.Visible = true;
                int m = Convert.ToInt32(textBox2.Text);
                int n = Convert.ToInt32(textBox3.Text);
                int[,] arr;
                arr = new int[m, n];
                dataGridView1.RowCount = m;
                dataGridView1.ColumnCount = n;

            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Convert.ToInt32(textBox2.Text);
                int n = Convert.ToInt32(textBox3.Text);
                int r = Convert.ToInt32(textBox1.Text);
                int[,] arr;
                arr = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        richTextBox1.AppendText($"{arr[i, j]} ");
                    }
                    richTextBox1.AppendText("\n");
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[i, j] < r)
                        {
                            arr[i, j] = r;
                        }
                    }
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        richTextBox2.AppendText($"{arr[i, j]} ");
                    }
                    richTextBox2.AppendText("\n");
                }
                richTextBox2.AppendText("\n");
            }
            catch
            {
                MessageBox.Show("оШИБКА!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dataGridView1.RowCount = 0;
            dataGridView1.ColumnCount = 0;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button2.Enabled = false;
            dataGridView1.Visible = false;
        }
    }
}
