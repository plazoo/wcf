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
    
    public partial class ComprobanteCliente
    {
        public string RAZONSOCIAL_PRODELSUR { get; set; }
        public string RUC_PRODELSUR { get; set; }
        public int IdComprobante { get; set; }
        public string Correlativo { get; set; }
        public string InvoiceState { get; set; }
        public Nullable<decimal> ImporteSubtotal { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> ImporteTotal { get; set; }
        public string FechaOperacion { get; set; }
        public string NombreArhivo { get; set; }
        public string TipoMoneda { get; set; }
        public string IdTipoComprobante { get; set; }
    }
}