using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConversorNumerico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        private void txtNumeros_TextChanged(object sender, EventArgs e)
        {
            //Variaveis
            string valorDigitado;
            int contador = 0;
            int cont = 0;
            //Entrada
            valorDigitado = txtNumeros.Text.ToUpper();
            
            //Processamento
            if (txtNumeros.TextLength>0)
            {
                if (valorDigitado.Substring(valorDigitado.Length - 1, 1) == "I")
                {
                    while (cont <= valorDigitado.Length - 1)
                    {
                        if (valorDigitado.Substring(cont, 1) == "I")
                        {
                            contador++;
                            cont++;
                        }
                    }
                    if (contador > 3)
                    {
                        valorDigitado = valorDigitado.Substring(0, valorDigitado.Length - 1);
                        contador=2;
                    }
                }
            }

            //Saída
            txtNumeros.Text = valorDigitado;
        }

        private void btnRomanoArabico_Click(object sender, EventArgs e)
        {   
            // variaveis
            //int contador;
            string romano;
            int arabico;
            int tamanho;
            string ultimoNumero;
            
            //entrada
            ultimoNumero = "";
            arabico = 0;
            romano = txtNumeros.Text;
            tamanho = txtNumeros.TextLength;
            //processamento

            #region tentativa 2

            while (tamanho > 0)
            {
                switch (romano.Substring(tamanho - 1,1))
                {
                    case "X":
                        arabico = arabico + 10;
                        ultimoNumero = "X";
                        break;
                    case "V":
                        arabico = arabico + 5;
                        ultimoNumero = "V";
                        break;
                    case"I":
                        if (ultimoNumero=="V")
                        {
                          arabico = arabico - 1;
                        }
                        else if (ultimoNumero=="X")
                        {
                           arabico = arabico - 1;
                        }
                        else
                        {
                            arabico = arabico + 1;
                        }
                        ultimoNumero = "I";
                        break;

                    default:
                        break;
                }
                tamanho--;
            }

            #endregion
            //saida
            lstValores.Items.Add(arabico);
        }

        private void btnArabicoRomano_Click(object sender, EventArgs e)
        {
            string numero;
            string romano;
            romano = "";
            numero = nudArabico.Value.ToString();
            switch (numero)
            {
                case "1":
                    romano = "I";
                    break;
                case "2": 
                    romano = "II";
                    break;
                case "3":
                    romano = "III";
                    break;
                case "4":
                    romano = "IV";
                    break;
                case "5":
                    romano = "V";
                    break;
                case "6":
                    romano = "VI";
                    break;
                case "7":
                    romano = "VII";
                    break;
                case "8":
                    romano = "VIII";
                    break;
                case "9":
                    romano = "IX";
                    break;
                case "10":
                    romano = "X";
                    break;
                default:
                    break;
                             
            }
            lstValores.Items.Add(romano);
        }
    }
}
