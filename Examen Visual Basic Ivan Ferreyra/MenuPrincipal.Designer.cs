
namespace Examen_Visual_Basic_Ivan_Ferreyra
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubMenuPunto4 = new System.Windows.Forms.Panel();
            this.BtnBuscadorVenta = new System.Windows.Forms.Button();
            this.SubMenuPunto3 = new System.Windows.Forms.Panel();
            this.BtnModificacionVentas = new System.Windows.Forms.Button();
            this.BtnBajaVentas = new System.Windows.Forms.Button();
            this.BtnAltaVentas = new System.Windows.Forms.Button();
            this.SubMenuPunto1 = new System.Windows.Forms.Panel();
            this.BtnModificacionProductos = new System.Windows.Forms.Button();
            this.BtnBajaProductos = new System.Windows.Forms.Button();
            this.BtnAltaProductos = new System.Windows.Forms.Button();
            this.BtnModificacionClientes = new System.Windows.Forms.Button();
            this.BtnBajaClientes = new System.Windows.Forms.Button();
            this.BtnAltaClientes = new System.Windows.Forms.Button();
            this.SubMenuPunto2 = new System.Windows.Forms.Panel();
            this.BtnBuscadorProductos = new System.Windows.Forms.Button();
            this.BtnBuscadorClientes = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SubMenuPunto4.SuspendLayout();
            this.SubMenuPunto3.SuspendLayout();
            this.SubMenuPunto1.SuspendLayout();
            this.SubMenuPunto2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(58)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.SubMenuPunto4);
            this.panel1.Controls.Add(this.SubMenuPunto3);
            this.panel1.Controls.Add(this.SubMenuPunto1);
            this.panel1.Controls.Add(this.SubMenuPunto2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 581);
            this.panel1.TabIndex = 2;
            // 
            // SubMenuPunto4
            // 
            this.SubMenuPunto4.Controls.Add(this.BtnBuscadorVenta);
            this.SubMenuPunto4.Location = new System.Drawing.Point(0, 409);
            this.SubMenuPunto4.Name = "SubMenuPunto4";
            this.SubMenuPunto4.Size = new System.Drawing.Size(200, 24);
            this.SubMenuPunto4.TabIndex = 2;
            // 
            // BtnBuscadorVenta
            // 
            this.BtnBuscadorVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuscadorVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBuscadorVenta.Location = new System.Drawing.Point(0, 0);
            this.BtnBuscadorVenta.Name = "BtnBuscadorVenta";
            this.BtnBuscadorVenta.Size = new System.Drawing.Size(200, 23);
            this.BtnBuscadorVenta.TabIndex = 0;
            this.BtnBuscadorVenta.Text = "Buscador Venta";
            this.BtnBuscadorVenta.UseVisualStyleBackColor = true;
            this.BtnBuscadorVenta.Click += new System.EventHandler(this.BtnBuscadorVenta_Click);
            // 
            // SubMenuPunto3
            // 
            this.SubMenuPunto3.Controls.Add(this.BtnModificacionVentas);
            this.SubMenuPunto3.Controls.Add(this.BtnBajaVentas);
            this.SubMenuPunto3.Controls.Add(this.BtnAltaVentas);
            this.SubMenuPunto3.Location = new System.Drawing.Point(0, 340);
            this.SubMenuPunto3.Name = "SubMenuPunto3";
            this.SubMenuPunto3.Size = new System.Drawing.Size(200, 71);
            this.SubMenuPunto3.TabIndex = 2;
            // 
            // BtnModificacionVentas
            // 
            this.BtnModificacionVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnModificacionVentas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnModificacionVentas.Location = new System.Drawing.Point(0, 46);
            this.BtnModificacionVentas.Name = "BtnModificacionVentas";
            this.BtnModificacionVentas.Size = new System.Drawing.Size(200, 23);
            this.BtnModificacionVentas.TabIndex = 2;
            this.BtnModificacionVentas.Text = "Modificacion Ventas";
            this.BtnModificacionVentas.UseVisualStyleBackColor = true;
            this.BtnModificacionVentas.Click += new System.EventHandler(this.BtnModificacionVentas_Click);
            // 
            // BtnBajaVentas
            // 
            this.BtnBajaVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBajaVentas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBajaVentas.Location = new System.Drawing.Point(0, 23);
            this.BtnBajaVentas.Name = "BtnBajaVentas";
            this.BtnBajaVentas.Size = new System.Drawing.Size(200, 23);
            this.BtnBajaVentas.TabIndex = 1;
            this.BtnBajaVentas.Text = "Baja Ventas";
            this.BtnBajaVentas.UseVisualStyleBackColor = true;
            this.BtnBajaVentas.Click += new System.EventHandler(this.BtnBajaVentas_Click);
            // 
            // BtnAltaVentas
            // 
            this.BtnAltaVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAltaVentas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAltaVentas.Location = new System.Drawing.Point(0, 0);
            this.BtnAltaVentas.Name = "BtnAltaVentas";
            this.BtnAltaVentas.Size = new System.Drawing.Size(200, 23);
            this.BtnAltaVentas.TabIndex = 0;
            this.BtnAltaVentas.Text = "Alta Ventas";
            this.BtnAltaVentas.UseVisualStyleBackColor = true;
            this.BtnAltaVentas.Click += new System.EventHandler(this.BtnAltaVentas_Click);
            // 
            // SubMenuPunto1
            // 
            this.SubMenuPunto1.Controls.Add(this.BtnModificacionProductos);
            this.SubMenuPunto1.Controls.Add(this.BtnBajaProductos);
            this.SubMenuPunto1.Controls.Add(this.BtnAltaProductos);
            this.SubMenuPunto1.Controls.Add(this.BtnModificacionClientes);
            this.SubMenuPunto1.Controls.Add(this.BtnBajaClientes);
            this.SubMenuPunto1.Controls.Add(this.BtnAltaClientes);
            this.SubMenuPunto1.Location = new System.Drawing.Point(-1, 102);
            this.SubMenuPunto1.Name = "SubMenuPunto1";
            this.SubMenuPunto1.Size = new System.Drawing.Size(201, 139);
            this.SubMenuPunto1.TabIndex = 0;
            // 
            // BtnModificacionProductos
            // 
            this.BtnModificacionProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnModificacionProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnModificacionProductos.Location = new System.Drawing.Point(0, 115);
            this.BtnModificacionProductos.Name = "BtnModificacionProductos";
            this.BtnModificacionProductos.Size = new System.Drawing.Size(201, 23);
            this.BtnModificacionProductos.TabIndex = 4;
            this.BtnModificacionProductos.Text = "Modificacion Productos";
            this.BtnModificacionProductos.UseVisualStyleBackColor = true;
            this.BtnModificacionProductos.Click += new System.EventHandler(this.BtnModificacionProductos_Click);
            // 
            // BtnBajaProductos
            // 
            this.BtnBajaProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBajaProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBajaProductos.Location = new System.Drawing.Point(0, 92);
            this.BtnBajaProductos.Name = "BtnBajaProductos";
            this.BtnBajaProductos.Size = new System.Drawing.Size(201, 23);
            this.BtnBajaProductos.TabIndex = 3;
            this.BtnBajaProductos.Text = "Baja Productos";
            this.BtnBajaProductos.UseVisualStyleBackColor = true;
            this.BtnBajaProductos.Click += new System.EventHandler(this.BtnBajaProductos_Click);
            // 
            // BtnAltaProductos
            // 
            this.BtnAltaProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAltaProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAltaProductos.Location = new System.Drawing.Point(0, 69);
            this.BtnAltaProductos.Name = "BtnAltaProductos";
            this.BtnAltaProductos.Size = new System.Drawing.Size(201, 23);
            this.BtnAltaProductos.TabIndex = 2;
            this.BtnAltaProductos.Text = "Alta Productos";
            this.BtnAltaProductos.UseVisualStyleBackColor = true;
            this.BtnAltaProductos.Click += new System.EventHandler(this.BtnAltaProductos_Click);
            // 
            // BtnModificacionClientes
            // 
            this.BtnModificacionClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnModificacionClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnModificacionClientes.Location = new System.Drawing.Point(0, 46);
            this.BtnModificacionClientes.Name = "BtnModificacionClientes";
            this.BtnModificacionClientes.Size = new System.Drawing.Size(201, 23);
            this.BtnModificacionClientes.TabIndex = 1;
            this.BtnModificacionClientes.Text = "Modificacion Clientes";
            this.BtnModificacionClientes.UseVisualStyleBackColor = true;
            this.BtnModificacionClientes.Click += new System.EventHandler(this.BtnModificacionClientes_Click);
            // 
            // BtnBajaClientes
            // 
            this.BtnBajaClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBajaClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBajaClientes.Location = new System.Drawing.Point(0, 23);
            this.BtnBajaClientes.Name = "BtnBajaClientes";
            this.BtnBajaClientes.Size = new System.Drawing.Size(201, 23);
            this.BtnBajaClientes.TabIndex = 1;
            this.BtnBajaClientes.Text = "Baja Clientes";
            this.BtnBajaClientes.UseVisualStyleBackColor = true;
            this.BtnBajaClientes.Click += new System.EventHandler(this.BtnBajaClientes_Click);
            // 
            // BtnAltaClientes
            // 
            this.BtnAltaClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAltaClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAltaClientes.Location = new System.Drawing.Point(0, 0);
            this.BtnAltaClientes.Name = "BtnAltaClientes";
            this.BtnAltaClientes.Size = new System.Drawing.Size(201, 23);
            this.BtnAltaClientes.TabIndex = 0;
            this.BtnAltaClientes.Text = "Alta Cliente";
            this.BtnAltaClientes.UseVisualStyleBackColor = true;
            this.BtnAltaClientes.Click += new System.EventHandler(this.BtnAltaClientes_Click);
            // 
            // SubMenuPunto2
            // 
            this.SubMenuPunto2.Controls.Add(this.BtnBuscadorProductos);
            this.SubMenuPunto2.Controls.Add(this.BtnBuscadorClientes);
            this.SubMenuPunto2.Location = new System.Drawing.Point(-1, 240);
            this.SubMenuPunto2.Name = "SubMenuPunto2";
            this.SubMenuPunto2.Size = new System.Drawing.Size(201, 48);
            this.SubMenuPunto2.TabIndex = 1;
            // 
            // BtnBuscadorProductos
            // 
            this.BtnBuscadorProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuscadorProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBuscadorProductos.Location = new System.Drawing.Point(0, 23);
            this.BtnBuscadorProductos.Name = "BtnBuscadorProductos";
            this.BtnBuscadorProductos.Size = new System.Drawing.Size(201, 23);
            this.BtnBuscadorProductos.TabIndex = 1;
            this.BtnBuscadorProductos.Text = "Buscador Productos";
            this.BtnBuscadorProductos.UseVisualStyleBackColor = true;
            this.BtnBuscadorProductos.Click += new System.EventHandler(this.BtnBuscadorProductos_Click);
            // 
            // BtnBuscadorClientes
            // 
            this.BtnBuscadorClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuscadorClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBuscadorClientes.Location = new System.Drawing.Point(0, 0);
            this.BtnBuscadorClientes.Name = "BtnBuscadorClientes";
            this.BtnBuscadorClientes.Size = new System.Drawing.Size(201, 23);
            this.BtnBuscadorClientes.TabIndex = 0;
            this.BtnBuscadorClientes.Text = "Buscador Clientes";
            this.BtnBuscadorClientes.UseVisualStyleBackColor = true;
            this.BtnBuscadorClientes.Click += new System.EventHandler(this.BtnBuscadorClientes_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(982, 581);
            this.PanelContenedor.TabIndex = 3;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 581);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.panel1.ResumeLayout(false);
            this.SubMenuPunto4.ResumeLayout(false);
            this.SubMenuPunto3.ResumeLayout(false);
            this.SubMenuPunto1.ResumeLayout(false);
            this.SubMenuPunto2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SubMenuPunto4;
        private System.Windows.Forms.Button BtnBuscadorVenta;
        private System.Windows.Forms.Panel SubMenuPunto3;
        private System.Windows.Forms.Button BtnModificacionVentas;
        private System.Windows.Forms.Button BtnBajaVentas;
        private System.Windows.Forms.Button BtnAltaVentas;
        private System.Windows.Forms.Panel SubMenuPunto1;
        private System.Windows.Forms.Button BtnModificacionProductos;
        private System.Windows.Forms.Button BtnBajaProductos;
        private System.Windows.Forms.Button BtnAltaProductos;
        private System.Windows.Forms.Button BtnModificacionClientes;
        private System.Windows.Forms.Button BtnBajaClientes;
        private System.Windows.Forms.Button BtnAltaClientes;
        private System.Windows.Forms.Panel SubMenuPunto2;
        private System.Windows.Forms.Button BtnBuscadorProductos;
        private System.Windows.Forms.Button BtnBuscadorClientes;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}

