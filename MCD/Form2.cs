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
    public partial class Form2 : Form
    {
        string respuesta;

        public Form2()
        {
            InitializeComponent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = 0;
            int numero2 = 0;
            try
            {
                 numero1 = Convert.ToInt32(textBox1.Text);
                 numero2 = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Asegurese de no haber escrito espacion, unicamente NUMEROS ENTEROS", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            };
           
            Int32 a = 2;
            Int32 mcd = 1;
            /*
            while (a <= numero1 && a <= numero2)
            {
                while (numero1 % a == 0 && numero2 % a == 0 )
                {
                    mcd = mcd * a;
                    numero1 = numero1 / a;
                    numero2 = numero2 / a;
                }
                a = a + 1;
            }

            respuesta = mcd.ToString();

            label2.Text = respuesta;*/
            Int32 residuo;
            Int32 complemento;
            string salida = "";
            do
            { 

                residuo = numero1 % numero2;
                complemento = numero1 / numero2;
                salida = salida + string.Empty;
                salida = salida + string.Format(numero1 + "=" + numero2 + "*" + complemento + "+" + residuo + "\n") + Environment.NewLine;
                
                
                if (residuo != 0)
                {
                    numero1 = numero2;
                    numero2 = residuo;
                }
                else
                {
                    mcd = numero2;
                }
            }while(residuo != 0);

            label2.Text = mcd.ToString();
            textBox3.Text = salida;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label2.Text = "";
            textBox3.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
