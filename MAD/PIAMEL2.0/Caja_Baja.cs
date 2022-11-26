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

namespace PIAMEL2._0
{
    public partial class Caja_Baja : Form
    {
        public Caja_Baja()
        {
            InitializeComponent();
        }

        private void btn_regresar_GC_Click(object sender, EventArgs e)
        {
            GestionCajas pantalla = new GestionCajas();
            pantalla.Show();
            this.Hide();
        }

        private void btn_Eliminar_GC_Click(object sender, EventArgs e)
        {
            //ELIMINA INFO DE CAJA

            MessageBox.Show("Esta caja ha sido eliminada exitosamente", "Eliminacion", MessageBoxButtons.OK);

            GestionCajas pantalla = new GestionCajas();
            pantalla.Show();
            this.Hide();
        }
    }
}
