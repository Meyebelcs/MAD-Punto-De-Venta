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
    public partial class RegistroProducto : Form
    {
        public RegistroProducto()
        {
            InitializeComponent();
        }

        private void btn_cancelar_RE_Click(object sender, EventArgs e)
        {
            GestionProductos pantalla = new GestionProductos();
            pantalla.Show();
            this.Hide();
        }
    }
}
