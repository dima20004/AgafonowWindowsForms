using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_3_zadanie_9_2forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\"+textBox1.Text+".txt"))
            { 
                sw.Write(textBox2.Text);
            }
            int k = 0;
            using (StreamReader sr = new StreamReader(@"D:\"+textBox1.Text+".txt"))
            {

                string line = sr.ReadLine();

               

                char[] chars = line.ToCharArray();

                while (line != null)
                {
                    chars = line.ToCharArray();
                    char buf = char.ToUpper(chars[0]);
                    char buf2 = char.ToUpper(chars[chars.Length - 1]);
                    if (buf == buf2) k++;
                    line = sr.ReadLine();
                };
            }
            MessageBox.Show("Количество строк, которые начинаются и заканчиваются на одну и ту же букву=" + k);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
