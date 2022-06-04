
namespace MAD_Pantallas
{
    partial class Form2
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
            this.perfil = new System.Windows.Forms.Button();
            this.NominaConsulta = new System.Windows.Forms.Button();
            this.EmpleadosGestion = new System.Windows.Forms.Button();
            this.DepartamentosGestion = new System.Windows.Forms.Button();
            this.PeryDed = new System.Windows.Forms.Button();
            this.PuestosGestion = new System.Windows.Forms.Button();
            this.Organigrama = new System.Windows.Forms.Button();
            this.Salir1 = new System.Windows.Forms.Button();
            this.NominaGestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a la pagina principal";
            // 
            // perfil
            // 
            this.perfil.Location = new System.Drawing.Point(12, 49);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(208, 40);
            this.perfil.TabIndex = 1;
            this.perfil.Text = "Ver perfil";
            this.perfil.UseVisualStyleBackColor = true;
            this.perfil.Click += new System.EventHandler(this.perfil_Click);
            // 
            // NominaConsulta
            // 
            this.NominaConsulta.Location = new System.Drawing.Point(12, 110);
            this.NominaConsulta.Name = "NominaConsulta";
            this.NominaConsulta.Size = new System.Drawing.Size(208, 40);
            this.NominaConsulta.TabIndex = 2;
            this.NominaConsulta.Text = "Consultar Nómina";
            this.NominaConsulta.UseVisualStyleBackColor = true;
            this.NominaConsulta.Click += new System.EventHandler(this.NominaConsulta_Click);
            // 
            // EmpleadosGestion
            // 
            this.EmpleadosGestion.Location = new System.Drawing.Point(248, 49);
            this.EmpleadosGestion.Name = "EmpleadosGestion";
            this.EmpleadosGestion.Size = new System.Drawing.Size(208, 40);
            this.EmpleadosGestion.TabIndex = 3;
            this.EmpleadosGestion.Text = "Gestión de Empleados";
            this.EmpleadosGestion.UseVisualStyleBackColor = true;
            this.EmpleadosGestion.Click += new System.EventHandler(this.EmpleadosGestion_Click);
            // 
            // DepartamentosGestion
            // 
            this.DepartamentosGestion.Location = new System.Drawing.Point(248, 110);
            this.DepartamentosGestion.Name = "DepartamentosGestion";
            this.DepartamentosGestion.Size = new System.Drawing.Size(208, 40);
            this.DepartamentosGestion.TabIndex = 4;
            this.DepartamentosGestion.Text = "Gestión de Departamentos";
            this.DepartamentosGestion.UseVisualStyleBackColor = true;
            this.DepartamentosGestion.Click += new System.EventHandler(this.DepartamentosGestion_Click);
            // 
            // PeryDed
            // 
            this.PeryDed.Location = new System.Drawing.Point(248, 233);
            this.PeryDed.Name = "PeryDed";
            this.PeryDed.Size = new System.Drawing.Size(208, 40);
            this.PeryDed.TabIndex = 6;
            this.PeryDed.Text = "Percepciones y Deducciones";
            this.PeryDed.UseVisualStyleBackColor = true;
            this.PeryDed.Click += new System.EventHandler(this.PeryDed_Click);
            // 
            // PuestosGestion
            // 
            this.PuestosGestion.Location = new System.Drawing.Point(248, 172);
            this.PuestosGestion.Name = "PuestosGestion";
            this.PuestosGestion.Size = new System.Drawing.Size(208, 40);
            this.PuestosGestion.TabIndex = 5;
            this.PuestosGestion.Text = "Gestión de Puestos";
            this.PuestosGestion.UseVisualStyleBackColor = true;
            this.PuestosGestion.Click += new System.EventHandler(this.PuestosGestion_Click);
            // 
            // Organigrama
            // 
            this.Organigrama.Location = new System.Drawing.Point(12, 233);
            this.Organigrama.Name = "Organigrama";
            this.Organigrama.Size = new System.Drawing.Size(208, 40);
            this.Organigrama.TabIndex = 7;
            this.Organigrama.Text = "Organigrama de la Empresa";
            this.Organigrama.UseVisualStyleBackColor = true;
            // 
            // Salir1
            // 
            this.Salir1.Location = new System.Drawing.Point(248, 398);
            this.Salir1.Name = "Salir1";
            this.Salir1.Size = new System.Drawing.Size(208, 40);
            this.Salir1.TabIndex = 8;
            this.Salir1.Text = "Cerrar Sesión";
            this.Salir1.UseVisualStyleBackColor = true;
            // 
            // NominaGestion
            // 
            this.NominaGestion.Location = new System.Drawing.Point(12, 172);
            this.NominaGestion.Name = "NominaGestion";
            this.NominaGestion.Size = new System.Drawing.Size(208, 40);
            this.NominaGestion.TabIndex = 9;
            this.NominaGestion.Text = "Percepciones y Deducciones";
            this.NominaGestion.UseVisualStyleBackColor = true;
            this.NominaGestion.Click += new System.EventHandler(this.NominaGestion_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.NominaGestion);
            this.Controls.Add(this.Salir1);
            this.Controls.Add(this.Organigrama);
            this.Controls.Add(this.PeryDed);
            this.Controls.Add(this.PuestosGestion);
            this.Controls.Add(this.DepartamentosGestion);
            this.Controls.Add(this.EmpleadosGestion);
            this.Controls.Add(this.NominaConsulta);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Pagina principal de Gerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button perfil;
        private System.Windows.Forms.Button NominaConsulta;
        private System.Windows.Forms.Button EmpleadosGestion;
        private System.Windows.Forms.Button DepartamentosGestion;
        private System.Windows.Forms.Button PeryDed;
        private System.Windows.Forms.Button PuestosGestion;
        private System.Windows.Forms.Button Organigrama;
        private System.Windows.Forms.Button Salir1;
        private System.Windows.Forms.Button NominaGestion;
    }
}