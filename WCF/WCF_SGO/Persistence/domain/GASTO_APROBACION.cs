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
    
    public partial class GASTO_APROBACION
    {
        public int IdGastoAprobacion { get; set; }
        public Nullable<int> IdGasto_PRP { get; set; }
        public Nullable<int> IdGastoMovilidad { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaRegistra { get; set; }
        public Nullable<int> UsuarioRegistra { get; set; }
        public Nullable<int> IdEstadoAprobacion { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<int> TipoTransaccion { get; set; }
        public string NroChequeCuentaBanco { get; set; }
    }
}