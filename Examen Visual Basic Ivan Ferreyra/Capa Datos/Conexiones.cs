using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Datos
{
    /// <summary>
    /// La clase Conexiones maneja la conexión a la base de datos SQL Server
    /// y ofrece métodos para ejecutar consultas y obtener datos.
    /// </summary>
    class Conexiones
    {
        // Cadena de conexión a la base de datos obtenida del archivo de configuración.
        static string SQLconexion = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection Conexion = new SqlConnection(SQLconexion);

        /// <summary>
        /// Establece la conexión con la base de datos.
        /// </summary>
        /// <returns>Devuelve la conexión abierta si se establece correctamente, de lo contrario devuelve null.</returns>
        public SqlConnection ObtenerConexion()
        {
            try
            {
                Conexion.Open();
                return Conexion;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene un adaptador de datos para ejecutar una consulta SQL.
        /// </summary>
        /// <param name="consultaSql">La consulta SQL a ejecutar.</param>
        /// <param name="cn">La conexión a la base de datos.</param>
        /// <returns>Devuelve un objeto SqlDataAdapter si la operación es exitosa, de lo contrario devuelve null.</returns>
        private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene una tabla de datos desde la base de datos.
        /// </summary>
        /// <param name="nombreTabla">El nombre de la tabla que se va a obtener.</param>
        /// <param name="sql">La consulta SQL que recupera los datos.</param>
        /// <returns>Devuelve un objeto DataTable que contiene los datos de la tabla.</returns>
        public DataTable ObtenerTabla(String nombreTabla, String sql)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(sql, Conexion);
            adp.Fill(ds, nombreTabla);
            Conexion.Close();
            return ds.Tables[nombreTabla];
        }

        /// <summary>
        /// Verifica si existe algún resultado para una consulta SQL.
        /// </summary>
        /// <param name="consulta">La consulta SQL para verificar la existencia de registros.</param>
        /// <returns>Devuelve true si existe al menos un registro, de lo contrario devuelve false.</returns>
        public Boolean Existe(String consulta)
        {
            Boolean estado = false;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }
            Conexion.Close();
            return estado;
        }

        /// <summary>
        /// Ejecuta una consulta SQL que no devuelve resultados, como INSERT, UPDATE o DELETE.
        /// </summary>
        /// <param name="consulta">La consulta SQL a ejecutar.</param>
        /// <returns>Devuelve true si se afectan filas, de lo contrario devuelve false.</returns>
        public bool EjecutarConsulta(String consulta)
        {
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return filasAfectadas > 0;
        }
    }
}
