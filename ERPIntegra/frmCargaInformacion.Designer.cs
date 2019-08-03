namespace ERPIntegra
{
    partial class frmCargaInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaInformacion));
            this.gbCargaInfromacion = new System.Windows.Forms.GroupBox();
            this.rbtnDoctor = new System.Windows.Forms.RadioButton();
            this.rbtnProducto = new System.Windows.Forms.RadioButton();
            this.rbtnCliente = new System.Windows.Forms.RadioButton();
            this.rbtnProveedor = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvCargaInformacion = new System.Windows.Forms.DataGridView();
            this.gbCargaInfromacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCargaInfromacion
            // 
            this.gbCargaInfromacion.Controls.Add(this.rbtnDoctor);
            this.gbCargaInfromacion.Controls.Add(this.rbtnProducto);
            this.gbCargaInfromacion.Controls.Add(this.rbtnCliente);
            this.gbCargaInfromacion.Controls.Add(this.rbtnProveedor);
            this.gbCargaInfromacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargaInfromacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gbCargaInfromacion.Location = new System.Drawing.Point(25, 22);
            this.gbCargaInfromacion.Name = "gbCargaInfromacion";
            this.gbCargaInfromacion.Size = new System.Drawing.Size(728, 86);
            this.gbCargaInfromacion.TabIndex = 15;
            this.gbCargaInfromacion.TabStop = false;
            this.gbCargaInfromacion.Text = "Carga de información";
            // 
            // rbtnDoctor
            // 
            this.rbtnDoctor.AutoSize = true;
            this.rbtnDoctor.Location = new System.Drawing.Point(30, 40);
            this.rbtnDoctor.Name = "rbtnDoctor";
            this.rbtnDoctor.Size = new System.Drawing.Size(141, 24);
            this.rbtnDoctor.TabIndex = 7;
            this.rbtnDoctor.TabStop = true;
            this.rbtnDoctor.Text = "Carga Doctor";
            this.rbtnDoctor.UseVisualStyleBackColor = true;
            this.rbtnDoctor.CheckedChanged += new System.EventHandler(this.rbtnDoctor_CheckedChanged);
            // 
            // rbtnProducto
            // 
            this.rbtnProducto.AutoSize = true;
            this.rbtnProducto.Location = new System.Drawing.Point(533, 40);
            this.rbtnProducto.Name = "rbtnProducto";
            this.rbtnProducto.Size = new System.Drawing.Size(168, 24);
            this.rbtnProducto.TabIndex = 10;
            this.rbtnProducto.TabStop = true;
            this.rbtnProducto.Text = "Carga Productos";
            this.rbtnProducto.UseVisualStyleBackColor = true;
            this.rbtnProducto.CheckedChanged += new System.EventHandler(this.rbtnProducto_CheckedChanged);
            // 
            // rbtnCliente
            // 
            this.rbtnCliente.AutoSize = true;
            this.rbtnCliente.Location = new System.Drawing.Point(191, 40);
            this.rbtnCliente.Name = "rbtnCliente";
            this.rbtnCliente.Size = new System.Drawing.Size(143, 24);
            this.rbtnCliente.TabIndex = 8;
            this.rbtnCliente.TabStop = true;
            this.rbtnCliente.Text = "Carga Cliente";
            this.rbtnCliente.UseVisualStyleBackColor = true;
            this.rbtnCliente.CheckedChanged += new System.EventHandler(this.rbtnCliente_CheckedChanged);
            // 
            // rbtnProveedor
            // 
            this.rbtnProveedor.AutoSize = true;
            this.rbtnProveedor.Location = new System.Drawing.Point(352, 40);
            this.rbtnProveedor.Name = "rbtnProveedor";
            this.rbtnProveedor.Size = new System.Drawing.Size(168, 24);
            this.rbtnProveedor.TabIndex = 9;
            this.rbtnProveedor.TabStop = true;
            this.rbtnProveedor.Text = "Carga Proveedor";
            this.rbtnProveedor.UseVisualStyleBackColor = true;
            this.rbtnProveedor.CheckedChanged += new System.EventHandler(this.rbtnProveedor_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(570, 414);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(183, 72);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(362, 414);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 72);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvCargaInformacion
            // 
            this.dgvCargaInformacion.AllowUserToAddRows = false;
            this.dgvCargaInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargaInformacion.Location = new System.Drawing.Point(25, 140);
            this.dgvCargaInformacion.Name = "dgvCargaInformacion";
            this.dgvCargaInformacion.RowTemplate.Height = 28;
            this.dgvCargaInformacion.Size = new System.Drawing.Size(728, 215);
            this.dgvCargaInformacion.TabIndex = 12;
            // 
            // frmCargaInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(776, 538);
            this.Controls.Add(this.gbCargaInfromacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvCargaInformacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCargaInformacion";
            this.Text = "Carga de informaión";
            this.Load += new System.EventHandler(this.frmCargaInformacion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCargaInformacion_KeyDown);
            this.gbCargaInfromacion.ResumeLayout(false);
            this.gbCargaInfromacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaInformacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargaInfromacion;
        private System.Windows.Forms.RadioButton rbtnDoctor;
        private System.Windows.Forms.RadioButton rbtnProducto;
        private System.Windows.Forms.RadioButton rbtnCliente;
        private System.Windows.Forms.RadioButton rbtnProveedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCargaInformacion;
    }
}