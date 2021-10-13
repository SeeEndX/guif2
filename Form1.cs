using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guif2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //SumA.Text = Properties.Settings.Default.SumForA; сохранение полей
        }

        public class Logic
            {
            public static int firstcond(double A, double B)
            {
                int month1 = 0;
                double A1 = A;
                double A2 = 0;
                for (int i = 0; i < 1000; i++)
                {
                    A1 = A1 * 1.02;
                    month1 = month1 + 1;
                    if (A > B) A2 = A1 % A;
                    else if (A1 - A >= B) i = 1000;
                    if (A2 > B) i = 1000;
                }
                Console.WriteLine("\nЗа {0}й мес. величина ежемесячного увеличения вклада превысит {1} руб", month1, B);
                return month1;
            }
            public static int secondcond(double A, double C)
            {
                double A2 = A;
                int month2 = 0;
                for (int j = 0; j < 1000; j++)
                {
                    while (C > A2)
                    {
                        A2 = A2 * 1.02;
                        month2 = month2 + 1;
                    }
                }
                Console.WriteLine("\nЧерез {0} мес. размер вклада превысит {1} руб", month2, C);
                return month2;
            }
            public static int correctinput(double A, double B, double C)
            {
                int a = 0;
                if (A <= 0 || B <= 0 || C <= 0)
                {
                    Console.WriteLine("Неверные исходные данные! Закрытие программы...");
                }
                else a = 1;
                return a;
            }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                //Общение с пользователем начало
                Console.WriteLine("Гражданин 1 марта открыл счет в банке, вложив A руб.\nЧерез каждый месяц размер вклада увеличивается на 2% от имеющейся суммы.");
                Console.WriteLine("а) за какой месяц величина ежемесячного увеличения вклада превысит B руб.;\nб) через сколько месяцев размер вклада превысит C руб\n\n");
                Console.WriteLine("Введите сумму для вклада");
                double A = int.Parse(Console.ReadLine());
                double B = int.Parse(Console.ReadLine());
                double C = int.Parse(Console.ReadLine());
                Console.WriteLine("\nОТВЕТ:");
                //Общение с пользователем конец
                //Начало логики
                if (Logic.correctinput(A, B, C) == 1)
                {
                    var fc = Logic.firstcond(A, B);
                    var sc = Logic.secondcond(A, C);
                }
                else System.Diagnostics.Process.GetCurrentProcess().Kill(); //закрытие программы
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            double A1 = int.Parse(this.SumA.Text);
            double B1 = int.Parse(this.SumB.Text);
            double C1 = int.Parse(this.SumC.Text);
            if (Logic.correctinput(A1, B1, C1) == 1) 
            { 
            Logic.firstcond(A1, B1);
            Logic.secondcond(A1, C1);
            }
        }
    }
}
