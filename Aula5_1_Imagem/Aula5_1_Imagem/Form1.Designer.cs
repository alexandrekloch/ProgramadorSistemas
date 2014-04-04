namespace Aula5_1_Imagem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.btnImagem1 = new System.Windows.Forms.Button();
            this.btnImagem2 = new System.Windows.Forms.Button();
            this.btnImagem3 = new System.Windows.Forms.Button();
            this.imgImagemAuto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajustadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagemAuto)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgImagem
            // 
            this.imgImagem.Image = ((System.Drawing.Image)(resources.GetObject("imgImagem.Image")));
            this.imgImagem.Location = new System.Drawing.Point(12, 12);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(240, 224);
            this.imgImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgImagem.TabIndex = 0;
            this.imgImagem.TabStop = false;
            // 
            // btnImagem1
            // 
            this.btnImagem1.Location = new System.Drawing.Point(13, 257);
            this.btnImagem1.Name = "btnImagem1";
            this.btnImagem1.Size = new System.Drawing.Size(75, 23);
            this.btnImagem1.TabIndex = 1;
            this.btnImagem1.Text = "Tulipas";
            this.btnImagem1.UseVisualStyleBackColor = true;
            this.btnImagem1.Click += new System.EventHandler(this.btnImagem1_Click);
            // 
            // btnImagem2
            // 
            this.btnImagem2.Location = new System.Drawing.Point(95, 257);
            this.btnImagem2.Name = "btnImagem2";
            this.btnImagem2.Size = new System.Drawing.Size(75, 23);
            this.btnImagem2.TabIndex = 2;
            this.btnImagem2.Text = "Imagem 2";
            this.btnImagem2.UseVisualStyleBackColor = true;
            // 
            // btnImagem3
            // 
            this.btnImagem3.Location = new System.Drawing.Point(177, 257);
            this.btnImagem3.Name = "btnImagem3";
            this.btnImagem3.Size = new System.Drawing.Size(75, 23);
            this.btnImagem3.TabIndex = 3;
            this.btnImagem3.Text = "Imagem 3";
            this.btnImagem3.UseVisualStyleBackColor = true;
            // 
            // imgImagemAuto
            // 
            this.imgImagemAuto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgImagemAuto.Location = new System.Drawing.Point(259, 13);
            this.imgImagemAuto.Name = "imgImagemAuto";
            this.imgImagemAuto.Size = new System.Drawing.Size(255, 223);
            this.imgImagemAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgImagemAuto.TabIndex = 4;
            this.imgImagemAuto.TabStop = false;
            this.imgImagemAuto.Click += new System.EventHandler(this.imgImagemAuto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustadoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // ajustadoToolStripMenuItem
            // 
            this.ajustadoToolStripMenuItem.Name = "ajustadoToolStripMenuItem";
            this.ajustadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajustadoToolStripMenuItem.Text = "Ajustado";
            this.ajustadoToolStripMenuItem.Click += new System.EventHandler(this.ajustadoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 330);
            this.Controls.Add(this.imgImagemAuto);
            this.Controls.Add(this.btnImagem3);
            this.Controls.Add(this.btnImagem2);
            this.Controls.Add(this.btnImagem1);
            this.Controls.Add(this.imgImagem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagemAuto)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgImagem;
        private System.Windows.Forms.Button btnImagem1;
        private System.Windows.Forms.Button btnImagem2;
        private System.Windows.Forms.Button btnImagem3;
        private System.Windows.Forms.PictureBox imgImagemAuto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajustadoToolStripMenuItem;
    }
}

