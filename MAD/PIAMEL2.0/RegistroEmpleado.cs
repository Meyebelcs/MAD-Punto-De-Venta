using PIAMEL2._0;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MAD._0
{
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private void btn_cancelar_RE_Click(object sender, EventArgs e)
        {
            gestionEmpleados pantalla = new gestionEmpleados();
            pantalla.Show();
            this.Hide();
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
                MessageBox.Show("El teléfono 1 debe tener 10 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            if (chb_admin_RE.Checked) { //si es admin

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
            if (!ValidarFecha()) {
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

            //Que el CURP no se repita

                if (tablita.Rows.Count >= 0)
                {
                    foreach (DataRow fila in tablita.Rows)
                    {
                        if (fila["CURP"].ToString() == txt_curp_RE.Text)
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
                    if (fila["Nomina"].ToString() == txt_nomina_RE.Text)
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

            //alta de empleado
            control =  empleado.add_Empleados("I", 0, txt_nombre_RE.Text, txt_ApellidoP_RE.Text, txt_ApellidoM_RE.Text, Convert.ToInt32( txt_Telefono_RE.Text), txt_contraseña_RE.Text, tp_fechanac.Value, txt_curp_RE.Text, txt_Email_RE.Text, tp_fechaIngreso.Value, nomina);

            if (!control)
            {
                MessageBox.Show("No se pudo agregar correctamente el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            //dar de alta al admin o cajero segun el caso
            if (chb_admin_RE.Checked)
            {
                //CREA EL NUEVO ADMINISTRADOR
                var administrador = new EnlaceDB();
                bool admin;

                admin = administrador.add_Administrador("I", Convert.ToInt32(txt_usuario_RE.Text), Convert.ToInt32(txt_usuario_RE.Text), Convert.ToInt32(txt_codigoAcceso_RE.Text));
                if (!admin)
                {
                    MessageBox.Show("No se pudo agregar correctamente el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Se agregó correctamente el nuevo administrador", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                //CREA EL NUEVO CAJERO
                var cajero = new EnlaceDB();
                bool cajeroval;
                Login gestor = new Login();

                cajeroval = cajero.add_Cajero("I", Convert.ToInt32(txt_usuario_RE.Text), Convert.ToInt32(txt_usuario_RE.Text), gestor.getCurrentIdUser()); 
                if (!cajeroval)
                {
                    MessageBox.Show("No se pudo agregar correctamente el cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Se agregó correctamente el nuevo cajero", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            MessageBox.Show("Se agregó correctamente el nuevo empleado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            gestionEmpleados pantalla = new gestionEmpleados();
            pantalla.Show();
            this.Hide();
        }

        bool ValidarFecha()
        {
            bool isvalid = true;

            DateTime hoy = DateTime.Today;
            if (tp_fechanac.Value.Date >= hoy) //valida que sea menor a hoy
            {
                isvalid = false;
                MessageBox.Show("Fecha inválida, no puedes seleccionar una fecha futura o presente", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tp_fechanac.Value.Date.AddYears(18) > hoy) //valida que sea mayor de edad
            {
                isvalid = false;
                MessageBox.Show("Eres menor de edad", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isvalid;
        }


        private void txt_nomina_RE_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {


            var obj = new EnlaceDB();
            var IdProvisional = new DataTable();
            IdProvisional = obj.get_Empleados("P"); //traigo de la base los datos del empleado


            txt_usuario_RE.Text = IdProvisional.Rows[0][0].ToString();
        }
    }
}

