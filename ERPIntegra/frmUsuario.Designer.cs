namespace ERPIntegra
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.trvFormularios = new System.Windows.Forms.TreeView();
            this.gbpUsuario = new System.Windows.Forms.GroupBox();
            this.txtusuid = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.gbpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvFormularios
            // 
            this.trvFormularios.CheckBoxes = true;
            this.trvFormularios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvFormularios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.trvFormularios.Location = new System.Drawing.Point(28, 338);
            this.trvFormularios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trvFormularios.Name = "trvFormularios";
            this.trvFormularios.Size = new System.Drawing.Size(1005, 302);
            this.trvFormularios.TabIndex = 17;
            this.trvFormularios.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvFormularios_AfterSelect);
            // 
            // gbpUsuario
            // 
            this.gbpUsuario.Controls.Add(this.txtusuid);
            this.gbpUsuario.Controls.Add(this.btnEditar);
            this.gbpUsuario.Controls.Add(this.btnSalir);
            this.gbpUsuario.Controls.Add(this.btnGuardar);
            this.gbpUsuario.Controls.Add(this.txtNombre);
            this.gbpUsuario.Controls.Add(this.rbtnInactivo);
            this.gbpUsuario.Controls.Add(this.lblNombre);
            this.gbpUsuario.Controls.Add(this.rbtnActivo);
            this.gbpUsuario.Controls.Add(this.lblUsuario);
            this.gbpUsuario.Controls.Add(this.lblEstatus);
            this.gbpUsuario.Controls.Add(this.txtUsuario);
            this.gbpUsuario.Controls.Add(this.txtPuesto);
            this.gbpUsuario.Controls.Add(this.lblContraseña);
            this.gbpUsuario.Controls.Add(this.lblPuesto);
            this.gbpUsuario.Controls.Add(this.txtContraseña);
            this.gbpUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gbpUsuario.Location = new System.Drawing.Point(28, 18);
            this.gbpUsuario.Name = "gbpUsuario";
            this.gbpUsuario.Size = new System.Drawing.Size(1005, 302);
            this.gbpUsuario.TabIndex = 16;
            this.gbpUsuario.TabStop = false;
            this.gbpUsuario.Text = "Datos del usuario";
            // 
            // txtusuid
            // 
            this.txtusuid.Location = new System.Drawing.Point(842, 147);
            this.txtusuid.Name = "txtusuid";
            this.txtusuid.Size = new System.Drawing.Size(100, 28);
            this.txtusuid.TabIndex = 14;
            this.txtusuid.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(425, 201);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(183, 72);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(805, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(183, 72);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(617, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 72);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(284, 28);
            this.txtNombre.TabIndex = 1;
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Location = new System.Drawing.Point(234, 153);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(104, 26);
            this.rbtnInactivo.TabIndex = 10;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Location = new System.Drawing.Point(128, 153);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(90, 26);
            this.rbtnActivo.TabIndex = 9;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(26, 93);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 22);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(26, 153);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(77, 22);
            this.lblEstatus.TabIndex = 8;
            this.lblEstatus.Text = "Estatus";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(132, 93);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(286, 28);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(722, 35);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(218, 28);
            this.txtPuesto.TabIndex = 5;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(587, 97);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(113, 22);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(587, 42);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(72, 22);
            this.lblPuesto.TabIndex = 4;
            this.lblPuesto.Text = "Puesto";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(722, 93);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(220, 28);
            this.txtContraseña.TabIndex = 3;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1077, 672);
            this.Controls.Add(this.trvFormularios);
            this.Controls.Add(this.gbpUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsuario_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmUsuario_KeyPress);
            this.gbpUsuario.ResumeLayout(false);
            this.gbpUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvFormularios;
        private System.Windows.Forms.GroupBox gbpUsuario;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtusuid;
    }
}