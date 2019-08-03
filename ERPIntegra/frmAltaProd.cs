using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ERPIntegra
{
    public partial class frmAltaProd : Form
    {
        csConexion c = new csConexion();
        public frmAltaProd()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmAltaProd_KeyPress);
        }
        private void frmAltaProd_Load(object sender, EventArgs e)
        {
            cbmLaboratorio.DataSource = c.cargacomboLab(cbmLaboratorio);
            cbmLaboratorio.ValueMember = "id";
            cbmLaboratorio.DisplayMember = "desc";
            cbmProveedor.DataSource = c.cargacomboProv(cbmProveedor);
            cbmProveedor.ValueMember = "idp";
            cbmProveedor.DisplayMember = "prov";
            cbmDepartamento.DataSource = c.cargacomboDpto(cbmDepartamento);
            cbmDepartamento.ValueMember = "idd";
            cbmDepartamento.DisplayMember = "dpto";
            cbmRack.DataSource = c.cargacomboRack(cbmRack);
            cbmRack.ValueMember = "idr";
            cbmRack.DisplayMember = "rack";
        }         

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            csConexion aprod= new csConexion();
            string tipo = "I";
            string  codigobarras = txtCodigo.Text;
            string clavesat = txtCsat.Text; 
            string nombre = txtNombre.Text;
            string sustancia = txtSustancia.Text;
            string presentacion = txtPresentacion.Text;   
            int laboratorio = Int32.Parse(cbmLaboratorio.SelectedValue.ToString());
            int proveedor = Int32.Parse(cbmProveedor.SelectedValue.ToString());
            int categoria = Int32.Parse(cbmDepartamento.SelectedValue.ToString());           
            int rack = Int32.Parse(cbmRack.SelectedValue.ToString());
            int antibiotico;
            int iva =Int32.Parse(cbxIVA.SelectedItem.ToString());
            int multiplo = Int32.Parse(txtPzscaja.Text.ToString());
            string terapeutico = txtIndiceTerapeutico.Text;
            decimal precioc = Decimal.Parse(txtCostocom.Text.ToString());
            decimal preciov = Decimal.Parse(txtPreciop.Text.ToString());          
            decimal precioes = Decimal.Parse(txtDescesp.Text.ToString());
            decimal preciol = Decimal.Parse(txtdesc.Text.ToString());
         

            if(chkAntibiotico.Checked==true)
            {
                antibiotico = 1;
            }
            else
            {
                antibiotico = 0;
            }

            if ((preciov < precioc) ||(preciol < precioc) || (precioes < precioc) )
            {
                MessageBox.Show("Valide los precios, están por debajo del costo de compra.");

            }
            else               
                {
                    //MessageBox.Show("Pasa parametros");
                    aprod.Agregaproducto(codigobarras, clavesat, nombre, sustancia, presentacion, laboratorio, proveedor, categoria, rack, antibiotico, iva, multiplo, terapeutico, precioc, preciol, preciov, precioes, tipo); 
                }            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            frmLaboratorio lab = new frmLaboratorio();
            lab.Show();        
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor prov = new frmProveedor();
            prov.Show();
        }

        private void frmAltaProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }

        private void frmAltaProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        

        
    }
}
