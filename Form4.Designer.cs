
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpleadoNacimiento = new System.Windows.Forms.Label();
            this.EmpleadoCURP = new System.Windows.Forms.Label();
            this.EmpleadoRFC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmpleadoCalle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EmpleadoNombre = new System.Windows.Forms.TextBox();
            this.EmpleadoApellidoP = new System.Windows.Forms.TextBox();
            this.EmpleadoApellidoM = new System.Windows.Forms.TextBox();
            this.EmpleadoTelefono = new System.Windows.Forms.TextBox();
            this.EmpleadoCorreo = new System.Windows.Forms.TextBox();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno";
            // 
            // EmpleadoNacimiento
            // 
            this.EmpleadoNacimiento.AutoSize = true;
            this.EmpleadoNacimiento.Location = new System.Drawing.Point(12, 214);
            this.EmpleadoNacimiento.Name = "EmpleadoNacimiento";
            this.EmpleadoNacimiento.Size = new System.Drawing.Size(108, 13);
            this.EmpleadoNacimiento.TabIndex = 4;
            this.EmpleadoNacimiento.Text = "Fecha de Nacimiento";
            this.EmpleadoNacimiento.Click += new System.EventHandler(this.label5_Click);
            // 
            // EmpleadoCURP
            // 
            this.EmpleadoCURP.AutoSize = true;
            this.EmpleadoCURP.Location = new System.Drawing.Point(12, 271);
            this.EmpleadoCURP.Name = "EmpleadoCURP";
            this.EmpleadoCURP.Size = new System.Drawing.Size(37, 13);
            this.EmpleadoCURP.TabIndex = 5;
            this.EmpleadoCURP.Text = "CURP";
            this.EmpleadoCURP.Click += new System.EventHandler(this.label6_Click);
            // 
            // EmpleadoRFC
            // 
            this.EmpleadoRFC.AutoSize = true;
            this.EmpleadoRFC.Location = new System.Drawing.Point(297, 242);
            this.EmpleadoRFC.Name = "EmpleadoRFC";
            this.EmpleadoRFC.Size = new System.Drawing.Size(28, 13);
            this.EmpleadoRFC.TabIndex = 6;
            this.EmpleadoRFC.Text = "RFC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Número de Telefono";
            // 
            // EmpleadoCalle
            // 
            this.EmpleadoCalle.AutoSize = true;
            this.EmpleadoCalle.Location = new System.Drawing.Point(297, 271);
            this.EmpleadoCalle.Name = "EmpleadoCalle";
            this.EmpleadoCalle.Size = new System.Drawing.Size(30, 13);
            this.EmpleadoCalle.TabIndex = 8;
            this.EmpleadoCalle.Text = "Calle";
            this.EmpleadoCalle.Click += new System.EventHandler(this.EmpleadoDomicilio_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 376);
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
            // EmpleadoNombre
            // 
            this.EmpleadoNombre.Location = new System.Drawing.Point(12, 73);
            this.EmpleadoNombre.Name = "EmpleadoNombre";
            this.EmpleadoNombre.Size = new System.Drawing.Size(179, 20);
            this.EmpleadoNombre.TabIndex = 11;
            // 
            // EmpleadoApellidoP
            // 
            this.EmpleadoApellidoP.Location = new System.Drawing.Point(12, 128);
            this.EmpleadoApellidoP.Name = "EmpleadoApellidoP";
            this.EmpleadoApellidoP.Size = new System.Drawing.Size(179, 20);
            this.EmpleadoApellidoP.TabIndex = 12;
            // 
            // EmpleadoApellidoM
            // 
            this.EmpleadoApellidoM.Location = new System.Drawing.Point(12, 178);
            this.EmpleadoApellidoM.Name = "EmpleadoApellidoM";
            this.EmpleadoApellidoM.Size = new System.Drawing.Size(179, 20);
            this.EmpleadoApellidoM.TabIndex = 13;
            // 
            // EmpleadoTelefono
            // 
            this.EmpleadoTelefono.Location = new System.Drawing.Point(12, 333);
            this.EmpleadoTelefono.Name = "EmpleadoTelefono";
            this.EmpleadoTelefono.Size = new System.Drawing.Size(179, 20);
            this.EmpleadoTelefono.TabIndex = 18;
            // 
            // EmpleadoCorreo
            // 
            this.EmpleadoCorreo.Location = new System.Drawing.Point(12, 392);
            this.EmpleadoCorreo.Name = "EmpleadoCorreo";
            this.EmpleadoCorreo.Size = new System.Drawing.Size(179, 20);
            this.EmpleadoCorreo.TabIndex = 19;
            // 
            // EmpleadoPuesto
            // 
            this.EmpleadoPuesto.AutoSize = true;
            this.EmpleadoPuesto.Location = new System.Drawing.Point(297, 157);
            this.EmpleadoPuesto.Name = "EmpleadoPuesto";
            this.EmpleadoPuesto.Size = new System.Drawing.Size(40, 13);
            this.EmpleadoPuesto.TabIndex = 25;
            this.EmpleadoPuesto.Text = "Puesto";
            // 
            // EmpleadoNSS
            // 
            this.EmpleadoNSS.AutoSize = true;
            this.EmpleadoNSS.Location = new System.Drawing.Point(297, 183);
            this.EmpleadoNSS.Name = "EmpleadoNSS";
            this.EmpleadoNSS.Size = new System.Drawing.Size(128, 13);
            this.EmpleadoNSS.TabIndex = 24;
            this.EmpleadoNSS.Text = "Número de Seguro Social";
            // 
            // EmpleadoOperaciones
            // 
            this.EmpleadoOperaciones.AutoSize = true;
            this.EmpleadoOperaciones.Location = new System.Drawing.Point(297, 214);
            this.EmpleadoOperaciones.Name = "EmpleadoOperaciones";
            this.EmpleadoOperaciones.Size = new System.Drawing.Size(158, 13);
            this.EmpleadoOperaciones.TabIndex = 23;
            this.EmpleadoOperaciones.Text = "Fecha de Inicio de Operaciones";
            // 
            // EmpleadoDepto
            // 
            this.EmpleadoDepto.AutoSize = true;
            this.EmpleadoDepto.Location = new System.Drawing.Point(297, 105);
            this.EmpleadoDepto.Name = "EmpleadoDepto";
            this.EmpleadoDepto.Size = new System.Drawing.Size(74, 13);
            this.EmpleadoDepto.TabIndex = 22;
            this.EmpleadoDepto.Text = "Departamento";
            // 
            // EmpleadoClave
            // 
            this.EmpleadoClave.AutoSize = true;
            this.EmpleadoClave.Location = new System.Drawing.Point(297, 66);
            this.EmpleadoClave.Name = "EmpleadoClave";
            this.EmpleadoClave.Size = new System.Drawing.Size(99, 13);
            this.EmpleadoClave.TabIndex = 20;
            this.EmpleadoClave.Text = "Clave de Empleado";
            // 
            // Regresar1
            // 
            this.Regresar1.Location = new System.Drawing.Point(289, 392);
            this.Regresar1.Name = "Regresar1";
            this.Regresar1.Size = new System.Drawing.Size(180, 34);
            this.Regresar1.TabIndex = 36;
            this.Regresar1.Text = "Regresar a Pagina Principal";
            this.Regresar1.UseVisualStyleBackColor = true;
            this.Regresar1.Click += new System.EventHandler(this.Regresar1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 34);
            this.button2.TabIndex = 37;
            this.button2.Text = "Actualizar Información";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 468);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(220, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "*Solo en caso de haber cambiado algún dato";
            // 
            // EmpleadoNum
            // 
            this.EmpleadoNum.AutoSize = true;
            this.EmpleadoNum.Location = new System.Drawing.Point(297, 293);
            this.EmpleadoNum.Name = "EmpleadoNum";
            this.EmpleadoNum.Size = new System.Drawing.Size(44, 13);
            this.EmpleadoNum.TabIndex = 39;
            this.EmpleadoNum.Text = "Numero";
            // 
            // EmpleadoColonia
            // 
            this.EmpleadoColonia.AutoSize = true;
            this.EmpleadoColonia.Location = new System.Drawing.Point(297, 317);
            this.EmpleadoColonia.Name = "EmpleadoColonia";
            this.EmpleadoColonia.Size = new System.Drawing.Size(42, 13);
            this.EmpleadoColonia.TabIndex = 40;
            this.EmpleadoColonia.Text = "Colonia";
            // 
            // EmpleadoMunicipio
            // 
            this.EmpleadoMunicipio.AutoSize = true;
            this.EmpleadoMunicipio.Location = new System.Drawing.Point(297, 339);
            this.EmpleadoMunicipio.Name = "EmpleadoMunicipio";
            this.EmpleadoMunicipio.Size = new System.Drawing.Size(52, 13);
            this.EmpleadoMunicipio.TabIndex = 41;
            this.EmpleadoMunicipio.Text = "Municipio";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 491);
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
            this.Controls.Add(this.EmpleadoApellidoM);
            this.Controls.Add(this.EmpleadoApellidoP);
            this.Controls.Add(this.EmpleadoNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EmpleadoCalle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmpleadoRFC);
            this.Controls.Add(this.EmpleadoCURP);
            this.Controls.Add(this.EmpleadoNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EmpleadoNacimiento;
        private System.Windows.Forms.Label EmpleadoCURP;
        private System.Windows.Forms.Label EmpleadoRFC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EmpleadoCalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EmpleadoNombre;
        private System.Windows.Forms.TextBox EmpleadoApellidoP;
        private System.Windows.Forms.TextBox EmpleadoApellidoM;
        private System.Windows.Forms.TextBox EmpleadoTelefono;
        private System.Windows.Forms.TextBox EmpleadoCorreo;
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
    }
}