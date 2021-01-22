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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Cambio = new Form2();
            Cambio.Visible = true;
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Cambio = new Form3();
            Cambio.Visible = true;
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Cambio = new Form4();
            Cambio.Visible = true;
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
