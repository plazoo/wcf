//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Persistence.domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class CIERRE_GUIAINGRESO
    {
        public int IDCIERREGI { get; set; }
        public int IDDETALLE { get; set; }
        public Nullable<int> IDGUIA { get; set; }
        public string GUIAINGRESO { get; set; }
        public Nullable<int> IDLOCAL { get; set; }
        public Nullable<int> IDCLIENTE { get; set; }
        public string CLIENTE { get; set; }
        public Nullable<int> IDCONTACTOCLIENTE { get; set; }
        public string CONTACTOCLIENTE { get; set; }
        public Nullable<int> RUMADESTINO { get; set; }
        public Nullable<decimal> PROMEDIORENDIMIENTO { get; set; }
        public Nullable<decimal> PROMEDIOHUMEDAD { get; set; }
        public Nullable<decimal> PROMEDIOTAZA { get; set; }
        public string DESCCERTIFICACION { get; set; }
        public string IdCertificadoVSP { get; set; }
        public Nullable<int> TOTALSACO { get; set; }
        public Nullable<decimal> TOTALKGBRUTO { get; set; }
        public Nullable<decimal> TOTALTARA { get; set; }
        public Nullable<decimal> TOTALKGNETO { get; set; }
        public Nullable<int> IDPROCESO { get; set; }
        public string ProcesoDescripcion { get; set; }
        public string ESTADO { get; set; }
        public string PROPIEDAD { get; set; }
        public string DESCUSUARIOREGISTRO { get; set; }
        public string FECHAREGISTRO { get; set; }
        public string DESCUSUARIOMODIFICA { get; set; }
        public string FECHAMODIFICA { get; set; }
        public Nullable<int> IMPRESION { get; set; }
        public string RUMA { get; set; }
        public string MODALIDADINGRESO { get; set; }
        public Nullable<decimal> TOTALDSCTOAGUA { get; set; }
        public Nullable<int> IdTipoCaFe { get; set; }
        public string TipoCafe { get; set; }
        public string ORIGEN { get; set; }
        public string TRASLADO { get; set; }
        public string GUIAREMISIONEXTERNA { get; set; }
        public string OBSERVACION { get; set; }
        public string CONTRATOCOMPRA { get; set; }
        public string LIQUIDACION { get; set; }
        public Nullable<int> IDCONTRATO { get; set; }
        public string SS { get; set; }
        public Nullable<decimal> DIF_NETOYAGUA { get; set; }
        public string CALIDAD { get; set; }
    }
}
