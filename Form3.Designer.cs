
namespace MAD_Pantallas
{
    partial class Form3
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
            this.SueldoConsulta = new System.Windows.Forms.Button();
            this.NominaConsulta = new System.Windows.Forms.Button();
            this.perfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Salir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SueldoConsulta
            // 
            this.SueldoConsulta.Location = new System.Drawing.Point(14, 173);
            this.SueldoConsulta.Name = "SueldoConsulta";
            this.SueldoConsulta.Size = new System.Drawing.Size(287, 40);
            this.SueldoConsulta.TabIndex = 14;
            this.SueldoConsulta.Text = "Consultar Sueldo";
            this.SueldoConsulta.UseVisualStyleBackColor = true;
            this.SueldoConsulta.Click += new System.EventHandler(this.SueldoConsulta_Click);
            // 
            // NominaConsulta
            // 
            this.NominaConsulta.Location = new System.Drawing.Point(14, 111);
            this.NominaConsulta.Name = "NominaConsulta";
            this.NominaConsulta.Size = new System.Drawing.Size(287, 40);
            this.NominaConsulta.TabIndex = 10;
            this.NominaConsulta.Text = "Consultar Nómina";
            this.NominaConsulta.UseVisualStyleBackColor = true;
            this.NominaConsulta.Click += new System.EventHandler(this.NominaConsulta_Click);
            // 
            // perfil
            // 
            this.perfil.Location = new System.Drawing.Point(14, 50);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(287, 40);
            this.perfil.TabIndex = 9;
            this.perfil.Text = "Ver perfil";
            this.perfil.UseVisualStyleBackColor = true;
            this.perfil.Click += new System.EventHandler(this.perfil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenido a la pagina principal";
            // 
            // Salir2
            // 
            this.Salir2.Location = new System.Drawing.Point(14, 396);
            this.Salir2.Name = "Salir2";
            this.Salir2.Size = new System.Drawing.Size(287, 40);
            this.Salir2.TabIndex = 16;
            this.Salir2.Text = "Cerrar Sesión";
            this.Salir2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 448);
            this.Controls.Add(this.Salir2);
            this.Controls.Add(this.SueldoConsulta);
            this.Controls.Add(this.NominaConsulta);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Pagina Principal de Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SueldoConsulta;
        private System.Windows.Forms.Button NominaConsulta;
        private System.Windows.Forms.Button perfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Salir2;
    }
}