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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите X!");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите Y!");
                return;
            }


            try
            {
                Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("X должен быть числом!");
                textBox1.Text = "";
                return;
            }
            try
            {
                Convert.ToDouble(textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Y должен быть числом!");
                textBox1.Text = "";
                return;
            }

            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            if (x * x + y * y < 81 && x > 0)
                MessageBox.Show("Точка находится нутри области");
            else if (x * x + y * y > 81 || x < 0)
                MessageBox.Show("Точка находится вне области");
            else MessageBox.Show("Точка находится на границах области");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
       
        private void button3_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
