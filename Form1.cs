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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificarcuenta_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            DataRow usuarioTemp = enlace.Autentificar(EmpleadoNum.Text, EmpleadoPass.Text);
            errorMsg.Text = "";

            if (usuarioTemp!= null)
            {
                Properties.Settings.Default.UserId = Int32.Parse(usuarioTemp["CveEmpleado"].ToString());
                Properties.Settings.Default.Permission = usuarioTemp["Rol"].ToString();

                if (usuarioTemp["Rol"].ToString() == "EM")
                {
                    Form3 frm = new Form3();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else if (usuarioTemp["Rol"].ToString() == "GG")
                {
                    Form2 frm = new Form2();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                    
            }
            else
            {
                errorMsg.Text = "Credenciales incorrectas";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
