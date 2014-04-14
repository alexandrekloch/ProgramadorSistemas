using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dojoComprarCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor;
            double imposto, distribuidor;
            valor = Convert.ToDouble(txtCusto.Text);
            imposto = valor * 0.32;
            distribuidor = valor * 0.15;
            txtPercDist.Text = Convert.ToString(distribuidor);
            txtImposto.Text = imposto.ToString();
            MessageBox.Show("custo total do veículo.: " + (distribuidor + imposto + valor).ToString());

        }
    }
}
