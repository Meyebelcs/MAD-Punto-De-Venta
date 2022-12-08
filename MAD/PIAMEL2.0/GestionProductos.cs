using MAD._0;
using PIAMEL2._0;
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
        private int ProductSelected;
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

            RegistroProducto pantalla = new RegistroProducto();
            pantalla.Show();
            this.Hide();

        }

        private void btn_MProducto_Click(object sender, EventArgs e)
        {
         

            //se habilita y deshabiita si el producto está eliminado
            lb_productoEliminado.Visible = false;
          


        }

        private void btn_EProducto_Click(object sender, EventArgs e)
        {
            var resp = new DialogResult();

            resp = MessageBox.Show("¿Seguro que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                //SE ELIMINA EL PRODUCTO O MAS BIEN, SE VUELVE TRUE EL BIT DE ELIMINACION
                MessageBox.Show("Este producto ha sido eliminado", "Eliminación", MessageBoxButtons.OK);
            }

            //se habilita y deshabiita si el producto está eliminado
            lb_productoEliminado.Visible = false;


        }


        private void GestionProductos_Load(object sender, EventArgs e)
        {
            var enlace = new EnlaceDB();
            var nombre = new DataTable();
            Login IdUser = new Login();

            nombre = enlace.get_DatosEmpleado('S', IdUser.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            lbl_nombrec_PA.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() + " " + nombre.Rows[0][3].ToString();


            //Muestra la tabla con la info de los productos
            var tablita = new DataTable();
            tablita = enlace.ConsultaTabla("spProductos", "*");
            dgv_productos.DataSource = tablita;
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

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login gestor = new Login();

            var row = (sender as DataGridView).CurrentRow;
            ProductSelected = Convert.ToInt32(row.Cells[0].Value.ToString()); //ID DEL producto SELECCIONADO

            var obj = new EnlaceDB();
            var INFO = new DataTable();
            INFO = obj.get_DatosProductos('S', ProductSelected); //traigo de la base los datos del empleado

            if (INFO.Rows.Count >= 1)
            {
            
                txt_id.Text = INFO.Rows[0][0].ToString();
                cb_departamento.Text = INFO.Rows[0][1].ToString();
                txt_nombre.Text = INFO.Rows[0][2].ToString();
                txt_descripcion.Text = INFO.Rows[0][3].ToString();
                cb_descuento.Text = INFO.Rows[0][4].ToString();
                cbUnidadMedida.Text = INFO.Rows[0][5].ToString();
                txt_costo.Text = INFO.Rows[0][6].ToString();
                txt_cantidadInv.Text = INFO.Rows[0][8].ToString();

            }

        }
    }
}
