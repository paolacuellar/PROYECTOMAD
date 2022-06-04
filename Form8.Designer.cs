
namespace MAD_Pantallas
{
    partial class Form8
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
            this.DeptoDelete = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.DeptoUpdate = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.DeptoAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxDeptos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deptoN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deptoSB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.deptoC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeptoDelete
            // 
            this.DeptoDelete.Location = new System.Drawing.Point(388, 317);
            this.DeptoDelete.Name = "DeptoDelete";
            this.DeptoDelete.Size = new System.Drawing.Size(164, 23);
            this.DeptoDelete.TabIndex = 82;
            this.DeptoDelete.Text = "Eliminar información";
            this.DeptoDelete.UseVisualStyleBackColor = true;
            this.DeptoDelete.Click += new System.EventHandler(this.DeptoDelete_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(385, 282);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(170, 13);
            this.label24.TabIndex = 78;
            this.label24.Text = "Eliminar datos de un departamento";
            // 
            // DeptoUpdate
            // 
            this.DeptoUpdate.Location = new System.Drawing.Point(387, 168);
            this.DeptoUpdate.Name = "DeptoUpdate";
            this.DeptoUpdate.Size = new System.Drawing.Size(164, 23);
            this.DeptoUpdate.TabIndex = 77;
            this.DeptoUpdate.Text = "Guardar nueva información";
            this.DeptoUpdate.UseVisualStyleBackColor = true;
            this.DeptoUpdate.Click += new System.EventHandler(this.DeptoUpdate_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(373, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 13);
            this.label19.TabIndex = 74;
            this.label19.Text = "Seleccionar un departamento de la lista";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(390, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 13);
            this.label20.TabIndex = 73;
            this.label20.Text = "Editar datos de un departamento";
            // 
            // DeptoAdd
            // 
            this.DeptoAdd.Location = new System.Drawing.Point(433, 81);
            this.DeptoAdd.Name = "DeptoAdd";
            this.DeptoAdd.Size = new System.Drawing.Size(75, 23);
            this.DeptoAdd.TabIndex = 72;
            this.DeptoAdd.Text = "Agregar";
            this.DeptoAdd.UseVisualStyleBackColor = true;
            this.DeptoAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "*Ingresar todos los datos que se piden a su derecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Agregar nuevo departamento";
            // 
            // listBoxDeptos
            // 
            this.listBoxDeptos.FormattingEnabled = true;
            this.listBoxDeptos.Location = new System.Drawing.Point(4, 25);
            this.listBoxDeptos.Name = "listBoxDeptos";
            this.listBoxDeptos.Size = new System.Drawing.Size(334, 407);
            this.listBoxDeptos.TabIndex = 69;
            this.listBoxDeptos.SelectedIndexChanged += new System.EventHandler(this.listBoxDeptos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Departamentos ya existentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Datos del departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Clave del departamento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // deptoN
            // 
            this.deptoN.Location = new System.Drawing.Point(614, 185);
            this.deptoN.Name = "deptoN";
            this.deptoN.Size = new System.Drawing.Size(179, 20);
            this.deptoN.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Nombre del Departamento";
            // 
            // deptoSB
            // 
            this.deptoSB.Location = new System.Drawing.Point(614, 239);
            this.deptoSB.Name = "deptoSB";
            this.deptoSB.Size = new System.Drawing.Size(179, 20);
            this.deptoSB.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Sueldo Base";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 42);
            this.button2.TabIndex = 90;
            this.button2.Text = "Regresar a Pagina Principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Seleccionar un departamento de la lista";
            // 
            // deptoC
            // 
            this.deptoC.AutoSize = true;
            this.deptoC.Location = new System.Drawing.Point(614, 139);
            this.deptoC.Name = "deptoC";
            this.deptoC.Size = new System.Drawing.Size(119, 13);
            this.deptoC.TabIndex = 92;
            this.deptoC.Text = "Clave del departamento";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.deptoC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deptoSB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deptoN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeptoDelete);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.DeptoUpdate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.DeptoAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxDeptos);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Gestión de Departamentos";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeptoDelete;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button DeptoUpdate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button DeptoAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxDeptos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deptoN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deptoSB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label deptoC;
    }
}