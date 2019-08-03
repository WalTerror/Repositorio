using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ERPIntegra
{
    public partial class frmProveedor : Form
    {
        csConexion c = new csConexion();
        public frmProveedor()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmProveedor_KeyPress);
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            cargaProveedorBD();
        }
        private void cargaProveedorBD()
        {
            c.cargaProveedor(dgvProveedor);
            this.dgvProveedor.Columns[0].Visible = false;
            this.dgvProveedor.Columns[11].Visible = false;
            this.dgvProveedor.Columns[12].Visible = false;
        }
        private void frmProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.dgvProveedor.DataSource != null)
            {
                this.dgvProveedor.DataSource = null;
                agregaDGV();
            }
            else
            {
                cargaProveedorBD();
            }
            btnGuardar.Visible = true;
            btnAgregar.Enabled = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvProveedor.AllowUserToAddRows = false;

            string tipo = "I";
            int estatus;
            string RFC = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            string Mail = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
            string Tel = dgvProveedor.CurrentRow.Cells[3].Value.ToString();     
            string Calle = dgvProveedor.CurrentRow.Cells[4].Value.ToString();
            string Col = dgvProveedor.CurrentRow.Cells[5].Value.ToString();
            string Del = dgvProveedor.CurrentRow.Cells[6].Value.ToString();
            string Num_Int = dgvProveedor.CurrentRow.Cells[7].Value.ToString(); 
            string Num_Ext = dgvProveedor.CurrentRow.Cells[8].Value.ToString();
            string Localidad = dgvProveedor.CurrentRow.Cells[9].Value.ToString();
            int CP = Int32.Parse(dgvProveedor.CurrentRow.Cells[10].Value.ToString());
            int Edo = Int32.Parse(dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[12].Value.ToString());

            foreach (DataGridViewRow row in dgvProveedor.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[11];
                if (chk.Selected == true)
                {
                    estatus = 2;
                    chk.Selected = false;
                    c.AgregaProveedor(RFC, Nombre, Mail,Tel,Calle,Col,Del,Num_Int,Num_Ext,Localidad,CP,estatus,Edo,tipo);
                 }
                else
                {
                    estatus = 1;
                    chk.Selected = true;
                    c.AgregaProveedor(RFC, Nombre, Mail, Tel, Calle, Col, Del, Num_Int, Num_Ext, Localidad, CP, estatus, Edo, tipo);             
                }
            }

            if (this.dgvProveedor.DataSource != null)
            {
                this.dgvProveedor.DataSource = null;
                agregaDGV();
            }
            else
            {
                this.dgvProveedor.Columns.Clear();
                cargaProveedorBD();
            }

            btnGuardar.Visible = false;
            btnAgregar.Enabled = true;        
        }
        private void btnSalir_Click(object sender, EventArgs e)    
        {
            this.Close();
        }
        private void btnSalir_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        private void frmProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void agregaDGV()
        {
            DataGridViewTextBoxColumn rfc = new DataGridViewTextBoxColumn();
            rfc.HeaderText = "RFC";
            DataGridViewTextBoxColumn nombre = new DataGridViewTextBoxColumn();
            nombre.HeaderText = "NOMBRE";
            DataGridViewTextBoxColumn mail = new DataGridViewTextBoxColumn();
            mail.HeaderText = "MAIL";
            DataGridViewTextBoxColumn tel = new DataGridViewTextBoxColumn();
            tel.HeaderText = "TEL.";
            DataGridViewTextBoxColumn calle = new DataGridViewTextBoxColumn();
            calle.HeaderText = "CALLE";
            DataGridViewTextBoxColumn colinia = new DataGridViewTextBoxColumn();
            colinia.HeaderText = "COLONIA";
            DataGridViewTextBoxColumn del = new DataGridViewTextBoxColumn();
            del.HeaderText = "DEL.";
            DataGridViewTextBoxColumn numint = new DataGridViewTextBoxColumn();
            numint.HeaderText = "NUM INT";
            DataGridViewTextBoxColumn numext = new DataGridViewTextBoxColumn();
            numext.HeaderText = "NUM EXT";    
            DataGridViewTextBoxColumn localidad = new DataGridViewTextBoxColumn();
            localidad.HeaderText = "LOCALIDAD";
            DataGridViewTextBoxColumn cp = new DataGridViewTextBoxColumn();
            cp.HeaderText = "CP";           
            DataGridViewCheckBoxColumn estatus = new DataGridViewCheckBoxColumn();
            estatus.HeaderText = "ACTIVO";
            DataGridViewComboBoxColumn cbxestado = new DataGridViewComboBoxColumn();
            cbxestado.HeaderText = "ESTADO";

            dgvProveedor.Columns.Add(rfc);
            dgvProveedor.Columns.Add(nombre);
            dgvProveedor.Columns.Add(mail);
            dgvProveedor.Columns.Add(tel);
            dgvProveedor.Columns.Add(calle);
            dgvProveedor.Columns.Add(colinia);
            dgvProveedor.Columns.Add(del);
            dgvProveedor.Columns.Add(numint);
            dgvProveedor.Columns.Add(numext);            
            dgvProveedor.Columns.Add(localidad);
            dgvProveedor.Columns.Add(cp);
            dgvProveedor.Columns.Add(estatus);
            dgvProveedor.Columns.Add(cbxestado);

            dgvProveedor.AllowUserToAddRows = true;

            foreach (DataGridViewRow row in dgvProveedor.Rows)
            {
                cbxestado.DataSource = c.cargacomboEstadostados();
                cbxestado.ValueMember = "edoId";
                cbxestado.DisplayMember = "edoDescripcion";
            }
        }

        private void txtRazon_TextChanged(object sender, EventArgs e)
        {
            if (txtRazon.Text != "")
            {
                dgvProveedor.CurrentCell = null;
                foreach (DataGridViewRow r in dgvProveedor.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvProveedor.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtRazon.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                c.cargaProveedor(dgvProveedor);
            }
        }

        private void gbProveedor_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            if (txtRFC.Text != "")
            {
                dgvProveedor.CurrentCell = null;
                foreach (DataGridViewRow r in dgvProveedor.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvProveedor.Rows)
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
                c.cargaProveedor(dgvProveedor);
            }
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          //  btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*
            string tipo = "M";
            int estatus;
            string RFC = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            string Mail = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
            string Tel = dgvProveedor.CurrentRow.Cells[3].Value.ToString();
            string Calle = dgvProveedor.CurrentRow.Cells[4].Value.ToString();
            string Col = dgvProveedor.CurrentRow.Cells[5].Value.ToString();
            string Del = dgvProveedor.CurrentRow.Cells[6].Value.ToString();
            string Num_Int = dgvProveedor.CurrentRow.Cells[7].Value.ToString();
            string Num_Ext = dgvProveedor.CurrentRow.Cells[8].Value.ToString();
            string Localidad = dgvProveedor.CurrentRow.Cells[9].Value.ToString();
            int CP = Int32.Parse(dgvProveedor.CurrentRow.Cells[10].Value.ToString());
            int Edo = Int32.Parse(dgvProveedor.Rows[dgvProveedor.CurrentRow.Index].Cells[12].Value.ToString());

            foreach (DataGridViewRow row in dgvProveedor.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[11];
                if (chk.Selected == true)
                {
                    estatus = 2;
                    chk.Selected = false;
                    c.AgregaProveedor(RFC, Nombre, Mail, Tel, Calle, Col, Del, Num_Int, Num_Ext, Localidad, CP, estatus, Edo, tipo);
                }
                else
                {
                    estatus = 1;
                    chk.Selected = true;
                    c.AgregaProveedor(RFC, Nombre, Mail, Tel, Calle, Col, Del, Num_Int, Num_Ext, Localidad, CP, estatus, Edo, tipo);
                }
            } */
        }
    }
}
