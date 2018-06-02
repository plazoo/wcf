namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPROBANTEVENTA_PROCESO
    {
        [Key]
        public int IdProcesoComprobante { get; set; }

        public int? IdComprobante { get; set; }

        public int? IdEstadoProceso { get; set; }

        [StringLength(8000)]
        public string Observaciones { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? UsuarioRegistro { get; set; }

        public int? IdEstado { get; set; }

        public virtual COMPROBANTE_VENTA_CAB COMPROBANTE_VENTA_CAB { get; set; }
    }
}
