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
    /// La clase NegocioClientes maneja la lógica de negocio relacionada con los clientes.
    /// Proporciona métodos para agregar, modificar, eliminar y obtener clientes.
    /// </summary>
    class NegocioClientes
    {
        /// <summary>
        /// Obtiene todos los clientes registrados en la base de datos.
        /// </summary>
        /// <returns>Devuelve un DataTable con los datos de todos los clientes.</returns>
        public DataTable ObtenerClientes()
        {
            DatosClientes Dato = new DatosClientes();
            DataTable Tabla;
            return Tabla = Dato.ObtenerTablaClientes();
        }

        /// <summary>
        /// Agrega un nuevo cliente a la base de datos si no existe previamente.
        /// </summary>
        /// <param name="nombreClientes">Nombre del cliente.</param>
        /// <param name="correoCliente">Correo del cliente.</param>
        /// <param name="telefonoCliente">Teléfono del cliente.</param>
        /// <returns>Devuelve true si el cliente fue agregado exitosamente, de lo contrario false.</returns>
        public bool AgregarCliente(string nombreClientes, string correoCliente, string telefonoCliente)
        {
            Clientes Cliente = new Clientes
            {
                Cliente_Cli1 = nombreClientes,
                Telefono_Cli1 = telefonoCliente,
                Correo_Cli1 = correoCliente
            };

            bool CantidadFilas = false;
            DatosClientes Dato = new DatosClientes();
            if (!Dato.ExisteCliente(Cliente))
            {
                CantidadFilas = Dato.AgregarCliente(Cliente);
                return CantidadFilas;
            }
            return CantidadFilas;
        }

        /// <summary>
        /// Elimina un cliente de la base de datos usando su ID si existe.
        /// </summary>
        /// <param name="IdCliente">ID del cliente a eliminar.</param>
        /// <returns>Devuelve true si el cliente fue eliminado exitosamente, de lo contrario false.</returns>
        public bool BorrarCliente(int IdCliente)
        {
            bool CantidadFilas = false;
            DatosClientes Dato = new DatosClientes();
            if (Dato.ExisteClientePorID(IdCliente))
            {
                CantidadFilas = Dato.EliminarCliente(IdCliente);
                return CantidadFilas;
            }
            return CantidadFilas;
        }

        /// <summary>
        /// Modifica los datos de un cliente existente.
        /// </summary>
        /// <param name="IdCliente">ID del cliente a modificar.</param>
        /// <param name="nombreClientes">Nuevo nombre del cliente.</param>
        /// <param name="correoCliente">Nuevo correo del cliente.</param>
        /// <param name="telefonoCliente">Nuevo teléfono del cliente.</param>
        /// <returns>Devuelve true si el cliente fue modificado exitosamente, de lo contrario false.</returns>
        public bool ModificarCliente(int IdCliente, string nombreClientes, string correoCliente, string telefonoCliente)
        {
            Clientes Cliente = new Clientes
            {
                Id_Cli1 = IdCliente,
                Cliente_Cli1 = nombreClientes,
                Telefono_Cli1 = telefonoCliente,
                Correo_Cli1 = correoCliente
            };

            DatosClientes Dato = new DatosClientes();
            bool FilasAfectadas = Dato.EditarCliente(Cliente);
            return FilasAfectadas;
        }
    }
}
