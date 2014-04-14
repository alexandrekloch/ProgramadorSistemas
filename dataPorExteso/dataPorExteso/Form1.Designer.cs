namespace dataPorExteso
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
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.txtDataExtenso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDia
            // 
            this.nudDia.Location = new System.Drawing.Point(23, 53);
            this.nudDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(54, 20);
            this.nudDia.TabIndex = 0;
            this.nudDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.ValueChanged += new System.EventHandler(this.nudDia_ValueChanged);
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(111, 53);
            this.nudMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(54, 20);
            this.nudMes.TabIndex = 1;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.ValueChanged += new System.EventHandler(this.nudDia_ValueChanged);
            // 
            // nudAno
            // 
            this.nudAno.Location = new System.Drawing.Point(199, 53);
            this.nudAno.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(54, 20);
            this.nudAno.TabIndex = 2;
            this.nudAno.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.nudAno.ValueChanged += new System.EventHandler(this.nudDia_ValueChanged);
            // 
            // txtDataExtenso
            // 
            this.txtDataExtenso.Location = new System.Drawing.Point(23, 106);
            this.txtDataExtenso.Name = "txtDataExtenso";
            this.txtDataExtenso.Size = new System.Drawing.Size(230, 20);
            this.txtDataExtenso.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.txtDataExtenso);
            this.Controls.Add(this.nudAno);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.nudDia);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.TextBox txtDataExtenso;
    }
}

