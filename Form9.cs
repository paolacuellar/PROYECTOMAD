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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
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

        private void Form9_Load(object sender, EventArgs e)
        {
            resetListBoxPuestos();
        }

        private void listBoxPuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            String idpuestos = ((KeyValuePair<string, string>)listBoxPuestos.SelectedItem).Key.ToString();

            int idPuestoTemp = Int32.Parse(idpuestos);

            DataRow puestoTem = enlace.getPuestoById(idPuestoTemp);

            PuestoN.Text = ((KeyValuePair<string, string>)listBoxPuestos.SelectedItem).Value.ToString();
            PuestoC.Text = puestoTem["ID_Puesto"].ToString();
            PuestoSB.Text = puestoTem["Nivel Salarial"].ToString();
        }

        private void PuestoAdd_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            string nombreT = PuestoN.Text;
            float sueldo_baseT = float.Parse(PuestoSB.Text);

            if (enlace.insertDeptos(nombreT, sueldo_baseT))
            {
                resetListBoxPuestos();
                resetDataPuestos();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ///ACTUALIZAR PUESTOS

            EnlaceDB enlace = new EnlaceDB();

            String idPuestos = ((KeyValuePair<string, string>)listBoxPuestos.SelectedItem).Key.ToString();
            int idPuestoTemp = Int32.Parse(idPuestos);

            string nombreT = PuestoN.Text;

            float nivel_salarialT = float.Parse(PuestoSB.Text);

            if (enlace.updatePuestos(idPuestoTemp, nombreT, nivel_salarialT))
            {
                resetListBoxPuestos();
            }
        }
        private void PuestoDelete_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            String idemp = ((KeyValuePair<string, string>)listBoxPuestos.SelectedItem).Key.ToString();

            int id = Int32.Parse(idemp);

            DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el puesto junto con sus datos", "Some Title"
                , MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (enlace.deleteDeptos(id))
                {
                    resetListBoxPuestos();
                    resetDataPuestos();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
        private void resetListBoxPuestos()
        {
            EnlaceDB enlace = new EnlaceDB();
            DataTable puestos = enlace.getPuestosV();
            
            listBoxPuestos.Items.Clear();

            foreach (DataRow row in puestos.Rows)
            {
                //Llenar el list box percepciones 
                listBoxPuestos.Items.Add(new KeyValuePair<string, string>(row["ID_Puesto"].ToString(), row["Nombre"].ToString()));
                listBoxPuestos.ValueMember = "Key";
                listBoxPuestos.DisplayMember = "Value";

            }
        }

        private void resetDataPuestos()
        {
            PuestoN.Text = "";
            PuestoC.Text = "";
            PuestoSB.Text = "";


            PuestoUpdate.Enabled = false;
            PuestoDelete.Enabled = false;
            PuestoAdd.Enabled = true;

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        
    }
}
