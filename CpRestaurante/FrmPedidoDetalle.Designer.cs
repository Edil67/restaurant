namespace CpRestaurante
{
    partial class FrmPedidoDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoDetalle));
            this.btnNuevoRegistroVenta = new System.Windows.Forms.Button();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dtpFEchaPedidoDetalle = new System.Windows.Forms.DateTimePicker();
            this.gvxInfCliente = new System.Windows.Forms.GroupBox();
            this.txtInfNombreCliente = new System.Windows.Forms.TextBox();
            this.lblInfNombreCliente = new System.Windows.Forms.Label();
            this.lblCeduaIdentidad = new System.Windows.Forms.Label();
            this.txtInfVentaCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.txtParametroCedulaIdentidadVentaDetalle = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.gbxInfVentaDetalle = new System.Windows.Forms.GroupBox();
            this.txtInfVentaUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioVentaDetalle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.gvxInfCliente.SuspendLayout();
            this.gbxInfVentaDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoRegistroVenta
            // 
            this.btnNuevoRegistroVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoRegistroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRegistroVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoRegistroVenta.Location = new System.Drawing.Point(623, 116);
            this.btnNuevoRegistroVenta.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevoRegistroVenta.Name = "btnNuevoRegistroVenta";
            this.btnNuevoRegistroVenta.Size = new System.Drawing.Size(269, 47);
            this.btnNuevoRegistroVenta.TabIndex = 260;
            this.btnNuevoRegistroVenta.Text = "Nuevo Registro";
            this.btnNuevoRegistroVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoRegistroVenta.UseVisualStyleBackColor = false;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(21, 419);
            this.dgvDetalleVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.RowHeadersWidth = 51;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(875, 225);
            this.dgvDetalleVenta.TabIndex = 259;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(766, 60);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(127, 47);
            this.btnBorrar.TabIndex = 257;
            this.btnBorrar.Text = "Limpiar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // dtpFEchaPedidoDetalle
            // 
            this.dtpFEchaPedidoDetalle.CalendarMonthBackground = System.Drawing.Color.Peru;
            this.dtpFEchaPedidoDetalle.Enabled = false;
            this.dtpFEchaPedidoDetalle.Location = new System.Drawing.Point(34, 54);
            this.dtpFEchaPedidoDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFEchaPedidoDetalle.Name = "dtpFEchaPedidoDetalle";
            this.dtpFEchaPedidoDetalle.Size = new System.Drawing.Size(325, 31);
            this.dtpFEchaPedidoDetalle.TabIndex = 94;
            // 
            // gvxInfCliente
            // 
            this.gvxInfCliente.BackColor = System.Drawing.Color.Tan;
            this.gvxInfCliente.Controls.Add(this.txtInfNombreCliente);
            this.gvxInfCliente.Controls.Add(this.lblInfNombreCliente);
            this.gvxInfCliente.Controls.Add(this.lblCeduaIdentidad);
            this.gvxInfCliente.Controls.Add(this.txtInfVentaCedulaIdentidad);
            this.gvxInfCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvxInfCliente.Location = new System.Drawing.Point(21, 280);
            this.gvxInfCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gvxInfCliente.Name = "gvxInfCliente";
            this.gvxInfCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gvxInfCliente.Size = new System.Drawing.Size(876, 122);
            this.gvxInfCliente.TabIndex = 255;
            this.gvxInfCliente.TabStop = false;
            this.gvxInfCliente.Text = "Informacion Cliente";
            // 
            // txtInfNombreCliente
            // 
            this.txtInfNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfNombreCliente.Location = new System.Drawing.Point(435, 69);
            this.txtInfNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfNombreCliente.MaxLength = 100;
            this.txtInfNombreCliente.Name = "txtInfNombreCliente";
            this.txtInfNombreCliente.ReadOnly = true;
            this.txtInfNombreCliente.Size = new System.Drawing.Size(253, 24);
            this.txtInfNombreCliente.TabIndex = 86;
            // 
            // lblInfNombreCliente
            // 
            this.lblInfNombreCliente.AutoSize = true;
            this.lblInfNombreCliente.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblInfNombreCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfNombreCliente.Location = new System.Drawing.Point(440, 42);
            this.lblInfNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfNombreCliente.Name = "lblInfNombreCliente";
            this.lblInfNombreCliente.Size = new System.Drawing.Size(168, 23);
            this.lblInfNombreCliente.TabIndex = 83;
            this.lblInfNombreCliente.Text = "Nombre Cliente:";
            // 
            // lblCeduaIdentidad
            // 
            this.lblCeduaIdentidad.AutoSize = true;
            this.lblCeduaIdentidad.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblCeduaIdentidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCeduaIdentidad.Location = new System.Drawing.Point(56, 42);
            this.lblCeduaIdentidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeduaIdentidad.Name = "lblCeduaIdentidad";
            this.lblCeduaIdentidad.Size = new System.Drawing.Size(177, 23);
            this.lblCeduaIdentidad.TabIndex = 91;
            this.lblCeduaIdentidad.Text = "Cedula Identidad";
            // 
            // txtInfVentaCedulaIdentidad
            // 
            this.txtInfVentaCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfVentaCedulaIdentidad.Location = new System.Drawing.Point(34, 69);
            this.txtInfVentaCedulaIdentidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfVentaCedulaIdentidad.MaxLength = 12;
            this.txtInfVentaCedulaIdentidad.Name = "txtInfVentaCedulaIdentidad";
            this.txtInfVentaCedulaIdentidad.ReadOnly = true;
            this.txtInfVentaCedulaIdentidad.Size = new System.Drawing.Size(251, 24);
            this.txtInfVentaCedulaIdentidad.TabIndex = 87;
            // 
            // txtParametroCedulaIdentidadVentaDetalle
            // 
            this.txtParametroCedulaIdentidadVentaDetalle.Location = new System.Drawing.Point(282, 73);
            this.txtParametroCedulaIdentidadVentaDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtParametroCedulaIdentidadVentaDetalle.Multiline = true;
            this.txtParametroCedulaIdentidadVentaDetalle.Name = "txtParametroCedulaIdentidadVentaDetalle";
            this.txtParametroCedulaIdentidadVentaDetalle.Size = new System.Drawing.Size(277, 32);
            this.txtParametroCedulaIdentidadVentaDetalle.TabIndex = 252;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(33, 76);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(211, 23);
            this.lblNumeroDocumento.TabIndex = 253;
            this.lblNumeroDocumento.Text = "Numero Documento:";
            // 
            // gbxInfVentaDetalle
            // 
            this.gbxInfVentaDetalle.BackColor = System.Drawing.Color.Tan;
            this.gbxInfVentaDetalle.Controls.Add(this.dtpFEchaPedidoDetalle);
            this.gbxInfVentaDetalle.Controls.Add(this.txtInfVentaUsuario);
            this.gbxInfVentaDetalle.Controls.Add(this.lblUsuarioVentaDetalle);
            this.gbxInfVentaDetalle.Controls.Add(this.label3);
            this.gbxInfVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfVentaDetalle.Location = new System.Drawing.Point(21, 167);
            this.gbxInfVentaDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.gbxInfVentaDetalle.Name = "gbxInfVentaDetalle";
            this.gbxInfVentaDetalle.Padding = new System.Windows.Forms.Padding(4);
            this.gbxInfVentaDetalle.Size = new System.Drawing.Size(876, 105);
            this.gbxInfVentaDetalle.TabIndex = 254;
            this.gbxInfVentaDetalle.TabStop = false;
            this.gbxInfVentaDetalle.Text = "Información Venta";
            // 
            // txtInfVentaUsuario
            // 
            this.txtInfVentaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfVentaUsuario.Location = new System.Drawing.Point(435, 61);
            this.txtInfVentaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfVentaUsuario.MaxLength = 15;
            this.txtInfVentaUsuario.Name = "txtInfVentaUsuario";
            this.txtInfVentaUsuario.ReadOnly = true;
            this.txtInfVentaUsuario.Size = new System.Drawing.Size(184, 24);
            this.txtInfVentaUsuario.TabIndex = 93;
            // 
            // lblUsuarioVentaDetalle
            // 
            this.lblUsuarioVentaDetalle.AutoSize = true;
            this.lblUsuarioVentaDetalle.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblUsuarioVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioVentaDetalle.Location = new System.Drawing.Point(440, 27);
            this.lblUsuarioVentaDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioVentaDetalle.Name = "lblUsuarioVentaDetalle";
            this.lblUsuarioVentaDetalle.Size = new System.Drawing.Size(92, 23);
            this.lblUsuarioVentaDetalle.TabIndex = 92;
            this.lblUsuarioVentaDetalle.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PapayaWhip;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(623, 60);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 47);
            this.btnBuscar.TabIndex = 256;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(-4, -3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(935, 58);
            this.lblTitulo.TabIndex = 261;
            this.lblTitulo.Text = "Detalle Pedido";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPedidoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(932, 658);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNuevoRegistroVenta);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gvxInfCliente);
            this.Controls.Add(this.txtParametroCedulaIdentidadVentaDetalle);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.gbxInfVentaDetalle);
            this.Name = "FrmPedidoDetalle";
            this.Text = "FrmPedidoDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.gvxInfCliente.ResumeLayout(false);
            this.gvxInfCliente.PerformLayout();
            this.gbxInfVentaDetalle.ResumeLayout(false);
            this.gbxInfVentaDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoRegistroVenta;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DateTimePicker dtpFEchaPedidoDetalle;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gvxInfCliente;
        private System.Windows.Forms.TextBox txtInfNombreCliente;
        private System.Windows.Forms.Label lblInfNombreCliente;
        private System.Windows.Forms.Label lblCeduaIdentidad;
        private System.Windows.Forms.TextBox txtInfVentaCedulaIdentidad;
        private System.Windows.Forms.TextBox txtParametroCedulaIdentidadVentaDetalle;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.GroupBox gbxInfVentaDetalle;
        private System.Windows.Forms.TextBox txtInfVentaUsuario;
        private System.Windows.Forms.Label lblUsuarioVentaDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
    }
}