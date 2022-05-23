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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            NominaBuscar.Format = DateTimePickerFormat.Custom;
            NominaBuscar.CustomFormat = "MM/yyyy";


            int userIdTemp = Properties.Settings.Default.UserId;

            EnlaceDB enlace = new EnlaceDB();
            DataRow empleado = enlace.getEmpleadoById(userIdTemp);

            PuestoSueldo.Text = String.Concat("Sueldo de Puesto: ", empleado["Sueldo_Base"].ToString()).ToString();
            DeptoSueldo.Text = String.Concat("Sueldo de Departamento: ", empleado["Nivel_Salarial"].ToString()).ToString();



            DataTable percepciones = enlace.getPercepcionesByDate(NominaBuscar.Value);

            foreach(DataRow row in percepciones.Rows)
            {
                if(row["CveEmpleado"].Equals(userIdTemp))
                {
                    //Llenar el list box
                    listBoxPercepciones.Items.Add(row["Motivo"]);
                }
            }

            DataTable deducciones = enlace.getDeduccionesByDate(NominaBuscar.Value);

            foreach (DataRow row in deducciones.Rows)
            {
                if (row["CveEmpleado"].Equals(userIdTemp))
                {
                    //Llenar el list box
                    listBoxDeducciones.Items.Add(row["Motivo"]);
                }
            }


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

        private void NominaBuscar_ValueChanged(object sender, EventArgs e)
        {
            int userIdTemp = Properties.Settings.Default.UserId;
            EnlaceDB enlace = new EnlaceDB();

            DataTable percepciones = enlace.getPercepcionesByDate(NominaBuscar.Value);

            foreach (DataRow row in percepciones.Rows)
            {
                if (row["CveEmpleado"].Equals(userIdTemp))
                {
                    //Llenar el list box
                    listBoxPercepciones.Items.Add(row["Motivo"]);
                }
            }


            DataTable deducciones = enlace.getDeduccionesByDate(NominaBuscar.Value);

            foreach (DataRow row in deducciones.Rows)
            {
                if (row["CveEmpleado"].Equals(userIdTemp))
                {
                    //Llenar el list box
                    listBoxDeducciones.Items.Add(row["Motivo"]);
                }
            }
        }
    }
}
