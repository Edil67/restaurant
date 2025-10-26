namespace CpRestaurante
{
    partial class FrmPedido
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.txtNombreClienteVenta = new System.Windows.Forms.TextBox();
            this.erpCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPrecioVenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCedulaIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombreCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvListaVentas = new System.Windows.Forms.DataGridView();
            this.erpMontoTotal = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNombreClienteVenta = new System.Windows.Forms.Label();
            this.lblCedulaIdentidadCLienteVenta = new System.Windows.Forms.Label();
            this.txtCedulaIdentidadVenta = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.gbxFechaVenta = new System.Windows.Forms.GroupBox();
            this.txtNombreProductoVenta = new System.Windows.Forms.TextBox();
            this.txtStockProductoVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioProductoVenta = new System.Windows.Forms.TextBox();
            this.lblStockProductoVenta = new System.Windows.Forms.Label();
            this.lblNombreProductoVenta = new System.Windows.Forms.Label();
            this.lblPrecioProductoVenta = new System.Windows.Forms.Label();
            this.nudCantidadProductoVenta = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadProductoVenta = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.gbxProductoVenta = new System.Windows.Forms.GroupBox();
            this.btnRegistrarVentaDetalle = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtMontoTotalVentaDetalle = new System.Windows.Forms.TextBox();
            this.lblMontoTotalVentaDetalle = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.erpStock = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombreCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMontoTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductoVenta)).BeginInit();
            this.gbxProductoVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpStock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreClienteVenta
            // 
            this.txtNombreClienteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreClienteVenta.BackColor = System.Drawing.Color.LightGray;
            this.txtNombreClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClienteVenta.Location = new System.Drawing.Point(670, 238);
            this.txtNombreClienteVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreClienteVenta.MaxLength = 100;
            this.txtNombreClienteVenta.Name = "txtNombreClienteVenta";
            this.txtNombreClienteVenta.ReadOnly = true;
            this.txtNombreClienteVenta.Size = new System.Drawing.Size(183, 30);
            this.txtNombreClienteVenta.TabIndex = 126;
            // 
            // erpCantidad
            // 
            this.erpCantidad.ContainerControl = this;
            // 
            // erpNombre
            // 
            this.erpNombre.ContainerControl = this;
            // 
            // erpPrecioVenta
            // 
            this.erpPrecioVenta.ContainerControl = this;
            // 
            // erpCedulaIdentidad
            // 
            this.erpCedulaIdentidad.ContainerControl = this;
            // 
            // erpNombreCliente
            // 
            this.erpNombreCliente.ContainerControl = this;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1155, 58);
            this.lblTitulo.TabIndex = 158;
            this.lblTitulo.Text = "Sistema de Pedidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListaVentas
            // 
            this.dgvListaVentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaVentas.ColumnHeadersHeight = 29;
            this.dgvListaVentas.Location = new System.Drawing.Point(3, 371);
            this.dgvListaVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaVentas.Name = "dgvListaVentas";
            this.dgvListaVentas.RowHeadersWidth = 51;
            this.dgvListaVentas.Size = new System.Drawing.Size(1141, 314);
            this.dgvListaVentas.TabIndex = 169;
            // 
            // erpMontoTotal
            // 
            this.erpMontoTotal.ContainerControl = this;
            // 
            // lblNombreClienteVenta
            // 
            this.lblNombreClienteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreClienteVenta.AutoSize = true;
            this.lblNombreClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClienteVenta.Location = new System.Drawing.Point(449, 242);
            this.lblNombreClienteVenta.Name = "lblNombreClienteVenta";
            this.lblNombreClienteVenta.Size = new System.Drawing.Size(192, 24);
            this.lblNombreClienteVenta.TabIndex = 125;
            this.lblNombreClienteVenta.Text = "Nombre de Cliente:";
            // 
            // lblCedulaIdentidadCLienteVenta
            // 
            this.lblCedulaIdentidadCLienteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCedulaIdentidadCLienteVenta.AutoSize = true;
            this.lblCedulaIdentidadCLienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaIdentidadCLienteVenta.Location = new System.Drawing.Point(7, 236);
            this.lblCedulaIdentidadCLienteVenta.Name = "lblCedulaIdentidadCLienteVenta";
            this.lblCedulaIdentidadCLienteVenta.Size = new System.Drawing.Size(204, 24);
            this.lblCedulaIdentidadCLienteVenta.TabIndex = 4;
            this.lblCedulaIdentidadCLienteVenta.Text = "Cédula de Identidad:";
            // 
            // txtCedulaIdentidadVenta
            // 
            this.txtCedulaIdentidadVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCedulaIdentidadVenta.BackColor = System.Drawing.Color.LightGray;
            this.txtCedulaIdentidadVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaIdentidadVenta.Location = new System.Drawing.Point(236, 236);
            this.txtCedulaIdentidadVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedulaIdentidadVenta.MaxLength = 12;
            this.txtCedulaIdentidadVenta.Name = "txtCedulaIdentidadVenta";
            this.txtCedulaIdentidadVenta.ReadOnly = true;
            this.txtCedulaIdentidadVenta.Size = new System.Drawing.Size(168, 30);
            this.txtCedulaIdentidadVenta.TabIndex = 3;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.CalendarTrailingForeColor = System.Drawing.Color.LightGray;
            this.dtpFechaVenta.Enabled = false;
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Location = new System.Drawing.Point(463, 172);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaVenta.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(360, 27);
            this.dtpFechaVenta.TabIndex = 1;
            this.dtpFechaVenta.Value = new System.DateTime(2024, 6, 7, 21, 24, 35, 0);
            // 
            // gbxFechaVenta
            // 
            this.gbxFechaVenta.BackColor = System.Drawing.Color.Tan;
            this.gbxFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFechaVenta.Location = new System.Drawing.Point(453, 149);
            this.gbxFechaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFechaVenta.Name = "gbxFechaVenta";
            this.gbxFechaVenta.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFechaVenta.Size = new System.Drawing.Size(385, 68);
            this.gbxFechaVenta.TabIndex = 159;
            this.gbxFechaVenta.TabStop = false;
            this.gbxFechaVenta.Text = "Fecha Venta";
            // 
            // txtNombreProductoVenta
            // 
            this.txtNombreProductoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProductoVenta.BackColor = System.Drawing.Color.LightGray;
            this.txtNombreProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProductoVenta.Location = new System.Drawing.Point(157, 34);
            this.txtNombreProductoVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreProductoVenta.MaxLength = 150;
            this.txtNombreProductoVenta.Name = "txtNombreProductoVenta";
            this.txtNombreProductoVenta.ReadOnly = true;
            this.txtNombreProductoVenta.Size = new System.Drawing.Size(247, 30);
            this.txtNombreProductoVenta.TabIndex = 3;
            // 
            // txtStockProductoVenta
            // 
            this.txtStockProductoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockProductoVenta.BackColor = System.Drawing.Color.LightGray;
            this.txtStockProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockProductoVenta.Location = new System.Drawing.Point(157, 149);
            this.txtStockProductoVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStockProductoVenta.Name = "txtStockProductoVenta";
            this.txtStockProductoVenta.ReadOnly = true;
            this.txtStockProductoVenta.Size = new System.Drawing.Size(247, 30);
            this.txtStockProductoVenta.TabIndex = 132;
            // 
            // txtPrecioProductoVenta
            // 
            this.txtPrecioProductoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioProductoVenta.BackColor = System.Drawing.Color.LightGray;
            this.txtPrecioProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProductoVenta.Location = new System.Drawing.Point(157, 92);
            this.txtPrecioProductoVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioProductoVenta.Name = "txtPrecioProductoVenta";
            this.txtPrecioProductoVenta.ReadOnly = true;
            this.txtPrecioProductoVenta.Size = new System.Drawing.Size(247, 30);
            this.txtPrecioProductoVenta.TabIndex = 131;
            // 
            // lblStockProductoVenta
            // 
            this.lblStockProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStockProductoVenta.AutoSize = true;
            this.lblStockProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockProductoVenta.Location = new System.Drawing.Point(9, 153);
            this.lblStockProductoVenta.Name = "lblStockProductoVenta";
            this.lblStockProductoVenta.Size = new System.Drawing.Size(67, 24);
            this.lblStockProductoVenta.TabIndex = 130;
            this.lblStockProductoVenta.Text = "Stock:";
            // 
            // lblNombreProductoVenta
            // 
            this.lblNombreProductoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreProductoVenta.AutoSize = true;
            this.lblNombreProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProductoVenta.Location = new System.Drawing.Point(9, 34);
            this.lblNombreProductoVenta.Name = "lblNombreProductoVenta";
            this.lblNombreProductoVenta.Size = new System.Drawing.Size(91, 24);
            this.lblNombreProductoVenta.TabIndex = 4;
            this.lblNombreProductoVenta.Text = "Nombre:";
            // 
            // lblPrecioProductoVenta
            // 
            this.lblPrecioProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecioProductoVenta.AutoSize = true;
            this.lblPrecioProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProductoVenta.Location = new System.Drawing.Point(9, 88);
            this.lblPrecioProductoVenta.Name = "lblPrecioProductoVenta";
            this.lblPrecioProductoVenta.Size = new System.Drawing.Size(142, 24);
            this.lblPrecioProductoVenta.TabIndex = 129;
            this.lblPrecioProductoVenta.Text = "Precio Venta :";
            // 
            // nudCantidadProductoVenta
            // 
            this.nudCantidadProductoVenta.Location = new System.Drawing.Point(613, 93);
            this.nudCantidadProductoVenta.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidadProductoVenta.Name = "nudCantidadProductoVenta";
            this.nudCantidadProductoVenta.Size = new System.Drawing.Size(120, 30);
            this.nudCantidadProductoVenta.TabIndex = 140;
            // 
            // lblCantidadProductoVenta
            // 
            this.lblCantidadProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCantidadProductoVenta.AutoSize = true;
            this.lblCantidadProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProductoVenta.Location = new System.Drawing.Point(449, 92);
            this.lblCantidadProductoVenta.Name = "lblCantidadProductoVenta";
            this.lblCantidadProductoVenta.Size = new System.Drawing.Size(98, 24);
            this.lblCantidadProductoVenta.TabIndex = 127;
            this.lblCantidadProductoVenta.Text = "Cantidad:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(743, 23);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(158, 55);
            this.btnBuscarProducto.TabIndex = 124;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // gbxProductoVenta
            // 
            this.gbxProductoVenta.BackColor = System.Drawing.Color.Tan;
            this.gbxProductoVenta.Controls.Add(this.dtpFechaVenta);
            this.gbxProductoVenta.Controls.Add(this.btnRegistrarVentaDetalle);
            this.gbxProductoVenta.Controls.Add(this.gbxFechaVenta);
            this.gbxProductoVenta.Controls.Add(this.lblCantidadProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.btnAgregarProducto);
            this.gbxProductoVenta.Controls.Add(this.lblPrecioProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.lblStockProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.txtNombreClienteVenta);
            this.gbxProductoVenta.Controls.Add(this.txtMontoTotalVentaDetalle);
            this.gbxProductoVenta.Controls.Add(this.lblNombreClienteVenta);
            this.gbxProductoVenta.Controls.Add(this.txtNombreProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.txtCedulaIdentidadVenta);
            this.gbxProductoVenta.Controls.Add(this.lblCedulaIdentidadCLienteVenta);
            this.gbxProductoVenta.Controls.Add(this.txtStockProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.lblMontoTotalVentaDetalle);
            this.gbxProductoVenta.Controls.Add(this.btnQuitar);
            this.gbxProductoVenta.Controls.Add(this.lblNombreProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.txtPrecioProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.nudCantidadProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.btnBuscarProducto);
            this.gbxProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProductoVenta.Location = new System.Drawing.Point(3, 62);
            this.gbxProductoVenta.Margin = new System.Windows.Forms.Padding(4);
            this.gbxProductoVenta.Name = "gbxProductoVenta";
            this.gbxProductoVenta.Padding = new System.Windows.Forms.Padding(4);
            this.gbxProductoVenta.Size = new System.Drawing.Size(1141, 301);
            this.gbxProductoVenta.TabIndex = 161;
            this.gbxProductoVenta.TabStop = false;
            this.gbxProductoVenta.Text = "Producto";
            // 
            // btnRegistrarVentaDetalle
            // 
            this.btnRegistrarVentaDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrarVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVentaDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarVentaDetalle.Image")));
            this.btnRegistrarVentaDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVentaDetalle.Location = new System.Drawing.Point(907, 172);
            this.btnRegistrarVentaDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarVentaDetalle.Name = "btnRegistrarVentaDetalle";
            this.btnRegistrarVentaDetalle.Size = new System.Drawing.Size(193, 63);
            this.btnRegistrarVentaDetalle.TabIndex = 168;
            this.btnRegistrarVentaDetalle.Text = "Registrar Venta";
            this.btnRegistrarVentaDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarVentaDetalle.UseVisualStyleBackColor = true;
            this.btnRegistrarVentaDetalle.Click += new System.EventHandler(this.btnRegistrarVentaDetalle_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(961, 16);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(139, 62);
            this.btnAgregarProducto.TabIndex = 141;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtMontoTotalVentaDetalle
            // 
            this.txtMontoTotalVentaDetalle.BackColor = System.Drawing.Color.LightGray;
            this.txtMontoTotalVentaDetalle.Location = new System.Drawing.Point(613, 34);
            this.txtMontoTotalVentaDetalle.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontoTotalVentaDetalle.Name = "txtMontoTotalVentaDetalle";
            this.txtMontoTotalVentaDetalle.ReadOnly = true;
            this.txtMontoTotalVentaDetalle.Size = new System.Drawing.Size(120, 30);
            this.txtMontoTotalVentaDetalle.TabIndex = 165;
            // 
            // lblMontoTotalVentaDetalle
            // 
            this.lblMontoTotalVentaDetalle.AutoSize = true;
            this.lblMontoTotalVentaDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoTotalVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalVentaDetalle.Location = new System.Drawing.Point(449, 34);
            this.lblMontoTotalVentaDetalle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMontoTotalVentaDetalle.Name = "lblMontoTotalVentaDetalle";
            this.lblMontoTotalVentaDetalle.Size = new System.Drawing.Size(139, 24);
            this.lblMontoTotalVentaDetalle.TabIndex = 162;
            this.lblMontoTotalVentaDetalle.Text = "Total a Pagar:";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(961, 88);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(139, 62);
            this.btnQuitar.TabIndex = 136;
            this.btnQuitar.Text = "Borrar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // erpStock
            // 
            this.erpStock.ContainerControl = this;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1151, 688);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvListaVentas);
            this.Controls.Add(this.gbxProductoVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Restaurante - FrmPedido :::";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombreCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMontoTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductoVenta)).EndInit();
            this.gbxProductoVenta.ResumeLayout(false);
            this.gbxProductoVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarVentaDetalle;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvListaVentas;
        private System.Windows.Forms.TextBox txtNombreClienteVenta;
        private System.Windows.Forms.Label lblNombreClienteVenta;
        private System.Windows.Forms.Label lblCedulaIdentidadCLienteVenta;
        private System.Windows.Forms.TextBox txtCedulaIdentidadVenta;
        private System.Windows.Forms.GroupBox gbxFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.GroupBox gbxProductoVenta;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.TextBox txtNombreProductoVenta;
        private System.Windows.Forms.TextBox txtStockProductoVenta;
        private System.Windows.Forms.TextBox txtPrecioProductoVenta;
        private System.Windows.Forms.Label lblStockProductoVenta;
        private System.Windows.Forms.Label lblNombreProductoVenta;
        private System.Windows.Forms.Label lblPrecioProductoVenta;
        private System.Windows.Forms.NumericUpDown nudCantidadProductoVenta;
        private System.Windows.Forms.Label lblCantidadProductoVenta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.ErrorProvider erpCantidad;
        private System.Windows.Forms.ErrorProvider erpNombre;
        private System.Windows.Forms.ErrorProvider erpPrecioVenta;
        private System.Windows.Forms.ErrorProvider erpCedulaIdentidad;
        private System.Windows.Forms.ErrorProvider erpNombreCliente;
        private System.Windows.Forms.ErrorProvider erpMontoTotal;
        private System.Windows.Forms.TextBox txtMontoTotalVentaDetalle;
        private System.Windows.Forms.Label lblMontoTotalVentaDetalle;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.ErrorProvider erpStock;
    }
}