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

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto3
{
    /// <summary>
    /// Formulario para eliminar ventas del sistema.
    /// </summary>
    public partial class BajaVentas : Form
    {
        /// <summary>
        /// Constructor de la clase BajaVentas.
        /// Inicializa los componentes y carga las ventas existentes en el DataGridView.
        /// </summary
        public BajaVentas()
        {
            InitializeComponent();
            CargarVentas(GvVentas);
        }

        NegocioVentasItems Venta = new NegocioVentasItems();

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
        /// Evento que se ejecuta al hacer clic en el botón para eliminar la venta seleccionada.
        /// </summary>
        private void BtnEliminarPorSeleccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (GvVentas.CurrentCell != null && Venta.BorrarVentasItems(Convert.ToInt32(GvVentas.CurrentRow.Cells[0].Value)))
                {
                    LblError.Text = "Venta articulo Borrado correctamente";
                }
                else
                {
                    LblError.Text = "Venta articulo no se pudo Borrado, seleccione un opcion valida";
                }

            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al agregar: {ex.Message}";
            }
            finally
            {
                CargarVentas(GvVentas);
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón para eliminar una venta por ID.
        /// </summary>
        private void BtnEliminarPorId_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tb_Id.Text != "" && Venta.BorrarVentasItems(Convert.ToInt32(Tb_Id.Text)))
                {
                    LblError.Text = "Venta articulo Borrado correctamente";
                }
                else
                {
                    LblError.Text = "Venta articulo no se pudo Borrado, seleccione un opcion valida";
                }

            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al agregar: {ex.Message}";
            }
            finally
            {
                CargarVentas(GvVentas);
                LimpiarCampos();
            }
        }

        //Funcion limpiar campos
        public void LimpiarCampos()
        {
            Tb_Id.Text = "";
        }
    }
}
