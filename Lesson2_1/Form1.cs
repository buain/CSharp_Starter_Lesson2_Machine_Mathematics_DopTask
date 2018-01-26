using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Кнопка "byte"
            MessageBox.Show("От 0 до 255", "byte");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Кнопка "sbyte"
            MessageBox.Show("От -128 до 128", "sbyte");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Кнопка "short"
            MessageBox.Show("От -32 768 до 32 767", "short");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Кнопка "ushort"
            MessageBox.Show("От 0 до 65535", "ushort");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Кнопка "int"
            MessageBox.Show("От -2 147 483 648 до 2 147 483 647", "int");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Кнопка "uint"
            MessageBox.Show("От 0 до 4 294 967 295", "uint");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Кнопка "long"
            MessageBox.Show("От -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807", "long");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Кнопка "ulong"
            MessageBox.Show("От 0 до 18 446 744 073 709 551 615", "ulong");
        }
    }
}
