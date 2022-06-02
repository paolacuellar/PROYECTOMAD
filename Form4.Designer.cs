
namespace MAD_Pantallas
{
    partial class Form4
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
            this.EmpleadoNombre = new System.Windows.Forms.Label();
            this.EmpleadoApellidoP = new System.Windows.Forms.Label();
            this.EmpleadoApellidoM = new System.Windows.Forms.Label();
            this.EmpleadoNacimiento = new System.Windows.Forms.Label();
            this.EmpleadoCURP = new System.Windows.Forms.Label();
            this.EmpleadoRFC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmpleadoCalle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EmpleadoPuesto = new System.Windows.Forms.Label();
            this.EmpleadoNSS = new System.Windows.Forms.Label();
            this.EmpleadoOperaciones = new System.Windows.Forms.Label();
            this.EmpleadoDepto = new System.Windows.Forms.Label();
            this.EmpleadoClave = new System.Windows.Forms.Label();
            this.Regresar1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.EmpleadoNum = new System.Windows.Forms.Label();
            this.EmpleadoColonia = new System.Windows.Forms.Label();
            this.EmpleadoMunicipio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpleadoPassword = new System.Windows.Forms.TextBox();
            this.EmpleadoCorreo = new System.Windows.Forms.TextBox();
            this.EmpleadoTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Personales ";
            // 
            // EmpleadoNombre
            // 
            this.EmpleadoNombre.AutoSize = true;
            this.EmpleadoNombre.Location = new System.Drawing.Point(12, 52);
            this.EmpleadoNombre.Name = "EmpleadoNombre";
            this.EmpleadoNombre.Size = new System.Drawing.Size(55, 13);
            this.EmpleadoNombre.TabIndex = 1;
            this.EmpleadoNombre.Text = "Nombre(s)";
            // 
            // EmpleadoApellidoP
            // 
            this.EmpleadoApellidoP.AutoSize = true;
            this.EmpleadoApellidoP.Location = new System.Drawing.Point(12, 75);
            this.EmpleadoApellidoP.Name = "EmpleadoApellidoP";
            this.EmpleadoApellidoP.Size = new System.Drawing.Size(84, 13);
            this.EmpleadoApellidoP.TabIndex = 2;
            this.EmpleadoApellidoP.Text = "Apellido Paterno";
            // 
            // EmpleadoApellidoM
            // 
            this.EmpleadoApellidoM.AutoSize = true;
            this.EmpleadoApellidoM.Location = new System.Drawing.Point(12, 99);
            this.EmpleadoApellidoM.Name = "EmpleadoApellidoM";
            this.EmpleadoApellidoM.Size = new System.Drawing.Size(86, 13);
            this.EmpleadoApellidoM.TabIndex = 3;
            this.EmpleadoApellidoM.Text = "Apellido Materno";
            // 
            // EmpleadoNacimiento
            // 
            this.EmpleadoNacimiento.AutoSize = true;
            this.EmpleadoNacimiento.Location = new System.Drawing.Point(12, 119);
            this.EmpleadoNacimiento.Name = "EmpleadoNacimiento";
            this.EmpleadoNacimiento.Size = new System.Drawing.Size(108, 13);
            this.EmpleadoNacimiento.TabIndex = 4;
            this.EmpleadoNacimiento.Text = "Fecha de Nacimiento";
            this.EmpleadoNacimiento.Click += new System.EventHandler(this.label5_Click);
            // 
            // EmpleadoCURP
            // 
            this.EmpleadoCURP.AutoSize = true;
            this.EmpleadoCURP.Location = new System.Drawing.Point(12, 141);
            this.EmpleadoCURP.Name = "EmpleadoCURP";
            this.EmpleadoCURP.Size = new System.Drawing.Size(37, 13);
            this.EmpleadoCURP.TabIndex = 5;
            this.EmpleadoCURP.Text = "CURP";
            this.EmpleadoCURP.Click += new System.EventHandler(this.label6_Click);
            // 
            // EmpleadoRFC
            // 
            this.EmpleadoRFC.AutoSize = true;
            this.EmpleadoRFC.Location = new System.Drawing.Point(297, 220);
            this.EmpleadoRFC.Name = "EmpleadoRFC";
            this.EmpleadoRFC.Size = new System.Drawing.Size(28, 13);
            this.EmpleadoRFC.TabIndex = 6;
            this.EmpleadoRFC.Text = "RFC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Número de Telefono";
            // 
            // EmpleadoCalle
            // 
            this.EmpleadoCalle.AutoSize = true;
            this.EmpleadoCalle.Location = new System.Drawing.Point(297, 249);
            this.EmpleadoCalle.Name = "EmpleadoCalle";
            this.EmpleadoCalle.Size = new System.Drawing.Size(30, 13);
            this.EmpleadoCalle.TabIndex = 8;
            this.EmpleadoCalle.Text = "Calle";
            this.EmpleadoCalle.Click += new System.EventHandler(this.EmpleadoDomicilio_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Correo Electrónico";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Datos de Empleado";
            // 
            // EmpleadoPuesto
            // 
            this.EmpleadoPuesto.AutoSize = true;
            this.EmpleadoPuesto.Location = new System.Drawing.Point(297, 138);
            this.EmpleadoPuesto.Name = "EmpleadoPuesto";
            this.EmpleadoPuesto.Size = new System.Drawing.Size(40, 13);
            this.EmpleadoPuesto.TabIndex = 25;
            this.EmpleadoPuesto.Text = "Puesto";
            // 
            // EmpleadoNSS
            // 
            this.EmpleadoNSS.AutoSize = true;
            this.EmpleadoNSS.Location = new System.Drawing.Point(297, 164);
            this.EmpleadoNSS.Name = "EmpleadoNSS";
            this.EmpleadoNSS.Size = new System.Drawing.Size(128, 13);
            this.EmpleadoNSS.TabIndex = 24;
            this.EmpleadoNSS.Text = "Número de Seguro Social";
            // 
            // EmpleadoOperaciones
            // 
            this.EmpleadoOperaciones.AutoSize = true;
            this.EmpleadoOperaciones.Location = new System.Drawing.Point(297, 195);
            this.EmpleadoOperaciones.Name = "EmpleadoOperaciones";
            this.EmpleadoOperaciones.Size = new System.Drawing.Size(158, 13);
            this.EmpleadoOperaciones.TabIndex = 23;
            this.EmpleadoOperaciones.Text = "Fecha de Inicio de Operaciones";
            // 
            // EmpleadoDepto
            // 
            this.EmpleadoDepto.AutoSize = true;
            this.EmpleadoDepto.Location = new System.Drawing.Point(295, 116);
            this.EmpleadoDepto.Name = "EmpleadoDepto";
            this.EmpleadoDepto.Size = new System.Drawing.Size(74, 13);
            this.EmpleadoDepto.TabIndex = 22;
            this.EmpleadoDepto.Text = "Departamento";
            // 
            // EmpleadoClave
            // 
            this.EmpleadoClave.AutoSize = true;
            this.EmpleadoClave.Location = new System.Drawing.Point(297, 52);
            this.EmpleadoClave.Name = "EmpleadoClave";
            this.EmpleadoClave.Size = new System.Drawing.Size(99, 13);
            this.EmpleadoClave.TabIndex = 20;
            this.EmpleadoClave.Text = "Clave de Empleado";
            // 
            // Regresar1
            // 
            this.Regresar1.Location = new System.Drawing.Point(300, 343);
            this.Regresar1.Name = "Regresar1";
            this.Regresar1.Size = new System.Drawing.Size(180, 34);
            this.Regresar1.TabIndex = 36;
            this.Regresar1.Text = "Regresar a Pagina Principal";
            this.Regresar1.UseVisualStyleBackColor = true;
            this.Regresar1.Click += new System.EventHandler(this.Regresar1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 34);
            this.button2.TabIndex = 37;
            this.button2.Text = "Actualizar Información";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(220, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "*Solo en caso de haber cambiado algún dato";
            // 
            // EmpleadoNum
            // 
            this.EmpleadoNum.AutoSize = true;
            this.EmpleadoNum.Location = new System.Drawing.Point(297, 274);
            this.EmpleadoNum.Name = "EmpleadoNum";
            this.EmpleadoNum.Size = new System.Drawing.Size(44, 13);
            this.EmpleadoNum.TabIndex = 39;
            this.EmpleadoNum.Text = "Numero";
            // 
            // EmpleadoColonia
            // 
            this.EmpleadoColonia.AutoSize = true;
            this.EmpleadoColonia.Location = new System.Drawing.Point(297, 298);
            this.EmpleadoColonia.Name = "EmpleadoColonia";
            this.EmpleadoColonia.Size = new System.Drawing.Size(42, 13);
            this.EmpleadoColonia.TabIndex = 40;
            this.EmpleadoColonia.Text = "Colonia";
            // 
            // EmpleadoMunicipio
            // 
            this.EmpleadoMunicipio.AutoSize = true;
            this.EmpleadoMunicipio.Location = new System.Drawing.Point(297, 320);
            this.EmpleadoMunicipio.Name = "EmpleadoMunicipio";
            this.EmpleadoMunicipio.Size = new System.Drawing.Size(52, 13);
            this.EmpleadoMunicipio.TabIndex = 41;
            this.EmpleadoMunicipio.Text = "Municipio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Password";
            // 
            // EmpleadoPassword
            // 
            this.EmpleadoPassword.Location = new System.Drawing.Point(298, 91);
            this.EmpleadoPassword.Name = "EmpleadoPassword";
            this.EmpleadoPassword.Size = new System.Drawing.Size(179, 20);
            this.EmpleadoPassword.TabIndex = 43;
            // 
            // EmpleadoCorreo
            // 
            this.EmpleadoCorreo.Location = new System.Drawing.Point(12, 224);
            this.EmpleadoCorreo.Name = "EmpleadoCorreo";
            this.EmpleadoCorreo.Size = new System.Drawing.Size(179, 20);
            this.EmpleadoCorreo.TabIndex = 19;
            // 
            // EmpleadoTelefono
            // 
            this.EmpleadoTelefono.Location = new System.Drawing.Point(12, 179);
            this.EmpleadoTelefono.Name = "EmpleadoTelefono";
            this.EmpleadoTelefono.Size = new System.Drawing.Size(179, 20);
            this.EmpleadoTelefono.TabIndex = 18;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 387);
            this.Controls.Add(this.EmpleadoPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmpleadoMunicipio);
            this.Controls.Add(this.EmpleadoColonia);
            this.Controls.Add(this.EmpleadoNum);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Regresar1);
            this.Controls.Add(this.EmpleadoPuesto);
            this.Controls.Add(this.EmpleadoNSS);
            this.Controls.Add(this.EmpleadoOperaciones);
            this.Controls.Add(this.EmpleadoDepto);
            this.Controls.Add(this.EmpleadoClave);
            this.Controls.Add(this.EmpleadoCorreo);
            this.Controls.Add(this.EmpleadoTelefono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EmpleadoCalle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmpleadoRFC);
            this.Controls.Add(this.EmpleadoCURP);
            this.Controls.Add(this.EmpleadoNacimiento);
            this.Controls.Add(this.EmpleadoApellidoM);
            this.Controls.Add(this.EmpleadoApellidoP);
            this.Controls.Add(this.EmpleadoNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmpleadoNombre;
        private System.Windows.Forms.Label EmpleadoApellidoP;
        private System.Windows.Forms.Label EmpleadoNacimiento;
        private System.Windows.Forms.Label EmpleadoCURP;
        private System.Windows.Forms.Label EmpleadoRFC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EmpleadoCalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label EmpleadoPuesto;
        private System.Windows.Forms.Label EmpleadoNSS;
        private System.Windows.Forms.Label EmpleadoOperaciones;
        private System.Windows.Forms.Label EmpleadoDepto;
        private System.Windows.Forms.Label EmpleadoClave;
        private System.Windows.Forms.Button Regresar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label EmpleadoNum;
        private System.Windows.Forms.Label EmpleadoColonia;
        private System.Windows.Forms.Label EmpleadoMunicipio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmpleadoPassword;
        private System.Windows.Forms.TextBox EmpleadoCorreo;
        private System.Windows.Forms.TextBox EmpleadoTelefono;
        private System.Windows.Forms.Label EmpleadoApellidoM;
    }
}