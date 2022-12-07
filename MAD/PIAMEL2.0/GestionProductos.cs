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
    public partial class GestionProductos : Form
    {
        public GestionProductos()
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

        private void btn_NProducto_Click(object sender, EventArgs e)
        {
            #region INICIALIZACION
            //VISIBILIDAD
            cb_idProducto.Visible = true;
            lb_productoEliminado.Visible = true;
            btn_Eliminar.Visible = true;
            btn_guardar.Visible = true;
            txt_nombre.Visible = true;
            cbUnidadMedida.Visible = true;
            txt_costo.Visible = true;
            txt_descripcion.Visible = true;
            cb_departamento.Visible = true;
            txt_cantidadInv.Visible = true;
            txt_reorden.Visible = true;
            txt_precioUnitario.Visible = true;
            //label
            lbl_idprod.Visible = true;
            lbl_nombre.Visible = true;
            lbl_departamento.Visible = true;
            lbl_medida.Visible = true;
            lbl_cantInv.Visible = true;
            lbl_costo.Visible = true;
            lbl_reorden.Visible = true;
            lbl_precioUni.Visible = true;
            lbl_descripcion.Visible = true;
            //BOTONES
            cb_idProducto.Enabled = false;
            lb_productoEliminado.Visible = false;
            btn_Eliminar.Visible = false;
            btn_guardar.Visible = true;
            //HABILITAR TXT Y CB
            txt_nombre.Enabled = true;
            cbUnidadMedida.Enabled = true;
            txt_costo.Enabled = true;
            txt_descripcion.Enabled = true;
            cb_departamento.Enabled = true;
            txt_cantidadInv.Enabled = true;
            txt_reorden.Enabled = true;
            txt_precioUnitario.Enabled = true;
            //VACIAR TXT
            cb_departamento.Text = String.Empty;
            cb_idProducto.Text = String.Empty;
            txt_nombre.Text = String.Empty;
            cbUnidadMedida.Text = String.Empty;
            txt_costo.Text = String.Empty;
            txt_descripcion.Text = String.Empty;
            txt_cantidadInv.Text = String.Empty;
            txt_cantidadInv.Text = String.Empty;
            txt_reorden.Text = String.Empty;
            txt_precioUnitario.Text = String.Empty;
            #endregion

            //se generará un id provisional

        }

        private void btn_MProducto_Click(object sender, EventArgs e)
        {
            #region INICIALIZACION
            //VISIBILIDAD
            cb_idProducto.Visible = true;
            lb_productoEliminado.Visible = true;
            btn_Eliminar.Visible = true;
            btn_guardar.Visible = true;
            txt_nombre.Visible = true;
            cbUnidadMedida.Visible = true;
            txt_costo.Visible = true;
            txt_descripcion.Visible = true;
            cb_departamento.Visible = true;
            txt_cantidadInv.Visible = true;
            txt_reorden.Visible = true;
            txt_precioUnitario.Visible = true;
            //label
            lbl_idprod.Visible = true;
            lbl_nombre.Visible = true;
            lbl_departamento.Visible = true;
            lbl_medida.Visible = true;
            lbl_cantInv.Visible = true;
            lbl_costo.Visible = true;
            lbl_reorden.Visible = true;
            lbl_precioUni.Visible = true;
            lbl_descripcion.Visible = true;
            //BOTONES
            cb_idProducto.Enabled = true;
            btn_Eliminar.Visible = false;
            btn_guardar.Visible = true;
            //VACIAR TXT
            cb_departamento.Text = String.Empty;
            cb_idProducto.Text = String.Empty;
            txt_nombre.Text = String.Empty;
            cbUnidadMedida.Text = String.Empty;
            txt_costo.Text = String.Empty;
            txt_descripcion.Text = String.Empty;
            txt_cantidadInv.Text = String.Empty;
            txt_cantidadInv.Text = String.Empty;
            txt_reorden.Text = String.Empty;
            txt_precioUnitario.Text = String.Empty;
            #endregion

            //se habilita y deshabiita si el producto está eliminado
            lb_productoEliminado.Visible = false;
            txt_nombre.Enabled = true;
            cbUnidadMedida.Enabled = true;
            txt_costo.Enabled = true;
            txt_descripcion.Enabled = true;
            cb_departamento.Enabled = true;
            txt_cantidadInv.Enabled = true;
            txt_reorden.Enabled = true;
            txt_precioUnitario.Enabled = true;


        }

        private void btn_EProducto_Click(object sender, EventArgs e)
        {
            #region INICIALIZACION
            //VISIBILIDAD
            cb_idProducto.Visible = true;
            lb_productoEliminado.Visible = true;
            btn_Eliminar.Visible = true;
            btn_guardar.Visible = true;
            txt_nombre.Visible = true;
            cbUnidadMedida.Visible = true;
            txt_costo.Visible = true;
            txt_descripcion.Visible = true;
            cb_departamento.Visible = true;
            txt_cantidadInv.Visible = true;
            txt_reorden.Visible = true;
            txt_precioUnitario.Visible = true;
            //label
            lbl_idprod.Visible = true;
            lbl_nombre.Visible = true;
            lbl_departamento.Visible = true;
            lbl_medida.Visible = true;
            lbl_cantInv.Visible = true;
            lbl_costo.Visible = true;
            lbl_reorden.Visible = true;
            lbl_precioUni.Visible = true;
            lbl_descripcion.Visible = true;
            //BOTONES
            cb_idProducto.Enabled = true;
            btn_Eliminar.Visible = true;
            btn_guardar.Visible = false;
            //VACIAR TXT
            cb_departamento.Text = String.Empty;
            cb_idProducto.Text = String.Empty;
            txt_nombre.Text = String.Empty;
            cbUnidadMedida.Text = String.Empty;
            txt_costo.Text = String.Empty;
            txt_descripcion.Text = String.Empty;
            txt_cantidadInv.Text = String.Empty;
            txt_cantidadInv.Text = String.Empty;
            txt_reorden.Text = String.Empty;
            txt_precioUnitario.Text = String.Empty;
            #endregion

            //se habilita y deshabiita si el producto está eliminado
            lb_productoEliminado.Visible = false;

            txt_nombre.Enabled = false;
            cbUnidadMedida.Enabled = false;
            txt_costo.Enabled = false;
            txt_descripcion.Enabled = false;
            cb_departamento.Enabled = false;
            txt_cantidadInv.Enabled = false;
            txt_reorden.Enabled = false;
            txt_precioUnitario.Enabled = false;

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var resp = new DialogResult();

            resp = MessageBox.Show("¿Seguro que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                //SE ELIMINA EL PRODUCTO O MAS BIEN, SE VUELVE TRUE EL BIT DE ELIMINACION
                MessageBox.Show("Este producto ha sido eliminado" , "Eliminación", MessageBoxButtons.OK);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este producto ha sido guardado con éxito", "Nuevo Producto", MessageBoxButtons.OK);

        }

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            var enlace = new EnlaceDB();
            var nombre = new DataTable();
            Login IdUser = new Login();

            nombre = enlace.get_DatosEmpleado('S', IdUser.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            lbl_nombrec_PA.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() + " " + nombre.Rows[0][3].ToString();

            #region INICIALIZACION
            cb_idProducto.Visible = false;
            lb_productoEliminado.Visible = false;
            btn_Eliminar.Visible = false;
            btn_guardar.Visible = false;

            txt_nombre.Visible = false;
            cbUnidadMedida.Visible = false;
            txt_costo.Visible = false;
            txt_descripcion.Visible = false;
            cb_departamento.Visible = false;
            txt_cantidadInv.Visible = false;
            txt_reorden.Visible = false;
            txt_precioUnitario.Visible = false;

            lbl_idprod.Visible = false;
            lbl_nombre.Visible = false;
            lbl_departamento.Visible = false;
            lbl_medida.Visible = false;
            lbl_cantInv.Visible = false;
            lbl_costo.Visible = false;
            lbl_reorden.Visible = false;
            lbl_precioUni.Visible = false;
            lbl_descripcion.Visible = false;
            #endregion
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

        private void txt_cantidadInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

        private void txt_precioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

        private void txt_reorden_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

      
    }
}
