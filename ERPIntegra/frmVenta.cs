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
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmVenta_KeyPress);        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
               // .ToString("HH:MM:SS");
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCatalogoProd catprod = new frmCatalogoProd();
            catprod.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCliente catclie = new frmCliente();
            catclie.Show();
        }

        private void frmVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmCliente catclie = new frmCliente();
                catclie.Show();
            }
            if (e.KeyCode == Keys.F2)
            {
                frmCatalogoProd catprod = new frmCatalogoProd();
                catprod.Show();
            }
        }

        private void frmVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }
    }
}
