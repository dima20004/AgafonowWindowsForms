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

namespace Агафонов_неделя_1_задание_1_2_форм
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не целое число!");
                textBox1.Text = "";
                return;
            }

            double p = Convert.ToDouble(textBox1.Text);
            p = p % 2;
            if (p == 0) MessageBox.Show("Число четное!");
            if (p != 0) MessageBox.Show("Число нечетное!");
           

        }
    }
}
