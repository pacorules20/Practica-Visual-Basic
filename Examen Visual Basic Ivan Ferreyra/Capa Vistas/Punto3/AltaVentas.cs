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
    /// Formulario para registrar nuevas ventas en el sistema.
    /// </summary>
    public partial class AltaVentas : Form
    {
        /// <summary>
        /// Constructor de la clase AltaVentas.
        /// Inicializa los componentes y carga las ventas existentes en el DataGridView.
        /// </summary>
        public AltaVentas()
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
        /// Evento que se ejecuta al hacer clic en el botón para cargar una nueva venta.
        /// </summary>
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbVenta.Text) ||
                       string.IsNullOrWhiteSpace(TbProducto.Text) ||
                       string.IsNullOrWhiteSpace(TbCantidad.Text))
                {
                    LblError.Text = "Complete todos los campos, por favor.";
                    return;
                }
                else
                {
                    // Validar que el precio sea un número
                    float precio;
                    if (!float.TryParse(TbCantidad.Text, out precio))
                    {
                        LblError.Text = "El precio debe ser un número válido.";
                        return;
                    }
                    else
                    {
                        if (Venta.AgregarVentasItems(Convert.ToInt32(TbVenta.Text), Convert.ToInt32(TbProducto.Text), precio))
                        {
                            LblError.Text = "el item de la venta creado correctamente.";
                            return;
                        }
                        else
                        {
                            LblError.Text = "el item de la venta ya se encuentra en esa venta de la  base de datos";
                            return;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al agregar Venta: {ex.Message}";
            }
            finally
            {
                CargarVentas(GvVentas);
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Limpia los campos de entrada en el formulario.
        /// </summary>
        public void LimpiarCampos()
        {
            TbVenta.Text = "";
            TbProducto.Text = "";
            TbCantidad.Text = "";
        }
    }
}