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
    
    public partial class LIQUIDACION_COMPRA_SALDO
    {
        public int IdGuiaIngresoSaldo { get; set; }
        public int IdLiquidacion { get; set; }
        public int IdGuia { get; set; }
        public int IdCliente { get; set; }
        public int Cosecha { get; set; }
        public int IdContrato { get; set; }
        public decimal KgNeto { get; set; }
        public decimal Operacion { get; set; }
        public decimal Saldo { get; set; }
        public string Documento { get; set; }
        public int IdEstado { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    }
}
