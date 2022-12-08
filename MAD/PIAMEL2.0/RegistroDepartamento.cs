using MAD._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIAMEL2._0
{
    public partial class RegistroDepartamento : Form
    {
        public RegistroDepartamento()
        {
            InitializeComponent();
        }

        private void RegistroDepartamento_Load(object sender, EventArgs e)
        {
            var obj = new EnlaceDB();
            var IdProvisional = new DataTable();
            IdProvisional = obj.ConsultaTabla("spDepartamento", "P"); //traigo de la base los datos del depa

            txt_id.Text = IdProvisional.Rows[0][0].ToString();

            Login gestor = new Login();
            string IdAdminstrador = gestor.getCurrentIdUser().ToString();
            lbl_idadmin.Text= IdAdminstrador;
            //busco el admin y lo imprimo
            var enlace = new EnlaceDB();
            var nombreAdmin = new DataTable();
            nombreAdmin = enlace.get_DatosEmpleado('S', Convert.ToInt32(IdAdminstrador)); //traigo de la base los datos del user q inició sesion
            txt_nameadmin.Text = nombreAdmin.Rows[0][1].ToString() + " " + nombreAdmin.Rows[0][2].ToString() + " " + nombreAdmin.Rows[0][3].ToString();
        }

        private void btn_cancelar_RE_Click(object sender, EventArgs e)
        {
            GestionDepartamentos pantalla = new GestionDepartamentos();
            pantalla.Show();
            this.Hide();
        }

        private void btn_registrar_RE_Click(object sender, EventArgs e)
        {
            #region Validaciones

            if (txt_nombre_RE.TextLength < 1)
            {
                MessageBox.Show("Nombre no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_descripction.TextLength < 1)
            {
                MessageBox.Show("Descripción no contiene información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //VALIDACIONES DE DATOS Q NO DEBEN REPETIRSE
            var enlace = new EnlaceDB();
            var tablita = new DataTable();
            tablita = enlace.ConsultaTabla("spDepartamento", "T");

            //Que el CURP no se repita

            if (tablita.Rows.Count >= 0)
            {
                foreach (DataRow fila in tablita.Rows)
                {
                    if (fila["Nombre"].ToString() == txt_nombre_RE.Text)
                    {
                        MessageBox.Show("Ya existe un departamento con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            #endregion

            //Si cumple toda las validaciones continua y guarda la info en la base de datos
            var empleado = new EnlaceDB();
            bool control;

            int devolucion = 0;
            if (chb_devolucion.Checked == true)
            {
                devolucion = 1;
            }

            //alta de empleado
           control = empleado.add_Departamento("I", Convert.ToInt32(txt_id.Text), txt_nombre_RE.Text, txt_descripction.Text, Convert.ToInt32( lbl_idadmin.Text), devolucion, tp_fechaIngreso.Value);

            if (!control)
            {
                MessageBox.Show("No se pudo agregar correctamente el departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            MessageBox.Show("Se agregó correctamente el nuevo departamento", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            GestionDepartamentos pantalla = new GestionDepartamentos();
            pantalla.Show();
            this.Hide();
        }
    }
}
