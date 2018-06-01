namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIERRE_KARDEX
    {
        [Key]
        public int IDDETALLE { get; set; }

        public int IDCIERRE { get; set; }

        public int? IDCONTRATO { get; set; }

        public string OPERACION { get; set; }

        public string LOCAL { get; set; }

        public string IDCONTRATOCOMPRA { get; set; }

        public string CLIENTE { get; set; }

        public string FECHACONTRATO { get; set; }

        public string TIPOCAFE { get; set; }

        public string MOTIVO { get; set; }

        public string BANCO { get; set; }

        public decimal? KGCONTRATO { get; set; }

        public int? SACOCONTRATO { get; set; }

        public string TIPOCOMPRA { get; set; }

        public string CALIDAD { get; set; }

        public decimal? PRECIO { get; set; }

        public decimal? SALDO { get; set; }

        public string IDLIQUIDACION { get; set; }

        public decimal? KGLIQUIDADO { get; set; }

        public decimal? PRECIO_SOLES { get; set; }

        public decimal? PRECIO_DOLARES { get; set; }

        public decimal? DIFERENCIAL { get; set; }

        public virtual CIERRE_ANUAL CIERRE_ANUAL { get; set; }
    }
}
