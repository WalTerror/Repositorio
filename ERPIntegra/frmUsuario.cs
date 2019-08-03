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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmUsuario_KeyPress);
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
           
            TreeNode nodo1 = new TreeNode();
            nodo1.Text = "Administración";
            nodo1.Tag = "1";
            trvFormularios.Nodes.Add(nodo1);

            TreeNode nodo1_1 = new TreeNode();
            nodo1_1.Text = "Clientes";
            nodo1_1.Tag = "1.1";
            nodo1.Nodes.Add(nodo1_1);

            TreeNode nodo1_2 = new TreeNode();
            nodo1_2.Text = "Doctor";
            nodo1_2.Tag = "1.2";
            nodo1.Nodes.Add(nodo1_2);
            
            TreeNode nodo1_3 = new TreeNode();
            nodo1_3.Text = "Proveedor";
            nodo1_3.Tag = "1.3";
            nodo1.Nodes.Add(nodo1_3);

            TreeNode nodo1_4 = new TreeNode();
            nodo1_4.Text = "Alta producto";
            nodo1_4.Tag = "1.4";
            nodo1.Nodes.Add(nodo1_4);

            TreeNode nodo1_5 = new TreeNode();
            nodo1_5.Text = "Catalogo productos";
            nodo1_5.Tag = "1.5";
            nodo1.Nodes.Add(nodo1_5);

            TreeNode nodo1_6 = new TreeNode();
            nodo1_6.Text = "Usuarios";
            nodo1_6.Tag = "1.6";
            nodo1.Nodes.Add(nodo1_6);
            
            TreeNode node2 = new TreeNode();
            node2.Text = "Moviminetos";
            node2.Tag = "2";
            trvFormularios.Nodes.Add(node2);

            TreeNode nodo2_1 = new TreeNode();
            nodo2_1.Text = "Pedido";
            nodo2_1.Tag = "2.1";
            node2.Nodes.Add(nodo2_1);

            TreeNode node3 = new TreeNode();
            node3.Text = "Reportes";
            node3.Tag = "3";
            trvFormularios.Nodes.Add(node3);

            TreeNode node4 = new TreeNode();
            node4.Text = "Inventrarios";
            node4.Tag = "4";
            trvFormularios.Nodes.Add(node4);

            TreeNode nodo4_1 = new TreeNode();
            nodo4_1.Text = "Inventario por rack";
            nodo4_1.Tag = "4.1";
            node4.Nodes.Add(nodo4_1);

            TreeNode node5 = new TreeNode();
            node5.Text = "Configuración";
            node5.Tag = "5";
            trvFormularios.Nodes.Add(node5);

            TreeNode nodo5_1 = new TreeNode();
            nodo5_1.Text = "Categoria y rack";
            nodo5_1.Tag = "5.1";
            node5.Nodes.Add(nodo5_1);

            TreeNode nodo5_2 = new TreeNode();
            nodo5_2.Text = "Laboratorio";
            nodo5_2.Tag = "5.2";
            node5.Nodes.Add(nodo5_2);

            TreeNode nodo5_3 = new TreeNode();
            nodo5_3.Text = "Datos farmacia";
            nodo5_3.Tag = "5.3";
            node5.Nodes.Add(nodo5_3);

            TreeNode nodo5_4 = new TreeNode();
            nodo5_4.Text = "Carga de información";
            nodo5_4.Tag = "5.4";
            node5.Nodes.Add(nodo5_4);

            TreeNode nodo5_5 = new TreeNode();
            nodo5_5.Text = "Ayuda";
            nodo5_5.Tag = "5.5";
            node5.Nodes.Add(nodo5_5);

            TreeNode node6 = new TreeNode();
            node6.Text = "Venta";
            node6.Tag = "6";
            trvFormularios.Nodes.Add(node6);

            TreeNode nodo6_1 = new TreeNode();
            nodo6_1.Text = "Fondo de Caja";
            nodo6_1.Tag = "6.1";
            node6.Nodes.Add(nodo6_1);

            TreeNode nodo6_2 = new TreeNode();
            nodo6_2.Text = "Venta";
            nodo6_2.Tag = "6.2";
            node6.Nodes.Add(nodo6_2);

            TreeNode nodo6_3 = new TreeNode();
            nodo6_3.Text = "Retiro vaja";
            nodo6_3.Tag = "6.3";
            node6.Nodes.Add(nodo6_3);

            TreeNode nodo6_4 = new TreeNode();
            nodo6_4.Text = "Ingreso de valores";
            nodo6_4.Tag = "6.4";
            node6.Nodes.Add(nodo6_4);

            TreeNode nodo6_5 = new TreeNode();
            nodo6_5.Text = "Arqueo de caja";
            nodo6_5.Tag = "6.5";
            node6.Nodes.Add(nodo6_5);

            TreeNode nodo6_6 = new TreeNode();
            nodo6_6.Text = "Corte de caja";
            nodo6_6.Tag = "6.6";
            node6.Nodes.Add(nodo6_6);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardaUsuario();
            buscaid();
            Guardapermiso();
            limpiaformulario();
        }

        private void frmUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        private void trvFormularios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text); 
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void RecorrerNodos(TreeNode treeNode)
        {
           try
            {
                foreach (TreeNode tn in treeNode.Nodes)
                {

                    if (tn.Checked == true)
                    {
                        MessageBox.Show(tn.Tag.ToString());
                    }

                    RecorrerNodos(tn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GuardaUsuario()
        {
            csConexion c = new csConexion();   
            string tipo = "I";
            if (rbtnActivo.Checked == true)
            {               
                string nombre = txtNombre.Text;
                string puesto = txtPuesto.Text;
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;
                int estatus = 1;
                c.AgregaUsuario(nombre, usuario, contraseña, puesto, estatus,tipo);
            }
            else if (rbtnInactivo.Checked == true)
            {
                string nombre = txtNombre.Text;
                string puesto = txtPuesto.Text;
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;
                int estatus = 2;
                c.AgregaUsuario(nombre, usuario, contraseña, puesto, estatus,tipo);
            }
        }
        
        public void buscaid()
        {
             csConexion c = new csConexion();            
             c.BuscaUsuario(txtusuid,txtUsuario.Text);
             string idusuario = txtusuid.Text; 
        }


        public void Guardapermiso()
        {
            csConexion c = new csConexion();

            int idusuario = Int32.Parse(txtusuid.Text.ToString());

            TreeNodeCollection nodes = trvFormularios.Nodes;
            try
            {

                int id = 1;
                foreach (TreeNode rp in nodes)
                {
                    int consecutivo = 1;

                    if (rp.Checked == true)
                    {
                        string nomobj = rp.Text;
                        string padre = rp.Tag.ToString();
                        string act = "T";
                          c.AgregaModulo(id, consecutivo, nomobj, act, idusuario, padre, padre, nomobj);

                        foreach (TreeNode rj in rp.Nodes)
                        {
                            consecutivo++;
                            string activo = "T";
                            string obj = rp.Text + "-" + rj.Text;
                            string llave = rj.Tag.ToString();
                            string des = rj.Text;

                            if (rj.Checked == true)
                            {
                                c.AgregaModulo(id, consecutivo, obj, activo, idusuario, padre, llave, des);
                            }
                            else
                            {
                                string inactivo = "F";
                                c.AgregaModulo(id, consecutivo, obj, inactivo, idusuario, padre, llave, des);
                            }
                        }
                    }
                    else
                    {
                        string nomobj = rp.Text;
                        string padre = rp.Tag.ToString();
                        string inact = "F";

                        c.AgregaModulo(id, consecutivo, nomobj, inact, idusuario, padre, padre, nomobj);

                        foreach (TreeNode rj in rp.Nodes)
                        {
                            string inactivo = "F";

                            if (rj.Checked == false)
                            {
                                string obj = rp.Text + "-" + rj.Text;
                                string llave = rj.Tag.ToString();
                                string des = rj.Text;

                                c.AgregaModulo(id, consecutivo, obj, inactivo, idusuario, padre, llave, des);
                            }
                        }
                    }
                    id++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public void limpiaformulario()
        {
            txtNombre.Clear();
            txtusuid.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtPuesto.Clear();
            rbtnActivo.Checked = false;
            rbtnInactivo.Checked=false;
            trvFormularios.Nodes.Clear();

        }
    }
}
