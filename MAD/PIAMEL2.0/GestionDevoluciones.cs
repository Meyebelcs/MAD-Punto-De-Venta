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
    public partial class GestionDevoluciones : Form
    {
        private int ventaSelected=0;
        private int ticketSelected;

        public GestionDevoluciones()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PA.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PA.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_regresar_GP_Click(object sender, EventArgs e)
        {
            PrincipalAdministrador pantalla = new PrincipalAdministrador();
            pantalla.Show();
            this.Hide();

        }

        private void btn_crearNota_Click(object sender, EventArgs e)
        {
            //valido que los campos no estén vacios

            //captura el producto seleccionado
            if (ventaSelected == 0)
            {
                MessageBox.Show("Seleccione un producto para devolver", "Devolucion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_motivo.TextLength < 1)
            {
                MessageBox.Show("Ingrese el motivo de la devolución", "Motivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //VALIDO QUE EL DEPARTAMENTO PERMITA HACER DEVOLUCIONES CON EL BIT

            DialogResult result = MessageBox.Show("Esta acción es irreversible\n\n El producto será devuelto ¿Está seguro que desea continuar?", "Devolver", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                MessageBox.Show("No se eliminó la venta", "Cancelado", MessageBoxButtons.OK);
                return;
            }


            var obj = new EnlaceDB();
            var Permitedevolucion = new DataTable();
            Permitedevolucion = obj.get_DatosDepartamento('C', Convert.ToInt32(id_depa.Text)); //traigo de la base los datos

           string devolucion= Permitedevolucion.Rows[0][0].ToString();

            if (devolucion != "True")
            {
                MessageBox.Show("El departamento no permite la devolución de este producto", "Devolución denegada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {    //dar de alta devolucion y nota de credito :) 
               
                //Si cumple toda las validaciones continua y guarda la info en la base de datos
                var devolucioon = new EnlaceDB();
                bool control;

                Login gestor = new Login();
                int merma = 0;

                if (chb_merma.Checked == true)
                {
                    merma = 1;
                }

                //alta de devolucioon
                control = devolucioon.add_Devolucion("I", 0, Convert.ToInt32(ID_producto.Text), Convert.ToInt32(id_depa.Text), gestor.getCurrentIdUser(), Convert.ToInt32(IDVENTA.Text), merma, txt_motivo.Text, tp_fechaIngreso.Value, Convert.ToInt32(IDTICKET.Text));

                if (!control)
                {
                    MessageBox.Show("No se pudo agregar correctamente la devolucion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                //TRAER EL ID DE LA DEVOLUCION RECIEN CREADA 
                var enlace = new EnlaceDB();
                var iddevolucion = new DataTable();
                iddevolucion = enlace.get_DatosDevolucion('V', Convert.ToInt32(IDVENTA.Text)); //traigo de la base los datos del user q inició sesion
                string idDevolucionCreada= iddevolucion.Rows[0][0].ToString();



                //alta de NOTA CREDITO
                control = devolucioon.add_NotaCredito("I",  Convert.ToInt32(ID_producto.Text), Convert.ToInt32(IDTICKET.Text), Convert.ToDecimal(CANTIDAD.Text), Convert.ToDecimal(SUBTOTAL.Text), Convert.ToDecimal(txt_monto.Text),tp_fechaIngreso.Value, Convert.ToInt32(idcaja.Text), Convert.ToInt32(idDevolucionCreada));

                if (!control)
                {
                    MessageBox.Show("No se pudo agregar correctamente la nota de credito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                //si no tiene merma actualiza el inventarioo de producto sino no 
                if (merma == 0)
                {
                    #region ACTUALIZA_INVENTARIO_PRODUCTO

                    control = true;

                    control = obj.add_Productos("Z", Convert.ToInt32(ID_producto.Text), " ", 0, " ", " ", 0, Convert.ToDecimal(CANTIDAD.Text));

                    if (!control)
                    {
                        MessageBox.Show("No se pudo actualizar el inventario del Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }
                    MessageBox.Show("Se modificó correctamente el inventario del producto", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    #endregion
                }

                //ELIMINAR LA VENTA DE ESE PRODUCTO
                enlace.get_DatosVentaInventario('E', Convert.ToInt32(IDVENTA.Text));

                MessageBox.Show("se eliminó correctamente el producto de la venta", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);



                MessageBox.Show("Este producto ha sido devuelto", "Devolución", MessageBoxButtons.OK);


                //inicializo todo
                this.Close();
                GestionDevoluciones pantalla = new GestionDevoluciones();
                pantalla.Show();
               
            }

          
        }

        private void btn_AgregarP_Click(object sender, EventArgs e)
        {
            //captura el producto seleccionado
            if (ventaSelected == 0)
            {
                MessageBox.Show("Seleccione un producto para devolver", "Devolucion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //muestra los datos del producto en los text box
            var obj = new EnlaceDB();
            var INFO = new DataTable();
            INFO = obj.get_DatosVentaInventario('O', ventaSelected); //traigo de la base los datos del producto

            if (INFO.Rows.Count >= 1)
            {
                string eliminacion = INFO.Rows[0][18].ToString();

                if (eliminacion == "True")
                {
                    MessageBox.Show("Este producto ya ha sido devuelto", "Devolucion denegada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                IDVENTA.Text = INFO.Rows[0][0].ToString();
                ID_producto.Text = INFO.Rows[0][1].ToString();
                txt_producto.Text = INFO.Rows[0][2].ToString();
                CANTIDAD.Text = INFO.Rows[0][3].ToString();
                SUBTOTAL.Text = INFO.Rows[0][7].ToString();
                txt_monto.Text = INFO.Rows[0][8].ToString();
                txt_departamento.Text = INFO.Rows[0][9].ToString();
                id_depa.Text = INFO.Rows[0][15].ToString();

                IDTICKET.Text = ticketSelected.ToString();
                idcaja.Text = INFO.Rows[0][17].ToString();
                
            }

            //genera id temporal para nota de credito
            var IdProvisional = new DataTable();
            IdProvisional = obj.ConsultaTabla("spNotaCredito","M"); //traigo de la base los datos

            idnotacredito.Text = IdProvisional.Rows[0][0].ToString();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //valida q el txt no esté vacio
            if (txt_idticket.TextLength < 1)
            {
                MessageBox.Show("Ingrese el codigo de ticket", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //busca el producto en la bd

            ticketSelected = Convert.ToInt32(txt_idticket.Text);

            //BUSCO EL IDENTIFICADOR DE LA VENTA EN LA INFO DE TICKET
            var obj = new EnlaceDB();
            var INFO = new DataTable();
            INFO = obj.get_DatosTicket('T', Convert.ToInt32(txt_idticket.Text)); //traigo de la base los datos del devloucion y venta
            string IdVenta = " ";                                                                  //traigo el identificador

            if (INFO.Rows.Count >= 1)
            {
                 IdVenta = INFO.Rows[0][1].ToString();
            }

            if (IdVenta == " ")
            {
                MessageBox.Show("Este ticket no existe", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //busco la info de venta que coincida el idventa en ticket y en identificador de ventas           
            var INFO2 = new DataTable();
            INFO2 = obj.get_DatosDevolucion('C', Convert.ToInt32(IdVenta)); //traigo de la base los datos del devloucion y venta
            //muestra los datos en el grid
            dgv_DEVOLUCIONES.DataSource = INFO2; //Asigna la info a la tabla

            //inicializo
            ventaSelected = 0;
        }

        private void GestionDevoluciones_Load(object sender, EventArgs e)
        {
            var enlace = new EnlaceDB();
            var nombre = new DataTable();
            Login IdUser = new Login();

            nombre = enlace.get_DatosEmpleado('S', IdUser.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            lbl_nombrec_PA.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() + " " + nombre.Rows[0][3].ToString();

        }

        private void dgv_DEVOLUCIONES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            ventaSelected = Convert.ToInt32(row.Cells[8].Value.ToString()); //ID DEL venta SELECCIONADO

        }
    }
}
