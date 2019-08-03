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
    public partial class frmCliente : Form
    {
        csConexion c = new csConexion();
        public frmCliente()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmCliente_KeyPress);
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            cargaLCientesBD();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (this.dgvClientes.DataSource != null)
            {
                this.dgvClientes.DataSource = null;
                agregaDGV();
            }
            else
            {
                cargaLCientesBD();
            }
            btnGuardar.Visible = true;
            btnAgregar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvClientes.AllowUserToAddRows = false;

            string tipo = "I";
            int estatus;
            string RFC = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            string Calle = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            string Num_Ext = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            string Num_Int = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            string Col = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            string Del = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            string Localidad = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            int CP = Int32.Parse(dgvClientes.CurrentRow.Cells[8].Value.ToString());
            string Mail = dgvClientes.CurrentRow.Cells[9].Value.ToString();
            string Tel = dgvClientes.CurrentRow.Cells[10].Value.ToString();
            int Edo= Int32.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[12].Value.ToString());
            int Cfdi = Int32.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[13].Value.ToString());

            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[11];
                if (chk.Selected == true)
                {
                    estatus = 2;
                    chk.Selected = false;

                    c.AgregaCliente(RFC,Cfdi,Nombre,Calle,Num_Ext,Num_Int,Col,Del,Localidad,CP,Edo,estatus,Mail,Tel,tipo);
                   // MessageBox.Show(" no esta marcado:"+ estatus.ToString());
                }
                else
                {
                    estatus = 1;
                    chk.Selected = true;
                    c.AgregaCliente(RFC, Cfdi, Nombre, Calle, Num_Ext, Num_Int, Col, Del, Localidad, CP, Edo, estatus, Mail, Tel, tipo);     
                   // MessageBox.Show("estatus esta marcdo y es :" + estatus.ToString());
                }
            }

            if (this.dgvClientes.DataSource != null)
            {
                this.dgvClientes.DataSource = null;
                agregaDGV();
            }
            else
            {
                this.dgvClientes.Columns.Clear();
                cargaLCientesBD();
            }

            btnGuardar.Visible = false;
            btnAgregar.Enabled = true;          

        }

        private void cargaLCientesBD()
        {
            c.cargaCliente(dgvClientes);
            this.dgvClientes.Columns[0].Visible = false;
            this.dgvClientes.Columns[2].Visible = false;
            this.dgvClientes.Columns[11].Visible = false;
            this.dgvClientes.Columns[12].Visible = false;
        }

        private void frmCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }

        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                dgvClientes.CurrentCell = null;
                foreach (DataGridViewRow r in dgvClientes.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvClientes.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtNombre.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                c.cargaCliente(dgvClientes);
            }
        }
        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            if (txtRFC.Text != "")
            {
                dgvClientes.CurrentCell = null;
                foreach (DataGridViewRow r in dgvClientes.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvClientes.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtRFC.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                c.cargaCliente(dgvClientes);
            }

        }

        private void agregaDGV()
        {
            //  DataTable dt = new DataTable();
            DataGridViewTextBoxColumn rfc = new DataGridViewTextBoxColumn();
            rfc.HeaderText = "RFC";
            DataGridViewTextBoxColumn nombre = new DataGridViewTextBoxColumn();
            nombre.HeaderText = "NOMBRE";
            DataGridViewTextBoxColumn calle = new DataGridViewTextBoxColumn();
            calle.HeaderText = "CALLE";
            DataGridViewTextBoxColumn numext = new DataGridViewTextBoxColumn();
            numext.HeaderText = "NUM EXT";
            DataGridViewTextBoxColumn numint = new DataGridViewTextBoxColumn();
            numint.HeaderText = "NUM INT";
            DataGridViewTextBoxColumn colinia = new DataGridViewTextBoxColumn();
            colinia.HeaderText = "COLONIA";
            DataGridViewTextBoxColumn del = new DataGridViewTextBoxColumn();
            del.HeaderText = "DEL.";
            DataGridViewTextBoxColumn localidad = new DataGridViewTextBoxColumn();
            localidad.HeaderText = "LOCALIDAD";
            DataGridViewTextBoxColumn cp = new DataGridViewTextBoxColumn();
            cp.HeaderText = "CP";
            DataGridViewTextBoxColumn mail = new DataGridViewTextBoxColumn();
            mail.HeaderText = "MAIL";
            DataGridViewTextBoxColumn tel = new DataGridViewTextBoxColumn();
            tel.HeaderText = "TEL.";
            DataGridViewCheckBoxColumn estatus = new DataGridViewCheckBoxColumn();
            estatus.HeaderText = "ACTIVO";
            DataGridViewComboBoxColumn cbxestado = new DataGridViewComboBoxColumn();
            cbxestado.HeaderText = "ESTADO";
            DataGridViewComboBoxColumn cfdi = new DataGridViewComboBoxColumn();
            cfdi.HeaderText = "CFDI";

            dgvClientes.Columns.Add(rfc);
            dgvClientes.Columns.Add(nombre);
            dgvClientes.Columns.Add(calle);
            dgvClientes.Columns.Add(numext);
            dgvClientes.Columns.Add(numint);
            dgvClientes.Columns.Add(colinia);
            dgvClientes.Columns.Add(del);
            dgvClientes.Columns.Add(localidad);
            dgvClientes.Columns.Add(cp);
            dgvClientes.Columns.Add(mail);
            dgvClientes.Columns.Add(tel);
            dgvClientes.Columns.Add(estatus);
            dgvClientes.Columns.Add(cbxestado);
            dgvClientes.Columns.Add(cfdi);

            dgvClientes.AllowUserToAddRows = true;

            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                cbxestado.DataSource = c.cargacomboEstadostados();
                cbxestado.ValueMember = "edoId";
                cbxestado.DisplayMember = "edoDescripcion";
            }

            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                cfdi.DataSource = c.cargacomboCFDI();
                cfdi.ValueMember = "ucfdiId";
                cfdi.DisplayMember = "ucfdiDescripcion";
            }

        }

    }
}
