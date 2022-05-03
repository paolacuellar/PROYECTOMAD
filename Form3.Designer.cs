
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
            this.PeryDed = new System.Windows.Forms.Button();
            this.NominaConsulta = new System.Windows.Forms.Button();
            this.perfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Salir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeryDed
            // 
            this.PeryDed.Location = new System.Drawing.Point(14, 173);
            this.PeryDed.Name = "PeryDed";
            this.PeryDed.Size = new System.Drawing.Size(287, 40);
            this.PeryDed.TabIndex = 14;
            this.PeryDed.Text = "Consultar Sueldo";
            this.PeryDed.UseVisualStyleBackColor = true;
            // 
            // NominaConsulta
            // 
            this.NominaConsulta.Location = new System.Drawing.Point(14, 111);
            this.NominaConsulta.Name = "NominaConsulta";
            this.NominaConsulta.Size = new System.Drawing.Size(287, 40);
            this.NominaConsulta.TabIndex = 10;
            this.NominaConsulta.Text = "Consultar Nómina";
            this.NominaConsulta.UseVisualStyleBackColor = true;
            // 
            // perfil
            // 
            this.perfil.Location = new System.Drawing.Point(14, 50);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(287, 40);
            this.perfil.TabIndex = 9;
            this.perfil.Text = "Ver perfil";
            this.perfil.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.PeryDed);
            this.Controls.Add(this.NominaConsulta);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Pagina Principal de Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PeryDed;
        private System.Windows.Forms.Button NominaConsulta;
        private System.Windows.Forms.Button perfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Salir2;
    }
}