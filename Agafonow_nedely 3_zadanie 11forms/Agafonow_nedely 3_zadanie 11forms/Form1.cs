using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_3_zadanie_11forms
{
    public partial class Form1 : Form
    {

        //Класс Point
        class Point
        {
            public int x;
            public int y;

            //Конструктор при нулевых параметрах
            public Point()
            {
                x = 0;
                y = 0;

            }
            //Конструктор при заданных параметрах
            public Point(int X, int Y)
            {
                x = X;
                y = Y;

            }

            //Метод вывода координат точек
            public void schowPoints()
            {
                Console.WriteLine($"x={x}, y={y}");
            }

            //Метод вывода расстояния от начала координат до точки 
            public double showCalculate()
            {
                double s;
                s = Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0));
                return s;
            }

            //Метод вычесления и вывода координат точки после перемещения на вектор a,b
            public void Moving(int a, int b)
            {
                x = x + a;
                y = y + b;
                Console.WriteLine($"Координаты точки после перемещения на вектор (a,b) x={x}, y={y}");
            }
            //Свойства для записи и вывода координат точки
            public int X
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }

            }
            public int Y
            {
                get
                {
                    return y;
                }
                set
                {
                    y = value;
                }

            }
            //Свойство позволяющее вывести умножить координаты точки на скаляр
            public int SkalarX
            {
                set
                {
                    x = x * value;
                }
            }

            public int SkalarY
            {
                set
                {
                    y = y * value;
                }
            }


        }



        public Form1()
        {
            InitializeComponent();
        }
        
        
private void button1_Click(object sender, EventArgs e)
        {
            try {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректные x и y");
                textBox1.Text = "";
                textBox2.Text = "";
                return;

            }
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);

            Point points = new Point(x,y);
            textBox9.Text = Convert.ToString(points.X);
            textBox8.Text = Convert.ToString(points.Y);

            Point zeroPoints = new Point();
            textBox6.Text = Convert.ToString(zeroPoints.X);
            textBox7.Text = Convert.ToString(zeroPoints.Y);


            textBox11.Text = Convert.ToString(points.showCalculate());
           
            textBox10.Text = Convert.ToString(zeroPoints.showCalculate());

            try
            {
                Convert.ToInt32(textBox3.Text);
                Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректные a и b");
                textBox3.Text = "";
                textBox4.Text = "";
                return;

            }
            int a= Convert.ToInt32(textBox3.Text);
            int b= Convert.ToInt32(textBox4.Text);

            points.Moving(a, b);
            textBox15.Text = Convert.ToString(points.X);
            textBox14.Text = Convert.ToString(points.Y);

            zeroPoints.Moving(a, b);
            textBox13.Text = Convert.ToString(zeroPoints.X);
            textBox12.Text = Convert.ToString(zeroPoints.Y);

            try
            {
                Convert.ToInt32(textBox17.Text);
                Convert.ToInt32(textBox16.Text);
                Convert.ToInt32(textBox19.Text);
                Convert.ToInt32(textBox18.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка в свойствах!");
                textBox17.Text = "";
                textBox16.Text = "";
                textBox19.Text = "";
                textBox18.Text = "";
                return;

            }
            points.X = Convert.ToInt32(textBox17.Text);
            points.Y = Convert.ToInt32(textBox16.Text);

            zeroPoints.X = Convert.ToInt32(textBox19.Text);
            zeroPoints.Y = Convert.ToInt32(textBox18.Text);


            textBox23.Text = Convert.ToString(points.X);
            textBox22.Text = Convert.ToString(points.Y);
            textBox21.Text = Convert.ToString(zeroPoints.X);
            textBox20.Text = Convert.ToString(zeroPoints.Y);

            try
            {
                Convert.ToInt32(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректный скаляр");
                textBox5.Text = "";
                return;

            }

            int SCA = Convert.ToInt32(textBox5.Text);

            points.SkalarX = SCA;
            points.SkalarY = SCA;

            zeroPoints.SkalarX = SCA;
            zeroPoints.SkalarY = SCA;


            textBox27.Text = Convert.ToString(points.X);
            textBox26.Text = Convert.ToString(points.Y);
            textBox25.Text = Convert.ToString(zeroPoints.X);
            textBox24.Text = Convert.ToString(zeroPoints.Y);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = null;

        }
    }
}
