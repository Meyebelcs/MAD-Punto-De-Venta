using MAD._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PIAMEL2._0
{
    public partial class gestionEmpleados : Form
    {

        Login IdUser = new Login();

        private int empleadoSelected;
        public gestionEmpleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Telefono_RE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

        private void chb_admin_RE_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_admin_RE.Checked) //valida si admin está checked
            {
                chb_cajero_RE.Checked = false;
                txt_codigoAcceso_RE.Enabled = true;
            }
        }

        private void chb_cajero_RE_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_cajero_RE.Checked)//valida si cajero está checked
            {
                chb_admin_RE.Checked = false;
                txt_codigoAcceso_RE.Enabled = false;
                txt_codigoAcceso_RE.Text = " ";
            }
        }

        private void txt_codigoAcceso_RE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

        private void btn_registrar_RE_Click(object sender, EventArgs e)
        {
            //validacion de fecha
            ValidarFecha();
        }

        void ValidarFecha()
        {
            DateTime hoy = DateTime.Today;
            if (tp_fechaNacimiento.Value.Date >= hoy) //valida que sea menor a hoy
            {
                MessageBox.Show("Fecha inválida, no puedes seleccionar una fecha futura o presente", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tp_fechaNacimiento.Value.Date.AddYears(18) > hoy) //valida que sea mayor de edad
            {
                MessageBox.Show("Eres menor de edad", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_nomina_RE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

        private void gestionEmpleados_Load(object sender, EventArgs e)
        {
            var enlace = new EnlaceDB();
            var nombre = new DataTable();
            nombre = enlace.get_DatosEmpleado('S', IdUser.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            lbl_nombrec_PA.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() +" " + nombre.Rows[0][3].ToString();
           
            var obj = new EnlaceDB(); 

            //Muestra la tabla con la info de los empleados
            var tablita = new DataTable();
            tablita = obj.get_Empleados('*');
            dgv_empleados.DataSource = tablita;

        }

        private void btn_cancelar_RE_Click(object sender, EventArgs e)
        {
            PrincipalAdministrador pantalla = new PrincipalAdministrador();
            pantalla.Show();
            this.Hide();
        }

        private void dgv_empleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            empleadoSelected = Convert.ToInt32(row.Cells[0].Value.ToString()); //ID DEL EMPLEADO SELECCIONADO

            var obj = new EnlaceDB();
            var INFO = new DataTable();
            INFO = obj.get_DatosEmpleado('S', empleadoSelected); //traigo de la base los datos del empleado

            if (INFO.Rows.Count >= 1)
            {
                txt_usuario_RE.Text = INFO.Rows[0][0].ToString();
                txt_nombre_RE.Text = INFO.Rows[0][1].ToString();
                txt_ApellidoP_RE.Text = INFO.Rows[0][2].ToString();
                txt_ApellidoM_RE.Text = INFO.Rows[0][3].ToString();
                txt_Email_RE.Text = INFO.Rows[0][4].ToString();
                tp_fechaIngreso.Value = Convert.ToDateTime(INFO.Rows[0][5].ToString());
                txt_curp_RE.Text = INFO.Rows[0][6].ToString();
                txt_nomina_RE.Text = INFO.Rows[0][7].ToString();
                txt_Telefono_RE.Text = INFO.Rows[0][8].ToString();
                tp_fechaNacimiento.Value = Convert.ToDateTime(INFO.Rows[0][9].ToString());
                txt_contraseña_RE.Text = INFO.Rows[0][10].ToString();

            }

            var chequeo = new EnlaceDB(); 

            if (chequeo.validarRol(empleadoSelected))
            {
                //Es administrador
                chb_admin_RE.Checked = true;
                chb_cajero_RE.Checked = false;
                txt_codigoAcceso_RE.Enabled = true;

                var enlace = new EnlaceDB();
                var codigo = new DataTable();
                codigo = enlace.get_DatosAdmin('V',empleadoSelected); //traigo de la base los datos del ADMINISTRADOR

                txt_codigoAcceso_RE.Text = codigo.Rows[0][2].ToString();

            }
            else
            {   //Es cajero
                chb_admin_RE.Checked = false;
                chb_cajero_RE.Checked = true;
                txt_codigoAcceso_RE.Enabled = false;
                txt_codigoAcceso_RE.Text = " ";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PA.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PA.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            RegistroEmpleado pantalla = new RegistroEmpleado();
            pantalla.Show();
            this.Hide();
        }
    }
}
