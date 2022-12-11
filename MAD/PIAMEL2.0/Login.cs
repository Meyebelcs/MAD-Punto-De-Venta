using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MAD._0;

namespace MAD._0
{
    public partial class Login : Form
    {
        private static int usuario;
        private static bool Admin;
        private static string NumCaja;
        private static int compra = 0;

        public void setEstadoCompra(int estado)
        {
            compra = estado;
        }
        public int getEstadoCompra()
        {
            return compra;
        }
        public Login()
        {
            InitializeComponent();
        }
        public void setNumCaja(string num)
        {
            NumCaja = num;
        }
        public string getNumCaja()
        {
            return NumCaja;
        }
        public int getCurrentIdUser()
        {
            return usuario;
        }
        public bool getCurrentRol()
        {
            return Admin;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {

            if (txt_user.TextLength < 1)
            {
                MessageBox.Show("El campo usuario no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            if (txt_pass.TextLength < 1)
            {
                MessageBox.Show("El campo contraseña no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            if (chb_admin.Checked) //valida si admin está checked
            {

                var obj = new EnlaceDB();
                var existe = new DataTable();
                existe = obj.LOGIN( 'A', txt_pass.Text, Convert.ToInt32(txt_user.Text)); //traigo de la base los datos del empleado

               string validacion= existe.Rows[0][0].ToString();

                if (validacion != "0")
                {
                    usuario = Convert.ToInt32(txt_user.Text);
                    Admin = true;

                    PrincipalAdministrador pantalla = new PrincipalAdministrador();
                    pantalla.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las credenciales ingresadas no pertenecen a ningun usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else//si es cajero abre principal cajero
            {

                var obj = new EnlaceDB();
                var existe = new DataTable();
                existe = obj.LOGIN('C', txt_pass.Text, Convert.ToInt32(txt_user.Text)); //traigo de la base los datos del empleado

                string validacion = existe.Rows[0][0].ToString();

                if (validacion != "0")
                {
                    usuario = Convert.ToInt32(txt_user.Text);
                    Admin = false;

                    PrincipalCajero pantalla = new PrincipalCajero();
                    pantalla.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las credenciales ingresadas no pertenecen a ningun usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

            var resp = new DialogResult();

            resp = MessageBox.Show("¿Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //var frmRegistroEmpleado = new RegistroEmpleado();

            //frmRegistroEmpleado.Show();//Ventana NO Modal
            //  frmRegistroEmpleado.ShowDialog(); //Ventana Modal

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
