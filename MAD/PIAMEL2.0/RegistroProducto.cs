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

namespace PIAMEL2._0
{
    public partial class RegistroProducto : Form
    {
        public RegistroProducto()
        {
            InitializeComponent();
        }

        private void btn_cancelar_RE_Click(object sender, EventArgs e)
        {
            GestionProductos pantalla = new GestionProductos();
            pantalla.Show();
            this.Hide();
        }

        private void RegistroProducto_Load(object sender, EventArgs e)
        {
            var obj = new EnlaceDB();
            var IdProvisional = new DataTable();
            IdProvisional = obj.ConsultaTabla("spProductos", "P"); //traigo de la base los datos del depa

            txt_id.Text = IdProvisional.Rows[0][0].ToString();

            Login gestor = new Login();
            string IdAdminstrador = gestor.getCurrentIdUser().ToString();
            lbl_idadmin.Text = IdAdminstrador;
            //busco el admin y lo imprimo
            var enlace = new EnlaceDB();
            var nombreAdmin = new DataTable();
            nombreAdmin = enlace.get_DatosEmpleado('S', Convert.ToInt32(IdAdminstrador)); //traigo de la base los datos del user q inició sesion
            txt_nameadmin.Text = nombreAdmin.Rows[0][1].ToString() + " " + nombreAdmin.Rows[0][2].ToString() + " " + nombreAdmin.Rows[0][3].ToString();


            //LLENAR LOS COMBOBOX
            var obj2 = new EnlaceDB();
            var depas = new DataTable();
            depas = obj2.ConsultaTabla("spDepartamento", "*");
            cb_departamento.DataSource = depas;
            cb_departamento.DisplayMember = "Nombre";
            cb_departamento.ValueMember = "IdDepartamento";

            cb_departamento.SelectedIndex = -1;

            cbUnidadMedida.Items.Add("Unidad");
            cbUnidadMedida.Items.Add("Kilogramos");
            cbUnidadMedida.Items.Add("Litros");
            cbUnidadMedida.Items.Add("Metros");

            cbUnidadMedida.SelectedIndex = -1;

        }

        private void btn_registrar_RE_Click(object sender, EventArgs e)
        {
            #region Validaciones

            if (txt_nombre.TextLength < 1)
            {
                MessageBox.Show("Nombre no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cb_departamento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cbUnidadMedida.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Unidad de medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_cantidadInv.TextLength < 1)
            {
                MessageBox.Show("Cantidad de Inventario no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_costo.TextLength < 1)
            {
                MessageBox.Show("Costo no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_reorden.TextLength < 1)
            {
                MessageBox.Show("Punto de Reorden no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_precioUnitario.TextLength < 1)
            {
                MessageBox.Show("Precio Unitario no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_descripcion.TextLength < 1)
            {
                MessageBox.Show("Descripcion no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            #endregion


            //busco el id del departamento seleccionado
            string departamentoSelected = cb_departamento.Text;
            
            var enlace = new EnlaceDB();
            var iddepa = new DataTable();
            iddepa = enlace.get_IdDepartamento('N', departamentoSelected); //traigo de la base los datos 
            departamentoSelected = iddepa.Rows[0][0].ToString();


            #region ALTA_PRODUCTO
            //Si cumple toda las validaciones continua y guarda la info en la base de datos
            bool control = true;

            //alta de producto
            control = enlace.add_Productos("I", Convert.ToInt32(txt_id.Text), txt_nombre.Text, Convert.ToInt32(departamentoSelected), txt_descripcion.Text, cbUnidadMedida.Text, Convert.ToDecimal(txt_costo.Text), Convert.ToInt32(txt_cantidadInv.Text));

            if (!control)
            {
                MessageBox.Show("No se pudo agregar correctamente el Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            #endregion

            #region ALTA_INFO_PRODUCTO
            control = true;
            Login gestor = new Login();

            //alta de producto
           control = enlace.add_InfoProductos("I", Convert.ToInt32(txt_id.Text), gestor.getCurrentIdUser(), Convert.ToInt32(txt_id.Text), tp_fechaIngreso.Value, Convert.ToInt32(txt_reorden.Text), Convert.ToDecimal(txt_precioUnitario.Text), Convert.ToInt32(txt_cantidadInv.Text));

            if (!control)
            {
                MessageBox.Show("No se pudo agregar correctamente Info de Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            #endregion

            #region ALTA_HISTORIAL_PRODUCTO
            control = true;

            //busco el id de info producto
            string idinfoProducto; 

            var idinfo = new DataTable();
            idinfo = enlace.get_DatosInfoProducto('S', Convert.ToInt32(txt_id.Text)); //traigo de la base los datos 
            idinfoProducto = idinfo.Rows[0][0].ToString();

            //alta de historial producto
            control = enlace.add_HistorialProductos("I", Convert.ToInt32(txt_id.Text), gestor.getCurrentIdUser(), Convert.ToInt32(idinfoProducto), tp_fechaIngreso.Value, Convert.ToInt32(txt_id.Text));

            if (!control)
            {
                MessageBox.Show("No se pudo agregar correctamente el historial de Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            #endregion

            MessageBox.Show("Se agregó correctamente el nuevo Producto", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            GestionProductos pantalla = new GestionProductos();
            pantalla.Show();
            this.Hide();
        }
    }
}
