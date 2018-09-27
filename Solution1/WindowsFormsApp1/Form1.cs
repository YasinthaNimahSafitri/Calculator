using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float Penambahan(float a, float b)
        {
            return a + b;
        }

        private float Pengurangan(float a, float b)
        {
            return a - b;
        }

        private float Perkalian(float a, float b)
        {
            return a * b;
        }

        private float Pembagian(float a, float b)
        {
            return a / b;
        }
        private void Operasi_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox3.Text = Convert.ToString(Penambahan(a, b));
                    break;
                case 1:
                    textBox3.Text = Convert.ToString(Pengurangan(a, b));
                    break;
                case 2:
                    textBox3.Text = Convert.ToString(Perkalian(a, b));
                    break;
                case 3:
                    textBox3.Text = Convert.ToString(Pembagian(a, b));
                    break;
            }
            }
        }
    }
