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
            if (txt_numcaja.TextLength < 1)
            {
                MessageBox.Show("Num Caja no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //VALIDACIONES DE DATOS Q NO DEBEN REPETIRSE
            var enlace = new EnlaceDB();
            var tablita = new DataTable();
            tablita = enlace.ConsultaTabla("spCaja", "*");

            //Que el CURP no se repita

            if (tablita.Rows.Count >= 0)
            {
                foreach (DataRow fila in tablita.Rows)
                {
                    if (fila["Num Caja"].ToString() == txt_numcaja.Text)
                    {
                        MessageBox.Show("El Numero de caja que ingresó ya se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }


            //GUARDA INFO DE CAJA
            //Si cumple toda las validaciones continua y guarda la info en la base de datos
            var caja = new EnlaceDB();
            bool control;
            //alta de caja
            control = caja.add_Caja("I", Convert.ToInt32(LBL_ID.Text), Convert.ToInt32(txt_numcaja.Text));

            if (!control)
            {
                MessageBox.Show("No se pudo agregar correctamente la caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            MessageBox.Show("Esta caja ha sido guardada", "Guardar", MessageBoxButtons.OK);


            //si selecciona un cajero se va a actualizar sino no
            if (cbcajero.SelectedIndex != -1)
            {
                //SE ACTUALIZA LA TABLA DE CAJEROS QUE FUE ASIGNADA UNA CAJA
                //TRAIGO EL ID DE LA CAJA Q SE CREÓ
                var IdCaja = new DataTable();
                IdCaja = enlace.get_DatosCaja('M', 0); //traigo de la base los datos ID  de la caja
                string sidcaja = IdCaja.Rows[0][0].ToString();

                bool cajeroval;

                cajeroval = enlace.actualiza_Caja(Convert.ToInt32(sidcaja), Convert.ToInt32(cbcajero.Text));
                if (!cajeroval)
                {
                    MessageBox.Show("No se pudo modificar correctamente el cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Se modificó correctamente el  cajero", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

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

        private void Caja_Alta_Load(object sender, EventArgs e)
        {
            //llenar combobox con los cajeros disponibles
          
            var obj2 = new EnlaceDB();
            var cajeros = new DataTable();

            cajeros = obj2.ConsultaTabla("spCajero", "T");
            cbcajero.DataSource = cajeros;

            cbcajero.DisplayMember = "IdEmpleado";
             cbcajero.ValueMember = "IdCajero";
            cbcajero.SelectedIndex = -1;

            Login gestor = new Login();
            LBL_ID.Text = gestor.getCurrentIdUser().ToString();

            //busco el admin y lo imprimo
            var enlace = new EnlaceDB();
            var nombreAdmin = new DataTable();
            nombreAdmin = enlace.get_DatosEmpleado('S', Convert.ToInt32(gestor.getCurrentIdUser())); //traigo de la base los datos del user q inició sesion

            txt_admin.Text = nombreAdmin.Rows[0][1].ToString() + " " + nombreAdmin.Rows[0][2].ToString() + " " + nombreAdmin.Rows[0][3].ToString();


        }
    }
}
