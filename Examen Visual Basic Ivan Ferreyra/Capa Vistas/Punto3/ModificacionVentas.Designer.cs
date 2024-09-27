
namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto3
{
    partial class ModificacionVentas
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TbCantidad = new System.Windows.Forms.TextBox();
            this.TbIdProducto = new System.Windows.Forms.TextBox();
            this.TbIdVenta = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblProductoId = new System.Windows.Forms.Label();
            this.LblVentaId = new System.Windows.Forms.Label();
            this.GvVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblTitulo.Location = new System.Drawing.Point(723, 77);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(171, 20);
            this.LblTitulo.TabIndex = 74;
            this.LblTitulo.Text = "Modificacion Ventas";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(671, 451);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 73;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(689, 351);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(258, 46);
            this.BtnModificar.TabIndex = 72;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TbCantidad
            // 
            this.TbCantidad.Location = new System.Drawing.Point(767, 282);
            this.TbCantidad.Name = "TbCantidad";
            this.TbCantidad.Size = new System.Drawing.Size(188, 20);
            this.TbCantidad.TabIndex = 71;
            // 
            // TbIdProducto
            // 
            this.TbIdProducto.Location = new System.Drawing.Point(767, 218);
            this.TbIdProducto.Name = "TbIdProducto";
            this.TbIdProducto.Size = new System.Drawing.Size(188, 20);
            this.TbIdProducto.TabIndex = 70;
            // 
            // TbIdVenta
            // 
            this.TbIdVenta.Location = new System.Drawing.Point(767, 152);
            this.TbIdVenta.Name = "TbIdVenta";
            this.TbIdVenta.Size = new System.Drawing.Size(188, 20);
            this.TbIdVenta.TabIndex = 69;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(670, 280);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(86, 20);
            this.LblCantidad.TabIndex = 68;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblProductoId
            // 
            this.LblProductoId.AutoSize = true;
            this.LblProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblProductoId.Location = new System.Drawing.Point(654, 216);
            this.LblProductoId.Name = "LblProductoId";
            this.LblProductoId.Size = new System.Drawing.Size(110, 20);
            this.LblProductoId.TabIndex = 67;
            this.LblProductoId.Text = "ID Producto:";
            // 
            // LblVentaId
            // 
            this.LblVentaId.AutoSize = true;
            this.LblVentaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblVentaId.Location = new System.Drawing.Point(670, 152);
            this.LblVentaId.Name = "LblVentaId";
            this.LblVentaId.Size = new System.Drawing.Size(86, 20);
            this.LblVentaId.TabIndex = 66;
            this.LblVentaId.Text = "ID Venta:";
            // 
            // GvVentas
            // 
            this.GvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvVentas.Location = new System.Drawing.Point(2, 33);
            this.GvVentas.Name = "GvVentas";
            this.GvVentas.Size = new System.Drawing.Size(624, 485);
            this.GvVentas.TabIndex = 65;
            this.GvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvVentas_CellClick);
            // 
            // ModificacionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 581);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TbCantidad);
            this.Controls.Add(this.TbIdProducto);
            this.Controls.Add(this.TbIdVenta);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblProductoId);
            this.Controls.Add(this.LblVentaId);
            this.Controls.Add(this.GvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificacionVentas";
            this.Text = "ModificacionVentas";
            ((System.ComponentModel.ISupportInitialize)(this.GvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TbCantidad;
        private System.Windows.Forms.TextBox TbIdProducto;
        private System.Windows.Forms.TextBox TbIdVenta;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblProductoId;
        private System.Windows.Forms.Label LblVentaId;
        private System.Windows.Forms.DataGridView GvVentas;
    }
}