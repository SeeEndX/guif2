﻿
namespace guif2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SumA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SumB = new System.Windows.Forms.TextBox();
            this.Task = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма для вклада";
            // 
            // SumA
            // 
            this.SumA.Location = new System.Drawing.Point(41, 57);
            this.SumA.Name = "SumA";
            this.SumA.Size = new System.Drawing.Size(230, 27);
            this.SumA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(292, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сумма для условий";
            // 
            // SumB
            // 
            this.SumB.Location = new System.Drawing.Point(292, 57);
            this.SumB.Name = "SumB";
            this.SumB.Size = new System.Drawing.Size(230, 27);
            this.SumB.TabIndex = 4;
            // 
            // Task
            // 
            this.Task.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Task.Location = new System.Drawing.Point(41, 235);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(123, 39);
            this.Task.TabIndex = 6;
            this.Task.Text = "Задание";
            this.Task.UseVisualStyleBackColor = true;
            this.Task.Click += new System.EventHandler(this.Task_Click);
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Count.Location = new System.Drawing.Point(243, 233);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(123, 39);
            this.Count.TabIndex = 7;
            this.Count.Text = "Рассчитать";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(450, 233);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(123, 39);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Очистить всё";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Сумма увеличения вклада (B)",
            "Сумма увеличенного вклада (C)"});
            this.comboBox1.Location = new System.Drawing.Point(292, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 309);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.SumB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Вклады";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SumB;
        private System.Windows.Forms.Button Task;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

