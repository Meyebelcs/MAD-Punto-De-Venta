using MAD._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

            #region Validaciones

            if (txt_nombre_RE.TextLength < 1)
            {
                MessageBox.Show("Nombre no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_nomina_RE.TextLength < 1)
            {
                MessageBox.Show("Numero de Nomina no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_contraseña_RE.TextLength < 1)
            {
                MessageBox.Show("La contraseña no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_ApellidoP_RE.TextLength < 1)
            {
                MessageBox.Show("Apellido paterno no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_ApellidoM_RE.TextLength < 1)
            {
                MessageBox.Show("Apellido materno no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_curp_RE.TextLength < 15)
            {
                MessageBox.Show("El curp debe contener 15 carácteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_curp_RE.Text.All(char.IsDigit))
            {
                MessageBox.Show("El curp no puede contener solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_curp_RE.Text.All(char.IsLetter))
            {
                MessageBox.Show("El curp no puede contener solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_Telefono_RE.TextLength < 10)
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_Email_RE.TextLength < 1)
            {
                MessageBox.Show("El correo electrónico no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string pattern = "(\\w+)(\\.|_)?(\\w*)@(\\w+)(\\.(\\w+))+";
            if (!Regex.IsMatch(txt_Email_RE.Text, pattern))
            {
                MessageBox.Show("La dirección de correo electrónico no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chb_admin_RE.Checked)
            { //si es admin

                if (txt_codigoAcceso_RE.TextLength < 1)
                {
                    MessageBox.Show("El codigo de acceso no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (!chb_admin_RE.Checked && !chb_cajero_RE.Checked)
            { //no hay nada seleccionado
                MessageBox.Show("Selecciona el rol de este empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //validacion de fecha de nacimiento q sea mayor de edad y no fecha futura
            if (!ValidarFecha())
            {
                return;
            }


            //valida fecha de ingreso
            //
            //capturar el primer id de empleados
            //buscar su fecha de ingreso
            //validar la fecha de ingreso con esa que trajimos de la base
            //validar que no se repita el codigo de acceso del administrador si esq lo es
            //validacion de la fecha de ingreso. Que sea una fecha en la que ya existe la empresa
            //--------------------------------------------------------------------------


            //VALIDACIONES DE DATOS Q NO DEBEN REPETIRSE
            var enlace = new EnlaceDB();
            var tablita = new DataTable();
            tablita = enlace.get_Empleados("T");

            //Que el cODIGO DE ACCCESO no se repita------------------------------------


            //Que el CURP no se repita

            if (tablita.Rows.Count >= 0)
            {
                foreach (DataRow fila in tablita.Rows)
                {
                    if (fila["CURP"].ToString() == txt_curp_RE.Text && fila["IdEmpleados"].ToString() != txt_usuario_RE.Text)
                    {
                        MessageBox.Show("El CURP que ingresó ya se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            //Que el Num de nomina no se repita

            if (tablita.Rows.Count >= 0)
            {
                foreach (DataRow fila in tablita.Rows)
                {
                    if (fila["Nomina"].ToString() == txt_nomina_RE.Text && fila["IdEmpleados"].ToString() != txt_usuario_RE.Text)
                    {
                        MessageBox.Show("El Numero de Nomina que ingresó ya se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            #endregion

            //Si cumple toda las validaciones continua y guarda la info en la base de datos
            var empleado = new EnlaceDB();
            bool control;

            int nomina = Convert.ToInt32(txt_nomina_RE.Text);

            //modifica de empleado
            control = empleado.add_Empleados("U", empleadoSelected, txt_nombre_RE.Text, txt_ApellidoP_RE.Text, txt_ApellidoM_RE.Text, Convert.ToInt32(txt_Telefono_RE.Text), txt_contraseña_RE.Text, tp_fechaNacimiento.Value, txt_curp_RE.Text, txt_Email_RE.Text, tp_fechaIngreso.Value, nomina);

            if (!control)
            {
                MessageBox.Show("No se pudo modificar correctamente el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            //VALIDACION DE CAJERO Y ADMIN

            var chequeo = new EnlaceDB();
            Login gestor = new Login();

            if (chequeo.validarRol(empleadoSelected) && chb_cajero_RE.Checked && empleadoSelected != gestor.getCurrentIdUser())
            {


                //buscar idadmin del seleccionado
                var enlace2 = new EnlaceDB();
                var idadmin = new DataTable();
                idadmin = enlace2.get_DatosAdmin('V', empleadoSelected); //traigo de la base los datos del idadmin 
                string idadministrador = idadmin.Rows[0][0].ToString();


                //si es qadministrador y cambio a cajero
                //se elimina el admin
                var administrador = new EnlaceDB();
                bool admin;

                admin = administrador.add_Administrador("E", Convert.ToInt32(txt_usuario_RE.Text), Convert.ToInt32(idadministrador), 0);
                if (!admin)
                {
                    MessageBox.Show("No se pudo ELIMINAR correctamente el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Se ELIMINÓ correctamente el administrador", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // y crea cajero
                var CAJERO = new EnlaceDB();
                bool cajeros;

                cajeros = CAJERO.add_Cajero("I", Convert.ToInt32(txt_usuario_RE.Text), Convert.ToInt32(txt_usuario_RE.Text), gestor.getCurrentIdUser());
                if (!cajeros)
                {
                    MessageBox.Show("No se pudo AGREGAR correctamente el cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Se AGREGÓ correctamente el cajero", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (chequeo.validarRol(empleadoSelected) && chb_admin_RE.Checked && empleadoSelected != gestor.getCurrentIdUser())
                {  //update al admin


                    var administrador = new EnlaceDB();
                    bool admin;

                    admin = administrador.add_Administrador("U", Convert.ToInt32(txt_usuario_RE.Text), Convert.ToInt32(txt_usuario_RE.Text), Convert.ToInt32(txt_codigoAcceso_RE.Text));
                    if (!admin)
                    {
                        MessageBox.Show("No se pudo modificar correctamente el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }
                    MessageBox.Show("Se modificó correctamente el nuevo administrador", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (!chequeo.validarRol(empleadoSelected) && chb_admin_RE.Checked && empleadoSelected != gestor.getCurrentIdUser())
            {
                //si es cajero y cambio a admin
                //se elimina el cajero 

                if (txt_codigoAcceso_RE.TextLength < 1 || txt_codigoAcceso_RE.Text == " ")
                {
                    MessageBox.Show("El codigo de acceso no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //buscar idcajero del seleccionado
                var enlace2 = new EnlaceDB();
                var idcaj = new DataTable();
                idcaj = enlace2.get_DatosCajero('V', empleadoSelected); //traigo de la base los datos del idcajero 
                string idcajero = idcaj.Rows[0][0].ToString();

                var CAJERO = new EnlaceDB();
                bool cajeros;
                cajeros = CAJERO.add_Cajero("E", Convert.ToInt32(idcajero), Convert.ToInt32(txt_usuario_RE.Text), 0);
                if (!cajeros)
                {
                    MessageBox.Show("No se pudo ELIMINAR correctamente el cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Se ELIMINÓ correctamente el cajero", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //y se crea el admimn
                //CREA EL NUEVO ADMINISTRADOR
                var administrador = new EnlaceDB();
                bool admin;


                admin = administrador.add_Administrador("I", Convert.ToInt32(empleadoSelected), Convert.ToInt32(txt_usuario_RE.Text), Convert.ToInt32(txt_codigoAcceso_RE.Text));
                if (!admin)
                {
                    MessageBox.Show("No se pudo AGREGAR correctamente el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Se AGREGÓ correctamente el nuevo administrador", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (!chequeo.validarRol(empleadoSelected) && chb_cajero_RE.Checked && empleadoSelected != gestor.getCurrentIdUser())
                {
                    //sino
                    //update al cajero
                    var cajero = new EnlaceDB();
                    bool cajeroval;


                    cajeroval = cajero.add_Cajero("U", Convert.ToInt32(txt_usuario_RE.Text), Convert.ToInt32(txt_usuario_RE.Text), gestor.getCurrentIdUser());
                    if (!cajeroval)
                    {
                        MessageBox.Show("No se pudo modificar correctamente el cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }
                    MessageBox.Show("Se modificó correctamente el nuevo cajero", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            MessageBox.Show("Se modificó correctamente el nuevo empleado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        bool ValidarFecha()
        {
            bool isvalid = true;

            DateTime hoy = DateTime.Today;
            if (tp_fechaNacimiento.Value.Date >= hoy) //valida que sea menor a hoy
            {
                isvalid = false;
                MessageBox.Show("Fecha inválida, no puedes seleccionar una fecha futura o presente", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tp_fechaNacimiento.Value.Date.AddYears(18) > hoy) //valida que sea mayor de edad
            {
                isvalid = false;
                MessageBox.Show("Eres menor de edad", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isvalid;
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
            lbl_nombrec_PA.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() + " " + nombre.Rows[0][3].ToString();

            var obj = new EnlaceDB();

            //Muestra la tabla con la info de los empleados
            var tablita = new DataTable();
            tablita = obj.get_Empleados("*");
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


        private void dgv_empleados_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Login gestor = new Login();

            var row = (sender as DataGridView).CurrentRow;
            empleadoSelected = Convert.ToInt32(row.Cells[0].Value.ToString()); //ID DEL EMPLEADO SELECCIONADO

            if (empleadoSelected == gestor.getCurrentIdUser())
            {
                gb_check_RE.Enabled = false;
                chb_admin_RE.Enabled = false;
                chb_cajero_RE.Enabled = false;
                txt_codigoAcceso_RE.Enabled = false;
                txt_codigoAcceso_RE.ReadOnly = true;
            }
            else
            {
                gb_check_RE.Enabled = true;
                chb_admin_RE.Enabled = true;
                chb_cajero_RE.Enabled = true;
                txt_codigoAcceso_RE.Enabled = true;
                txt_codigoAcceso_RE.ReadOnly = false;
            }


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
                codigo = enlace.get_DatosAdmin('V', empleadoSelected); //traigo de la base los datos del ADMINISTRADOR

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

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            if (empleadoSelected != 0)
            {
                var enlace = new EnlaceDB();
                DialogResult result = MessageBox.Show("Esta acción es irreversible\n\n ¿Está seguro que desea continuar?", "Eliminar", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se eliminó el empleado", "Cancelado", MessageBoxButtons.OK);
                    return;
                }

                enlace.get_DatosEmpleado('E', empleadoSelected);

                MessageBox.Show("se eliminó correctamente el empleado", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

                //recargar pantalla
            }
            else
            {
                MessageBox.Show("Selecciona un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
