using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto1
{
    /// <summary>
    /// Clase que representa el formulario para eliminar clientes de la base de datos.
    /// </summary>
    public partial class BajaClientes : Form
    {
        private NegocioClientes Clientes = new NegocioClientes();

        /// <summary>
        /// Constructor de la clase BajaClientes.
        /// Inicializa los componentes y carga la lista de clientes en el DataGridView.
        /// </summary>
        public BajaClientes()
        {
            InitializeComponent();
            CargarClientes(GvClientes);
        }

        /// <summary>
        /// Carga la lista de clientes en el DataGridView proporcionado.
        /// </summary>
        /// <param name="aux">El DataGridView donde se mostrarán los clientes.</param>
        private void CargarClientes(DataGridView aux)
        {
            DataTable TablaClientes = Clientes.ObtenerClientes();
            aux.DataSource = TablaClientes;
        }

        /// <summary>
        /// Limpia los campos de texto del formulario.
        /// </summary>
        public void LimpiarCampos()
        {
            Tb_Id.Text = "";
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón para eliminar un cliente seleccionado del DataGridView.
        /// </summary>
        /// <param name="sender">El objeto que envió el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnEliminarPorSeleccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (GvClientes.CurrentCell != null &&
                    Clientes.BorrarCliente(Convert.ToInt32(GvClientes.CurrentRow.Cells[0].Value)))
                {
                    LblError.Text = "Cliente borrado correctamente.";
                    return;
                }
                else
                {
                    LblError.Text = "No se pudo borrar el cliente. Seleccione una opción válida.";
                    return;
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al eliminar: {ex.Message}";
            }
            finally
            {
                CargarClientes(GvClientes);
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón para eliminar un cliente por ID.
        /// </summary>
        /// <param name="sender">El objeto que envió el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnEliminarPorId_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Tb_Id.Text) &&
                    Clientes.BorrarCliente(Convert.ToInt32(Tb_Id.Text)))
                {
                    LblError.Text = "Cliente borrado correctamente.";
                    return;
                }
                else
                {
                    LblError.Text = "No se pudo borrar el cliente. Seleccione una opción válida.";
                    return;
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al eliminar: {ex.Message}";
            }
            finally
            {
                CargarClientes(GvClientes);
                LimpiarCampos();
            }
        }
    }
}
