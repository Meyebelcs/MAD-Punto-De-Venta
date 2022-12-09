using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MAD._0;
//using iTextSharp.text;
using System.IO;
//using iTextSharp.text.pdf;
//using iTextSharp.tool.xml;
using System.Drawing.Printing;
using System.Xml.Linq;


namespace PIAMEL2._0
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

        bool ValidarFecha()
        {
            bool isvalid = true;

            DateTime hoy = DateTime.Today;
            if (DateInicio.Value.Date > hoy) //valida que sea menor a hoy
            {
                isvalid = false;
                MessageBox.Show("Fecha inválida, no puedes seleccionar una fecha futura", "Error de Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (DateFinal.Value.Date > hoy) //valida que sea menor a hoy
            {
                isvalid = false;
                MessageBox.Show("Fecha inválida, no puedes seleccionar una fecha futura", "Error de Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isvalid;
        }


        private void ReporteVentas_Load(object sender, EventArgs e)
        {

        }

        private void TodosCajeros_CheckedChanged(object sender, EventArgs e)
        {
            if (TodosCajeros.Checked) //valida si todos está checked
            {
                UnCajero.Checked = false;
                IdCajero.Enabled = false;
            }
        }

        private void UnCajero_CheckedChanged(object sender, EventArgs e)
        {
            if (UnCajero.Checked) //valida si uno está checked
            {
                TodosCajeros.Checked = false;
                IdCajero.Enabled = true;
            }
        }

        private void TodoDepa_CheckedChanged(object sender, EventArgs e)
        {
            if (TodoDepa.Checked) //valida si todos está checked
            {
                UnoDepa.Checked = false;
                IdDepartamento.Enabled = false;
            }
        }

        private void UnoDepa_CheckedChanged(object sender, EventArgs e)
        {
            if (UnoDepa.Checked) //valida si admin está checked
            {
                TodoDepa.Checked = false;
                IdDepartamento.Enabled = true;
            }
        }

        private void Consultar_Click(object sender, EventArgs e)
        {

            if (!ValidarFecha())
            {
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            //ME FALTO HACER EL DATAGRID DESDE LA BASE UNU
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyy"));


            var enlace = new EnlaceDB();
            var datos = new DataTable();
            datos = enlace.get_DatosCajeros('P');

            //var f = new EnlaceDB();
            //var name = new DataTable();


            string PaginaHTML_Texto = Properties.Resources.Plantilla2.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "Reporte Ventas");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;

            //PARA IMPRIMIR LAS COLUMNAS DEBEN COINCIDIR
            foreach (DataGridViewRow row in DG_REPORTEVENTAS.Rows)
            {

                filas += "<tr>";
                filas += "<td>" + row.Cells["Fecha de Venta"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Departamento"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Código de artículo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio Unitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad Unidades Vendidas"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descuento"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Venta"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Utilidad"].Value.ToString() + "</td>";
                //filas += "<td>" + row.Cells["Suma Utilidad"].Value.ToString() + "</td>";
                filas += "</tr>";

            }

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);


            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }*/
        }

        private void GoBack_Click(object sender, EventArgs e)
        {

        }
    }
}
