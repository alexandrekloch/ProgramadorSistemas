namespace ConversorNumerico
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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.lstValores = new System.Windows.Forms.ListBox();
            this.nudArabico = new System.Windows.Forms.NumericUpDown();
            this.btnRomanoArabico = new System.Windows.Forms.Button();
            this.btnArabicoRomano = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudArabico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(12, 27);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 20);
            this.txtNumeros.TabIndex = 0;
            this.txtNumeros.TextChanged += new System.EventHandler(this.txtNumeros_TextChanged);
            // 
            // lstValores
            // 
            this.lstValores.FormattingEnabled = true;
            this.lstValores.Location = new System.Drawing.Point(12, 76);
            this.lstValores.Name = "lstValores";
            this.lstValores.Size = new System.Drawing.Size(216, 69);
            this.lstValores.TabIndex = 1;
            // 
            // nudArabico
            // 
            this.nudArabico.Location = new System.Drawing.Point(128, 27);
            this.nudArabico.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudArabico.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudArabico.Name = "nudArabico";
            this.nudArabico.Size = new System.Drawing.Size(100, 20);
            this.nudArabico.TabIndex = 2;
            this.nudArabico.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRomanoArabico
            // 
            this.btnRomanoArabico.BackColor = System.Drawing.Color.Black;
            this.btnRomanoArabico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRomanoArabico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRomanoArabico.Location = new System.Drawing.Point(12, 167);
            this.btnRomanoArabico.Name = "btnRomanoArabico";
            this.btnRomanoArabico.Size = new System.Drawing.Size(216, 27);
            this.btnRomanoArabico.TabIndex = 3;
            this.btnRomanoArabico.Text = "Converter de romano para arabico";
            this.btnRomanoArabico.UseVisualStyleBackColor = false;
            this.btnRomanoArabico.Click += new System.EventHandler(this.btnRomanoArabico_Click);
            // 
            // btnArabicoRomano
            // 
            this.btnArabicoRomano.BackColor = System.Drawing.Color.Black;
            this.btnArabicoRomano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArabicoRomano.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnArabicoRomano.Location = new System.Drawing.Point(12, 210);
            this.btnArabicoRomano.Name = "btnArabicoRomano";
            this.btnArabicoRomano.Size = new System.Drawing.Size(216, 27);
            this.btnArabicoRomano.TabIndex = 4;
            this.btnArabicoRomano.Text = "Converter de arabico para romano";
            this.btnArabicoRomano.UseVisualStyleBackColor = false;
            this.btnArabicoRomano.Click += new System.EventHandler(this.btnArabicoRomano_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Romanos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arabicos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(90, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(248, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArabicoRomano);
            this.Controls.Add(this.btnRomanoArabico);
            this.Controls.Add(this.nudArabico);
            this.Controls.Add(this.lstValores);
            this.Controls.Add(this.txtNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudArabico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.ListBox lstValores;
        private System.Windows.Forms.NumericUpDown nudArabico;
        private System.Windows.Forms.Button btnRomanoArabico;
        private System.Windows.Forms.Button btnArabicoRomano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

