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
    
    public partial class CONTRATO_ZONA_OUT
    {
        public int IdDetalleFijado { get; set; }
        public int IdContrato { get; set; }
        public decimal KgBase { get; set; }
        public int IdMoneda { get; set; }
        public decimal Precio { get; set; }
        public int IdTrader { get; set; }
        public int IdAprobacion { get; set; }
        public Nullable<int> IdRendimiento { get; set; }
        public Nullable<int> IdDefecto { get; set; }
        public string UsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string UsuarioAprueba { get; set; }
        public Nullable<System.DateTime> FechaAprueba { get; set; }
        public Nullable<int> IdAprobRecha { get; set; }
        public Nullable<int> inVigente { get; set; }
    }
}
