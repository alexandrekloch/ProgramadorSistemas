using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraCompleta
{
    public partial class Form1 : Form
    {
        double ValorTotal = 0;
        bool iniciar = true;
        bool pontuacao = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnDois_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + "2";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + "1";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + "0";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtValores.Text = txtValores.Text + "9";
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double novoValor = Convert.ToDouble(txtValores.Text);

            if (iniciar == true)
            {
                ValorTotal = novoValor;
                txtValores.Clear();
                pontuacao = false;
                iniciar = false;
            }
            else
            {
                ValorTotal = ValorTotal + novoValor;
                txtValores.Clear();
                pontuacao = false;
            }

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            txtValores.Clear();
            pontuacao = false;
            txtValores.Text = ValorTotal.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double novoValor = Convert.ToDouble(txtValores.Text);

            if (iniciar == true)
            {
                ValorTotal = novoValor;
                txtValores.Clear();
                iniciar = false;
                pontuacao = false;
            }
            else
            {
                ValorTotal = ValorTotal - novoValor;
                txtValores.Clear();
                pontuacao = false;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double novoValor = Convert.ToDouble(txtValores.Text);

            if (iniciar == true)
            {
                ValorTotal = novoValor;
                txtValores.Clear();
                pontuacao = false;
                iniciar = false;
            }
            else
            {
                ValorTotal = ValorTotal * novoValor;
                txtValores.Clear();
                pontuacao = false;
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double novoValor = Convert.ToDouble(txtValores.Text);

            if (iniciar == true)
            {
                ValorTotal = novoValor;
                txtValores.Clear();
                iniciar = false;
                pontuacao = false;
            }
            else
            {
                ValorTotal = ValorTotal / novoValor;
                txtValores.Clear();
                pontuacao = false;
            }
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            double novoValor = Convert.ToDouble(txtValores.Text);

            txtValores.Text = (novoValor * -1).ToString();

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtValores.Clear();
            pontuacao = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtValores.Clear();
            ValorTotal = 0;
            iniciar = true;
            pontuacao = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            int comp = txtValores.TextLength;
            if(comp > 0)
            {
                txtValores.Text = txtValores.Text.Substring(0,comp-1); 
            }
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            double novoValor = Convert.ToDouble(txtValores.Text);

            if (iniciar == true)
            {
                ValorTotal = novoValor;
                txtValores.Clear();
                iniciar = false;
                pontuacao = false;
            }
            else
            {
                ValorTotal = ValorTotal % novoValor;
                txtValores.Clear();
                pontuacao = false;
            }

        }

        private void btnQuociente_Click(object sender, EventArgs e)
        {
            double novoValor = Convert.ToDouble(txtValores.Text);

            if (iniciar == true)
            {
                ValorTotal = novoValor;
                txtValores.Clear();
                iniciar = false;
                pontuacao = false;
            }
            else
            {
                ValorTotal = Math.Truncate(ValorTotal / novoValor);
                txtValores.Clear();
                pontuacao = false;
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            double novoValor = Convert.ToDouble(txtValores.Text);
            novoValor = Math.Pow(novoValor, 2);
            txtValores.Text = novoValor.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double novoValor = Convert.ToDouble(txtValores.Text);
            novoValor = Math.Sqrt(novoValor);
            txtValores.Text = novoValor.ToString();
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if(pontuacao == false)
            {
                txtValores.Text = txtValores.Text + ".";
                pontuacao = true;
            }
        }
    }
}
