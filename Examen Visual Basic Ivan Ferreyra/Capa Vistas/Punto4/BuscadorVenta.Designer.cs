
namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto4
{
    partial class BuscadorVenta
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
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroTotal = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroFecha = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroCliente = new System.Windows.Forms.Button();
            this.BtnBorrarFiltroID = new System.Windows.Forms.Button();
            this.TbFiltroID = new System.Windows.Forms.TextBox();
            this.LblClienteId = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.TbFiltroTotal = new System.Windows.Forms.TextBox();
            this.TbFiltroIdClietne = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblIdCliente = new System.Windows.Forms.Label();
            this.GvVentas = new System.Windows.Forms.DataGridView();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnAplicarFiltro = new System.Windows.Forms.Button();
            this.LblIdSeleccionado = new System.Windows.Forms.Label();
            this.LblClienteIdSeleccionado = new System.Windows.Forms.Label();
            this.LblFechaSeleccionada = new System.Windows.Forms.Label();
            this.LblTotalSeleccionado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Location = new System.Drawing.Point(644, 369);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(258, 46);
            this.BtnSeleccionar.TabIndex = 128;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnBorrarFiltroTotal
            // 
            this.BtnBorrarFiltroTotal.Location = new System.Drawing.Point(844, 297);
            this.BtnBorrarFiltroTotal.Name = "BtnBorrarFiltroTotal";
            this.BtnBorrarFiltroTotal.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroTotal.TabIndex = 127;
            this.BtnBorrarFiltroTotal.Text = "Borrar Filtro";
            this.BtnBorrarFiltroTotal.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroTotal.Click += new System.EventHandler(this.BtnBorrarFiltroTotal_Click);
            // 
            // BtnBorrarFiltroFecha
            // 
            this.BtnBorrarFiltroFecha.Location = new System.Drawing.Point(844, 230);
            this.BtnBorrarFiltroFecha.Name = "BtnBorrarFiltroFecha";
            this.BtnBorrarFiltroFecha.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroFecha.TabIndex = 126;
            this.BtnBorrarFiltroFecha.Text = "Borrar Filtro";
            this.BtnBorrarFiltroFecha.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroFecha.Click += new System.EventHandler(this.BtnBorrarFiltroFecha_Click);
            // 
            // BtnBorrarFiltroCliente
            // 
            this.BtnBorrarFiltroCliente.Location = new System.Drawing.Point(844, 143);
            this.BtnBorrarFiltroCliente.Name = "BtnBorrarFiltroCliente";
            this.BtnBorrarFiltroCliente.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroCliente.TabIndex = 125;
            this.BtnBorrarFiltroCliente.Text = "Borrar Filtro";
            this.BtnBorrarFiltroCliente.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroCliente.Click += new System.EventHandler(this.BtnBorrarFiltroCliente_Click);
            // 
            // BtnBorrarFiltroID
            // 
            this.BtnBorrarFiltroID.Location = new System.Drawing.Point(844, 82);
            this.BtnBorrarFiltroID.Name = "BtnBorrarFiltroID";
            this.BtnBorrarFiltroID.Size = new System.Drawing.Size(101, 23);
            this.BtnBorrarFiltroID.TabIndex = 124;
            this.BtnBorrarFiltroID.Text = "Borrar Filtro";
            this.BtnBorrarFiltroID.UseVisualStyleBackColor = true;
            this.BtnBorrarFiltroID.Click += new System.EventHandler(this.BtnBorrarFiltroID_Click);
            // 
            // TbFiltroID
            // 
            this.TbFiltroID.Location = new System.Drawing.Point(592, 85);
            this.TbFiltroID.Name = "TbFiltroID";
            this.TbFiltroID.Size = new System.Drawing.Size(212, 20);
            this.TbFiltroID.TabIndex = 123;
            this.TbFiltroID.TextChanged += new System.EventHandler(this.TbFiltroID_TextChanged);
            // 
            // LblClienteId
            // 
            this.LblClienteId.AutoSize = true;
            this.LblClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblClienteId.Location = new System.Drawing.Point(640, 62);
            this.LblClienteId.Name = "LblClienteId";
            this.LblClienteId.Size = new System.Drawing.Size(110, 20);
            this.LblClienteId.TabIndex = 122;
            this.LblClienteId.Text = "Filtro por ID:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblTitulo.Location = new System.Drawing.Point(566, 21);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(127, 20);
            this.LblTitulo.TabIndex = 121;
            this.LblTitulo.Text = "Buscar Ventas";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(605, 344);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(49, 13);
            this.LblError.TabIndex = 120;
            this.LblError.Text = "              ";
            // 
            // TbFiltroTotal
            // 
            this.TbFiltroTotal.Location = new System.Drawing.Point(592, 300);
            this.TbFiltroTotal.Name = "TbFiltroTotal";
            this.TbFiltroTotal.Size = new System.Drawing.Size(212, 20);
            this.TbFiltroTotal.TabIndex = 119;
            this.TbFiltroTotal.TextChanged += new System.EventHandler(this.TbFiltroTotal_TextChanged);
            // 
            // TbFiltroIdClietne
            // 
            this.TbFiltroIdClietne.Location = new System.Drawing.Point(592, 146);
            this.TbFiltroIdClietne.Name = "TbFiltroIdClietne";
            this.TbFiltroIdClietne.Size = new System.Drawing.Size(212, 20);
            this.TbFiltroIdClietne.TabIndex = 117;
            this.TbFiltroIdClietne.TextChanged += new System.EventHandler(this.TbFiltroIdClietne_TextChanged);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(621, 277);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(131, 20);
            this.LblTotal.TabIndex = 116;
            this.LblTotal.Text = "Filtro por Total:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblFecha.Location = new System.Drawing.Point(629, 186);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(141, 20);
            this.LblFecha.TabIndex = 115;
            this.LblFecha.Text = "Filtro por Fecha:";
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.AutoSize = true;
            this.LblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblIdCliente.Location = new System.Drawing.Point(604, 123);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(197, 20);
            this.LblIdCliente.TabIndex = 114;
            this.LblIdCliente.Text = "Filtro por ID del cliente:";
            // 
            // GvVentas
            // 
            this.GvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvVentas.Location = new System.Drawing.Point(2, 23);
            this.GvVentas.Name = "GvVentas";
            this.GvVentas.Size = new System.Drawing.Size(545, 485);
            this.GvVentas.TabIndex = 113;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Checked = false;
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(593, 219);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtpFecha.Size = new System.Drawing.Size(211, 20);
            this.DtpFecha.TabIndex = 134;
            this.DtpFecha.Value = new System.DateTime(2024, 9, 24, 0, 0, 0, 0);
            // 
            // BtnAplicarFiltro
            // 
            this.BtnAplicarFiltro.Location = new System.Drawing.Point(844, 201);
            this.BtnAplicarFiltro.Name = "BtnAplicarFiltro";
            this.BtnAplicarFiltro.Size = new System.Drawing.Size(101, 23);
            this.BtnAplicarFiltro.TabIndex = 135;
            this.BtnAplicarFiltro.Text = "Aplicar Filtro";
            this.BtnAplicarFiltro.UseVisualStyleBackColor = true;
            this.BtnAplicarFiltro.Click += new System.EventHandler(this.BtnAplicarFiltro_Click);
            // 
            // LblIdSeleccionado
            // 
            this.LblIdSeleccionado.AutoSize = true;
            this.LblIdSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdSeleccionado.Location = new System.Drawing.Point(605, 443);
            this.LblIdSeleccionado.Name = "LblIdSeleccionado";
            this.LblIdSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.LblIdSeleccionado.TabIndex = 136;
            // 
            // LblClienteIdSeleccionado
            // 
            this.LblClienteIdSeleccionado.AutoSize = true;
            this.LblClienteIdSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClienteIdSeleccionado.Location = new System.Drawing.Point(605, 467);
            this.LblClienteIdSeleccionado.Name = "LblClienteIdSeleccionado";
            this.LblClienteIdSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.LblClienteIdSeleccionado.TabIndex = 137;
            // 
            // LblFechaSeleccionada
            // 
            this.LblFechaSeleccionada.AutoSize = true;
            this.LblFechaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaSeleccionada.Location = new System.Drawing.Point(605, 489);
            this.LblFechaSeleccionada.Name = "LblFechaSeleccionada";
            this.LblFechaSeleccionada.Size = new System.Drawing.Size(0, 18);
            this.LblFechaSeleccionada.TabIndex = 138;
            // 
            // LblTotalSeleccionado
            // 
            this.LblTotalSeleccionado.AutoSize = true;
            this.LblTotalSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalSeleccionado.Location = new System.Drawing.Point(605, 512);
            this.LblTotalSeleccionado.Name = "LblTotalSeleccionado";
            this.LblTotalSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.LblTotalSeleccionado.TabIndex = 139;
            // 
            // BuscadorVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 542);
            this.Controls.Add(this.LblTotalSeleccionado);
            this.Controls.Add(this.LblFechaSeleccionada);
            this.Controls.Add(this.LblClienteIdSeleccionado);
            this.Controls.Add(this.LblIdSeleccionado);
            this.Controls.Add(this.BtnAplicarFiltro);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.BtnBorrarFiltroTotal);
            this.Controls.Add(this.BtnBorrarFiltroFecha);
            this.Controls.Add(this.BtnBorrarFiltroCliente);
            this.Controls.Add(this.BtnBorrarFiltroID);
            this.Controls.Add(this.TbFiltroID);
            this.Controls.Add(this.LblClienteId);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.TbFiltroTotal);
            this.Controls.Add(this.TbFiltroIdClietne);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblIdCliente);
            this.Controls.Add(this.GvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscadorVenta";
            this.Text = "BuscadorVenta";
            ((System.ComponentModel.ISupportInitialize)(this.GvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnBorrarFiltroTotal;
        private System.Windows.Forms.Button BtnBorrarFiltroFecha;
        private System.Windows.Forms.Button BtnBorrarFiltroCliente;
        private System.Windows.Forms.Button BtnBorrarFiltroID;
        private System.Windows.Forms.TextBox TbFiltroID;
        private System.Windows.Forms.Label LblClienteId;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.TextBox TbFiltroTotal;
        private System.Windows.Forms.TextBox TbFiltroIdClietne;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblIdCliente;
        private System.Windows.Forms.DataGridView GvVentas;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Button BtnAplicarFiltro;
        private System.Windows.Forms.Label LblIdSeleccionado;
        private System.Windows.Forms.Label LblClienteIdSeleccionado;
        private System.Windows.Forms.Label LblFechaSeleccionada;
        private System.Windows.Forms.Label LblTotalSeleccionado;
    }
}