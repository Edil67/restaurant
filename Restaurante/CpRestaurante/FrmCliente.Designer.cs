namespace CpRestaurante
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.lblPrimerApellidosCliente = new System.Windows.Forms.Label();
            this.erpSegundoApellidoCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombresCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCedulaIdentidadCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPrimerApellidoCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPrimerApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtCedulaIdentidadCliente = new System.Windows.Forms.TextBox();
            this.txtNombresCliente = new System.Windows.Forms.TextBox();
            this.lblNombresCliente = new System.Windows.Forms.Label();
            this.lblCedulaIdentidadCliente = new System.Windows.Forms.Label();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.txtParametroCliente = new System.Windows.Forms.TextBox();
            this.fondo = new System.Windows.Forms.Label();
            this.lblTituloCLiente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSegundoApellidoCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpSegundoApellidoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombresCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidadCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrimerApellidoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.gbxLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrimerApellidosCliente
            // 
            this.lblPrimerApellidosCliente.AutoSize = true;
            this.lblPrimerApellidosCliente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellidosCliente.Location = new System.Drawing.Point(971, 327);
            this.lblPrimerApellidosCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerApellidosCliente.Name = "lblPrimerApellidosCliente";
            this.lblPrimerApellidosCliente.Size = new System.Drawing.Size(165, 28);
            this.lblPrimerApellidosCliente.TabIndex = 207;
            this.lblPrimerApellidosCliente.Text = "Primer Apellido:";
            // 
            // erpSegundoApellidoCliente
            // 
            this.erpSegundoApellidoCliente.ContainerControl = this;
            // 
            // erpNombresCliente
            // 
            this.erpNombresCliente.ContainerControl = this;
            // 
            // erpCedulaIdentidadCliente
            // 
            this.erpCedulaIdentidadCliente.ContainerControl = this;
            // 
            // erpPrimerApellidoCliente
            // 
            this.erpPrimerApellidoCliente.ContainerControl = this;
            // 
            // txtPrimerApellidoCliente
            // 
            this.txtPrimerApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellidoCliente.Location = new System.Drawing.Point(976, 359);
            this.txtPrimerApellidoCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrimerApellidoCliente.MaxLength = 100;
            this.txtPrimerApellidoCliente.Name = "txtPrimerApellidoCliente";
            this.txtPrimerApellidoCliente.Size = new System.Drawing.Size(313, 26);
            this.txtPrimerApellidoCliente.TabIndex = 208;
            // 
            // txtCedulaIdentidadCliente
            // 
            this.txtCedulaIdentidadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaIdentidadCliente.Location = new System.Drawing.Point(972, 222);
            this.txtCedulaIdentidadCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtCedulaIdentidadCliente.MaxLength = 12;
            this.txtCedulaIdentidadCliente.Name = "txtCedulaIdentidadCliente";
            this.txtCedulaIdentidadCliente.Size = new System.Drawing.Size(312, 26);
            this.txtCedulaIdentidadCliente.TabIndex = 206;
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresCliente.Location = new System.Drawing.Point(972, 284);
            this.txtNombresCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombresCliente.MaxLength = 100;
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.Size = new System.Drawing.Size(313, 26);
            this.txtNombresCliente.TabIndex = 202;
            // 
            // lblNombresCliente
            // 
            this.lblNombresCliente.AutoSize = true;
            this.lblNombresCliente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresCliente.Location = new System.Drawing.Point(971, 254);
            this.lblNombresCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombresCliente.Name = "lblNombresCliente";
            this.lblNombresCliente.Size = new System.Drawing.Size(103, 28);
            this.lblNombresCliente.TabIndex = 199;
            this.lblNombresCliente.Text = "Nombres:";
            // 
            // lblCedulaIdentidadCliente
            // 
            this.lblCedulaIdentidadCliente.AutoSize = true;
            this.lblCedulaIdentidadCliente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaIdentidadCliente.Location = new System.Drawing.Point(971, 194);
            this.lblCedulaIdentidadCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedulaIdentidadCliente.Name = "lblCedulaIdentidadCliente";
            this.lblCedulaIdentidadCliente.Size = new System.Drawing.Size(172, 28);
            this.lblCedulaIdentidadCliente.TabIndex = 198;
            this.lblCedulaIdentidadCliente.Text = "Cedula Identidad";
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.AllowUserToAddRows = false;
            this.dgvListaCliente.AllowUserToDeleteRows = false;
            this.dgvListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaCliente.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Location = new System.Drawing.Point(33, 39);
            this.dgvListaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaCliente.MultiSelect = false;
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.ReadOnly = true;
            this.dgvListaCliente.RowHeadersWidth = 51;
            this.dgvListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCliente.Size = new System.Drawing.Size(821, 366);
            this.dgvListaCliente.TabIndex = 0;
            // 
            // txtParametroCliente
            // 
            this.txtParametroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtParametroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroCliente.Location = new System.Drawing.Point(253, 94);
            this.txtParametroCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtParametroCliente.Name = "txtParametroCliente";
            this.txtParametroCliente.Size = new System.Drawing.Size(535, 34);
            this.txtParametroCliente.TabIndex = 192;
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.Tan;
            this.fondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fondo.Location = new System.Drawing.Point(13, 84);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(935, 60);
            this.fondo.TabIndex = 191;
            this.fondo.Text = "Buscar por Nombre:";
            this.fondo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloCLiente
            // 
            this.lblTituloCLiente.AutoSize = true;
            this.lblTituloCLiente.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCLiente.Location = new System.Drawing.Point(1024, 84);
            this.lblTituloCLiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCLiente.Name = "lblTituloCLiente";
            this.lblTituloCLiente.Size = new System.Drawing.Size(187, 35);
            this.lblTituloCLiente.TabIndex = 190;
            this.lblTituloCLiente.Text = "Detalle Cliente";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(-3, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1309, 57);
            this.lblTitulo.TabIndex = 187;
            this.lblTitulo.Text = "CLIENTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxLista
            // 
            this.gbxLista.BackColor = System.Drawing.Color.Transparent;
            this.gbxLista.Controls.Add(this.dgvListaCliente);
            this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(36, 166);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(4);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(4);
            this.gbxLista.Size = new System.Drawing.Size(879, 428);
            this.gbxLista.TabIndex = 189;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(971, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 209;
            this.label1.Text = "Segundo Apellido:";
            // 
            // txtSegundoApellidoCliente
            // 
            this.txtSegundoApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellidoCliente.Location = new System.Drawing.Point(976, 436);
            this.txtSegundoApellidoCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtSegundoApellidoCliente.MaxLength = 100;
            this.txtSegundoApellidoCliente.Name = "txtSegundoApellidoCliente";
            this.txtSegundoApellidoCliente.Size = new System.Drawing.Size(313, 26);
            this.txtSegundoApellidoCliente.TabIndex = 210;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(797, 94);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(143, 42);
            this.btnBuscar.TabIndex = 205;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1137, 505);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 52);
            this.btnCancelar.TabIndex = 197;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(975, 505);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 52);
            this.btnGuardar.TabIndex = 196;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(503, 603);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 58);
            this.btnEliminar.TabIndex = 195;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(683, 603);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(135, 58);
            this.btnCerrar.TabIndex = 194;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(324, 603);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(133, 58);
            this.btnEditar.TabIndex = 193;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(155, 603);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(131, 58);
            this.btnNuevo.TabIndex = 188;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1307, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSegundoApellidoCliente);
            this.Controls.Add(this.lblPrimerApellidosCliente);
            this.Controls.Add(this.txtPrimerApellidoCliente);
            this.Controls.Add(this.txtCedulaIdentidadCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombresCliente);
            this.Controls.Add(this.lblNombresCliente);
            this.Controls.Add(this.lblCedulaIdentidadCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtParametroCliente);
            this.Controls.Add(this.fondo);
            this.Controls.Add(this.lblTituloCLiente);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Restaurante - FrmCliente :::";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpSegundoApellidoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombresCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidadCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrimerApellidoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.gbxLista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimerApellidosCliente;
        private System.Windows.Forms.TextBox txtPrimerApellidoCliente;
        private System.Windows.Forms.TextBox txtCedulaIdentidadCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombresCliente;
        private System.Windows.Forms.Label lblNombresCliente;
        private System.Windows.Forms.Label lblCedulaIdentidadCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtParametroCliente;
        private System.Windows.Forms.Label fondo;
        private System.Windows.Forms.Label lblTituloCLiente;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.ErrorProvider erpSegundoApellidoCliente;
        private System.Windows.Forms.ErrorProvider erpNombresCliente;
        private System.Windows.Forms.ErrorProvider erpCedulaIdentidadCliente;
        private System.Windows.Forms.ErrorProvider erpPrimerApellidoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSegundoApellidoCliente;
    }
}