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
    
    public partial class PRECIO_BOLSA
    {
        public int IdPrecioBolsa { get; set; }
        public System.DateTime FechaPrecio { get; set; }
        public Nullable<int> IdMesFijacion { get; set; }
        public Nullable<decimal> PrecioInicio { get; set; }
        public Nullable<decimal> PrecioBajo { get; set; }
        public Nullable<decimal> PrecioAlto { get; set; }
        public Nullable<decimal> PrecioCierre { get; set; }
        public int IdEstado { get; set; }
        public int UsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public decimal PrecioVolumen { get; set; }
        public Nullable<int> UsuarioElim { get; set; }
        public Nullable<System.DateTime> FechaElim { get; set; }
    }
}
