namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTRATO_COMPRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTRATO_COMPRA()
        {
            CONTRATO_COMPRA_SWITCH = new HashSet<CONTRATO_COMPRA_SWITCH>();
            CONTRATO_COMPRA_UNFIXED = new HashSet<CONTRATO_COMPRA_UNFIXED>();
        }

        [Key]
        public int IdContrato { get; set; }

        public int IdLocal { get; set; }

        [Required]
        [StringLength(10)]
        public string SerieContrato { get; set; }

        [Required]
        [StringLength(10)]
        public string NumContrato { get; set; }

        public DateTime FechaContrato { get; set; }

        public int IdTipoCafe { get; set; }

        public int IdTipoCompra { get; set; }

        public int Cosecha { get; set; }

        public decimal Cantidad { get; set; }

        public int IdTipoUnidadMedida { get; set; }

        public decimal PesoxSacoRecibido { get; set; }

        public decimal PesoSaco { get; set; }

        public decimal TotalPesoSaco { get; set; }

        public int IdCliente { get; set; }

        public int IdCalidad { get; set; }

        public int IdTipoHumedad { get; set; }

        public int IdTipoRendimiento { get; set; }

        public decimal PrecioTabla { get; set; }

        public int? ChkPrecioNuevo { get; set; }

        public decimal? PrecioNuevo { get; set; }

        public int? IdTrader { get; set; }

        [StringLength(200)]
        public string IdCertificadoVSP { get; set; }

        [StringLength(250)]
        public string DescCertificacion { get; set; }

        public int? IdTipoPrecio { get; set; }

        public DateTime? FechaEntregaInicio { get; set; }

        public DateTime? FechaEntregaFin { get; set; }

        public int PorAutorizar { get; set; }

        public int? UsuarioRegistroGeneral { get; set; }

        public DateTime? FechaRegistroGeneral { get; set; }

        public int? UsuarioModificaGeneral { get; set; }

        public DateTime? FechaModificaGeneral { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        [Column(TypeName = "text")]
        public string ObservacionInterna { get; set; }

        public int? IdAgente { get; set; }

        [StringLength(50)]
        public string ReferenciaAgente { get; set; }

        public int? ImprimeReferencia { get; set; }

        public decimal? ComisionMonto { get; set; }

        public int? IdMoneda { get; set; }

        public int? ComisionCantidad { get; set; }

        public int? IdUnidadMedida { get; set; }

        public int? UsuarioRegistroComentario { get; set; }

        public DateTime? FechaRegistroComentario { get; set; }

        public int? UsuarioModificaComentario { get; set; }

        public DateTime? FechaModificaComentario { get; set; }

        [StringLength(200)]
        public string InstruccionMuestra { get; set; }

        public int? IdTipoDsa { get; set; }

        public int? IdTipoTerminoEntrega { get; set; }

        public int? IdTipoReglasPeso { get; set; }

        public int? IdTipoCondPago { get; set; }

        public int? IdTipoControlBase { get; set; }

        public int? IdTipoArbitraje { get; set; }

        public int? IdTipoDestino { get; set; }

        public int? IdSaco { get; set; }

        [StringLength(1)]
        public string IdTipoFijador { get; set; }

        public int? UsuarioRegistroTerminos { get; set; }

        public DateTime? FechaRegistroTerminos { get; set; }

        public int? UsuarioModificaTerminos { get; set; }

        public DateTime? FechaModificaTerminos { get; set; }

        public int? IdTipoCambioOperacion { get; set; }

        public decimal? PrecioOutFijado { get; set; }

        public int? IdOutTipoMoneda { get; set; }

        public decimal? PrecioOutCantidad { get; set; }

        public int? IdOutUnidadMedida { get; set; }

        public decimal? PrecioOutMercado { get; set; }

        public decimal? DiferencialBaseOut { get; set; }

        public decimal? PrecioFinalSoles { get; set; }

        public decimal? PrecioFinalDolares { get; set; }

        public int? UsuarioRegistroOut { get; set; }

        public DateTime? FechaRegistroOut { get; set; }

        public int? UsuarioModificaOut { get; set; }

        public DateTime? FechaModificaOut { get; set; }

        public int? UnfxPendienteFijar { get; set; }

        public int? UnfxMesFijacion { get; set; }

        public decimal? UnfxDiferencial { get; set; }

        public int? UnfxTipoDiferencial { get; set; }

        [StringLength(1)]
        public string UnfxTipoFijador { get; set; }

        public DateTime? UnfxFechaExpiraFijacion { get; set; }

        public decimal? UnfxPrecioFinalSoles { get; set; }

        public decimal? UnfxPrecioFinalDolares { get; set; }

        public int? UnfxUsuarioRegistro { get; set; }

        public DateTime? UnfxFechaRegistro { get; set; }

        public int? UnfxUsuarioModifica { get; set; }

        public DateTime? UnfxFechaModifica { get; set; }

        public decimal? OpenDiferencial { get; set; }

        public DateTime? OpenFechaDiferencial { get; set; }

        public int IdEstado { get; set; }

        public int ChkLiquidacion { get; set; }

        [StringLength(50)]
        public string GiExcel { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_COMPRA_SWITCH> CONTRATO_COMPRA_SWITCH { get; set; }

        public virtual TIPO_AGENTE TIPO_AGENTE { get; set; }

        public virtual TIPO_ARBITRAJE TIPO_ARBITRAJE { get; set; }

        public virtual TIPO_COMPRA TIPO_COMPRA { get; set; }

        public virtual TIPO_COND_PAGO TIPO_COND_PAGO { get; set; }

        public virtual TIPO_CONTROL_BASE TIPO_CONTROL_BASE { get; set; }

        public virtual TIPO_DESTINO TIPO_DESTINO { get; set; }

        public virtual TIPO_DIFERENCIAL TIPO_DIFERENCIAL { get; set; }

        public virtual TIPO_DSA TIPO_DSA { get; set; }

        public virtual TIPO_PRECIO TIPO_PRECIO { get; set; }

        public virtual TIPO_REGLAS_PESO TIPO_REGLAS_PESO { get; set; }

        public virtual TIPO_TERMINO_ENTREGA TIPO_TERMINO_ENTREGA { get; set; }

        public virtual TIPO_UNIDAD_MEDIDA TIPO_UNIDAD_MEDIDA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_COMPRA_UNFIXED> CONTRATO_COMPRA_UNFIXED { get; set; }
    }
}
