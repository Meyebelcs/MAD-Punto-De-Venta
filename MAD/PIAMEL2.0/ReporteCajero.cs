using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using iTextSharp.text;
using System.IO;
//using iTextSharp.text.pdf;
//using iTextSharp.tool.xml;
using MAD._0;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace PIAMEL2._0
{
    public partial class ReporteCajero : Form
    {
        public ReporteCajero()
        {
            InitializeComponent();
        }

        //private int RowSelected;


        private void ReporteCajero_Load(object sender, EventArgs e)
        {
            /*
            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla
            tabla = obj.ConsultaTabla("spCliente", "P");//manda llamar el SP
            DG_REPORTCAJERO.DataSource = tabla; //Asigna la info a la tabla
            */
        }


        private void Consultar_Click(object sender, EventArgs e)
        {
            //var row = (sender as DataGridView).CurrentRow;
            //RowSelected = Convert.ToInt32(row.Cells[0].Value.ToString());


            if (!ValidarFecha())
            {
                return;
            }



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


            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "Reporte Cajero");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;

            //PARA IMPRIMIR LAS COLUMNAS DEBEN COINCIDIR
            foreach (DataGridViewRow row in DG_REPORTCAJERO.Rows)
            {

                filas += "<tr>";
                filas += "<td>" + row.Cells["Fecha Registro"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Nombre Cajero"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Departamento"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad de Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Suma Venta"].Value.ToString() + "</td>";
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

            }
            */
        }

        private void TodosCajeros_CheckedChanged_1(object sender, EventArgs e)
        {
            if (TodosCajeros.Checked) //valida si admin está checked
            {
                UnCajero.Checked = false;
                IdCajero.Enabled = false;
            }
        }

        private void UnCajero_CheckedChanged(object sender, EventArgs e)
        {
            if (UnCajero.Checked) //valida si admin está checked
            {
                TodosCajeros.Checked = false;
                IdCajero.Enabled = true;
            }
        }

        private void TodosDepa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (TodosDepa.Checked) //valida si admin está checked
            {
                UnoDepa.Checked = false;
                IdDepartamento.Enabled = false;
            }
        }

        private void UnoDepa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (UnoDepa.Checked) //valida si admin está checked
            {
                TodosDepa.Checked = false;
                IdDepartamento.Enabled = true;
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {

        }
    }
}
