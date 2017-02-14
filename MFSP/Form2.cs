using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFSP
{
     
    public partial class Form2 : Form
    {
        private double a,b,c;
        private bool znak = true;
        private int count;

        public Form2()
        {
            InitializeComponent();
        }

        private void calculate() {
            switch(count){
                case 1: {
                        b = a + Convert.ToDouble(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 2: {
                        b = a - Convert.ToDouble(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 3: {
                        b = a * Convert.ToDouble(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 4: {
                        b = a / Convert.ToDouble(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 5: {
                        b = a % Convert.ToDouble(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Text = b.ToString();
                        break;
                    }
                case 6: {
                        c = Convert.ToUInt32(textBox1.Text);
                        b = Math.Pow(a, c);
                        textBox1.Clear();
                        textBox1.Text = b.ToString();
                        break;
                    }

                default: {
                            break;
                         } 
            }
        }

        #region 0...9
        private void but_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1; 
        }
        private void but_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }
        private void but_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }
        private void but_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        private void but_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }
        private void but_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }
        private void but_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        private void but_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        private void but_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }
        private void but_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        #endregion

        //Clear_But
        private void but_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }
        // Plus_but
        private void but_plus_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);            // Считывание значения из textbox и передача переменную 
                count = 1;                                      // для switch()
                textBox1.Clear();
                label1.Text = "+";                              // добавляем в label знак +
                znak = true;                                    // Обработка операции с положительным значением
            }
            catch (System.FormatException) {
                MessageBox.Show("Вы не ввели значение для операции", "Warning");
            }
        }
        // Number_PI
        private void but_Pi_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "3,1415926535897932384626433832795";
            label1.Text = "Число π";
        }
        // Min_but
        private void but_min_Click(object sender, EventArgs e)
        {
            try {
                a = Convert.ToDouble(textBox1.Text);
                count = 2;
                textBox1.Clear();
                label1.Text = "-";
                znak = true;

            }
            catch (System.FormatException) {
                MessageBox.Show("Вы не ввели значение для операции", "Warning");
            }
        }
        // Mult_but
        private void but_mult_Click(object sender, EventArgs e)
        {
            try {
                a = Convert.ToDouble(textBox1.Text);
                count = 3;
                textBox1.Clear();
                label1.Text = "*";
                znak = true;   
            }
            catch (System.FormatException) {
                MessageBox.Show("Вы не ввели значение для операции", "Warning");
            }
        }
        // Delit_But
        private void but_del_Click(object sender, EventArgs e)
        {
            try {
                a = Convert.ToDouble(textBox1.Text);
                count = 4;
                textBox1.Clear();
                label1.Text = "/";
                znak = true;
            }
            catch (System.FormatException) {
                MessageBox.Show("Вы не ввели значение для операции", "Warning");
            }
        }
        // persent_but
        private void but_persent_Click(object sender, EventArgs e)
        {
            try {
                a = Convert.ToDouble(textBox1.Text);
                count = 5;
                textBox1.Clear();
                label1.Text = "%";
                znak = true;
            }
            catch (System.FormatException) {
                MessageBox.Show("Вы не ввели значение для операции", "Warning");
            }
        }
        // Sin_But
        private void but_sin_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            double _value = Math.Sin(a);
            textBox1.Clear();
            label1.Text = "Sin(" + a.ToString() + ")";
            textBox1.Text = _value.ToString();
        }
        // Cos_But
        private void but_cos_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            double _value = Math.Cos(a);
            textBox1.Clear();
            label1.Text = "Cos(" + a.ToString() + ")";
            textBox1.Text = _value.ToString();
        }
        // result_But
        private void but_ravn_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }
        // Back_But 
        private void button2_Click(object sender, EventArgs e)
        {
            int _value = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < _value; i++) {
                textBox1.Text += text[i]; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (znak == true) {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false){
                textBox1.Text = textBox1.Text.Replace("-","");
                znak = true;
            }
        }

        private void ut_Xe_Click(object sender, EventArgs e)
        {
            
        }

        private void but_tg_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            label1.Text = "Tg(" + a.ToString() + ")";
            double _value = Math.Tan(a); 
            textBox1.Clear();
            textBox1.Text = _value.ToString();
        }

        private void but_ctg_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            label1.Text = "Ctg(" + a + ")";
            double _value = 1/Math.Tan(a);
            textBox1.Clear();
            textBox1.Text = _value.ToString();
        }

        private void but_bin_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                    textBox1.Clear();
                    int index = 0, ish;
                    for (int i = 0; i <= index; i++)
                    {
                        if (a >= 1)
                        {
                            ish = (int)a % 2;
                            a /= 2;
                            textBox1.Text += ish.ToString();
                            index++;
                        }
                        else break;
                    }
                    string str = textBox1.Text;
                    char[] arr = str.ToCharArray();
                    Array.Reverse(arr);
                    string str1 = new string(arr);
                    textBox1.Text = str1.ToString();
            }
            catch (System.FormatException) {
                MessageBox.Show("Не допустимое значение!", "Warning");
            }
        }

        private void but_Ex_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            Math.Exp(a);
            textBox1.Clear();
            label1.Text = a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToUInt32(textBox1.Text);
        }

        private void but_Xn_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                label1.Text = "(X^n) введите степень для подсчета";
                count = 6;
                textBox1.Clear();
                znak = true;
            }
            catch (System.FormatException) {
                MessageBox.Show("Вы не ввели значения для операции!", "Warning");
            }
            
        }
        // Dot_But
        private void but_dot_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }
    }
}
