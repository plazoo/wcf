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
    
    public partial class usp_LisTickedPesadaEnProceso_Result
    {
        public string CodigoTicketPesadaZona { get; set; }
        public string IdTicketPesada { get; set; }
        public string FechaTicket { get; set; }
        public Nullable<int> IDCLIENTE { get; set; }
        public Nullable<int> IDCONTACTOCLIENTE { get; set; }
        public string Proveedor { get; set; }
        public string IdLaboratorio { get; set; }
        public string LaboratorioZona { get; set; }
        public string Analisis { get; set; }
        public int NroSaco { get; set; }
        public decimal PesoSaco { get; set; }
        public decimal Tara { get; set; }
        public decimal KgBruto { get; set; }
        public decimal KgNeto { get; set; }
        public string Observaciones { get; set; }
        public int IdTipoCafe { get; set; }
        public string TipoCafe { get; set; }
    }
}