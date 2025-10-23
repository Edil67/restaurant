namespace CpRestaurante
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup11 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaTipoMenu = new C1.Win.Ribbon.RibbonButton();
            this.btnCaMenu = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaCliente = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonTab3 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup5 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaPedidos = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup8 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaPedidosDetalle = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonButton2 = new C1.Win.Ribbon.RibbonButton();
            this.btnCaClientes = new C1.Win.Ribbon.RibbonButton();
            this.pctPrincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1168, 201);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup11);
            this.ribbonTab1.Groups.Add(this.ribbonGroup2);
            this.ribbonTab1.Groups.Add(this.ribbonGroup3);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "CÁTALOGO";
            // 
            // ribbonGroup11
            // 
            this.ribbonGroup11.Items.Add(this.btnCaTipoMenu);
            this.ribbonGroup11.Items.Add(this.btnCaMenu);
            this.ribbonGroup11.Name = "ribbonGroup11";
            // 
            // btnCaTipoMenu
            // 
            this.btnCaTipoMenu.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaTipoMenu.IconSet")))));
            this.btnCaTipoMenu.Name = "btnCaTipoMenu";
            this.btnCaTipoMenu.Text = "CATEGORIA";
            this.btnCaTipoMenu.Click += new System.EventHandler(this.btnCaTipoMenu_Click);
            // 
            // btnCaMenu
            // 
            this.btnCaMenu.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaMenu.IconSet")))));
            this.btnCaMenu.Name = "btnCaMenu";
            this.btnCaMenu.Text = "MENU";
            this.btnCaMenu.Click += new System.EventHandler(this.btnCaMenu_Click);
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("ribbonGroup2.IconSet")))));
            this.ribbonGroup2.Items.Add(this.btnCaCliente);
            this.ribbonGroup2.Name = "ribbonGroup2";
            // 
            // btnCaCliente
            // 
            this.btnCaCliente.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaCliente.IconSet")))));
            this.btnCaCliente.Name = "btnCaCliente";
            this.btnCaCliente.Text = "CLIENTES";
            this.btnCaCliente.Click += new System.EventHandler(this.btnCaCliente_Click);
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Name = "ribbonGroup3";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup4);
            this.ribbonTab2.Name = "ribbonTab2";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Group";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup5);
            this.ribbonTab3.Groups.Add(this.ribbonGroup8);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "VENTA";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("ribbonGroup5.IconSet")))));
            this.ribbonGroup5.Items.Add(this.btnCaPedidos);
            this.ribbonGroup5.Name = "ribbonGroup5";
            // 
            // btnCaPedidos
            // 
            this.btnCaPedidos.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaPedidos.IconSet")))));
            this.btnCaPedidos.Name = "btnCaPedidos";
            this.btnCaPedidos.Text = "PEDIDOS";
            this.btnCaPedidos.Click += new System.EventHandler(this.btnCaPedidos_Click);
            // 
            // ribbonGroup8
            // 
            this.ribbonGroup8.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(100, 100), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("ribbonGroup8.IconSet")))));
            this.ribbonGroup8.Items.Add(this.btnCaPedidosDetalle);
            this.ribbonGroup8.Name = "ribbonGroup8";
            // 
            // btnCaPedidosDetalle
            // 
            this.btnCaPedidosDetalle.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(100, 100), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaPedidosDetalle.IconSet")))));
            this.btnCaPedidosDetalle.Name = "btnCaPedidosDetalle";
            this.btnCaPedidosDetalle.Text = "PEDIDO DETALLES";
            this.btnCaPedidosDetalle.Click += new System.EventHandler(this.btnCaPedidosDetalle_Click);
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Name = "ribbonGroup1";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.Text = "PRODUCTOS";
            // 
            // btnCaClientes
            // 
            this.btnCaClientes.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaClientes.Name = "btnCaClientes";
            this.btnCaClientes.Text = "CLIENTES";
            // 
            // pctPrincipal
            // 
            this.pctPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pctPrincipal.Image")));
            this.pctPrincipal.Location = new System.Drawing.Point(0, 199);
            this.pctPrincipal.Name = "pctPrincipal";
            this.pctPrincipal.Size = new System.Drawing.Size(1168, 443);
            this.pctPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPrincipal.TabIndex = 1;
            this.pctPrincipal.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1168, 643);
            this.Controls.Add(this.pctPrincipal);
            this.Controls.Add(this.c1Ribbon1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup11;
        private C1.Win.Ribbon.RibbonButton btnCaTipoMenu;
        private C1.Win.Ribbon.RibbonButton btnCaMenu;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonButton btnCaCliente;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonTab ribbonTab2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.Ribbon.RibbonTab ribbonTab3;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.Ribbon.RibbonButton btnCaPedidos;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup8;
        private C1.Win.Ribbon.RibbonButton btnCaPedidosDetalle;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonButton ribbonButton2;
        private C1.Win.Ribbon.RibbonButton btnCaClientes;
        private System.Windows.Forms.PictureBox pctPrincipal;
    }
}