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
    public partial class Form8 : Form
    {
        public Form8()
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

        private void Form8_Load(object sender, EventArgs e)
        {
            resetListBoxDeptos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            string nombreT = deptoN.Text;
            float sueldo_baseT = float.Parse(deptoSB.Text);

            if (enlace.insertDeptos(nombreT, sueldo_baseT))
            {
                resetListBoxDeptos();
                resetDataDeptos();
            }
        }

        private void DeptoUpdate_Click(object sender, EventArgs e)
        {
            ///ACTUALIZAR DEPARTAMENTOS

            EnlaceDB enlace = new EnlaceDB();

            String iddeptos = ((KeyValuePair<string, string>)listBoxDeptos.SelectedItem).Key.ToString();
            int idDeptoTemp = Int32.Parse(iddeptos);

            string nombreT = deptoN.Text;

            float sueldo_baseT = float.Parse(deptoSB.Text);

            if (enlace.updateDeptos(idDeptoTemp, nombreT, sueldo_baseT))
            {
                resetListBoxDeptos();
                resetDataDeptos();
            }
          
        } 

        private void listBoxDeptos_SelectedIndexChanged(object sender, EventArgs e)
        {

            EnlaceDB enlace = new EnlaceDB();

            String iddeptos = ((KeyValuePair<string, string>)listBoxDeptos.SelectedItem).Key.ToString();

            int idDeptoTemp = Int32.Parse(iddeptos);

            DataRow deptoTem = enlace.getDeptoById(idDeptoTemp);

            deptoN.Text = ((KeyValuePair<string, string>)listBoxDeptos.SelectedItem).Value.ToString();
            deptoC.Text = deptoTem["ID_Departamento"].ToString();
            deptoSB.Text = deptoTem["Sueldo Base"].ToString();

            DeptoAdd.Enabled = false;
            DeptoUpdate.Enabled = true;
            DeptoDelete.Enabled = true;
        }

        private void DeptoDelete_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            String idemp = ((KeyValuePair<string, string>)listBoxDeptos.SelectedItem).Key.ToString();

            int id = Int32.Parse(idemp);

            DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el departamento junto con sus datos", "Some Title"
                , MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (enlace.deleteDeptos(id))
                {
                    resetListBoxDeptos();
                    resetDataDeptos();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void resetListBoxDeptos()
        {
            EnlaceDB enlace = new EnlaceDB();
            DataTable deptos = enlace.getDeptosV();

            listBoxDeptos.Items.Clear();


            foreach (DataRow row in deptos.Rows)
            {
                //Llenar el list box departamentos
                listBoxDeptos.Items.Add(new KeyValuePair<string, string>(row["ID_Departamento"].ToString(), row["Nombre"].ToString()));
                listBoxDeptos.ValueMember = "Key";
                listBoxDeptos.DisplayMember = "Value";

            }
        }

        private void resetDataDeptos()
        {
            deptoN.Text = "";
            deptoC.Text = "Clave departamento";
            deptoSB.Text = "";


            DeptoUpdate.Enabled = false;
            DeptoDelete.Enabled = false;
            DeptoAdd.Enabled = true;

        }


        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        
    }
}
