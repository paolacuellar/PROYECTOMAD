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

            //NominaBuscar.Format = DateTimePickerFormat.Custom;
            //NominaBuscar.CustomFormat = "MM/yyyy";
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

            string id_emp = String.Concat("Empleado No. : ", empleado["Clave"].ToString()).ToString();
            string nombre_emp = "Nombre: " + empleado["Nombre"].ToString() + " " + empleado["A_Paterno"].ToString() + " " + empleado["A_Materno"].ToString();
            string sueldo_base = String.Concat("Sueldo de Puesto: ", empleado["Sueldo_Base"].ToString()).ToString();
            string nivel_salarial = String.Concat("Sueldo de Departamento: ", empleado["Nivel_Salarial"].ToString()).ToString();


            DataTable percepciones = enlace.getPercepcionesByDate(NominaBuscar.Value);
            DataTable deducciones = enlace.getDeduccionesByDate(NominaBuscar.Value);

            DataTable percepcionesB = enlace.getAllBasicP();
            DataTable deduccionesB = enlace.getAllBasicD();

            DataRow nomina = enlace.getNominaByDate(userIdTemp, NominaBuscar.Value.ToString());

            if (nomina == null){
                MessageBox.Show("Aún no se ha calculado la nomina de ese mes", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string sueldo_bruto = nomina["Sueldo Bruto"].ToString();
            string sueldo_neto = nomina["Sueldo Neto"].ToString();

                string ubicacion = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Recibo.pdf";
            try
            {
                using (PdfWriter pdfWriter = new PdfWriter(ubicacion))
                using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
                using (Document document = new Document(pdfDocument))
                {
                    document.Add(new Paragraph("RECIBO NOMINA"));
                    document.Add(new Paragraph("\n\tFecha: " + print_date));
                    document.Add(new Paragraph("\n" + id_emp));
                    document.Add(new Paragraph(nombre_emp));
                    document.Add(new Paragraph("\n" + sueldo_base));
                    document.Add(new Paragraph(nivel_salarial));
                    
                    if(percepciones.Rows.Count > 0 && percepcionesB.Rows.Count > 0)
                        document.Add(new Paragraph("\n\tPERCEPCIONES APLICADAS"));

                    foreach (DataRow rowPB in percepcionesB.Rows)
                            document.Add(new Paragraph(rowPB["Motivo"].ToString() + "\t $" + rowPB["Cantidad"].ToString() + " - BASICA"));

                    foreach (DataRow rowP in percepciones.Rows){
                        if (rowP["CveEmpleado"].Equals(userIdTemp))
                            document.Add(new Paragraph(rowP["Motivo"].ToString() + "\t $" + rowP["Cantidad"].ToString()));
                    }

                    

                    if (deducciones.Rows.Count > 0 && deduccionesB.Rows.Count > 0)
                        document.Add(new Paragraph("\n\tDEDUCCIONES APLICADAS"));

                    foreach (DataRow rowDB in deduccionesB.Rows)
                            document.Add(new Paragraph(rowDB["Motivo"].ToString() + "\t $" + rowDB["Cantidad"].ToString() + " - BASICA"));

                    foreach (DataRow rowD in deducciones.Rows){
                        if (rowD["CveEmpleado"].Equals(userIdTemp))
                            document.Add(new Paragraph(rowD["Motivo"].ToString() + "\t $" + rowD["Cantidad"].ToString()));
                    }



                    document.Add(new Paragraph("\n SUELDO BRUTO \t  $" + sueldo_bruto));
                    document.Add(new Paragraph("SUELDO NETO \t  $" + sueldo_neto));
                }
            }
            catch (Exception ex){
                MessageBox.Show("No se puede crear el documento" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally{

            }
            MessageBox.Show(ubicacion, "Se ha generado su recibo en la ruta: ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void consul_nomina_Click(object sender, EventArgs e)
        {
            int userIdTemp = Properties.Settings.Default.UserId;

            EnlaceDB enlace = new EnlaceDB();
            DataRow empleado = enlace.getEmpleadoById(userIdTemp);

            DataRow nomina = enlace.getNominaByDate(userIdTemp, NominaBuscar.Value.ToString());

            //Validacion si la nomina no existe

            if(nomina == null){
                MessageBox.Show("Aún no se ha calculado la nomina de ese mes", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            PuestoSueldo.Text = String.Concat("Sueldo de Puesto: ", empleado["Sueldo_Base"].ToString()).ToString();
            DeptoSueldo.Text = String.Concat("Sueldo de Departamento: ", empleado["Nivel_Salarial"].ToString()).ToString();

            string sueldo_neto = nomina["Sueldo Neto"].ToString();
            consul_sueldoneto.Text = String.Concat("Sueldo Neto: ", sueldo_neto).ToString();


            listBoxPercepciones.Items.Clear();
            DataTable percepcionesB = enlace.getAllBasicP();

            foreach (DataRow rowPB in percepcionesB.Rows){
                    listBoxPercepciones.Items.Add(rowPB["Motivo"].ToString() + " - BASICA");
            }

            DataTable percepciones = enlace.getPercepcionesByDate(NominaBuscar.Value);

            foreach (DataRow row in percepciones.Rows)
            {
                if (row["CveEmpleado"].Equals(userIdTemp))
                {
                    //Llenar el list box
                    listBoxPercepciones.Items.Add(row["Motivo"]);
                }
            }



            listBoxDeducciones.Items.Clear();
            DataTable deduccionesB = enlace.getAllBasicD();

            foreach (DataRow rowDB in deduccionesB.Rows){
                   listBoxDeducciones.Items.Add(rowDB["Motivo"].ToString() + " - BASICA");
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
