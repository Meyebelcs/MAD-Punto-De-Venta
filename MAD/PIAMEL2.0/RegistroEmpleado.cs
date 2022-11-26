using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MAD._0
{
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private void btn_cancelar_RE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Telefono_RE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

        private void chb_admin_RE_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_admin_RE.Checked) //valida si admin está checked
            {
                chb_cajero_RE.Checked = false;
                txt_codigoAcceso_RE.Enabled = true;
            }
        }

        private void chb_cajero_RE_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_cajero_RE.Checked)//valida si cajero está checked
            {
                chb_admin_RE.Checked = false;
                txt_codigoAcceso_RE.Enabled = false;
                txt_codigoAcceso_RE.Text = " ";
            }
        }

        private void txt_codigoAcceso_RE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

        private void btn_registrar_RE_Click(object sender, EventArgs e)
        {
            //validacion de fecha
            ValidarFecha();
        }

        void ValidarFecha()
        {
            DateTime hoy = DateTime.Today;
            if (tp_FechaIngreso_RE.Value.Date >= hoy) //valida que sea menor a hoy
            {
                MessageBox.Show("Fecha inválida, no puedes seleccionar una fecha futura o presente", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tp_FechaIngreso_RE.Value.Date.AddYears(18) > hoy) //valida que sea mayor de edad
            {
                MessageBox.Show("Eres menor de edad", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txt_nomina_RE_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //Solo numeros en el txt
        }

       
    }
}

