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

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto1
{
    /// <summary>
    /// Ventana para la modificación de productos en el sistema.
    /// </summary>
    public partial class ModificacionProductos : Form
    {
        /// <summary>
        /// Constructor de la clase ModificacionProductos.
        /// Inicializa los componentes y carga los productos en el DataGridView.
        /// </summary>
        public ModificacionProductos()
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
        /// Evento que se dispara al hacer clic en el botón de modificar.
        /// Modifica los datos del producto seleccionado en el DataGridView.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbNombre.Text == "" || TbPrecio.Text == "" || TbCategoria.Text == "")
                {
                    LblError.Text = "Complete todos los campos, por favor.";
                    return;
                }
                else
                {
                    float precio;
                    if (!float.TryParse(TbPrecio.Text, out precio))
                    {
                        LblError.Text = "El precio debe ser un número válido.";
                        return;
                    }
                    else
                    {
                        int IdProducto = Convert.ToInt32(GvProductos.CurrentRow.Cells[0].Value);
     

                        if (Producto.ModificarProducto(IdProducto, TbNombre.Text, precio, TbCategoria.Text))
                        {
                            LblError.Text = "El producto modificado correctamente.";
                            return;
                        }
                        else
                        {
                            LblError.Text = "El producto ya se encuentra en la base de datos.";
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al modificar producto: {ex.Message}";
            }
            finally
            {
                CargarProductos(GvProductos);
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en una celda del DataGridView.
        /// Rellena los campos de texto con la información del producto seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void GvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbNombre.Text = GvProductos.CurrentRow.Cells[1].Value.ToString();
            TbPrecio.Text = GvProductos.CurrentRow.Cells[2].Value.ToString();
            TbCategoria.Text = GvProductos.CurrentRow.Cells[3].Value.ToString();
        }

        /// <summary>
        /// Limpia los campos de texto utilizados para la entrada de datos del producto.
        /// </summary>
        public void LimpiarCampos()
        {
            TbNombre.Text = "";
            TbPrecio.Text = "";
            TbCategoria.Text = "";
        }
    }
}
