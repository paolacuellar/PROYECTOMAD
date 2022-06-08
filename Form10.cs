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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            int userIdTemp = Properties.Settings.Default.UserId;

            EnlaceDB enlace = new EnlaceDB();
            DataRow empleado = enlace.getEmpleadoById(userIdTemp);

            CSPuesto.Text = empleado["Puesto"].ToString();
            CSDepto.Text = empleado["Depto"].ToString();
            CSPuestoSueldo.Text = empleado["Sueldo_Base"].ToString();
            CSDeptoSueldo.Text = empleado["Nivel_Salarial"].ToString();


            float Sueldito = float.Parse(empleado["Sueldo_Base"].ToString()) * float.Parse(empleado["Nivel_Salarial"].ToString());
            CSsueldo.Text = Sueldito.ToString();

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
    }
}
