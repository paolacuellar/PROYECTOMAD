
namespace MAD_Pantallas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Verificarcuenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpleadoNum = new System.Windows.Forms.TextBox();
            this.EmpleadoPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Verificarcuenta
            // 
            this.Verificarcuenta.Location = new System.Drawing.Point(92, 238);
            this.Verificarcuenta.Name = "Verificarcuenta";
            this.Verificarcuenta.Size = new System.Drawing.Size(162, 41);
            this.Verificarcuenta.TabIndex = 0;
            this.Verificarcuenta.Text = "Iniciar sesión";
            this.Verificarcuenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número del Empleado";
            // 
            // EmpleadoNum
            // 
            this.EmpleadoNum.Location = new System.Drawing.Point(92, 64);
            this.EmpleadoNum.Name = "EmpleadoNum";
            this.EmpleadoNum.Size = new System.Drawing.Size(162, 20);
            this.EmpleadoNum.TabIndex = 2;
            // 
            // EmpleadoPass
            // 
            this.EmpleadoPass.Location = new System.Drawing.Point(92, 161);
            this.EmpleadoPass.Name = "EmpleadoPass";
            this.EmpleadoPass.Size = new System.Drawing.Size(162, 20);
            this.EmpleadoPass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 336);
            this.Controls.Add(this.EmpleadoPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpleadoNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Verificarcuenta);
            this.Name = "Form1";
            this.Text = "Inicio de Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Verificarcuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpleadoNum;
        private System.Windows.Forms.TextBox EmpleadoPass;
        private System.Windows.Forms.Label label2;
    }
}

