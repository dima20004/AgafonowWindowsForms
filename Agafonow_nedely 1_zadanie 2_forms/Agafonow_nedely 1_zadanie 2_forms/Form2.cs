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

namespace Agafonow_nedely_1_zadanie_2_forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите порядковый номер!");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректный порядковый номер!");
                textBox1.Text = "";
                return;
            }

            int n = Convert.ToInt32(textBox1.Text);
            if (n < 0 || n > 12)
            {
                MessageBox.Show("Номер месяца от 0 до 12!");
                textBox1.Text = "";
            }


            switch (n)
            {
                case 0: MessageBox.Show("Осталось 12 месяцев до конца года"); break;
                case 1: MessageBox.Show("Осталось 11 месяцев до конца года"); break;
                case 2: MessageBox.Show("Осталось 10 месяцев до конца года"); break;
                case 3: MessageBox.Show("Осталось 9 месяцев до конца года"); break;
                case 4: MessageBox.Show("Осталось 8 месяцев до конца года"); break;
                case 5: MessageBox.Show("Осталось 7 месяцев до конца года"); break;
                case 6: MessageBox.Show("Осталось 6 месяцев до конца года"); break;
                case 7: MessageBox.Show("Осталось 5 месяцев до конца года"); break;
                case 8: MessageBox.Show("Осталось 4 месяцев до конца года"); break;
                case 9: MessageBox.Show("Осталось 3 месяцев до конца года"); break;
                case 10: MessageBox.Show("Осталось 2 месяцев до конца года"); break;
                case 11: MessageBox.Show("Осталось 1 месяцев до конца года"); break;
                case 12: MessageBox.Show("Осталось 0 месяцев до конца года"); break;
                default: MessageBox.Show("ВЫ ОШИБЛИСЬ"); break;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
