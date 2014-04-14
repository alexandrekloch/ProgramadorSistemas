using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dataPorExteso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nudDia_ValueChanged(object sender, EventArgs e)
        {
            //Dia
            int dia;
            dia = int.Parse(nudDia.Value.ToString());
            string diaExtenso;
            if(dia<10)
            {
                diaExtenso = "0" + dia;
            }
            else
            {
                diaExtenso = dia.ToString();
            }

            //Mes

            int mes;
            mes = Convert.ToInt16(nudMes.Value);
            string mesExtenso;

            switch (mes)
            {
                case 1 :
                    mesExtenso = "Janeiro";
                    break;
                case 2:
                    mesExtenso = "Fevereiro";
                    break;
                case 3:
                    mesExtenso = "Março";
                    break;
                case 4:
                    mesExtenso = "Abril";
                    break;
                case 5:
                    mesExtenso = "Maio";
                    break;
                case 6:
                    mesExtenso = "Junho";
                    break;
                case 7:
                    mesExtenso = "Julho";
                    break;
                case 8:
                    mesExtenso = "Agosto";
                    break;
                case 9:
                    mesExtenso = "Setembro";
                    break;
                case 10:
                    mesExtenso = "Outubro";
                    break;
                case 11:
                    mesExtenso = "Novembro";
                    break;
                case 12:
                    mesExtenso = "Dezembro";
                    break;
                default:
                    mesExtenso = "Erro!!";
                    break;
            }

            //Ano

            int ano;
            ano = Convert.ToInt16(nudAno.Value);
            string anoExtenso;
            anoExtenso = ano.ToString().Substring(2,2);
            
            //Resultado
            txtDataExtenso.Text = diaExtenso + " de " +
                                  mesExtenso + " de " +
                                  anoExtenso +"." ;
           


        }

       
    }
}
