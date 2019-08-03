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
    public partial class frmLaboratorio : Form
    {
        csConexion c = new csConexion();
        public frmLaboratorio()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmLaboratorio_KeyPress);
        }

        private void frmLaboratorio_Load(object sender, EventArgs e)
        {
            c.cargaLaboratorio(dgvLaboratorio);
            this.dgvLaboratorio.Columns[0].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            string laboratorio = dgvLaboratorio.CurrentRow.Cells[1].Value.ToString();
            string tipo="I";
            c.AgregaLaboratorio(laboratorio,tipo);
        }

        private void frmLaboratorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLaboratorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                string laboratorio = dgvLaboratorio.CurrentRow.Cells[1].Value.ToString();
                string tipo = "I";
                MessageBox.Show(laboratorio.ToString());
                MessageBox.Show(tipo.ToString());
                //c.AgregaLaboratorio(laboratorio, tipo);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvLaboratorio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvLaboratorio.CurrentRow.Cells[0].Value.ToString());
            string laboratorio = dgvLaboratorio.CurrentRow.Cells[1].Value.ToString();
            string tipo = "M";
            c.ModificaLaboratorio(id,laboratorio,tipo);
        }
    }
}
