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
    public partial class Caja_Seleccion : Form
    {
       
        public Caja_Seleccion()
        {
            InitializeComponent();
        }

        private void btn_aceptar_SC_Click(object sender, EventArgs e)
        {
           

            if (cb_Num_SC.SelectedIndex != -1)
            {
                Login gestor = new Login();
                gestor.setNumCaja(cb_Num_SC.Text);

              
                //busco el id de esa caja
                var enlace = new EnlaceDB();
                var Numerocaja = new DataTable();
                Numerocaja = enlace.get_idcaja('B', Convert.ToInt32(cb_Num_SC.Text)); //traigo de la base los datos del user q inició sesion
                string sidcaja= Numerocaja.Rows[0][0].ToString();

                //significa que le acaba de asignar un cajero a la caja
                enlace.actualiza_Caja(Convert.ToInt32(sidcaja), gestor.getCurrentIdUser());

                gestor.setidcaja(Convert.ToInt32(sidcaja));

                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona una caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void Caja_Seleccion_Load(object sender, EventArgs e)
        {
            //LLENAR LOS COMBOBOX
            var obj2 = new EnlaceDB();
            var CAJAS = new DataTable();
            CAJAS = obj2.ConsultaTabla("spCaja", "*");
           // cb_Num_SC.DataSource = CAJAS;

            if (CAJAS.Rows.Count >= 0)
            {
                foreach (DataRow fila in CAJAS.Rows)
                {
                    string idcaja = fila["IdCaja"].ToString();
                    string numerocaja = fila["Num Caja"].ToString();

                    //busco si existe un cajero con esta caja asignada
                    var busquedadcajero = new DataTable();
                    busquedadcajero = obj2.get_DatosCajaAsignada('B', Convert.ToInt32(idcaja)); //traigo de la base los datos del depa

                    string asignado = busquedadcajero.Rows[0][0].ToString();

                    if (asignado == "0")
                    {

                        cb_Num_SC.Items.Add(numerocaja);
                    }

                }
            }

            cb_Num_SC.SelectedIndex = -1;
        }
    }
}
