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
    
    public partial class usp_Mant_CLIENTE_COSECHA_Result
    {
        public int IdClienteCosecha { get; set; }
        public int IdCosecha { get; set; }
        public string DESCRIPCION { get; set; }
        public int IdCliente { get; set; }
        public Nullable<int> IdTipoCliente { get; set; }
        public string TIPO_CLIENTE { get; set; }
        public string DocIdentidad { get; set; }
        public string CLIENTE { get; set; }
        public int InEstado { get; set; }
        public int UsuarioRegistro { get; set; }
        public string VUSUARIO { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public int InVigente { get; set; }
    }
}
