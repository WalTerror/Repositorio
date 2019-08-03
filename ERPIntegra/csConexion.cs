using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERPIntegra
{
    class csConexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
         public csConexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=DESARROLLO1_COR\\CORP_DESARROLLO;Initial Catalog=ERPIntegra;User ID=sa;Password=DevUser");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexion a la base de datos" + ex.ToString());
            }
        }
         public  int AccesoSistema(string usuario, string contraseña)
         {
             int resultado = -1;
             cmd = new SqlCommand("select * from vw_CargaUsuario where usuario='" + usuario + "' and contraseña ='" + contraseña + "'", cn);
                 dr = cmd.ExecuteReader();

                 if (dr.Read() == true)
                 {
                     resultado = 50;                  
                 }
                 else
                 {
                     MessageBox.Show("Datos Incorrectos");                   
                 }             
                /* while (dr.Read())
                 {
                     resultado = 50;
                 }*/

                 cn.Close();
                 return resultado;           
         }
         public string AgregaModulo(int id, int nivel, string objeto, string estatus, int usu, string padre, string llave, string descripcion)
         {
             string insertado = "Se asignaron  corretcamente los  modulos";

             try
             {
                 cmd = new SqlCommand("sp_ModulosUsu", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@id", id));
                 cmd.Parameters.Add(new SqlParameter("@modNivel", nivel));
                 cmd.Parameters.Add(new SqlParameter("@modNombreObj", objeto));
                 cmd.Parameters.Add(new SqlParameter("@modHabilitado", estatus));
                 cmd.Parameters.Add(new SqlParameter("@usuid", usu));
                 cmd.Parameters.Add(new SqlParameter("@modPadre", padre));
                 cmd.Parameters.Add(new SqlParameter("@modLlave", llave));
                 cmd.Parameters.Add(new SqlParameter("@modDescr", descripcion));
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(insertado);

             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al asignar modulo ." + ex.ToString());
             }
             return insertado;
         }
         public string AgregaDepartamento(string departamento,string tipo)
         {
             string insertado = "Se guardo corretcamente el departamento";
             try
             {
                 cmd = new SqlCommand("sp_Departamento", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@departamento", departamento));
                 cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(insertado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al guardar el departamento." + ex.ToString());
             }
             return insertado;
         }
         public string AgregaRack(string rack,string tipo)
         {
             string insertado = "Se guardo corretcamente el rack";
             try
             {
                 cmd = new SqlCommand("sp_Rack", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@rack", rack));
                 cmd.Parameters.Add(new SqlParameter("@Tipo", tipo));
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(insertado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al guardar el rack." + ex.ToString());
             }
             return insertado;
         }
         public string AgregaLaboratorio(string laboratorio,string tipo)
         {
             string insertado = "Se guardo corretcamente el laboratorio";
             try
             {
                 cmd = new SqlCommand("sp_Laboratorio", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@laboratorio", laboratorio));
                 cmd.Parameters.Add(new SqlParameter("@Tipo", tipo));
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(insertado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al guardar el laboratorio." + ex.ToString());
             }
             return insertado;
         }
         public string AgregaDoctor(int Cedula, string Nombre, string Domicilio, int status, string tipo)
         {
             
                 string insertado = "Se guardo corretcamente el doctor";
                 try
                 {
                     cmd = new SqlCommand("sp_Doctor", cn);
                     cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.Add(new SqlParameter("@Cedula", Cedula));
                     cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                     cmd.Parameters.Add(new SqlParameter("@domicilio", Domicilio));
                     cmd.Parameters.Add(new SqlParameter("@status", status));
                     cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                     cmd.ExecuteNonQuery();
                     MessageBox.Show(insertado);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error al guardar datos del doctor." + ex.ToString());
                 }
                 return insertado;            
            
         }
         public string AgregaCliente(string rfc, int cfdi, string nombre, string calle, string numext, string numint, string colonia, string delegacion, string localidad, int cp, int estado, int estatus, string mail, string telefono,string tipo)
         {
             string insertado = "Se guardo corretcamente el cliente";
             try
             {
                 cmd = new SqlCommand("sp_Cliente", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@rfc", rfc));
                 cmd.Parameters.Add(new SqlParameter("@cfdi", cfdi));
                 cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                 cmd.Parameters.Add(new SqlParameter("@calle", calle));
                 cmd.Parameters.Add(new SqlParameter("@numext", numext));
                 cmd.Parameters.Add(new SqlParameter("@numint", numint));
                 cmd.Parameters.Add(new SqlParameter("@colonia", colonia));
                 cmd.Parameters.Add(new SqlParameter("@delegacion", delegacion));
                 cmd.Parameters.Add(new SqlParameter("@localidad", localidad));
                 cmd.Parameters.Add(new SqlParameter("@cp", cp));
                 cmd.Parameters.Add(new SqlParameter("@estado", estado));
                 cmd.Parameters.Add(new SqlParameter("@status", estatus));
                 cmd.Parameters.Add(new SqlParameter("@mail", mail));
                 cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                 cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
        
                 cmd.ExecuteNonQuery();
                   MessageBox.Show(insertado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al guardar datos del cliente." + ex.ToString());
             }
             return insertado;
         }
         public string AgregaProveedor(string RFC, string nombre, string mail, string telefono, string calle, string colonia, string delegacion, string numint, string numext, string localidad, int cp, int estatus, int estado, string tipo)
         {
             string insertado = "Se guardo corretcamente el proveedor";
             try
             {
                 cmd = new SqlCommand("sp_Proveedor", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@rfc", RFC));
                 cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                 cmd.Parameters.Add(new SqlParameter("@mail", mail));
                 cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                 cmd.Parameters.Add(new SqlParameter("@status", estatus));
                 cmd.Parameters.Add(new SqlParameter("@calle", calle));
                 cmd.Parameters.Add(new SqlParameter("@colonia", colonia));
                 cmd.Parameters.Add(new SqlParameter("@delegacion", delegacion));
                 cmd.Parameters.Add(new SqlParameter("@numint", numint));
                 cmd.Parameters.Add(new SqlParameter("@numext", numext));
                 cmd.Parameters.Add(new SqlParameter("@localidad", localidad));
                 cmd.Parameters.Add(new SqlParameter("@estado", estado));
                 cmd.Parameters.Add(new SqlParameter("@cp", cp));
                 cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(insertado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al guardar datos del proveedor." + ex.ToString());
             }
             return insertado;
         }
         public string AgregaUsuario(string nombre, string usuario, string contraseña, string puesto, int estatus,string tipo)
         {
             string insertado = "Se guardo corretcamente el usuario";
             try
             {
                 cmd = new SqlCommand("sp_Usuario", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                 cmd.Parameters.Add(new SqlParameter("@usuario", usuario));
                 cmd.Parameters.Add(new SqlParameter("@contraseña", contraseña));
                 cmd.Parameters.Add(new SqlParameter("@puesto", puesto));
                 cmd.Parameters.Add(new SqlParameter("@estatus", estatus));
                 cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(insertado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al guardar el usuario." + ex.ToString());
             }
             return insertado;
         }
         public string Agregaproducto(string codigo, string clavesat, string nombre, string sustnacia,string presentacion,int laboratorio,int proveedor,int categoria,int rack, int antibiotico, int iva,int multiplo,string terapeutico, decimal precioc, decimal preciol,decimal preciov,decimal precioe,string tipo)
         {
             string insertado = "Se guardo corretcamente el producto";
             try
             {
                 cmd = new SqlCommand("sp_Producto", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@codigob", codigo));
                 cmd.Parameters.Add(new SqlParameter("@clavesat", clavesat));
                 cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                 cmd.Parameters.Add(new SqlParameter("@sustancia", sustnacia));
                 cmd.Parameters.Add(new SqlParameter("@presentacion", presentacion));
                 cmd.Parameters.Add(new SqlParameter("@laboratorio", laboratorio));
                 cmd.Parameters.Add(new SqlParameter("@proveedor", proveedor));
                 cmd.Parameters.Add(new SqlParameter("@categoria", categoria));
                 cmd.Parameters.Add(new SqlParameter("@rack", rack));
                 cmd.Parameters.Add(new SqlParameter("@antibiotico", antibiotico));
                 cmd.Parameters.Add(new SqlParameter("@tipoiva", iva));
                 cmd.Parameters.Add(new SqlParameter("@multiplo", multiplo));
                 cmd.Parameters.Add(new SqlParameter("@terapeutico", terapeutico));
                 cmd.Parameters.Add(new SqlParameter("@precioc", precioc));
                 cmd.Parameters.Add(new SqlParameter("@preciol", preciol));
                 cmd.Parameters.Add(new SqlParameter("@preciov", preciov));
                 cmd.Parameters.Add(new SqlParameter("@precioe", precioe));
                 cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(insertado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al guardar el usuario." + ex.ToString());
             }
             return insertado;
         }
         public void BuscaUsuario(TextBox tx, string usuario)
         {
             string a;
             try
             {
                 cmd = new SqlCommand("SELECT TOP 1 usuId FROM tbl_Usuario where usuUsuario='" + usuario + "' and stsid= 1 ORDER BY usuid DESC", cn);
                 dr = cmd.ExecuteReader();

                 if (dr.Read() == true)
                 {
                     tx.Text = dr["usuId"].ToString();
                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al cargar datos" + ex.ToString());
             }
             cn.Close();
         }
         public void BuscaPedido(DataGridView dgv, int estatus)
         {
             try
             {
                 // da = new SqlDataAdapter("Select DISTINCT *  from vw_pedidos where vw_pedidos.ESTATUSPEDIDO='"+estatus+"'", cn);
                 da = new SqlDataAdapter("Select DISTINCT  * FROM  vw_pedidos where vw_pedidos.ESTATUSPEDIDO='" + estatus + "'", cn);

                 dt = new DataTable();
                 da.Fill(dt);
                 dgv.DataSource = dt;
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al cargar datos" + ex.ToString());
             }

         }
         public void cargaDoctor(DataGridView dgv)
         {
             try
             {
                 da = new SqlDataAdapter("select  CEDULA,NOMBRE,DOMICILIO,DESCRIPCION from vw_CargaDoctor", cn);
                 dt = new DataTable();
                 da.Fill(dt);
                 dgv.DataSource = dt;
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al cargar datos" + ex.ToString());
             }
         }
         public void cargaLaboratorio(DataGridView dgv)
         {
             try
             {
                 da = new SqlDataAdapter("select labid,labDescrip as Laboratorio from tbl_Laboratorio", cn);
                 dt = new DataTable();
                 da.Fill(dt);
                 dgv.DataSource = dt;
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al cargar datos" + ex.ToString());
             }
         }
         public void cargaProveedor(DataGridView dgv)
         {
             try
             {
                 da = new SqlDataAdapter("select * from vw_CargaProveedor", cn);
                 dt = new DataTable();
                 da.Fill(dt);
                 dgv.DataSource = dt;
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al cargar datos" + ex.ToString());
             }
         }
         public void cargaCliente(DataGridView dgv)
         {
             try
             {
                 da = new SqlDataAdapter("select * from vw_CargaCliente", cn);
                 dt = new DataTable();
                 da.Fill(dt);
                 dgv.DataSource = dt;
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al cargar datos" + ex.ToString());
             }
         }
         public void cbmEstatus(ComboBox cmb)
         {
             cmd = new SqlCommand("SELECT stsId, stsDescrip from tbl_Status", cn);
             da.SelectCommand = cmd;
             dt = new DataTable();
             da.Fill(dt);
             cmb.DataSource = dt;
         }
         public void cargaProducto(DataGridView dgv)
         {
             try
             {
                 //da = new SqlDataAdapter("select proCodigoBarra,proNombre,proSusAct,proPresentacion,proProveedor,proRack  from tbl_Productos", cn);
                 da = new SqlDataAdapter("select * from vw_Producto", cn);
                 dt = new DataTable();
                 da.Fill(dt);
                 dgv.DataSource = dt;
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al cargar datos" + ex.ToString());
             }
         }
         public void cargaPedido(DataGridView dgv)
         {
             try
             {
                 da = new SqlDataAdapter(" select * from vw_PedidoSugerido", cn);
                 dt = new DataTable();
                 da.Fill(dt);
                 dgv.DataSource = dt;

             }
             catch (Exception ex)
             {
             }
         }
         public string GuardaPedido(int status, decimal subtotal,decimal ivatotal,decimal total,int tipopedido,int usuario,string pc,string codigo, int pzapedir, int existencia, decimal costo,int tipoiva,string tiposp)
         {
             string insertado = "Se guardo correctamente el pedido";

             try
             {
                 cmd = new SqlCommand("sp_Pedido", cn);
                // cmd = new SqlCommand("sp_pruebapedido",cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@status", status));
                 cmd.Parameters.Add(new SqlParameter("@subtotal", subtotal));
                 cmd.Parameters.Add(new SqlParameter("@ivatotal", ivatotal));
                 cmd.Parameters.Add(new SqlParameter("@total", total));
                 cmd.Parameters.Add(new SqlParameter("@tipopedido", tipopedido));
                 cmd.Parameters.Add(new SqlParameter("@usuario", usuario));
                 cmd.Parameters.Add(new SqlParameter("@pc", pc));
                 cmd.Parameters.Add(new SqlParameter("@codigopro", codigo));
                 cmd.Parameters.Add(new SqlParameter("@pzapedidas", pzapedir));                 
                 cmd.Parameters.Add(new SqlParameter("@existencia", existencia));
                 cmd.Parameters.Add(new SqlParameter("@costo", costo));
                 cmd.Parameters.Add(new SqlParameter("@tipoiva", tipoiva));
                 cmd.Parameters.Add(new SqlParameter("@tipo", tiposp));
                 cmd.ExecuteNonQuery();
                // MessageBox.Show(insertado);

             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al guardar datos del proveedor." + ex.ToString());
             }
             return insertado;

         }

         public string ActualizaDetalle(string pc)
         {
             string insertado = "Se actualizó correctamente el pedido";

             try
             {
                 cmd = new SqlCommand("sp_ActualizaDetalle", cn);
                 cmd.Parameters.Add(new SqlParameter("@pc", pc));
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(insertado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al actualizar datos de detalle." + ex.ToString());
             }
             return insertado;

         }    
         public string ModificaDoctor(int Cedula, string Nombre, string Domicilio, int status, string tipo)
         {
             string insertado = "Se actualizo corretcamente el doctor";
             try
             {
                 cmd = new SqlCommand("sp_Doctor", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@Cedula", Cedula));
                 cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                 cmd.Parameters.Add(new SqlParameter("@domicilio", Domicilio));
                 cmd.Parameters.Add(new SqlParameter("@status", status));
                 cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(insertado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al actualzar datos del doctor." + ex.ToString());
             }
             return insertado;

         }
         public string ModificaLaboratorio(int id,string laboratorio,string tipo)
         {
             string modificado = "Se actualizo corretcamente el laboratorio";
             try
             {
                 cmd = new SqlCommand("sp_Laboratorio", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@id", id));
                 cmd.Parameters.Add(new SqlParameter("@laboratorio", laboratorio));
                 cmd.Parameters.Add(new SqlParameter("@Tipo", tipo));
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(modificado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al guardar el laboratorio." + ex.ToString());
             }
             return modificado;
         }
         public string ModificaProveedor(string RFC, string nombre, string mail, string telefono, string calle, string colonia, string delegacion, string numint, string numext, string localidad, int cp, int estatus, int estado, string tipo)
         {
             string insertado = "Se actualizo corretcamente el proveedor";
             try
             {
                 cmd = new SqlCommand("sp_Proveedor", cn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@rfc", RFC));
                 cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                 cmd.Parameters.Add(new SqlParameter("@mail", mail));
                 cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                 cmd.Parameters.Add(new SqlParameter("@status", estatus));
                 cmd.Parameters.Add(new SqlParameter("@calle", calle));
                 cmd.Parameters.Add(new SqlParameter("@colonia", colonia));
                 cmd.Parameters.Add(new SqlParameter("@delegacion", delegacion));
                 cmd.Parameters.Add(new SqlParameter("@numint", numint));
                 cmd.Parameters.Add(new SqlParameter("@numext", numext));
                 cmd.Parameters.Add(new SqlParameter("@localidad", localidad));
                 cmd.Parameters.Add(new SqlParameter("@estado", estado));
                 cmd.Parameters.Add(new SqlParameter("@cp", cp));
                 cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                 cmd.ExecuteNonQuery();
                 MessageBox.Show(insertado);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al actualizar datos del proveedor." + ex.ToString());
             }
             return insertado;
         }
         public List<lisLaboratorio> cargacomboLab(ComboBox cmb)
         {
             List<lisLaboratorio> lab = new List<lisLaboratorio>();
             using (cn)
             {
                 cmd = new SqlCommand("SELECT labId,labDescrip from tbl_Laboratorio", cn);
                 dr = cmd.ExecuteReader();

                 while (dr.Read())
                 {
                     lisLaboratorio laboratorio = new lisLaboratorio();
                     laboratorio.id = dr.GetInt32(0);
                     laboratorio.desc = dr[1].ToString();
                     lab.Add(laboratorio);                  
                 }
             }
             return lab;                    
         }        
         public List<lisProveedor> cargacomboProv(ComboBox cmb)
         {
             List<lisProveedor> prov = new List<lisProveedor>();

             using (SqlConnection cnn = new SqlConnection("Data Source=DESARROLLO1_COR\\CORP_DESARROLLO;Initial Catalog=ERPIntegra;User ID=sa;Password=DevUser"))
             {
                 cnn.Open();
                 cmd = new SqlCommand("SELECT PId,PNombre from tbl_Proveedor", cnn);
                 SqlDataReader dr1 = cmd.ExecuteReader();

                while (dr1.Read())
                 {
                     lisProveedor proveedor = new lisProveedor();
                     proveedor.idp = dr1.GetInt32(0);
                     proveedor.prov = dr1[1].ToString();
                     prov.Add(proveedor);
                 }
             }
             return prov;
         }
         public List<lisDepartamento> cargacomboDpto(ComboBox cmb)
        {
            List<lisDepartamento> depto = new List<lisDepartamento>();

            using (SqlConnection cnn = new SqlConnection("Data Source=DESARROLLO1_COR\\CORP_DESARROLLO;Initial Catalog=ERPIntegra;User ID=sa;Password=DevUser"))
            {
                cnn.Open();
                cmd = new SqlCommand("SELECT dptoId,dptoDescripcion from tbl_Departamento", cnn);
                SqlDataReader dr1 = cmd.ExecuteReader();

                while (dr1.Read())
                {
                    lisDepartamento departamento = new lisDepartamento();
                    departamento.idd = dr1.GetByte(0);
                    departamento.dpto = dr1[1].ToString();
                    depto.Add(departamento);
                }
            }
            return depto;
        }
         public List<lisrack> cargacomboRack(ComboBox cmb)
        {
            List<lisrack> rack = new List<lisrack>();

            using (SqlConnection cnn = new SqlConnection("Data Source=DESARROLLO1_COR\\CORP_DESARROLLO;Initial Catalog=ERPIntegra;User ID=sa;Password=DevUser"))
            {
                cnn.Open();
                cmd = new SqlCommand("SELECT rackId,rackDescripcion from tbl_rack", cnn);
                SqlDataReader dr1 = cmd.ExecuteReader();

                while (dr1.Read())
                {
                    lisrack rac = new lisrack();
                    rac.idr = dr1.GetByte(0);
                    rac.rack = dr1[1].ToString();
                    rack.Add(rac);
                }
            }
            return rack;
        }
         public List<lisDenominaciones> cargarDenominaciones(DataGridView dgv)
        {
            List<lisDenominaciones> deno = new List<lisDenominaciones>();

            using (cn)
            {
               
                cmd = new SqlCommand("SELECT denId,denDescr,denValor,denTipo from tbl_Denominaciones", cn);              
                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    lisDenominaciones denominacion = new lisDenominaciones();
                    denominacion.denId = Int32.Parse(dr[0].ToString());
                    denominacion.denDescr = dr[1].ToString();
                    denominacion.denValor =Decimal.Parse(dr[2].ToString());
                    denominacion.denTipo = dr[3].ToString();
                    deno.Add(denominacion);
                }

            }
            return deno;
        }
         public List<lisEstado> cargacomboEstadostados()
         {
             List<lisEstado> estado = new List<lisEstado>();

             using (SqlConnection cnn = new SqlConnection("Data Source=DESARROLLO1_COR\\CORP_DESARROLLO;Initial Catalog=ERPIntegra;User ID=sa;Password=DevUser"))
             {
                 cnn.Open();
                 cmd = new SqlCommand("SELECT edoId,edoDescripcion from tbl_Estados", cnn);
                 SqlDataReader dr = cmd.ExecuteReader();

                 while (dr.Read())
                 {
                     lisEstado estados = new lisEstado();
                     //estados.edoId = dr.GetByte(0);
                     estados.edoId = Int32.Parse(dr[0].ToString());
                     estados.edoDescripcion = dr[1].ToString();
                     estado.Add(estados);
                 }
             }
             return estado;
         }
         public List<lisCFDI> cargacomboCFDI()
         {
             List<lisCFDI> ucfdi = new List<lisCFDI>();

             using (SqlConnection cnn = new SqlConnection("Data Source=DESARROLLO1_COR\\CORP_DESARROLLO;Initial Catalog=ERPIntegra;User ID=sa;Password=DevUser"))
             {
                 cnn.Open();
                 cmd = new SqlCommand("SELECT ucfdiId,ucfdiDescripcion from tbl_Usocfdi", cnn);
                 SqlDataReader dr = cmd.ExecuteReader();

                 while (dr.Read())
                 {
                     lisCFDI cfdi = new lisCFDI();
                     cfdi.ucfdiId = Int32.Parse(dr[0].ToString());
                     cfdi.ucfdiDescripcion = dr[1].ToString();
                     ucfdi.Add(cfdi);
                 }
             }
             return ucfdi;
         }

         internal void ActualizaDetalle()
         {
             throw new NotImplementedException();
         }
    }
}
