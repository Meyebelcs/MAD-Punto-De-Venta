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

        private void Modificar_Caja_Load(object sender, EventArgs e)
        {
            //llenar combobox con los cajeros disponibles

            var obj2 = new EnlaceDB();
            var cajas = new DataTable();
            cajas = obj2.ConsultaTabla("spCaja", "*");
            cb_numcaja.DataSource = cajas;

            cb_numcaja.DisplayMember = "Num Caja";
            cb_numcaja.ValueMember = "IdCaja";
            cb_numcaja.SelectedIndex = -1;

        }

        private void cb_numcaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            //busca la caja seleccionada
        }
    }
}
