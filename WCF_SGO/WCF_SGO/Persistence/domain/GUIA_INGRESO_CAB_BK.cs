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
    
    public partial class GUIA_INGRESO_CAB_BK
    {
        public int IdGuia { get; set; }
        public int IdGuiaIngreso { get; set; }
        public string IdLocal { get; set; }
        public int IdCliente { get; set; }
        public Nullable<int> IdContactoCliente { get; set; }
        public int IdTipoCafe { get; set; }
        public int Cosecha { get; set; }
        public string RumaDestino { get; set; }
        public Nullable<decimal> PromedioRendimiento { get; set; }
        public Nullable<decimal> PromedioHumedad { get; set; }
        public Nullable<decimal> PromedioTaza { get; set; }
        public int TotalSaco { get; set; }
        public decimal TotalKgBruto { get; set; }
        public decimal TotalTara { get; set; }
        public decimal TotalDsctoAgua { get; set; }
        public decimal TotalKgNeto { get; set; }
        public int IdEstado { get; set; }
        public string UsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public int Impresion { get; set; }
        public int ChkLiquidacion { get; set; }
        public Nullable<int> IdProceso { get; set; }
        public int IdTransito { get; set; }
        public string IdCertificadoVSP { get; set; }
        public string DescCertificacion { get; set; }
        public string ModalidadIngreso { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public Nullable<int> IdGuiaReferencia { get; set; }
        public Nullable<int> IdProductor { get; set; }
        public Nullable<int> IdIngresoPRP { get; set; }
        public Nullable<int> IdOficinaOrigen { get; set; }
        public Nullable<int> IdTraslado { get; set; }
        public string GuiaRemisionExterna { get; set; }
        public Nullable<int> IdClienteTrazabilidad { get; set; }
        public Nullable<int> IdTrasladoFila { get; set; }
    }
}