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
    
    public partial class CIERRE_KARDEX
    {
        public int IDDETALLE { get; set; }
        public int IDCIERRE { get; set; }
        public Nullable<int> IDCONTRATO { get; set; }
        public string OPERACION { get; set; }
        public string LOCAL { get; set; }
        public string IDCONTRATOCOMPRA { get; set; }
        public string CLIENTE { get; set; }
        public string FECHACONTRATO { get; set; }
        public string TIPOCAFE { get; set; }
        public string MOTIVO { get; set; }
        public string BANCO { get; set; }
        public Nullable<decimal> KGCONTRATO { get; set; }
        public Nullable<int> SACOCONTRATO { get; set; }
        public string TIPOCOMPRA { get; set; }
        public string CALIDAD { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public Nullable<decimal> SALDO { get; set; }
        public string IDLIQUIDACION { get; set; }
        public Nullable<decimal> KGLIQUIDADO { get; set; }
        public Nullable<decimal> PRECIO_SOLES { get; set; }
        public Nullable<decimal> PRECIO_DOLARES { get; set; }
        public Nullable<decimal> DIFERENCIAL { get; set; }
    }
}