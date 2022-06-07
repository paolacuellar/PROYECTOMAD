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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Return_Click(object sender, EventArgs e)
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

        private void ResetForm()
        {
            comboBoxdeptos.SelectedIndex = -1;

            EnlaceDB enlace = new EnlaceDB();
            DataTable percepciones = enlace.getAllP();

            listBoxP.Items.Clear();

            foreach (DataRow row in percepciones.Rows)
            {
                //Llenar el list box percepciones
                listBoxP.Items.Add(new KeyValuePair<string, string>(row["ID_Percepcion"].ToString(), row["Motivo"].ToString()));
                listBoxP.ValueMember = "Key";
                listBoxP.DisplayMember = "Value";
            }

            listBoxD.Items.Clear();


            DataTable deducciones = enlace.getAllD();

            foreach (DataRow row in deducciones.Rows)
            {
                //Llenar el list box deducciones
                listBoxD.Items.Add(new KeyValuePair<string, string>(row["ID_Deduccion"].ToString(), row["Motivo"].ToString()));
                listBoxD.ValueMember = "Key";
                listBoxD.DisplayMember = "Value";
            }


            DataTable emp = enlace.getEmpleadosV();

            listBoxemp.Items.Clear();

            foreach (DataRow row in emp.Rows)
            {
                //Llenar el list box de empleados 
                listBoxemp.Items.Add(new KeyValuePair<string, string>(row["Clave"].ToString(), row["Nombre"].ToString()));
                listBoxemp.ValueMember = "Key";
                listBoxemp.DisplayMember = "Value";

            }

            DataTable depto = enlace.getDeptosV();

            comboBoxdeptos.SelectedIndex = -1;

            foreach (DataRow row in depto.Rows)
            {
                //Llenar el combo box de departamentos
                comboBoxdeptos.Items.Add(new KeyValuePair<string, string>(row["ID_Departamento"].ToString(), row["Nombre"].ToString()));
                comboBoxdeptos.ValueMember = "Key";
                comboBoxdeptos.DisplayMember = "Value";

            }

            FechaAplicarConcepto.Value = Convert.ToDateTime("01/01/2022");
            PD_Asignadas.Items.Clear();
        }

        private void listBoxP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxD.SelectedIndex != -1)
                listBoxD.SelectedIndex = -1;

            verificarAsignacion();

        }

        private void listBoxD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxP.SelectedIndex != -1)
                listBoxP.SelectedIndex = -1;

            verificarAsignacion();
        }

        private void listBoxemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();
            PD_Asignadas.Items.Clear();

            int idEnte = Int32.Parse(((KeyValuePair<string, string>)listBoxemp.SelectedItem).Key.ToString());

            DataTable percepcionesA = enlace.getPercepcionesAsignadas(idEnte);

            DataTable deduccionesA = enlace.getDeduccionesAsignadas(idEnte);

            if (comboBoxdeptos.SelectedIndex != -1)
                comboBoxdeptos.SelectedIndex = -1;

            DataTable percepcionesB = enlace.getAllBasicP();

            if (percepcionesA.Rows.Count > 0 || percepcionesB.Rows.Count > 0)
            {
                PD_Asignadas.Items.Add("PERCEPCIONES APLICADAS\n");
                PD_Asignadas.Items.Add(" ");
            }


            foreach (DataRow rowPB in percepcionesB.Rows)
            {
                if (rowPB["Es_porcentaje"].ToString() == "True")
                    PD_Asignadas.Items.Add(rowPB["Motivo"].ToString() + "(Porcentaje: " + rowPB["Cantidad"].ToString() + "%) - BASICA");
                else
                    PD_Asignadas.Items.Add(rowPB["Motivo"].ToString() + "(Valor fijo: $" + rowPB["Cantidad"].ToString() + ") - BASICA");
            }

            foreach (DataRow rowP in percepcionesA.Rows){
                
                    if (rowP["Es_porcentaje"].ToString() == "True")
                        PD_Asignadas.Items.Add(rowP["Motivo"].ToString() + "(Porcentaje: " + rowP["Cantidad"].ToString() + "%) - " + rowP["Fecha"]);
                    else
                        PD_Asignadas.Items.Add(rowP["Motivo"].ToString() + "(Valor fijo: $" + rowP["Cantidad"].ToString() + ") - " + rowP["Fecha"]);
            }

            DataTable deduccionesB = enlace.getAllBasicD();


            if (deduccionesA.Rows.Count > 0 || deduccionesB.Rows.Count > 0) {
                PD_Asignadas.Items.Add(" ");
                PD_Asignadas.Items.Add("DEDUCCIONES APLICADAS\n");
                PD_Asignadas.Items.Add(" ");
            }

            foreach (DataRow rowDB in deduccionesB.Rows)
            {
                if (rowDB["Es_porcentaje"].ToString() == "True")
                    PD_Asignadas.Items.Add(rowDB["Motivo"].ToString() + "(Porcentaje: " + rowDB["Cantidad"].ToString() + "%) - BASICA");
                else
                    PD_Asignadas.Items.Add(rowDB["Motivo"].ToString() + "(Valor fijo: $" + rowDB["Cantidad"].ToString() + ") - BASICA");
            }

            foreach (DataRow rowD in deduccionesA.Rows)
            {               
                    if (rowD["Es_porcentaje"].ToString() == "True")
                        PD_Asignadas.Items.Add(rowD["Motivo"].ToString() + "(Porcentaje: " + rowD["Cantidad"].ToString() + "%) - " + rowD["Fecha"]);
                    else
                        PD_Asignadas.Items.Add(rowD["Motivo"].ToString() + "(Valor fijo: $" + rowD["Cantidad"].ToString() + ") - " + rowD["Fecha"]);
            }

            verificarAsignacion();

        }

        private void comboBoxdeptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxemp.SelectedIndex != -1)
                listBoxemp.SelectedIndex = -1;

            verificarAsignacion();

        }

        private void asignar_Click(object sender, EventArgs e)
        {
            string oper = getOperacion();
            int idEnte = 0;
            int idConcepto = 0;
            string tipoEnte = "";

            EnlaceDB enlace = new EnlaceDB();

            if (listBoxD.SelectedIndex != -1)
                idConcepto = Int32.Parse(((KeyValuePair<string, string>)listBoxD.SelectedItem).Key.ToString());

            if (listBoxP.SelectedIndex != -1)
                idConcepto = Int32.Parse(((KeyValuePair<string, string>)listBoxP.SelectedItem).Key.ToString());

            if (listBoxemp.SelectedIndex != -1)
            {
                idEnte = Int32.Parse(((KeyValuePair<string, string>)listBoxemp.SelectedItem).Key.ToString());
                tipoEnte = "E";
            }

            if (comboBoxdeptos.SelectedIndex != -1)
            {
                idEnte = Int32.Parse(((KeyValuePair<string, string>)comboBoxdeptos.SelectedItem).Key.ToString());
                tipoEnte = "D";
            }


            string fechaAplicacion = FechaAplicarConcepto.Value.ToString();

            if (enlace.asignarConcepto(oper, idConcepto, tipoEnte, idEnte, fechaAplicacion))
                ResetForm();
        }

        private void verificarAsignacion()
        {
            if ((listBoxD.SelectedIndex > -1 || listBoxP.SelectedIndex > -1) && (listBoxemp.SelectedIndex > -1 || comboBoxdeptos.SelectedIndex > -1))
                asignar.Enabled = true;
            else
                asignar.Enabled = false;
        }

        private string getOperacion()
        {
            string operTemp = "";

            if (listBoxD.SelectedIndex != -1)
                operTemp += "D";

            if (listBoxP.SelectedIndex != -1)
                operTemp += "P";

            operTemp += "x";

            if (listBoxemp.SelectedIndex != -1)
                operTemp += "E";

            if (comboBoxdeptos.SelectedIndex != -1)
                operTemp += "D";

            return operTemp;
        }

        private void btn_Calculo_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            enlace.calcularNomina(fechaCalculo.Value.ToString());
        }
    }
}
