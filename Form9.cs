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
            EnlaceDB enlace = new EnlaceDB();
            DataTable puestos = enlace.getPuestosV();



            foreach (DataRow row in puestos.Rows)
            {
                //Llenar el list box percepciones 
                listBoxPuestos.Items.Add(new KeyValuePair<string, string>(row["ID_Puesto"].ToString(), row["Nombre"].ToString()));
                listBoxPuestos.ValueMember = "Key";
                listBoxPuestos.DisplayMember = "Value";

            }
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

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
