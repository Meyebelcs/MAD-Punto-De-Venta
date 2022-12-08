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

            //LLENAR LOS COMBOBOX
            var obj2 = new EnlaceDB();
            var depas = new DataTable();
            depas = obj2.ConsultaTabla("spDepartamento", "*");
            cb_departamento.DataSource = depas;
            cb_departamento.DisplayMember = "Nombre";
            cb_departamento.ValueMember = "IdDepartamento";

            cb_departamento.SelectedIndex = -1;

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
            INFO = obj.get_DatosProductos('S', ProductSelected); //traigo de la base los datos del PRODUCT

            if (INFO.Rows.Count >= 1)
            {
                txt_id.Text = INFO.Rows[0][0].ToString();
               
                txt_nombre.Text = INFO.Rows[0][2].ToString();
                txt_descripcion.Text = INFO.Rows[0][3].ToString();
                cb_descuento.Text = INFO.Rows[0][4].ToString();
                cbUnidadMedida.Text = INFO.Rows[0][5].ToString();
                txt_costo.Text = INFO.Rows[0][6].ToString();
                txt_cantidadInv.Text = INFO.Rows[0][8].ToString();

                //Imprimo el noombre del departamento 
                int iddepa = Convert.ToInt32(INFO.Rows[0][1].ToString());
                var INFO_Depa = new DataTable();
                INFO_Depa = obj.get_DatosDepartamento('S', iddepa); //traigo de la base los datos del departamento

                cb_departamento.Text = INFO_Depa.Rows[0][1].ToString();
            }

            var INFO_Product = new DataTable();
            INFO_Product = obj.get_Datos_InfoProductos('S', ProductSelected); //traigo de la base los datos del PRODUCT

            if (INFO_Product.Rows.Count >= 1)
            {
                lbl_idadmin.Text = INFO_Product.Rows[0][1].ToString();
                tp_fechaIngreso.Value = Convert.ToDateTime(INFO_Product.Rows[0][3].ToString());
                txt_reorden.Text = INFO_Product.Rows[0][4].ToString();
                txt_precioUnitario.Text = INFO_Product.Rows[0][5].ToString();
                string eliminacion = INFO_Product.Rows[0][6].ToString();
                string IdAdminstrador= INFO_Product.Rows[0][1].ToString();

                //busco el admin y lo imprimo
                var enlace = new EnlaceDB();
                var nombreAdmin = new DataTable();
                nombreAdmin = enlace.get_DatosEmpleado('S', Convert.ToInt32(IdAdminstrador)); //traigo de la base los datos del user q inició sesion
                txt_nameadmin.Text = nombreAdmin.Rows[0][1].ToString() + " " + nombreAdmin.Rows[0][2].ToString() + " " + nombreAdmin.Rows[0][3].ToString();


                if (eliminacion == "True")
                {
                    lb_productoEliminado.Visible = true;
                    txt_nombre.Enabled = false;
                    cbUnidadMedida.Enabled = false;
                    txt_costo.Enabled = false;
                    txt_precioUnitario.Enabled = false;
                    cb_departamento.Enabled = false;
                    txt_cantidadInv.Enabled = false;
                    txt_reorden.Enabled = false;
                    txt_descripcion.Enabled = false;
                    cb_descuento.Enabled = false;
                    tp_fechaIngreso.Enabled = false;
                    btn_EProducto.Visible = false;
                    btn_MProducto.Visible=false;
                }
                else
                {
                    lb_productoEliminado.Visible = false;
                    txt_nombre.Enabled = true;
                    cbUnidadMedida.Enabled = true;
                    txt_costo.Enabled = true;
                    txt_precioUnitario.Enabled = true;
                    cb_departamento.Enabled = true;
                    txt_cantidadInv.Enabled = true;
                    txt_reorden.Enabled = true;
                    txt_descripcion.Enabled = true;
                    cb_descuento.Enabled = true;
                    tp_fechaIngreso.Enabled = true;
                    btn_EProducto.Visible = true;
                    btn_MProducto.Visible = true;
                }

            }
        }
    }
}
