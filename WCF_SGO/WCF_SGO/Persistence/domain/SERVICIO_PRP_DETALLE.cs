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
    
    public partial class SERVICIO_PRP_DETALLE
    {
        public int IdDetalle { get; set; }
        public int IdOrdenServicio { get; set; }
        public Nullable<int> IdTicketPesada { get; set; }
        public Nullable<int> IdServicio { get; set; }
        public Nullable<int> SacoInicial { get; set; }
        public Nullable<decimal> KgNetoInicial { get; set; }
        public Nullable<int> SacoUsado { get; set; }
        public Nullable<decimal> KgNetoUsado { get; set; }
        public Nullable<int> SacoSaldo { get; set; }
        public Nullable<decimal> KgNetoSaldo { get; set; }
        public int IdEstado { get; set; }
        public Nullable<int> IdAnulado { get; set; }
    }
}