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
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conection = new SqlConnection("server= DESKTOP-IMKRRN7\\SQLEXPRESS ; database = DB_MAD ; INTEGRATED SECURITY = true");

        private void btn_login_Click(object sender, EventArgs e)
        {
            conection.Open();
            SqlCommand comando = new SqlCommand("SELECT [IdEmpleados], Contraseña FROM Empleados WHERE [IdEmpleados] = @vUser AND Contraseña = @vPassword", conection);
            comando.Parameters.AddWithValue("@vUser", txt_user.Text);
            comando.Parameters.AddWithValue("@vPassword", txt_pass.Text);
           

            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                conection.Close();


                if (chb_admin.Checked) //valida si admin está checked
                {
                    PrincipalAdministrador pantalla = new PrincipalAdministrador();
                    pantalla.Show();
                    this.Hide();
                }
                else//si es cajero abre principal cajero
                {
                    PrincipalCajero pantalla = new PrincipalCajero();
                    pantalla.Show();
                    this.Hide();
                }

                
            }
            conection.Close();
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
            var frmRegistroEmpleado = new RegistroEmpleado();

            //frmRegistroEmpleado.Show();//Ventana NO Modal
            frmRegistroEmpleado.ShowDialog(); //Ventana Modal

        }

    }
}
