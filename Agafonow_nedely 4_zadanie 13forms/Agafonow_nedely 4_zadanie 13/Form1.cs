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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agafonow_nedely_4_zadanie_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public abstract class Figure
        {
            public abstract void ShowInfo();
            public abstract void Area();

            public abstract void Perimeter();


        }

        //Создать производные классы: Rectangle (прямоугольник) со своими методами вычисления площади и периметра.
        class Rectangle : Figure
        {
            int a, b;

            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public override void ShowInfo()
            {
                MessageBox.Show($"Прямоугольник со сторонами {a} {b}");
            }
            public override void Area()
            {

                MessageBox.Show($"Площадь прямоугольника={a * b}");
            }

            public override void Perimeter()
            {
                MessageBox.Show($"Периметр прямоугольника={(a + b) * 2}");
            }


        }

        //Создать производные классы: Triangle (треугольник) со своими методами вычисления площади и периметра.
        class Triangle : Figure
        {
            int a, b, c;

            public Triangle(int a, int b, int c)
            {
                this.a = a;
                this.c = c;
                this.b = b;
            }

            public override void ShowInfo()
            {
                MessageBox.Show($"Треугольник со сторонами {a} {b} {c}");
            }

            public override void Perimeter()
            {
                MessageBox.Show($"Периметр треугольника={a + b + c}");
            }


            public override void Area()
            {
                double p = (a + b + c) / 2;
                MessageBox.Show($"Площадь треугольника равна={Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
            }


        }

        //Создать производные классы: Circle (круг), со своими методами вычисления площади и периметра.
        class Circle : Figure
        {
            const double pi = 3.14;

            int r;

            public override void ShowInfo()
            {
                MessageBox.Show($"Круг радиусом {r}");
            }
            public Circle(int r) { this.r = r; }

            public override void Area()
            {
                MessageBox.Show($"Площадь круга={pi * r * r}");
            }

            public override void Perimeter()
            {
                MessageBox.Show($"Периметр круга={2 * pi * r}");
            }


        }


        

        public string ReadFile()
        {
            string str = string.Empty; //Представляет пустую строку. Это поле доступно только для чтения.

            try
            {
                StreamReader fin = new StreamReader(@"D:\" + textBox1.Text + ".txt");
                str = fin.ReadToEnd();
                fin.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден, поместите файл в необходимую директорию.");
               
                
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Директория не найдена");
               
               
              
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("Путь или имя файла превышает максимальную длину, определенную системой.");
               
                
               


            }
            return str;
        }

        public  Figure[] GetArrayFigures()
        {
            string[] s = ReadFile().Split('\n');
            Figure[] array_fig = new Figure[s.Length];

            int a, b, c, r, i = 0, n = 0;

            while (i < s.Length)
            {
                string[] str = s[i].Split(' ');

                if (str[0] == "rectangle")
                {
                    a = Convert.ToInt32(str[1]);
                    b = Convert.ToInt32(str[2]);
                    array_fig[n] = new Rectangle(a, b);
                    n++;
                }
                if (str[0] == "circle")
                {
                    r = Convert.ToInt32(str[1]);
                    array_fig[i] = new Circle(r);
                    n++;
                }
                if (str[0] == "triangle")
                {
                    a = Convert.ToInt32(str[1]);
                    b = Convert.ToInt32(str[2]);
                    c = Convert.ToInt32(str[3]);
                    array_fig[i] = new Triangle(a, b, c);
                    n++;
                }
                i++;
            }
            return array_fig;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\" + textBox1.Text + ".txt"))
            {
                sw.Write(textBox2.Text);
            }
        }
        
        

        
    
        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Figure[] array_fig = GetArrayFigures();

                foreach (Figure fig in array_fig)
                {

                    fig.ShowInfo();
                    fig.Area();
                    fig.Perimeter();
                    Console.WriteLine();

                }
            }
            catch
            {
                MessageBox.Show("Ошибка! Проверьте данные!");

            }
            return;
        }
    }
}
