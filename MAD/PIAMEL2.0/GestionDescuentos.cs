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

namespace MAD._0
{
    public partial class GestionDescuentos : Form
    {
        private int descuentoSelected;

        public GestionDescuentos()
        {
            InitializeComponent();
        }

        private void btn_regresar_GC_Click(object sender, EventArgs e)
        {
            PrincipalAdministrador pantalla = new PrincipalAdministrador();
            pantalla.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PA.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PA.Text = DateTime.Now.ToLongDateString();
        }

        private void GestionDescuentos_Load(object sender, EventArgs e)
        {
            var enlace = new EnlaceDB();
            var nombre = new DataTable();
            Login IdUser = new Login();

            nombre = enlace.get_DatosEmpleado('S', IdUser.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            lbl_nombrec_PA.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() + " " + nombre.Rows[0][3].ToString();


            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.ConsultaTabla("spDescuento", "*");//manda llamar el SP
            dgv_devoluciones.DataSource = tabla; //Asigna la info a la tabla
        }

        private void btn_NProducto_Click(object sender, EventArgs e)
        {
            RegistroDescuentos pantalla = new RegistroDescuentos();
            pantalla.Show();
            this.Hide();
        }

        private void btn_MProducto_Click(object sender, EventArgs e)
        {
            if (descuentoSelected != 0)
            {
                #region Validaciones

                var enlace = new EnlaceDB();
                DialogResult result = MessageBox.Show("¿Está seguro que desea modificar este elemento?", "Modificar", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se modificó el departamento", "Cancelado", MessageBoxButtons.OK);
                    return;
                }

                if (txtx_porcentaje.TextLength < 1)
                {
                    MessageBox.Show("Porcentaje no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //validacion de las fechas -----------------------------------------------------------------------------------------
                #endregion

                //Si cumple toda las validaciones continua y guarda la info en la base de datos
                var desceunto = new EnlaceDB();
                bool control;


                //modifica de descuento
                control = desceunto.add_Descuento("U", Convert.ToInt32(LBL_IDDESCUENTO.Text), Convert.ToInt32(IDPRODUCTO.Text), Convert.ToInt32(LBL_Depa.Text), Convert.ToInt32(lbl_idadmin.Text), Convert.ToInt32(txtx_porcentaje.Text), DateInicio.Value, DateFinal.Value);

                if (!control)
                {
                    MessageBox.Show("No se pudo modificar correctamente el descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Se modificó correctamente el descuento", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Selecciona un descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        

        private void dgv_devoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login gestor = new Login();

            var row = (sender as DataGridView).CurrentRow;
            descuentoSelected = Convert.ToInt32(row.Cells[0].Value.ToString()); //ID DEL descuento SELECCIONADO

            var obj = new EnlaceDB();
            var INFO = new DataTable();
            INFO = obj.get_DatosDescuento('T', descuentoSelected); //traigo de la base los datos del empleado

            if (INFO.Rows.Count >= 1)
            {
                LBL_IDDESCUENTO.Text = INFO.Rows[0][0].ToString();
                IDPRODUCTO.Text = INFO.Rows[0][1].ToString();
                LBL_Depa.Text = INFO.Rows[0][2].ToString();
                lbl_idadmin.Text = INFO.Rows[0][3].ToString();
                txtx_porcentaje.Text = INFO.Rows[0][4].ToString();
                DateInicio.Value = Convert.ToDateTime(INFO.Rows[0][5].ToString());
                DateFinal.Value = Convert.ToDateTime(INFO.Rows[0][6].ToString());
               
            }

            //BUSCO EL PRODUCTO
            string IdProducto = INFO.Rows[0][1].ToString();
            var nombreproducto = new DataTable();
            nombreproducto = obj.get_DatosProductos('S', Convert.ToInt32(IdProducto)); //traigo de la base los datos del user q inició sesion
            txt_producto.Text = nombreproducto.Rows[0][2].ToString();

            //BUSCO EL DEPARTAMENTO
            string IdDepa = INFO.Rows[0][2].ToString();
            var NombreDepa = new DataTable();
            NombreDepa = obj.get_DatosDepartamento('S', Convert.ToInt32(IdDepa)); //traigo de la base los datos del user q inició sesion
            txt_depa.Text = NombreDepa.Rows[0][1].ToString();

            //BUSCO EL ADMIN
            string IdAdminstrador = INFO.Rows[0][3].ToString();
            var nombreAdmin = new DataTable();
            nombreAdmin = obj.get_DatosEmpleado('S', Convert.ToInt32(IdAdminstrador)); //traigo de la base los datos del user q inició sesion
            txt_nameadmin.Text = nombreAdmin.Rows[0][1].ToString() + " " + nombreAdmin.Rows[0][2].ToString() + " " + nombreAdmin.Rows[0][3].ToString();


        }

        private void btn_EProducto_Click(object sender, EventArgs e)
        {
            if (descuentoSelected != 0)
            {
                var enlace = new EnlaceDB();
                DialogResult result = MessageBox.Show("Esta acción es irreversible\n\n Se le quitará el descuento a este producto ¿Está seguro que desea continuar?", "Eliminar", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se eliminó el descuento", "Cancelado", MessageBoxButtons.OK);
                    return;
                }


                enlace.get_DatosDescuento('E', descuentoSelected);

                MessageBox.Show("se eliminó correctamente el descuento", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

                bool control;
                //actualizo el descuento en producto de que se lo han quitado
                control = enlace.actualiza_Descuento('O', Convert.ToInt32(IDPRODUCTO.Text));

                if (!control)
                {
                    MessageBox.Show("No se pudo modificar correctamente el descuento en producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Se modificó correctamente el descuento en producto", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //recargar pantalla
                this.Close();
                GestionDescuentos pantalla = new GestionDescuentos();
                pantalla.Show();

            }
            else
            {
                MessageBox.Show("Selecciona un descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
