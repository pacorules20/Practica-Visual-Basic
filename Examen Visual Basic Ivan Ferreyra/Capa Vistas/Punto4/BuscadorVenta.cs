using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto4
{
    /// <summary>
    /// Formulario para buscar ventas en el sistema.
    /// </summary>
    public partial class BuscadorVenta : Form
    {
        /// <summary>
        /// Instancia de la clase de negocio para manejar las ventas.
        /// </summary>
        private NegocioVentas Venta = new NegocioVentas();

        /// <summary>
        /// Constructor de la clase BuscadorVenta.
        /// Inicializa los componentes y carga las ventas existentes en el DataGridView.
        /// </summary>
        public BuscadorVenta()
        {
            InitializeComponent();
            CargarVentas(GvVentas);
            DtpFecha.Value = DateTimePicker.MinimumDateTime; // Establece la fecha mínima en el DateTimePicker
        }

        /// <summary>
        /// Carga las ventas desde la base de datos en el DataGridView especificado.
        /// </summary>
        /// <param name="aux">El DataGridView donde se mostrarán las ventas.</param>
        private void CargarVentas(DataGridView aux)
        {
            DataTable TablaVentas = Venta.ObtenerVentas();
            aux.DataSource = TablaVentas;
        }

        /// <summary>
        /// Aplica los filtros a las ventas basándose en los valores ingresados en los campos de texto y la fecha seleccionada.
        /// </summary>
        private void AplicarFiltros()
        {
            // Lista para almacenar las condiciones de filtro
            List<string> filtros = new List<string>();

            // Filtro de ID si el texto no está vacío
            if (!string.IsNullOrEmpty(TbFiltroID.Text))
            {
                filtros.Add(String.Format("Convert(ID, 'System.String') LIKE '{0}%'", TbFiltroID.Text));
            }

            // Filtro de ID del cliente si el texto no está vacío
            if (!string.IsNullOrEmpty(TbFiltroIdClietne.Text))
            {
                filtros.Add(String.Format("Convert(IDCliente, 'System.String') LIKE '{0}%'", TbFiltroIdClietne.Text));
            }

            // Filtro de fecha si la fecha no es la predeterminada
            if (DtpFecha.Value != DateTimePicker.MinimumDateTime)
            {
                string fechaFormateada = DtpFecha.Value.ToString("dd/M/yyyy"); // Formato completo
                DateTime fechaFinal = DtpFecha.Value.AddDays(1); // Día siguiente
                filtros.Add($"Fecha >= '{fechaFormateada}' AND Fecha < '{fechaFinal:dd/M/yyyy}'");
            }

            // Filtro de total si el texto no está vacío
            if (!string.IsNullOrEmpty(TbFiltroTotal.Text))
            {
                filtros.Add(String.Format("Convert(Total, 'System.String') LIKE '{0}%'", TbFiltroTotal.Text));
            }

            // Combina todos los filtros usando el operador AND si hay filtros disponibles
            string filtroFinal = filtros.Count > 0 ? string.Join(" AND ", filtros) : string.Empty;

            // Aplica el filtro final al DataView
            (GvVentas.DataSource as DataTable).DefaultView.RowFilter = filtroFinal;
        }

        /// <summary>
        /// Evento que se ejecuta al cambiar el texto del campo de filtro de ID.
        /// Aplica los filtros a las ventas.
        /// </summary>
        private void TbFiltroID_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        /// <summary>
        /// Evento que se ejecuta al cambiar el texto del campo de filtro de ID del cliente.
        /// Aplica los filtros a las ventas.
        /// </summary>
        private void TbFiltroIdClietne_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        /// <summary>
        /// Evento que se ejecuta al cambiar el texto del campo de filtro de total.
        /// Aplica los filtros a las ventas.
        /// </summary>
        private void TbFiltroTotal_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón para aplicar filtros.
        /// Aplica los filtros a las ventas.
        /// </summary>
        private void BtnAplicarFiltro_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón para borrar el filtro de ID.
        /// Limpia el campo de texto del filtro de ID.
        /// </summary>
        private void BtnBorrarFiltroID_Click(object sender, EventArgs e)
        {
            TbFiltroID.Text = "";
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón para borrar el filtro de cliente.
        /// Limpia el campo de texto del filtro de cliente.
        /// </summary>
        private void BtnBorrarFiltroCliente_Click(object sender, EventArgs e)
        {
            TbFiltroIdClietne.Text = "";
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón para borrar el filtro de fecha.
        /// Restablece la fecha en el DateTimePicker y aplica filtros.
        /// </summary>
        private void BtnBorrarFiltroFecha_Click(object sender, EventArgs e)
        {
            DtpFecha.Value = DateTimePicker.MinimumDateTime;
            AplicarFiltros();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón para borrar el filtro de total.
        /// Limpia el campo de texto del filtro de total.
        /// </summary>
        private void BtnBorrarFiltroTotal_Click(object sender, EventArgs e)
        {
            TbFiltroTotal.Text = "";
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón para seleccionar una venta.
        /// Muestra los detalles de la venta seleccionada en las etiquetas correspondientes.
        /// </summary>
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GvVentas.CurrentCell != null)
                {
                    String ID = GvVentas.CurrentRow.Cells[0].Value.ToString();
                    String IDCliente = GvVentas.CurrentRow.Cells[1].Value.ToString();
                    String Fecha = Convert.ToDateTime(GvVentas.CurrentRow.Cells[2].Value).ToString("dd/M/yyyy");
                    String Total = GvVentas.CurrentRow.Cells[3].Value.ToString();

                    // Mostrar detalles de la venta seleccionada
                    LblIdSeleccionado.Text = "ID = " + ID;
                    LblClienteIdSeleccionado.Text = "IDCliente = " + IDCliente;
                    LblFechaSeleccionada.Text = "Fecha = " + Fecha;
                    LblTotalSeleccionado.Text = "Total = " + Total;
                }
                else
                {
                    LblError.Text = "No se seleccionó ninguna venta.";
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al seleccionar: {ex.Message}";
            }
        }
    }
}
