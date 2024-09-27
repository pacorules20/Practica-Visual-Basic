
namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto1
{
    partial class AltaProductos
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
            this.LblError = new System.Windows.Forms.Label();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.TbCategoria = new System.Windows.Forms.TextBox();
            this.TbPrecio = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GvProdcutos = new System.Windows.Forms.DataGridView();
            this.LblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GvProdcutos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(625, 467);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 52;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(677, 348);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(258, 46);
            this.BtnCargar.TabIndex = 51;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // TbCategoria
            // 
            this.TbCategoria.Location = new System.Drawing.Point(737, 276);
            this.TbCategoria.Name = "TbCategoria";
            this.TbCategoria.Size = new System.Drawing.Size(212, 20);
            this.TbCategoria.TabIndex = 50;
            // 
            // TbPrecio
            // 
            this.TbPrecio.Location = new System.Drawing.Point(737, 212);
            this.TbPrecio.Name = "TbPrecio";
            this.TbPrecio.Size = new System.Drawing.Size(212, 20);
            this.TbPrecio.TabIndex = 49;
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(737, 146);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(212, 20);
            this.TbNombre.TabIndex = 48;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(639, 274);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(92, 20);
            this.LblCategoria.TabIndex = 47;
            this.LblCategoria.Text = "Categoria:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblPrecio.Location = new System.Drawing.Point(639, 210);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(64, 20);
            this.LblPrecio.TabIndex = 46;
            this.LblPrecio.Text = "Precio:";
            this.LblPrecio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblNombre.Location = new System.Drawing.Point(639, 146);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(76, 20);
            this.LblNombre.TabIndex = 45;
            this.LblNombre.Text = "Nombre:";
            // 
            // GvProdcutos
            // 
            this.GvProdcutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvProdcutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProdcutos.Location = new System.Drawing.Point(34, 48);
            this.GvProdcutos.Name = "GvProdcutos";
            this.GvProdcutos.Size = new System.Drawing.Size(568, 485);
            this.GvProdcutos.TabIndex = 44;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblTitulo.Location = new System.Drawing.Point(733, 78);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(127, 20);
            this.LblTitulo.TabIndex = 53;
            this.LblTitulo.Text = "Alta Productos";
            // 
            // AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 581);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.TbCategoria);
            this.Controls.Add(this.TbPrecio);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.GvProdcutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaProductos";
            this.Text = "AltaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.GvProdcutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox TbCategoria;
        private System.Windows.Forms.TextBox TbPrecio;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView GvProdcutos;
        private System.Windows.Forms.Label LblTitulo;
    }
}