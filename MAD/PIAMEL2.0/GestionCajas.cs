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

        private int cajaSelected;
        public GestionCajas()
        {
            InitializeComponent();
        }

        private void GestionCajas_Load(object sender, EventArgs e)
        {
            var enlace = new EnlaceDB();
            var nombre = new DataTable();
            Login IdUser = new Login();

            nombre = enlace.get_DatosEmpleado('S', IdUser.getCurrentIdUser()); //traigo de la base los datos del user q inició sesion
            lbl_nombrec_PA.Text = nombre.Rows[0][1].ToString() + " " + nombre.Rows[0][2].ToString() + " " + nombre.Rows[0][3].ToString();


            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.ConsultaTabla("spCaja", "*");//manda llamar el SP
            dgv_cajasinfo.DataSource = tabla; //Asigna la info a la tabla

            //llenar combobox con los cajeros disponibles
            var obj2 = new EnlaceDB();
            var cajeros = new DataTable();

            cajeros = obj2.ConsultaTabla("spCajero", "T");
            cbcajero.DataSource = cajeros;

            cbcajero.DisplayMember = "IdEmpleado";
            cbcajero.ValueMember = "IdCajero";
            cbcajero.SelectedIndex = -1;


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
            if (cajaSelected != 0)
            {

                #region Validaciones

                var enlace = new EnlaceDB();
                DialogResult result = MessageBox.Show("¿Está seguro que desea modificar este elemento?", "Modificar", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se modificó el departamento", "Cancelado", MessageBoxButtons.OK);
                    return;
                }

                if (txt_num.TextLength < 1)
                {
                    MessageBox.Show("Numero de caja no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //VALIDACIONES DE DATOS Q NO DEBEN REPETIRSE
                var tablita = new DataTable();
                tablita = enlace.ConsultaTabla("spCaja", "*");


                //Que el nombre no se repita

                if (tablita.Rows.Count >= 0)
                {
                    foreach (DataRow fila in tablita.Rows)
                    {
                        if (fila["Num Caja"].ToString() == txt_num.Text && fila["IdCaja"].ToString() != LBL_IDCAJA.Text)
                        {
                            MessageBox.Show("Ya existe una caja con ese numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
                #endregion


                if (chb_sincajero.Checked==true && lblb_idempleado.Text != "NoTieneCajero") //si quitó el cajero q estaba asignado
                {
                    //actualizar la el idcaja en cajero con 0

                    //SE ACTUALIZA LA TABLA DE CAJEROS 
                    bool cajeroval;
                    cajeroval = enlace.actualiza_Caja(0, Convert.ToInt32(lblb_idempleado.Text));

                }
                else
                {
                    if (chb_sincajero.Checked == true && lblb_idempleado.Text == "NoTieneCajero")//si 
                    {
                        //no pasará nada
                    }
                    else
                    {
                        if (chb_sincajero.Checked == false && lblb_idempleado.Text == "NoTieneCajero")
                        {
                            if (cbcajero.Text == " ")
                            {
                                MessageBox.Show("Seleccione un cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            //significa que le acaba de asignar un cajero a la caja
                           
                            enlace.actualiza_Caja(Convert.ToInt32(LBL_IDCAJA.Text), Convert.ToInt32(cbcajero.Text));

                        }
                        else
                        {
                            if (chb_sincajero.Checked == false && lblb_idempleado.Text != "NoTieneCajero")
                            {
                                //significa que si tenia un cajero asignado asiq probablemente cambió el cajero q estaba asignado
                                //pregunta si el empleado es el mismo que ya estaba
                                if (cbcajero.Text == " ")
                                {
                                    MessageBox.Show("Seleccione un cajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }

                                if (cbcajero.Text!= lblb_idempleado.Text)
                                { 
                                    //va a actualizar en 0 el que estaba asignado 
                                   
                                   enlace.actualiza_Caja(0, Convert.ToInt32(lblb_idempleado.Text));

                                    //y actualiza el nuevo encargado de la caja
                                   enlace.actualiza_Caja(Convert.ToInt32(LBL_IDCAJA.Text), Convert.ToInt32(cbcajero.Text));
                                }
                               
                            }
                        }
                    }
                }

                //Si cumple toda las validaciones continua y guarda la info en la base de datos de la caja
                var cajas = new EnlaceDB();
                bool control;
                //modifica la caja
                control = cajas.add_Caja("U", Convert.ToInt32(LBL_ID.Text), Convert.ToInt32(txt_num.Text));

                if (!control)
                {
                    MessageBox.Show("No se pudo modificar correctamente la caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                MessageBox.Show("Esta caja ha sido modificada", "Guardar", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Selecciona una caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_ECaja_Click(object sender, EventArgs e)
        {
            if (cajaSelected != 0)
            {
                var enlace = new EnlaceDB();
                DialogResult result = MessageBox.Show("Esta acción es irreversible\n\n ¿Está seguro que desea continuar?", "Eliminar", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se eliminó la caja", "Cancelado", MessageBoxButtons.OK);
                    return;
                }

                //validar si existen cajero asignado a esta caja

                if (lblb_idempleado.Text == "NoTieneCajero")
                {
                    enlace.get_DatosCaja('E', Convert.ToInt32(LBL_IDCAJA.Text));

                    MessageBox.Show("se eliminó correctamente la caja", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("No se puede eliminar esta caja porque hay un cajero asignado a esta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //recargar pantalla
                this.Close();
                GestionCajas pantalla = new GestionCajas();
                pantalla.Show();

            }
            else
            {
                MessageBox.Show("Selecciona una caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgv_cajasinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login gestor = new Login();

            var row = (sender as DataGridView).CurrentRow;
            cajaSelected = Convert.ToInt32(row.Cells[0].Value.ToString()); //ID DE la caja SELECCIONADa

            //MUESTRA LA INFO DE LA CAJA
            var obj = new EnlaceDB();
            var INFO = new DataTable();
            INFO = obj.get_DatosCaja('S', cajaSelected); //traigo de la base los datos de la caja

            if (INFO.Rows.Count >= 1)
            {
                LBL_IDCAJA.Text = INFO.Rows[0][0].ToString();
                LBL_ID.Text = INFO.Rows[0][1].ToString();
                txt_num.Text = INFO.Rows[0][2].ToString();

                string IdAdminstrador = INFO.Rows[0][1].ToString();
                //busco el admin y lo imprimo
                var enlace = new EnlaceDB();
                var nombreAdmin = new DataTable();
                nombreAdmin = enlace.get_DatosEmpleado('S', Convert.ToInt32(IdAdminstrador)); //traigo de la base los datos del user q inició sesion
                txt_admin.Text = nombreAdmin.Rows[0][1].ToString() + " " + nombreAdmin.Rows[0][2].ToString() + " " + nombreAdmin.Rows[0][3].ToString();

            }

            //MUESTRA LA INFO DE SI ESTÁ ASIGNADA ESA CAJA A ALGUN CAJERO



            //validar si existen productos con este departamento
            string idcaja = INFO.Rows[0][0].ToString();

            var busquedadcajero = new DataTable();
            busquedadcajero = obj.get_DatosCajaAsignada('B', Convert.ToInt32(idcaja)); //traigo de la base los datos del depa

            string asignado = busquedadcajero.Rows[0][0].ToString();

            if (asignado == "0")
            {
                chb_sincajero.Checked = true;
                cbcajero.Text = " ";
                cbcajero.Enabled = false;
                lblb_idempleado.Text = "NoTieneCajero";
            }
            else
            {
                lblb_idempleado.Text = asignado;
                chb_sincajero.Checked = false;
                cbcajero.Text = asignado;
                cbcajero.Enabled = true;
            }
        }

        private void chb_sincajero_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_sincajero.Checked == true)
            {
                cbcajero.Enabled = false;
            }
            else
            {
                cbcajero.Enabled = true;
            }
        }
    }
}
