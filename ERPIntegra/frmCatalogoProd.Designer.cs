namespace ERPIntegra
{
    partial class frmCatalogoProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogoProd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUSTNACIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRESENTACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LABORATORIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(859, 561);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(183, 72);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(648, 561);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 72);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.txtProducto);
            this.gbProducto.Controls.Add(this.lblCodigo);
            this.gbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gbProducto.Location = new System.Drawing.Point(55, 33);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(942, 123);
            this.gbProducto.TabIndex = 9;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(241, 58);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(530, 26);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(65, 61);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(158, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Datos de producto";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRE,
            this.SUSTNACIA,
            this.PRESENTACION,
            this.PRECIO,
            this.IVA,
            this.PROVEEDOR,
            this.PROVEEDOR_ID,
            this.CATEGORIA,
            this.LABORATORIO});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducto.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducto.Location = new System.Drawing.Point(19, 195);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowTemplate.Height = 28;
            this.dgvProducto.Size = new System.Drawing.Size(1032, 312);
            this.dgvProducto.TabIndex = 8;
            this.dgvProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellDoubleClick);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // SUSTNACIA
            // 
            this.SUSTNACIA.DataPropertyName = "SUSTANCIA";
            this.SUSTNACIA.HeaderText = "SUSTANCIA";
            this.SUSTNACIA.Name = "SUSTNACIA";
            this.SUSTNACIA.ReadOnly = true;
            // 
            // PRESENTACION
            // 
            this.PRESENTACION.DataPropertyName = "PRESENTACION";
            this.PRESENTACION.HeaderText = "PRESENTACION";
            this.PRESENTACION.Name = "PRESENTACION";
            this.PRESENTACION.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PRECIO";
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "IVA";
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.DataPropertyName = "PROVEEDOR";
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            this.PROVEEDOR.ReadOnly = true;
            // 
            // PROVEEDOR_ID
            // 
            this.PROVEEDOR_ID.DataPropertyName = "PROVEEDOR_ID";
            this.PROVEEDOR_ID.HeaderText = "PROVEEDOR_ID";
            this.PROVEEDOR_ID.Name = "PROVEEDOR_ID";
            this.PROVEEDOR_ID.ReadOnly = true;
            this.PROVEEDOR_ID.Visible = false;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // LABORATORIO
            // 
            this.LABORATORIO.DataPropertyName = "LABORATORIO";
            this.LABORATORIO.HeaderText = "LABORATORIO";
            this.LABORATORIO.Name = "LABORATORIO";
            this.LABORATORIO.ReadOnly = true;
            // 
            // frmCatalogoProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1081, 675);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.dgvProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCatalogoProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de productos";
            this.Load += new System.EventHandler(this.frmCatalogoProd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCatalogoProd_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCatalogoProd_KeyPress);
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUSTNACIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRESENTACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LABORATORIO;
    }
}