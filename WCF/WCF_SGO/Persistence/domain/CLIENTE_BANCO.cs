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
    
    public partial class CLIENTE_BANCO
    {
        public int IdClienteBanco { get; set; }
        public int IdCliente { get; set; }
        public int IdBanco { get; set; }
        public int IdMoneda { get; set; }
        public string NroCuenta { get; set; }
        public string NroCuentaInterbancario { get; set; }
        public string CodigoSwift { get; set; }
        public string Detraccion { get; set; }
        public int IdEstado { get; set; }
        public string UsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    }
}
