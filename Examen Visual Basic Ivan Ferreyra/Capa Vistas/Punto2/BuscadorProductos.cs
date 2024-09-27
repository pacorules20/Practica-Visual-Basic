using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto2

{    /// <summary>
     /// Ventana para buscar y filtrar productos en el sistema.
     /// </summary>
    public partial class BuscadorProductos : Form
    {
        /// <summary>
        /// Constructor de la clase BuscadorProductos.
        /// Inicializa los componentes y carga los productos en el DataGridView.
        /// </summary>
        public BuscadorProductos()
        {
            InitializeComponent();
            CargarProductos(GvProductos);
        }

        NegocioProductos Producto = new NegocioProductos();

        /// <summary>
        /// Carga los productos desde la base de datos en el DataGridView especificado.
        /// </summary>
        /// <param name="aux">El DataGridView donde se mostrarán los productos.</param>
        private void CargarProductos(DataGridView aux)
        {
            DataTable TablaProductos = Producto.ObtenerProductos();
            aux.DataSource = TablaProductos;

        }

        /// <summary>
        /// Aplica los filtros a la lista de productos en el DataGridView basado en los textos de los filtros.
        /// </summary>
        private void AplicarFiltros()
        {
            // Crea una lista para almacenar las condiciones de filtro
            List<string> filtros = new List<string>();

            // Filtro de ID si el texto no está vacío
            if (!string.IsNullOrEmpty(TbFiltroID.Text))
            {
                filtros.Add(String.Format("Convert(ID, 'System.String') LIKE '{0}%'", TbFiltroID.Text));
            }

            // Filtro de nombre si el texto no está vacío
            if (!string.IsNullOrEmpty(TbNombre.Text))
            {
                filtros.Add(String.Format("Nombre LIKE '{0}%'", TbNombre.Text));
            }

            // Filtro de precio si el texto no está vacío
            if (!string.IsNullOrEmpty(TbPrecio.Text))
            {
                filtros.Add(String.Format("Convert(Precio, 'System.String') LIKE '{0}%'", TbPrecio.Text));
            }

            // Filtro de categoria si el texto no está vacío
            if (!string.IsNullOrEmpty(TbCategoria.Text))
            {
                filtros.Add(String.Format("Categoria LIKE '{0}%'", TbCategoria.Text));
            }

            // Combina todos los filtros usando el operador AND si hay filtros disponibles
            string filtroFinal = filtros.Count > 0 ? string.Join(" AND ", filtros) : string.Empty;

            // Aplica el filtro final al DataView
            (GvProductos.DataSource as DataTable).DefaultView.RowFilter = filtroFinal;
        }

        private void TbFiltroID_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void TbNombre_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void TbTelefono_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void TbCorreo_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        /// <summary>
        /// Selecciona el producto actual en el DataGridView y muestra sus detalles.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GvProductos.CurrentCell != null)
                {
                    String Id = GvProductos.CurrentRow.Cells[0].Value.ToString();
                    String Producto = GvProductos.CurrentRow.Cells[1].Value.ToString();
                    String Precio = GvProductos.CurrentRow.Cells[2].Value.ToString();
                    String Categoria = GvProductos.CurrentRow.Cells[3].Value.ToString();

                    LblSeleccionId.Text = "Id = " + Id;
                    LblSeleccionProducto.Text = "Producto = " + Producto;
                    LblSeleccionPrecio.Text = "Precio = " + Precio;
                    LblSeleccionCategoria.Text = "Categoria = " + Categoria;
                }
                else
                {
                    LblError.Text = "no se selecciono ningun producto";
                    return;
                }

            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al agregar: {ex.Message}";
            }
        }

        /// <summary>
        /// Borra el filtro aplicado en el campo ID.
        /// </summary>
        private void BtnBorrarFiltroID_Click(object sender, EventArgs e)
        {
            TbFiltroID.Text = "";
        }

        /// <summary>
        /// Borra el filtro aplicado en el campo Nombre.
        /// </summary>
        private void BtnBorrarFiltroNombre_Click(object sender, EventArgs e)
        {
            TbNombre.Text = "";
        }

        /// <summary>
        /// Borra el filtro aplicado en el campo Precio.
        /// </summary>
        private void BtnBorrarFiltroPrecio_Click(object sender, EventArgs e)
        {
            TbPrecio.Text = "";
        }

        /// <summary>
        /// Borra el filtro aplicado en el campo Categoría.
        /// </summary>
        private void BtnBorrarFiltroCategoria_Click(object sender, EventArgs e)
        {
            TbCategoria.Text = "";
        }
    }
}
