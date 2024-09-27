using Examen_Visual_Basic_Ivan_Ferreyra.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Datos
{
    /// <summary>
    /// La clase DatosVentasItems maneja las operaciones relacionadas con la tabla de ventasitems en la base de datos.
    /// Proporciona métodos para agregar, eliminar, editar y verificar la existencia de items de venta.
    /// </summary>
    class DatosVentasItems
    {
        // Instancia de la clase Conexiones para manejar la conexión a la base de datos.
        Conexiones conexion = new Conexiones();

        /// <summary>
        /// Verifica si un item de venta ya existe en la base de datos con el mismo ID de venta e ID de producto.
        /// </summary>
        /// <param name="VentasIt">El objeto VentasItems que contiene los datos del item de venta a verificar.</param>
        /// <returns>Devuelve true si el item de venta existe, de lo contrario devuelve false.</returns>
        public Boolean ExisteVentasIt(VentasItems VentasIt)
        {
            String consulta = "SELECT * FROM ventasitems WHERE IDVenta = '" + VentasIt.Id_Venta_VenItem1 +
                              "' AND IDProducto = '" + VentasIt.Id_Producto_VenItem1 + "'";
            return conexion.Existe(consulta);
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla 'ventasitems' en la base de datos.
        /// </summary>
        /// <returns>Devuelve un DataTable que contiene los datos de todos los items de venta.</returns>
        public DataTable ObtenerTablaVentasIt()
        {
            DataTable Tabla = conexion.ObtenerTabla("ventasitems", "SELECT * FROM ventasitems");
            return Tabla;
        }

        /// <summary>
        /// Agrega un nuevo item de venta a la base de datos, calculando el precio unitario y el precio total basados en el producto.
        /// </summary>
        /// <param name="VentasIt">El objeto VentasItems que contiene los datos del item de venta a agregar.</param>
        /// <returns>Devuelve true si el item de venta se agregó correctamente, de lo contrario devuelve false.</returns>
        public bool AgregarVentasItems(VentasItems VentasIt)
        {
            string consultaInsert = "INSERT INTO ventasitems (IDVenta, IDProducto, Cantidad, PrecioUnitario, PrecioTotal) " +
                                    "VALUES (" + VentasIt.Id_Venta_VenItem1 + ", " +
                                    VentasIt.Id_Producto_VenItem1 + ", " +
                                    VentasIt.Cantidad_VenItem1 + ", " +
                                    "(SELECT Precio FROM productos WHERE ID = " + VentasIt.Id_Producto_VenItem1 + "), " +
                                    "(SELECT Precio FROM productos WHERE ID = " + VentasIt.Id_Producto_VenItem1 + ") * " + VentasIt.Cantidad_VenItem1 + ")";
            return conexion.EjecutarConsulta(consultaInsert);
        }

        /// <summary>
        /// Verifica si existe un item de venta con un ID específico.
        /// </summary>
        /// <param name="IDVenta">El ID del item de venta a verificar.</param>
        /// <returns>Devuelve true si existe un item de venta con ese ID, de lo contrario devuelve false.</returns>
        public Boolean ExisteVentasItemsPorID(int IDVenta)
        {
            String consulta = "SELECT * FROM ventasitems WHERE ID = " + IDVenta;
            return conexion.Existe(consulta);
        }

        /// <summary>
        /// Elimina un item de venta de la base de datos según su ID.
        /// </summary>
        /// <param name="IDVenta">El ID del item de venta a eliminar.</param>
        /// <returns>Devuelve true si el item de venta se eliminó correctamente, de lo contrario devuelve false.</returns>
        public bool EliminarVentasItems(int IDVenta)
        {
            string consultaDelete = "DELETE FROM ventasitems WHERE ID = " + IDVenta;
            return conexion.EjecutarConsulta(consultaDelete);
        }

        /// <summary>
        /// Edita los datos de un item de venta existente en la base de datos.
        /// Actualiza el precio unitario y el precio total basados en el producto correspondiente.
        /// </summary>
        /// <param name="VentasIt">El objeto VentasItems que contiene los nuevos datos del item de venta.</param>
        /// <returns>Devuelve true si los datos del item de venta se actualizaron correctamente, de lo contrario devuelve false.</returns>
        public bool EditarVentasItems(VentasItems VentasIt)
        {
            string consultaUpdate = "UPDATE ventasitems SET IDVenta = " + VentasIt.Id_Venta_VenItem1 +
                                    ", IDProducto = " + VentasIt.Id_Producto_VenItem1 +
                                    ", Cantidad = " + VentasIt.Cantidad_VenItem1 +
                                    ", PrecioUnitario = (SELECT Precio FROM productos WHERE ID = " + VentasIt.Id_Producto_VenItem1 + ")" +
                                    ", PrecioTotal = (SELECT Precio FROM productos WHERE ID = " + VentasIt.Id_Producto_VenItem1 + ") * " + VentasIt.Cantidad_VenItem1 +
                                    " WHERE ID = " + VentasIt.Id_VenItem1;

            return conexion.EjecutarConsulta(consultaUpdate);
        }
    }
}
