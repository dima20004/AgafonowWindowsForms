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

namespace Aгафонов_неделя_1_задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!");
                textBox1.Text = "";
                return;
            }

            double p = Convert.ToDouble(textBox1.Text);
            double s = (Math.Pow(p / 3, 2) * Math.Sqrt(3)) / 4;
            string a = Convert.ToString(s);
            textBox2.Text = a;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
