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
    /// La clase DatosProductos maneja las operaciones relacionadas con la tabla de productos en la base de datos.
    /// Proporciona métodos para agregar, eliminar, editar y verificar la existencia de productos.
    /// </summary>
    class DatosProductos
    {
        // Instancia de la clase Conexiones para manejar la conexión a la base de datos.
        Conexiones conexion = new Conexiones();

        /// <summary>
        /// Verifica si un producto ya existe en la base de datos con el mismo nombre, precio y categoría.
        /// </summary>
        /// <param name="Producto">El objeto Productos que contiene los datos del producto a verificar.</param>
        /// <returns>Devuelve true si el producto existe, de lo contrario devuelve false.</returns>
        public Boolean ExisteProducto(Productos Producto)
        {
            String consulta = "SELECT * FROM productos WHERE Nombre = '" + Producto.Nombre_Pro1 +
                              "' AND Precio = " + Producto.Precio_Pro1 +
                              " AND Categoria = '" + Producto.Categoria_Pro1 + "'";
            return conexion.Existe(consulta);
        }

        /// <summary>
        /// Obtiene todos los productos de la tabla 'productos' en la base de datos.
        /// </summary>
        /// <returns>Devuelve un DataTable que contiene los datos de todos los productos.</returns>
        public DataTable ObtenerTablaProductos()
        {
            DataTable Tabla = conexion.ObtenerTabla("productos", "SELECT * FROM productos");
            return Tabla;
        }

        /// <summary>
        /// Agrega un nuevo producto a la base de datos.
        /// </summary>
        /// <param name="Producto">El objeto Productos que contiene los datos del producto a agregar.</param>
        /// <returns>Devuelve true si el producto se agregó correctamente, de lo contrario devuelve false.</returns>
        public bool AgregarProducto(Productos Producto)
        {
            string consultaInsert = "INSERT INTO productos (Nombre, Precio, Categoria) " +
                                    "VALUES ('" + Producto.Nombre_Pro1 + "', " + Producto.Precio_Pro1 +
                                    ", '" + Producto.Categoria_Pro1 + "')";
            return conexion.EjecutarConsulta(consultaInsert);
        }

        /// <summary>
        /// Verifica si existe un producto con un ID específico.
        /// </summary>
        /// <param name="IdProducto">El ID del producto a verificar.</param>
        /// <returns>Devuelve true si existe un producto con ese ID, de lo contrario devuelve false.</returns>
        public Boolean ExisteProductoPorID(int IdProducto)
        {
            String consulta = "SELECT * FROM productos WHERE ID = " + IdProducto;
            return conexion.Existe(consulta);
        }

        /// <summary>
        /// Elimina un producto de la base de datos según su ID.
        /// </summary>
        /// <param name="IdProducto">El ID del producto a eliminar.</param>
        /// <returns>Devuelve true si el producto se eliminó correctamente, de lo contrario devuelve false.</returns>
        public bool EliminarProducto(int IdProducto)
        {
            string consultaDelete = "DELETE FROM productos WHERE ID = " + IdProducto;
            return conexion.EjecutarConsulta(consultaDelete);
        }
         
        /// <summary>
        /// Edita los datos de un producto existente en la base de datos.
        /// </summary>
        /// <param name="Producto">El objeto Productos que contiene los nuevos datos del producto.</param>
        /// <returns>Devuelve true si los datos del producto se actualizaron correctamente, de lo contrario devuelve false.</returns>
        public bool EditarProducto(Productos Producto)
        {
            string consultaUpdate = "UPDATE productos SET Nombre = '" + Producto.Nombre_Pro1 +
                                    "', Precio = REPLACE('" + Producto.Precio_Pro1 + "', ',', '.')"+
                                    ", Categoria = '" + Producto.Categoria_Pro1 +
                                    "' WHERE ID = " + Producto.Id_Pro1;
            return conexion.EjecutarConsulta(consultaUpdate);
        }
    }
}
