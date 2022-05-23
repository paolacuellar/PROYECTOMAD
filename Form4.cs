using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD_Pantallas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Regresar1_Click(object sender, EventArgs e)
        {
            String rol = Properties.Settings.Default.Permission;

            if (rol == "EM")
            {
                Form3 frm = new Form3();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else if (rol == "GG")
            {
                Form2 frm = new Form2();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int userIdTemp = Properties.Settings.Default.UserId;

            EnlaceDB enlace = new EnlaceDB();


            DataRow empleado = enlace.getEmpleadoById(userIdTemp);

            EmpleadoNombre.Text = empleado["Nombre"].ToString();
            EmpleadoApellidoP.Text = empleado["A_Paterno"].ToString();
            EmpleadoApellidoM.Text = empleado["A_Materno"].ToString();
            EmpleadoNacimiento.Text = String.Concat("Fecha de Nacimiento ", empleado["Fecha_nacimiento"].ToString()).ToString();
            EmpleadoCURP.Text = String.Concat("CURP: ", empleado["CURP"].ToString()).ToString();
            EmpleadoRFC.Text = String.Concat("RFC: ", empleado["RFC"].ToString()).ToString(); ;
            EmpleadoCalle.Text = String.Concat("Calle: ", empleado["calle"].ToString()).ToString();
            EmpleadoNum.Text = String.Concat("# ", empleado["numero"].ToString()).ToString();
            EmpleadoColonia.Text = String.Concat("Colonia: ", empleado["colonia"].ToString()).ToString();
            EmpleadoMunicipio.Text = String.Concat("Municipio: ", empleado["municipio"].ToString()).ToString();
            EmpleadoTelefono.Text = empleado["Telefono"].ToString();
            EmpleadoCorreo.Text = empleado["Email"].ToString();
            EmpleadoNSS.Text = String.Concat("Numero de Seguro Social: ",empleado["NumSeguro_Social"].ToString()).ToString();
            EmpleadoPuesto.Text = String.Concat("Puesto ",empleado["Puesto"].ToString()).ToString();
            EmpleadoOperaciones.Text = String.Concat("Contratación: ", empleado["Fecha_contratacion"].ToString()).ToString();
            EmpleadoDepto.Text = String.Concat("Departamento: ", empleado["Depto"].ToString()).ToString();
            EmpleadoClave.Text = String.Concat("Clave Empleado: ", empleado["CveEmpleado"].ToString()).ToString();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadoRfc_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpleadoDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Actualizar Informacion 
        }
    }
}
