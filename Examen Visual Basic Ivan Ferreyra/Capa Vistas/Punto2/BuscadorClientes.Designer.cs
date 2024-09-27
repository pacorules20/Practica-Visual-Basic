
namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto2
{
    partial class BuscadorClientes
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.TbCorreo = new System.Windows.Forms.TextBox();
            this.TbTelefono = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.GvClientes = new System.Windows.Forms.DataGridView();
            this.TbFiltroID = new System.Windows.Forms.TextBox();
            this.LblClienteId = new System.Windows.Forms.Label();
            this.BtnBorrarFiltroID = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroNombre = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroTelefono = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroCorreo = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.LblSeleccionId = new System.Windows.Forms.Label();
            this.LblSeleccionCliente = new System.Windows.Forms.Label();
            this.LblSeleccionCorreo = new System.Windows.Forms.Label();
            this.LblSeleccionTelefono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblTitulo.Location = new System.Drawing.Point(534, 54);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(146, 20);
            this.LblTitulo.TabIndex = 74;
            this.LblTitulo.Text = "Buscador Cliente";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(573, 345);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(49, 13);
            this.LblError.TabIndex = 73;
            this.LblError.Text = "              ";
            // 
            // TbCorreo
            // 
            this.TbCorreo.Location = new System.Drawing.Point(560, 304);
            this.TbCorreo.Name = "TbCorreo";
            this.TbCorreo.Size = new System.Drawing.Size(212, 20);
            this.TbCorreo.TabIndex = 71;
            this.TbCorreo.TextChanged += new System.EventHandler(this.TbCorreo_TextChanged);
            // 
            // TbTelefono
            // 
            this.TbTelefono.Location = new System.Drawing.Point(560, 242);
            this.TbTelefono.Name = "TbTelefono";
            this.TbTelefono.Size = new System.Drawing.Size(212, 20);
            this.TbTelefono.TabIndex = 70;
            this.TbTelefono.TextChanged += new System.EventHandler(this.TbTelefono_TextChanged);
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(560, 179);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(212, 20);
            this.TbNombre.TabIndex = 69;
            this.TbNombre.TextChanged += new System.EventHandler(this.TbNombre_TextChanged);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.Location = new System.Drawing.Point(597, 281);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(145, 20);
            this.LblCorreo.TabIndex = 68;
            this.LblCorreo.Text = "Filtro por Correo:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblTelefono.Location = new System.Drawing.Point(589, 219);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(161, 20);
            this.LblTelefono.TabIndex = 67;
            this.LblTelefono.Text = "Filtro por Telefono:";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblCliente.Location = new System.Drawing.Point(589, 156);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(147, 20);
            this.LblCliente.TabIndex = 66;
            this.LblCliente.Text = "Filtro por Cliente:";
            // 
            // GvClientes
            // 
            this.GvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvClientes.Location = new System.Drawing.Point(26, 29);
            this.GvClientes.Name = "GvClientes";
            this.GvClientes.Size = new System.Drawing.Size(484, 485);
            this.GvClientes.TabIndex = 65;
            // 
            // TbFiltroID
            // 
            this.TbFiltroID.Location = new System.Drawing.Point(560, 118);
            this.TbFiltroID.Name = "TbFiltroID";
            this.TbFiltroID.Size = new System.Drawing.Size(212, 20);
            this.TbFiltroID.TabIndex = 79;
            this.TbFiltroID.TextChanged += new System.EventHandler(this.LblFiltroID_TextChanged);
            // 
            // LblClienteId
            // 
            this.LblClienteId.AutoSize = true;
            this.LblClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblClienteId.Location = new System.Drawing.Point(608, 95);
            this.LblClienteId.Name = "LblClienteId";
            this.LblClienteId.Size = new System.Drawing.Size(110, 20);
            this.LblClienteId.TabIndex = 78;
            this.LblClienteId.Text = "Filtro por ID:";
            // 
            // BtnBorrarFiltroID
            // 
            this.BtnBorrarFiltroID.Location = new System.Drawing.Point(812, 115);
            this.BtnBorrarFiltroID.Name = "BtnBorrarFiltroID";
            this.BtnBorrarFiltroID.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroID.TabIndex = 84;
            this.BtnBorrarFiltroID.Text = "Borrar Filtro";
            this.BtnBorrarFiltroID.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroID.Click += new System.EventHandler(this.BtnBorrarFiltroID_Click);
            // 
            // BtnBorrarFiltroNombre
            // 
            this.BtnBorrarFiltroNombre.Location = new System.Drawing.Point(812, 176);
            this.BtnBorrarFiltroNombre.Name = "BtnBorrarFiltroNombre";
            this.BtnBorrarFiltroNombre.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroNombre.TabIndex = 85;
            this.BtnBorrarFiltroNombre.Text = "Borrar Filtro";
            this.BtnBorrarFiltroNombre.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroNombre.Click += new System.EventHandler(this.BtnBorrarFiltroNombre_Click);
            // 
            // BtnBorrarFiltroTelefono
            // 
            this.BtnBorrarFiltroTelefono.Location = new System.Drawing.Point(812, 239);
            this.BtnBorrarFiltroTelefono.Name = "BtnBorrarFiltroTelefono";
            this.BtnBorrarFiltroTelefono.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroTelefono.TabIndex = 86;
            this.BtnBorrarFiltroTelefono.Text = "Borrar Filtro";
            this.BtnBorrarFiltroTelefono.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroTelefono.Click += new System.EventHandler(this.BtnBorrarFiltroTelefono_Click);
            // 
            // BtnBorrarFiltroCorreo
            // 
            this.BtnBorrarFiltroCorreo.Location = new System.Drawing.Point(812, 301);
            this.BtnBorrarFiltroCorreo.Name = "BtnBorrarFiltroCorreo";
            this.BtnBorrarFiltroCorreo.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroCorreo.TabIndex = 87;
            this.BtnBorrarFiltroCorreo.Text = "Borrar Filtro";
            this.BtnBorrarFiltroCorreo.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroCorreo.Click += new System.EventHandler(this.BtnBorrarFiltroCorreo_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Location = new System.Drawing.Point(612, 373);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(258, 46);
            this.BtnSeleccionar.TabIndex = 88;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // LblSeleccionId
            // 
            this.LblSeleccionId.AutoSize = true;
            this.LblSeleccionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeleccionId.Location = new System.Drawing.Point(558, 435);
            this.LblSeleccionId.Name = "LblSeleccionId";
            this.LblSeleccionId.Size = new System.Drawing.Size(64, 18);
            this.LblSeleccionId.TabIndex = 89;
            this.LblSeleccionId.Text = "              ";
            // 
            // LblSeleccionCliente
            // 
            this.LblSeleccionCliente.AutoSize = true;
            this.LblSeleccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeleccionCliente.Location = new System.Drawing.Point(557, 454);
            this.LblSeleccionCliente.Name = "LblSeleccionCliente";
            this.LblSeleccionCliente.Size = new System.Drawing.Size(64, 18);
            this.LblSeleccionCliente.TabIndex = 90;
            this.LblSeleccionCliente.Text = "              ";
            // 
            // LblSeleccionCorreo
            // 
            this.LblSeleccionCorreo.AutoSize = true;
            this.LblSeleccionCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeleccionCorreo.Location = new System.Drawing.Point(558, 495);
            this.LblSeleccionCorreo.Name = "LblSeleccionCorreo";
            this.LblSeleccionCorreo.Size = new System.Drawing.Size(64, 18);
            this.LblSeleccionCorreo.TabIndex = 92;
            this.LblSeleccionCorreo.Text = "              ";
            // 
            // LblSeleccionTelefono
            // 
            this.LblSeleccionTelefono.AutoSize = true;
            this.LblSeleccionTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeleccionTelefono.Location = new System.Drawing.Point(557, 474);
            this.LblSeleccionTelefono.Name = "LblSeleccionTelefono";
            this.LblSeleccionTelefono.Size = new System.Drawing.Size(64, 18);
            this.LblSeleccionTelefono.TabIndex = 91;
            this.LblSeleccionTelefono.Text = "              ";
            // 
            // BuscadorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 542);
            this.Controls.Add(this.LblSeleccionCorreo);
            this.Controls.Add(this.LblSeleccionTelefono);
            this.Controls.Add(this.LblSeleccionCliente);
            this.Controls.Add(this.LblSeleccionId);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.BtnBorrarFiltroCorreo);
            this.Controls.Add(this.BtnBorrarFiltroTelefono);
            this.Controls.Add(this.BtnBorrarFiltroNombre);
            this.Controls.Add(this.BtnBorrarFiltroID);
            this.Controls.Add(this.TbFiltroID);
            this.Controls.Add(this.LblClienteId);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.TbCorreo);
            this.Controls.Add(this.TbTelefono);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.GvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscadorClientes";
            this.Text = "Filtrar";
            ((System.ComponentModel.ISupportInitialize)(this.GvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.TextBox TbCorreo;
        private System.Windows.Forms.TextBox TbTelefono;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.DataGridView GvClientes;
        private System.Windows.Forms.TextBox TbFiltroID;
        private System.Windows.Forms.Label LblClienteId;
        private System.Windows.Forms.Button BtnBorrarFiltroID;
        private System.Windows.Forms.Button BtnBorrarFiltroNombre;
        private System.Windows.Forms.Button BtnBorrarFiltroTelefono;
        private System.Windows.Forms.Button BtnBorrarFiltroCorreo;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Label LblSeleccionId;
        private System.Windows.Forms.Label LblSeleccionCliente;
        private System.Windows.Forms.Label LblSeleccionCorreo;
        private System.Windows.Forms.Label LblSeleccionTelefono;
    }
}