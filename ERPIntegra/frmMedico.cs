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
    public partial class frmMedico : Form
    {
        csConexion c = new csConexion();
       
        public frmMedico()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmMedico_KeyPress);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            c.cargaDoctor(dgwDoctor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardaDoctor();
        }

        private void GuardaDoctor()
        {
            string tipo = "I";
            int estatus;
            int cedula = Int32.Parse(dgwDoctor.CurrentRow.Cells[0].Value.ToString());
            string nombre = dgwDoctor.CurrentRow.Cells[1].Value.ToString();
            string domicilio = dgwDoctor.CurrentRow.Cells[2].Value.ToString();
            //int estatus = Int32.Parse(dgwDoctor.CurrentRow.Cells[3].Value.ToString());

            if (dgwDoctor.CurrentRow.Cells[3].Value.ToString() == "ACTIVO")
            {
                estatus = 1;
                c.AgregaDoctor(cedula, nombre, domicilio, estatus, tipo);
                c.cargaDoctor(dgwDoctor);
                btnGuardar.Visible = false;
                btnModificar.Visible = false;
                btnAgregar.Enabled = true; 
            }
            else if (dgwDoctor.CurrentRow.Cells[3].Value.ToString() == "INACTIVO")
            {
                estatus = 2;
                c.AgregaDoctor(cedula, nombre, domicilio, estatus, tipo);
                c.cargaDoctor(dgwDoctor);
                btnGuardar.Visible = false;
                btnModificar.Visible = false;
                btnAgregar.Enabled = true; 
            }
            /*
            c.AgregaDoctor(cedula, nombre, domicilio, estatus,tipo);
            c.cargaDoctor(dgwDoctor);
            btnGuardar.Visible = false;
            btnModificar.Visible = false;
            btnAgregar.Enabled = true;*/
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgwDoctor.DataSource;
            dt.Clear();
            dgwDoctor.AllowUserToAddRows = true;
            if (dt.Rows.Count == 0)
                btnGuardar.Visible = true;
            btnModificar.Visible = true;
            btnAgregar.Enabled = false;       
        }

        private void frmMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                dgwDoctor.CurrentCell = null;
                foreach (DataGridViewRow r in dgwDoctor.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgwDoctor.Rows)
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
                c.cargaDoctor(dgwDoctor);
            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.Text != "")
            {
                dgwDoctor.CurrentCell = null;
                foreach (DataGridViewRow r in dgwDoctor.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgwDoctor.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtCedula.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                c.cargaDoctor(dgwDoctor);
            }
        }

        private void frmMedico_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                /*string nombre = txtNombre.Text;
                c.BuscaDoctor(nombre, dgwDoctor);*/
            }
            if (e.KeyCode == Keys.F2)
            {
                LimpiaDataGrid();
                dgwDoctor.AllowUserToAddRows = true;
                btnGuardar.Visible = true;
                btnModificar.Visible = true;
                btnAgregar.Enabled = false;
            }
            if (e.KeyCode == Keys.F3)
            {
                GuardaDoctor();
                c.cargaDoctor(dgwDoctor);
                btnGuardar.Visible = false;
                btnModificar.Visible = true;
                btnAgregar.Enabled = true;
                
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }            
        }
        private void LimpiaDataGrid()
        {
            DataTable dt = (DataTable)dgwDoctor.DataSource;
            dt.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string tipo = "M";
            int estatus;
            int cedula = Int32.Parse(dgwDoctor.CurrentRow.Cells[0].Value.ToString());
            string nombre = dgwDoctor.CurrentRow.Cells[1].Value.ToString();
            string domicilio = dgwDoctor.CurrentRow.Cells[2].Value.ToString();

            if (dgwDoctor.CurrentRow.Cells[3].Value.ToString() == "ACTIVO")
            {
                estatus = 1;
                c.ModificaDoctor(cedula, nombre, domicilio, estatus, tipo);
                c.cargaDoctor(dgwDoctor);
                btnGuardar.Visible = false;
                btnModificar.Visible = false;
                btnAgregar.Enabled = true;
            }
            else if (dgwDoctor.CurrentRow.Cells[3].Value.ToString() == "INACTIVO")
            {
                estatus = 2;
                c.ModificaDoctor(cedula, nombre, domicilio, estatus, tipo);
                c.cargaDoctor(dgwDoctor);
                btnGuardar.Visible = false;
                btnModificar.Visible = false;
                btnAgregar.Enabled = true;
            }
            txtNombre.Text = "";
            txtCedula.Text = "";
        }

        private void dgwDoctor_DoubleClick(object sender, EventArgs e)
        {
            btnModificar.Visible = true;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
