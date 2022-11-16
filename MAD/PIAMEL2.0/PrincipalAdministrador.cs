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
    public partial class PrincipalAdministrador : Form
    {
        public PrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PA.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PA.Text = DateTime.Now.ToLongDateString();
        }


        private void PrincipalAdministrador_Load(object sender, EventArgs e)
        {
            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.ConsultaTabla("spProductos", "J");//manda llamar el SP
            dgv_Lista_PA.DataSource = tabla; //Asigna la info a la tabla

        }

        //--------------------------MENÚ------------------------------
        private void btn_cajeros_PA_Click(object sender, EventArgs e)
        {
            GestionCajas pantalla = new GestionCajas();
            pantalla.Show();
            this.Hide();
        }
        private void btn_cerrarS_PA_Click(object sender, EventArgs e)
        {
            var resp = new DialogResult();

            resp = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Login pantalla = new Login();

                pantalla.Show();
                this.Hide();
            }
        }

        private void btn_ventas_PA_Click(object sender, EventArgs e)
        {
            GestionVentas pantalla = new GestionVentas();
            pantalla.Show();
            this.Hide();
        }

        private void btn_reportes_PA_Click(object sender, EventArgs e)
        {
            GestionReportes pantalla = new GestionReportes();
            pantalla.Show();
            this.Hide();
        }

        private void btn_inventario_PA_Click(object sender, EventArgs e)
        {
            GestionInventario pantalla = new GestionInventario();
            pantalla.Show();
            this.Hide();
        }

        private void btn_productos_PA_Click(object sender, EventArgs e)
        {
            GestionProductos pantalla = new GestionProductos();
            pantalla.Show();
            this.Hide();
        }

        private void btn_devoluciones_PA_Click(object sender, EventArgs e)
        {
            GestionDevoluciones pantalla = new GestionDevoluciones();
            pantalla.Show();
            this.Hide();
        }
    }
}
