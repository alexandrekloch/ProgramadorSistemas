using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSinaleiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sinalVerde.BackStyle == Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque)
            {
                sinalVerde.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;
                sinalAmarelo.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                sinalVermelho.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;
            }
            else if (sinalAmarelo.BackStyle == Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque)
            {
                sinalVerde.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;
                sinalAmarelo.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;
                sinalVermelho.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            }
            else
            {
                sinalVerde.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                sinalAmarelo.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;
                sinalVermelho.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;
            }
        }
    }
}
