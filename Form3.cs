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
    public partial class Form3 : Form
    {
        public Form3()
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

        //Boton para entrar a la pantalla de Consultar Sueldo
        private void SueldoConsulta_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
