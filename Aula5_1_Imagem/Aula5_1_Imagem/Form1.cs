using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula5_1_Imagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImagem1_Click(object sender, EventArgs e)
        {
            imgImagem.ImageLocation = @"C:\Users\Public\Pictures\Sample Pictures\tulips.jpg";
        }

        private void imgImagemAuto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imgImagemAuto.ImageLocation = openFileDialog1.FileName;
        }

        private void ajustadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgImagemAuto.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
