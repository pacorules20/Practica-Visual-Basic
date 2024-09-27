using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Datos
{
    /// <summary>
    /// La clase DatosVentas maneja las operaciones relacionadas con la tabla de ventas en la base de datos.
    /// Proporciona métodos para recuperar las ventas registradas.
    /// </summary>
    class DatosVentas
    {
        // Instancia de la clase Conexiones para manejar la conexión a la base de datos.
        Conexiones conexion = new Conexiones();

        /// <summary>
        /// Obtiene todos los registros de la tabla 'ventas' en la base de datos.
        /// </summary>
        /// <returns>Devuelve un DataTable que contiene los datos de todas las ventas registradas.</returns>
        public DataTable ObtenerTablaVentas()
        {
            DataTable Tabla = conexion.ObtenerTabla("ventas", "SELECT * FROM ventas");
            return Tabla;
        }
    }
}
