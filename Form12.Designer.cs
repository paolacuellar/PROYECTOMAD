namespace MAD_Pantallas
{
    partial class Form12
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
            this.cbDeptos = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.bGenerar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAnio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbDeptos
            // 
            this.cbDeptos.FormattingEnabled = true;
            this.cbDeptos.Location = new System.Drawing.Point(12, 50);
            this.cbDeptos.Name = "cbDeptos";
            this.cbDeptos.Size = new System.Drawing.Size(169, 21);
            this.cbDeptos.TabIndex = 0;
            this.cbDeptos.SelectedIndexChanged += new System.EventHandler(this.cbDeptos_SelectedIndexChanged);
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(198, 50);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(169, 21);
            this.cbMes.TabIndex = 2;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // bGenerar
            // 
            this.bGenerar.Location = new System.Drawing.Point(12, 110);
            this.bGenerar.Name = "bGenerar";
            this.bGenerar.Size = new System.Drawing.Size(169, 35);
            this.bGenerar.TabIndex = 3;
            this.bGenerar.Text = "Generar reporte Headcounter";
            this.bGenerar.UseVisualStyleBackColor = true;
            this.bGenerar.Click += new System.EventHandler(this.bGenerar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Regresar a Pagina Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Para generar el reporte headcounter es necesario que seleccione:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Año:";
            // 
            // tbAnio
            // 
            this.tbAnio.Enabled = false;
            this.tbAnio.Location = new System.Drawing.Point(384, 51);
            this.tbAnio.Name = "tbAnio";
            this.tbAnio.Size = new System.Drawing.Size(169, 20);
            this.tbAnio.TabIndex = 9;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 157);
            this.Controls.Add(this.tbAnio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bGenerar);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbDeptos);
            this.Name = "Form12";
            this.Text = "Reporte Headcounter";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDeptos;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Button bGenerar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAnio;
    }
}