
namespace Examen_Visual_Basic_Ivan_Ferreyra.Capa_Vistas.Punto1
{
    partial class ModificacionClientes
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
            this.TbCorreo = new System.Windows.Forms.TextBox();
            this.TbTelefono = new System.Windows.Forms.TextBox();
            this.TbClientes = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.GvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblTitulo.Location = new System.Drawing.Point(703, 55);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(170, 20);
            this.LblTitulo.TabIndex = 64;
            this.LblTitulo.Text = "Modificacion Cliente";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(617, 448);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 63;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(669, 329);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(258, 46);
            this.BtnModificar.TabIndex = 62;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TbCorreo
            // 
            this.TbCorreo.Location = new System.Drawing.Point(729, 257);
            this.TbCorreo.Name = "TbCorreo";
            this.TbCorreo.Size = new System.Drawing.Size(212, 20);
            this.TbCorreo.TabIndex = 61;
            // 
            // TbTelefono
            // 
            this.TbTelefono.Location = new System.Drawing.Point(729, 193);
            this.TbTelefono.Name = "TbTelefono";
            this.TbTelefono.Size = new System.Drawing.Size(212, 20);
            this.TbTelefono.TabIndex = 60;
            // 
            // TbClientes
            // 
            this.TbClientes.Location = new System.Drawing.Point(729, 127);
            this.TbClientes.Name = "TbClientes";
            this.TbClientes.Size = new System.Drawing.Size(212, 20);
            this.TbClientes.TabIndex = 59;
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.Location = new System.Drawing.Point(636, 255);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(68, 20);
            this.LblCorreo.TabIndex = 58;
            this.LblCorreo.Text = "Correo:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblTelefono.Location = new System.Drawing.Point(634, 191);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(84, 20);
            this.LblTelefono.TabIndex = 57;
            this.LblTelefono.Text = "Telefono:";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblCliente.Location = new System.Drawing.Point(636, 128);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(76, 20);
            this.LblCliente.TabIndex = 56;
            this.LblCliente.Text = "Nombre:";
            // 
            // GvClientes
            // 
            this.GvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvClientes.Location = new System.Drawing.Point(26, 29);
            this.GvClientes.Name = "GvClientes";
            this.GvClientes.Size = new System.Drawing.Size(568, 485);
            this.GvClientes.TabIndex = 55;
            this.GvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvClientes_CellClick);
            // 
            // ModificacionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 542);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TbCorreo);
            this.Controls.Add(this.TbTelefono);
            this.Controls.Add(this.TbClientes);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.GvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificacionClientes";
            this.Text = "ModificacionClientes";
            ((System.ComponentModel.ISupportInitialize)(this.GvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TbCorreo;
        private System.Windows.Forms.TextBox TbTelefono;
        private System.Windows.Forms.TextBox TbClientes;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.DataGridView GvClientes;
    }
}