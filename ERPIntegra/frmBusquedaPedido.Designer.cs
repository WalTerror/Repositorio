namespace ERPIntegra
{
    partial class frmBusquedaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaPedido));
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnGuardados = new System.Windows.Forms.RadioButton();
            this.rbtnPedidosEnviados = new System.Windows.Forms.RadioButton();
            this.rbtncanceldaos = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(37, 146);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowTemplate.Height = 28;
            this.dgvPedidos.Size = new System.Drawing.Size(738, 277);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.DoubleClick += new System.EventHandler(this.dgvPedidos_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnGuardados);
            this.groupBox1.Controls.Add(this.rbtnPedidosEnviados);
            this.groupBox1.Controls.Add(this.rbtncanceldaos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.groupBox1.Location = new System.Drawing.Point(37, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatus pedidos";
            // 
            // rbtnGuardados
            // 
            this.rbtnGuardados.AutoSize = true;
            this.rbtnGuardados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGuardados.Location = new System.Drawing.Point(38, 45);
            this.rbtnGuardados.Name = "rbtnGuardados";
            this.rbtnGuardados.Size = new System.Drawing.Size(207, 26);
            this.rbtnGuardados.TabIndex = 2;
            this.rbtnGuardados.TabStop = true;
            this.rbtnGuardados.Text = "Pedidos guardados";
            this.rbtnGuardados.UseVisualStyleBackColor = true;
            this.rbtnGuardados.CheckedChanged += new System.EventHandler(this.rbtnGuardados_CheckedChanged);
            // 
            // rbtnPedidosEnviados
            // 
            this.rbtnPedidosEnviados.AutoSize = true;
            this.rbtnPedidosEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPedidosEnviados.Location = new System.Drawing.Point(278, 45);
            this.rbtnPedidosEnviados.Name = "rbtnPedidosEnviados";
            this.rbtnPedidosEnviados.Size = new System.Drawing.Size(193, 26);
            this.rbtnPedidosEnviados.TabIndex = 3;
            this.rbtnPedidosEnviados.TabStop = true;
            this.rbtnPedidosEnviados.Text = "Pedidos enviados";
            this.rbtnPedidosEnviados.UseVisualStyleBackColor = true;
            this.rbtnPedidosEnviados.CheckedChanged += new System.EventHandler(this.rbtnPedidosEnviados_CheckedChanged);
            // 
            // rbtncanceldaos
            // 
            this.rbtncanceldaos.AutoSize = true;
            this.rbtncanceldaos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtncanceldaos.Location = new System.Drawing.Point(501, 45);
            this.rbtncanceldaos.Name = "rbtncanceldaos";
            this.rbtncanceldaos.Size = new System.Drawing.Size(214, 26);
            this.rbtncanceldaos.TabIndex = 4;
            this.rbtncanceldaos.TabStop = true;
            this.rbtncanceldaos.Text = "Pedidos cancelados";
            this.rbtncanceldaos.UseVisualStyleBackColor = true;
            this.rbtncanceldaos.CheckedChanged += new System.EventHandler(this.rbtncanceldaos_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(610, 469);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 74);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmBusquedaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(824, 554);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaPedido";
            this.Text = "Búsqueda pedidos";
            this.Load += new System.EventHandler(this.frmBusquedaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnGuardados;
        private System.Windows.Forms.RadioButton rbtnPedidosEnviados;
        private System.Windows.Forms.RadioButton rbtncanceldaos;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.DataGridView dgvPedidos;

    }
}