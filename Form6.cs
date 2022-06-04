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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {          

            comboOp.Items.Add("Percepcion");
            comboOp.Items.Add("Deduccion");

            EnlaceDB enlace = new EnlaceDB();
            DataTable percepciones = enlace.getAllP(); 

            foreach (DataRow row in percepciones.Rows)
            {
                //Llenar el list box percepciones
                listBoxP.Items.Add(row["Motivo"]); 
            }

            DataTable deducciones = enlace.getAllD();

            foreach (DataRow row in deducciones.Rows)
            {
                //Llenar el list box deducciones
                listBoxD.Items.Add(row["Motivo"]);
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

        //AGREGAR CONCEPTO
        private void button1_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            string motivo = MotivoConcepto.Text.ToString();
            float cantidad = float.Parse(CantidadConcepto.Text.ToString());
            bool esPorcentaje = false;
            bool seInserto = false;

            if (esPorcentajeConcepto.Checked)
                esPorcentaje = true;

            if (comboOp.Text.ToString() == "Deduccion")
                seInserto = enlace.insertDeduccion(motivo, cantidad, esPorcentaje);


            if (comboOp.Text.ToString() == "Percepcion")
                seInserto = enlace.insertPercepcion(motivo, cantidad, esPorcentaje);

            if (seInserto)
                resetForm();
        }

        private void resetForm()
        {
            comboOp.SelectedIndex = -1;

            EnlaceDB enlace = new EnlaceDB();
            DataTable percepciones = enlace.getAllP();

            listBoxP.Items.Clear();

            foreach (DataRow row in percepciones.Rows)
            {
                //Llenar el list box percepciones
                listBoxP.Items.Add(row["Motivo"]);
            }

            listBoxD.Items.Clear();


            DataTable deducciones = enlace.getAllD();

            foreach (DataRow row in deducciones.Rows)
            {
                //Llenar el list box deducciones
                listBoxD.Items.Add(row["Motivo"]);
            }

            MotivoConcepto.Text = "";
            CantidadConcepto.Text = "";
            esPorcentajeConcepto.Checked = false;
        }
    }
}
