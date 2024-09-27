using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto3
{
    /// <summary>
    /// Formulario para modificar las ventas en el sistema.
    /// </summary>
    public partial class ModificacionVentas : Form
    {
        /// <summary>
        /// Instancia de la clase de negocio para manejar las ventas.
        /// </summary>
        private NegocioVentasItems Venta = new NegocioVentasItems();

        /// <summary>
        /// Constructor de la clase ModificacionVentas.
        /// Inicializa los componentes y carga las ventas existentes en el DataGridView.
        /// </summary>
        public ModificacionVentas()
        {
            InitializeComponent();
            CargarVentas(GvVentas);
        }

        /// <summary>
        /// Carga las ventas desde la base de datos en el DataGridView especificado.
        /// </summary>
        /// <param name="aux">El DataGridView donde se mostrarán las ventas.</param>
        private void CargarVentas(DataGridView aux)
        {
            DataTable TablaVentas = Venta.ObtenerVentasItems();
            aux.DataSource = TablaVentas;
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón para modificar una venta.
        /// Verifica que todos los campos estén completos y que la cantidad sea un número válido.
        /// Luego llama al método de negocio para modificar la venta.
        /// </summary>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que todos los campos estén completos
                if (TbIdVenta.Text == "" || TbIdProducto.Text == "" || TbCantidad.Text == "")
                {
                    LblError.Text = "Complete todos los campos, por favor.";
                    return;
                }
                else
                {
                    // Intentar convertir la cantidad a un número flotante
                    float Cantidad;
                    if (!float.TryParse(TbCantidad.Text, out Cantidad))
                    {
                        LblError.Text = "La Cantidad debe ser un número válido.";
                        return;
                    }
                    else
                    {
                        // Obtener los IDs de la venta y el producto de la fila seleccionada
                        int ID = Convert.ToInt32(GvVentas.CurrentRow.Cells[0].Value);
          

                        // Llamar al método para modificar la venta y mostrar el resultado
                        if (Venta.ModificarVentasItems(ID, Convert.ToInt32(TbIdVenta.Text), Convert.ToInt32(TbIdProducto.Text), Cantidad))
                        {
                            LblError.Text = "El item de la venta se ha modificado correctamente.";
                            return;
                        }
                        else
                        {
                            LblError.Text = "El item de la venta  ya se encuentra en la base de datos.";
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al modificar la venta: {ex.Message}";
            }
            finally
            {
                // Recargar las ventas en el DataGridView y limpiar los campos
                CargarVentas(GvVentas);
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en una celda del DataGridView.
        /// Llena los campos de texto con los valores de la fila seleccionada.
        /// </summary>
        private void GvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbIdVenta.Text = GvVentas.CurrentRow.Cells[1].Value.ToString();
            TbIdProducto.Text = GvVentas.CurrentRow.Cells[2].Value.ToString();
            TbCantidad.Text = GvVentas.CurrentRow.Cells[4].Value.ToString();
        }

        /// <summary>
        /// Limpia los campos de entrada en el formulario.
        /// </summary>
        public void LimpiarCampos()
        {
            TbIdVenta.Text = "";
            TbIdProducto.Text = "";
            TbCantidad.Text = "";
        }
    }
}
