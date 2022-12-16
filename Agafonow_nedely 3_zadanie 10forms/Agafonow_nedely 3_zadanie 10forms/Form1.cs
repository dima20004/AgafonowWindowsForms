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

namespace Agafonow_nedely_3_zadanie_10forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void gig()
        {
            try
            {
                if (!Directory.Exists(@"D:\temp"))         //Если эта папка не существует
                {
                    Directory.CreateDirectory(@"D:\temp"); //Создает папку temp
                }

                Directory.CreateDirectory(@"D:\temp\" + textBox1.Text);  //Создает папку K1
                Directory.CreateDirectory(@"D:\temp\" + textBox2.Text);  //Создает папку К2
                MessageBox.Show("Все прошло успешно!");
            }
            catch(Exception e)
            {
               MessageBox.Show(e.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            gig();
        }

       
        void gig2()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\temp\K1\" + textBox3.Text + ".txt"))
                { //Создает в K1 t1.txt
                    sw.Write(textBox4.Text);//Записывает в t1
                }
                MessageBox.Show("Все прошло успешно!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            gig2();
        }

       
        void gig3()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\temp\K1\" + textBox6.Text + ".txt"))
                { //Создает в K1 t1.txt
                    sw.Write(textBox5.Text);//Записывает в t1
                }
                MessageBox.Show("Все прошло успешно!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {

            gig3();

        }

        void Create()
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\temp\K2\" + textBox7.Text + ".txt");//Создает в K2 t3.txt
                sw.Close();
                MessageBox.Show("Все прошло успешно!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

}
        private void button5_Click(object sender, EventArgs e)
        {
            Create();
        }

        void gig4()
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\temp\K2\" + textBox9.Text + ".txt");
                StreamReader sr = new StreamReader(@"D:\temp\K1\" + textBox8.Text + ".txt");
                sw.WriteLine(sr.ReadToEnd());              //Записывает в t3 содержимое t1
                sr.Close();
                sr = new StreamReader(@"D:\temp\K1\" + textBox18.Text + ".txt");
                sw.WriteLine(sr.ReadToEnd());//Записывает в t3 содержимое t2
                sr.Close();
                sw.Close();
                MessageBox.Show("Все прошло успешно!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            gig4();

        }
        void gig5()
        {
            try
            {
               
                DirectoryInfo adinf = new DirectoryInfo(@"D:\temp\" + textBox16.Text);//Создаем объект папки
                FileInfo[] afinf = adinf.GetFiles();//GetFiles возвращает список файлов из текущего каталога

                foreach (FileInfo fi in afinf)
                {
                    MessageBox.Show($"{fi.FullName.ToString()} {fi.CreationTime.ToString()} {$"{fi.Length.ToString()} байт"} ");
                    //MessageBox.Show(fi.CreationTime.ToString());
                    //MessageBox.Show($"{fi.Length.ToString()} байт");
                    //Выводим в консоль полный путь файлов
                }
                MessageBox.Show("Все прошло успешно!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            gig5();
        }

        void gig6()
        {
            try
            {
                File.Move("D:\\temp\\K1\\" + textBox11.Text + ".txt", @"D:\temp\" + textBox10.Text + "\\t2.txt");//Перемещаем t2 в K2
                MessageBox.Show("Все прошло успешно!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            gig6();
        }

        void gig7()
        {
            try
            {
                File.Copy("D:\\temp\\K1\\" + textBox13.Text + ".txt", @"D:\\temp\\" + textBox12.Text + "\\t1.txt");
                MessageBox.Show("Все прошло успешно!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            gig7();
        }

        void gig8()
        {
            try
            {
                Directory.Move(@"D:\temp\" + textBox15.Text, @"D:\temp\" + textBox14.Text);
                MessageBox.Show("Все прошло успешно!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            gig8();
        }

        void gig9()
        {
            try
            {
                DirectoryInfo dinf = new DirectoryInfo(@"D:\temp\" + textBox17.Text);//Создаем объект папки ALL
                FileInfo[] finf = dinf.GetFiles();//GetFiles возвращает список файлов из текущего каталога
                foreach (FileInfo fi in finf)
                {
                    MessageBox.Show($"{fi.FullName.ToString()} {fi.CreationTime.ToString()} {$"{fi.Length.ToString()} байт"} ");

                    //MessageBox.Show(fi.FullName.ToString());
                    //MessageBox.Show(fi.CreationTime.ToString());
                    //MessageBox.Show($"{fi.Length.ToString()} байт");
                 
                }
                MessageBox.Show("Все прошло успешно!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gig9();
        }
        void gig10()
        {
            try
            {
                Directory.Delete(@"D:\temp\" + textBox19.Text, true);//Удаляем K1
                MessageBox.Show("Все прошло успешно!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void button11_Click(object sender, EventArgs e)
        {
            gig10();
        }
    }
}
