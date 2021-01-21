using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD
{
    public partial class Form4 : Form
    {
        string respuesta;
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 regresar = new Form1();
            regresar.Visible = true;
            Visible = false;
            this.Dispose();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double numero3 = Convert.ToDouble(textBox2.Text);
            double numero4 = Convert.ToDouble(textBox2.Text);

            double a = 2;
            double mcd = 1;

            while (a <= numero1 && a <= numero2 && a <= numero3 && a <= numero4)
            {
                while (numero1 % a == 0 && numero2 % a == 0 && numero3 % a == 0 && numero4 % a == 0)
                {
                    mcd = mcd * a;
                    numero1 = numero1 / a;
                    numero2 = numero2 / a;
                    numero3 = numero3 / a;
                    numero4 = numero4 / a;
                }
                a = a + 1;
            }

            respuesta = mcd.ToString();

            label2.Text = respuesta;
        }
    }
}
