using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace MAD_Pantallas
{
    public partial class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        private void conectar()
        {
            //string cnn = ConfigurationManager.AppSettings["desarrollo1"];

            //String connetionString = @"Data Source=DESKTOP-MFMA6VE\SQLEXPRESS;Initial Catalog=PROYECTOMAD;Integrated Security=True;"; //ARELY

            String connetionString = @"Data Source=LAPTOP-02AHRSHI\SQLEXPRESS;Initial Catalog=PROYECTOMAD;Integrated Security=True;"; //LAPTOP

            //String connetionString = @"Data Source=DESKTOP-51SJOGN;Initial Catalog=PROYECTOMAD;Integrated Security=True;"; //KARIM

            //string cnn = ConfigurationManager.ConnectionStrings[connetionString].ToString();
            _conexion = new SqlConnection(connetionString);
            _conexion.Open();
        }

        private static void desconectar()
        {
            _conexion.Close();
        }

        //Verificamos las credenciales del empleado para darle acceso y mostrar el menu correspondiente
        public DataRow Autentificar(string us, string ps)
        {
            var msg = "";
            DataRow temp = null;
            try
            {
                conectar();
                string qry = "sp_ValidaUsuario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 20);
                parametro1.Value = us;
                var parametro2 = _comandosql.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 25);
                parametro2.Value = ps;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    temp = _tabla.Rows[0];
                }

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

            return temp;
        }

        //Buscamos los datos del empleado por ID para poder mostrar la informacion correcta en la ventana de Perfil
        public DataRow getEmpleadoById(int id)
        {
            var msg = "";
            DataRow empleado = null;
            try
            {
                _tabla = new DataTable();
                conectar();
                string qry = "sp_GestionEmpleado";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "VIEWE";

                _comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 25);
                _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 255);
                _comandosql.Parameters.Add("@A_Paterno", SqlDbType.VarChar, 25);
                _comandosql.Parameters.Add("@A_Materno", SqlDbType.VarChar, 25);
                _comandosql.Parameters.Add("@Fecha_nacimiento", SqlDbType.VarChar, 10);
                _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 25);
                _comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 25);
                _comandosql.Parameters.Add("@NumSeguro_Social", SqlDbType.VarChar, 25);

                var parametro2 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 10);
                parametro2.Value = id;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    empleado = _tabla.Rows[0];
                }
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

            return empleado;
        }

        //Departamento by id
        public DataRow getDeptoById(int id)
        {
            var msg = "";
            DataRow depto = null;
            try
            {
                _tabla = new DataTable();
                conectar();
                string qry = "sp_GestionDepartamento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "VIEWE";

                var parametro2 = _comandosql.Parameters.Add("@ID_Departamento", SqlDbType.Int, 10);
                parametro2.Value = id;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    depto = _tabla.Rows[0];
                }
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

            return depto;
        }

        //Departamento by id
        public DataRow getPuestoById(int id)
        {
            var msg = "";
            DataRow puesto = null;
            try
            {
                _tabla = new DataTable();
                conectar();
                string qry = "sp_GestionPuesto";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "VIEWE";

                var parametro2 = _comandosql.Parameters.Add("@ID_Puesto", SqlDbType.Int, 10);
                parametro2.Value = id;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    puesto = _tabla.Rows[0];
                }
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

            return puesto;
        }


        //Buscamos las percepciones y las deducciones por fecha para mostrar las que fueron mostradas en cierto mes 
        //en la ventana de consultar nomina
        public DataTable getPercepcionesByDate(DateTime date)
        {
            var msg = "";
            try
            {
                _tabla = new DataTable();
                conectar();
                string qry = "sp_AsignacionPD";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "SPxM";

                //_comandosql.Parameters.Add("@CveEmpleado", SqlDbType.VarChar, 10);
                //_comandosql.Parameters.Add("@ID_Departamento", SqlDbType.Int, 10);
                //_comandosql.Parameters.Add("@ID_Deduccion", SqlDbType.TinyInt, 10);
                //_comandosql.Parameters.Add("@ID_Percepcion", SqlDbType.TinyInt, 10);
                //_comandosql.Parameters.Add("@ID_ADeduccion", SqlDbType.Int, 10);
                //_comandosql.Parameters.Add("@ID_APercepcion", SqlDbType.Int, 10);

                var parametro2 = _comandosql.Parameters.Add("@Fecha", SqlDbType.Date, 10);
                parametro2.Value = date;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

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

            return _tabla;
        }

        public DataTable getDeduccionesByDate(DateTime date)
        {
            var msg = "";
            try
            {
                _tabla = new DataTable();
                conectar();
                string qry = "sp_AsignacionPD";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "SDxM";

                //_comandosql.Parameters.Add("@CveEmpleado", SqlDbType.VarChar, 10);
                //_comandosql.Parameters.Add("@ID_Departamento", SqlDbType.Int, 10);
                //_comandosql.Parameters.Add("@ID_Deduccion", SqlDbType.TinyInt, 10);
                //_comandosql.Parameters.Add("@ID_Percepcion", SqlDbType.TinyInt, 10);
                //_comandosql.Parameters.Add("@ID_ADeduccion", SqlDbType.Int, 10);
                //_comandosql.Parameters.Add("@ID_APercepcion", SqlDbType.Int, 10);

                var parametro2 = _comandosql.Parameters.Add("@Fecha", SqlDbType.Date, 10);
                parametro2.Value = date;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

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

            return _tabla;
        }

        //Buscamos todas las percepciones y las deducciones para mostrarlas en los listbox de la ventana de 
        //gestion de percepciones y deducciones para poder aplicarlas a una nomina
        public DataTable getAllP()
        {
            var msg = "";
            try
            {
                _tabla = new DataTable();
                conectar();
                string qry = "sp_GestionPercepcion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "VIEW";

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

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

            return _tabla;
        }

        public DataTable getAllD()
        {
            var msg = "";
            try
            {
                _tabla = new DataTable();
                conectar();
                string qry = "sp_GestionDeduccion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "VIEW";

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

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

            return _tabla;
        }

        public DataTable getAllBasicP()
        {
            var msg = "";
            try
            {
                _tabla = new DataTable();
                conectar();
                string qry = "sp_GestionPercepcion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "VIEWB";

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

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

            return _tabla;
        }

        public DataTable getAllBasicD()
        {
            var msg = "";
            try
            {
                _tabla = new DataTable();
                conectar();
                string qry = "sp_GestionDeduccion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "VIEWB";

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

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

            return _tabla;
        }

        public bool insertPercepcion(string motivo, float cantidad, bool esPorcenaje)
        {
            var msg = "";
            bool seInserto = true;
            try
            {
                conectar();
                string qry = "sp_GestionPercepcion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "INSERT";

                var parametro2 = _comandosql.Parameters.Add("@Motivo", SqlDbType.VarChar, 255);
                parametro2.Value = motivo;

                var parametro3 = _comandosql.Parameters.Add("@Cantidad", SqlDbType.Decimal, 10);
                parametro3.Value = cantidad;

                var parametro4 = _comandosql.Parameters.Add("@Es_porcentaje", SqlDbType.Bit, 1);
                parametro4.Value = esPorcenaje;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se inserto la Percepción", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seInserto = false;
                }
                else
                {
                    MessageBox.Show("Se inserto la Percepción!", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seInserto = false;
            }
            finally
            {
                desconectar();
            }
            return seInserto;
        }

        public bool insertDeduccion(string motivo, float cantidad, bool esPorcenaje)
        {
            var msg = "";
            bool seInserto = true;
            try
            {
                conectar();
                string qry = "sp_GestionDeduccion";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "INSERT";

                var parametro2 = _comandosql.Parameters.Add("@Motivo", SqlDbType.VarChar, 255);
                parametro2.Value = motivo;

                var parametro3 = _comandosql.Parameters.Add("@Cantidad", SqlDbType.Decimal, 10);
                parametro3.Value = cantidad;

                var parametro4 = _comandosql.Parameters.Add("@Es_porcentaje", SqlDbType.Bit, 1);
                parametro4.Value = esPorcenaje;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se inserto la Deduccion", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seInserto = false;
                }
                else
                {
                    MessageBox.Show("Se inserto la Deduccion!", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seInserto = false;
            }
            finally
            {
                desconectar();
            }
            return seInserto;
        }

        public bool asignarConcepto(string Oper, int idConcepto, string tipoEnte, int idEnte, string fechaAplicacion)
        {
            string msg = "";
            bool seAsigno = true;

            try
            {
                conectar();
                string qry = "sp_AsignacionPD";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = Oper;

                var parametro2 = _comandosql.Parameters.Add("@ID_Concepto", SqlDbType.TinyInt, 10);
                parametro2.Value = idConcepto;

                if (tipoEnte == "E")
                {
                    var parametro3 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 10);
                    parametro3.Value = idEnte;
                }
                else if (tipoEnte == "D")
                {
                    var parametro3 = _comandosql.Parameters.Add("@ID_Departamento", SqlDbType.TinyInt, 10);
                    parametro3.Value = idEnte;
                }
                else
                {
                    MessageBox.Show("Solo se pueden asignar percepciones y deducciones a Empleados/Departamentos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }


                var parametro4 = _comandosql.Parameters.Add("@Fecha", SqlDbType.Date, 10);
                parametro4.Value = fechaAplicacion;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se asgno el Concepto", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seAsigno = false;
                }
                else
                {
                    MessageBox.Show("Se asgno el Concepto!", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seAsigno = false;
            }
            finally
            {
                desconectar();
            }
            return seAsigno;
        }

        public DataTable getPercepcionesAsignadas(int idEnte)
        {
            string msg = "";

            try
            {
                conectar();
                string qry = "sp_AsignacionPD";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "SPxME";               

                var parametro2 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 10);
                parametro2.Value = idEnte;
               

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);                

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
            return _tabla;
        }

        public DataTable getDeduccionesAsignadas(int idEnte)
        {
            string msg = "";

            try
            {
                conectar();
                string qry = "sp_AsignacionPD";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "SDxME";

                var parametro2 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 10);
                parametro2.Value = idEnte;
                

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);               


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
            return _tabla;
        }

        //Obtenemos la vista de Departamentos, Empleados y Puestos para mostrarlos en los listbox correspondientes en cada ventana
        public DataTable getDeptosV()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_GestionDepartamento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "VIEW";


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

        public DataTable getEmpleadosV()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_GestionEmpleado";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "VIEW";


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

        public DataTable getPuestosV()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_GestionPuesto";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "VIEW";


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

        //Actualizar datos de Empleados//
        //en su perfil//
        public bool updateEmpleadoDatos(int id, string emailT, string telefonoT, string contraseniaT)
        {
            bool seActualizo = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionEmpleado";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "UPDATE";

                var parametro2 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 10);
                parametro2.Value = id;

                var parametro3 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 25);
                parametro3.Value = emailT;

                var parametro4 = _comandosql.Parameters.Add("@telefono", SqlDbType.VarChar, 25);
                parametro4.Value = telefonoT;

                var parametro5 = _comandosql.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 25);
                parametro5.Value = contraseniaT;


                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se actualizo ninguna fila", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seActualizo = false;
                }
                else
                {
                    MessageBox.Show("Se actualizaron sus datos!", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seActualizo = false;
            }
            finally
            {
                desconectar();
            }
            return seActualizo;
        }

        //Gestion de Empleados//
        public bool updateEmpleados(int id, string nombreT, string apellidopT, string apellidomT, string curpT, string nacimientoT, string emailT,
            string rfcT, string nssT, string bancoT, string numbancariaT, string calleT, int numT, string coloniaT, string estadoT, int codPostalT,
            string telefonoT, string contraseniaT, string operacionesT, int idPuesto, int idDepto)
        {
            bool seActualizo = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionEmpleado";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "UPDATE";

                var parametro2 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 10);
                parametro2.Value = id;

                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                parametro3.Value = nombreT;

                var parametro4 = _comandosql.Parameters.Add("@A_Paterno", SqlDbType.VarChar, 25);
                parametro4.Value = apellidopT;

                var parametro5 = _comandosql.Parameters.Add("@A_Materno", SqlDbType.VarChar, 25);
                parametro5.Value = apellidomT;

                var parametro6 = _comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 25);
                parametro6.Value = curpT;

                var parametro7 = _comandosql.Parameters.Add("@Fecha_nacimiento", SqlDbType.Date, 10);
                parametro7.Value = nacimientoT;

                var parametro8 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 25);
                parametro8.Value = emailT;

                var parametro9 = _comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 25);
                parametro9.Value = rfcT;

                var parametro10 = _comandosql.Parameters.Add("@NumSeguro_Social", SqlDbType.Int, 10);
                if (nssT == "")
                    parametro10.Value = DBNull.Value;
                else
                    parametro10.Value = Int32.Parse(nssT);

                var parametro11 = _comandosql.Parameters.Add("@Banco", SqlDbType.VarChar, 50);
                parametro11.Value = bancoT;

                var parametro12 = _comandosql.Parameters.Add("@NumCuentaBan", SqlDbType.Int, 25);
                if (nssT == "")
                    parametro12.Value = DBNull.Value;
                else
                    parametro12.Value = Int32.Parse(numbancariaT);

                var parametro13 = _comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 25);
                parametro13.Value = calleT;

                var parametro14 = _comandosql.Parameters.Add("@numero", SqlDbType.Int, 10);
                parametro14.Value = numT;

                var parametro15 = _comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 25);
                parametro15.Value = coloniaT;

                var parametro16 = _comandosql.Parameters.Add("@municipio", SqlDbType.VarChar, 25);
                parametro16.Value = estadoT;

                var parametro17 = _comandosql.Parameters.Add("@codigo_postal", SqlDbType.Int, 25);
                parametro17.Value = codPostalT;

                var parametro18 = _comandosql.Parameters.Add("@telefono", SqlDbType.VarChar, 18);
                parametro18.Value = telefonoT;

                var parametro19 = _comandosql.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 25);
                parametro19.Value = contraseniaT;

                var parametro20 = _comandosql.Parameters.Add("@Fecha_contratacion", SqlDbType.Date, 25);
                parametro20.Value = operacionesT;

                var parametro21 = _comandosql.Parameters.Add("@ID_Puesto", SqlDbType.TinyInt);
                parametro21.Value = idPuesto;

                var parametro22 = _comandosql.Parameters.Add("@ID_Departamento", SqlDbType.TinyInt);
                parametro22.Value = idDepto;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se actualizo ninguna fila", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seActualizo = false;
                }
                else
                {
                    MessageBox.Show("Se actualizaron los datos del Empleado!", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seActualizo = false;
            }
            finally
            {
                desconectar();
            }
            return seActualizo;
        }

        public bool insertEmpleado(string nombreT, string apellidopT, string apellidomT, string curpT, string nacimientoT, string emailT,
            string rfcT, string nssT, string bancoT, string numbancariaT, string calleT, int numT, string coloniaT, string estadoT,
            int codPostalT, string telefonoT, string contraseniaT, string operacionesT, int idPuesto, int idDepto)
        {
            bool seInserto = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionEmpleado";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "INSERT";

                var parametro2 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 10);
                parametro2.Value = DBNull.Value;

                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                parametro3.Value = nombreT;

                var parametro4 = _comandosql.Parameters.Add("@A_Paterno", SqlDbType.VarChar, 25);
                parametro4.Value = apellidopT;

                var parametro5 = _comandosql.Parameters.Add("@A_Materno", SqlDbType.VarChar, 25);
                parametro5.Value = apellidomT;

                var parametro6 = _comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 25);
                parametro6.Value = curpT;

                var parametro7 = _comandosql.Parameters.Add("@Fecha_nacimiento", SqlDbType.Date, 10);
                parametro7.Value = nacimientoT;

                var parametro8 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 25);
                parametro8.Value = emailT;

                var parametro9 = _comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 25);
                parametro9.Value = rfcT;

                var parametro10 = _comandosql.Parameters.Add("@NumSeguro_Social", SqlDbType.Int, 10);
                if (nssT == "")
                    parametro10.Value = DBNull.Value;
                else
                    parametro10.Value = Int32.Parse(nssT);

                var parametro11 = _comandosql.Parameters.Add("@Banco", SqlDbType.VarChar, 50);
                parametro11.Value = bancoT;

                var parametro12 = _comandosql.Parameters.Add("@NumCuentaBan", SqlDbType.Int, 25);
                if (nssT == "")
                    parametro12.Value = DBNull.Value;
                else
                    parametro12.Value = Int32.Parse(numbancariaT);

                var parametro13 = _comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 25);
                parametro13.Value = calleT;

                var parametro14 = _comandosql.Parameters.Add("@numero", SqlDbType.Int, 10);
                parametro14.Value = numT;

                var parametro15 = _comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 25);
                parametro15.Value = coloniaT;

                var parametro16 = _comandosql.Parameters.Add("@municipio", SqlDbType.VarChar, 25);
                parametro16.Value = estadoT;

                var parametro17 = _comandosql.Parameters.Add("@codigo_postal", SqlDbType.Int, 10);
                parametro17.Value = codPostalT;

                var parametro18 = _comandosql.Parameters.Add("@telefono", SqlDbType.VarChar, 18);
                parametro18.Value = telefonoT;

                var parametro19 = _comandosql.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 25);
                parametro19.Value = contraseniaT;

                var parametro20 = _comandosql.Parameters.Add("@Fecha_contratacion", SqlDbType.Date, 25);
                parametro20.Value = operacionesT;

                var parametro21 = _comandosql.Parameters.Add("@ID_Puesto", SqlDbType.TinyInt);
                parametro21.Value = idPuesto;

                var parametro22 = _comandosql.Parameters.Add("@ID_Departamento", SqlDbType.TinyInt);
                parametro22.Value = idDepto;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se inserto el empleado", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seInserto = false;
                }
                else
                {
                    MessageBox.Show("Se inserto el empleado!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seInserto = false;
            }
            finally
            {
                desconectar();
            }
            return seInserto;
        }

        public bool deleteEmpleado(int id)
        {
            bool seElimino = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionEmpleado";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "DELETE";

                var parametro2 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 10);
                parametro2.Value = id;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se borro ningun registro", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seElimino = false;
                }
                else
                {
                    MessageBox.Show("Se elimino el empleado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seElimino = false;
            }
            finally
            {
                desconectar();
            }
            return seElimino;
        }

        //Gestion de Departamentos//
        public bool updateDeptos(int id, string nombreT, float sueldo_baseT)
        {
            bool seActualizo = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionDepartamento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "UPDATE";

                var parametro2 = _comandosql.Parameters.Add("@ID_Departamento", SqlDbType.Int, 10);
                parametro2.Value = id;

                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                parametro3.Value = nombreT;

                var parametro4 = _comandosql.Parameters.Add("@Sueldo_Base", SqlDbType.Decimal, 10);
                parametro4.Value = sueldo_baseT;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se actualizo ninguna fila", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seActualizo = false;
                }
                else
                {
                    MessageBox.Show("Se actualizo el departamento!", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seActualizo = false;
            }
            finally
            {
                desconectar();
            }
            return seActualizo;
        }

        public bool deleteDeptos(int id)
        {
            bool seElimino = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionDepartamento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "DELETE";

                var parametro2 = _comandosql.Parameters.Add("@ID_Departamento", SqlDbType.Int, 10);
                parametro2.Value = id;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se borro ningun registro", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seElimino = false;
                }
                else
                {
                    MessageBox.Show("Se elimino el Departamento", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seElimino = false;
            }
            finally
            {
                desconectar();
            }
            return seElimino;
        }

        public bool insertDeptos(string nombreT, float sueldo_baseT)
        {
            bool seInserto = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionDepartamento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "INSERT";

                var parametro2 = _comandosql.Parameters.Add("@ID_Departamento", SqlDbType.Int, 10);
                parametro2.Value = DBNull.Value;

                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                parametro3.Value = nombreT;

                var parametro4 = _comandosql.Parameters.Add("@Sueldo_Base", SqlDbType.VarChar, 25);
                parametro4.Value = sueldo_baseT;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se inserto el departamento", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seInserto = false;
                }
                else
                {
                    MessageBox.Show("Se inserto el Departamento!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seInserto = false;
            }
            finally
            {
                desconectar();
            }
            return seInserto;
        }

        //Gestion de Puestos//

        public bool insertPuestos(string nombreT, float sueldo_baseT)
        {
            bool seInserto = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionPuesto";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "INSERT";

                var parametro2 = _comandosql.Parameters.Add("@ID_Puesto", SqlDbType.Int, 10);
                parametro2.Value = DBNull.Value;

                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                parametro3.Value = nombreT;

                var parametro4 = _comandosql.Parameters.Add("@Nivel_Salarial", SqlDbType.VarChar, 25);
                parametro4.Value = sueldo_baseT;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se inserto el puesto", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seInserto = false;
                }
                else
                {
                    MessageBox.Show("Se inserto el Puesto!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seInserto = false;
            }
            finally
            {
                desconectar();
            }
            return seInserto;
        }

        public bool updatePuestos(int id, string nombreT, float nivel_salarialT)
        {
            bool seActualizo = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionPuesto";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "UPDATE";

                var parametro2 = _comandosql.Parameters.Add("@ID_Puesto", SqlDbType.Int, 10);
                parametro2.Value = id;

                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                parametro3.Value = nombreT;

                var parametro4 = _comandosql.Parameters.Add("@Nivel_Salarial", SqlDbType.Decimal, 10);
                parametro4.Value = nivel_salarialT;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se actualizo ninguna fila", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seActualizo = false;
                }
                else
                {
                    MessageBox.Show("Se actualizo el puesto!", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seActualizo = false;
            }
            finally
            {
                desconectar();
            }
            return seActualizo;
        }

        public bool deletePuestos(int id)
        {
            bool seElimino = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionPuesto";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "DELETE";

                var parametro2 = _comandosql.Parameters.Add("@ID_Puesto", SqlDbType.Int, 10);
                parametro2.Value = id;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se borro ningun registro", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seElimino = false;
                }
                else
                {
                    MessageBox.Show("Se elimino el Puesto", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seElimino = false;
            }
            finally
            {
                desconectar();
            }
            return seElimino;
        }

        //Calculos de Nomina

        public bool calcularNomina(string date)
        {
            bool seCalculo = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_CalculoNomina";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Fecha", SqlDbType.DateTime, 10);
                parametro1.Value = date;

                int rows = _comandosql.ExecuteNonQuery();

                if (rows <= 0)
                {
                    MessageBox.Show("No se calculó la nomina", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    seCalculo = false;
                }
                else
                {
                    MessageBox.Show("Se calculó la Nomina!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException e)
            {
                msg = "Excepcion de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                seCalculo = false;
            }
            finally
            {
                desconectar();
            }
            return seCalculo;
        }

        public DataRow getNominaByDate(int idEmpleado, string date)
        {
            var msg = "";
            try
            {
                _tabla = new DataTable();
                conectar();
                string qry = "sp_ViewNomina";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Fecha", SqlDbType.Date, 10);
                parametro1.Value = date;

                var parametro2 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 10);
                parametro2.Value = idEmpleado;



                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

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
            if (_tabla.Rows.Count <= 0)
                return null;

            return _tabla.Rows[0];
        }
    }
}
