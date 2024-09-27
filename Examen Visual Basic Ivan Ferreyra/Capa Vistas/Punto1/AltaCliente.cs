using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto1
{
    /// <summary>
    /// Clase que representa el formulario para agregar nuevos clientes.
    /// </summary>
    public partial class AltaCliente : Form
    {
        private NegocioClientes Clientes = new NegocioClientes();

        /// <summary>
        /// Constructor de la clase AltaCliente.
        /// Inicializa los componentes y carga la lista de clientes en el DataGridView.
        /// </summary>
        public AltaCliente()
        {
            InitializeComponent();
            CargarClientes(GvClientes);
        }

        /// <summary>
        /// Carga la lista de clientes en el DataGridView proporcionado.
        /// </summary>
        /// <param name="aux">El DataGridView donde se mostrarán los clientes.</param>
        private void CargarClientes(DataGridView aux)
        {
            DataTable TablaClientes = Clientes.ObtenerClientes();
            aux.DataSource = TablaClientes;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón para cargar un nuevo cliente.
        /// Valida los campos y agrega el cliente a la base de datos.
        /// </summary>
        /// <param name="sender">El objeto que envió el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbClientes.Text) ||
                    string.IsNullOrWhiteSpace(TbCorreo.Text) ||
                    string.IsNullOrWhiteSpace(TbTelefono.Text))
                {
                    LblError.Text = "Complete todos los campos, por favor.";
                    return;
                }
                else
                {
                    if (Clientes.AgregarCliente(TbClientes.Text, TbCorreo.Text, TbTelefono.Text))
                    {
                        LblError.Text = "Cliente creado correctamente.";
                        return;
                    }
                    else
                    {
                        LblError.Text = "El cliente ya se encuentra en la base de datos";
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                LblError.Text = $"Error al agregar cliente: {ex.Message}";
            }
            finally
            {
                CargarClientes(GvClientes);
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Limpia los campos de texto del formulario.
        /// </summary>
        public void LimpiarCampos()
        {
            TbClientes.Text = "";
            TbCorreo.Text = "";
            TbTelefono.Text = "";
        }
    }
}
