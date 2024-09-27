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
{
    /// <summary>
    /// Ventana para buscar y filtrar clientes en el sistema.
    /// </summary>
    public partial class BuscadorClientes : Form
    {
        /// <summary>
        /// Constructor de la clase BuscadorClientes.
        /// Inicializa los componentes y carga los clientes en el DataGridView.
        /// </summary>
        public BuscadorClientes()
        {
            InitializeComponent();
            CargarClientes(GvClientes);
        }

        NegocioClientes Clientes = new NegocioClientes();

        /// <summary>
        /// Carga los clientes desde la base de datos en el DataGridView especificado.
        /// </summary>
        /// <param name="aux">El DataGridView donde se mostrarán los clientes.</param>
        private void CargarClientes(DataGridView aux)
        {
            DataTable TablaClientes = Clientes.ObtenerClientes();
            aux.DataSource = TablaClientes;
        }

        /// <summary>
        /// Aplica los filtros a la lista de clientes en el DataGridView basado en los textos de los filtros.
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
                filtros.Add(String.Format("Cliente LIKE '%{0}%'", TbNombre.Text));
            }

            // Filtro de teléfono si el texto no está vacío
            if (!string.IsNullOrEmpty(TbTelefono.Text))
            {
                filtros.Add(String.Format("Telefono LIKE '%{0}%'", TbTelefono.Text));
            }

            // Filtro de correo si el texto no está vacío
            if (!string.IsNullOrEmpty(TbCorreo.Text))
            {
                filtros.Add(String.Format("Correo LIKE '%{0}%'", TbCorreo.Text));
            }

            // Combina todos los filtros usando el operador AND si hay filtros disponibles
            string filtroFinal = filtros.Count > 0 ? string.Join(" AND ", filtros) : string.Empty;

            // Aplica el filtro final al DataView
            (GvClientes.DataSource as DataTable).DefaultView.RowFilter = filtroFinal;
        }

        // Eventos TextChanged para aplicar el filtro
        private void LblFiltroID_TextChanged(object sender, EventArgs e)
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
        /// Borra el filtro aplicado en el campo Teléfono.
        /// </summary>
        private void BtnBorrarFiltroTelefono_Click(object sender, EventArgs e)
        {
            TbTelefono.Text = "";
        }

        /// <summary>
        /// Borra el filtro aplicado en el campo Correo.
        /// </summary>
        private void BtnBorrarFiltroCorreo_Click(object sender, EventArgs e)
        {
            TbCorreo.Text = "";
        }

        /// <summary>
        /// Selecciona el cliente actual en el DataGridView y muestra sus detalles.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GvClientes.CurrentCell != null)
                {
                    String Id = GvClientes.CurrentRow.Cells[0].Value.ToString();
                    String Cliente = GvClientes.CurrentRow.Cells[1].Value.ToString();
                    String Telefono = GvClientes.CurrentRow.Cells[2].Value.ToString();
                    String Correo = GvClientes.CurrentRow.Cells[3].Value.ToString();

                    LblSeleccionId.Text = "Id = " + Id;
                    LblSeleccionCliente.Text = "Cliente = " + Cliente;
                    LblSeleccionTelefono.Text = "Teléfono = " + Telefono;
                    LblSeleccionCorreo.Text = "Correo = " + Correo;
                }
                else
                {
                    LblError.Text = "No se seleccionó ningún cliente.";
                    return;
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al seleccionar cliente: {ex.Message}";
            }
        }
    }
}
