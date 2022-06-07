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
    public partial class Form12 : Form
    {
        public Form12()
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

        private void cbDeptos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            prepareComboBox();
        }

        private void prepareComboBox()
        {
            EnlaceDB enlace = new EnlaceDB();
            DataTable deptos = enlace.getDeptosV();

            cbDeptos.Items.Clear();

            if (deptos.Rows.Count > 0)
                cbDeptos.Items.Add(new KeyValuePair<string, string>("TODOS", "TODOS"));


            foreach (DataRow row in deptos.Rows)
            {
                //Llenar el list box departamentos
                cbDeptos.Items.Add(new KeyValuePair<string, string>(row["ID_Departamento"].ToString(), row["Nombre"].ToString()));
                cbDeptos.ValueMember = "Key";
                cbDeptos.DisplayMember = "Value";

            }


            cbMes.Items.Add(new KeyValuePair<string, string>("01", "ENERO"));
            cbMes.Items.Add(new KeyValuePair<string, string>("02", "FEBRERO"));
            cbMes.Items.Add(new KeyValuePair<string, string>("03", "MARZO"));
            cbMes.Items.Add(new KeyValuePair<string, string>("04", "ABRIL"));
            cbMes.Items.Add(new KeyValuePair<string, string>("05", "MAYO"));
            cbMes.Items.Add(new KeyValuePair<string, string>("06", "JUNIO"));
            cbMes.Items.Add(new KeyValuePair<string, string>("07", "JULIO"));
            cbMes.Items.Add(new KeyValuePair<string, string>("08", "AGOSTO"));
            cbMes.Items.Add(new KeyValuePair<string, string>("09", "SEPTIEMBRE"));
            cbMes.Items.Add(new KeyValuePair<string, string>("10", "OCTUBRE"));
            cbMes.Items.Add(new KeyValuePair<string, string>("11", "NOVIEMBRE"));
            cbMes.Items.Add(new KeyValuePair<string, string>("12", "DICIEMBRE"));


            cbMes.ValueMember = "Key";
            cbMes.DisplayMember = "Value";

        }

        private void bGenerar_Click(object sender, EventArgs e)
        {
            EnlaceDB enlace = new EnlaceDB();

            string deptoName = ((KeyValuePair<string, string>)cbDeptos.SelectedItem).Value.ToString();
            string year = tbAnio.Text.ToString();
            string month = "";
            string monthName = "";
            string date = "";

            if (cbMes.SelectedIndex == -1 || year == "")
                date = "0";
            else{
                month = ((KeyValuePair<string, string>)cbMes.SelectedItem).Key.ToString();
                monthName = ((KeyValuePair<string, string>)cbMes.SelectedItem).Value.ToString();
                date = year + "-" + month + "-" + "01";
            }

            DataTable reporte1 = enlace.getHeadcounterReport(deptoName, date, "1");
            DataTable reporte2 = enlace.getHeadcounterReport(deptoName, date, "2");

            if (reporte1.Rows.Count <= 0 && reporte2.Rows.Count <= 0)
            {
                MessageBox.Show("Reporte vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string docName = "";

            if (year != "")
                docName = "_" + year;
            if(monthName != "")
                docName = "_" + monthName;

            string ubicacion = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Headcounter_" + deptoName + docName + ".pdf";
            try
            {
                using (PdfWriter pdfWriter = new PdfWriter(ubicacion))
                using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
                using (Document document = new Document(pdfDocument))
                {
                    document.Add(new Paragraph("\tREPORTE HEADCOUNTER"));
                    document.Add(new Paragraph("\n\tCANTIDAD DE EMPLEADOS POR PUESTO"));


                    // Creating a table       
                    float[] pointColumnWidths = { 150F, 150F, 150F };
                    Table table = new Table(pointColumnWidths);

                    // Adding cells to the table       
                    table.AddCell(new Cell().Add(new Paragraph("Departamento")));
                    table.AddCell(new Cell().Add(new Paragraph("Puesto")));
                    table.AddCell(new Cell().Add(new Paragraph("Cantidad de empleados")));


                    foreach (DataRow row in reporte1.Rows){
                        table.AddCell(new Cell().Add(new Paragraph(row["Departamento"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["Puesto"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["Cantidad de empleados"].ToString())));
                    }

                    // Adding Table to document        
                    document.Add(table);

                    document.Add(new Paragraph("\n\tCANTIDAD DE EMPLEADOS POR DEPARTAMENTO"));

                    // Creating a table       
                    float[] pointColumnWidths2 = { 150F, 150F};
                    Table table2 = new Table(pointColumnWidths2);

                    // Adding cells to the table       
                    table2.AddCell(new Cell().Add(new Paragraph("Departamento")));
                    table2.AddCell(new Cell().Add(new Paragraph("Cantidad de empleados")));


                    foreach (DataRow row in reporte2.Rows)
                    {
                        table2.AddCell(new Cell().Add(new Paragraph(row["Departamento"].ToString())));
                        table2.AddCell(new Cell().Add(new Paragraph(row["Cantidad de empleados"].ToString())));
                    }

                    // Adding Table to document        
                    document.Add(table2);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede crear el documento" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {

            }
            MessageBox.Show(ubicacion, "Se ha generado el reporte en la ruta: ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
