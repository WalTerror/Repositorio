using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPIntegra
{
    public class lisLaboratorio
    {
        public int id { get; set; }
        public string desc { get; set; }
    }
    public class lisProveedor
    {
        public int idp { get; set; }
        public string prov { get; set; }
    }
    public class lisDepartamento
    {
        public int idd { get; set; }
        public string dpto { get; set; }
    }
    public class lisrack
    {
        public int idr { get; set; }
        public string rack { get; set; }
    }
    public class lisDenominaciones
    {
        public int denId { get; set; }
        public string denDescr { get; set; }
        public decimal denValor { get; set; }
        public string denTipo { get; set; }

    }

    public class lisEstado
    {
        public int edoId { get; set; }
        public string edoDescripcion { get; set; }
    }
    public class lisCFDI
    {
        public int ucfdiId { get; set; }
        public string ucfdiDescripcion { get; set; }
    }
    public class lisEstatus
    {
        public int idstatus { get; set; }
        public string estatus { get; set; }
    }
}
