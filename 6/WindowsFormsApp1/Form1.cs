using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    


    public partial class Form1 : Form
    {
        
        public static int testn = 1;
        public static int instr = 0;
        public static int otvet = 0;
        public static int point = 0;

        public static string[] T = {"USB порты не работают",
                "ПК не включается",
                "Нет изображения",
                "Не загружается BIOS",
                "Нет звука"
            };
        public static string[] t1 = {"Неисправна микросхема BIOS",
                "Неисправнен Южный мост",//в
                "Неисправность DDR3",
                "Неисправность PCI-E"
            };
        public static string[] t2 = {"Проблемы с DDR3",
                "Неисправен Южный мост",
                "Неисправна микросхема звукового ядра",
                "Короткое замыкание"//в
            };
        public static string[] t3 = {"Неисправность PCI-E",//в
                "Неисправна микросхема BIOS",
                "Короткое замыкание",
                "Неисправен Южный мост"
            };
        public static string[] t4 = {"Неисправна микросхема звукового ядра",
                "Неисправна микросхема BIOS",//в
                "Короткое замыкание",
                "Неисправность PCI-E"
            };
        public static string[] t5 = {"Неисправность DDR3",
                "Неисправна микросхема BIOS",
                "Неисправна микросхема звукового ядра",//в
                "Неисправен Южный мост"
            };

        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox1.Text = T[0];
            Smena(t1);
            button2.Hide();
            textBox2.Text = "Инструмент";
            checkBox1.Text = "Амперметр";
            checkBox2.Text = "Вольтметр";
            checkBox3.Text = "Осциллограф";
            button1.Text = "Ответить";
            button2.Text = "Пройти тест заново";
            button3.Text = "Инструкция";
            textBox3.Text = "ASRock H61m";
            button4.Text = "";
            Trans(button4);
            button5.Text = "";
            Trans(button5);
            button6.Text = "";
            Trans(button6);
            button7.Text = "";
            Trans(button7);
            button8.Text = "";
            Trans(button8);
            button9.Text = "";
            Trans(button9);
        }
        public void Smena(string[] el)
        {
            checkBox4.Text = el[0];
            checkBox5.Text = el[1];
            checkBox6.Text = el[2];
            checkBox7.Text = el[3];
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //ответ
        private void button1_Click(object sender, EventArgs e)
        {
            //проверка теста
            if (testn == 1)
            {
                if (otvet==2)
                {
                    MessageBox.Show("Верно!");
                    point++;
                }
                else
                    MessageBox.Show("Неверно!");
            }
            if (testn == 2)
            {
                if (otvet == 4)
                {
                    MessageBox.Show("Верно!");
                    point++;
                }
                else
                    MessageBox.Show("Неверно!");
            }
            if (testn == 3)
            {
                if (otvet == 1)
                {
                    MessageBox.Show("Верно!");
                    point++;
                }
                else
                    MessageBox.Show("Неверно!");
            }
            if (testn == 4)
            {
                if (otvet == 2)
                {
                    MessageBox.Show("Верно!");
                    point++;
                }
                else
                    MessageBox.Show("Неверно!");
            }
            if (testn == 5)
            {
                if (otvet == 3)
                {
                    MessageBox.Show("Верно!");
                    point++;
                }
                else
                    MessageBox.Show("Неверно!");
            }
            //переключение теста

            testn++;
            if (testn == 6)
            {
                button1.Hide();
                button1.Enabled = false;
                button2.Show();
                if (point < 3)
                    point = 2;
                MessageBox.Show("Тест завершен! Ваша оценка: " + point);
            }
            if (testn < 6)
            {
                textBox1.Text = T[testn - 1];
                otvet = 0;
                checkBox7.Checked = false;
                checkBox6.Checked = false;
                checkBox5.Checked = false;
                checkBox4.Checked = false;
            }
            if (testn == 2)
            {
                Smena(t2);
            }
            if (testn == 3)
            {
                Smena(t3);
            }
            if (testn == 4)
            {
                Smena(t4);
            }
            if (testn == 5)
            {
                Smena(t5);
            }

        }
        public void Trans(ButtonBase but)
        {
            but.BackColor = Color.Transparent;
            but.FlatStyle = FlatStyle.Flat;
            but.FlatAppearance.BorderSize = 0;
            but.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 52, 152, 219);
            but.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 52, 152, 219);
            pictureBox1.Controls.Add(but);//добавляем кнопку в кортинку и она становится прозрачной относительно картинки
        }
        //тест
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                otvet = 4;

                checkBox6.Enabled = false;
                checkBox5.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {
                otvet = 0;

                checkBox6.Enabled = true;
                checkBox5.Enabled = true;
                checkBox4.Enabled = true;
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                otvet = 3;

                checkBox7.Enabled = false;
                checkBox5.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {
                otvet = 0;

                checkBox7.Enabled = true;
                checkBox5.Enabled = true;
                checkBox4.Enabled = true;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                otvet = 2;

                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {
                otvet = 0;

                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox4.Enabled = true;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                otvet = 1;

                checkBox6.Enabled = false;
                checkBox5.Enabled = false;
                checkBox7.Enabled = false;
            }
            else
            {
                otvet = 0;

                checkBox6.Enabled = true;
                checkBox5.Enabled = true;
                checkBox7.Enabled = true;
            }
        }

    
        //инструменты
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                instr = 3;

                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                instr = 0;

                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                instr = 2;

                checkBox3.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                instr = 0;

                checkBox3.Enabled = true;
                checkBox1.Enabled = true;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                instr = 1;

                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                instr = 0;

                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        //инструмент
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //тест
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //рестарт
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = T[0];
            Smena(t1);
            button2.Hide();
            button1.Show();
            button1.Enabled = true;
            testn = 1;
            point = 0;
            otvet = 0;
            checkBox7.Checked = false;
            checkBox6.Checked = false;
            checkBox5.Checked = false;
            checkBox4.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Используя встроенные инструменты выявите неисправность материнской платы и ответьте на вопрос");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //питиние
        private void button4_Click(object sender, EventArgs e)
        {
            if (testn != 2)
            {
                if (instr == 1) MessageBox.Show("Нет признаков короткого замыкания между линиями +12V, +5V, +3.3V и землей");
                if (instr == 2) MessageBox.Show("Все напряжения находятся в норме: +12V = 12.0V, +5V = 5.0V, +3.3V = 3.3V");
                if (instr == 3) MessageBox.Show("Форма сигнала стабильна, без помех и колебаний");
            }
            else
            {
                if (instr == 1) MessageBox.Show("Обнаружено низкое сопротивление между линиями питания и землей, что указывает на короткое замыкание");
                if (instr == 2) MessageBox.Show("Напряжения на линиях питания нестабильны или значительно ниже нормы");
                if (instr == 3) MessageBox.Show("Сигналы на линиях питания искажены, присутствуют пики и провалы");
            }
        }
        //видео карта
        private void button5_Click(object sender, EventArgs e)
        {
            if (testn != 3)
            {
                if (instr == 1) MessageBox.Show("Сопротивление на линиях видеокарты в норме");
                if (instr == 2) MessageBox.Show("Напряжение на линиях видеокарты стабильно");
                if (instr == 3) MessageBox.Show("Сигналы чистые и стабильные, без помех");
            }
            else
            {
                if (instr == 1) MessageBox.Show("Обнаружено повышенное сопротивление или обрыв в линиях передачи данных видеокарты");
                if (instr == 2) MessageBox.Show("Напряжение в разъеме видеокарты нестабильно, местами слишком высокое или слишком низкое");
                if (instr == 3) MessageBox.Show("Сигналы в линиях передачи данных видеокарты искажены, присутствуют значительные помехи и шумы");
            }
        }
        //BIOS
        private void button6_Click(object sender, EventArgs e)
        {
            if (testn != 4)
            {
                if (instr == 1) MessageBox.Show("Сопротивление микросхемы BIOS в пределах нормы");
                if (instr == 2) MessageBox.Show("Напряжение питания микросхемы BIOS корректно");
                if (instr == 3) MessageBox.Show("Сигналы BIOS без отклонений, все в пределах спецификаций");
            }
            else
            {
                if (instr == 1) MessageBox.Show("Сопротивление микросхемы BIOS в пределах нормы");
                if (instr == 2) MessageBox.Show("Напряжение питания микросхемы BIOS корректно");
                if (instr == 3) MessageBox.Show("Сигналы отсутствуют или не соответствуют норме, возможна ошибка прошивки или повреждение микросхемы");
            }
        }
        //usb
        private void button7_Click(object sender, EventArgs e)
        {
            if (testn != 1)
            {
                if (instr == 1) MessageBox.Show("Сопротивление USB портов нормальное");
                if (instr == 2) MessageBox.Show("Все USB порты показывают стабильное напряжение 5V");
                if (instr == 3) MessageBox.Show("Сигналы USB стабильны, без отклонений");
            }
            else
            {
                if (instr == 1) MessageBox.Show("Сопротивление на микросхеме южного моста ниже нормы");
                if (instr == 2) MessageBox.Show("Напряжение на южном мосте нестабильно, местами слишком высокое или слишком низкое");
                if (instr == 3) MessageBox.Show("Сигналы на линиях южного моста искажены, обнаружены необычные колебания и шумы");
            }
        }
        //звук
        private void button8_Click(object sender, EventArgs e)
        {

                if (testn != 5)
            {
                    if (instr == 1) MessageBox.Show("Аудиоцепи показывают нормальное сопротивление");
                    if (instr == 2) MessageBox.Show("Напряжение аудиосистемы стабильно");
                    if (instr == 3) MessageBox.Show("Аудиосигналы чистые, без шумов и искажений");
            }
                else
            {
                if (instr == 1) MessageBox.Show("Сопротивление микроконтроллера в пределах нормы");
                if (instr == 2) MessageBox.Show("Питание на микроконтроллере стабильно");
                if (instr == 3) MessageBox.Show("Сигналы генерации звука отсутствуют или искажены, требуется замена микроконтроллера");
            }
        }
        //память
        private void button9_Click(object sender, EventArgs e)
        {

                if (instr == 1) MessageBox.Show("Сопротивление оперативной памяти в пределах нормы");
                if (instr == 2) MessageBox.Show("Напряжение на линиях питания оперативной памяти стабильное");
                if (instr == 3) MessageBox.Show("Сигналы передачи данных оперативной памяти стабильны и не искажены");

        }
    }
}
