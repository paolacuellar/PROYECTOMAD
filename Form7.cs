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
            getDepartamentos();
            getPuestos();
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
            EmpleadoClave.Text = empTem["Clave"].ToString();
            EmpleadoApellidoP.Text = empTem["A_Paterno"].ToString();
            EmpleadoApellidoM.Text = empTem["A_Materno"].ToString();
            EmpleadoNacimiento.Value = Convert.ToDateTime(empTem["Fecha_nacimiento"].ToString());

            EmpleadoCURP.Text = empTem["CURP"].ToString();
            EmpleadoRFC.Text = empTem["RFC"].ToString();

            EmpleadoCalle.Text = empTem["calle"].ToString();
            EmpleadoNum.Text = empTem["numero"].ToString();
            EmpleadoColonia.Text = empTem["colonia"].ToString();
            EmpleadoMunicipio.Text = empTem["municipio"].ToString();
            EmpleadoCodPostal.Text = empTem["codigo_postal"].ToString();

            EmpleadoTelefono.Text = empTem["Telefono"].ToString();
            EmpleadoCorreo.Text = empTem["Email"].ToString();

            EmpleadoNSS.Text = empTem["NumSeguro_Social"].ToString();
            EmpleadoOperaciones.Value = Convert.ToDateTime(empTem["Fecha_contratacion"].ToString());

            EmpleadoBanco.Text = empTem["Banco"].ToString();
            EmpleadoCBancaria.Text = empTem["NumCuentaBan"].ToString();

            EmpleadoPassword.Text = empTem["contrasenia"].ToString();

            KeyValuePair<string, string> puestoSeleccionado = new KeyValuePair<string, string>(empTem["id_Puesto"].ToString(), empTem["Puesto"].ToString());
            cbPuestos.SelectedItem = puestoSeleccionado;

            KeyValuePair<string, string> deptoSeleccionado = new KeyValuePair<string, string>(empTem["id_Depto"].ToString(), empTem["Depto"].ToString());
            cbDeptos.SelectedItem = deptoSeleccionado;

            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Insert.Enabled = false;
        }

        //Actualizar Datos del Empleado
        private void button4_Click(object sender, EventArgs e)
        {
            ///ACTUALIZAR EMPLEADOS

            EnlaceDB enlace = new EnlaceDB();

            String idemp = ((KeyValuePair<string, string>)listBoxemp.SelectedItem).Key.ToString();

            int id = Int32.Parse(idemp);
            string nombreT = EmpleadoNombre.Text;
            string apellidopT = EmpleadoApellidoP.Text;
            string apellidomT = EmpleadoApellidoM.Text;
            string curpT = EmpleadoCURP.Text;
            string nacimientoT = EmpleadoNacimiento.Value.ToString();
            string emailT = EmpleadoCorreo.Text;
            string rfcT = EmpleadoRFC.Text;
            string nssT = EmpleadoNSS.Text.ToString();
            string bancoT = EmpleadoBanco.Text;
            string numbancariaT = EmpleadoCBancaria.Text.ToString();
            string calleT = EmpleadoCalle.Text;
            int numT = Int32.Parse(EmpleadoNum.Text.ToString()); 
            string coloniaT = EmpleadoColonia.Text;
            string estadoT = EmpleadoMunicipio.Text;
            int codPostalT = Int32.Parse(EmpleadoCodPostal.Text);
            string telefonoT = EmpleadoTelefono.Text;
            string contraseniaT = EmpleadoPassword.Text;
            string operacionesT = EmpleadoOperaciones.Value.ToString();

            int idPuesto = Int32.Parse(((KeyValuePair<string, string>)cbPuestos.SelectedItem).Key.ToString());
            int idDepto = Int32.Parse(((KeyValuePair<string, string>)cbDeptos.SelectedItem).Key.ToString());

            if (enlace.updateEmpleados(id, nombreT, apellidopT, apellidomT, curpT, nacimientoT, emailT,
             rfcT, nssT, bancoT, numbancariaT, calleT, numT, coloniaT, estadoT, codPostalT, telefonoT,
             contraseniaT, operacionesT, idPuesto, idDepto))
            {
                resetListBoxEmpleados();
                resetDataEmpleados();
            }
        }

        private void resetListBoxEmpleados()
        {
            EnlaceDB enlace = new EnlaceDB();
            DataTable emp = enlace.getEmpleadosV();

            listBoxemp.Items.Clear();

            foreach (DataRow row in emp.Rows)
            {
                //Llenar el list box de empleados 
                listBoxemp.Items.Add(new KeyValuePair<string, string>(row["Clave"].ToString(), row["Nombre"].ToString()));
                listBoxemp.ValueMember = "Key";
                listBoxemp.DisplayMember = "Value";

            }
        }

        private void resetDataEmpleados()
        {
            EmpleadoNombre.Text = "";
            EmpleadoClave.Text = "";
            EmpleadoApellidoP.Text = "";
            EmpleadoApellidoM.Text = "";
            EmpleadoNacimiento.Value = Convert.ToDateTime("01/01/1999");

            EmpleadoCURP.Text = "";
            EmpleadoRFC.Text = "";

            EmpleadoCalle.Text = "";
            EmpleadoNum.Text = "";
            EmpleadoColonia.Text = "";
            EmpleadoMunicipio.Text = "";
            EmpleadoCodPostal.Text = "";

            EmpleadoTelefono.Text = "";
            EmpleadoCorreo.Text = "";

            EmpleadoNSS.Text = "";
            EmpleadoOperaciones.Value = Convert.ToDateTime("01/01/1999");

            EmpleadoBanco.Text = "";
            EmpleadoCBancaria.Text = "";

            EmpleadoPassword.Text = "";

            cbPuestos.SelectedIndex = -1;

            cbDeptos.SelectedIndex = -1;

            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Insert.Enabled = true;

        }

        private void getDepartamentos()
        {
            EnlaceDB enlace = new EnlaceDB();
            DataTable depto = enlace.getDeptosV();

            cbDeptos.Items.Clear();

            foreach (DataRow row in depto.Rows)
            {
                //Llenar el combo box de departamentos
                cbDeptos.Items.Add(new KeyValuePair<string, string>(row["ID_Departamento"].ToString(), row["Nombre"].ToString()));
                cbDeptos.ValueMember = "Key";
                cbDeptos.DisplayMember = "Value";

            }
        }

        private void getPuestos()
        {
            EnlaceDB enlace = new EnlaceDB();
            DataTable puesto = enlace.getPuestosV();

            cbPuestos.Items.Clear();

            foreach (DataRow row in puesto.Rows)
            {
                //Llenar el combo box de departamentos
                cbPuestos.Items.Add(new KeyValuePair<string, string>(row["ID_Puesto"].ToString(), row["Nombre"].ToString()));
                cbPuestos.ValueMember = "Key";
                cbPuestos.DisplayMember = "Value";

            }
        }

        //Eliminación de Empleado
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            String idemp = ((KeyValuePair<string, string>)listBoxemp.SelectedItem).Key.ToString();

            int id = Int32.Parse(idemp);

            DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el empleado junto con sus datos", "Some Title"
                , MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (enlace.deleteEmpleado(id))
                {
                    resetListBoxEmpleados();
                    resetDataEmpleados();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }

        }

        //Inserción de Empleado
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            string nombreT = EmpleadoNombre.Text;
            string apellidopT = EmpleadoApellidoP.Text;
            string apellidomT = EmpleadoApellidoM.Text;
            string curpT = EmpleadoCURP.Text;
            string nacimientoT = EmpleadoNacimiento.Value.ToString();
            string emailT = EmpleadoCorreo.Text;
            string rfcT = EmpleadoRFC.Text;
            string nssT = EmpleadoNSS.Text.ToString();
            string bancoT = EmpleadoBanco.Text;
            string numbancariaT = EmpleadoCBancaria.Text.ToString();
            string calleT = EmpleadoCalle.Text;
            int numT = Int32.Parse(EmpleadoNum.Text.ToString());
            string coloniaT = EmpleadoColonia.Text;
            string estadoT = EmpleadoMunicipio.Text;
            int codPostalT = Int32.Parse(EmpleadoCodPostal.Text.ToString());
            string telefonoT = EmpleadoTelefono.Text;
            string contraseniaT = EmpleadoPassword.Text;
            string operacionesT = EmpleadoOperaciones.Value.ToString();

            int idPuesto = Int32.Parse(((KeyValuePair<string, string>)cbPuestos.SelectedItem).Key.ToString());
            int idDepto = Int32.Parse(((KeyValuePair<string, string>)cbDeptos.SelectedItem).Key.ToString());


            if (enlace.insertEmpleado(nombreT, apellidopT, apellidomT, curpT, nacimientoT, emailT,
             rfcT, nssT, bancoT, numbancariaT, calleT, numT, coloniaT, estadoT, codPostalT, telefonoT,
             contraseniaT, operacionesT, idPuesto, idDepto))
            {
                resetListBoxEmpleados();
                resetDataEmpleados();
            }
        }
    }
}
