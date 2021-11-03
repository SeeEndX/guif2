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
            comboBox1.Text = "Сумма увеличения вклада (B)";

            // для ENTERа
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
          //this.Count.Click += new System.EventHandler(this.Count_Click); в гайде было, без нее работает
            // для ENTERа
        }

        // для ENTERа
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Count.PerformClick();
        }
        // для ENTERа

        private void Clear_Click(object sender, EventArgs e)
        {
            this.SumA.Text = "";
            this.SumB.Text = "";
            this.comboBox1.Text = "";
            Properties.Settings.Default.SumA = this.SumA.Text;
            Properties.Settings.Default.SumB = this.SumB.Text;
            Properties.Settings.Default.Save();
        }


        private void Task_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гражданин 1 марта открыл счет в банке, вложив A руб.\n"+
                "Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы.\n" +
                "Определить:\n а) за какой месяц величина ежемесячного увеличения вклада превысит B руб.;\n" +
                 "б) через сколько месяцев размер вклада превысит C руб");
            Properties.Settings.Default.SumA = this.SumA.Text;
            Properties.Settings.Default.SumB = this.SumB.Text;
            Properties.Settings.Default.Save();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            double A = double.Parse(this.SumA.Text);
            double B = double.Parse(this.SumB.Text);
            switch (comboBox1.Text)
            {
                case "Сумма увеличения вклада (B)":
                    MessageBox.Show("За " + Logic.firstcond(A, B) + "й мес.величина ежемесячного увеличения вклада превысит " + B + " руб");
                    break;
                case "Сумма увеличенного вклада (C)":
                    MessageBox.Show("Через " + Logic.secondcond(A, B) + "мес.размер вклада превысит " + B + " руб");
                    break;
            }
            Properties.Settings.Default.SumA = this.SumA.Text;
            Properties.Settings.Default.SumB = this.SumB.Text;
            Properties.Settings.Default.Save();
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
                if (A <= 0 || B <= 0) MessageBox.Show("Неверные исходные данные!" );
                else a = 1;
                return a;
            }
        }

    }
}
