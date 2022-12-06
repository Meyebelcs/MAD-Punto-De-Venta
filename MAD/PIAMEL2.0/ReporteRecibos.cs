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
    public partial class ReporteRecibos : Form
    {
        public ReporteRecibos()
        {
            InitializeComponent();
        }

        private void btn_regresar_GP_Click(object sender, EventArgs e)
        {
            PrincipalAdministrador pantalla = new PrincipalAdministrador();
            pantalla.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PA.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PA.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_imprimirPDF_Click(object sender, EventArgs e)
        {
            //VALIDA QUE HAYA INFORMACION EN LA TABLA

            MessageBox.Show("Se imprimió correctamente el PDF", "Impresión", MessageBoxButtons.OK);
        }

        private void btn_buscarIdTicket_Click(object sender, EventArgs e)
        {
            //valida que haya info en el txt

            //busca en la bd ese ticket e imprime su info en el dgv
        }

        private void btn_IdNota_Click(object sender, EventArgs e)
        {
            //valida que haya info en el txt

            //busca en la bd ese ticket e imprime su info en el dgv
        }

        private void btn_buscarFechaCaja_Click(object sender, EventArgs e)
        {
            //valida que haya info en el timer y cb de caja

            //busca en la bd ese ticket e imprime su info en el dgv
        }

        private void ReporteRecibos_Load(object sender, EventArgs e)
        {
            var enlace = new EnlaceDB();
            var nombre = new DataTable();
            Login IdUser = new Login();

            nombre = enlace.get_DatosEmpleado('S', IdUser.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            lbl_nombrec_PA.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() + " " + nombre.Rows[0][3].ToString();
        }
    }
}
