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
    public partial class frmRetiroValores : Form
    {
        csConexion c = new csConexion();
        public frmRetiroValores()
        {
            InitializeComponent();
        }
        private void frmRetiroValores_Load(object sender, EventArgs e)
        {
            dgvdenominaciones.AutoGenerateColumns = false;
            dgvdenominaciones.DataSource = c.cargarDenominaciones(dgvdenominaciones);

            foreach (DataGridViewColumn columna in dgvdenominaciones.Columns)
            {
                columna.Width = 75;
            }
        }
        private void frmRetiroValores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            } 
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvdenominaciones_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdenominaciones.Columns[e.ColumnIndex].Name == "denValor" || dgvdenominaciones.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                decimal totalColumna = 0;
                decimal totalMoneda = 0;
                decimal totalBillete = 0;

                foreach (DataGridViewRow row in dgvdenominaciones.Rows)
                {
                    decimal totalFila = Convert.ToDecimal(row.Cells["denValor"].Value) * Convert.ToDecimal(row.Cells["Cantidad"].Value);
                    row.Cells["Importe"].Value = totalFila;
                    totalColumna += totalFila;

                    string moneda = row.Cells["denTipo"].Value.ToString();

                    if (moneda == "M")
                    {
                        totalMoneda += totalFila;
                    }
                    else
                    {
                        totalBillete += totalFila;
                    }
                }
                DataGridViewRow rowTotal = dgvdenominaciones.Rows[dgvdenominaciones.Rows.Count - 1];
                rowTotal.Cells["Importe"].Value = totalColumna;
                txtTotal.Text = totalColumna.ToString();
                txtMonto1.Text = totalMoneda.ToString();
                txtMonto2.Text = totalBillete.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Debe ingresar el toral de retiro");
            }
            else
            {
                MessageBox.Show("El valor ingresado: " + txtTotal.Text.ToString());
            }
        }

        private void dgvdenominaciones_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            // dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }
        void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
