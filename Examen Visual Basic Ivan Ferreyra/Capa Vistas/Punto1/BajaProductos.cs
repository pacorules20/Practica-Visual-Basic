using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto1
{
    /// <summary>
    /// Clase que representa el formulario para eliminar productos de la base de datos.
    /// </summary>
    public partial class BajaProductos : Form
    {
        private NegocioProductos Producto = new NegocioProductos();

        /// <summary>
        /// Constructor de la clase BajaProductos.
        /// Inicializa los componentes y carga la lista de productos en el DataGridView.
        /// </summary>
        public BajaProductos()
        {
            InitializeComponent();
            CargarProductos(GvProductos);
        }

        /// <summary>
        /// Carga la lista de productos en el DataGridView proporcionado.
        /// </summary>
        /// <param name="aux">El DataGridView donde se mostrarán los productos.</param>
        private void CargarProductos(DataGridView aux)
        {
            DataTable TablaProductos = Producto.ObtenerProductos();
            aux.DataSource = TablaProductos;
        }

        /// <summary>
        /// Limpia los campos de texto del formulario.
        /// </summary>
        public void LimpiarCampos()
        {
            Tb_Id.Text = "";
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón para eliminar un producto seleccionado del DataGridView.
        /// </summary>
        /// <param name="sender">El objeto que envió el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnEliminarPorSeleccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (GvProductos.CurrentCell != null &&
                    Producto.BorrarProducto(Convert.ToInt32(GvProductos.CurrentRow.Cells[0].Value)))
                {
                    LblError.Text = "Producto borrado correctamente.";
                    return;
                }
                else
                {
                    LblError.Text = "No se pudo borrar el producto. Seleccione una opción válida.";
                    return;
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al eliminar: {ex.Message}";
            }
            finally
            {
                CargarProductos(GvProductos);
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón para eliminar un producto por ID.
        /// </summary>
        /// <param name="sender">El objeto que envió el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnEliminarPorId_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Tb_Id.Text) &&
                    Producto.BorrarProducto(Convert.ToInt32(Tb_Id.Text)))
                {
                    LblError.Text = "Producto borrado correctamente.";
                    return;
                }
                else
                {
                    LblError.Text = "No se pudo borrar el producto. Seleccione una opción válida.";
                    return;
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al eliminar: {ex.Message}";
            }
            finally
            {
                CargarProductos(GvProductos);
                LimpiarCampos();
            }
        }
    }
}
