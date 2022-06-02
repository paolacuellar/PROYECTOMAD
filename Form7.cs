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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            resetListBoxEmpleados();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void listBoxemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            String idemp = ((KeyValuePair<string, string>)listBoxemp.SelectedItem).Key.ToString();

            int idEmpTemp = Int32.Parse(idemp);

            DataRow empTem = enlace.getEmpleadoById(idEmpTemp);

            EmpleadoNombre.Text = ((KeyValuePair<string, string>)listBoxemp.SelectedItem).Value.ToString();
            EmpleadoClave.Text = empTem["CveEmpleado"].ToString();
            EmpleadoApellidoP.Text = empTem["A_Paterno"].ToString();
            EmpleadoApellidoM.Text = empTem["A_Materno"].ToString();
            EmpleadoNacimiento.Text = empTem["Fecha_nacimiento"].ToString();
            EmpleadoCURP.Text = empTem["CURP"].ToString();
            EmpleadoRFC.Text = empTem["RFC"].ToString();
            EmpleadoCalle.Text = empTem["calle"].ToString();
            EmpleadoNum.Text = empTem["numero"].ToString();
            EmpleadoColonia.Text = empTem["colonia"].ToString();
            EmpleadoMunicipio.Text = empTem["municipio"].ToString();
            EmpleadoTelefono.Text = empTem["Telefono"].ToString();
            EmpleadoCorreo.Text = empTem["Email"].ToString();
            EmpleadoNSS.Text = empTem["NumSeguro_Social"].ToString();
            EmpleadoOperaciones.Text = empTem["Fecha_contratacion"].ToString();
            EmpleadoBanco.Text = empTem["Banco"].ToString();
            EmpleadoCBancaria.Text = empTem["NumCuentaBan"].ToString();
        }

        //Actualizar Datos del Empleado
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void resetListBoxEmpleados()
        {
            EnlaceDB enlace = new EnlaceDB();
            DataTable emp = enlace.getEmpleadosV();

            listBoxemp.Items.Clear();

            foreach (DataRow row in emp.Rows)
            {
                //Llenar el list box empleados 
                listBoxemp.Items.Add(new KeyValuePair<string, string>(row["Clave"].ToString(), row["Nombre"].ToString()));
                listBoxemp.ValueMember = "Key";
                listBoxemp.DisplayMember = "Value";

            }
        }

    }
}
