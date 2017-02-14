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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double _value, _result;
        private void but_exit_Click(object sender, EventArgs e)
        {
            if (result_label.Text == "0"){
                MessageBox.Show("Вы не смогли решить уровнение!");
                Form1.ActiveForm.Close();
            }
        }

        private void but_count_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Вы ввели в место значения строку!!");
            // textBox1.Clear();
            try
            {
                 _value = Convert.ToDouble(textBox1.Text);         // Считывание значения и передача в переменную для обработки 
                 _result = 2 * Math.Pow(_value, 0.33);            // Нахождение значения по формуле Y = 2* ^3 sqrt(X)
                result_label.Text = _result.ToString();                 // Вывод результата в label

                but_exit.Visible = false;                               // Выключаем кнопку "Exit"
            }
            catch(System.FormatException) {
                if (textBox1.Text == String.Empty)
                {
                    MessageBox.Show("Вы не ввели значение для рассчета!", "Error");
                }
                else{
                    MessageBox.Show("Вы ввели символ, пожалуйста введите цифры!", "Error");
                    textBox1.Clear();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
            }
            else if (checkBox1.Checked == true) {
                textBox1.Enabled = true;
            }
        }

        private void Big_Form(object sender, EventArgs e)
        {
            if (_value != 0)
            {
                this.Width = (int)_value;
                this.Height = 220;
            }
            else
            {
                this.Width = 585;
                this.Height = 220;
            }
        }

        private void Big_Form_Double_Click(object sender, EventArgs e)
        {
            this.Width = 585;
            this.Height = 220;
        }

        private void Mouse_Go(object sender, MouseEventArgs e)
        {
            try
            {
                if (_value >= 0)
                {
                    this.result_label.Location = new Point(80, 94);
                }
                if (_value != 0)
                {
                    Random rnd = new Random();
                    result_label.Left = rnd.Next(0, 10);
                    result_label.Top = rnd.Next(0, 10);
                    _value = 0;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("!!!", "Error");
            }
        }

        private void but_calc_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();                                   // Создаю экземпляр класса Form2; 
            form.Show();                                                // Вызываю через ф-цию Show();
        }

        
    }
}
