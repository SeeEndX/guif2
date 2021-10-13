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
        }

        public class Logic
            {
            public static string firstcond(double A, double B)
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
                string result1 = "За "+month1+"й мес. величина ежемесячного увеличения вклада превысит "+B+" руб";
                return result1;
            }
            public static string secondcond(double A, double C)
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
                string result2 = "Через " + month2 + " мес. размер вклада превысит " + C + " руб";
                return result2;
            }
            public static int correctinput(double A, double B, double C)
            {
                int a = 0;
                if (A <= 0 || B <= 0 || C <= 0) MessageBox.Show("Неверные исходные данные! ");
                else a = 1;
                return a;
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            double A = double.Parse(this.SumA.Text);
            double B = double.Parse(this.SumB.Text);
            double C = double.Parse(this.SumC.Text);
            if (Logic.correctinput(A, B, C) == 1)
            {
                string result = Logic.firstcond(A, B) + "\n" + Logic.secondcond(A, C);
                MessageBox.Show(result);
            }
            else MessageBox.Show("Неверные исходные данные!");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.SumA.Text = "";
            this.SumB.Text = "";
            this.SumC.Text = "";
        }

        private void Task_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гражданин 1 марта открыл счет в банке, вложив A руб.\n" +
                "Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы.\n" +
                "Определить:\n а) за какой месяц величина ежемесячного увеличения вклада превысит B руб.;\n" +
                " б) через сколько месяцев размер вклада превысит C руб");
        }
    }
}
