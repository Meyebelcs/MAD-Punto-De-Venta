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
        private int productoSelected;
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
            //abre una ventana modal
            //Pregunta cual caja va a utilizar
            var frmSeleccionDeCaja = new Caja_Seleccion();
            frmSeleccionDeCaja.ShowDialog(); //Ventana Modal


            //muestra los datos del usuario
            var enlace = new EnlaceDB();
            var nombre = new DataTable();
            Login IdUser = new Login();
            nombre = enlace.get_DatosEmpleado('S', IdUser.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            lbl_nombrec_PC.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() + " " + nombre.Rows[0][3].ToString();

           //muestra la caja en la q trabaja
            lbl_numcaja_PC.Text = IdUser.getNumCaja();
           
            //muestro los productos
            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.ConsultaTabla("spProductos", "X");//manda llamar el SP
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

        private void btn_codigoP_Click(object sender, EventArgs e)
        {
            if (txt_codigop_PC.TextLength < 1)
            {
                MessageBox.Show("Ingresa un codigo de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //muestro los productos
            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.get_DatosProductos('V', Convert.ToInt32(txt_codigop_PC.Text));//manda llamar el SP

            dgv_busqueda_PC.DataSource = tabla; //Asigna la info a la tabla


        }

        private void btn_nombre_Click(object sender, EventArgs e)
        {
            if (txt_nombreP_PC.TextLength < 1)
            {
                MessageBox.Show("Ingresa un Nombre de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //muestro los productos
            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.get_DatosProductosByName('N', txt_nombreP_PC.Text);//manda llamar el SP

            dgv_busqueda_PC.DataSource = tabla; //Asigna la info a la tabla
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //muestro los productos
            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.ConsultaTabla("spProductos", "X");//manda llamar el SP
            dgv_busqueda_PC.DataSource = tabla; //Asigna la info a la tabla

            //limpio antes de poner info
            txt_unidad.Text = " ";
            iddepartament.Text = " ";
            txt_existente.Text = " ";
            idproducto.Text = " ";
            txt_departamento.Text = " ";
            lbl_descuento.Text = " ";
            porcentaje.Text = " ";
        }

        private void dgv_busqueda_PC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var row = (sender as DataGridView).CurrentRow;
            productoSelected = Convert.ToInt32(row.Cells[0].Value.ToString()); //ID DEL descuento SELECCIONADO

            //limpio antes de poner info
            txt_unidad.Text = " ";
            iddepartament.Text = " ";
            txt_existente.Text = " ";
            idproducto.Text = " ";
            txt_departamento.Text = " ";
            lbl_descuento.Text = " ";
            porcentaje.Text = " ";

            //muestro los productos
            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.get_DatosProductos('V', productoSelected);//manda llamar el SP

            dgv_busqueda_PC.DataSource = tabla; //Asigna la info a la tabla

            txt_unidad.Text = tabla.Rows[0][5].ToString();
            iddepartament.Text = tabla.Rows[0][1].ToString();
            txt_existente.Text = tabla.Rows[0][8].ToString();
            idproducto.Text = tabla.Rows[0][0].ToString();

            //buscar el departamento e imprimir su nombre
            //BUSCO EL DEPARTAMENTO
            var dep = new DataTable();
            string IdDepa = tabla.Rows[0][1].ToString();
            var NombreDepa = new DataTable();
            NombreDepa = obj.get_DatosDepartamento('S', Convert.ToInt32(IdDepa));
            txt_departamento.Text = NombreDepa.Rows[0][1].ToString();


            string descuento = tabla.Rows[0][4].ToString();

            if (descuento == "True")
            {
                //busca el descuento que coincida con el productoy lo imprime
                var INFO = new DataTable();
                INFO = obj.get_DatosPorcentaje('S', productoSelected); //traigo de la base los datos del empleado

                if (INFO.Rows.Count >= 1)
                {

                    lbl_descuento.Text = tabla.Rows[0][0].ToString();
                    porcentaje.Text = INFO.Rows[0][4].ToString() + " %";
                }
            }
            else
            {
                porcentaje.Text = "0%";
            }
        }

        private void btn_AgregarP_PC_Click(object sender, EventArgs e)
        {
            //dar de alta venta
            //mostrarla en el datagridview
        }
    }
}
