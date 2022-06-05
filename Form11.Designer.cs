
namespace MAD_Pantallas
{
    partial class Form11
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
            this.listBoxP = new System.Windows.Forms.ListBox();
            this.FechaAplicarConcepto = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.asignar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.listBoxD = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxemp = new System.Windows.Forms.ListBox();
            this.comboBoxdeptos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.btn_Calculo = new System.Windows.Forms.Button();
            this.fechaCalculo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listBoxP
            // 
            this.listBoxP.FormattingEnabled = true;
            this.listBoxP.Location = new System.Drawing.Point(12, 55);
            this.listBoxP.Name = "listBoxP";
            this.listBoxP.Size = new System.Drawing.Size(357, 147);
            this.listBoxP.TabIndex = 0;
            this.listBoxP.SelectedIndexChanged += new System.EventHandler(this.listBoxP_SelectedIndexChanged);
            // 
            // FechaAplicarConcepto
            // 
            this.FechaAplicarConcepto.Location = new System.Drawing.Point(397, 286);
            this.FechaAplicarConcepto.Name = "FechaAplicarConcepto";
            this.FechaAplicarConcepto.Size = new System.Drawing.Size(200, 20);
            this.FechaAplicarConcepto.TabIndex = 54;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(394, 270);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(220, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "Seleccionar fecha en la que se desea aplicar";
            // 
            // asignar
            // 
            this.asignar.Enabled = false;
            this.asignar.Location = new System.Drawing.Point(397, 312);
            this.asignar.Name = "asignar";
            this.asignar.Size = new System.Drawing.Size(309, 30);
            this.asignar.TabIndex = 49;
            this.asignar.Text = "Asignar ";
            this.asignar.UseVisualStyleBackColor = true;
            this.asignar.Click += new System.EventHandler(this.asignar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Lista de percepciones";
            // 
            // listBoxD
            // 
            this.listBoxD.FormattingEnabled = true;
            this.listBoxD.Location = new System.Drawing.Point(12, 226);
            this.listBoxD.Name = "listBoxD";
            this.listBoxD.Size = new System.Drawing.Size(357, 147);
            this.listBoxD.TabIndex = 55;
            this.listBoxD.SelectedIndexChanged += new System.EventHandler(this.listBoxD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Lista de deducciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Seleccione una percepción o una deducción de las listas ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Para asignar por empleado seleccione uno de los que se encuentran aqui";
            // 
            // listBoxemp
            // 
            this.listBoxemp.FormattingEnabled = true;
            this.listBoxemp.Location = new System.Drawing.Point(397, 55);
            this.listBoxemp.Name = "listBoxemp";
            this.listBoxemp.Size = new System.Drawing.Size(357, 147);
            this.listBoxemp.TabIndex = 59;
            this.listBoxemp.SelectedIndexChanged += new System.EventHandler(this.listBoxemp_SelectedIndexChanged);
            // 
            // comboBoxdeptos
            // 
            this.comboBoxdeptos.FormattingEnabled = true;
            this.comboBoxdeptos.Location = new System.Drawing.Point(397, 232);
            this.comboBoxdeptos.Name = "comboBoxdeptos";
            this.comboBoxdeptos.Size = new System.Drawing.Size(354, 21);
            this.comboBoxdeptos.TabIndex = 60;
            this.comboBoxdeptos.SelectedIndexChanged += new System.EventHandler(this.comboBoxdeptos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Para asignar por departamento seleccione uno de los que se encuentran aqui";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(35, 398);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(316, 30);
            this.Return.TabIndex = 62;
            this.Return.Text = "Regresar a menú";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // btn_Calculo
            // 
            this.btn_Calculo.Location = new System.Drawing.Point(397, 398);
            this.btn_Calculo.Name = "btn_Calculo";
            this.btn_Calculo.Size = new System.Drawing.Size(309, 30);
            this.btn_Calculo.TabIndex = 63;
            this.btn_Calculo.Text = "Calcular";
            this.btn_Calculo.UseVisualStyleBackColor = true;
            this.btn_Calculo.Click += new System.EventHandler(this.btn_Calculo_Click);
            // 
            // fechaCalculo
            // 
            this.fechaCalculo.Location = new System.Drawing.Point(397, 365);
            this.fechaCalculo.Name = "fechaCalculo";
            this.fechaCalculo.Size = new System.Drawing.Size(200, 20);
            this.fechaCalculo.TabIndex = 64;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.fechaCalculo);
            this.Controls.Add(this.btn_Calculo);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxdeptos);
            this.Controls.Add(this.listBoxemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxD);
            this.Controls.Add(this.FechaAplicarConcepto);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.asignar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listBoxP);
            this.Name = "Form11";
            this.Text = "Gestión de Nómina";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxP;
        private System.Windows.Forms.DateTimePicker FechaAplicarConcepto;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button asignar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBoxD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxemp;
        private System.Windows.Forms.ComboBox comboBoxdeptos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button btn_Calculo;
        private System.Windows.Forms.DateTimePicker fechaCalculo;
    }
}