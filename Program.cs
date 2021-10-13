using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guif2
{
    static class Program
    {
        /// <summary>
        public class logic
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
                if (logic.correctinput(A, B, C) == 1)
                {
                    var fc = logic.firstcond(A, B);
                    var sc = logic.secondcond(A, C);
                }
                else System.Diagnostics.Process.GetCurrentProcess().Kill(); //закрытие программы
                                                                            //Конец логики
            }
        }
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
