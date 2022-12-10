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

namespace PIAMEL2._0
{
    public partial class RegistroDescuentos : Form
    {
        public RegistroDescuentos()
        {
            InitializeComponent();
        }

        private void btn_cancelar_RE_Click(object sender, EventArgs e)
        {
            GestionDescuentos pantalla = new GestionDescuentos();
            pantalla.Show();
            this.Hide();
        }

        private void btn_registrar_RE_Click(object sender, EventArgs e)
        {
            #region Validaciones

            if (cb_producto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtx_porcentaje.TextLength < 1)
            {
                MessageBox.Show("El porcentaje debe tener informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (Convert.ToInt32(txtx_porcentaje.Text) < 1 || Convert.ToInt32(txtx_porcentaje.Text) > 100)
            {
                MessageBox.Show("El porcentaje debe ser un numero entre el 1 y el 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //validaciono a las fechas que sean congruentes-------------------------------------------------------------------------------------------------------

            #endregion

            //Si cumple toda las validaciones continua y guarda la info en la base de datos
            var Descuento = new EnlaceDB();
            bool control;

            //alta de decsuento
            control = Descuento.add_Descuento("I", 0, Convert.ToInt32(cb_producto.Text), Convert.ToInt32(LBL_Depa.Text), Convert.ToInt32(lbl_idadmin.Text), Convert.ToInt32(txtx_porcentaje.Text), DateInicio.Value, DateFinal.Value);

            if (!control)
            {
                MessageBox.Show("No se pudo agregar correctamente el Descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }


            //ACTUALIZAR LA TABLA DE PRODUCTOS EL PRODUCTO A QUIEN FUE ASIGNADO EL DESCUENTOO
            var enlace = new EnlaceDB();

            bool productodescuento;

            productodescuento = enlace.actualiza_Descuento( 'C', Convert.ToInt32(cb_producto.Text));
            if (!productodescuento)
            {
                MessageBox.Show("No se pudo modificar correctamente el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            MessageBox.Show("Se modificó correctamente el producto con su descuento", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 


            MessageBox.Show("Se agregó correctamente el nuevo Descuento", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            GestionDescuentos pantalla = new GestionDescuentos();
            pantalla.Show();
            this.Hide();
        }

        private void RegistroDescuentos_Load(object sender, EventArgs e)
        {
            Login gestor = new Login();
            lbl_idadmin.Text = gestor.getCurrentIdUser().ToString();

            //busco el admin y lo imprimo
            var enlace = new EnlaceDB();
            var nombreAdmin = new DataTable();
            nombreAdmin = enlace.get_DatosEmpleado('S', gestor.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            txt_nameadmin.Text = nombreAdmin.Rows[0][1].ToString() + " " + nombreAdmin.Rows[0][2].ToString() + " " + nombreAdmin.Rows[0][3].ToString();

            //LLENAR LOS COMBOBOX
            var obj2 = new EnlaceDB();
            var product = new DataTable();
            product = obj2.ConsultaTabla("spProductos", "T");
            cb_producto.DataSource = product;
            cb_producto.DisplayMember = "IdProducto";
            cb_producto.ValueMember = "IdProducto";

            cb_producto.SelectedIndex = -1;


        }

        private void cb_producto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ( txtx_porcentaje.Enabled == true )
            {
               
                var obj = new EnlaceDB();
                var INFO = new DataTable();
                INFO = obj.get_DatosProductos('S', Convert.ToInt32(cb_producto.Text)); //traigo de la base los datos del PRODUCT

                if (INFO.Rows.Count >= 1)
                {

                    lLBL_PRODUCT.Text = INFO.Rows[0][2].ToString();
                    LBL_Depa.Text = INFO.Rows[0][1].ToString();

                    int iddepa = Convert.ToInt32(INFO.Rows[0][1].ToString());
                    var INFO_Depa = new DataTable();
                    INFO_Depa = obj.get_DatosDepartamento('S', iddepa); //traigo de la base los datos del departamento

                    txt_depa.Text = INFO_Depa.Rows[0][1].ToString();
                }
              

            }

        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {

            btn_habilitar.Visible = false;
            cb_producto.Enabled = true;
            txtx_porcentaje.Enabled = true;
            DateInicio.Enabled = true;
            DateFinal.Enabled = true;
        }

        private void txtx_porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }
    }
}
