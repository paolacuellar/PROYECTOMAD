
namespace MAD_Pantallas
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.MotivoConcepto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboOp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CantidadConcepto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxP = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxD = new System.Windows.Forms.ListBox();
            this.btnAddConcepto = new System.Windows.Forms.Button();
            this.esPorcentajeConcepto = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Percepciones y Deducciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MotivoConcepto
            // 
            this.MotivoConcepto.Location = new System.Drawing.Point(31, 135);
            this.MotivoConcepto.Name = "MotivoConcepto";
            this.MotivoConcepto.Size = new System.Drawing.Size(171, 20);
            this.MotivoConcepto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Asignar Motivo";
            // 
            // comboOp
            // 
            this.comboOp.FormattingEnabled = true;
            this.comboOp.Location = new System.Drawing.Point(31, 74);
            this.comboOp.Name = "comboOp";
            this.comboOp.Size = new System.Drawing.Size(171, 21);
            this.comboOp.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Elegir una opción";
            // 
            // CantidadConcepto
            // 
            this.CantidadConcepto.Location = new System.Drawing.Point(31, 205);
            this.CantidadConcepto.Name = "CantidadConcepto";
            this.CantidadConcepto.Size = new System.Drawing.Size(171, 20);
            this.CantidadConcepto.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Asignar Cantidad";
            // 
            // listBoxP
            // 
            this.listBoxP.FormattingEnabled = true;
            this.listBoxP.Location = new System.Drawing.Point(263, 22);
            this.listBoxP.Name = "listBoxP";
            this.listBoxP.Size = new System.Drawing.Size(394, 147);
            this.listBoxP.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Percepciones ya existentes";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Deducciones ya existentes";
            // 
            // listBoxD
            // 
            this.listBoxD.FormattingEnabled = true;
            this.listBoxD.Location = new System.Drawing.Point(263, 197);
            this.listBoxD.Name = "listBoxD";
            this.listBoxD.Size = new System.Drawing.Size(394, 147);
            this.listBoxD.TabIndex = 15;
            // 
            // btnAddConcepto
            // 
            this.btnAddConcepto.Location = new System.Drawing.Point(31, 284);
            this.btnAddConcepto.Name = "btnAddConcepto";
            this.btnAddConcepto.Size = new System.Drawing.Size(171, 42);
            this.btnAddConcepto.TabIndex = 30;
            this.btnAddConcepto.Text = "Agregar";
            this.btnAddConcepto.UseVisualStyleBackColor = true;
            this.btnAddConcepto.Click += new System.EventHandler(this.button1_Click);
            // 
            // esPorcentajeConcepto
            // 
            this.esPorcentajeConcepto.AutoSize = true;
            this.esPorcentajeConcepto.Location = new System.Drawing.Point(34, 236);
            this.esPorcentajeConcepto.Name = "esPorcentajeConcepto";
            this.esPorcentajeConcepto.Size = new System.Drawing.Size(91, 17);
            this.esPorcentajeConcepto.TabIndex = 44;
            this.esPorcentajeConcepto.Text = "Es porcentaje";
            this.esPorcentajeConcepto.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 29);
            this.button2.TabIndex = 31;
            this.button2.Text = "Regresar a Pagina Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 420);
            this.Controls.Add(this.esPorcentajeConcepto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddConcepto);
            this.Controls.Add(this.listBoxD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxP);
            this.Controls.Add(this.CantidadConcepto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboOp);
            this.Controls.Add(this.MotivoConcepto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Manejo de Percepciones y Deducciones";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MotivoConcepto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboOp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CantidadConcepto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxD;
        private System.Windows.Forms.Button btnAddConcepto;
        private System.Windows.Forms.CheckBox esPorcentajeConcepto;
        private System.Windows.Forms.Button button2;
    }
}