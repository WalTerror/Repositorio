namespace ERPIntegra
{
    partial class frmIntegra
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntegra));
            this.pnlInformativo = new System.Windows.Forms.Panel();
            this.pboxPanel2 = new System.Windows.Forms.PictureBox();
            this.pboxPanel1 = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlVenta = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnArqueoc = new System.Windows.Forms.Button();
            this.btnIngresov = new System.Windows.Forms.Button();
            this.btnRetiroc = new System.Windows.Forms.Button();
            this.btnCorteC = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnFondoC = new System.Windows.Forms.Button();
            this.mnuGeneral = new System.Windows.Forms.MenuStrip();
            this.mnuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.subClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.subDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.subProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.subProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.subCatalogoProd = new System.Windows.Forms.ToolStripMenuItem();
            this.subAltaProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.subUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.subPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventarios = new System.Windows.Forms.ToolStripMenuItem();
            this.subInvrack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.subDepto = new System.Windows.Forms.ToolStripMenuItem();
            this.subLaboratorio = new System.Windows.Forms.ToolStripMenuItem();
            this.subFarmacia = new System.Windows.Forms.ToolStripMenuItem();
            this.subCargaInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.subAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrImagen = new System.Windows.Forms.Timer(this.components);
            this.listimgCarga = new System.Windows.Forms.ImageList(this.components);
            this.pnlInformativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPanel1)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.pnlVenta.SuspendLayout();
            this.mnuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformativo
            // 
            this.pnlInformativo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlInformativo.Controls.Add(this.pboxPanel2);
            this.pnlInformativo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInformativo.Location = new System.Drawing.Point(915, 166);
            this.pnlInformativo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlInformativo.Name = "pnlInformativo";
            this.pnlInformativo.Size = new System.Drawing.Size(408, 654);
            this.pnlInformativo.TabIndex = 9;
            // 
            // pboxPanel2
            // 
            this.pboxPanel2.Location = new System.Drawing.Point(17, 20);
            this.pboxPanel2.Name = "pboxPanel2";
            this.pboxPanel2.Size = new System.Drawing.Size(348, 223);
            this.pboxPanel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxPanel2.TabIndex = 0;
            this.pboxPanel2.TabStop = false;
            this.pboxPanel2.DoubleClick += new System.EventHandler(this.pboxPanel2_DoubleClick);
            // 
            // pboxPanel1
            // 
            this.pboxPanel1.Image = ((System.Drawing.Image)(resources.GetObject("pboxPanel1.Image")));
            this.pboxPanel1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pboxPanel1.InitialImage")));
            this.pboxPanel1.Location = new System.Drawing.Point(192, 131);
            this.pboxPanel1.Name = "pboxPanel1";
            this.pboxPanel1.Size = new System.Drawing.Size(644, 248);
            this.pboxPanel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxPanel1.TabIndex = 0;
            this.pboxPanel1.TabStop = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlContenedor.Controls.Add(this.pboxPanel1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 166);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1323, 654);
            this.pnlContenedor.TabIndex = 8;
            // 
            // pnlVenta
            // 
            this.pnlVenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVenta.Controls.Add(this.txtid);
            this.pnlVenta.Controls.Add(this.btnArqueoc);
            this.pnlVenta.Controls.Add(this.btnIngresov);
            this.pnlVenta.Controls.Add(this.btnRetiroc);
            this.pnlVenta.Controls.Add(this.btnCorteC);
            this.pnlVenta.Controls.Add(this.btnVenta);
            this.pnlVenta.Controls.Add(this.btnFondoC);
            this.pnlVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVenta.Location = new System.Drawing.Point(0, 34);
            this.pnlVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Size = new System.Drawing.Size(1323, 132);
            this.pnlVenta.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(1194, 38);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 26);
            this.txtid.TabIndex = 1;
            // 
            // btnArqueoc
            // 
            this.btnArqueoc.Enabled = false;
            this.btnArqueoc.FlatAppearance.BorderSize = 0;
            this.btnArqueoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArqueoc.Image = ((System.Drawing.Image)(resources.GetObject("btnArqueoc.Image")));
            this.btnArqueoc.Location = new System.Drawing.Point(643, 4);
            this.btnArqueoc.Name = "btnArqueoc";
            this.btnArqueoc.Size = new System.Drawing.Size(169, 120);
            this.btnArqueoc.TabIndex = 5;
            this.btnArqueoc.UseVisualStyleBackColor = true;
            this.btnArqueoc.Click += new System.EventHandler(this.btnArqueoc_Click);
            // 
            // btnIngresov
            // 
            this.btnIngresov.Enabled = false;
            this.btnIngresov.FlatAppearance.BorderSize = 0;
            this.btnIngresov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresov.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresov.Image")));
            this.btnIngresov.Location = new System.Drawing.Point(478, 4);
            this.btnIngresov.Name = "btnIngresov";
            this.btnIngresov.Size = new System.Drawing.Size(169, 120);
            this.btnIngresov.TabIndex = 4;
            this.btnIngresov.UseVisualStyleBackColor = true;
            this.btnIngresov.Click += new System.EventHandler(this.btnIngresov_Click);
            // 
            // btnRetiroc
            // 
            this.btnRetiroc.Enabled = false;
            this.btnRetiroc.FlatAppearance.BorderSize = 0;
            this.btnRetiroc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetiroc.Image = ((System.Drawing.Image)(resources.GetObject("btnRetiroc.Image")));
            this.btnRetiroc.Location = new System.Drawing.Point(314, 5);
            this.btnRetiroc.Name = "btnRetiroc";
            this.btnRetiroc.Size = new System.Drawing.Size(169, 120);
            this.btnRetiroc.TabIndex = 3;
            this.btnRetiroc.UseVisualStyleBackColor = true;
            this.btnRetiroc.Click += new System.EventHandler(this.btnRetiroc_Click);
            // 
            // btnCorteC
            // 
            this.btnCorteC.Enabled = false;
            this.btnCorteC.FlatAppearance.BorderSize = 0;
            this.btnCorteC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorteC.Image = ((System.Drawing.Image)(resources.GetObject("btnCorteC.Image")));
            this.btnCorteC.Location = new System.Drawing.Point(813, 4);
            this.btnCorteC.Name = "btnCorteC";
            this.btnCorteC.Size = new System.Drawing.Size(169, 120);
            this.btnCorteC.TabIndex = 2;
            this.btnCorteC.UseVisualStyleBackColor = true;
            this.btnCorteC.Click += new System.EventHandler(this.btnCorteC_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Enabled = false;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnVenta.Image")));
            this.btnVenta.Location = new System.Drawing.Point(151, 5);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(169, 120);
            this.btnVenta.TabIndex = 1;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnFondoC
            // 
            this.btnFondoC.Enabled = false;
            this.btnFondoC.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFondoC.FlatAppearance.BorderSize = 0;
            this.btnFondoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFondoC.Image = ((System.Drawing.Image)(resources.GetObject("btnFondoC.Image")));
            this.btnFondoC.Location = new System.Drawing.Point(-7, 5);
            this.btnFondoC.Name = "btnFondoC";
            this.btnFondoC.Size = new System.Drawing.Size(169, 120);
            this.btnFondoC.TabIndex = 0;
            this.btnFondoC.UseVisualStyleBackColor = true;
            this.btnFondoC.Click += new System.EventHandler(this.btnFondoC_Click);
            // 
            // mnuGeneral
            // 
            this.mnuGeneral.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.mnuGeneral.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministracion,
            this.mnuMovimientos,
            this.mnuReportes,
            this.mnuInventarios,
            this.mnuConfiguracion});
            this.mnuGeneral.Location = new System.Drawing.Point(0, 0);
            this.mnuGeneral.Name = "mnuGeneral";
            this.mnuGeneral.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnuGeneral.Size = new System.Drawing.Size(1323, 34);
            this.mnuGeneral.TabIndex = 6;
            this.mnuGeneral.Text = "menuStrip1";
            // 
            // mnuAdministracion
            // 
            this.mnuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subClientes,
            this.subDoctor,
            this.subProveedor,
            this.subProductos,
            this.subUsuario});
            this.mnuAdministracion.Enabled = false;
            this.mnuAdministracion.Name = "mnuAdministracion";
            this.mnuAdministracion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.mnuAdministracion.Size = new System.Drawing.Size(141, 28);
            this.mnuAdministracion.Text = "&Administracion";
            // 
            // subClientes
            // 
            this.subClientes.Enabled = false;
            this.subClientes.Name = "subClientes";
            this.subClientes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.subClientes.Size = new System.Drawing.Size(233, 30);
            this.subClientes.Text = "&Clientes";
            this.subClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // subDoctor
            // 
            this.subDoctor.Enabled = false;
            this.subDoctor.Name = "subDoctor";
            this.subDoctor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.subDoctor.Size = new System.Drawing.Size(233, 30);
            this.subDoctor.Text = "&Doctor";
            this.subDoctor.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // subProveedor
            // 
            this.subProveedor.Enabled = false;
            this.subProveedor.Name = "subProveedor";
            this.subProveedor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.subProveedor.Size = new System.Drawing.Size(233, 30);
            this.subProveedor.Text = "&Proveedor";
            this.subProveedor.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // subProductos
            // 
            this.subProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subCatalogoProd,
            this.subAltaProductos});
            this.subProductos.Enabled = false;
            this.subProductos.Name = "subProductos";
            this.subProductos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.subProductos.Size = new System.Drawing.Size(233, 30);
            this.subProductos.Text = "Produc&tos";
            // 
            // subCatalogoProd
            // 
            this.subCatalogoProd.Enabled = false;
            this.subCatalogoProd.Name = "subCatalogoProd";
            this.subCatalogoProd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.subCatalogoProd.Size = new System.Drawing.Size(305, 30);
            this.subCatalogoProd.Text = "Catalogo Productos";
            this.subCatalogoProd.Click += new System.EventHandler(this.catalogoProductosToolStripMenuItem_Click);
            // 
            // subAltaProductos
            // 
            this.subAltaProductos.Enabled = false;
            this.subAltaProductos.Name = "subAltaProductos";
            this.subAltaProductos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.subAltaProductos.Size = new System.Drawing.Size(305, 30);
            this.subAltaProductos.Text = "&Alta Producto";
            this.subAltaProductos.Click += new System.EventHandler(this.altaProductoToolStripMenuItem_Click);
            // 
            // subUsuario
            // 
            this.subUsuario.Enabled = false;
            this.subUsuario.Name = "subUsuario";
            this.subUsuario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.subUsuario.Size = new System.Drawing.Size(233, 30);
            this.subUsuario.Text = "&Usuario";
            this.subUsuario.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // mnuMovimientos
            // 
            this.mnuMovimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subPedido});
            this.mnuMovimientos.Enabled = false;
            this.mnuMovimientos.Name = "mnuMovimientos";
            this.mnuMovimientos.Size = new System.Drawing.Size(126, 28);
            this.mnuMovimientos.Text = "&Movimientos";
            // 
            // subPedido
            // 
            this.subPedido.Enabled = false;
            this.subPedido.Name = "subPedido";
            this.subPedido.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.subPedido.Size = new System.Drawing.Size(202, 30);
            this.subPedido.Text = "&Pedido";
            this.subPedido.Click += new System.EventHandler(this.entradaOrdenToolStripMenuItem_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.Enabled = false;
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(93, 28);
            this.mnuReportes.Text = "&Reportes";
            // 
            // mnuInventarios
            // 
            this.mnuInventarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subInvrack});
            this.mnuInventarios.Enabled = false;
            this.mnuInventarios.Name = "mnuInventarios";
            this.mnuInventarios.Size = new System.Drawing.Size(109, 28);
            this.mnuInventarios.Text = "&Inventarios";
            // 
            // subInvrack
            // 
            this.subInvrack.Enabled = false;
            this.subInvrack.Name = "subInvrack";
            this.subInvrack.Size = new System.Drawing.Size(241, 30);
            this.subInvrack.Text = "Inventario por rack";
            // 
            // mnuConfiguracion
            // 
            this.mnuConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subDepto,
            this.subLaboratorio,
            this.subFarmacia,
            this.subCargaInformacion,
            this.subAyuda});
            this.mnuConfiguracion.Enabled = false;
            this.mnuConfiguracion.Name = "mnuConfiguracion";
            this.mnuConfiguracion.Size = new System.Drawing.Size(133, 28);
            this.mnuConfiguracion.Text = "&Configuración";
            // 
            // subDepto
            // 
            this.subDepto.Enabled = false;
            this.subDepto.Name = "subDepto";
            this.subDepto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.subDepto.Size = new System.Drawing.Size(318, 30);
            this.subDepto.Text = "Categoría y &Rack";
            this.subDepto.Click += new System.EventHandler(this.departamentoYRackToolStripMenuItem_Click);
            // 
            // subLaboratorio
            // 
            this.subLaboratorio.Enabled = false;
            this.subLaboratorio.Name = "subLaboratorio";
            this.subLaboratorio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.subLaboratorio.Size = new System.Drawing.Size(318, 30);
            this.subLaboratorio.Text = "&Laboratorio";
            this.subLaboratorio.Click += new System.EventHandler(this.laboratorioToolStripMenuItem_Click);
            // 
            // subFarmacia
            // 
            this.subFarmacia.Enabled = false;
            this.subFarmacia.Name = "subFarmacia";
            this.subFarmacia.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.subFarmacia.Size = new System.Drawing.Size(318, 30);
            this.subFarmacia.Text = "Datos &Farmacia";
            this.subFarmacia.Click += new System.EventHandler(this.datosFarmaciaToolStripMenuItem_Click);
            // 
            // subCargaInformacion
            // 
            this.subCargaInformacion.Enabled = false;
            this.subCargaInformacion.Name = "subCargaInformacion";
            this.subCargaInformacion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.subCargaInformacion.Size = new System.Drawing.Size(318, 30);
            this.subCargaInformacion.Text = "Carga de &Información";
            this.subCargaInformacion.Click += new System.EventHandler(this.cargaDeInformaciónToolStripMenuItem_Click);
            // 
            // subAyuda
            // 
            this.subAyuda.Enabled = false;
            this.subAyuda.Name = "subAyuda";
            this.subAyuda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.subAyuda.Size = new System.Drawing.Size(318, 30);
            this.subAyuda.Text = "&Ayuda";
            // 
            // tmrImagen
            // 
            this.tmrImagen.Enabled = true;
            this.tmrImagen.Interval = 4000;
            this.tmrImagen.Tick += new System.EventHandler(this.tmrImagen_Tick);
            // 
            // listimgCarga
            // 
            this.listimgCarga.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listimgCarga.ImageStream")));
            this.listimgCarga.TransparentColor = System.Drawing.Color.Transparent;
            this.listimgCarga.Images.SetKeyName(0, "1.png");
            this.listimgCarga.Images.SetKeyName(1, "2.png");
            this.listimgCarga.Images.SetKeyName(2, "3.png");
            this.listimgCarga.Images.SetKeyName(3, "4.png");
            this.listimgCarga.Images.SetKeyName(4, "5.png");
            this.listimgCarga.Images.SetKeyName(5, "6.png");
            // 
            // frmIntegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 820);
            this.Controls.Add(this.pnlInformativo);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlVenta);
            this.Controls.Add(this.mnuGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuGeneral;
            this.Name = "frmIntegra";
            this.Text = "ERP-Integra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIntegra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIntegra_KeyDown);
            this.pnlInformativo.ResumeLayout(false);
            this.pnlInformativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPanel1)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlVenta.ResumeLayout(false);
            this.pnlVenta.PerformLayout();
            this.mnuGeneral.ResumeLayout(false);
            this.mnuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformativo;
        private System.Windows.Forms.PictureBox pboxPanel1;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlVenta;
        private System.Windows.Forms.MenuStrip mnuGeneral;
        private System.Windows.Forms.PictureBox pboxPanel2;
        private System.Windows.Forms.Timer tmrImagen;
        private System.Windows.Forms.ImageList listimgCarga;
        public System.Windows.Forms.Button btnArqueoc;
        public System.Windows.Forms.Button btnIngresov;
        public System.Windows.Forms.Button btnRetiroc;
        public System.Windows.Forms.Button btnCorteC;
        public System.Windows.Forms.Button btnVenta;
        public System.Windows.Forms.Button btnFondoC;
        public System.Windows.Forms.ToolStripMenuItem mnuAdministracion;
        public System.Windows.Forms.ToolStripMenuItem subClientes;
        public System.Windows.Forms.ToolStripMenuItem subDoctor;
        public System.Windows.Forms.ToolStripMenuItem subProveedor;
        public System.Windows.Forms.ToolStripMenuItem subAltaProductos;
        public System.Windows.Forms.ToolStripMenuItem subCatalogoProd;
        public System.Windows.Forms.ToolStripMenuItem subUsuario;
        public System.Windows.Forms.ToolStripMenuItem mnuInventarios;
        public System.Windows.Forms.ToolStripMenuItem mnuReportes;
        public System.Windows.Forms.ToolStripMenuItem mnuConfiguracion;
        public System.Windows.Forms.ToolStripMenuItem subDepto;
        public System.Windows.Forms.ToolStripMenuItem subLaboratorio;
        public System.Windows.Forms.ToolStripMenuItem subFarmacia;
        public System.Windows.Forms.ToolStripMenuItem subCargaInformacion;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.ToolStripMenuItem mnuMovimientos;
        public System.Windows.Forms.ToolStripMenuItem subPedido;
        public System.Windows.Forms.ToolStripMenuItem subAyuda;
        public System.Windows.Forms.ToolStripMenuItem subProductos;
        public System.Windows.Forms.ToolStripMenuItem subInvrack;

    }
}

