namespace ERPIntegra
{
    partial class frmAltaDeptoRack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaDeptoRack));
            this.rdbtnRack = new System.Windows.Forms.RadioButton();
            this.rdbtnDepartamento = new System.Windows.Forms.RadioButton();
            this.btnGuardaambos = new System.Windows.Forms.Button();
            this.gbRack = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarRack = new System.Windows.Forms.Button();
            this.txtrack = new System.Windows.Forms.TextBox();
            this.gbDepartamento = new System.Windows.Forms.GroupBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.btnGuardarDepto = new System.Windows.Forms.Button();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.gbRack.SuspendLayout();
            this.gbDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtnRack
            // 
            this.rdbtnRack.AutoSize = true;
            this.rdbtnRack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnRack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.rdbtnRack.Location = new System.Drawing.Point(447, 26);
            this.rdbtnRack.Name = "rdbtnRack";
            this.rdbtnRack.Size = new System.Drawing.Size(157, 26);
            this.rdbtnRack.TabIndex = 13;
            this.rdbtnRack.TabStop = true;
            this.rdbtnRack.Text = "Agregar Rack";
            this.rdbtnRack.UseVisualStyleBackColor = true;
            this.rdbtnRack.CheckedChanged += new System.EventHandler(this.rdbtnRack_CheckedChanged);
            // 
            // rdbtnDepartamento
            // 
            this.rdbtnDepartamento.AutoSize = true;
            this.rdbtnDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.rdbtnDepartamento.Location = new System.Drawing.Point(171, 26);
            this.rdbtnDepartamento.Name = "rdbtnDepartamento";
            this.rdbtnDepartamento.Size = new System.Drawing.Size(210, 26);
            this.rdbtnDepartamento.TabIndex = 12;
            this.rdbtnDepartamento.TabStop = true;
            this.rdbtnDepartamento.Text = "Agreagar Categoría";
            this.rdbtnDepartamento.UseVisualStyleBackColor = true;
            this.rdbtnDepartamento.CheckedChanged += new System.EventHandler(this.rdbtnDepartamento_CheckedChanged);
            // 
            // btnGuardaambos
            // 
            this.btnGuardaambos.FlatAppearance.BorderSize = 0;
            this.btnGuardaambos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaambos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardaambos.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGuardaambos.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardaambos.Image")));
            this.btnGuardaambos.Location = new System.Drawing.Point(503, 548);
            this.btnGuardaambos.Name = "btnGuardaambos";
            this.btnGuardaambos.Size = new System.Drawing.Size(183, 72);
            this.btnGuardaambos.TabIndex = 11;
            this.btnGuardaambos.UseVisualStyleBackColor = true;
            this.btnGuardaambos.Click += new System.EventHandler(this.btnGuardaambos_Click);
            // 
            // gbRack
            // 
            this.gbRack.Controls.Add(this.label1);
            this.gbRack.Controls.Add(this.btnGuardarRack);
            this.gbRack.Controls.Add(this.txtrack);
            this.gbRack.Enabled = false;
            this.gbRack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gbRack.Location = new System.Drawing.Point(36, 342);
            this.gbRack.Name = "gbRack";
            this.gbRack.Size = new System.Drawing.Size(723, 160);
            this.gbRack.TabIndex = 10;
            this.gbRack.TabStop = false;
            this.gbRack.Text = "Rack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(39, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rack";
            // 
            // btnGuardarRack
            // 
            this.btnGuardarRack.FlatAppearance.BorderSize = 0;
            this.btnGuardarRack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRack.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarRack.Image")));
            this.btnGuardarRack.Location = new System.Drawing.Point(467, 57);
            this.btnGuardarRack.Name = "btnGuardarRack";
            this.btnGuardarRack.Size = new System.Drawing.Size(183, 72);
            this.btnGuardarRack.TabIndex = 5;
            this.btnGuardarRack.UseVisualStyleBackColor = true;
            this.btnGuardarRack.Click += new System.EventHandler(this.btnGuardarRack_Click);
            // 
            // txtrack
            // 
            this.txtrack.Location = new System.Drawing.Point(215, 79);
            this.txtrack.Name = "txtrack";
            this.txtrack.Size = new System.Drawing.Size(171, 28);
            this.txtrack.TabIndex = 4;
            // 
            // gbDepartamento
            // 
            this.gbDepartamento.Controls.Add(this.lblDepartamento);
            this.gbDepartamento.Controls.Add(this.btnGuardarDepto);
            this.gbDepartamento.Controls.Add(this.txtDepartamento);
            this.gbDepartamento.Enabled = false;
            this.gbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gbDepartamento.Location = new System.Drawing.Point(36, 102);
            this.gbDepartamento.Name = "gbDepartamento";
            this.gbDepartamento.Size = new System.Drawing.Size(723, 186);
            this.gbDepartamento.TabIndex = 9;
            this.gbDepartamento.TabStop = false;
            this.gbDepartamento.Text = "Categoría";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.lblDepartamento.Location = new System.Drawing.Point(39, 89);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 22);
            this.lblDepartamento.TabIndex = 0;
            this.lblDepartamento.Text = "Categoría";
            // 
            // btnGuardarDepto
            // 
            this.btnGuardarDepto.FlatAppearance.BorderSize = 0;
            this.btnGuardarDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDepto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarDepto.Image")));
            this.btnGuardarDepto.Location = new System.Drawing.Point(467, 61);
            this.btnGuardarDepto.Name = "btnGuardarDepto";
            this.btnGuardarDepto.Size = new System.Drawing.Size(183, 72);
            this.btnGuardarDepto.TabIndex = 2;
            this.btnGuardarDepto.UseVisualStyleBackColor = true;
            this.btnGuardarDepto.Click += new System.EventHandler(this.btnGuardarDepto_Click);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(215, 83);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(171, 28);
            this.txtDepartamento.TabIndex = 1;
            // 
            // frmAltaDeptoRack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(818, 660);
            this.Controls.Add(this.rdbtnRack);
            this.Controls.Add(this.rdbtnDepartamento);
            this.Controls.Add(this.btnGuardaambos);
            this.Controls.Add(this.gbRack);
            this.Controls.Add(this.gbDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAltaDeptoRack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta categoría y rack";
            this.Load += new System.EventHandler(this.frmAltaDeptoRack_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAltaDeptoRack_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAltaDeptoRack_KeyPress);
            this.gbRack.ResumeLayout(false);
            this.gbRack.PerformLayout();
            this.gbDepartamento.ResumeLayout(false);
            this.gbDepartamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnRack;
        private System.Windows.Forms.RadioButton rdbtnDepartamento;
        private System.Windows.Forms.Button btnGuardaambos;
        private System.Windows.Forms.GroupBox gbRack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarRack;
        private System.Windows.Forms.TextBox txtrack;
        private System.Windows.Forms.GroupBox gbDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Button btnGuardarDepto;
        private System.Windows.Forms.TextBox txtDepartamento;
    }
}