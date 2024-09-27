
namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto1
{
    partial class BajaProductos
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
            this.LblDescripcionMetodo = new System.Windows.Forms.Label();
            this.BtnEliminarPorSeleccion = new System.Windows.Forms.Button();
            this.LblDescripcion1 = new System.Windows.Forms.Label();
            this.LblDescripcion2 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.BtnEliminarPorId = new System.Windows.Forms.Button();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.GvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDescripcionMetodo
            // 
            this.LblDescripcionMetodo.AutoSize = true;
            this.LblDescripcionMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblDescripcionMetodo.ForeColor = System.Drawing.Color.Tomato;
            this.LblDescripcionMetodo.Location = new System.Drawing.Point(676, 110);
            this.LblDescripcionMetodo.Name = "LblDescripcionMetodo";
            this.LblDescripcionMetodo.Size = new System.Drawing.Size(258, 20);
            this.LblDescripcionMetodo.TabIndex = 76;
            this.LblDescripcionMetodo.Text = "Haga click sobre la fila a borrar";
            // 
            // BtnEliminarPorSeleccion
            // 
            this.BtnEliminarPorSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPorSeleccion.Location = new System.Drawing.Point(676, 168);
            this.BtnEliminarPorSeleccion.Name = "BtnEliminarPorSeleccion";
            this.BtnEliminarPorSeleccion.Size = new System.Drawing.Size(258, 46);
            this.BtnEliminarPorSeleccion.TabIndex = 75;
            this.BtnEliminarPorSeleccion.Text = "Eliminar";
            this.BtnEliminarPorSeleccion.UseVisualStyleBackColor = true;
            this.BtnEliminarPorSeleccion.Click += new System.EventHandler(this.BtnEliminarPorSeleccion_Click);
            // 
            // LblDescripcion1
            // 
            this.LblDescripcion1.AutoSize = true;
            this.LblDescripcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblDescripcion1.Location = new System.Drawing.Point(716, 59);
            this.LblDescripcion1.Name = "LblDescripcion1";
            this.LblDescripcion1.Size = new System.Drawing.Size(179, 20);
            this.LblDescripcion1.TabIndex = 74;
            this.LblDescripcion1.Text = "Borrar seleccionando";
            // 
            // LblDescripcion2
            // 
            this.LblDescripcion2.AutoSize = true;
            this.LblDescripcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblDescripcion2.Location = new System.Drawing.Point(741, 289);
            this.LblDescripcion2.Name = "LblDescripcion2";
            this.LblDescripcion2.Size = new System.Drawing.Size(114, 20);
            this.LblDescripcion2.TabIndex = 73;
            this.LblDescripcion2.Text = "Borrar por ID";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(633, 478);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 72;
            // 
            // BtnEliminarPorId
            // 
            this.BtnEliminarPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPorId.Location = new System.Drawing.Point(674, 389);
            this.BtnEliminarPorId.Name = "BtnEliminarPorId";
            this.BtnEliminarPorId.Size = new System.Drawing.Size(258, 46);
            this.BtnEliminarPorId.TabIndex = 71;
            this.BtnEliminarPorId.Text = "Eliminar";
            this.BtnEliminarPorId.UseVisualStyleBackColor = true;
            this.BtnEliminarPorId.Click += new System.EventHandler(this.BtnEliminarPorId_Click);
            // 
            // Tb_Id
            // 
            this.Tb_Id.Location = new System.Drawing.Point(709, 337);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.Size = new System.Drawing.Size(212, 20);
            this.Tb_Id.TabIndex = 70;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblCliente.Location = new System.Drawing.Point(652, 337);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(35, 20);
            this.LblCliente.TabIndex = 69;
            this.LblCliente.Text = "Id :";
            // 
            // GvProductos
            // 
            this.GvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProductos.Location = new System.Drawing.Point(32, 29);
            this.GvProductos.Name = "GvProductos";
            this.GvProductos.Size = new System.Drawing.Size(568, 485);
            this.GvProductos.TabIndex = 68;
            // 
            // BajaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 542);
            this.Controls.Add(this.LblDescripcionMetodo);
            this.Controls.Add(this.BtnEliminarPorSeleccion);
            this.Controls.Add(this.LblDescripcion1);
            this.Controls.Add(this.LblDescripcion2);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnEliminarPorId);
            this.Controls.Add(this.Tb_Id);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.GvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaProductos";
            this.Text = "BajaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.GvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDescripcionMetodo;
        private System.Windows.Forms.Button BtnEliminarPorSeleccion;
        private System.Windows.Forms.Label LblDescripcion1;
        private System.Windows.Forms.Label LblDescripcion2;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Button BtnEliminarPorId;
        private System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.DataGridView GvProductos;
    }
}