
namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto2
{
    partial class BuscadorProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblSeleccionCategoria = new System.Windows.Forms.Label();
            this.LblSeleccionPrecio = new System.Windows.Forms.Label();
            this.LblSeleccionProducto = new System.Windows.Forms.Label();
            this.LblSeleccionId = new System.Windows.Forms.Label();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroCategoria = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroPrecio = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroNombre = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroID = new System.Windows.Forms.Button();
            this.TbFiltroID = new System.Windows.Forms.TextBox();
            this.LblClienteId = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.TbCategoria = new System.Windows.Forms.TextBox();
            this.TbPrecio = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.GvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSeleccionCategoria
            // 
            this.LblSeleccionCategoria.AutoSize = true;
            this.LblSeleccionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeleccionCategoria.Location = new System.Drawing.Point(572, 495);
            this.LblSeleccionCategoria.Name = "LblSeleccionCategoria";
            this.LblSeleccionCategoria.Size = new System.Drawing.Size(64, 18);
            this.LblSeleccionCategoria.TabIndex = 112;
            this.LblSeleccionCategoria.Text = "              ";
            // 
            // LblSeleccionPrecio
            // 
            this.LblSeleccionPrecio.AutoSize = true;
            this.LblSeleccionPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeleccionPrecio.Location = new System.Drawing.Point(571, 474);
            this.LblSeleccionPrecio.Name = "LblSeleccionPrecio";
            this.LblSeleccionPrecio.Size = new System.Drawing.Size(64, 18);
            this.LblSeleccionPrecio.TabIndex = 111;
            this.LblSeleccionPrecio.Text = "              ";
            // 
            // LblSeleccionProducto
            // 
            this.LblSeleccionProducto.AutoSize = true;
            this.LblSeleccionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeleccionProducto.Location = new System.Drawing.Point(571, 454);
            this.LblSeleccionProducto.Name = "LblSeleccionProducto";
            this.LblSeleccionProducto.Size = new System.Drawing.Size(64, 18);
            this.LblSeleccionProducto.TabIndex = 110;
            this.LblSeleccionProducto.Text = "              ";
            // 
            // LblSeleccionId
            // 
            this.LblSeleccionId.AutoSize = true;
            this.LblSeleccionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeleccionId.Location = new System.Drawing.Point(572, 435);
            this.LblSeleccionId.Name = "LblSeleccionId";
            this.LblSeleccionId.Size = new System.Drawing.Size(64, 18);
            this.LblSeleccionId.TabIndex = 109;
            this.LblSeleccionId.Text = "              ";
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Location = new System.Drawing.Point(626, 373);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(258, 46);
            this.BtnSeleccionar.TabIndex = 108;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnBorrarFiltroCategoria
            // 
            this.BtnBorrarFiltroCategoria.Location = new System.Drawing.Point(826, 301);
            this.BtnBorrarFiltroCategoria.Name = "BtnBorrarFiltroCategoria";
            this.BtnBorrarFiltroCategoria.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroCategoria.TabIndex = 107;
            this.BtnBorrarFiltroCategoria.Text = "Borrar Filtro";
            this.BtnBorrarFiltroCategoria.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroCategoria.Click += new System.EventHandler(this.BtnBorrarFiltroCategoria_Click);
            // 
            // BtnBorrarFiltroPrecio
            // 
            this.BtnBorrarFiltroPrecio.Location = new System.Drawing.Point(826, 239);
            this.BtnBorrarFiltroPrecio.Name = "BtnBorrarFiltroPrecio";
            this.BtnBorrarFiltroPrecio.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroPrecio.TabIndex = 106;
            this.BtnBorrarFiltroPrecio.Text = "Borrar Filtro";
            this.BtnBorrarFiltroPrecio.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroPrecio.Click += new System.EventHandler(this.BtnBorrarFiltroPrecio_Click);
            // 
            // BtnBorrarFiltroNombre
            // 
            this.BtnBorrarFiltroNombre.Location = new System.Drawing.Point(826, 176);
            this.BtnBorrarFiltroNombre.Name = "BtnBorrarFiltroNombre";
            this.BtnBorrarFiltroNombre.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroNombre.TabIndex = 105;
            this.BtnBorrarFiltroNombre.Text = "Borrar Filtro";
            this.BtnBorrarFiltroNombre.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroNombre.Click += new System.EventHandler(this.BtnBorrarFiltroNombre_Click);
            // 
            // BtnBorrarFiltroID
            // 
            this.BtnBorrarFiltroID.Location = new System.Drawing.Point(826, 115);
            this.BtnBorrarFiltroID.Name = "BtnBorrarFiltroID";
            this.BtnBorrarFiltroID.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroID.TabIndex = 104;
            this.BtnBorrarFiltroID.Text = "Borrar Filtro";
            this.BtnBorrarFiltroID.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroID.Click += new System.EventHandler(this.BtnBorrarFiltroID_Click);
            // 
            // TbFiltroID
            // 
            this.TbFiltroID.Location = new System.Drawing.Point(574, 118);
            this.TbFiltroID.Name = "TbFiltroID";
            this.TbFiltroID.Size = new System.Drawing.Size(212, 20);
            this.TbFiltroID.TabIndex = 103;
            this.TbFiltroID.TextChanged += new System.EventHandler(this.TbFiltroID_TextChanged);
            // 
            // LblClienteId
            // 
            this.LblClienteId.AutoSize = true;
            this.LblClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblClienteId.Location = new System.Drawing.Point(622, 95);
            this.LblClienteId.Name = "LblClienteId";
            this.LblClienteId.Size = new System.Drawing.Size(110, 20);
            this.LblClienteId.TabIndex = 102;
            this.LblClienteId.Text = "Filtro por ID:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblTitulo.Location = new System.Drawing.Point(548, 54);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(162, 20);
            this.LblTitulo.TabIndex = 101;
            this.LblTitulo.Text = "Buscador Producto";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(587, 345);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(49, 13);
            this.LblError.TabIndex = 100;
            this.LblError.Text = "              ";
            // 
            // TbCategoria
            // 
            this.TbCategoria.Location = new System.Drawing.Point(574, 304);
            this.TbCategoria.Name = "TbCategoria";
            this.TbCategoria.Size = new System.Drawing.Size(212, 20);
            this.TbCategoria.TabIndex = 99;
            this.TbCategoria.TextChanged += new System.EventHandler(this.TbCorreo_TextChanged);
            // 
            // TbPrecio
            // 
            this.TbPrecio.Location = new System.Drawing.Point(574, 242);
            this.TbPrecio.Name = "TbPrecio";
            this.TbPrecio.Size = new System.Drawing.Size(212, 20);
            this.TbPrecio.TabIndex = 98;
            this.TbPrecio.TextChanged += new System.EventHandler(this.TbTelefono_TextChanged);
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(574, 179);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(212, 20);
            this.TbNombre.TabIndex = 97;
            this.TbNombre.TextChanged += new System.EventHandler(this.TbNombre_TextChanged);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.Location = new System.Drawing.Point(603, 281);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(169, 20);
            this.LblCorreo.TabIndex = 96;
            this.LblCorreo.Text = "Filtro por Categoria:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblTelefono.Location = new System.Drawing.Point(611, 219);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(141, 20);
            this.LblTelefono.TabIndex = 95;
            this.LblTelefono.Text = "Filtro por Precio:";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblCliente.Location = new System.Drawing.Point(603, 156);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(163, 20);
            this.LblCliente.TabIndex = 94;
            this.LblCliente.Text = "Filtro por Producto:";
            // 
            // GvProductos
            // 
            this.GvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProductos.Location = new System.Drawing.Point(40, 29);
            this.GvProductos.Name = "GvProductos";
            this.GvProductos.Size = new System.Drawing.Size(484, 485);
            this.GvProductos.TabIndex = 93;
            // 
            // BuscadorProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 542);
            this.Controls.Add(this.LblSeleccionCategoria);
            this.Controls.Add(this.LblSeleccionPrecio);
            this.Controls.Add(this.LblSeleccionProducto);
            this.Controls.Add(this.LblSeleccionId);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.BtnBorrarFiltroCategoria);
            this.Controls.Add(this.BtnBorrarFiltroPrecio);
            this.Controls.Add(this.BtnBorrarFiltroNombre);
            this.Controls.Add(this.BtnBorrarFiltroID);
            this.Controls.Add(this.TbFiltroID);
            this.Controls.Add(this.LblClienteId);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.TbCategoria);
            this.Controls.Add(this.TbPrecio);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.GvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscadorProductos";
            this.Text = "BuscadorProductos";
            ((System.ComponentModel.ISupportInitialize)(this.GvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSeleccionCategoria;
        private System.Windows.Forms.Label LblSeleccionPrecio;
        private System.Windows.Forms.Label LblSeleccionProducto;
        private System.Windows.Forms.Label LblSeleccionId;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnBorrarFiltroCategoria;
        private System.Windows.Forms.Button BtnBorrarFiltroPrecio;
        private System.Windows.Forms.Button BtnBorrarFiltroNombre;
        private System.Windows.Forms.Button BtnBorrarFiltroID;
        private System.Windows.Forms.TextBox TbFiltroID;
        private System.Windows.Forms.Label LblClienteId;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.TextBox TbCategoria;
        private System.Windows.Forms.TextBox TbPrecio;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.DataGridView GvProductos;
    }
}