using MAD._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD._0
{
    public partial class PrincipalCajero : Form
    {
        public PrincipalCajero()
        {
            InitializeComponent();
        }

        private void horaYfecha_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PC.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PC.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

        private void PrincipalCajero_Load(object sender, EventArgs e)
        {

           


            //Pregunta cual caja va a utilizar
            var frmSeleccionDeCaja = new Caja_Seleccion();

            frmSeleccionDeCaja.ShowDialog(); //Ventana Modal

            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.ConsultaTabla("spProductos", "*");//manda llamar el SP
            dgv_busqueda_PC.DataSource = tabla; //Asigna la info a la tabla
        }

        private void btn_ticket_PC_Click(object sender, EventArgs e)
        {
            //Selecciona el tipo de pago
            var frmPago = new Pago();
            frmPago.ShowDialog(); //Ventana Modal
        }

        private void btn_cerrarS_PC_Click(object sender, EventArgs e)
        {
            var resp = new DialogResult();

            resp = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Login pantalla = new Login();

                pantalla.Show();
                this.Hide();
            }

        }
    }
}
