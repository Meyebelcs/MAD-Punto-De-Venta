using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MAD._0
{
    public class EnlaceDB
    {
        static private string _aux { set; get; } //SOLO ES UNA CADENA
        static private SqlConnection _conexion; //PARA LA CONEXION
        static private SqlDataAdapter _adaptador = new SqlDataAdapter(); //ES UN ADAPTADOR
        static private SqlCommand _comandosql = new SqlCommand(); //PARA EL PROCEDURE
        static private DataTable _tabla = new DataTable(); //PARA LAS TABLAS 
        static private DataSet _DS = new DataSet(); //PARA MODIFICAR

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        private static void conectar()
        {
            //string cnn = ConfigurationManager.AppSettings["desarrollo1"];
            string cnn = ConfigurationManager.ConnectionStrings["Grupo01"].ToString();
            _conexion = new SqlConnection(cnn);
            _conexion.Open();
        }
        private static void desconectar()
        {
            _conexion.Close();
        }

        public bool Autentificar(string opc, int IdRol, string contra)
        {
            var msg = "";
            bool isValid = false;
            try
            {
                conectar();
                string qry = "SP_ValidaUser";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro3 = _comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 20);
                parametro3.Value = contra;
                var parametro2 = _comandosql.Parameters.Add("@IdRol", SqlDbType.Int, 4);
                parametro2.Value = IdRol;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in _tabla.Rows)
                    {
                        if (fila["IdEmpleado"].ToString() == IdRol.ToString())
                        {
                            isValid = true;
                        }
                    }
                }

            }
            catch (SqlException e)
            {
                isValid = false;

                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return isValid;
        }

        public DataTable ConsultaTabla(string SP, string accion)
        {
            var msg = "";
            DataTable tabla = new DataTable(); //creo una tabla, un objeto
            try
            {
                conectar();
                //string qry = SP;
                _comandosql = new SqlCommand(SP, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = accion; //letra para el stored procedure

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla); //llena la tabla con fill

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        //EMPLEADOS
        public bool validarRol(int IdRol)
        {
            var msg = "";
            bool isValid = false;
            try
            {
                conectar();
                string qry = "spEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = 'V';
                var parametro2 = _comandosql.Parameters.Add("@IdEmpleados", SqlDbType.Int, 20);
                parametro2.Value = IdRol;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in _tabla.Rows)
                    {
                        if (fila["IdEmpleado"].ToString() == IdRol.ToString())
                        {
                            isValid = true;
                        }
                    }
                }

            }
            catch (SqlException e)
            {
                isValid = false;

                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return isValid;
        }
        public DataTable get_DatosEmpleado(char op, int noEmpleado)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdEmpleados", SqlDbType.Int, 20);
                parametro2.Value = noEmpleado;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_Empleados(string opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public bool add_Empleados(string opc, int noEmpleado, string nombre, string apPaterno, string apMaterno, int telefono, string contraseña, DateTime fechaNacimiento, string curp, string email, DateTime fechaIngreso, int numNomina)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdEmpleados", SqlDbType.Int, 20);
                parametro2.Value = noEmpleado;
                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametro3.Value = nombre;
                var parametro4 = _comandosql.Parameters.Add("@APpellidoP", SqlDbType.VarChar, 50);
                parametro4.Value = apPaterno;
                var parametro5 = _comandosql.Parameters.Add("@APpellidoM", SqlDbType.VarChar, 50);
                parametro5.Value = apMaterno;
                var parametro6 = _comandosql.Parameters.Add("@Telefono", SqlDbType.Int, 11);
                parametro6.Value = telefono;
                var parametro7 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 50);
                parametro7.Value = email;
                var parametro8 = _comandosql.Parameters.Add("@FechaIngreso", SqlDbType.DateTime);
                parametro8.Value = fechaIngreso;
                var parametro9 = _comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 20);
                parametro9.Value = curp;
                var parametro10 = _comandosql.Parameters.Add("@FechaNac", SqlDbType.DateTime);
                parametro10.Value = fechaNacimiento;
                var parametro11 = _comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 10);
                parametro11.Value = contraseña;
                var parametro12 = _comandosql.Parameters.Add("@NumNomina", SqlDbType.Int, 20);
                parametro12.Value = numNomina;

                var parametro13 = _comandosql.Parameters.Add("@Eliminacion", SqlDbType.Int, 1);
                parametro13.Value = 0;
                var parametro14 = _comandosql.Parameters.Add("@CodigoAcceso", SqlDbType.Int, 1);
                parametro14.Value = 0;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        //ADMINISTRADOR
        public bool add_Administrador(string opc, int noEmpleado, int IdAdmin, int codigoAcceso)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spAdministrador";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdAdministrador", SqlDbType.Int, 20);
                parametro2.Value = IdAdmin;
                var parametro3 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int, 20);
                parametro3.Value = noEmpleado;
                var parametro4 = _comandosql.Parameters.Add("@CodigoAcceso", SqlDbType.Int, 20);
                parametro4.Value = codigoAcceso;
                var parametro5 = _comandosql.Parameters.Add("@Eliminacion", SqlDbType.Int, 1);
                parametro5.Value = 0;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public DataTable get_DatosAdmin(char op, int noEmpleado)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spAdministrador";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int, 20);
                parametro2.Value = noEmpleado;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        //CAJERO
        public bool add_Cajero(string opc, int IdCajero, int IdEmpleado, int IdAdmin)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spCajero";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdCajero", SqlDbType.Int, 20);
                parametro2.Value = IdCajero;
                var parametro3 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int, 20);
                parametro3.Value = IdEmpleado;
                var parametro4 = _comandosql.Parameters.Add("@IdAdmin", SqlDbType.Int, 20);
                parametro4.Value = IdAdmin;
                var parametro5 = _comandosql.Parameters.Add("@Eliminacion", SqlDbType.Int, 1);
                parametro5.Value = 0;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public DataTable get_DatosCajero(char op, int IdEmpleado)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spCajero";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int, 20);
                parametro2.Value = IdEmpleado;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        //DEPARTAMENTOS
        public DataTable get_DatosDepartamento(char op, int noEmpleado)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spDepartamento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdDepartamento", SqlDbType.Int, 20);
                parametro2.Value = noEmpleado;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public bool add_Departamento(string opc, int IdDepartamento, string Nombre, string Descripcion, int IdAdministrador, int Devolucion, DateTime FechaIngreso)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spDepartamento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdDepartamento", SqlDbType.Int, 20);
                parametro2.Value = IdDepartamento;
                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametro3.Value = Nombre;
                var parametro4 = _comandosql.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
                parametro4.Value = Descripcion;
                var parametro5 = _comandosql.Parameters.Add("@IdAdminstrador", SqlDbType.Int, 20);
                parametro5.Value = IdAdministrador;
                var parametro6 = _comandosql.Parameters.Add("@PermiteDevolucion", SqlDbType.Int, 1);
                parametro6.Value = Devolucion;
                var parametro7 = _comandosql.Parameters.Add("@Eliminacion", SqlDbType.Int, 1);
                parametro7.Value = 0;
                var parametro8 = _comandosql.Parameters.Add("@FechaIngreso", SqlDbType.DateTime);
                parametro8.Value = FechaIngreso;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        //PRODUCTOS
        public DataTable get_DatosProductos(char op, int noProduct)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spProductos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro2.Value = noProduct;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable get_Datos_InfoProductos(char op, int noProduct)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spInfo_Productos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro2.Value = noProduct;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

    }
}
