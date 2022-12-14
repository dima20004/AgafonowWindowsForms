using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_3_zadanie_8_1_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            string x = textBox1.Text;
            
            string words = textBox2.Text;
            Regex r = new Regex(@"\b" + words + @"\b", RegexOptions.IgnoreCase);
            //Определяет, входит ли шаблон регулярного выражения во входной текст,
            //с помощью метода Regex.IsMatch.


            if (r.IsMatch(x))   //Метод Указывает на то, обнаружино ли регулярное выражение
                                //во входной строке.
            {
                MessageBox.Show("Вы угадали, сообщение содержит слово "+words+"!");
            }
            else
            {
                MessageBox.Show("Вы не угадали, сообщение не содержит слово " + words + "!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string x = textBox1.Text;

            string words = textBox2.Text;
            Regex r = new Regex(@"\b" + words + @"\b", RegexOptions.IgnoreCase);
            //Определяет, входит ли шаблон регулярного выражения во входной текст,
            //с помощью метода Regex.IsMatch.


            if (r.IsMatch(x))   //Метод Указывает на то, обнаружино ли регулярное выражение
                                //во входной строке.
            {
                MessageBox.Show("Вы не угадали, сообщение содержит слово " + words + "!");
            }
            else
            {
                MessageBox.Show("Вы угадали, сообщение не содержит слово " + words + "!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }


   
}
