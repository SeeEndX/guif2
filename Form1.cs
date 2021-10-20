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
        }

        private void Count_Click(object sender, EventArgs e)
        {
            
            double A = double.Parse(this.SumA.Text);
            double B = double.Parse(this.SumB.Text);
            double B1 = double.Parse(this.SumB.Text);
            if (Logic.correctinput(A, B) == 1)
            {
                //string result = Logic.firstcond(A, B) + "\n\n" + Logic.secondcond(A, B1);
                MessageBox.Show(result);
            }
            else MessageBox.Show("Неверные исходные данные!");
            Properties.Settings.Default.SumA = this.SumA.Text;
            Properties.Settings.Default.SumB = this.SumB.Text;
            Properties.Settings.Default.Save();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.SumA.Text = "";
            this.SumB.Text = "";
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

        public string result = "";
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
               // string result1 = "За " + month1 + "й мес. величина ежемесячного увеличения вклада превысит " + B + " руб";
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
                        month2 = month2 + 1;
                    }
                }
                //string result2 = "Через " + month2 + " мес. размер вклада превысит " + B1 + " руб";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //условие б)
        {
            RadioButton radioButton = (RadioButton)sender;
            double A = double.Parse(this.SumA.Text);
            double B = double.Parse(this.SumB.Text);
            if (radioButton.Checked)
            {
                string result1 = "За " + Logic.firstcond(A,B) + "й мес. величина ежемесячного увеличения вклада превысит " + B + " руб";
                result = result1;
            }
            radioButton = (RadioButton)sender;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            double A = double.Parse(this.SumA.Text);
            double B = double.Parse(this.SumB.Text);
            if (radioButton.Checked)
            {
                string result2 = "Через " + Logic.secondcond(A,B) + " мес. размер вклада превысит " + B + " руб";
                result = result2;
            }
        }
    }
}
