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
    
    public partial class TRASLADO_CHOFER
    {
        public int IdChofer { get; set; }
        public Nullable<int> IdEmpresaTransporte { get; set; }
        public string NombreChofer { get; set; }
        public string ApellidoChofer { get; set; }
        public string Vehiculo { get; set; }
        public string NroInscripcion { get; set; }
        public string Licencia { get; set; }
        public int IdEstado { get; set; }
        public Nullable<int> BlackList { get; set; }
        public string UsuarioBL { get; set; }
        public Nullable<System.DateTime> FechaBL { get; set; }
        public string DniChofer { get; set; }
        public string Comentario { get; set; }
    }
}
