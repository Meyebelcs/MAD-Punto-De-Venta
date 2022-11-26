using PIAMEL2._0;
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
    public partial class GestionCajas : Form
    {
        public GestionCajas()
        {
            InitializeComponent();
        }

        private void GestionCajas_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PA.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PA.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_regresar_GC_Click(object sender, EventArgs e)
        {
            PrincipalAdministrador pantalla = new PrincipalAdministrador();
            pantalla.Show();
            this.Hide();
        }

        private void btn_NCaja_Click(object sender, EventArgs e)
        {
            Caja_Alta pantalla = new Caja_Alta();
            pantalla.Show();
            this.Hide();
        }

        private void btn_MCaja_Click(object sender, EventArgs e)
        {
            Modificar_Caja pantalla = new Modificar_Caja();
            pantalla.Show();
            this.Hide();
        }

        private void btn_ECaja_Click(object sender, EventArgs e)
        {
            Caja_Baja pantalla = new Caja_Baja();
            pantalla.Show();
            this.Hide();
        }
    }
}
