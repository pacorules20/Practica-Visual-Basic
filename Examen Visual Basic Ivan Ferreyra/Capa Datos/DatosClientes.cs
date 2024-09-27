using Examen_Visual_Basic_Ivan_Ferreyra.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Datos
{
    /// <summary>
    /// La clase DatosClientes maneja las operaciones relacionadas con la tabla de clientes en la base de datos.
    /// Proporciona métodos para agregar, eliminar, editar y verificar la existencia de clientes.
    /// </summary>
    class DatosClientes
    {
        // Instancia de la clase Conexiones para manejar la conexión a la base de datos.
        Conexiones conexion = new Conexiones();

        /// <summary>
        /// Verifica si un cliente ya existe en la base de datos con el mismo nombre, correo y teléfono.
        /// </summary>
        /// <param name="Cliente">El objeto Clientes que contiene los datos del cliente a verificar.</param>
        /// <returns>Devuelve true si el cliente existe, de lo contrario devuelve false.</returns>
        public Boolean ExisteCliente(Clientes Cliente)
        {
            String consulta = "SELECT * FROM clientes WHERE Cliente = '" + Cliente.Cliente_Cli1 +
                              "' AND Correo ='" + Cliente.Correo_Cli1 +
                              "' AND Telefono ='" + Cliente.Telefono_Cli1 + "'";
            return conexion.Existe(consulta);
        }

        /// <summary>
        /// Obtiene todos los clientes de la tabla 'clientes' en la base de datos.
        /// </summary>
        /// <returns>Devuelve un DataTable que contiene los datos de todos los clientes.</returns>
        public DataTable ObtenerTablaClientes()
        {
            DataTable Tabla = conexion.ObtenerTabla("clientes", "SELECT * FROM clientes");
            return Tabla;
        }

        /// <summary>
        /// Agrega un nuevo cliente a la base de datos.
        /// </summary>
        /// <param name="cliente">El objeto Clientes que contiene los datos del cliente a agregar.</param>
        /// <returns>Devuelve true si el cliente se agregó correctamente, de lo contrario devuelve false.</returns>
        public bool AgregarCliente(Clientes cliente)
        {
            string consultaInsert = "INSERT INTO clientes (Cliente, Correo, Telefono) " +
                                    "VALUES ('" + cliente.Cliente_Cli1 + "', '" + cliente.Correo_Cli1 + "', '" + cliente.Telefono_Cli1 + "')";
            return conexion.EjecutarConsulta(consultaInsert);
        }

        /// <summary>
        /// Verifica si existe un cliente con un ID específico.
        /// </summary>
        /// <param name="idCliente">El ID del cliente a verificar.</param>
        /// <returns>Devuelve true si existe un cliente con ese ID, de lo contrario devuelve false.</returns>
        public Boolean ExisteClientePorID(int idCliente)
        {
            String consulta = "SELECT * FROM clientes WHERE ID = " + idCliente;
            return conexion.Existe(consulta);
        }

        /// <summary>
        /// Elimina un cliente de la base de datos según su ID.
        /// </summary>
        /// <param name="idCliente">El ID del cliente a eliminar.</param>
        /// <returns>Devuelve true si el cliente se eliminó correctamente, de lo contrario devuelve false.</returns>
        public bool EliminarCliente(int idCliente)
        {
            string consultaDelete = "DELETE FROM clientes WHERE ID = " + idCliente;
            return conexion.EjecutarConsulta(consultaDelete);
        }

        /// <summary>
        /// Edita los datos de un cliente existente en la base de datos.
        /// </summary>
        /// <param name="cliente">El objeto Clientes que contiene los nuevos datos del cliente.</param>
        /// <returns>Devuelve true si los datos del cliente se actualizaron correctamente, de lo contrario devuelve false.</returns>
        public bool EditarCliente(Clientes cliente)
        {
            string consultaUpdate = "UPDATE clientes SET Cliente = '" + cliente.Cliente_Cli1 +
                                    "', Correo = '" + cliente.Correo_Cli1 +
                                    "', Telefono = '" + cliente.Telefono_Cli1 +
                                    "' WHERE ID = " + cliente.Id_Cli1;
            return conexion.EjecutarConsulta(consultaUpdate);
        }
    }
}

