namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPROBANTE_VENTA_DET
    {
        [Key]
        public int IdDetalleComprobante { get; set; }

        public int? IdComprobante { get; set; }

        [StringLength(4)]
        public string Unidad { get; set; }

        [StringLength(800)]
        public string GuiaRemisionRef { get; set; }

        [StringLength(8000)]
        public string DescripcionServicio { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? PrecioUnitario { get; set; }

        public decimal? Importe { get; set; }

        [StringLength(2)]
        public string IdTipoImpuesto { get; set; }

        [StringLength(2)]
        public string IdMotivoServicio { get; set; }

        public decimal? ExpCantidadComercial { get; set; }

        public decimal? ExpNetWeight { get; set; }

        public decimal? ExpTara { get; set; }

        public decimal? ExpGrossWeight { get; set; }

        [StringLength(30)]
        public string ExpMarks { get; set; }

        [StringLength(20)]
        public string ExpPartidaArancelaria { get; set; }

        public decimal? ExpPrecioFairTrade { get; set; }

        public decimal? ExpFairTrade { get; set; }

        public decimal? ExpPrecioUnitario { get; set; }

        public decimal? ExpImporte { get; set; }

        [StringLength(3)]
        public string ExpMedida { get; set; }

        public decimal? ExpMedidaCantidad { get; set; }

        public decimal? KgmSaco { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? IdEstado { get; set; }

        public virtual COMPROBANTE_VENTA_CAB COMPROBANTE_VENTA_CAB { get; set; }
    }
}
