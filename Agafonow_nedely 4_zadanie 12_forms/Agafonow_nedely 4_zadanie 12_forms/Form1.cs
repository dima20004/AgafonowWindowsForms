using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agafonow_nedely_4_zadanie_12_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Point
        {
            public int x;
            public int y;

            public Point()
            {
                x = 0;
                y = 0;

            }

            public Point(int X, int Y)
            {
                x = X;
                y = Y;

            }


            public void schowPoints()
            {
                MessageBox.Show($"x={x}, y={y}");
            }

            public void showCalculate()
            {
                double s;
                s = Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0));
                MessageBox.Show($"Расстояние от начала координат до точки={s}");
            }

            public void Moving(int a, int b)
            {
                x = x + a;
                y = y + b;
                MessageBox.Show($"Координаты точки после перемещения на вектор (a,b) x={x}, y={y}");
            }

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


            // Перегрузка операций ++ и -- и +
            public static Point operator --(Point Ad)
            {
                Ad.x -= 1;
                Ad.y -= 1;
                return Ad;
            }

            public static Point operator ++(Point Ad)
            {
                Ad.x += 1;
                Ad.y += 1;
                return Ad;
            }

            // перегрузка true или false, если они не равны, то false, иначе true
            public static bool operator false(Point Ad)
            {
                if (Ad.x != Ad.y)
                    return false;
                return true;
            }

            public static bool operator true(Point Ad)
            {
                if (Ad.x == Ad.y)
                    return true;
                return false;
            }
            public static Point operator +(Point Ad, int skalar)
            {
                Ad.x = Ad.x + skalar;
                Ad.y = Ad.y + skalar;
                return Ad;
            }
            public static Point operator -(Point Ad, int skalar)
            {
                Ad.x = Ad.x - skalar;
                Ad.y = Ad.y - skalar;
                return Ad;
            }
            public static Point operator +(int skalar, Point Ad)
            {
                Ad.x = Ad.x + skalar;
                Ad.y = Ad.y + skalar;
                return Ad;
            }

            public static Point operator -(int skalar, Point Ad)
            {
                Ad.x = Ad.x - skalar;
                Ad.y = Ad.y - skalar;
                return Ad;
            }

            // Индексаторы 0=x, 1=y, если не 0 и 1, то ошибка
            public int this[int index]
            {
                get
                {
                    if (index == 0) return x;
                    if (index == 1) return y;
                    else
                        throw new Exception("Ошибка");// в противном случае ошибка
                }
            }


            // преобразования типа Point в string (и наоборот).
            public static explicit operator String(Point obj)
            {
                return obj.x + ", " + obj.y;
            }

            public static explicit operator Point(string str)
            {
                string[] q = str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                Point obj = new Point();
                obj.x = int.Parse(q[0]);
                obj.y = int.Parse(q[1]);
                return obj;
            }

        }






        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                x = 0;
                y = 0;

            }
            else
            {
                try
                {
                    x = Convert.ToInt32(textBox1.Text);
                    y = Convert.ToInt32(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Введите корректные X и Y");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    return;
                }
            }

            Point point = new Point(x, y);
            
            

           
            point.schowPoints();
            point.showCalculate();
            

            //Перемещение точки на вектор
            
            int a =Convert.ToInt32(textBox3.Text);

          
            int b = Convert.ToInt32(textBox4.Text);

            point.Moving(a, b);
        
       

            //Получение и установление координаты точке через свойства
            int X = Convert.ToInt32(textBox7.Text);
            int Y = Convert.ToInt32(textBox8.Text);
            point.X = X;
            point.Y = Y;
            MessageBox.Show($"Установление координат через свойства x={point.X} y={point.Y}");

            //Console.WriteLine("Умножение координаты точки на скаляр");
            //Console.Write("Введите скаляр=");
            int SCA = Convert.ToInt32(textBox5.Text);
            point.SkalarX = SCA;
            point.SkalarY = SCA;
            MessageBox.Show($"Умножение координат точки на скаляр x={point.X} y={point.Y}");

            //Console.WriteLine("при ++ значение координат увеличивается на 1");
            point++;
            MessageBox.Show($"При ++ значение увеличивается на 1 x={point.X} y={point.Y}");

            point--;
            MessageBox.Show($"При -- значение координат уменьшается на 1 x={point.X} y={point.Y}");

            //Console.WriteLine("При + значение координат увеличивается на скаляр ");
            point = point + SCA;
            MessageBox.Show($"При + значение увеличивается на скаляр x={point.X} y={point.Y}");

            point = point - SCA;
            MessageBox.Show($"При - значение уменьшается на скаляр x={point.X} y={point.Y}");


            //Console.WriteLine("Если x и y равны, то true, иначе false");

            if (point)
                MessageBox.Show("X и Y равны");
            else
                MessageBox.Show("X и Y неравны");
            

            //Console.WriteLine("Преобразования типа Point в string:");
            string str = (string)point;
            MessageBox.Show($"Преобразование из point в string= {str}");

            //Console.WriteLine("Преобразования типа string в Point:");
            point = (Point)str;
            MessageBox.Show($"Преобразование из string в point x={point.X} y={point.Y}");


            //Console.WriteLine("Обращение по индексу!");

            MessageBox.Show($"Обращение по индексу x={point[0]} y={point[1]}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = null;

        }
    }
}
