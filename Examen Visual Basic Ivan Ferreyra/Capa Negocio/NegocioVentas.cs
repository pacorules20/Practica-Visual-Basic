using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Negocio
{
    /// <summary>
    /// La clase NegocioVentas gestiona la lógica de negocio relacionada con las ventas.
    /// Proporciona métodos para obtener información sobre las ventas registradas.
    /// </summary>
    class NegocioVentas
    {
        /// <summary>
        /// Obtiene todos los registros de ventas desde la base de datos.
        /// </summary>
        /// <returns>Devuelve un DataTable con los datos de todas las ventas.</returns>
        public DataTable ObtenerVentas()
        {
            DatosVentas Dato = new DatosVentas();
            DataTable Tabla;
            return Tabla = Dato.ObtenerTablaVentas();
        }
    }
}
