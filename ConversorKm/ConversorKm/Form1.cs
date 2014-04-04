using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConversorKm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {  
            Double Calculo;
            Calculo = Convert.ToDouble(txtKm.Text);
            Calculo = Calculo / 3.6;
            txtMetro.Text = Convert.ToString(Calculo);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKm_TextChanged(object sender, EventArgs e)
        {
            double calculo;
            calculo = Convert.ToDouble(txtKm.Text);
            calculo = calculo / 3.6;
            txtMetro.Text = Convert.ToString(calculo);

        }
    }
}
