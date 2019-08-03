namespace ERPIntegra
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtArtVendidos = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblArtVen = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.tctCantidadR = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotalV = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.CBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPublico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(-1, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(1284, 26);
            this.textBox11.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSubtotal);
            this.groupBox1.Controls.Add(this.txtArtVendidos);
            this.groupBox1.Controls.Add(this.txtSubtotal);
            this.groupBox1.Controls.Add(this.lblArtVen);
            this.groupBox1.Controls.Add(this.txtIva);
            this.groupBox1.Controls.Add(this.tctCantidadR);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txtCambio);
            this.groupBox1.Controls.Add(this.lblCambio);
            this.groupBox1.Controls.Add(this.lblIva);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.lblDescuento);
            this.groupBox1.Controls.Add(this.lblTotalV);
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 625);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 201);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblSubtotal.Location = new System.Drawing.Point(8, 43);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(113, 26);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Sub Total";
            // 
            // txtArtVendidos
            // 
            this.txtArtVendidos.Enabled = false;
            this.txtArtVendidos.Location = new System.Drawing.Point(188, 149);
            this.txtArtVendidos.Name = "txtArtVendidos";
            this.txtArtVendidos.Size = new System.Drawing.Size(57, 32);
            this.txtArtVendidos.TabIndex = 16;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(188, 37);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 32);
            this.txtSubtotal.TabIndex = 6;
            // 
            // lblArtVen
            // 
            this.lblArtVen.AutoSize = true;
            this.lblArtVen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblArtVen.Location = new System.Drawing.Point(10, 155);
            this.lblArtVen.Name = "lblArtVen";
            this.lblArtVen.Size = new System.Drawing.Size(156, 26);
            this.lblArtVen.TabIndex = 15;
            this.lblArtVen.Text = "Art. Vendidos";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(188, 70);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 32);
            this.txtIva.TabIndex = 10;
            // 
            // tctCantidadR
            // 
            this.tctCantidadR.Location = new System.Drawing.Point(570, 75);
            this.tctCantidadR.Name = "tctCantidadR";
            this.tctCantidadR.Size = new System.Drawing.Size(100, 32);
            this.tctCantidadR.TabIndex = 12;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblCantidad.Location = new System.Drawing.Point(339, 75);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(198, 26);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad recibida";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(570, 109);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(100, 32);
            this.txtCambio.TabIndex = 14;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblCambio.Location = new System.Drawing.Point(340, 110);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(94, 26);
            this.lblCambio.TabIndex = 13;
            this.lblCambio.Text = "Cambio";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblIva.Location = new System.Drawing.Point(5, 73);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(51, 26);
            this.lblIva.TabIndex = 9;
            this.lblIva.Text = "IVA";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(188, 103);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 32);
            this.txtDescuento.TabIndex = 8;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblDescuento.Location = new System.Drawing.Point(4, 106);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(125, 26);
            this.lblDescuento.TabIndex = 7;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblTotalV
            // 
            this.lblTotalV.Enabled = false;
            this.lblTotalV.Location = new System.Drawing.Point(570, 39);
            this.lblTotalV.Name = "lblTotalV";
            this.lblTotalV.Size = new System.Drawing.Size(100, 32);
            this.lblTotalV.TabIndex = 4;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lbltotal.Location = new System.Drawing.Point(340, 42);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(129, 26);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total venta";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBarras,
            this.NProducto,
            this.Cantidad,
            this.PPublico,
            this.Descuento,
            this.STotal,
            this.Iva,
            this.Total});
            this.dgvVentas.Location = new System.Drawing.Point(0, 30);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowTemplate.Height = 28;
            this.dgvVentas.Size = new System.Drawing.Size(1283, 571);
            this.dgvVentas.TabIndex = 20;
            // 
            // CBarras
            // 
            this.CBarras.HeaderText = "Código Barras";
            this.CBarras.Name = "CBarras";
            // 
            // NProducto
            // 
            this.NProducto.HeaderText = "Nombre Producto";
            this.NProducto.Name = "NProducto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PPublico
            // 
            this.PPublico.HeaderText = "Precio Publico";
            this.PPublico.Name = "PPublico";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // STotal
            // 
            this.STotal.HeaderText = "Sub Total";
            this.STotal.Name = "STotal";
            // 
            // Iva
            // 
            this.Iva.HeaderText = "IVA";
            this.Iva.Name = "Iva";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1324, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 94);
            this.button1.TabIndex = 6;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1324, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 94);
            this.button2.TabIndex = 5;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1311, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 187);
            this.button3.TabIndex = 4;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1324, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 94);
            this.button4.TabIndex = 3;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1324, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 94);
            this.button5.TabIndex = 2;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1324, 103);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 94);
            this.button6.TabIndex = 1;
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblHora.Location = new System.Drawing.Point(834, 701);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(74, 37);
            this.lblHora.TabIndex = 24;
            this.lblHora.Text = "nnn";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblFecha.Location = new System.Drawing.Point(823, 627);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 37);
            this.lblFecha.TabIndex = 25;
            this.lblFecha.Text = "fecha";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1437, 840);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVenta_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmVenta_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtArtVendidos;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblArtVen;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox tctCantidadR;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox lblTotalV;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn NProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPublico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn STotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        public System.Windows.Forms.DataGridView dgvVentas;
    }
}