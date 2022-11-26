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
    public partial class Caja_Alta : Form
    {
        public Caja_Alta()
        {
            InitializeComponent();
        }

        private void btn_Guardar_GC_Click(object sender, EventArgs e)
        {
            //GUARDA INFO DE CAJA

            MessageBox.Show("Esta caja ha sido guardada", "Guardar", MessageBoxButtons.OK);

            GestionCajas pantalla = new GestionCajas();
            pantalla.Show();
            this.Hide();
        }

        private void btn_regresar_GC_Click(object sender, EventArgs e)
        {
            GestionCajas pantalla = new GestionCajas();
            pantalla.Show();
            this.Hide();

        }
    }
}
