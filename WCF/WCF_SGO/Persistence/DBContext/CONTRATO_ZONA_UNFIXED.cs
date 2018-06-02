namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTRATO_ZONA_UNFIXED
    {
        [Key]
        public int IdDetalleSinFijar { get; set; }

        public int IdContrato { get; set; }

        public decimal KgBase { get; set; }

        public int IdMoneda { get; set; }

        public decimal Precio { get; set; }

        public decimal KgFijado { get; set; }

        public decimal Diferencial { get; set; }

        public int IdTipoDiferencial { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int? IdDetalleSwitch { get; set; }

        public int IdEstado { get; set; }

        public int? UsuarioAprueba { get; set; }

        public DateTime? FechaAprueba { get; set; }

        public int? IdAprobRecha { get; set; }

        public int? inVigente { get; set; }

        public virtual CONTRATO_COMPRA_ZONA CONTRATO_COMPRA_ZONA { get; set; }
    }
}
