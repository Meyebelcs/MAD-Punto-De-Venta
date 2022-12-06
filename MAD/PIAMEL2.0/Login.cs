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

        public Login()
        {
            InitializeComponent();
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
                var enlace = new EnlaceDB();
                if (enlace.Autentificar("A", Convert.ToInt32(txt_user.Text), txt_pass.Text)) 
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
                var enlace = new EnlaceDB();
                if (enlace.Autentificar("C", Convert.ToInt32(txt_user.Text), txt_pass.Text))
                {
                 

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

            resp = MessageBox.Show("¿Seguro que desea salir?", "Confirmación",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resp == DialogResult.Yes)
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

    }
}
