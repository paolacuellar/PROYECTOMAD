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

        private  void conectar()
        {
            //string cnn = ConfigurationManager.AppSettings["desarrollo1"];
           String connetionString = @"Data Source=DESKTOP-MFMA6VE\SQLEXPRESS;Initial Catalog=PROYECTOMAD;Integrated Security=True;";
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

                if(_tabla.Rows.Count > 0)
                {
                    temp = _tabla.Rows[0];
                }

            }
            catch(SqlException e)
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

                _comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 10);
                _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 10);
                _comandosql.Parameters.Add("@A_Paterno", SqlDbType.VarChar, 10);
                _comandosql.Parameters.Add("@A_Materno", SqlDbType.VarChar, 10);
                _comandosql.Parameters.Add("@Fecha_nacimiento", SqlDbType.VarChar, 10);
                _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 10);
                _comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 10);
                _comandosql.Parameters.Add("@NumSeguro_Social", SqlDbType.VarChar, 10);

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

        //Obtenemos la nomina del empleado por ID para poder mostrarla 
        public DataRow getNominaById(int id)
        {
            var msg = "";
                DataRow empleado = null;
                try
                {
                    _tabla = new DataTable();
                    conectar();
                    string qry = "sp_ViewNomina";
                    _comandosql = new SqlCommand(qry, _conexion);
                    _comandosql.CommandType = CommandType.StoredProcedure;
                    _comandosql.CommandTimeout = 1200;

                    var parametro1 = _comandosql.Parameters.Add("@Fecha", SqlDbType.Date, 10);
                    parametro1.Value = "VIEWE";

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

                _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.VarChar, 10);
                _comandosql.Parameters.Add("@ID_Departamento", SqlDbType.Int, 10);
                _comandosql.Parameters.Add("@ID_Deduccion", SqlDbType.TinyInt, 10);
                _comandosql.Parameters.Add("@ID_Percepcion", SqlDbType.TinyInt, 10);
                _comandosql.Parameters.Add("@ID_ADeduccion", SqlDbType.Int, 10);
                _comandosql.Parameters.Add("@ID_APercepcion", SqlDbType.Int, 10);
                
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

                _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.VarChar, 10);
                _comandosql.Parameters.Add("@ID_Departamento", SqlDbType.Int, 10);
                _comandosql.Parameters.Add("@ID_Deduccion", SqlDbType.TinyInt, 10);
                _comandosql.Parameters.Add("@ID_Percepcion", SqlDbType.TinyInt, 10);
                _comandosql.Parameters.Add("@ID_ADeduccion", SqlDbType.Int, 10);
                _comandosql.Parameters.Add("@ID_APercepcion", SqlDbType.Int, 10);

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

        public bool updateEmpleados(int id, string nombreT, string apellidopT, string apellidomT, string curpT, string nacimientoT, string emailT,
            string rfcT, string nssT, string bancoT, int numbancariaT, string calleT, int numT, string coloniaT, string estadoT, string telefonoT,
            string contraseniaT)
        {
            bool seActualizo = true;
            var msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opcion", SqlDbType.VarChar, 10);
                parametro1.Value = "UPDATE";

                var parametro2 = _comandosql.Parameters.Add("@CveEmpleado", SqlDbType.Int, 10);
                parametro2.Value = id; 

                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 10);
                parametro3.Value = nombreT;

                var parametro4 = _comandosql.Parameters.Add("@A_Paterno", SqlDbType.VarChar, 10);
                parametro4.Value = apellidopT;

                var parametro5 = _comandosql.Parameters.Add("@A_Materno", SqlDbType.VarChar, 10);
                parametro5.Value = apellidomT;

                var parametro6 = _comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 10);
                parametro6.Value = curpT;

                var parametro7 = _comandosql.Parameters.Add("@Fecha_nacimiento", SqlDbType.VarChar, 10);
                parametro7.Value = nacimientoT;

                var parametro8 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 10);
                parametro8.Value = emailT;

                var parametro9 = _comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 10);
                parametro9.Value = rfcT;

                var parametro10 = _comandosql.Parameters.Add("@NumSeguro_Social", SqlDbType.VarChar, 10);
                parametro10.Value = nssT;

                var parametro11 = _comandosql.Parameters.Add("@Banco", SqlDbType.VarChar, 25);
                parametro11.Value = bancoT;

                var parametro12 = _comandosql.Parameters.Add("@NumCuentaBan", SqlDbType.Int, 25);
                parametro12.Value = numbancariaT;

                var parametro13 = _comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 25);
                parametro13.Value = calleT;

                var parametro14 = _comandosql.Parameters.Add("@numero", SqlDbType.Int, 10);
                parametro14.Value = numT;

                var parametro15 = _comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 25);
                parametro15.Value = coloniaT;

                var parametro16 = _comandosql.Parameters.Add("@estadopais", SqlDbType.VarChar, 25);
                parametro16.Value = estadoT;

                var parametro17 = _comandosql.Parameters.Add("@telefono", SqlDbType.VarChar, 18);
                parametro17.Value = telefonoT;

                var parametro18 = _comandosql.Parameters.Add("@Constrasenia", SqlDbType.VarChar, 25);
                parametro18.Value = contraseniaT;

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

        //Actualizar datos de Departamentos//
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

        //Actualizar datos de puesto//
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
    
        
    }
}
