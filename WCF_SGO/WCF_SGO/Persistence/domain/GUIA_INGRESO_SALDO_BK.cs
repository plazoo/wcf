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
    
    public partial class GUIA_INGRESO_SALDO_BK
    {
        public int IdTicketPesadaSaldo { get; set; }
        public Nullable<int> IdGuia { get; set; }
        public Nullable<int> IdTicketPesada { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> Cosecha { get; set; }
        public Nullable<int> Saco { get; set; }
        public Nullable<decimal> KgBruto { get; set; }
        public Nullable<decimal> Tara { get; set; }
        public Nullable<decimal> KgNeto { get; set; }
        public Nullable<int> SacoOperacion { get; set; }
        public Nullable<decimal> KgBrutoOperacion { get; set; }
        public Nullable<decimal> TaraOperacion { get; set; }
        public Nullable<decimal> KgNetoOperacion { get; set; }
        public Nullable<int> SacoSaldo { get; set; }
        public Nullable<decimal> KgBrutoSaldo { get; set; }
        public Nullable<decimal> TaraSaldo { get; set; }
        public Nullable<decimal> KgNetoSaldo { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public string UsuarioRegistro { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    }
}
