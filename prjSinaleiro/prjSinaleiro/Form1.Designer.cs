namespace prjSinaleiro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.sinalAmarelo = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.sinalVerde = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.sinalVermelho = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.sinalAmarelo,
            this.sinalVerde,
            this.sinalVermelho});
            this.shapeContainer1.Size = new System.Drawing.Size(124, 261);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // sinalAmarelo
            // 
            this.sinalAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.sinalAmarelo.Location = new System.Drawing.Point(18, 101);
            this.sinalAmarelo.Name = "sinalAmarelo";
            this.sinalAmarelo.Size = new System.Drawing.Size(75, 69);
            // 
            // sinalVerde
            // 
            this.sinalVerde.BackColor = System.Drawing.Color.Lime;
            this.sinalVerde.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.sinalVerde.Location = new System.Drawing.Point(20, 180);
            this.sinalVerde.Name = "sinalVerde";
            this.sinalVerde.Size = new System.Drawing.Size(75, 69);
            // 
            // sinalVermelho
            // 
            this.sinalVermelho.BackColor = System.Drawing.Color.Red;
            this.sinalVermelho.Location = new System.Drawing.Point(17, 19);
            this.sinalVermelho.Name = "sinalVermelho";
            this.sinalVermelho.Size = new System.Drawing.Size(75, 69);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 261);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape sinalVermelho;
        private Microsoft.VisualBasic.PowerPacks.OvalShape sinalAmarelo;
        private Microsoft.VisualBasic.PowerPacks.OvalShape sinalVerde;
        private System.Windows.Forms.Timer timer1;
    }
}

