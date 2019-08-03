using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPIntegra
{    
    public partial class frmIntegra : Form
    {       
        int indice;
        public frmIntegra()
        {
            InitializeComponent();
            indice = 0;                
        }
        private void btnFondoC_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmFondoCaja());
            btnVenta.Enabled = true;
            btnRetiroc.Enabled = true;
            btnIngresov.Enabled = true;
            btnArqueoc.Enabled = true;
            btnCorteC.Enabled = true;
        }
        private void abriricontenedor(object cont)
        {
            if (this.pnlContenedor.Controls.Count > 0) this.pnlContenedor.Controls.RemoveAt(0);
            Form mostrar = cont as Form;
            mostrar.TopLevel = false;
            mostrar.FormBorderStyle = FormBorderStyle.None;
            mostrar.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(mostrar);
            this.pnlContenedor.Tag = mostrar;
            mostrar.Show();
        }
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmUsuario());
        }
        private void btnVenta_Click(object sender, EventArgs e)
        {
             abriricontenedor(new frmVenta());
        }
        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmMedico());
        }
        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmProveedor());
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmCliente());
        }
        private void altaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmAltaProd());
        }
        private void catalogoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmCatalogoProd());
        }
        private void departamentoYRackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmAltaDeptoRack());
        }
        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmLaboratorio());
        }

        private void cargaDeInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmCargaInformacion());
        }

        private void frmIntegra_Load(object sender, EventArgs e)
        {
            
        }
           private void btnCorteC_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmCorteCaja());
        }        

        private void tmrImagen_Tick(object sender, EventArgs e)
        {
            indice++;
            if (indice > 5)
                indice = 0;
            pboxPanel2.Image = listimgCarga.Images[indice];
           /* if (cerrado)
            {
                cerrado = false;
                pboxPanel2.Image = listimgCarga.Images[1];

            }
            else
            {   cerrado = true;
                pboxPanel2.Image = listimgCarga.Images[0];
            }   */
        }

        private void pboxPanel2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Realizara acción");
        }

        private void btnIngresov_Click(object sender, EventArgs e)
        {
            abriricontenedor (new frmIngresoValores() );
        }

        private void btnRetiroc_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmRetiroValores());
        }

        private void btnArqueoc_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmArqueoCaja());
        }

        private void datosFarmaciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmFarmacia());
        }

        private void entradaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abriricontenedor(new frmPedido());
        }
        private void frmIntegra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                abriricontenedor(new frmFondoCaja());
                btnArqueoc.Enabled = true;
                btnVenta.Enabled = true;
                btnRetiroc.Enabled = true;
                btnCorteC.Enabled = true;
                btnIngresov.Enabled = true;
            }
            if (e.KeyCode == Keys.F6)
            {   
                 abriricontenedor(new frmVenta());
            }
            if (e.KeyCode == Keys.F7)
            {
                abriricontenedor(new frmRetiroValores());
            }
            if (e.KeyCode == Keys.F8)
            {
                abriricontenedor(new frmIngresoValores());
            }
            if (e.KeyCode == Keys.F9)
            {
                 abriricontenedor(new frmArqueoCaja());
            }
            if (e.KeyCode == Keys.F10)
            {
                 abriricontenedor(new frmCorteCaja());
            }
        }    
     }    
}
