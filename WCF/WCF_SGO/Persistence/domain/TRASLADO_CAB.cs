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
    
    public partial class TRASLADO_CAB
    {
        public int IdTraslado { get; set; }
        public int IdTrasladoInterno { get; set; }
        public string IdLocal { get; set; }
        public string FechaTraslado { get; set; }
        public int IdOrigen { get; set; }
        public int IdDestino { get; set; }
        public int IdMotivo { get; set; }
        public int IdTipoCafe { get; set; }
        public int IdEmpresaTransporte { get; set; }
        public int IdChofer { get; set; }
        public decimal GiKgBruto { get; set; }
        public decimal GiTara { get; set; }
        public decimal GiKgNeto { get; set; }
        public int GiSaco { get; set; }
        public decimal GiRendimiento { get; set; }
        public decimal GiHumedad { get; set; }
        public decimal GrKgBruto { get; set; }
        public decimal GrTara { get; set; }
        public decimal GrKgNeto { get; set; }
        public int GrSaco { get; set; }
        public decimal GrRendimiento { get; set; }
        public decimal GrHumedad { get; set; }
        public string Certificado { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public string UsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string IdCertificado { get; set; }
        public string CostoMinimo { get; set; }
        public string TipoGuia { get; set; }
        public string Marcas { get; set; }
        public string Destino { get; set; }
        public string Contenedor { get; set; }
        public string Precinto { get; set; }
        public string NumContrato { get; set; }
        public string Vapor { get; set; }
        public Nullable<decimal> TCon { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
    }
}
