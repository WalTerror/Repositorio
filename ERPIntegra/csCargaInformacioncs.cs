using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ERPIntegra
{
    class csCargaInformacion
    {
        OleDbConnection conexc;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;

        public void importarExcel(DataGridView dgv, String nombreHoja)
        {
            String ruta = "";
            try
            {
                OpenFileDialog abrirarchivo = new OpenFileDialog();
                abrirarchivo.InitialDirectory = @"C:\Carga Integra";
                abrirarchivo.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm;";
                abrirarchivo.Title = "Seleccione el archivo de Excel";
                if (abrirarchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (abrirarchivo.FileName.Equals("") == false)
                    {
                        ruta = abrirarchivo.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar archivo para carga de información");

                }

                conexc = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conexc);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {

            }
        }

        

    }
}
