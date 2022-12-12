﻿using System;
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
        public DataTable LOGIN(char op, string contraseña, int rol)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "SP_ValidaUser";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Op", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 20);
                parametro2.Value = contraseña;
                var parametro3 = _comandosql.Parameters.Add("@IdRol", SqlDbType.Int, 30);
                parametro3.Value = rol;

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

        public bool actualiza_Caja(int IdCaja, int IdEmpleado)
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
                parametro1.Value = "M";
                var parametro2 = _comandosql.Parameters.Add("@IdCaja", SqlDbType.Int, 20);
                parametro2.Value = IdCaja;
                var parametro3 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int, 20);
                parametro3.Value = IdEmpleado;

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
        public DataTable get_DatosCajaAsignada(char op, int IdCaja)
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
                var parametro2 = _comandosql.Parameters.Add("@IdCaja", SqlDbType.Int, 20);
                parametro2.Value = IdCaja;

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
        public DataTable get_DatosDepartamento(char op, int IdDepartamento)
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
                parametro2.Value = IdDepartamento;

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
        public DataTable get_IdDepartamento(char op, string Nombre)
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
                var parametro2 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametro2.Value = Nombre;

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
        public DataTable get_DatosInfoProducto(char op, int noProduct)
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
        public DataTable get_DatosHistorialProducto(char op, int noProduct)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spHistorial_Productos";
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
        public bool add_Productos(string opc, int IdProducto, string Nombre, int IdDepartamento, string Descripcion, string UnidaddeMedida, Decimal Costo, Decimal CantidadDeInventario)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spProductos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro2.Value = IdProducto;
                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametro3.Value = Nombre;
                var parametro4 = _comandosql.Parameters.Add("@IdDepartamento", SqlDbType.Int, 20);
                parametro4.Value = IdDepartamento;
                var parametro5 = _comandosql.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
                parametro5.Value = Descripcion;
                var parametro6 = _comandosql.Parameters.Add("@Descuento", SqlDbType.Int, 1);
                parametro6.Value = 0;
                var parametro7 = _comandosql.Parameters.Add("@UnidaddeMedida", SqlDbType.VarChar, 20);
                parametro7.Value = UnidaddeMedida;
                var parametro8 = _comandosql.Parameters.Add("@Costo", SqlDbType.Decimal,10);
                _comandosql.Parameters["@Costo"].Precision = 10;
                _comandosql.Parameters["@Costo"].Scale = 2;
                parametro8.Value = Costo;
                var parametro9 = _comandosql.Parameters.Add("@Eliminacion", SqlDbType.Int, 1);
                parametro9.Value = 0;
                var parametro10 = _comandosql.Parameters.Add("@CantidadDeInventario", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@CantidadDeInventario"].Precision = 10;
                _comandosql.Parameters["@CantidadDeInventario"].Scale = 2;
                parametro10.Value = CantidadDeInventario;

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
        public bool add_InfoProductos(string opc, int IdInfoProductos, int IdAdministrador, int IdProducto, DateTime FechaDeAlta, int PuntoReorden, Decimal PrecioUnitario)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spInfo_Productos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdInfoProductos", SqlDbType.Int, 20);
                parametro2.Value = IdInfoProductos;
                var parametro3 = _comandosql.Parameters.Add("@IdAdministrador", SqlDbType.Int, 20);
                parametro3.Value = IdAdministrador;
                var parametro4 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro4.Value = IdProducto;
                var parametro5 = _comandosql.Parameters.Add("@FechaDeAlta", SqlDbType.DateTime);
                parametro5.Value = FechaDeAlta;
                var parametro6 = _comandosql.Parameters.Add("@PuntoReorden", SqlDbType.Int, 30);
                parametro6.Value = PuntoReorden;
                var parametro7 = _comandosql.Parameters.Add("@PrecioUnitario", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@PrecioUnitario"].Precision = 10;
                _comandosql.Parameters["@PrecioUnitario"].Scale = 2;
                parametro7.Value = PrecioUnitario;
                var parametro9 = _comandosql.Parameters.Add("@Eliminacion", SqlDbType.Int, 1);
                parametro9.Value = 0;

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
        public bool add_HistorialProductos(string opc, int IdHistorialIp, int IdUsuarioModificacion, int IdInfoProducto, DateTime FechaDeCambios, int IdProducto)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spHistorial_Productos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdHistorialIp", SqlDbType.Int, 20);
                parametro2.Value = IdHistorialIp;
                var parametro3 = _comandosql.Parameters.Add("@IdUsuarioModificacion", SqlDbType.Int, 20);
                parametro3.Value = IdUsuarioModificacion;
                var parametro4 = _comandosql.Parameters.Add("@IdInfoProducto", SqlDbType.Int, 20);
                parametro4.Value = IdInfoProducto;
                var parametro5 = _comandosql.Parameters.Add("@FechaDeCambios", SqlDbType.DateTime);
                parametro5.Value = FechaDeCambios;
                var parametro6 = _comandosql.Parameters.Add("@Eliminacion", SqlDbType.Int, 1);
                parametro6.Value = 0;
                var parametro7 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro7.Value = IdProducto;

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


        //CAJAS
        public bool add_Caja(string opc, int IdAdministrador, int Numero)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spCaja";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdAdministrador", SqlDbType.Int, 20);
                parametro2.Value = IdAdministrador;
                var parametro3 = _comandosql.Parameters.Add("@Numero", SqlDbType.Int, 20);
                parametro3.Value = Numero;
              

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
        public DataTable get_DatosCaja(char op, int IdCaja)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spCaja";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdCaja", SqlDbType.Int, 20);
                parametro2.Value = IdCaja;

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

        public DataTable get_idcaja(char op, int NumCaja)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spCaja";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Numero", SqlDbType.Int, 20);
                parametro2.Value = NumCaja;

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

        //DESCUENTO
        public bool add_Descuento(string opc, int IdDescuento, int IdProducto, int IdDepartamento,int IdAdmin, int Porcentaje, DateTime FechaInicio, DateTime FechaFinal)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spDescuento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdDescuento", SqlDbType.Int, 20);
                parametro2.Value = IdDescuento;
                var parametro3 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro3.Value = IdProducto;
                var parametro4 = _comandosql.Parameters.Add("@IdDepartamento", SqlDbType.Int, 20);
                parametro4.Value = IdDepartamento;
                var parametro5 = _comandosql.Parameters.Add("@IdAdmin", SqlDbType.Int, 20);
                parametro5.Value = IdAdmin;
                var parametro6 = _comandosql.Parameters.Add("@Porcentaje", SqlDbType.Int, 20);
                parametro6.Value = Porcentaje;
                var parametro7 = _comandosql.Parameters.Add("@FechaInicio", SqlDbType.DateTime);
                parametro7.Value = FechaInicio;
                var parametro8 = _comandosql.Parameters.Add("@FechaFinal", SqlDbType.DateTime);
                parametro8.Value = FechaFinal;


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

        public DataTable get_DatosDescuento(char op, int IdDescuento)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spDescuento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdDescuento", SqlDbType.Int, 20);
                parametro2.Value = IdDescuento;

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

        public DataTable get_DatosPorcentaje(char op, int IdProducto)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spDescuento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro2.Value = IdProducto;

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

        public bool actualiza_Descuento(char opc ,int IdProducto)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spProductos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro2.Value = IdProducto;
               
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

        //PRINCIPAL CAJERO
        public DataTable get_DatosProductosByName(char op, string Nombre)
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
                var parametro2 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 30);
                parametro2.Value = Nombre;

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

        //VENTA
        public bool add_Venta(char opc, int IdProducto, string NombreProducto, decimal CantidadProducto, decimal CostoUnitario, decimal Costo, string Descuento, decimal subtotal, decimal Total, string  Departamento, decimal MontoCambio, decimal MontopPagado, DateTime FechaRegistro, string NombreCajero,int IdCajero, int IdDepartamento, string UnidadMedida, int Identificador)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spVenta";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro3 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro3.Value = IdProducto;
                var parametro4 = _comandosql.Parameters.Add("@NombreProducto", SqlDbType.VarChar, 50);
                parametro4.Value = NombreProducto;
                var parametro5 = _comandosql.Parameters.Add("@CantidadProducto", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@CantidadProducto"].Precision = 10;
                _comandosql.Parameters["@CantidadProducto"].Scale = 2;
                parametro5.Value = CantidadProducto;
                var parametro6 = _comandosql.Parameters.Add("@CostoUnitario", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@CostoUnitario"].Precision = 10;
                _comandosql.Parameters["@CostoUnitario"].Scale = 2;
                parametro6.Value = CostoUnitario;
                var parametro7 = _comandosql.Parameters.Add("@Costo", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@Costo"].Precision = 10;
                _comandosql.Parameters["@Costo"].Scale = 2;
                parametro7.Value = Costo;
                var parametro8 = _comandosql.Parameters.Add("@Descuento", SqlDbType.VarChar, 50);
                parametro8.Value = Descuento;
                var parametro9 = _comandosql.Parameters.Add("@subtotal", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@subtotal"].Precision = 10;
                _comandosql.Parameters["@subtotal"].Scale = 2;
                parametro9.Value = subtotal;
                var parametro10 = _comandosql.Parameters.Add("@Total", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@Total"].Precision = 10;
                _comandosql.Parameters["@Total"].Scale = 2;
                parametro10.Value = Total;
                var parametro11 = _comandosql.Parameters.Add("@Departamento", SqlDbType.VarChar, 50);
                parametro11.Value = Departamento;
                var parametro18 = _comandosql.Parameters.Add("@MontoCambio", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@MontoCambio"].Precision = 10;
                _comandosql.Parameters["@MontoCambio"].Scale = 2;
                parametro18.Value = MontoCambio;
                var parametro12 = _comandosql.Parameters.Add("@MontopPagado", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@MontopPagado"].Precision = 10;
                _comandosql.Parameters["@MontopPagado"].Scale = 2;
                parametro12.Value = MontopPagado;
                var parametro13 = _comandosql.Parameters.Add("@FechaRegistro", SqlDbType.DateTime);
                parametro13.Value = FechaRegistro;
                var parametro14 = _comandosql.Parameters.Add("@NombreCajero", SqlDbType.VarChar, 50);
                parametro14.Value = NombreCajero;
                var parametr15 = _comandosql.Parameters.Add("@IdCajero", SqlDbType.Int, 20);
                parametr15.Value = IdCajero;
                var parametro16 = _comandosql.Parameters.Add("@IdDepartamento", SqlDbType.Int, 20);
                parametro16.Value = IdDepartamento;
                var parametro17 = _comandosql.Parameters.Add("@UnidadMedida", SqlDbType.VarChar, 50);
                parametro17.Value = UnidadMedida;
                var parametro19 = _comandosql.Parameters.Add("@Identificador", SqlDbType.Int, 20);
                parametro19.Value = Identificador;
                
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

        public DataTable get_DatosVenta(char op, int Identificador)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spVenta";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Identificador", SqlDbType.Int, 20);
                parametro2.Value = Identificador;

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
        public DataTable get_DatosVentaInventario(char op, int IdVenta)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spVenta";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdVenta", SqlDbType.Int, 20);
                parametro2.Value = IdVenta;

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

        //OPCION PAGO
        public DataTable get_IdOpcionPago(char op, string Opcion)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spOpcion_Pago";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                parametro2.Value = Opcion;

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
        public bool add_TipoPago(string opc, int IdTipo, int IdCajero, int IdPago, int IdVenta, int Identificador, string Opcion, decimal MontoCambio, decimal MontopPagado)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spTipo_Pago";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdTipo", SqlDbType.Int, 20);
                parametro2.Value = IdTipo;
                var parametro3 = _comandosql.Parameters.Add("@IdCajero", SqlDbType.Int, 20);
                parametro3.Value = IdCajero;
                var parametro4 = _comandosql.Parameters.Add("@IdPago", SqlDbType.Int, 20);
                parametro4.Value = IdPago;
                var parametro5 = _comandosql.Parameters.Add("@IdVenta", SqlDbType.Int, 20);
                parametro5.Value = IdVenta;
                var parametro6 = _comandosql.Parameters.Add("@Identificador", SqlDbType.Int, 20);
                parametro6.Value = Identificador;
                var parametro7 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 50);
                parametro7.Value = Opcion;
                var parametro8 = _comandosql.Parameters.Add("@MontoCambio", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@MontoCambio"].Precision = 10;
                _comandosql.Parameters["@MontoCambio"].Scale = 2;
                parametro8.Value = MontoCambio;
                var parametro9 = _comandosql.Parameters.Add("@MontopPagado", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@MontopPagado"].Precision = 10;
                _comandosql.Parameters["@MontopPagado"].Scale = 2;
                parametro9.Value = MontopPagado;


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
        public DataTable get_DatosTipoPago(char op, int Identificador)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spTipo_Pago";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@Identificador", SqlDbType.Int, 20);
                parametro2.Value = Identificador;

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

        //TICKET
        public bool add_Ticket(string opc, int IdTicket, int IdVenta, int IdCajero, int IdTipoPago, DateTime FechaHr, int NumCaja, decimal Subtotal , decimal DescuentoTotal, decimal MontoCambio, int IdCaja)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spTicket";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdTicket", SqlDbType.Int, 20);
                parametro2.Value = IdTicket;
                var parametro3 = _comandosql.Parameters.Add("@IdVenta", SqlDbType.Int, 20);
                parametro3.Value = IdVenta;
                var parametro4 = _comandosql.Parameters.Add("@IdCajero", SqlDbType.Int, 20);
                parametro4.Value = IdCajero;
                var parametro5 = _comandosql.Parameters.Add("@IdTipoPago", SqlDbType.Int, 20);
                parametro5.Value = IdTipoPago;
                var parametro6 = _comandosql.Parameters.Add("@FechaHr", SqlDbType.DateTime);
                parametro6.Value = FechaHr;
                var parametro7 = _comandosql.Parameters.Add("@NumCaja", SqlDbType.Int, 20);
                parametro7.Value = NumCaja;
                var parametro8 = _comandosql.Parameters.Add("@Subtotal", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@Subtotal"].Precision = 10;
                _comandosql.Parameters["@Subtotal"].Scale = 2;
                parametro8.Value = Subtotal;
                var parametro9 = _comandosql.Parameters.Add("@DescuentoTotal", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@DescuentoTotal"].Precision = 10;
                _comandosql.Parameters["@DescuentoTotal"].Scale = 2;
                parametro9.Value = DescuentoTotal;
                var parametro10= _comandosql.Parameters.Add("@MontoCambio", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@MontoCambio"].Precision = 10;
                _comandosql.Parameters["@MontoCambio"].Scale = 2;
                parametro10.Value = MontoCambio;
                var parametro11 = _comandosql.Parameters.Add("@IdCaja", SqlDbType.Int, 20);
                parametro11.Value = IdCaja;
                

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
        public DataTable get_DatosTicket(char op, int IdTicket)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spTicket";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdTicket", SqlDbType.Int, 20);
                parametro2.Value = IdTicket;

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
        //DEVOLUCIONES
        public DataTable get_DatosDevolucion(char op, int IdVenta)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spDevolucion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = op;
                var parametro2 = _comandosql.Parameters.Add("@IdVenta", SqlDbType.Int, 20);
                parametro2.Value = IdVenta;

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

        public bool add_Devolucion(string opc, int IdDevolucion, int IdProducto, int IdDepartamento, int IdAdministrador, int IdVenta, int Merma, string Motivo, DateTime FechaRegistro, int IdTicket)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spDevolucion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@IdDevolucion", SqlDbType.Int, 20);
                parametro2.Value = IdDevolucion;
                var parametro3 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro3.Value = IdProducto;
                var parametro4 = _comandosql.Parameters.Add("@IdDepartamento", SqlDbType.Int, 20);
                parametro4.Value = IdDepartamento;
                var parametro5 = _comandosql.Parameters.Add("@IdAdministrador", SqlDbType.Int, 20);
                parametro5.Value = IdAdministrador;
                var parametro6 = _comandosql.Parameters.Add("@IdVenta", SqlDbType.Int, 20);
                parametro6.Value = IdVenta;
                var parametro7 = _comandosql.Parameters.Add("@Merma", SqlDbType.Int, 1);
                parametro7.Value = Merma;
                var parametro8 = _comandosql.Parameters.Add("@Motivo", SqlDbType.VarChar, 100);
                parametro8.Value = Motivo;
                var parametro9 = _comandosql.Parameters.Add("@FechaRegistro", SqlDbType.DateTime);
                parametro9.Value = FechaRegistro;
                var parametro10 = _comandosql.Parameters.Add("@IdTicket", SqlDbType.Int, 20);
                parametro10.Value = IdTicket;


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

        //NOTA CREDITO
        public bool add_NotaCredito(string opc, int IdProducto, int IdTicket, decimal cantidad, decimal subtotal, decimal total, DateTime FechaDevolucion, int IdCaja, int IdDevolucion)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spNotaCredito";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 1);
                parametro1.Value = opc;
                var parametro3 = _comandosql.Parameters.Add("@IdProducto", SqlDbType.Int, 20);
                parametro3.Value = IdProducto;
                var parametro4 = _comandosql.Parameters.Add("@idTicket", SqlDbType.Int, 20);
                parametro4.Value = IdTicket;
                var parametro5 = _comandosql.Parameters.Add("@cantidad", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@cantidad"].Precision = 10;
                _comandosql.Parameters["@cantidad"].Scale = 2;
                parametro5.Value = cantidad;
                var parametro6 = _comandosql.Parameters.Add("@subtotal", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@subtotal"].Precision = 10;
                _comandosql.Parameters["@subtotal"].Scale = 2;
                parametro6.Value = subtotal;
                var parametro7 = _comandosql.Parameters.Add("@total", SqlDbType.Decimal, 10);
                _comandosql.Parameters["@total"].Precision = 10;
                _comandosql.Parameters["@total"].Scale = 2;
                parametro7.Value = total;
                var parametro8 = _comandosql.Parameters.Add("@FechaDevolucion", SqlDbType.DateTime);
                parametro8.Value = FechaDevolucion;
                var parametro9 = _comandosql.Parameters.Add("@IdCaja", SqlDbType.Int, 20);
                parametro9.Value = IdCaja;
                var parametro10 = _comandosql.Parameters.Add("@IdDevolucion", SqlDbType.Int, 20);
                parametro10.Value = IdDevolucion;


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

    }

}
