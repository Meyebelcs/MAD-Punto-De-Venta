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
    public partial class Modificar_Caja : Form
    {
        public Modificar_Caja()
        {
            InitializeComponent();
        }

        private void btn_regresar_GC_Click(object sender, EventArgs e)
        {
            GestionCajas pantalla = new GestionCajas();
            pantalla.Show();
            this.Hide();
        }

        private void btn_Guardar_GC_Click(object sender, EventArgs e)
        {
            //MODIFICA INFO DE CAJA

            MessageBox.Show("Esta caja ha sido modificada exitosamente", "Guardar", MessageBoxButtons.OK);

            GestionCajas pantalla = new GestionCajas();
            pantalla.Show();
            this.Hide();
        }
    }
}
