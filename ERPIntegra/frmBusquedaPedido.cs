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
    public partial class frmBusquedaPedido : Form
    {
        csConexion c = new csConexion(); 
        public frmBusquedaPedido()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnGuardados_CheckedChanged(object sender, EventArgs e)
        {
            int estatus = 3;
            c.BuscaPedido(dgvPedidos,estatus);
        }

        private void rbtnPedidosEnviados_CheckedChanged(object sender, EventArgs e)
        {
            int estatus = 4;
            c.BuscaPedido(dgvPedidos, estatus);
        }

        private void rbtncanceldaos_CheckedChanged(object sender, EventArgs e)
        {
            int estatus = 5;
            c.BuscaPedido(dgvPedidos, estatus);
        }

        private void frmBusquedaPedido_Load(object sender, EventArgs e)
        {

        }
        private void dgvPedidos_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPedidos.SelectedRows)
            {
                string codigo = this.dgvPedidos.CurrentRow.Cells["CODIGO"].Value.ToString();
                string nombre = this.dgvPedidos.CurrentRow.Cells["DESCRIPCIÓN"].Value.ToString();
                string proveedor = this.dgvPedidos.CurrentRow.Cells["PROVEEDOR"].Value.ToString();
                string precio = this.dgvPedidos.CurrentRow.Cells["PRECIO"].Value.ToString();
                string ivaprod = this.dgvPedidos.CurrentRow.Cells["IVA"].Value.ToString();
                string pzapedir = this.dgvPedidos.CurrentRow.Cells["PZAPEDIR"].Value.ToString();
                string total = this.dgvPedidos.CurrentRow.Cells["TOTAL"].Value.ToString();
                
                
                frmPedido pedido = new frmPedido();
              

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "frmPedido")
                    {
                        pedido = (frmPedido)frm;

                        pedido.txtsubtotal.Text = this.dgvPedidos.CurrentRow.Cells["SUBTOTAL"].Value.ToString();
                        pedido.txtTotalPedido.Text = this.dgvPedidos.CurrentRow.Cells["TOTAL"].Value.ToString();
                        pedido.txtIva.Text = this.dgvPedidos.CurrentRow.Cells[5].Value.ToString();
                        //MessageBox.Show(codigo);
                        //MessageBox.Show(nombre);
                        //MessageBox.Show(proveedor);
                        //MessageBox.Show(precio);
                        //MessageBox.Show(ivaprod);
                        //MessageBox.Show(pzapedir);
                        //MessageBox.Show(total);
                        pedido.dgvProductoEntrada.Rows.Add(codigo, nombre, proveedor, precio, ivaprod,pzapedir,total);
                        this.Close();
                        break;
                    }
                }
            }
        }
    }
}
