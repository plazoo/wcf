namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LIQUIDACION_COMPRA_DET
    {
        [Key]
        public int IdLiquidacionDetalle { get; set; }

        public int IdLiquidacion { get; set; }

        public int IdDocumento { get; set; }

        [Required]
        [StringLength(2)]
        public string TipoDocumento { get; set; }

        public int IdEstado { get; set; }

        public virtual LIQUIDACION_COMPRA_CAB LIQUIDACION_COMPRA_CAB { get; set; }
    }
}
