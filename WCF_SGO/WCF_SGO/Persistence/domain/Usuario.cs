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
    
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string vCodTrabajador { get; set; }
        public string vNombre { get; set; }
        public string vApePat { get; set; }
        public string vCorreo { get; set; }
        public string vUsuario { get; set; }
        public string vPassword { get; set; }
        public int nEstado { get; set; }
        public string vApeMat { get; set; }
        public Nullable<bool> bCambioPassword { get; set; }
        public string vIdJefatura { get; set; }
        public Nullable<int> nIdUsuario_Mod { get; set; }
        public Nullable<System.DateTime> dFecha_Mod { get; set; }
    }
}
