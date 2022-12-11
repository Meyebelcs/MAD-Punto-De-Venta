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
        private static int idVenta;
        public int getidVenta()
        {
            return idVenta;
        }

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
            //inicializo 
            idVenta = 0;

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
            decimal Total = 0;
            if (descuento == "True")
            {
                //busca el descuento que coincida con el productoy lo imprime
                var INFO = new DataTable();
                INFO = obj.get_DatosPorcentaje('S', productoSelected); //traigo de la base los datos del empleado

                if (INFO.Rows.Count >= 1)
                {

                    lbl_descuento.Text = tabla.Rows[0][0].ToString();
                    porcentaje.Text = INFO.Rows[0][4].ToString() ;

                    //CALCULO EL TOTAL CON DESCUENTO APLICADO
                    string descuento1 = "0." + porcentaje.Text;
                    //costo * descuento
                    Total = (Convert.ToDecimal(tabla.Rows[0][6].ToString())) * (Convert.ToDecimal(descuento1));
                    //costo - total
                    Total = (Convert.ToDecimal(tabla.Rows[0][6].ToString())) - Total;

                }
            }
            else
            {
                porcentaje.Text = "0";
                Total = Convert.ToDecimal(tabla.Rows[0][6].ToString());
            }

            total.Text = "$ "+ Total.ToString();

        }

        private void btn_AgregarP_PC_Click(object sender, EventArgs e)
        {
            //dar de alta venta
            if (productoSelected != 0)
            {
                if (txt_cantidad.TextLength < 1)
                {
                    MessageBox.Show("Ingrese la cantidad de productos que se comprarán", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_cantidad.Text == "0")
                {
                    MessageBox.Show("Ingrese al menos 1 articulo para poder generar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Tiene que validar que la existencia de este producto sea mayor a 0
                if (Convert.ToDecimal(txt_existente.Text) == 0)
                {
                    MessageBox.Show("No hay productos suficientes para realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Tiene que validar que la cantidad que llevará sea congruente con la existencia
                // cantidad < = inventario 
                if (Convert.ToDecimal(txt_cantidad.Text) <= Convert.ToDecimal(txt_existente.Text))
                {
                    //Si cumple toda las validaciones continua y guarda la info en la base de datos
                    var venta = new EnlaceDB();
                    bool control=true;

                    //traigo la info de producto
                    var obj = new EnlaceDB(); //creo objeto enlaceDB
                    var tabla = new DataTable();//creo tabla 
                    tabla = obj.get_DatosProductos('V', productoSelected);//manda llamar el SP

                    //traigo la info Info_producto
                    var tabla2 = new DataTable();//creo tabla 
                    tabla2 = obj.get_DatosInfoProducto('S', productoSelected);//manda llamar el SP

                    decimal precioUnitario = Convert.ToDecimal(tabla2.Rows[0][5].ToString());

                    //CALCULO EL TOTAL CON DESCUENTO APLICADO
                    string descuento = "0." + porcentaje.Text;
                    //costo * descuento
                    decimal Total = (Convert.ToDecimal(tabla.Rows[0][6].ToString())) * (Convert.ToDecimal(descuento));
                    //costo - total
                    Total = (Convert.ToDecimal(tabla.Rows[0][6].ToString())) - Total;

                    //TENIENDO EL PRECIOO TOTAL SE MUILTIPLICA POR LA CANTIDAD VENDIDA
                    Total = Total * (Convert.ToDecimal(txt_cantidad.Text));

                    //SUBTOTAL ES EL PRECIO NORMAL POR LA CANTIDAD VENDIDA
                    decimal subtotal = (Convert.ToDecimal(tabla.Rows[0][6].ToString())) * (Convert.ToDecimal(txt_cantidad.Text));

                    Login gestor = new Login();

                    //alta de VENTA

                    //VALIDAR SI ES EL PRIMER ARTICULO O SI YA SON AGREGADOS A LA MISMA VENTA
                    if (idVenta != 0)
                    {
                        //ES UN ARTICULO MAS
                        control = venta.add_Venta('I', productoSelected, tabla.Rows[0][2].ToString(), Convert.ToDecimal(txt_cantidad.Text), precioUnitario, Convert.ToDecimal(tabla.Rows[0][6].ToString()), porcentaje.Text, subtotal, Total, txt_departamento.Text, 0, 0, tp_fechaIngreso.Value, lbl_nombrec_PC.Text, gestor.getCurrentIdUser(), Convert.ToInt32(iddepartament.Text), txt_unidad.Text, idVenta);

                    }
                    else
                    {
                        //SE genera SU IDENTIFICADOR DE VENTA
                        var IdentificadorVenta = new DataTable();//creo tabla 
                        IdentificadorVenta = obj.ConsultaTabla("spVenta", "M");//manda llamar el SP

                        idVenta = Convert.ToInt32(IdentificadorVenta.Rows[0][0].ToString());

                        //ES EL PRIMER ARTICULO
                        control = venta.add_Venta('I', productoSelected, tabla.Rows[0][2].ToString(), Convert.ToDecimal(txt_cantidad.Text), precioUnitario, Convert.ToDecimal(tabla.Rows[0][6].ToString()), porcentaje.Text, subtotal, Total, txt_departamento.Text, 0, 0, tp_fechaIngreso.Value, lbl_nombrec_PC.Text, gestor.getCurrentIdUser(), Convert.ToInt32(iddepartament.Text), txt_unidad.Text, idVenta);

                    }

                    if (!control)
                    {
                        MessageBox.Show("No se pudo agregar correctamente el producto a la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }

                    decimal cantidadInventario = (Convert.ToDecimal(txt_existente.Text)) - (Convert.ToDecimal(txt_cantidad.Text));

                    control = true;
                    //Tiene que actualizar el inventario de este producto
                    #region ACTUALIZA_INVENTARIO_PRODUCTO
                   
                    //alta de producto
                    control = obj.add_Productos("R", Convert.ToInt32(idproducto.Text)," ", 0, " ", " ", 0, Convert.ToInt32(cantidadInventario));

                    if (!control)
                    {
                        MessageBox.Show("No se pudo actualizar el inventario del Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }

                    #endregion

                    MessageBox.Show("Se modificó correctamente el inventario del producto", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    MessageBox.Show("Se agregó correctamente el producto a la venta", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //MOSTRAR EN EL DATAGRID VIEW LA INFO DE VENTA
                  
                   
                    var ventaGenerada = new DataTable();//creo tabla 
                    ventaGenerada = obj.get_DatosVenta('T', idVenta);//manda llamar el SP

                    dgv_Lista_PC.DataSource = ventaGenerada; //Asigna la info a la tabla

                    decimal totalVenta = 0;

                    //MUESTRA EL PRECIO TOTAL DE LA SUMA DE LA VENTA
                    if (ventaGenerada.Rows.Count >= 0)
                    {
                        foreach (DataRow fila in ventaGenerada.Rows)
                        {
                            totalVenta = totalVenta + Convert.ToDecimal(fila["Total"]);
                        }
                    }

                    lbl_Total_PC.Text = "$ " + totalVenta;

                }
                else
                {
                    MessageBox.Show("No hay suficientes articulos para su venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
