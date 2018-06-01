namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESUMEN_COMPRA_CLIENTE_DETALLE
    {
        public int ID { get; set; }

        public int? IDCONTRATO { get; set; }

        public int? IDLOCAL { get; set; }

        public int? COSECHA { get; set; }

        public int? IDCLIENTE { get; set; }

        [StringLength(2)]
        public string OPERACION { get; set; }

        [StringLength(50)]
        public string TIPOCAFE { get; set; }

        public decimal? KGCONTRATO { get; set; }

        public int? SACOCONTRATO { get; set; }

        public decimal? KGLIQUIDADO { get; set; }

        public decimal? PRECIO_SOLES { get; set; }

        public decimal? PRECIO_DOLARES { get; set; }
    }
}
