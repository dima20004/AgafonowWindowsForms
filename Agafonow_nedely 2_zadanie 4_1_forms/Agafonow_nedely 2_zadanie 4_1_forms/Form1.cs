using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_2_zadanie_4_1_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int recurs(int n)
        {
            int b1 = -10;
            int b2 = 2;
            if (n <= 0)
                return 0;
            if (n == 1)
                return b1;
            if (n == 2)
                return b2;
            return Math.Abs(recurs(n - 2)) - 6 * recurs(n - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Введите целое число!");
                textBox1.Text = "";
                textBox2.Text = "";
                return;

            }


            int n= Convert.ToInt32(textBox1.Text);

            bool a = true;
            while (a) {

                if (n < 1) { MessageBox.Show("n>0!"); textBox1.Text = ""; return; }
                else a = false;
            }
            textBox2.Text=Convert.ToString(recurs(n));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
