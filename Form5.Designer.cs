
namespace MAD_Pantallas
{
    partial class Form5
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
            this.NominaBuscar = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxPercepciones = new System.Windows.Forms.ListBox();
            this.listBoxDeducciones = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeptoSueldo = new System.Windows.Forms.Label();
            this.PuestoSueldo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Mes y el Año de la nómina que desea consultar";
            // 
            // NominaBuscar
            // 
            this.NominaBuscar.Location = new System.Drawing.Point(15, 29);
            this.NominaBuscar.Name = "NominaBuscar";
            this.NominaBuscar.Size = new System.Drawing.Size(200, 20);
            this.NominaBuscar.TabIndex = 1;
            this.NominaBuscar.ValueChanged += new System.EventHandler(this.NominaBuscar_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar Nómina";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nómina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Percepciones aplicadas este mes";
            // 
            // listBoxPercepciones
            // 
            this.listBoxPercepciones.FormattingEnabled = true;
            this.listBoxPercepciones.Location = new System.Drawing.Point(15, 164);
            this.listBoxPercepciones.Name = "listBoxPercepciones";
            this.listBoxPercepciones.Size = new System.Drawing.Size(344, 95);
            this.listBoxPercepciones.TabIndex = 5;
            // 
            // listBoxDeducciones
            // 
            this.listBoxDeducciones.FormattingEnabled = true;
            this.listBoxDeducciones.Location = new System.Drawing.Point(15, 282);
            this.listBoxDeducciones.Name = "listBoxDeducciones";
            this.listBoxDeducciones.Size = new System.Drawing.Size(344, 95);
            this.listBoxDeducciones.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Deducciones aplicadas este mes";
            // 
            // DeptoSueldo
            // 
            this.DeptoSueldo.AutoSize = true;
            this.DeptoSueldo.Location = new System.Drawing.Point(15, 396);
            this.DeptoSueldo.Name = "DeptoSueldo";
            this.DeptoSueldo.Size = new System.Drawing.Size(125, 13);
            this.DeptoSueldo.TabIndex = 8;
            this.DeptoSueldo.Text = "Sueldo de Departamento";
            // 
            // PuestoSueldo
            // 
            this.PuestoSueldo.AutoSize = true;
            this.PuestoSueldo.Location = new System.Drawing.Point(15, 425);
            this.PuestoSueldo.Name = "PuestoSueldo";
            this.PuestoSueldo.Size = new System.Drawing.Size(91, 13);
            this.PuestoSueldo.TabIndex = 10;
            this.PuestoSueldo.Text = "Sueldo de Puesto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 24);
            this.button2.TabIndex = 12;
            this.button2.Text = "Regresar a Pagina Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 24);
            this.button3.TabIndex = 13;
            this.button3.Text = "Generar Recibo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 520);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PuestoSueldo);
            this.Controls.Add(this.DeptoSueldo);
            this.Controls.Add(this.listBoxDeducciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxPercepciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NominaBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Consultar Nómina";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker NominaBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxPercepciones;
        private System.Windows.Forms.ListBox listBoxDeducciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DeptoSueldo;
        private System.Windows.Forms.Label PuestoSueldo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}