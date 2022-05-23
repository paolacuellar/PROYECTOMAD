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

       /* public DataTable updateDeptos(int id)
        {

        }*/
    }
}
