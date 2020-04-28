using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Algoritm
{
    public partial class Form1 : Form
    {
        int[] mass = new int[10];
        int q = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mass[q] = Convert.ToInt32(textBox1.Text);
            q++;
            textBox1.Text = " ";
            string text = Convert.ToString(q);
            if (q < 10)
            {
                textBox2.Text = "Введите " + text + "/9";
            }
            else
            {
                textBox2.Text = "Готово";
                button1.Enabled = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = mass[0];
            for (int i = 1; i < 9; i++)
            {
                if (max > mass[i])
                {
                    max = mass[i];
                }
            }
            textBox3.Text = Convert.ToString(max);
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int min = mass[0];
            for (int i = 1; i < 9; i++)
            {
                if (min < mass[i])
                {
                    min = mass[i];
                }
            }
            textBox4.Text = Convert.ToString(min);
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int temp;

            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;

                    }
                }
            }
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                result = result + Convert.ToString(mass[i]) + "  ";
            }
            textBox5.Text = result;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int temp;

            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] < mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;

                    }
                }
            }
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                result = result + Convert.ToString(mass[i]) + "  ";
            }
            textBox6.Text = result;
            button5.Enabled = false;
        }
    }
}
