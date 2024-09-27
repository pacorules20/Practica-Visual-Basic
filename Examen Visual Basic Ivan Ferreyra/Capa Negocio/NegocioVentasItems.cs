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
    /// La clase NegocioVentasItems gestiona la lógica de negocio relacionada con los items de ventas.
    /// Proporciona métodos para obtener, agregar, modificar y eliminar items de ventas.
    /// </summary>
    class NegocioVentasItems
    {
        /// <summary>
        /// Obtiene todos los items de ventas registrados en la base de datos.
        /// </summary>
        /// <returns>Devuelve un DataTable con los datos de todos los items de ventas.</returns>
        public DataTable ObtenerVentasItems()
        {
            DatosVentasItems Dato = new DatosVentasItems();
            DataTable Tabla;
            return Tabla = Dato.ObtenerTablaVentasIt();
        }

        /// <summary>
        /// Agrega un nuevo item de venta a la base de datos.
        /// </summary>
        /// <param name="Idventa">ID de la venta asociada.</param>
        /// <param name="IdProducto">ID del producto asociado.</param>
        /// <param name="Cantidad">Cantidad del producto vendido.</param>
        /// <returns>Devuelve true si el item de venta fue agregado exitosamente, de lo contrario false.</returns>
        public bool AgregarVentasItems(int Idventa, int IdProducto, float Cantidad)
        {
            VentasItems VentasIt = new VentasItems();
            VentasIt.Id_Venta_VenItem1 = Idventa;
            VentasIt.Id_Producto_VenItem1 = IdProducto;
            VentasIt.Cantidad_VenItem1 = Cantidad;

            bool CantidadFilas = false;
            DatosVentasItems Dato = new DatosVentasItems();
            if (Dato.ExisteVentasIt(VentasIt) == false)
            {
                CantidadFilas = Dato.AgregarVentasItems(VentasIt);
                return CantidadFilas;
            }
            return CantidadFilas;
        }

        /// <summary>
        /// Elimina un item de venta de la base de datos.
        /// </summary>
        /// <param name="IdVentasItems">ID del item de venta a eliminar.</param>
        /// <returns>Devuelve true si el item de venta fue eliminado exitosamente, de lo contrario false.</returns>
        public bool BorrarVentasItems(int IdVentasItems)
        {
            bool CantidadFilas = false;
            DatosVentasItems Dato = new DatosVentasItems();
            if (Dato.ExisteVentasItemsPorID(IdVentasItems) == true)
            {
                CantidadFilas = Dato.EliminarVentasItems(IdVentasItems);
                return CantidadFilas;
            }
            return CantidadFilas;
        }

        /// <summary>
        /// Modifica un item de venta existente en la base de datos.
        /// </summary>
        /// <param name="IdVentasItems">ID del item de venta a modificar.</param>
        /// <param name="Idventa">ID de la nueva venta asociada.</param>
        /// <param name="IdProducto">ID del nuevo producto asociado.</param>
        /// <param name="Cantidad">Nueva cantidad del producto vendido.</param>
        /// <returns>Devuelve true si el item de venta fue modificado exitosamente, de lo contrario false.</returns>
        public bool ModificarVentasItems(int IdVentasItems, int Idventa, int IdProducto, float Cantidad)
        {
            VentasItems VentasIt = new VentasItems();
            VentasIt.Id_VenItem1 = IdVentasItems;
            VentasIt.Id_Venta_VenItem1 = Idventa;
            VentasIt.Id_Producto_VenItem1 = IdProducto;
            VentasIt.Cantidad_VenItem1 = Cantidad;

            DatosVentasItems Dato = new DatosVentasItems();
            bool FilasAfectadas = Dato.EditarVentasItems(VentasIt);
            return FilasAfectadas;
        }
    }
}

