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
    
    public partial class usp_LisSaldoCertificado_Result
    {
        public int IDCERTIFICADOVSP { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<int> COSECHA { get; set; }
        public decimal TOPE { get; set; }
        public int SOBREGIRO { get; set; }
        public Nullable<decimal> LIMITE { get; set; }
        public decimal OPERACION { get; set; }
        public decimal SALDO { get; set; }
        public Nullable<decimal> SALDO_CALCULADO { get; set; }
    }
}
