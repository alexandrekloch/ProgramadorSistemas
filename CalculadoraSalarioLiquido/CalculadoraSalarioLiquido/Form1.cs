using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraSalarioLiquido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Requisito 1 - Valor das Horas Trabalhadas
            txtValorHora.Text = Convert.ToString(Convert.ToDouble(txtVencimento.Text) / 160);

            //Requisito 2 - Valor Total de Horas Extras
            txtValorHoraExtra.Text = Convert.ToString(Convert.ToDouble(txtValorHora.Text) * 
                                                        1.50 * 
                                                        Convert.ToDouble(txtHorasExtras.Text));

            //Requisito 3 - Valor Total do Salário Família
            txtValorSalarioFamilia.Text = Convert.ToString(Convert.ToDouble(txtFilhos.Text) * 100);

            //Requisito 4 - Valor Total do INSS

            double salarioBruto = Convert.ToDouble(txtVencimento.Text) + 
                                  Convert.ToDouble(txtValorHoraExtra.Text) + 
                                  Convert.ToDouble(txtValorSalarioFamilia.Text);

            txtValorInss.Text = Convert.ToString(salarioBruto * 0.08);
            txtValorFgts.Text = Convert.ToString(salarioBruto * 0.11);
            
            //Requisito 5 - Valor Salário Liquido

            txtSalarioLiquido.Text = Convert.ToString(salarioBruto - 
                                     Convert.ToDouble(txtValorFgts.Text) - 
                                     Convert.ToDouble(txtValorInss.Text));

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVencimento.Clear();
            txtValorSalarioFamilia.Clear();
            txtValorInss.Clear();
            txtValorHoraExtra.Clear();
            txtValorHora.Clear();
            txtValorFgts.Clear();
            txtSalarioLiquido.Clear();
            txtHorasExtras.Clear();
            txtFilhos.Clear();
        }

    }
}
