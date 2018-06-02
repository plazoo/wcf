namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTRATO_COMPRA_ZONA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTRATO_COMPRA_ZONA()
        {
            CONTRATO_ZONA_OUT = new HashSet<CONTRATO_ZONA_OUT>();
            CONTRATO_ZONA_SWITCH = new HashSet<CONTRATO_ZONA_SWITCH>();
            CONTRATO_ZONA_UNFIXED = new HashSet<CONTRATO_ZONA_UNFIXED>();
        }

        [Key]
        public int IdContrato { get; set; }

        [Required]
        [StringLength(15)]
        public string IdContratoCompra { get; set; }

        public int IdLocal { get; set; }

        public int IdTipoPrecio { get; set; }

        public decimal? TC { get; set; }

        public int IdTipoCompra { get; set; }

        public int Cosecha { get; set; }

        public DateTime FechaContrato { get; set; }

        public int IdTipoCafe { get; set; }

        public decimal KgContrato { get; set; }

        public int SacoContrato { get; set; }

        public int IdCliente { get; set; }

        public int IdCalidad { get; set; }

        public int? IdRendimiento { get; set; }

        public int? IdDefecto { get; set; }

        [Column(TypeName = "text")]
        public string Observaciones { get; set; }

        public DateTime? FechaEntregaI { get; set; }

        public DateTime? FechaEntregaF { get; set; }

        public int IdOficinaEntrega { get; set; }

        [StringLength(200)]
        public string IdCertificacion { get; set; }

        [StringLength(250)]
        public string Certificacion { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(6)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        public decimal? KgBaseOut { get; set; }

        public int? IdMonedaOut { get; set; }

        public decimal? PrecioOut { get; set; }

        public decimal? KgBaseNuevoOut { get; set; }

        public int? IdMonedaNuevoOut { get; set; }

        public decimal? PrecioNuevoOut { get; set; }

        public int? IdTraderOut { get; set; }

        public int? IdAprobacionOut { get; set; }

        public decimal? KgBaseUnfix { get; set; }

        public int? IdMonedaUnfix { get; set; }

        public decimal? PrecioVigenteUnfix { get; set; }

        public decimal? KgFijadosVigenteUnfix { get; set; }

        public int? IdMesFijacionUnfix { get; set; }

        public decimal? DiferencialUnfix { get; set; }

        public int? IdTipoDiferencialUnfix { get; set; }

        public int? IdUnidadPrecio { get; set; }

        public decimal? KgPorSaco { get; set; }

        public int? NumSaco { get; set; }

        public int? IdContratoReferencia { get; set; }

        public decimal? PrecioOutOtorgado { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual TIPO_DIFERENCIAL TIPO_DIFERENCIAL { get; set; }

        public virtual TIPO_CAFE TIPO_CAFE { get; set; }

        public virtual TIPO_COMPRA TIPO_COMPRA { get; set; }

        public virtual TIPO_PRECIO TIPO_PRECIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_ZONA_OUT> CONTRATO_ZONA_OUT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_ZONA_SWITCH> CONTRATO_ZONA_SWITCH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_ZONA_UNFIXED> CONTRATO_ZONA_UNFIXED { get; set; }
    }
}
