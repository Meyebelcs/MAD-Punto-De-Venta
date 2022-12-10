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
    public partial class GestionDepartamentos : Form
    {
        Login IdUser = new Login();
        private int departamentSelected;

        public GestionDepartamentos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PA.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PA.Text = DateTime.Now.ToLongDateString();
        }

        private void GestionDepartamentos_Load(object sender, EventArgs e)
        {
            var enlace = new EnlaceDB();
            var nombre = new DataTable();
            nombre = enlace.get_DatosEmpleado('S', IdUser.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            lbl_nombrec_PA.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() + " " + nombre.Rows[0][3].ToString();

            var obj = new EnlaceDB();

            //Muestra la tabla con la info de los departamentos
            var tablita = new DataTable();
            tablita = obj.ConsultaTabla("spDepartamento", "*");
            dgv_empleados.DataSource = tablita;

        }

        private void btn_cancelar_RE_Click(object sender, EventArgs e)
        {
            PrincipalAdministrador pantalla = new PrincipalAdministrador();
            pantalla.Show();
            this.Hide();
        }

        private void dgv_empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login gestor = new Login();

            var row = (sender as DataGridView).CurrentRow;
            departamentSelected = Convert.ToInt32(row.Cells[0].Value.ToString()); //ID DEL EMPLEADO SELECCIONADO

            var obj = new EnlaceDB();
            var INFO = new DataTable();
            INFO = obj.get_DatosDepartamento('S', departamentSelected); //traigo de la base los datos del empleado

            if (INFO.Rows.Count >= 1)
            {
                txt_idepa.Text = INFO.Rows[0][0].ToString();
                txt_nombre_RE.Text = INFO.Rows[0][1].ToString();
                txt_dexcription.Text = INFO.Rows[0][2].ToString();
                txt_IdAdminstrador.Text = INFO.Rows[0][3].ToString();

                string devolucion = INFO.Rows[0][4].ToString();
                if (devolucion == "True")
                {
                    chb_PermiteDevolucion.Checked = true;
                }
                else
                {
                    chb_PermiteDevolucion.Checked = false;
                }
                tp_fechaIngreso.Value = Convert.ToDateTime(INFO.Rows[0][6].ToString());

                string IdAdminstrador = INFO.Rows[0][3].ToString();
                //busco el admin y lo imprimo
                var enlace = new EnlaceDB();
                var nombreAdmin = new DataTable();
                nombreAdmin = enlace.get_DatosEmpleado('S', Convert.ToInt32(IdAdminstrador)); //traigo de la base los datos del user q inició sesion
                txt_nombreadmin.Text = nombreAdmin.Rows[0][1].ToString() + " " + nombreAdmin.Rows[0][2].ToString() + " " + nombreAdmin.Rows[0][3].ToString();

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            RegistroDepartamento pantalla = new RegistroDepartamento();
            pantalla.Show();
            this.Hide();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (departamentSelected != 0)
            {

                #region Validaciones

                var enlace = new EnlaceDB();
                DialogResult result = MessageBox.Show("¿Está seguro que desea modificar este elemento?", "Modificar", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se modificó el departamento", "Cancelado", MessageBoxButtons.OK);
                    return;
                }

                if (txt_nombre_RE.TextLength < 1)
                {
                    MessageBox.Show("Nombre no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txt_dexcription.TextLength < 1)
                {
                    MessageBox.Show("Descripción no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //VALIDACIONES DE DATOS Q NO DEBEN REPETIRSE
                var tablita = new DataTable();
                tablita = enlace.ConsultaTabla("spDepartamento", "T");

                //Que el nombre no se repita

                if (tablita.Rows.Count >= 0)
                {
                    foreach (DataRow fila in tablita.Rows)
                    {
                        if (fila["Nombre"].ToString() == txt_nombre_RE.Text && fila["IdDepartamento"].ToString() != txt_idepa.Text)
                        {
                            MessageBox.Show("Ya existe un departamento con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
                #endregion

                //Si cumple toda las validaciones continua y guarda la info en la base de datos
                var empleado = new EnlaceDB();
                bool control;

                int devolucion = 0;
                if (chb_PermiteDevolucion.Checked == true)
                {
                    devolucion = 1;
                }

                //modifica de departamento
                control = empleado.add_Departamento("U", Convert.ToInt32(txt_idepa.Text), txt_nombre_RE.Text, txt_dexcription.Text, Convert.ToInt32(txt_IdAdminstrador.Text), devolucion, tp_fechaIngreso.Value);

                if (!control)
                {
                    MessageBox.Show("No se pudo modificar correctamente el departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Se modificó correctamente el departamento", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Selecciona un departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (departamentSelected != 0)
            {
                var enlace = new EnlaceDB();
                DialogResult result = MessageBox.Show("Esta acción es irreversible\n\n ¿Está seguro que desea continuar?", "Eliminar", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se eliminó el departamento", "Cancelado", MessageBoxButtons.OK);
                    return;
                }

                //validar si existen productos con este departamento
                string departamentoSelected = txt_idepa.Text;

                var obj = new EnlaceDB();
                var busquedadepa = new DataTable();
                busquedadepa = obj.get_DatosDepartamento( 'B', Convert.ToInt32(departamentoSelected)); //traigo de la base los datos del depa

                string existe = busquedadepa.Rows[0][0].ToString();

                if (existe == "1")
                {
                    MessageBox.Show("No se puede eliminar este departamento porque hay productos asignados a este" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                enlace.get_DatosDepartamento('E', departamentSelected);

                MessageBox.Show("se eliminó correctamente el departamento", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

                //recargar pantalla
                this.Close();
                GestionDepartamentos pantalla = new GestionDepartamentos();
                pantalla.Show();
              
            }
            else
            {
                MessageBox.Show("Selecciona un departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
