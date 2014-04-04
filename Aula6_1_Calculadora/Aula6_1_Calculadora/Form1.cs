using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula6_1_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double val1;
            double val2;
            val1 = Convert.ToDouble(txtValor1.Text);
            val2 = Convert.ToDouble(txtValor2.Text);
            double result = val1 + val2;
            txtResultado.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(txtValor1.Text);
            double val2 = Convert.ToDouble(txtValor2.Text);
            txtResultado.Text = Convert.ToString(val1 - val2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToDouble(txtValor1.Text) * Convert.ToDouble(txtValor2.Text) );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToDouble(txtValor1.Text) / Convert.ToDouble(txtValor2.Text));
        }

        private void btnRestoDivisao_Click(object sender, EventArgs e)
        {
            double val1;
            double val2;
            val1 = Convert.ToDouble(txtValor1.Text);
            val2 = Convert.ToDouble(txtValor2.Text);
            double result = val1 % val2;
            txtResultado.Text = Convert.ToString(result);
        }

        private void btnIntDivisao_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(txtValor1.Text);
            double val2 = Convert.ToDouble(txtValor2.Text);
            txtResultado.Text = Convert.ToString(Math.Truncate(val1 / val2));
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(txtValor1.Text);
            double val2 = Convert.ToDouble(txtValor2.Text);
            txtResultado.Text = Convert.ToString(Math.Pow(val1,val2));
        }

       


    }
}
