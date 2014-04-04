using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RelogioDigital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrRelogio_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void tmrProgresso_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
        }

        private void btnInciar_Click(object sender, EventArgs e)
        {
            tmrProgresso.Enabled = true;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            tmrProgresso.Enabled = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lblRelogio.Font = fontDialog1.Font;
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblRelogio.ForeColor = colorDialog1.Color;
        }
    }
}
