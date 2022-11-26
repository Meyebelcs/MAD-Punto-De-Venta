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
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
        }

        private void btn_cancelar_P_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pagar_P_Click(object sender, EventArgs e)
        {
            var resp = new DialogResult();

            resp = MessageBox.Show("¿Seguro que quiere realizar esta compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                MessageBox.Show("Pago realizado con éxito", "Compra exitosa", MessageBoxButtons.OK);
                this.Close();

                //se hace la impresion del pdf 

                MessageBox.Show("Se guardó un PDF del recibo", "Impresión", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            var obj = new EnlaceDB(); //creo objeto enlaceDB
            var tabla = new DataTable();//creo tabla 
            tabla = obj.ConsultaTabla("spOpcion_Pago", "*");//manda llamar el SP
            dgv_Lista_P.DataSource = tabla; //Asigna la info a la tabla


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tiempo_PC.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha_PC.Text = DateTime.Now.ToLongDateString();
        }
    }
}
