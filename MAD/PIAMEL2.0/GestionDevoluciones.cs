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

namespace MAD._0
{
    public partial class GestionDevoluciones : Form
    {
        public GestionDevoluciones()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PA.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PA.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_regresar_GP_Click(object sender, EventArgs e)
        {
            PrincipalAdministrador pantalla = new PrincipalAdministrador();
            pantalla.Show();
            this.Hide();

        }

        private void btn_crearNota_Click(object sender, EventArgs e)
        {
            //valido que los campos no estén vacios

            int i = 0;
            //VALIDO QUE EL DEPARTAMENTO PERMITA HACER DEVOLUCIONES CON EL BIT
            if (i==0)//si el departamento permite la devolucion se hace la devolucion
            {
                MessageBox.Show("Este producto ha sido devuelto", "Devolución", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("El departamento no permite la devolución de este producto", "Devolución denegada", MessageBoxButtons.OK);
            }

           
        }

        private void btn_AgregarP_Click(object sender, EventArgs e)
        {
            //captura el producto seleccionado
            //muestra los datos del producto en los text box
            //genera id temporal para nota de credito
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //valida q el txt no esté vacio
            //busca el producto en la bd
            //muestra los datos en el grid

        }

        private void GestionDevoluciones_Load(object sender, EventArgs e)
        {
            var enlace = new EnlaceDB();
            var nombre = new DataTable();
            Login IdUser = new Login();

            nombre = enlace.get_DatosEmpleado('S', IdUser.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            lbl_nombrec_PA.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() + " " + nombre.Rows[0][3].ToString();
        }
    }
}
