namespace ERPIntegra
{
    partial class frmAltaProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaProd));
            this.btnLaboratorio = new System.Windows.Forms.Button();
            this.gbPrecio = new System.Windows.Forms.GroupBox();
            this.lblPreciop = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtPreciop = new System.Windows.Forms.TextBox();
            this.lblPreciodes = new System.Windows.Forms.Label();
            this.txtDescesp = new System.Windows.Forms.TextBox();
            this.lblDescEsp = new System.Windows.Forms.Label();
            this.txtCostocom = new System.Windows.Forms.TextBox();
            this.lblCostocom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPzscaja = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtIndiceTerapeutico = new System.Windows.Forms.TextBox();
            this.lblIndice = new System.Windows.Forms.Label();
            this.cbxIVA = new System.Windows.Forms.ComboBox();
            this.txtCsat = new System.Windows.Forms.TextBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lblCsat = new System.Windows.Forms.Label();
            this.cbmLaboratorio = new System.Windows.Forms.ComboBox();
            this.cbmRack = new System.Windows.Forms.ComboBox();
            this.lblRack = new System.Windows.Forms.Label();
            this.cbmDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cbmProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.chkAntibiotico = new System.Windows.Forms.CheckBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.txtSustancia = new System.Windows.Forms.TextBox();
            this.lblSustancia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.gbPrecio.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaboratorio
            // 
            this.btnLaboratorio.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLaboratorio.FlatAppearance.BorderSize = 0;
            this.btnLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaboratorio.Image = ((System.Drawing.Image)(resources.GetObject("btnLaboratorio.Image")));
            this.btnLaboratorio.Location = new System.Drawing.Point(1084, 416);
            this.btnLaboratorio.Name = "btnLaboratorio";
            this.btnLaboratorio.Size = new System.Drawing.Size(183, 72);
            this.btnLaboratorio.TabIndex = 41;
            this.btnLaboratorio.UseVisualStyleBackColor = true;
            this.btnLaboratorio.Click += new System.EventHandler(this.btnLaboratorio_Click);
            // 
            // gbPrecio
            // 
            this.gbPrecio.Controls.Add(this.lblPreciop);
            this.gbPrecio.Controls.Add(this.txtdesc);
            this.gbPrecio.Controls.Add(this.txtPreciop);
            this.gbPrecio.Controls.Add(this.lblPreciodes);
            this.gbPrecio.Controls.Add(this.txtDescesp);
            this.gbPrecio.Controls.Add(this.lblDescEsp);
            this.gbPrecio.Controls.Add(this.txtCostocom);
            this.gbPrecio.Controls.Add(this.lblCostocom);
            this.gbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gbPrecio.Location = new System.Drawing.Point(34, 460);
            this.gbPrecio.Name = "gbPrecio";
            this.gbPrecio.Size = new System.Drawing.Size(999, 155);
            this.gbPrecio.TabIndex = 40;
            this.gbPrecio.TabStop = false;
            this.gbPrecio.Text = "Precios producto";
            // 
            // lblPreciop
            // 
            this.lblPreciop.AutoSize = true;
            this.lblPreciop.Location = new System.Drawing.Point(461, 45);
            this.lblPreciop.Name = "lblPreciop";
            this.lblPreciop.Size = new System.Drawing.Size(137, 22);
            this.lblPreciop.TabIndex = 28;
            this.lblPreciop.Text = "Precio publico";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(302, 99);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(74, 28);
            this.txtdesc.TabIndex = 31;
            // 
            // txtPreciop
            // 
            this.txtPreciop.Location = new System.Drawing.Point(659, 39);
            this.txtPreciop.Name = "txtPreciop";
            this.txtPreciop.Size = new System.Drawing.Size(80, 28);
            this.txtPreciop.TabIndex = 29;
            // 
            // lblPreciodes
            // 
            this.lblPreciodes.AutoSize = true;
            this.lblPreciodes.Location = new System.Drawing.Point(122, 99);
            this.lblPreciodes.Name = "lblPreciodes";
            this.lblPreciodes.Size = new System.Drawing.Size(110, 22);
            this.lblPreciodes.TabIndex = 30;
            this.lblPreciodes.Text = "Precio lista";
            // 
            // txtDescesp
            // 
            this.txtDescesp.Location = new System.Drawing.Point(661, 96);
            this.txtDescesp.Name = "txtDescesp";
            this.txtDescesp.Size = new System.Drawing.Size(78, 28);
            this.txtDescesp.TabIndex = 33;
            // 
            // lblDescEsp
            // 
            this.lblDescEsp.AutoSize = true;
            this.lblDescEsp.Location = new System.Drawing.Point(461, 99);
            this.lblDescEsp.Name = "lblDescEsp";
            this.lblDescEsp.Size = new System.Drawing.Size(185, 22);
            this.lblDescEsp.TabIndex = 32;
            this.lblDescEsp.Text = "Descuento especial";
            // 
            // txtCostocom
            // 
            this.txtCostocom.Location = new System.Drawing.Point(302, 39);
            this.txtCostocom.Name = "txtCostocom";
            this.txtCostocom.Size = new System.Drawing.Size(74, 28);
            this.txtCostocom.TabIndex = 27;
            // 
            // lblCostocom
            // 
            this.lblCostocom.AutoSize = true;
            this.lblCostocom.Location = new System.Drawing.Point(122, 45);
            this.lblCostocom.Name = "lblCostocom";
            this.lblCostocom.Size = new System.Drawing.Size(133, 22);
            this.lblCostocom.TabIndex = 26;
            this.lblCostocom.Text = "Costo compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Num pzs por caja";
            // 
            // txtPzscaja
            // 
            this.txtPzscaja.Location = new System.Drawing.Point(781, 295);
            this.txtPzscaja.Name = "txtPzscaja";
            this.txtPzscaja.Size = new System.Drawing.Size(71, 28);
            this.txtPzscaja.TabIndex = 39;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1084, 218);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(183, 72);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(1084, 117);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 72);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.lblIva);
            this.gbProducto.Controls.Add(this.txtIndiceTerapeutico);
            this.gbProducto.Controls.Add(this.lblIndice);
            this.gbProducto.Controls.Add(this.txtPzscaja);
            this.gbProducto.Controls.Add(this.label1);
            this.gbProducto.Controls.Add(this.cbxIVA);
            this.gbProducto.Controls.Add(this.txtCsat);
            this.gbProducto.Controls.Add(this.lblLaboratorio);
            this.gbProducto.Controls.Add(this.lblCsat);
            this.gbProducto.Controls.Add(this.cbmLaboratorio);
            this.gbProducto.Controls.Add(this.cbmRack);
            this.gbProducto.Controls.Add(this.lblRack);
            this.gbProducto.Controls.Add(this.cbmDepartamento);
            this.gbProducto.Controls.Add(this.lblDepartamento);
            this.gbProducto.Controls.Add(this.cbmProveedor);
            this.gbProducto.Controls.Add(this.lblProveedor);
            this.gbProducto.Controls.Add(this.chkAntibiotico);
            this.gbProducto.Controls.Add(this.txtPresentacion);
            this.gbProducto.Controls.Add(this.lblPresentacion);
            this.gbProducto.Controls.Add(this.txtSustancia);
            this.gbProducto.Controls.Add(this.lblSustancia);
            this.gbProducto.Controls.Add(this.txtNombre);
            this.gbProducto.Controls.Add(this.lblNombre);
            this.gbProducto.Controls.Add(this.txtCodigo);
            this.gbProducto.Controls.Add(this.lblCodigoBarras);
            this.gbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gbProducto.Location = new System.Drawing.Point(34, 34);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(999, 393);
            this.gbProducto.TabIndex = 36;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Características Producto";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(11, 299);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(41, 22);
            this.lblIva.TabIndex = 42;
            this.lblIva.Text = "IVA";
            // 
            // txtIndiceTerapeutico
            // 
            this.txtIndiceTerapeutico.Location = new System.Drawing.Point(646, 138);
            this.txtIndiceTerapeutico.Name = "txtIndiceTerapeutico";
            this.txtIndiceTerapeutico.Size = new System.Drawing.Size(281, 28);
            this.txtIndiceTerapeutico.TabIndex = 41;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(431, 138);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(169, 22);
            this.lblIndice.TabIndex = 40;
            this.lblIndice.Text = "Índice terapéutico";
            // 
            // cbxIVA
            // 
            this.cbxIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.cbxIVA.FormattingEnabled = true;
            this.cbxIVA.Items.AddRange(new object[] {
            "0",
            "16",
            "18"});
            this.cbxIVA.Location = new System.Drawing.Point(174, 294);
            this.cbxIVA.Name = "cbxIVA";
            this.cbxIVA.Size = new System.Drawing.Size(196, 30);
            this.cbxIVA.TabIndex = 25;
            // 
            // txtCsat
            // 
            this.txtCsat.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtCsat.Location = new System.Drawing.Point(174, 138);
            this.txtCsat.Name = "txtCsat";
            this.txtCsat.Size = new System.Drawing.Size(196, 28);
            this.txtCsat.TabIndex = 23;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Location = new System.Drawing.Point(11, 190);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(112, 22);
            this.lblLaboratorio.TabIndex = 10;
            this.lblLaboratorio.Text = "Laboratorio";
            // 
            // lblCsat
            // 
            this.lblCsat.AutoSize = true;
            this.lblCsat.Location = new System.Drawing.Point(11, 138);
            this.lblCsat.Name = "lblCsat";
            this.lblCsat.Size = new System.Drawing.Size(94, 22);
            this.lblCsat.TabIndex = 22;
            this.lblCsat.Text = "Clave sat";
            // 
            // cbmLaboratorio
            // 
            this.cbmLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.cbmLaboratorio.FormattingEnabled = true;
            this.cbmLaboratorio.Location = new System.Drawing.Point(174, 182);
            this.cbmLaboratorio.Name = "cbmLaboratorio";
            this.cbmLaboratorio.Size = new System.Drawing.Size(196, 30);
            this.cbmLaboratorio.TabIndex = 11;
            // 
            // cbmRack
            // 
            this.cbmRack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.cbmRack.FormattingEnabled = true;
            this.cbmRack.Location = new System.Drawing.Point(174, 239);
            this.cbmRack.Name = "cbmRack";
            this.cbmRack.Size = new System.Drawing.Size(196, 30);
            this.cbmRack.TabIndex = 21;
            // 
            // lblRack
            // 
            this.lblRack.AutoSize = true;
            this.lblRack.Location = new System.Drawing.Point(11, 242);
            this.lblRack.Name = "lblRack";
            this.lblRack.Size = new System.Drawing.Size(55, 22);
            this.lblRack.TabIndex = 20;
            this.lblRack.Text = "Rack";
            // 
            // cbmDepartamento
            // 
            this.cbmDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.cbmDepartamento.FormattingEnabled = true;
            this.cbmDepartamento.Location = new System.Drawing.Point(646, 187);
            this.cbmDepartamento.Name = "cbmDepartamento";
            this.cbmDepartamento.Size = new System.Drawing.Size(281, 30);
            this.cbmDepartamento.TabIndex = 19;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(433, 190);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 22);
            this.lblDepartamento.TabIndex = 18;
            this.lblDepartamento.Text = "Categoría";
            // 
            // cbmProveedor
            // 
            this.cbmProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.cbmProveedor.FormattingEnabled = true;
            this.cbmProveedor.Location = new System.Drawing.Point(646, 239);
            this.cbmProveedor.Name = "cbmProveedor";
            this.cbmProveedor.Size = new System.Drawing.Size(281, 30);
            this.cbmProveedor.TabIndex = 13;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(431, 236);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(102, 22);
            this.lblProveedor.TabIndex = 12;
            this.lblProveedor.Text = "Proveedor";
            // 
            // chkAntibiotico
            // 
            this.chkAntibiotico.AutoSize = true;
            this.chkAntibiotico.Location = new System.Drawing.Point(430, 295);
            this.chkAntibiotico.Name = "chkAntibiotico";
            this.chkAntibiotico.Size = new System.Drawing.Size(130, 26);
            this.chkAntibiotico.TabIndex = 9;
            this.chkAntibiotico.Text = "Antibiótico";
            this.chkAntibiotico.UseVisualStyleBackColor = true;
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Location = new System.Drawing.Point(646, 92);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(281, 28);
            this.txtPresentacion.TabIndex = 7;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(433, 88);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(127, 22);
            this.lblPresentacion.TabIndex = 6;
            this.lblPresentacion.Text = "Presentación";
            // 
            // txtSustancia
            // 
            this.txtSustancia.Location = new System.Drawing.Point(174, 91);
            this.txtSustancia.Name = "txtSustancia";
            this.txtSustancia.Size = new System.Drawing.Size(196, 28);
            this.txtSustancia.TabIndex = 5;
            // 
            // lblSustancia
            // 
            this.lblSustancia.AutoSize = true;
            this.lblSustancia.Location = new System.Drawing.Point(9, 91);
            this.lblSustancia.Name = "lblSustancia";
            this.lblSustancia.Size = new System.Drawing.Size(159, 22);
            this.lblSustancia.TabIndex = 4;
            this.lblSustancia.Text = "Sustancia Activa";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(646, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(281, 28);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(433, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(174, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(196, 28);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(9, 48);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(138, 22);
            this.lblCodigoBarras.TabIndex = 0;
            this.lblCodigoBarras.Text = "Codigo Barras";
            // 
            // btnProveedor
            // 
            this.btnProveedor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Image")));
            this.btnProveedor.Location = new System.Drawing.Point(1084, 318);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(183, 72);
            this.btnProveedor.TabIndex = 42;
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // frmAltaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1328, 691);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnLaboratorio);
            this.Controls.Add(this.gbPrecio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAltaProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta producto";
            this.Load += new System.EventHandler(this.frmAltaProd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAltaProd_KeyDown);
            this.gbPrecio.ResumeLayout(false);
            this.gbPrecio.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaboratorio;
        private System.Windows.Forms.GroupBox gbPrecio;
        private System.Windows.Forms.Label lblPreciop;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtPreciop;
        private System.Windows.Forms.Label lblPreciodes;
        private System.Windows.Forms.TextBox txtDescesp;
        private System.Windows.Forms.Label lblDescEsp;
        private System.Windows.Forms.TextBox txtCostocom;
        private System.Windows.Forms.Label lblCostocom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPzscaja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.ComboBox cbxIVA;
        private System.Windows.Forms.ComboBox cbmRack;
        private System.Windows.Forms.Label lblRack;
        private System.Windows.Forms.ComboBox cbmDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cbmProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbmLaboratorio;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.CheckBox chkAntibiotico;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.TextBox txtSustancia;
        private System.Windows.Forms.Label lblSustancia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.TextBox txtCsat;
        private System.Windows.Forms.Label lblCsat;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.TextBox txtIndiceTerapeutico;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblIva;
    }
}