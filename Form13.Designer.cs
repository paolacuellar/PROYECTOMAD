namespace MAD_Pantallas
{
    partial class Form13
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bGenerar = new System.Windows.Forms.Button();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.tbAnio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Para generar el reporte general de nomina es necesario que seleccione:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Regresar a Pagina Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bGenerar
            // 
            this.bGenerar.Location = new System.Drawing.Point(15, 110);
            this.bGenerar.Name = "bGenerar";
            this.bGenerar.Size = new System.Drawing.Size(169, 35);
            this.bGenerar.TabIndex = 11;
            this.bGenerar.Text = "Generar reporte General de Nomina";
            this.bGenerar.UseVisualStyleBackColor = true;
            this.bGenerar.Click += new System.EventHandler(this.bGenerar_Click);
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(16, 47);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(169, 21);
            this.cbMes.TabIndex = 10;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // tbAnio
            // 
            this.tbAnio.Location = new System.Drawing.Point(202, 48);
            this.tbAnio.Name = "tbAnio";
            this.tbAnio.Size = new System.Drawing.Size(169, 20);
            this.tbAnio.TabIndex = 16;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 150);
            this.Controls.Add(this.tbAnio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bGenerar);
            this.Controls.Add(this.cbMes);
            this.Name = "Form13";
            this.Text = "Reporte General de Nomina";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bGenerar;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.TextBox tbAnio;
    }
}