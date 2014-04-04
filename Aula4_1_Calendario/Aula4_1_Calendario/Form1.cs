using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula4_1_Calendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDataCompra.Text = mclCalendario.SelectionStart.ToLongDateString();
            txtDataPagamento.Text = mclCalendario.SelectionStart.AddDays(28).ToLongDateString();
           textBox1.Text = DateTime.Now.Subtract(mclCalendario.SelectionStart).Days.ToString();
        }
    }
}
