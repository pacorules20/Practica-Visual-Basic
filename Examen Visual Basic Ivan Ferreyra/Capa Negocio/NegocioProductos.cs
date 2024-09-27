using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Datos;
using Examen_Visual_Basic_Ivan_Ferreyra.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Negocio
{
    /// <summary>
    /// La clase NegocioProductos gestiona la lógica de negocio relacionada con los productos.
    /// Proporciona métodos para agregar, modificar, eliminar y obtener productos.
    /// </summary>
    class NegocioProductos
    {
        /// <summary>
        /// Obtiene todos los productos registrados en la base de datos.
        /// </summary>
        /// <returns>Devuelve un DataTable con los datos de todos los productos.</returns>
        public DataTable ObtenerProductos()
        {
            DatosProductos Dato = new DatosProductos();
            DataTable Tabla;
            return Tabla = Dato.ObtenerTablaProductos();
        }

        /// <summary>
        /// Agrega un nuevo producto a la base de datos si no existe previamente.
        /// </summary>
        /// <param name="nombreProducto">Nombre del producto.</param>
        /// <param name="precioProducto">Precio del producto.</param>
        /// <param name="categoriaProducto">Categoría del producto.</param>
        /// <returns>Devuelve true si el producto fue agregado exitosamente, de lo contrario false.</returns>
        public bool AgregarProductos(string nombreProducto, float precioProducto, string categoriaProducto)
        {
            Productos Producto = new Productos
            {
                Nombre_Pro1 = nombreProducto,
                Precio_Pro1 = precioProducto,
                Categoria_Pro1 = categoriaProducto
            };

            bool CantidadFilas = false;
            DatosProductos Dato = new DatosProductos();
            if (!Dato.ExisteProducto(Producto))
            {
                CantidadFilas = Dato.AgregarProducto(Producto);
                return CantidadFilas;
            }
            return CantidadFilas;
        }

        /// <summary>
        /// Elimina un producto de la base de datos usando su ID si existe.
        /// </summary>
        /// <param name="IdProducto">ID del producto a eliminar.</param>
        /// <returns>Devuelve true si el producto fue eliminado exitosamente, de lo contrario false.</returns>
        public bool BorrarProducto(int IdProducto)
        {
            bool CantidadFilas = false;
            DatosProductos Dato = new DatosProductos();
            if (Dato.ExisteProductoPorID(IdProducto))
            {
                CantidadFilas = Dato.EliminarProducto(IdProducto);
                return CantidadFilas;
            }
            return CantidadFilas;
        }

        /// <summary>
        /// Modifica los datos de un producto existente.
        /// </summary>
        /// <param name="idProducto">ID del producto a modificar.</param>
        /// <param name="nombreProducto">Nuevo nombre del producto.</param>
        /// <param name="precioProducto">Nuevo precio del producto.</param>
        /// <param name="categoriaProducto">Nueva categoría del producto.</param>
        /// <returns>Devuelve true si el producto fue modificado exitosamente, de lo contrario false.</returns>
        public bool ModificarProducto(int idProducto, string nombreProducto, float precioProducto, string categoriaProducto)
        {
            Productos Producto = new Productos
            {
                Id_Pro1 = idProducto,
                Nombre_Pro1 = nombreProducto,
                Precio_Pro1 = precioProducto,
                Categoria_Pro1 = categoriaProducto
            };

            DatosProductos Dato = new DatosProductos();
            bool FilasAfectadas = Dato.EditarProducto(Producto);
            return FilasAfectadas;
        }
    }
}

