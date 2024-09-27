using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto1
{
    /// <summary>
    /// Clase que representa el formulario para agregar nuevos productos.
    /// </summary>
    public partial class AltaProductos : Form
    {
        private NegocioProductos Producto = new NegocioProductos();

        /// <summary>
        /// Constructor de la clase AltaProductos.
        /// Inicializa los componentes y carga la lista de productos en el DataGridView.
        /// </summary>
        public AltaProductos()
        {
            InitializeComponent();
            CargarProductos(GvProdcutos);
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
        /// Evento que se dispara al hacer clic en el botón para cargar un nuevo producto.
        /// Valida los campos y agrega el producto a la base de datos.
        /// </summary>
        /// <param name="sender">El objeto que envió el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbNombre.Text) ||
                    string.IsNullOrWhiteSpace(TbPrecio.Text) ||
                    string.IsNullOrWhiteSpace(TbCategoria.Text))
                {
                    LblError.Text = "Complete todos los campos, por favor.";
                    return;
                }
                else
                {
                    // Validar que el precio sea un número
                    float precio;
                    if (!float.TryParse(TbPrecio.Text, out precio))
                    {
                        LblError.Text = "El precio debe ser un número válido.";
                        return;
                    }
                    else
                    {
                        if (Producto.AgregarProductos(TbNombre.Text, precio, TbCategoria.Text))
                        {
                            LblError.Text = "El producto agregado correctamente.";
                            return;
                        }
                        else
                        {
                            LblError.Text = "El producto ya está en la base de datos.";
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al agregar producto: {ex.Message}";
            }
            finally
            {
                CargarProductos(GvProdcutos);
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Limpia los campos de texto del formulario.
        /// </summary>
        public void LimpiarCampos()
        {
            TbNombre.Text = "";
            TbPrecio.Text = "";
            TbCategoria.Text = "";
        }
    }
}
