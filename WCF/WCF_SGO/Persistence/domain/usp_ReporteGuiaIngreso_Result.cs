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
    
    public partial class usp_ReporteGuiaIngreso_Result
    {
        public int IDGUIA { get; set; }
        public string IDGUIAINGRESO { get; set; }
        public string FECHA_DOCUMENTO { get; set; }
        public string IDLOCAL { get; set; }
        public string LOCAL { get; set; }
        public string LOCAL_DIRECCION { get; set; }
        public Nullable<int> IDCLIENTE { get; set; }
        public string CLIENTE { get; set; }
        public string DIRECCIONFACTURA { get; set; }
        public string RUMADESTINO { get; set; }
        public string CERTIFICADO { get; set; }
        public string MODALIDADINGRESO { get; set; }
        public int TOTALSACO { get; set; }
        public Nullable<decimal> TOTALKGBRUTO { get; set; }
        public Nullable<decimal> TOTALTARA { get; set; }
        public Nullable<decimal> TOTALKGNETO { get; set; }
        public Nullable<int> IDGUIAINGRESODETALLE { get; set; }
        public string REFERENCIA { get; set; }
        public Nullable<int> IDTICKETPESADA { get; set; }
        public Nullable<int> IDORDENSERVICIO { get; set; }
        public Nullable<int> IDRESULTADO { get; set; }
        public Nullable<int> NROSACO { get; set; }
        public Nullable<decimal> KGBRUTO { get; set; }
        public Nullable<decimal> TARA { get; set; }
        public Nullable<decimal> KGNETO { get; set; }
        public string ESTADO { get; set; }
        public string DESCUSUARIOREGISTRO { get; set; }
        public string FECHAREGISTRO { get; set; }
        public Nullable<int> IDTIPOCAFE { get; set; }
        public string TIPO_CAFE { get; set; }
        public decimal TOTALDSCTOAGUA { get; set; }
        public Nullable<int> IDINGRESOPRP { get; set; }
        public string ORIGEN { get; set; }
        public string TRASLADO { get; set; }
        public string GUIAREMISIONEXTERNA { get; set; }
        public string OBSERVACIONES { get; set; }
        public string CALIDAD { get; set; }
    }
}
