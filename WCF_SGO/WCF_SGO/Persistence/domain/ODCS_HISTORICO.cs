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
    
    public partial class ODCS_HISTORICO
    {
        public int IdHistorico { get; set; }
        public int IdOrden { get; set; }
        public int IdEstadoProceso { get; set; }
        public int IdUsuario { get; set; }
        public System.DateTime dtFechaRegistro { get; set; }
    }
}