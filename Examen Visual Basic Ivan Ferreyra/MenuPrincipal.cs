using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto1;
using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto2;
using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto3;
using Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Visual_Basic_Ivan_Ferreyra
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //PUNTO 1
        private void BtnAltaClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new AltaCliente());
        }

        private void BtnAltaProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new AltaProductos());
        }

        private void BtnBajaClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new BajaClientes());
        }

        private void BtnModificacionClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ModificacionClientes());
        }
        private void BtnBajaProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new BajaProductos());
        }

        private void BtnModificacionProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ModificacionProductos());
        }


        //PUNTO 2
        private void BtnBuscadorClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new BuscadorClientes());
        }

        private void BtnBuscadorProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new BuscadorProductos());
        }

        //PUNTO 3
        private void BtnAltaVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new AltaVentas());
        }

        private void BtnBajaVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new BajaVentas());
        }

        private void BtnModificacionVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ModificacionVentas());
        }

        //PUNTO 4
        private void BtnBuscadorVenta_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new BuscadorVenta());
        }

        //Funciones
        private void AbrirFormHijo(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FormEnPantalla = FormHijo as Form;
            FormEnPantalla.TopLevel = false;
            FormEnPantalla.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FormEnPantalla);
            this.PanelContenedor.Tag = FormEnPantalla;
            FormEnPantalla.Show();
        }
    }
}
