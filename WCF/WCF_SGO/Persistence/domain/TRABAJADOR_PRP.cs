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
    
    public partial class TRABAJADOR_PRP
    {
        public int IdTrabajador { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public string DocumentoId { get; set; }
        public string IdLocal { get; set; }
        public Nullable<int> IdUsuarioSGO { get; set; }
        public Nullable<System.DateTime> FechaRegistra { get; set; }
        public Nullable<int> UsuarioRegistra { get; set; }
        public Nullable<System.DateTime> FechaActualiza { get; set; }
        public Nullable<int> UsuarioActualiza { get; set; }
    }
}