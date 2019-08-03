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
    public partial class frmAltaDeptoRack : Form
    {
        csConexion c = new csConexion();
        public frmAltaDeptoRack()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmAltaDeptoRack_KeyPress);
        }

        private void rdbtnDepartamento_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDepartamento.Checked == true)
                gbDepartamento.Enabled = true;
            else
                gbDepartamento.Enabled = false;  
        }

        private void rdbtnRack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnRack.Checked == true)
                gbRack.Enabled = true;
            else
                gbRack.Enabled = false;
        }

        private void frmAltaDeptoRack_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }

        private void btnGuardarDepto_Click(object sender, EventArgs e)
        {
            string tipo = "I";
            string departamento = txtDepartamento.Text;
            c.AgregaDepartamento(departamento,tipo);
            txtDepartamento.Clear();
        }

        private void btnGuardarRack_Click(object sender, EventArgs e)
        {
            string tipo = "I";
            string rack = txtrack.Text;
            c.AgregaRack(rack,tipo);
            txtrack.Clear();
        }

        private void btnGuardaambos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaDeptoRack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }  
        }

        private void frmAltaDeptoRack_Load(object sender, EventArgs e)
        {

        }
    }
}
