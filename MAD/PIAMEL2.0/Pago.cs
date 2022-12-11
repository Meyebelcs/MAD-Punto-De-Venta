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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAD._0
{
    public partial class Pago : Form
    {

        private bool generaPago=false;
        private bool hallegado = false;
        public Pago()
        {
            InitializeComponent();
        }

        private void btn_cancelar_P_Click(object sender, EventArgs e)
        {

            //eliminar los tipos de pago que se generaron con el id de esta venta
            var enlace = new EnlaceDB();
            DialogResult result = MessageBox.Show(" ¿Está seguro que desea cancelar la compra?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                MessageBox.Show("No se canceló la compra", "No Cancelado", MessageBoxButtons.OK);
                return;
            }

            //Pregunto si selecciono una opcion de pago
            if (cb_opcionP_P.SelectedIndex != -1)
            {
                

                PrincipalCajero IdVenta = new PrincipalCajero();

                enlace.get_DatosTipoPago('D', IdVenta.getidVenta());

                MessageBox.Show("se eliminó correctamente los tipos de pago asignados", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            generaPago = false;
            this.Close();
        }

        private void btn_pagar_P_Click(object sender, EventArgs e)
        {
            if (hallegado!=true)
            {
                MessageBox.Show("Ingresa el monto requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resp = new DialogResult();

            resp = MessageBox.Show("¿Seguro que quiere realizar esta compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.No)
            {
                MessageBox.Show("No se generó el Ticket", "Cancelado", MessageBoxButtons.OK);
                return;
            }

            //SE GENERA EL TICKET 
            //Si cumple toda las validaciones continua y guarda la info en la base de datos
            var ticket = new EnlaceDB();
            bool control;
            PrincipalCajero idVenta = new PrincipalCajero();
            Login gestor = new Login();


            //TRAIGO ID DE TICKET X´S
            var obj = new EnlaceDB();
            var INFO = new DataTable();
            INFO = obj.ConsultaTabla("spTipo_Pago", "M"); //traigo de la base los datos del empleado

            string idtipopago= " ";
            if (INFO.Rows.Count >= 1)
            {
                idtipopago = INFO.Rows[0][0].ToString();

            }
            //alta de ticket
            control = ticket.add_Ticket("I", 0,idVenta.getidVenta() ,gestor.getCurrentIdUser() , Convert.ToInt32(idtipopago), tp_fechaIngreso.Value, Convert.ToInt32(gestor.getNumCaja()), idVenta.getSubTotal(), idVenta.getTotal(), 0);

            if (!control)
            {
                MessageBox.Show("No se pudo agregar correctamente el ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            MessageBox.Show("Pago realizado con éxito", "Compra exitosa", MessageBoxButtons.OK);
           this.Close();

            //se reinicia todo
            gestor.setEstadoCompra(1);

        }

        private void Pago_Load(object sender, EventArgs e)
        {
            hallegado = false;
            PrincipalCajero total = new PrincipalCajero();

            lbl_Total_P.Text = total.getTotal().ToString();


            //LLENAR LOS COMBOBOX
            var obj2 = new EnlaceDB();
            var depas = new DataTable();
            depas = obj2.ConsultaTabla("spOpcion_Pago", "*");
            cb_opcionP_P.DataSource = depas;
            cb_opcionP_P.DisplayMember = "Tipo de Pago";
            cb_opcionP_P.ValueMember = "Id";

            cb_opcionP_P.SelectedIndex = -1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PC.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PC.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_Agregar_P_Click(object sender, EventArgs e)
        {
            //Pregunto si selecciono una opcion de pago
            if (cb_opcionP_P.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una opción de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (hallegado == true)
            {
                MessageBox.Show("Ya ingresaste el monto suficiente, puedes hacer tu ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //si es si, capturo la info del combobox y busco el id de esa opcion

            //busco el id de la opcion seleccionada
            string idopcion = cb_opcionP_P.Text;

            var enlace = new EnlaceDB();
            var iddepa = new DataTable();
            iddepa = enlace.get_IdOpcionPago('N', idopcion); //traigo de la base los datos 
            idopcion = iddepa.Rows[0][0].ToString();

            //alta de tipo de pago 
            //Si cumple toda las validaciones continua y guarda la info en la base de datos
            var pagos = new EnlaceDB();
            bool control;

            Login gestor = new Login();
            PrincipalCajero idVenta = new PrincipalCajero();

            //alta de tipo pago
            control = pagos.add_TipoPago("I",0, gestor.getCurrentIdUser(), Convert.ToInt32(idopcion), idVenta.getidVenta(), idVenta.getidVenta(), cb_opcionP_P.Text, 0, 0);

            if (!control)
            {
                MessageBox.Show("No se pudo agregar correctamente el Tipo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            MessageBox.Show("Se agregó correctamente el Tipo de pago", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //la muestra en la tabla
            //muestro los tipos de pago de esa venta
            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.get_DatosTipoPago('T', idVenta.getidVenta());//manda llamar el SP

            dgv_Lista_P.DataSource = tabla; //Asigna la info a la tabla

            generaPago = true;

        }


        private void dgv_Lista_P_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!generaPago)
            {
                return;
            }

           
            PrincipalCajero total = new PrincipalCajero();
            PrincipalCajero idVenta = new PrincipalCajero();

            decimal Total = 0;
            for (int i = 0; i < dgv_Lista_P.RowCount - 1; i++)
            {
                string datoIngresado = dgv_Lista_P.Rows[i].Cells[3].Value.ToString();
                Total = Total + Convert.ToDecimal(datoIngresado);


                //PREGUNTO SI LA SUMA YA LLEGO A LA CANTIDAD PEDIDA, DEJE DE METER MAS MONEY
                if (Total > total.getTotal()) //si la suma es > al total a pagar
                {
                    //te excediste de dinero, cambia la cifra
                    //no hace ningun update y solo carga la tabla de nuev

                    //la muestra en la tabla
                    //muestro los tipos de pago de esa venta
                    var obj2 = new EnlaceDB(); //creo objeto enlaceDB
                    var tabla = new DataTable();//creo tabla 
                    tabla = obj2.get_DatosTipoPago('T', idVenta.getidVenta());//manda llamar el SP

                    dgv_Lista_P.DataSource = tabla; //Asigna la info a la tabla
                    MessageBox.Show("te excediste de dinero, cambia la cifra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Total == total.getTotal())
                {   //si llega a ser la cantidad exacta a pagar 
                    //te excediste de dinero, cambia la cifra
                    hallegado = true;
                
                }

                var obj = new EnlaceDB(); //creo objeto enlaceDB
                bool control = true;
                //moDIfica el tipo de pago
                control = obj.add_TipoPago("U",Convert.ToInt32( dgv_Lista_P.Rows[i].Cells[2].Value.ToString()), 0, 0, 0, 0," ",0, Convert.ToDecimal(dgv_Lista_P.Rows[i].Cells[3].Value.ToString()));

            }
            montopagar.Text = "$ " + Total.ToString();

            decimal HayQuePagar= total.getTotal() - Total;

            lbl_Total_P.Text = HayQuePagar.ToString();

            //muestro los tipos de pago de esa venta
            var obj3 = new EnlaceDB(); //creo objeto enlaceDB
            var tabla2 = new DataTable();//creo tabla 
            tabla2 = obj3.get_DatosTipoPago('T', idVenta.getidVenta());//manda llamar el SP

        }
    }
}
