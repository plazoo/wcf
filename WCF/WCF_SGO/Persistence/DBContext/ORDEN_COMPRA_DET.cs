namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDEN_COMPRA_DET
    {
        [Key]
        public int IdDetalleOrden { get; set; }

        public int IdOrden { get; set; }

        public int inCantidad { get; set; }

        [StringLength(30)]
        public string vcUnidadMedida { get; set; }

        [Required]
        [StringLength(200)]
        public string vcDescripcion { get; set; }

        [Required]
        [StringLength(10)]
        public string TipoModena { get; set; }

        public decimal dcPrecioUnidad { get; set; }

        public decimal dcSubtotal { get; set; }

        public decimal dcTotalDesc { get; set; }

        public decimal dcTotal { get; set; }

        public int inEstado { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }
    }
}
