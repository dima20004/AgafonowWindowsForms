using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_3_zadanie_7_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder a=new StringBuilder(textBox1.Text);

            for (int i = 0; i < a.Length - 1; i = i + 2)
            {
                if (a[i] == ' ' || a[i + 1] == ' ')
                {
                    i = i - 1;
                }
                else
                {
                    char buf = a[i];
                    buf = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = buf;
                }

            }

            textBox2.Text = Convert.ToString(a);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
