using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HwL7Task2
{    // Используя Windows Forms, разработать игру «Угадай число». 
     // Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
     // Компьютер говорит, больше или меньше загаданное число введенного.  
     // a) Для ввода данных от человека используется элемент TextBox;
     //  б) ** Реализовать отдельную форму c TextBox для ввода числа.
    public partial class Form1 : Form
    {
        rndmNum rnum;
        int max;
        Form2 f2;
        public Form1()
        {
            max = 100;
            rnum = new rndmNum(max);
            InitializeComponent();
            btnCheck.Text = "Проверить";
            this.Text = "Угадай число";
            lblStepCount.Text = "0";
            lblEnterTheNumber.Text = $"Введите число от 0 до {max}:";
            lblStepText.Text = "Число ходов:";
            MessageBox.Show("Вводите в поле число пока не угадаете. Нажмите кнопку \"Проверить\" " +
                "чтобы узнать результат попытки. ", "Справка");
            tboxUserAnswer.Visible = false;
            f2 = new Form2();
            f2.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool check;
            //MessageBox.Show(rnum.CheckValue(out check, int.Parse(tboxUserAnswer.Text)));
            MessageBox.Show(rnum.CheckValue(out check, f2.userAnswer));
            if (check)
            {
                rnum.Reset(max);
                MessageBox.Show($"Чтобы начать заново.\nВведите число от 0 до {max}:");
            }
            Update();
        }

        void Update()
        {
            lblStepCount.Text = rnum.Steps.ToString();
            this.Refresh();
        }

    }
}
