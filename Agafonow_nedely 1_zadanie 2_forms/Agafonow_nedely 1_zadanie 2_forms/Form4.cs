using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_1_zadanie_2_forms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 1; j < 5; j++)
            {
                for (int i = 1; i < 11; i++)
                {

                    textBox1.Text=textBox1.Text+Convert.ToString(i)+ " ";


                }
                textBox1.Text = textBox1.Text + '\r'+'\n';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
