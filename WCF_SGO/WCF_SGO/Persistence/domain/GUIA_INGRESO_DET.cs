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
    
    public partial class GUIA_INGRESO_DET
    {
        public int IdGuiaIngresoDetalle { get; set; }
        public int IdGuia { get; set; }
        public Nullable<int> IdTicketPesada { get; set; }
        public Nullable<int> IdOrdenServicio { get; set; }
        public Nullable<int> IdResultado { get; set; }
        public int NroSaco { get; set; }
        public decimal KgBruto { get; set; }
        public decimal Tara { get; set; }
        public decimal KgNeto { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<int> IdSSAsignado { get; set; }
    }
}
