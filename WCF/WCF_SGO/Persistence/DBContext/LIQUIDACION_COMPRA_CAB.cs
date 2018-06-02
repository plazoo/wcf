namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LIQUIDACION_COMPRA_CAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIQUIDACION_COMPRA_CAB()
        {
            LIQUIDACION_COMPRA_DET = new HashSet<LIQUIDACION_COMPRA_DET>();
        }

        [Key]
        public int IdLiquidacion { get; set; }

        public int IdLocal { get; set; }

        [Required]
        [StringLength(2)]
        public string TipoLiquidacion { get; set; }

        public int CodigoLiquidacion { get; set; }

        public int IdCliente { get; set; }

        public int? IdContactoCliente { get; set; }

        public int IdTipoCafe { get; set; }

        public int Cosecha { get; set; }

        public DateTime FechaLiquidacion { get; set; }

        [StringLength(50)]
        public string IdGuiaIngreso { get; set; }

        [StringLength(200)]
        public string DescGuiaIngreso { get; set; }

        [StringLength(50)]
        public string IdContratoCompra { get; set; }

        [StringLength(200)]
        public string DescContratoCompra { get; set; }

        public decimal TotalSacoGi { get; set; }

        public decimal TotalKgNetoGi { get; set; }

        public decimal TotalSacoCc { get; set; }

        public decimal TotalKgNetoCc { get; set; }

        public decimal DiferenciaSaco { get; set; }

        public decimal DiferenciaKg { get; set; }

        public decimal Precio { get; set; }

        public decimal? KgBase { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistra { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(6)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        [StringLength(20)]
        public string FacturaSerie { get; set; }

        [StringLength(20)]
        public string FacturaNumero { get; set; }

        [StringLength(10)]
        public string FacturaFecha { get; set; }

        [StringLength(4)]
        public string SerieDocumento { get; set; }

        [StringLength(8)]
        public string NroDocumento { get; set; }

        public DateTime? FechaAsignacionPrecio { get; set; }

        [StringLength(100)]
        public string UsuarioAsignacionPrecio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIQUIDACION_COMPRA_DET> LIQUIDACION_COMPRA_DET { get; set; }
    }
}
