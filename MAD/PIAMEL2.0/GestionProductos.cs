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
            cb_idProducto.Visible = true;
            lb_productoEliminado.Visible = true;
            btn_Eliminar.Visible = true;
            btn_guardar.Visible = true;
            txt_nombre.Visible = true;
            txt_unidadmedida.Visible = true;
            txt_costo.Visible = true;
            txt_descripcion.Visible = true;
            cb_departamento.Visible = true;
            txt_cantidadInv.Visible = true;
            txt_reorden.Visible = true;
            txt_precioUnitario.Visible = true;

            cb_idProducto.Enabled = false;
            lb_productoEliminado.Visible = false;
            btn_Eliminar.Visible = false;
            btn_guardar.Visible = true;

            txt_nombre.Enabled = true;
            txt_unidadmedida.Enabled = true;
            txt_costo.Enabled = true;
            txt_descripcion.Enabled = true;
            cb_departamento.Enabled = true;
            txt_cantidadInv.Enabled = true;
            txt_reorden.Enabled = true;
            txt_precioUnitario.Enabled = true;
            //se generará un id provisional

        }

        private void btn_MProducto_Click(object sender, EventArgs e)
        {
            cb_idProducto.Visible = true;
            lb_productoEliminado.Visible = true;
            btn_Eliminar.Visible = true;
            btn_guardar.Visible = true;
            txt_nombre.Visible = true;
            txt_unidadmedida.Visible = true;
            txt_costo.Visible = true;
            txt_descripcion.Visible = true;
            cb_departamento.Visible = true;
            txt_cantidadInv.Visible = true;
            txt_reorden.Visible = true;
            txt_precioUnitario.Visible = true;



            cb_idProducto.Enabled = true;
            btn_Eliminar.Visible = false;
            btn_guardar.Visible = true;

            //se habilita y deshabiita si el producto está eliminado
            lb_productoEliminado.Visible = false;
            txt_nombre.Enabled = true;
            txt_unidadmedida.Enabled = true;
            txt_costo.Enabled = true;
            txt_descripcion.Enabled = true;
            cb_departamento.Enabled = true;
            txt_cantidadInv.Enabled = true;
            txt_reorden.Enabled = true;
            txt_precioUnitario.Enabled = true;


        }

        private void btn_EProducto_Click(object sender, EventArgs e)
        {
            cb_idProducto.Visible = true;
            lb_productoEliminado.Visible = true;
            btn_Eliminar.Visible = true;
            btn_guardar.Visible = true;
            txt_nombre.Visible = true;
            txt_unidadmedida.Visible = true;
            txt_costo.Visible = true;
            txt_descripcion.Visible = true;
            cb_departamento.Visible = true;
            txt_cantidadInv.Visible = true;
            txt_reorden.Visible = true;
            txt_precioUnitario.Visible = true;

            cb_idProducto.Enabled = true;
            btn_Eliminar.Visible = true;
            btn_guardar.Visible = false;

            //se habilita y deshabiita si el producto está eliminado
            lb_productoEliminado.Visible = false;

            txt_nombre.Enabled = false;
            txt_unidadmedida.Enabled = false;
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
            cb_idProducto.Visible = false;
            lb_productoEliminado.Visible = false;
            btn_Eliminar.Visible = false;
            btn_guardar.Visible = false;

            txt_nombre.Visible = false;
            txt_unidadmedida.Visible = false;
            txt_costo.Visible = false;
            txt_descripcion.Visible = false;
            cb_departamento.Visible = false;
            txt_cantidadInv.Visible = false;
            txt_reorden.Visible = false;
            txt_precioUnitario.Visible = false;
        }
    }
}
