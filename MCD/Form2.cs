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
            Int32 mcd = 1;
            Int32 residuo;
            Int32 complemento;
            Int32 numero1;
            Int32 numero2;
            string texto1;
            string texto2;
            string salida = "";
            bool errores = false;
            // Eliminamos espacios de la cadena para evitar errores

            texto1 = textBox1.Text.Replace(" ", "");
            texto2 = textBox2.Text.Replace(" ", "");
            numero1 = Convert.ToInt32(texto1);
            numero2 = Convert.ToInt32(texto2);
            salida = "Procedimiento" + Environment.NewLine;

            if (numero1 == 0 || numero2 == 0)
            {
                MessageBox.Show("Ningun numero puede ser 0", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errores = true;
            }
            else
            {
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
                } while (residuo != 0);
            }
            if(errores == true)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label2.Text = "";
            }
            else
            {
                label2.Text = mcd.ToString();
                textBox3.Text = salida;
            } 
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
