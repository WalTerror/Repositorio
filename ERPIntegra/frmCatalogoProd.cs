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
    public partial class frmCatalogoProd : Form
    {
        csConexion c = new csConexion();
   
        frmPedido Pedido = new frmPedido();
        public frmCatalogoProd()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmCatalogoProd_KeyPress);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                dgvProducto.CurrentCell = null;
                foreach (DataGridViewRow r in dgvProducto.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvProducto.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtProducto.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }

                    }
                }
            }
            else
            {
                c.cargaProducto(dgvProducto);
            }
        }
        private void frmCatalogoProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmCatalogoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }

        private void frmCatalogoProd_Load(object sender, EventArgs e)
        {
            c.cargaProducto(dgvProducto);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaProd altapro = new frmAltaProd();
            altapro.Show();
        }

      
        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {                       
            foreach(DataGridViewRow row in dgvProducto.SelectedRows)
            {
                string codigo = this.dgvProducto.CurrentRow.Cells[0].Value.ToString();
                string idp = this.dgvProducto.CurrentRow.Cells[1].Value.ToString();
                string nombre = this.dgvProducto.CurrentRow.Cells[2].Value.ToString();
                string iva = this.dgvProducto.CurrentRow.Cells[6].Value.ToString();
                string precio = this.dgvProducto.CurrentRow.Cells[5].Value.ToString();
                string proveedor = this.dgvProducto.CurrentRow.Cells[7].Value.ToString();
           
                frmPedido ped = new frmPedido();

                foreach(Form frm in Application.OpenForms)
                {
                    if(frm.Name =="frmPedido")
                    {
                        ped = (frmPedido)frm;
                        ped.dgvProductoEntrada.Rows.Add(idp, codigo, nombre,proveedor,precio,iva);
                        this.Close();
                        break;
                    }
                }
            }
        }



      

    }
}
