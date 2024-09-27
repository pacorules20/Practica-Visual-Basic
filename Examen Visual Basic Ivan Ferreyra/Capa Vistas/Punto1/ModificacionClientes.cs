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
    /// Ventana para la modificación de clientes en el sistema.
    /// </summary>
    public partial class ModificacionClientes : Form
    {
        /// <summary>
        /// Constructor de la clase ModificacionClientes.
        /// Inicializa los componentes y carga los clientes en el DataGridView.
        /// </summary>
        public ModificacionClientes()
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
        /// Limpia los campos de texto utilizados para la entrada de datos del cliente.
        /// </summary>
        public void LimpiarCampos()
        {
            TbClientes.Text = "";
            TbCorreo.Text = "";
            TbTelefono.Text = "";
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de modificar.
        /// Modifica los datos del cliente seleccionado en el DataGridView.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            NegocioClientes Cliente = new NegocioClientes();
            try
            {
                if (TbClientes.Text == "" || TbTelefono.Text == "" || TbCorreo.Text == "")
                {
                    LblError.Text = "Complete todos los campos, por favor.";
                    return;
                }
                else
                {
                    int IdCliente = Convert.ToInt32(GvClientes.CurrentRow.Cells[0].Value);

                    if (Cliente.ModificarCliente(IdCliente, TbClientes.Text,TbCorreo.Text, TbTelefono.Text))
                    {
                        LblError.Text = "Cliente modificado correctamente.";
                        return;
                    }
                    else
                    {
                        LblError.Text = "El cliente ya se encuentra en la base de datos.";
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al modificar cliente: {ex.Message}";
            }
            finally
            {
                CargarClientes(GvClientes);
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en una celda del DataGridView.
        /// Rellena los campos de texto con la información del cliente seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void GvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbClientes.Text = GvClientes.CurrentRow.Cells[1].Value.ToString();
            TbTelefono.Text = GvClientes.CurrentRow.Cells[2].Value.ToString();
            TbCorreo.Text = GvClientes.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
