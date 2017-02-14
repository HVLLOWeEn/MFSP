namespace MFSP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.but_count = new System.Windows.Forms.Button();
            this.but_calc = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // but_count
            // 
            this.but_count.Location = new System.Drawing.Point(440, 12);
            this.but_count.Name = "but_count";
            this.but_count.Size = new System.Drawing.Size(118, 26);
            this.but_count.TabIndex = 0;
            this.but_count.Text = "Вычислить";
            this.but_count.UseVisualStyleBackColor = true;
            this.but_count.Click += new System.EventHandler(this.but_count_Click);
            // 
            // but_calc
            // 
            this.but_calc.Location = new System.Drawing.Point(440, 70);
            this.but_calc.Name = "but_calc";
            this.but_calc.Size = new System.Drawing.Size(118, 27);
            this.but_calc.TabIndex = 1;
            this.but_calc.Text = "Калькулятор+";
            this.but_calc.UseVisualStyleBackColor = true;
            this.but_calc.Click += new System.EventHandler(this.but_calc_Click);
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(440, 131);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(118, 27);
            this.but_exit.TabIndex = 2;
            this.but_exit.Text = "Выход";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(12, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 32);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите значение чтобы решить уровнение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат:";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.result_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_label.Location = new System.Drawing.Point(80, 94);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(17, 19);
            this.result_label.TabIndex = 6;
            this.result_label.Text = "0";
            this.result_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Go);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Вводить значения";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(569, 181);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_calc);
            this.Controls.Add(this.but_count);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MFSP Main";
            this.Click += new System.EventHandler(this.Big_Form);
            this.DoubleClick += new System.EventHandler(this.Big_Form_Double_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_count;
        private System.Windows.Forms.Button but_calc;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

