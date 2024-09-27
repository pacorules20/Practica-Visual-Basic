
namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto3
{
    partial class AltaVentas
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
            this.BtnCargar = new System.Windows.Forms.Button();
            this.TbCantidad = new System.Windows.Forms.TextBox();
            this.TbProducto = new System.Windows.Forms.TextBox();
            this.TbVenta = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblIDVenta = new System.Windows.Forms.Label();
            this.GvVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblTitulo.Location = new System.Drawing.Point(741, 88);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(103, 20);
            this.LblTitulo.TabIndex = 64;
            this.LblTitulo.Text = "Alta Ventas";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(682, 479);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 63;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(685, 367);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(258, 46);
            this.BtnCargar.TabIndex = 62;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // TbCantidad
            // 
            this.TbCantidad.Location = new System.Drawing.Point(776, 289);
            this.TbCantidad.Name = "TbCantidad";
            this.TbCantidad.Size = new System.Drawing.Size(193, 20);
            this.TbCantidad.TabIndex = 61;
            // 
            // TbProducto
            // 
            this.TbProducto.Location = new System.Drawing.Point(776, 225);
            this.TbProducto.Name = "TbProducto";
            this.TbProducto.Size = new System.Drawing.Size(193, 20);
            this.TbProducto.TabIndex = 60;
            // 
            // TbVenta
            // 
            this.TbVenta.Location = new System.Drawing.Point(776, 161);
            this.TbVenta.Name = "TbVenta";
            this.TbVenta.Size = new System.Drawing.Size(193, 20);
            this.TbVenta.TabIndex = 59;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(660, 289);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(86, 20);
            this.LblCantidad.TabIndex = 58;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblTelefono.Location = new System.Drawing.Point(660, 225);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(110, 20);
            this.LblTelefono.TabIndex = 57;
            this.LblTelefono.Text = "ID Producto:";
            // 
            // LblIDVenta
            // 
            this.LblIDVenta.AutoSize = true;
            this.LblIDVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblIDVenta.Location = new System.Drawing.Point(660, 161);
            this.LblIDVenta.Name = "LblIDVenta";
            this.LblIDVenta.Size = new System.Drawing.Size(86, 20);
            this.LblIDVenta.TabIndex = 56;
            this.LblIDVenta.Text = "ID Venta:";
            // 
            // GvVentas
            // 
            this.GvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvVentas.Location = new System.Drawing.Point(2, 41);
            this.GvVentas.Name = "GvVentas";
            this.GvVentas.Size = new System.Drawing.Size(633, 485);
            this.GvVentas.TabIndex = 55;
            // 
            // AltaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 581);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.TbCantidad);
            this.Controls.Add(this.TbProducto);
            this.Controls.Add(this.TbVenta);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblIDVenta);
            this.Controls.Add(this.GvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaVentas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox TbCantidad;
        private System.Windows.Forms.TextBox TbProducto;
        private System.Windows.Forms.TextBox TbVenta;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblIDVenta;
        private System.Windows.Forms.DataGridView GvVentas;
    }
}