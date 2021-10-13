
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
            this.label3 = new System.Windows.Forms.Label();
            this.SumB = new System.Windows.Forms.TextBox();
            this.SumC = new System.Windows.Forms.TextBox();
            this.Task = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
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
            this.SumA.Size = new System.Drawing.Size(177, 27);
            this.SumA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сумма для условия а)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Сумма для условия б)";
            // 
            // SumB
            // 
            this.SumB.Location = new System.Drawing.Point(41, 126);
            this.SumB.Name = "SumB";
            this.SumB.Size = new System.Drawing.Size(177, 27);
            this.SumB.TabIndex = 4;
            // 
            // SumC
            // 
            this.SumC.Location = new System.Drawing.Point(41, 194);
            this.SumC.Name = "SumC";
            this.SumC.Size = new System.Drawing.Size(177, 27);
            this.SumC.TabIndex = 5;
            // 
            // Task
            // 
            this.Task.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Task.Location = new System.Drawing.Point(313, 184);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(123, 40);
            this.Task.TabIndex = 6;
            this.Task.Text = "Задание";
            this.Task.UseVisualStyleBackColor = true;
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Count.Location = new System.Drawing.Point(313, 48);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(123, 39);
            this.Count.TabIndex = 7;
            this.Count.Text = "Рассчитать";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(313, 117);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(123, 39);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 261);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.SumC);
            this.Controls.Add(this.SumB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Вклады";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumB;
        private System.Windows.Forms.TextBox SumC;
        private System.Windows.Forms.Button Task;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button Clear;
    }
}

