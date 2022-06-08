
namespace MAD_Pantallas
{
    partial class Form10
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CSPuesto = new System.Windows.Forms.Label();
            this.CSDepto = new System.Windows.Forms.Label();
            this.CSPuestoSueldo = new System.Windows.Forms.Label();
            this.CSDeptoSueldo = new System.Windows.Forms.Label();
            this.CSsueldo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Sueldo Diario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "Nivel Salarial por puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Sueldo por departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Puesto:";
            // 
            // CSPuesto
            // 
            this.CSPuesto.AutoSize = true;
            this.CSPuesto.Location = new System.Drawing.Point(61, 112);
            this.CSPuesto.Name = "CSPuesto";
            this.CSPuesto.Size = new System.Drawing.Size(35, 13);
            this.CSPuesto.TabIndex = 98;
            this.CSPuesto.Text = "label6";
            // 
            // CSDepto
            // 
            this.CSDepto.AutoSize = true;
            this.CSDepto.Location = new System.Drawing.Point(96, 21);
            this.CSDepto.Name = "CSDepto";
            this.CSDepto.Size = new System.Drawing.Size(35, 13);
            this.CSDepto.TabIndex = 99;
            this.CSDepto.Text = "label7";
            // 
            // CSPuestoSueldo
            // 
            this.CSPuestoSueldo.AutoSize = true;
            this.CSPuestoSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CSPuestoSueldo.Location = new System.Drawing.Point(21, 156);
            this.CSPuestoSueldo.Name = "CSPuestoSueldo";
            this.CSPuestoSueldo.Size = new System.Drawing.Size(37, 15);
            this.CSPuestoSueldo.TabIndex = 100;
            this.CSPuestoSueldo.Text = "label8";
            // 
            // CSDeptoSueldo
            // 
            this.CSDeptoSueldo.AutoSize = true;
            this.CSDeptoSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CSDeptoSueldo.Location = new System.Drawing.Point(21, 69);
            this.CSDeptoSueldo.Name = "CSDeptoSueldo";
            this.CSDeptoSueldo.Size = new System.Drawing.Size(37, 15);
            this.CSDeptoSueldo.TabIndex = 101;
            this.CSDeptoSueldo.Text = "label9";
            // 
            // CSsueldo
            // 
            this.CSsueldo.AutoSize = true;
            this.CSsueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CSsueldo.Location = new System.Drawing.Point(21, 236);
            this.CSsueldo.Name = "CSsueldo";
            this.CSsueldo.Size = new System.Drawing.Size(43, 15);
            this.CSsueldo.TabIndex = 102;
            this.CSsueldo.Text = "label10";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 42);
            this.button2.TabIndex = 103;
            this.button2.Text = "Regresar a Pagina Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 361);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CSsueldo);
            this.Controls.Add(this.CSDeptoSueldo);
            this.Controls.Add(this.CSPuestoSueldo);
            this.Controls.Add(this.CSDepto);
            this.Controls.Add(this.CSPuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form10";
            this.Text = "Consultar Sueldo";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CSPuesto;
        private System.Windows.Forms.Label CSDepto;
        private System.Windows.Forms.Label CSPuestoSueldo;
        private System.Windows.Forms.Label CSDeptoSueldo;
        private System.Windows.Forms.Label CSsueldo;
        private System.Windows.Forms.Button button2;
    }
}