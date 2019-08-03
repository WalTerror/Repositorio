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
using Excel = Microsoft.Office.Interop.Excel; 


namespace ERPIntegra
{
    public partial class frmPedido : Form
    {
         csConexion c = new csConexion();
        string levicpedido = @"C:\PedidoLevic\levic.xls";
        string levic = @"C:\pedido\levic.txt";
        string otro = @"C:\otro\otro.txt";
 
        public frmPedido()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmPedido_KeyPress);
        }
        private void frmEntradaProd_Load(object sender, EventArgs e)
        {
            
        }
        private void dgvProductoEntrada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmEntradaProd_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F2)
            {
                frmCatalogoProd pro = new frmCatalogoProd();
                pro.Show();
            }
        }
        private void rbtPManual_CheckedChanged(object sender, EventArgs e)
        {
            dgvProductoEntrada.DataSource = null;
            btnProductos.Visible = true;
           // LimpiaDataGrid();
        }
        private void rbtPSugerido_CheckedChanged(object sender, EventArgs e)
        {
            c.cargaPedido(dgvProductoEntrada);
            dgvProductoEntrada.AllowUserToAddRows = true;
            this.dgvProductoEntrada.Columns[0].Visible = true;
            this.dgvProductoEntrada.Columns[11].Visible = true;
            btnProductos.Visible = false;
        }
        private void btnEnviarP_Click(object sender, EventArgs e)
        {
            TextWriter rlevic = new StreamWriter(@"C:\pedido\levic.txt");
            TextWriter rotro = new StreamWriter(@"C:\otro\otro.txt");

            if (rbtPSugerido.Checked == true)
            {              
                foreach (DataGridViewRow row in dgvProductoEntrada.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[4].Value))
                    {
                        string idp = row.Cells[4].Value.ToString();

                        if (idp == "1")
                        {
                            string fila = row.Cells["CODIGO"].Value.ToString() + "|" + row.Cells["DESCRIPCIÓN"].Value.ToString() + "|" + row.Cells["PROVEEDOR"].Value.ToString() + "|" + row.Cells["PZAPEDIR"].Value.ToString() + "|" + row.Cells["PRECIO"].Value.ToString() + "|" + row.Cells["IVA"].Value.ToString() + "|" + row.Cells["STOTAL"].Value.ToString() + "|" + row.Cells["TOTALP"].Value.ToString() + "\n";
                            rlevic.Write(fila);
                        }
                        else
                        {
                            string fila = row.Cells["CODIGO"].Value.ToString() + "|" + row.Cells["DESCRIPCIÓN"].Value.ToString() + "|" + row.Cells["PROVEEDOR"].Value.ToString() + "|" + row.Cells["PZAPEDIR"].Value.ToString() + "|" + row.Cells["PRECIO"].Value.ToString() + "|" + row.Cells["IVA"].Value.ToString() + "|" + row.Cells["STOTAL"].Value.ToString() + "|" + row.Cells["TOTALP"].Value.ToString() + "\n";
                            rotro.Write(fila);
                        }
                    }
                }
                rlevic.Close();
                rotro.Close();

                string pza = txtPza.Text;
                string sub = txtsubtotal.Text;
                string total = txtTotalPedido.Text;

                pedidolevic(pza, sub, total);
                pedidotro(pza, sub, total);
                LimpiaDataGrid();
                txtPza.Clear();
                txtsubtotal.Clear();
                txtTotalPedido.Clear();
            }
            else if (rbtPManual.Checked == true)
            {
                foreach (DataGridViewRow row in dgvProductoEntrada.Rows)
                {

                    if (row.Cells[0].Value!=null)
                    {
                        string idp = row.Cells[0].Value.ToString();
                        if (idp == "1")
                        {
                            string fila = row.Cells["CODIGO"].Value.ToString() + "|" + row.Cells["DESCRIPCIÓN"].Value.ToString() + "|" + row.Cells["PROVEEDOR"].Value.ToString() + "|" + row.Cells["PZAPEDIR"].Value.ToString() + "|" + row.Cells["PRECIO"].Value.ToString() + "|" + row.Cells["IVA"].Value.ToString() + "|" + row.Cells["STOTAL"].Value.ToString() + "|" + row.Cells["TOTALP"].Value.ToString() + "\n";
                            rlevic.Write(fila);                          
                          
                        }
                        else
                        {
                            string fila = row.Cells["CODIGO"].Value.ToString() + "|" + row.Cells["DESCRIPCIÓN"].Value.ToString() + "|" + row.Cells["PROVEEDOR"].Value.ToString() + "|" + row.Cells["PZAPEDIR"].Value.ToString() + "|" + row.Cells["PRECIO"].Value.ToString() + "|" + row.Cells["IVA"].Value.ToString() + "|" + row.Cells["STOTAL"].Value.ToString() + "|" + row.Cells["TOTALP"].Value.ToString() + "\n";
                            rotro.Write(fila);
                        }
                    }
                }
                rlevic.Close();
                rotro.Close();

                string pza = txtPza.Text;
                string sub = txtsubtotal.Text;
                string total = txtTotalPedido.Text;

                pedidolevic(pza, sub, total);
                pedidotro(pza, sub, total);
            
                txtPza.Clear();
                txtsubtotal.Clear();
                txtTotalPedido.Clear();
               
            }
        }
        private void LimpiaDataGrid()
        {
            DataTable dt = (DataTable)dgvProductoEntrada.DataSource;
            dt.Clear();
        }
        private void frmPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            char mayuscula;
            mayuscula = Char.ToUpper(e.KeyChar);
            e.KeyChar = mayuscula;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {  
            if (rbtPSugerido.Checked == true)
            {
                //DATOS CABECERA PEDIDO
                string tipogp = "GP";
                int status = 3;
                decimal subtotal = Convert.ToDecimal(txtsubtotal.Text);
                decimal ivatotal = Convert.ToDecimal(txtIva.Text);
                decimal total = Convert.ToDecimal(txtTotalPedido.Text);
                int descripcionpedido = 1;
                int usuario = 15;
                string pc = Environment.MachineName;             

                for (int fila = 0; fila < dgvProductoEntrada.Rows.Count - 1; fila++)
                {                 
                    string codigo = dgvProductoEntrada.Rows[fila].Cells["CODIGO"].Value.ToString();
                    int pzapedir = Convert.ToInt32(dgvProductoEntrada.Rows[fila].Cells["PZAPEDIR"].Value.ToString());
                    int existencia = Convert.ToInt32(dgvProductoEntrada.Rows[fila].Cells["EXISTENCIA"].Value.ToString());
                    decimal costo = Convert.ToDecimal(dgvProductoEntrada.Rows[fila].Cells["PRECIO"].Value.ToString());
                    int ivaproducto = Convert.ToInt32(dgvProductoEntrada.Rows[fila].Cells["IVA"].Value.ToString());
                    
                  //  MessageBox.Show("codigo" + "-" + codigo + "-" + pzapedir + "-" + existencia + "-" + costo + "-"+ ivaproducto);
                   c.GuardaPedido(status, subtotal, ivatotal, total, descripcionpedido, usuario, pc, codigo, pzapedir, existencia, costo, ivaproducto, tipogp);
                  
                }
               
                c.ActualizaDetalle(pc);
            }
            else if (rbtPManual.Checked == true)
            {
                string tipogpm = "GP";
                int statusm = 3;
                string subtotalm = txtsubtotal.Text;
                string ivatotalm = txtIva.Text;
                string totalm = txtTotalPedido.Text;
                int descripcionpedidom= 1;
                int usuariom = 15;
                string pcm = Environment.MachineName;
                string codigom = dgvProductoEntrada.CurrentRow.Cells[1].Value.ToString();
                string preciom = dgvProductoEntrada.CurrentRow.Cells[4].Value.ToString();
                string ivaprodm = dgvProductoEntrada.CurrentRow.Cells[5].Value.ToString();
                string pzapedirm = dgvProductoEntrada.CurrentRow.Cells[9].Value.ToString(); 
            }
        }
        private void total()
        {
            double total = 0;
            int pza = 0;
            decimal subt = 0;
            decimal totaliva = 0;

            foreach (DataGridViewRow row in dgvProductoEntrada.Rows)
            {
                total += Convert.ToDouble(row.Cells["TOTALP"].Value);
                pza += Convert.ToInt32(row.Cells["PZAPEDIR"].Value);
                decimal s= Convert.ToDecimal(row.Cells["PRECIO"].Value) * Convert.ToDecimal(row.Cells["PZAPEDIR"].Value);
                subt += s;
                decimal iprod = (((Convert.ToDecimal(row.Cells["PRECIO"].Value) * Convert.ToDecimal(row.Cells["IVA"].Value)) / 100) * Convert.ToDecimal(row.Cells["PZAPEDIR"].Value));
                totaliva += iprod;
            }           
            txtTotalPedido.Text = total.ToString();
            txtPza.Text = pza.ToString();
            txtsubtotal.Text = subt.ToString();
            txtIva.Text = totaliva.ToString();
        }
        private void subtotal()
        {
            double sumatoria = 0;
            foreach (DataGridViewRow row in dgvProductoEntrada.Rows)
            {
                sumatoria += Convert.ToDouble(row.Cells["TOTALP"].Value);
            }
            txtTotalPedido.Text = Convert.ToString(sumatoria);
        }       
        private void dgvProductoEntrada_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(rbtPSugerido.Checked==true)
            {
                if (dgvProductoEntrada.Columns[e.ColumnIndex].Name == "PZAPEDIR" || dgvProductoEntrada.Columns[e.ColumnIndex].Name == "IVA" || dgvProductoEntrada.Columns[e.ColumnIndex].Name == "PRECIO")
                {
                    decimal totalColumna = 0;
                    decimal subtotal = 0;
                    int totalpieza = 0;
                    decimal totaliva = 0;

                    foreach (DataGridViewRow row in dgvProductoEntrada.Rows)
                    {
                        totalpieza += Convert.ToInt32(row.Cells["PZAPEDIR"].Value);
                        decimal sub = Convert.ToDecimal(row.Cells["PRECIO"].Value) * Convert.ToDecimal(row.Cells["PZAPEDIR"].Value);
                        decimal iva = (((Convert.ToDecimal(row.Cells["PRECIO"].Value) * Convert.ToDecimal(row.Cells["IVA"].Value)) / 100) + Convert.ToDecimal(row.Cells["PRECIO"].Value));
                        decimal ivaprod = (((Convert.ToDecimal(row.Cells["PRECIO"].Value) * Convert.ToDecimal(row.Cells["IVA"].Value)) / 100) * Convert.ToDecimal(row.Cells["PZAPEDIR"].Value));
                        decimal totalFila = Convert.ToDecimal(row.Cells["PZAPEDIR"].Value) * iva;
                        row.Cells["TOTALP"].Value = totalFila;
                        row.Cells["STOTAL"].Value = sub;
                        subtotal += sub;
                        totalColumna += totalFila;
                        totaliva+=ivaprod;
                    }

                    DataGridViewRow rowTotal = dgvProductoEntrada.Rows[dgvProductoEntrada.Rows.Count - 1];
                    rowTotal.Cells["TOTALP"].Value = totalColumna;
                    DataGridViewRow rowSub = dgvProductoEntrada.Rows[dgvProductoEntrada.Rows.Count - 1];
                    rowSub.Cells["STOTAL"].Value = subtotal;

                    txtTotalPedido.Text = totalColumna.ToString();
                    txtsubtotal.Text = subtotal.ToString();
                    txtPza.Text = totalpieza.ToString();
                    txtIva.Text = totaliva.ToString();
                }  
            }

            else if (rbtPManual.Checked == true)
            {
                if (dgvProductoEntrada.Columns[e.ColumnIndex].Name == "PZAPEDIR" || dgvProductoEntrada.Columns[e.ColumnIndex].Name == "IVA" || dgvProductoEntrada.Columns[e.ColumnIndex].Name == "PRECIO")
                {
                    decimal totalColumna = 0;
                    decimal subtotal = 0;
                    int totalpieza = 0;
                    decimal totaliva = 0;
                    foreach (DataGridViewRow row in dgvProductoEntrada.Rows)
                    {
                        totalpieza += Convert.ToInt32(row.Cells["PZAPEDIR"].Value);
                        decimal sub = Convert.ToDecimal(row.Cells["PRECIO"].Value) * Convert.ToDecimal(row.Cells["PZAPEDIR"].Value);
                        decimal iva = (((Convert.ToDecimal(row.Cells["PRECIO"].Value) * Convert.ToDecimal(row.Cells["IVA"].Value)) / 100) + Convert.ToDecimal(row.Cells["PRECIO"].Value));
                        decimal ivaprod = (((Convert.ToDecimal(row.Cells["PRECIO"].Value) * Convert.ToDecimal(row.Cells["IVA"].Value)) / 100) * Convert.ToDecimal(row.Cells["PZAPEDIR"].Value));
                        decimal totalFila = Convert.ToDecimal(row.Cells["PZAPEDIR"].Value) * iva;
                        row.Cells["TOTALP"].Value = totalFila;
                        row.Cells["STOTAL"].Value = sub;
                        subtotal += sub;
                        totalColumna += totalFila;
                        totaliva += ivaprod;
                    }

                    DataGridViewRow rowTotal = dgvProductoEntrada.Rows[dgvProductoEntrada.Rows.Count - 1];
                    rowTotal.Cells["TOTALP"].Value = totalColumna;
                    DataGridViewRow rowSub = dgvProductoEntrada.Rows[dgvProductoEntrada.Rows.Count - 1];
                    rowSub.Cells["STOTAL"].Value = subtotal;

                    txtTotalPedido.Text = totalColumna.ToString();
                    txtsubtotal.Text = subtotal.ToString();
                    txtPza.Text = totalpieza.ToString();
                    txtIva.Text = totaliva.ToString();
                } 
            }
            
        }
        public void pedidotro(string pza,string sub, string total)
        {           
            DataSet DS = new DataSet();
            DataTable tbl = new DataTable();

            tbl.Columns.Add("col1");
            tbl.Columns.Add("col2");
            tbl.Columns.Add("col3");
            tbl.Columns.Add("col4");
            tbl.Columns.Add("col5");
            tbl.Columns.Add("col6");
            tbl.Columns.Add("col7");
            tbl.Columns.Add("col8");

            string[] lines = System.IO.File.ReadAllLines(otro);

            foreach (string s in lines)
            {
                string[] columns = s.Split('|');
                var dataRow = tbl.NewRow();

                dataRow["col1"] = columns[0];
                dataRow["col2"] = columns[1];
                dataRow["col3"] = columns[2];
                dataRow["col4"] = columns[3];
                dataRow["col5"] = columns[4];
                dataRow["col6"] = columns[5];
                dataRow["col7"] = columns[6];
                dataRow["col8"] = columns[7];
                tbl.Rows.Add(dataRow);

            }
            DS.Tables.Add(tbl);

            Excel.Application Mi_Excel = default(Excel.Application);
            Excel.Workbook LibroExcel = default(Excel.Workbook);
            Excel.Worksheet HojaExcel = default(Excel.Worksheet);

            Mi_Excel = new Excel.Application();
            Mi_Excel.Visible = true;

            LibroExcel = Mi_Excel.Workbooks.Add();
            HojaExcel = LibroExcel.Worksheets[1];
            HojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible;

            HojaExcel.Activate();

            HojaExcel.Range["A2:H2"].Merge();
            HojaExcel.Range["A2:H2"].Value = "PEDIDO A OTRO PROVEEDORES ";
            HojaExcel.Range["A2:H2"].Font.Italic = true;
            HojaExcel.Range["A2:H2"].Font.Size = 13;

            Excel.Range objCelda = HojaExcel.Range["A3", Type.Missing];
            objCelda.Value = "CODIGO";

            objCelda = HojaExcel.Range["B3", Type.Missing];
            objCelda.Value = "DESCRIPCION";

            objCelda = HojaExcel.Range["C3", Type.Missing];
            objCelda.Value = "PROVEEDOR";

            objCelda = HojaExcel.Range["D3", Type.Missing];
            objCelda.Value = "PZAS.POR PEDIR";

            objCelda = HojaExcel.Range["E3", Type.Missing];
            objCelda.Value = "PRECIO";

            objCelda = HojaExcel.Range["F3", Type.Missing];
            objCelda.Value = "IVA";

            objCelda = HojaExcel.Range["G3", Type.Missing];
            objCelda.Value = "SUB.TOTAL";

            objCelda = HojaExcel.Range["H3", Type.Missing];
            objCelda.Value = "TOTAL";

            objCelda = HojaExcel.Range["J3", Type.Missing];
            objCelda.Value = "PZA. TOTAL";

            objCelda = HojaExcel.Range["J4", Type.Missing];
            objCelda.Value = "SUBTOTAL PEDIDO";

            objCelda = HojaExcel.Range["J5", Type.Missing];
            objCelda.Value = "TOTAL PEDIDO";

            HojaExcel.Cells[3, "K"] = pza;          
            HojaExcel.Cells[4, "K"] = sub;
            HojaExcel.Cells[5, "K"] = total;
     
            HojaExcel.Range["J5:K5"].Font.Size = 15;

            int i = 4;

            foreach (DataRow Row in DS.Tables[0].Rows)
            {
                HojaExcel.Cells[i, "A"] = Row.ItemArray[0];
                HojaExcel.Cells[i, "B"] = Row.ItemArray[1];
                HojaExcel.Cells[i, "C"] = Row.ItemArray[2];
                HojaExcel.Cells[i, "D"] = Row.ItemArray[3];
                HojaExcel.Cells[i, "E"] = Row.ItemArray[4];
                HojaExcel.Cells[i, "F"] = Row.ItemArray[5];
                HojaExcel.Cells[i, "G"] = Row.ItemArray[6];
                HojaExcel.Cells[i, "H"] = Row.ItemArray[7];
                i++;
             }
        }
        public void pedidolevic(string pza,string sub, string total)
        {            
            DataSet DS = new DataSet();
            DataTable tbl = new DataTable();

            tbl.Columns.Add("col1");
            tbl.Columns.Add("col2");
            tbl.Columns.Add("col3");
            tbl.Columns.Add("col4");
            tbl.Columns.Add("col5");
            tbl.Columns.Add("col6");
            tbl.Columns.Add("col7");
            tbl.Columns.Add("col8");

            string[] lines = System.IO.File.ReadAllLines(levic);

            foreach (string s in lines)
            {
                string[] columns = s.Split('|');
                var dataRow = tbl.NewRow();

                dataRow["col1"] = columns[0];
                dataRow["col2"] = columns[1];
                dataRow["col3"] = columns[2];
                dataRow["col4"] = columns[3];
                dataRow["col5"] = columns[4];
                dataRow["col6"] = columns[5];
                dataRow["col7"] = columns[6];
                dataRow["col8"] = columns[7];
                tbl.Rows.Add(dataRow);
            }

            DS.Tables.Add(tbl);

            Excel.Application Mi_Excel = default(Excel.Application);
            Excel.Workbook LibroExcel = default(Excel.Workbook);
            Excel.Worksheet HojaExcel = default(Excel.Worksheet);
            Mi_Excel = new Microsoft.Office.Interop.Excel.Application();

            LibroExcel = Mi_Excel.Workbooks.Add();

            Mi_Excel = new Excel.Application();

            LibroExcel = Mi_Excel.Workbooks.Add();
            HojaExcel = LibroExcel.Worksheets[1];
            HojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible;

            HojaExcel.Activate();

            HojaExcel.Range["A2:H2"].Merge();
            HojaExcel.Range["A2:H2"].Value = "PEDIDO GENERADO PARA LEVIC ";
            HojaExcel.Range["A2:H2"].Font.Italic = true;
            HojaExcel.Range["A2:H2"].Font.Size = 13;

            Excel.Range objCelda = HojaExcel.Range["A3", Type.Missing];
            objCelda.Value = "CODIGO";

            objCelda = HojaExcel.Range["B3", Type.Missing];
            objCelda.Value = "DESCRIPCION";

            objCelda = HojaExcel.Range["C3", Type.Missing];
            objCelda.Value = "PROVEEDOR";

            objCelda = HojaExcel.Range["D3", Type.Missing];
            objCelda.Value = "PZAS.POR PEDIR";            

            objCelda = HojaExcel.Range["E3", Type.Missing];
            objCelda.Value = "PRECIO";

            objCelda = HojaExcel.Range["F3", Type.Missing];
            objCelda.Value = "IVA";

            objCelda = HojaExcel.Range["G3", Type.Missing];
            objCelda.Value = "SUB.TOTAL";

            objCelda = HojaExcel.Range["H3", Type.Missing];
            objCelda.Value = "TOTAL";            

            objCelda = HojaExcel.Range["J3", Type.Missing];
            objCelda.Value = "PZA. TOTAL";

            objCelda = HojaExcel.Range["J4", Type.Missing];
            objCelda.Value = "SUBTOTAL PEDIDO";

            objCelda = HojaExcel.Range["J5", Type.Missing];
            objCelda.Value = "TOTAL PEDIDO";

            HojaExcel.Cells[3, "K"] = pza;
            HojaExcel.Cells[4, "K"] = sub;
            HojaExcel.Cells[5, "K"] = total;
            HojaExcel.Range["J5:K5"].Font.Size = 15;

            int i = 4;

            foreach (DataRow Row in DS.Tables[0].Rows)
            {
                HojaExcel.Cells[i, "A"] = Row.ItemArray[0];
                HojaExcel.Cells[i, "B"] = Row.ItemArray[1];
                HojaExcel.Cells[i, "C"] = Row.ItemArray[2];
                HojaExcel.Cells[i, "D"] = Row.ItemArray[3];
                HojaExcel.Cells[i, "E"] = Row.ItemArray[4];
                HojaExcel.Cells[i, "F"] = Row.ItemArray[5];
                HojaExcel.Cells[i, "G"] = Row.ItemArray[6];
                HojaExcel.Cells[i, "H"] = Row.ItemArray[7];

                i++;
            }
            LibroExcel.SaveAs(levicpedido, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            LibroExcel.Close(true);
            Mi_Excel.Quit();
            MessageBox.Show("Segenero pedido para levic");
        }
        private void dgvProductoEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dgvProductoEntrada.Rows.Remove(dgvProductoEntrada.CurrentRow);
                total();                
            }
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmCatalogoProd prod = new frmCatalogoProd();
            prod.Show(this);
        }
        private void rbtPManual_MouseClick(object sender, MouseEventArgs e)
        {
            dgvProductoEntrada.DataSource = null;
            btnProductos.Visible = true;
           // LimpiaDataGrid();
        
            this.dgvProductoEntrada.Columns[11].Visible = true;
            this.dgvProductoEntrada.Columns[7].Visible = false;
            this.dgvProductoEntrada.Columns[8].Visible = false;
        }
        private void rbtPSugerido_MouseClick(object sender, MouseEventArgs e)
        {
            c.cargaPedido(dgvProductoEntrada);
            dgvProductoEntrada.AllowUserToAddRows = true;
            this.dgvProductoEntrada.Columns[0].Visible = true;
            this.dgvProductoEntrada.Columns[11].Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPedido buscapedido = new frmBusquedaPedido();
            buscapedido.Show();
        }
    }
}
