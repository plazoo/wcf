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
    
    public partial class TICKET_PESADA
    {
        public int IdTicketPesada { get; set; }
        public int IdTicketPesadaZona { get; set; }
        public int IdCliente { get; set; }
        public Nullable<int> IdContactoCliente { get; set; }
        public string IdLocal { get; set; }
        public System.DateTime FechaTicket { get; set; }
        public int Cosecha { get; set; }
        public int IdLaboratorio { get; set; }
        public int IdTipoCafe { get; set; }
        public int NroSaco { get; set; }
        public int IdSaco { get; set; }
        public decimal PesoSaco { get; set; }
        public decimal Tara { get; set; }
        public decimal KgBruto { get; set; }
        public decimal KgNeto { get; set; }
        public decimal DsctoAgua { get; set; }
        public decimal KgSeco { get; set; }
        public int IdProceso { get; set; }
        public string Observaciones { get; set; }
        public int IdEstado { get; set; }
        public string UsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> IdGuiaIngreso { get; set; }
        public string IdExcel { get; set; }
        public string GiExcel { get; set; }
        public string IdGuiaRemision { get; set; }
        public string GuiaRemision { get; set; }
    }
}
