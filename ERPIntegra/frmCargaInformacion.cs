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
    public partial class frmCargaInformacion : Form
    {
        csConexion c = new csConexion();
        public frmCargaInformacion()
        {
            InitializeComponent();
        }

        private void rbtnDoctor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDoctor.Checked == true)
                new csCargaInformacion().importarExcel(dgvCargaInformacion, "Hoja1");
            else
                rbtnDoctor.Checked = false;
        }

        private void rbtnCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCliente.Checked == true)
                new csCargaInformacion().importarExcel(dgvCargaInformacion, "Hoja1");
            else
                rbtnCliente.Checked = false;
        }

        private void rbtnProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnProveedor.Checked == true)
                new csCargaInformacion().importarExcel(dgvCargaInformacion, "Hoja1");
            else
                rbtnProveedor.Checked = false;
        }

        private void rbtnProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnProducto.Checked == true)
                new csCargaInformacion().importarExcel(dgvCargaInformacion, "Hoja1");
            else
                rbtnProducto.Checked = false;

        }

        private void frmCargaInformacion_Load(object sender, EventArgs e)
        {

        }

        private void LimpiaDataGrid()
        {
            DataTable dt = (DataTable)dgvCargaInformacion.DataSource;
            dt.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string tipo = "I";

            if (rbtnDoctor.Checked == true)
            {               
                foreach (DataGridViewRow row in dgvCargaInformacion.Rows)
                {
                    int cedula = Int32.Parse(dgvCargaInformacion[0, row.Index].Value.ToString()); ;
                    string nombre = dgvCargaInformacion[1, row.Index].Value.ToString();
                    string direccion = dgvCargaInformacion[2, row.Index].Value.ToString();
                    int estatus = Int32.Parse(dgvCargaInformacion[3, row.Index].Value.ToString());
                    c.AgregaDoctor(cedula, nombre, direccion, estatus,tipo);
                    LimpiaDataGrid();
                }
            }


            if (rbtnProveedor.Checked == true)
            {
                foreach (DataGridViewRow row in dgvCargaInformacion.Rows)
                {
                    string RFC = dgvCargaInformacion[0, row.Index].Value.ToString();
                    string razon = dgvCargaInformacion[1, row.Index].Value.ToString();
                    string mail = dgvCargaInformacion[2, row.Index].Value.ToString();
                    string tel = dgvCargaInformacion[3, row.Index].Value.ToString();
                    int estatus = Int32.Parse(dgvCargaInformacion[4, row.Index].Value.ToString());
                    string calle = dgvCargaInformacion[5, row.Index].Value.ToString();
                    string colonia = dgvCargaInformacion[6, row.Index].Value.ToString();
                    string delegacion = dgvCargaInformacion[7, row.Index].Value.ToString();
                    int numint = Int32.Parse(dgvCargaInformacion[8, row.Index].Value.ToString());
                    int numext = Int32.Parse(dgvCargaInformacion[9, row.Index].Value.ToString());
                    string localidad = dgvCargaInformacion[10, row.Index].Value.ToString();
                    int estado = Int32.Parse(dgvCargaInformacion[11, row.Index].Value.ToString());
                    int cp = Int32.Parse(dgvCargaInformacion[12, row.Index].Value.ToString());
                  //  c.AgregaProveedor(RFC, razon, mail, tel, estatus, calle, colonia, delegacion, numint, numext, localidad, estado, cp,tipo);
                    LimpiaDataGrid();
                }
            }
            if (rbtnCliente.Checked == true)
            {
                
                foreach (DataGridViewRow row in dgvCargaInformacion.Rows)
                {
                    string rfc = dgvCargaInformacion[0, row.Index].Value.ToString();
                    string cfdi = dgvCargaInformacion[1, row.Index].Value.ToString();
                    string nombre = dgvCargaInformacion[2, row.Index].Value.ToString();
                    string calle = dgvCargaInformacion[3, row.Index].Value.ToString();
                    int numext = Int32.Parse(dgvCargaInformacion[4, row.Index].Value.ToString());
                    int numint = Int32.Parse(dgvCargaInformacion[5, row.Index].Value.ToString());
                    string colonia = dgvCargaInformacion[6, row.Index].Value.ToString();
                    string delegacion = dgvCargaInformacion[7, row.Index].Value.ToString();
                    string localidad = dgvCargaInformacion[8, row.Index].Value.ToString();
                    int cp = Int32.Parse(dgvCargaInformacion[9, row.Index].Value.ToString());
                    int estado = Int32.Parse(dgvCargaInformacion[10, row.Index].Value.ToString());
                    int estatus = Int32.Parse(dgvCargaInformacion[11, row.Index].Value.ToString());
                    string mail = dgvCargaInformacion[12, row.Index].Value.ToString();
                    string telefono = dgvCargaInformacion[13, row.Index].Value.ToString();
                  //  c.AgregaCliente(rfc, cfdi, nombre, calle, numext, numint, colonia, delegacion, localidad, cp, estado, estatus, mail,telefono,tipo);
                    LimpiaDataGrid();
                }
       
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCargaInformacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

     
    }
}
