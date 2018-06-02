namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIERRE_CONTRATO
    {
        [Key]
        public int IDDETALLE { get; set; }

        public int IDCIERRE { get; set; }

        public int? IDCONTRATO { get; set; }

        [StringLength(200)]
        public string IDCONTRATOCOMPRA { get; set; }

        public int? IDLOCAL { get; set; }

        [StringLength(200)]
        public string LOCAL { get; set; }

        public int? IDTIPOPRECIO { get; set; }

        [StringLength(200)]
        public string TIPO_CONTRATO { get; set; }

        [StringLength(200)]
        public string TIPOCOMPRA { get; set; }

        public int? COSECHA { get; set; }

        [StringLength(200)]
        public string FECHACONTRATO { get; set; }

        [StringLength(200)]
        public string TIPOCAFE { get; set; }

        public decimal? KGCONTRATO { get; set; }

        public int? SACOCONTRATO { get; set; }

        public int? IDCLIENTE { get; set; }

        [StringLength(200)]
        public string CLIENTE { get; set; }

        [StringLength(200)]
        public string CALIDAD { get; set; }

        public int? IDRENDIMIENTO { get; set; }

        public int? IDDEFECTO { get; set; }

        public string OBSERVACIONES { get; set; }

        [StringLength(200)]
        public string CERTIFICACION { get; set; }

        [StringLength(200)]
        public string ESTADO { get; set; }

        [StringLength(200)]
        public string USUARIO { get; set; }

        public DateTime? FECHAREGISTRO { get; set; }

        public decimal? KGBASE { get; set; }

        public decimal? PRECIO { get; set; }

        public decimal? FIJACION { get; set; }

        [StringLength(200)]
        public string MES_FIJACION { get; set; }

        [StringLength(200)]
        public string DIFERENCIAL { get; set; }

        public decimal? KGLIQUIDADO { get; set; }

        public virtual CIERRE_ANUAL CIERRE_ANUAL { get; set; }
    }
}
