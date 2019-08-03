using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ERPIntegra
{
    public partial class frmLogin : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=CORP_DESARROLLO\\SQLEXPRESS;Initial Catalog=ERPIntegra;Integrated Security=True");
     
        public string id;
        frmIntegra Integra = new frmIntegra();
        
        public frmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmLogin_KeyPress);      
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtContrasena.Text))
            {
                string usuario = txtUsuario.Text;
                string contraseña = txtContrasena.Text;

                SqlConnection conexion = new SqlConnection("Data Source=CORP_DESARROLLO\\SQLEXPRESS;Initial Catalog=ERPIntegra;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("sp_AccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                conexion.Open();

                SqlDataReader dr = cmd.ExecuteReader(); ;
                if (dr.Read() == true)
                {
                    id = dr["usuId"].ToString();
                    permisosPadres(id);
                    permisosHijos(id);
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Complete datos");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
       
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                    
            }
        }
        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEntrar.Focus();
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContrasena.Focus();
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }
        public void permisosPadres(string id)
        {
            SqlConnection conexion = new SqlConnection("Data Source=CORP_DESARROLLO\\SQLEXPRESS;Initial Catalog=ERPIntegra;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select DISTINCT modId from tbl_Modulos where modUsuId = '" + id + "' and modHabilitado = 'T'", conexion);
           
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
       
            List<string> padre = new List<string>();

            while (dr.Read())
            {
                padre.Add(dr["modId"].ToString());
               //hijo.Add(dr["modLlave"].ToString());
            }

            foreach (string aPart in padre)
            {
                if (aPart == "1")
                {              
                    Integra.mnuAdministracion.Enabled = true;                 
                }
                else if (aPart == "2")
                {
                    Integra.mnuMovimientos.Enabled = true;
                }
                else if (aPart == "3")
                {
                    Integra.mnuReportes.Enabled = true;
                }
                else if (aPart == "4")
                {
                    Integra.mnuInventarios.Enabled = true;
                }
                else if (aPart == "5")
                {
                    Integra.mnuConfiguracion.Enabled = true;
                }
                string usuario = txtUsuario.Text;
                Integra.txtid.Text = id.ToString()+usuario.ToString();
                Integra.Show();
                this.Visible = false;              
            }

         }

        public void permisosHijos(string id)
        {
            SqlCommand cmd = new SqlCommand("select DISTINCT modLlave from tbl_Modulos where modUsuId = '" + id + "' and modHabilitado = 'T'", conexion);

            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            List<string> hijos = new List<string>();

            while (dr.Read())
            {
                hijos.Add(dr["modLlave"].ToString());    
            }

            foreach( string item in hijos)
            {                        
               string valor = item;
            
                if (item.Contains("1.1"))
               {
                    Integra.subClientes.Enabled = true;
               }
                else if(item.Contains("1.2"))
                {
                    Integra.subDoctor.Enabled = true;
                }
                else if (item.Contains("1.3"))
                {
                    Integra.subProveedor.Enabled = true;
                }
                else if (item.Contains("1.4"))
                {
                    Integra.subProductos.Enabled = true;
                    Integra.subAltaProductos.Enabled = true;
                }
                else if (item.Contains("1.5"))
                {
                    Integra.subProductos.Enabled = true;
                    Integra.subCatalogoProd.Enabled = true;
                }
                else if (item.Contains("1.6"))
                {
                    Integra.subUsuario.Enabled = true;
                }
                else if (item.Contains("2.1"))
                {
                    Integra.subPedido.Enabled = true;
                }
                else if (item.Contains("4.1"))
                {
                    Integra.subInvrack.Enabled = true;
                }
                else if (item.Contains("5.1"))
                {
                    Integra.subDepto.Enabled = true;
                }
                else if (item.Contains("5.2"))
                {
                    Integra.subLaboratorio.Enabled = true;
                }
                else if (item.Contains("5.3"))
                {
                    Integra.subFarmacia.Enabled = true;
                }
                else if (item.Contains("5.4"))
                {
                    Integra.subCargaInformacion.Enabled = true;
                }
                else if (item.Contains("5.5 "))
                {
                    Integra.subAyuda.Enabled = true;
                }
                else if (item.Contains("6.1 "))
                {
                    Integra.btnFondoC.Enabled = true;
                } 
            }
        }     
    }
}
