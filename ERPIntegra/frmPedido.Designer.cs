namespace ERPIntegra
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvProductoEntrada = new System.Windows.Forms.DataGridView();
            this.IDPROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCIÓN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXISTENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PZASUGERIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PZAPEDIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtPSugerido = new System.Windows.Forms.RadioButton();
            this.rbtPManual = new System.Windows.Forms.RadioButton();
            this.btnEnviarP = new System.Windows.Forms.Button();
            this.txtTotalPedido = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPza = new System.Windows.Forms.TextBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoEntrada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(721, 474);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 47);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(525, 474);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 47);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvProductoEntrada
            // 
            this.dgvProductoEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductoEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPROVEEDOR,
            this.CODIGO,
            this.DESCRIPCIÓN,
            this.PROVEEDOR,
            this.PRECIO,
            this.IVA,
            this.TOTALIVA,
            this.EXISTENCIA,
            this.PZASUGERIDA,
            this.PZAPEDIR,
            this.STOTAL,
            this.TOTALP});
            this.dgvProductoEntrada.Location = new System.Drawing.Point(24, 122);
            this.dgvProductoEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductoEntrada.Name = "dgvProductoEntrada";
            this.dgvProductoEntrada.RowHeadersVisible = false;
            this.dgvProductoEntrada.RowTemplate.Height = 28;
            this.dgvProductoEntrada.Size = new System.Drawing.Size(951, 285);
            this.dgvProductoEntrada.TabIndex = 49;
            this.dgvProductoEntrada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductoEntrada_CellDoubleClick);
            this.dgvProductoEntrada.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductoEntrada_CellValueChanged);
            this.dgvProductoEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProductoEntrada_KeyDown);
            // 
            // IDPROVEEDOR
            // 
            this.IDPROVEEDOR.DataPropertyName = "ID_PROV";
            this.IDPROVEEDOR.HeaderText = "ID_PROVEEDOR";
            this.IDPROVEEDOR.Name = "IDPROVEEDOR";
            this.IDPROVEEDOR.Visible = false;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // DESCRIPCIÓN
            // 
            this.DESCRIPCIÓN.DataPropertyName = "DESCRIPCIÓN";
            this.DESCRIPCIÓN.HeaderText = "DESCRIPCIÓN";
            this.DESCRIPCIÓN.Name = "DESCRIPCIÓN";
            this.DESCRIPCIÓN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DESCRIPCIÓN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.DataPropertyName = "PROVEEDOR";
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            this.PROVEEDOR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PROVEEDOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PRECIO";
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "IVA";
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            // 
            // TOTALIVA
            // 
            this.TOTALIVA.DataPropertyName = "TOTALIVA";
            this.TOTALIVA.HeaderText = "TOTALIVA";
            this.TOTALIVA.Name = "TOTALIVA";
            this.TOTALIVA.Visible = false;
            // 
            // EXISTENCIA
            // 
            this.EXISTENCIA.DataPropertyName = "EXISTENCIA";
            this.EXISTENCIA.HeaderText = "EXISTENCIA";
            this.EXISTENCIA.Name = "EXISTENCIA";
            // 
            // PZASUGERIDA
            // 
            this.PZASUGERIDA.HeaderText = "PZA.SUGERIDAS";
            this.PZASUGERIDA.Name = "PZASUGERIDA";
            this.PZASUGERIDA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PZASUGERIDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PZAPEDIR
            // 
            this.PZAPEDIR.HeaderText = "PZAS.PEDIR";
            this.PZAPEDIR.Name = "PZAPEDIR";
            this.PZAPEDIR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PZAPEDIR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // STOTAL
            // 
            this.STOTAL.HeaderText = "STOTAL";
            this.STOTAL.Name = "STOTAL";
            this.STOTAL.Visible = false;
            // 
            // TOTALP
            // 
            this.TOTALP.HeaderText = "TOTAL";
            this.TOTALP.Name = "TOTALP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtPSugerido);
            this.groupBox1.Controls.Add(this.rbtPManual);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.groupBox1.Location = new System.Drawing.Point(45, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(745, 77);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar pedido";
            // 
            // rbtPSugerido
            // 
            this.rbtPSugerido.AutoSize = true;
            this.rbtPSugerido.Location = new System.Drawing.Point(204, 31);
            this.rbtPSugerido.Margin = new System.Windows.Forms.Padding(2);
            this.rbtPSugerido.Name = "rbtPSugerido";
            this.rbtPSugerido.Size = new System.Drawing.Size(197, 29);
            this.rbtPSugerido.TabIndex = 1;
            this.rbtPSugerido.Text = "Pedido Sugerido";
            this.rbtPSugerido.UseVisualStyleBackColor = true;
            this.rbtPSugerido.CheckedChanged += new System.EventHandler(this.rbtPSugerido_CheckedChanged);
            this.rbtPSugerido.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtPSugerido_MouseClick);
            // 
            // rbtPManual
            // 
            this.rbtPManual.AutoSize = true;
            this.rbtPManual.Location = new System.Drawing.Point(480, 31);
            this.rbtPManual.Margin = new System.Windows.Forms.Padding(2);
            this.rbtPManual.Name = "rbtPManual";
            this.rbtPManual.Size = new System.Drawing.Size(180, 29);
            this.rbtPManual.TabIndex = 0;
            this.rbtPManual.TabStop = true;
            this.rbtPManual.Text = "Pedido manual";
            this.rbtPManual.UseVisualStyleBackColor = true;
            this.rbtPManual.CheckedChanged += new System.EventHandler(this.rbtPManual_CheckedChanged);
            this.rbtPManual.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtPManual_MouseClick);
            // 
            // btnEnviarP
            // 
            this.btnEnviarP.FlatAppearance.BorderSize = 0;
            this.btnEnviarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.btnEnviarP.Location = new System.Drawing.Point(343, 477);
            this.btnEnviarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviarP.Name = "btnEnviarP";
            this.btnEnviarP.Size = new System.Drawing.Size(142, 47);
            this.btnEnviarP.TabIndex = 51;
            this.btnEnviarP.Text = "Enviar Pedido";
            this.btnEnviarP.UseVisualStyleBackColor = true;
            this.btnEnviarP.Click += new System.EventHandler(this.btnEnviarP_Click);
            // 
            // txtTotalPedido
            // 
            this.txtTotalPedido.Location = new System.Drawing.Point(168, 480);
            this.txtTotalPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPedido.Name = "txtTotalPedido";
            this.txtTotalPedido.Size = new System.Drawing.Size(77, 26);
            this.txtTotalPedido.TabIndex = 52;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(168, 449);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(77, 26);
            this.txtsubtotal.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(25, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 54;
            this.label1.Text = "SUB.TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(25, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 55;
            this.label2.Text = "TOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(25, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "Total pza";
            // 
            // txtPza
            // 
            this.txtPza.Location = new System.Drawing.Point(168, 511);
            this.txtPza.Name = "txtPza";
            this.txtPza.Size = new System.Drawing.Size(77, 26);
            this.txtPza.TabIndex = 56;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.Location = new System.Drawing.Point(880, 460);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(87, 74);
            this.btnProductos.TabIndex = 59;
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Visible = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(25, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "IVA";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(168, 417);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(77, 26);
            this.txtIva.TabIndex = 60;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(833, 45);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(142, 47);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 419);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 63;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1013, 586);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txtTotalPedido);
            this.Controls.Add(this.btnEnviarP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductoEntrada);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frmEntradaProd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEntradaProd_KeyDown_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPedido_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoEntrada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtPSugerido;
        private System.Windows.Forms.RadioButton rbtPManual;
        private System.Windows.Forms.Button btnEnviarP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCIÓN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXISTENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PZASUGERIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PZAPEDIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALP;
        private System.Windows.Forms.Button btnProductos;
        public System.Windows.Forms.DataGridView dgvProductoEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtTotalPedido;
        public System.Windows.Forms.TextBox txtsubtotal;
        public System.Windows.Forms.TextBox txtPza;
        public System.Windows.Forms.TextBox txtIva;
        public System.Windows.Forms.TextBox textBox1;
    }
}