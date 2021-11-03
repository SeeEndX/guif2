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
            SumA.Text = Properties.Settings.Default.SumA;
            SumB.Text = Properties.Settings.Default.SumB;
            double A = double.Parse(this.SumA.Text);
            double B = double.Parse(this.SumB.Text);
        }
        private void Count_Click(object sender, EventArgs e,double A, double B)
        {
            A = double.Parse(this.SumA.Text);
            B = double.Parse(this.SumB.Text);
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (Logic.correctinput(A, B) == 1) MessageBox.Show(result);
                Properties.Settings.Default.SumA = this.SumA.Text;
                Properties.Settings.Default.SumB = this.SumB.Text;
                Properties.Settings.Default.Save();
            }
            else MessageBox.Show("Вы не выбрали для какого задания считать сумму");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.SumA.Text = "0";
            this.SumB.Text = "0";
            Properties.Settings.Default.SumA = this.SumA.Text;
            Properties.Settings.Default.SumB = this.SumB.Text;
            Properties.Settings.Default.Save();
        }


        private void Task_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гражданин 1 марта открыл счет в банке, вложив A руб.\n" +
                "Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы.\n" +
                "Определить:\n а) за какой месяц величина ежемесячного увеличения вклада превысит B руб.;\n" +
                " б) через сколько месяцев размер вклада превысит C руб");
            Properties.Settings.Default.SumA = this.SumA.Text;
            Properties.Settings.Default.SumB = this.SumB.Text;
            Properties.Settings.Default.Save();
        }

        public string result = "Ошибка";
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
                    month1++;
                    if (A > B) A2 = A1 % A;
                    else if (A1 - A >= B) i = 1000;
                    if (A2 > B) i = 1000;
                }
                return month1;
            }
            public static int secondcond(double A, double B)
            {
                double A2 = A;
                int month2 = 0;
                for (int j = 0; j < 1000; j++)
                {
                    while (B > A2)
                    {
                        A2 = A2 * 1.02;
                        month2++;
                    }
                }
                return month2;
            }

            public static int correctinput(double A, double B)
            {
                int a = 0;
                if (A <= 0 || B <= 0) MessageBox.Show("Неверные исходные данные! ");
                else a = 1;
                return a;
            }
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e,double A,double B) //условие а)
        {
            RadioButton radioButton = (RadioButton)sender;
            A = double.Parse(this.SumA.Text);
            B = double.Parse(this.SumB.Text);
            if (radioButton.Checked)
            {
                string result1 = "За " + Logic.firstcond(A, B) + "й мес. величина ежемесячного увеличения вклада превысит " + B + " руб";
                result = result1;
            }
            //radioButton = (RadioButton)sender;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e, double A, double B) // условие б)
        {
            RadioButton radioButton = (RadioButton)sender;
            A = double.Parse(this.SumA.Text);
            B = double.Parse(this.SumB.Text);
            if (radioButton.Checked)
            {
                string result2 = "Через " + Logic.secondcond(A,B) + " мес. размер вклада превысит " + B + " руб";
                result = result2;
            }
        }


    }
}
