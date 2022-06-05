using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
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

        }

        private void btn_Generar_Recibo_Click(object sender, EventArgs e)
        {
            int userIdTemp = Properties.Settings.Default.UserId;

            EnlaceDB enlace = new EnlaceDB();
            DataRow empleado = enlace.getEmpleadoById(userIdTemp);

            string print_date = NominaBuscar.Value.Month.ToString();
            print_date += " " + NominaBuscar.Value.Year.ToString();

            DataRow nompdf = enlace.getNominaByDate(userIdTemp, NominaBuscar.Value.ToString());

            string id_emp = String.Concat("Empleado No. : ", empleado["Clave"].ToString()).ToString();
            string nombre_emp = "Nombre: " + empleado["Nombre"].ToString() + " " + empleado["A_Paterno"].ToString() + " " + empleado["A_Materno"].ToString();
            string sueldo_base = String.Concat("Sueldo de Puesto: ", empleado["Sueldo_Base"].ToString()).ToString();
            string nivel_salarial = String.Concat("Sueldo de Departamento: ", empleado["Nivel_Salarial"].ToString()).ToString();


            DataTable percepciones = enlace.getPercepcionesByDate(NominaBuscar.Value);
            DataTable deducciones = enlace.getDeduccionesByDate(NominaBuscar.Value);

            //string sueldo_bruto = "";
            //string sueldo_neto = "";

            try
            {
                string ubicacion = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Recibo.pdf";
                using (PdfWriter pdfWriter = new PdfWriter(ubicacion))
                using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
                using (Document document = new Document(pdfDocument))
                {
                    document.Add(new Paragraph("RECIBO NOMINA"));
                    document.Add(new Paragraph("Fecha: " + print_date));
                    document.Add(new Paragraph(id_emp));
                    document.Add(new Paragraph(nombre_emp));
                    document.Add(new Paragraph(sueldo_base));
                    document.Add(new Paragraph(nivel_salarial));
                    
                    if(percepciones.Rows.Count > 0)
                        document.Add(new Paragraph("PERCEPCIONES APLICADAS"));

                    foreach (DataRow rowP in percepciones.Rows)
                    {
                        if (rowP["CveEmpleado"].Equals(userIdTemp))
                            document.Add(new Paragraph(rowP["Motivo"].ToString() + "\t $" + rowP["Cantidad"].ToString()));
                    }

                    if (deducciones.Rows.Count > 0)
                        document.Add(new Paragraph("DEDUCCIONES APLICADAS"));

                    foreach (DataRow rowD in deducciones.Rows)
                    {
                        if (rowD["CveEmpleado"].Equals(userIdTemp))
                            document.Add(new Paragraph(rowD["Motivo"].ToString() + "\t $" + rowD["Cantidad"].ToString()));
                    }

                    document.Add(new Paragraph("SUELDO BRUTO \t  $100"));
                    document.Add(new Paragraph("SUELDO NETO \t  $101"));
                }
            }
            catch (Exception ex){
                MessageBox.Show("No se puede crear el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
            finally{

            }
        }

        private void consul_nomina_Click(object sender, EventArgs e)
        {
            int userIdTemp = Properties.Settings.Default.UserId;

            EnlaceDB enlace = new EnlaceDB();
            DataRow empleado = enlace.getEmpleadoById(userIdTemp);

            PuestoSueldo.Text = String.Concat("Sueldo de Puesto: ", empleado["Sueldo_Base"].ToString()).ToString();
            DeptoSueldo.Text = String.Concat("Sueldo de Departamento: ", empleado["Nivel_Salarial"].ToString()).ToString();



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

            //Aplicar Calculos de Nomina

            DataRow nom = enlace.getNominaByDate(userIdTemp, NominaBuscar.Value.ToString());

            if(nom != null){
                
                consul_sueldoneto.Text = String.Concat("Sueldo Neto: ", nom["Sueldo Bruto"].ToString()).ToString();
        
            }
        }
    }
}
