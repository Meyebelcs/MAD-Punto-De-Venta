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
                    chb_PermiteDevolucion.Checked=true;
                }
                else
                {
                    chb_PermiteDevolucion.Checked=false;
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
    }
}
