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
    public partial class Form13 : Form
    {
        public Form13()
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

        private void Form13_Load(object sender, EventArgs e)
        {
            prepareCombo();
        }

        private void prepareCombo()
        {
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

            string year = tbAnio.Text.ToString();
            string month = "";
            string monthName = "";
            string date = "";

            if (cbMes.SelectedIndex == -1 || year == "")
                date = "0";
            else
            {
                month = ((KeyValuePair<string, string>)cbMes.SelectedItem).Key.ToString();
                monthName = ((KeyValuePair<string, string>)cbMes.SelectedItem).Value.ToString();
                date = year + "-" + month + "-" + "01";
            }

            DataTable reporte = enlace.getGeneralReport(date);

            if (reporte.Rows.Count <= 0)
            {
                MessageBox.Show("Reporte vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string docDate = "";

            if (year != "")
                docDate = "_" + year;
            if (monthName != "")
                docDate = "_" + monthName;

            string ubicacion = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Reporte_General_" + docDate + ".pdf";
            try
            {
                using (PdfWriter pdfWriter = new PdfWriter(ubicacion))
                using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
                using (Document document = new Document(pdfDocument))
                {
                    document.Add(new Paragraph("\tREPORTE GENERAL DE NOMINA"));
                    if(docDate != "")
                        document.Add(new Paragraph("\t" + docDate));

                    // Creating a table       
                    float[] pointColumnWidths = { 150F, 150F, 150F, 150F, 150F, 150F };
                    Table table = new Table(pointColumnWidths);

                    // Adding cells to the table       
                    table.AddCell(new Cell().Add(new Paragraph("Departamento")));
                    table.AddCell(new Cell().Add(new Paragraph("Puesto")));
                    table.AddCell(new Cell().Add(new Paragraph("Empleado")));
                    table.AddCell(new Cell().Add(new Paragraph("Fecha de ingreso")));
                    table.AddCell(new Cell().Add(new Paragraph("Edad")));
                    table.AddCell(new Cell().Add(new Paragraph("Salario Diario")));


                    foreach (DataRow row in reporte.Rows)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(row["Departamento"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["Puesto"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["Nombre del empleado"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["Fecha de contratacion"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["Edad"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["Salario Diario"].ToString())));
                    }

                    // Adding Table to document        
                    document.Add(table);                                       

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

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMes.SelectedIndex != -1)
                tbAnio.Enabled = true;
            else
                tbAnio.Enabled = false;
        }
    }
}
