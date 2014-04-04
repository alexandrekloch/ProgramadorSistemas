using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int limpa;
            int recebe;
            limpa = txtPeso.TextLength;
            recebe = txtAltura.TextLength;
            if (recebe > 0 & limpa > 0)
            {
                MessageBox.Show("Digite um valor na caixa");
                Double peso;
                Double altura;
                Double resultado;
                peso = Convert.ToDouble(txtPeso.Text);
                altura = Convert.ToDouble(txtAltura.Text);
                altura = altura * altura;
                resultado = peso / altura;
                MessageBox.Show(Convert.ToString(resultado));
                if (resultado < 18.5)
                    MessageBox.Show("Magreza");
                else
                    if (resultado > 18.5 & resultado < 25)
                        MessageBox.Show("Saudável");
                    else
                        MessageBox.Show("Sobrepeso");
            }
            else
                MessageBox.Show("Digite um valor na caixa");


                 
        }
    }
}
