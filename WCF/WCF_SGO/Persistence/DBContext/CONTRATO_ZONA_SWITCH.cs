namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTRATO_ZONA_SWITCH
    {
        [Key]
        public int IdDetalleSwitch { get; set; }

        public int IdContrato { get; set; }

        public decimal Diferencial { get; set; }

        public int IdTipoDiferencial { get; set; }

        public int IdMesFijacion { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int IdEstado { get; set; }

        public decimal? CostoSwitch { get; set; }

        public virtual CONTRATO_COMPRA_ZONA CONTRATO_COMPRA_ZONA { get; set; }
    }
}
