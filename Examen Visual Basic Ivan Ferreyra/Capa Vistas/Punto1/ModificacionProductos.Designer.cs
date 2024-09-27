
namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto1
{
    partial class ModificacionProductos
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
            this.TbCategoria = new System.Windows.Forms.TextBox();
            this.TbPrecio = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblTitulo.Location = new System.Drawing.Point(703, 55);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(186, 20);
            this.LblTitulo.TabIndex = 74;
            this.LblTitulo.Text = "Modificacion Producto";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(617, 448);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 73;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(669, 329);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(258, 46);
            this.BtnModificar.TabIndex = 72;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TbCategoria
            // 
            this.TbCategoria.Location = new System.Drawing.Point(729, 257);
            this.TbCategoria.Name = "TbCategoria";
            this.TbCategoria.Size = new System.Drawing.Size(212, 20);
            this.TbCategoria.TabIndex = 71;
            // 
            // TbPrecio
            // 
            this.TbPrecio.Location = new System.Drawing.Point(729, 193);
            this.TbPrecio.Name = "TbPrecio";
            this.TbPrecio.Size = new System.Drawing.Size(212, 20);
            this.TbPrecio.TabIndex = 70;
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(729, 127);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(212, 20);
            this.TbNombre.TabIndex = 69;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(635, 255);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(92, 20);
            this.LblCategoria.TabIndex = 68;
            this.LblCategoria.Text = "Categoria:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblPrecio.Location = new System.Drawing.Point(634, 191);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(64, 20);
            this.LblPrecio.TabIndex = 67;
            this.LblPrecio.Text = "Precio:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblNombre.Location = new System.Drawing.Point(636, 128);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(76, 20);
            this.LblNombre.TabIndex = 66;
            this.LblNombre.Text = "Nombre:";
            // 
            // GvProductos
            // 
            this.GvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProductos.Location = new System.Drawing.Point(26, 29);
            this.GvProductos.Name = "GvProductos";
            this.GvProductos.Size = new System.Drawing.Size(568, 485);
            this.GvProductos.TabIndex = 65;
            this.GvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvProductos_CellClick);
            // 
            // ModificacionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 542);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TbCategoria);
            this.Controls.Add(this.TbPrecio);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.GvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificacionProductos";
            this.Text = "ModificacionProductos";
            ((System.ComponentModel.ISupportInitialize)(this.GvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TbCategoria;
        private System.Windows.Forms.TextBox TbPrecio;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView GvProductos;
    }
}