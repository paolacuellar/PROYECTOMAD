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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Boton para entrar a la pantalla de editar perfil
        private void perfil_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        //Boton para entrar a la pantalla de Consultar Nomina
        private void NominaConsulta_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        //Boton para entrar a la pantalla de Gestion de empleados
        private void EmpleadosGestion_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        //Boton para entrar a la pantalla de Gestion de departamentos
        private void DepartamentosGestion_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        //Boton para entrar a la pantalla de Gestion de puestos
        private void PuestosGestion_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        //Boton para entrar a la pantalla de Percepciones y Deducciones
        private void PeryDed_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        //Boton para entrar a la pagina de Gestion de nomina
        private void NominaGestion_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        //Boton para entrar a la pantalla de Organigrama, aun no hay pantalla. todo bn.


    }
}
