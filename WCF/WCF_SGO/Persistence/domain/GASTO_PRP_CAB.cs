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
    
    public partial class GASTO_PRP_CAB
    {
        public int IdGasto_PRP { get; set; }
        public Nullable<int> IdGastoInterno_PRP { get; set; }
        public string IdLocal { get; set; }
        public Nullable<int> IdTipoGasto { get; set; }
        public int IdTrabajador { get; set; }
        public Nullable<int> IdJefatura { get; set; }
        public string IdMoneda { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<decimal> PendienteRendir { get; set; }
        public string Motivo { get; set; }
        public Nullable<System.DateTime> FechaRegistra { get; set; }
        public Nullable<int> UsuarioRegistra { get; set; }
        public Nullable<System.DateTime> FechaActualiza { get; set; }
        public Nullable<int> UsuarioActualiza { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<decimal> Vuelto { get; set; }
    }
}