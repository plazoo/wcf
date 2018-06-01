namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPROBANTE_VENTA_CAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPROBANTE_VENTA_CAB()
        {
            COMPROBANTEVENTA_FILE = new HashSet<COMPROBANTEVENTA_FILE>();
            COMPROBANTE_VENTA_DET = new HashSet<COMPROBANTE_VENTA_DET>();
            COMPROBANTEVENTA_PROCESO = new HashSet<COMPROBANTEVENTA_PROCESO>();
        }

        [Key]
        public int IdComprobante { get; set; }

        [StringLength(15)]
        public string Correlativo { get; set; }

        [Required]
        [StringLength(2)]
        public string IdLocal { get; set; }

        [StringLength(2)]
        public string IdTipoComprobante { get; set; }

        [StringLength(4)]
        public string IdSerieComprobante { get; set; }

        public int? IdCliente { get; set; }

        [StringLength(100)]
        public string NombreCliente { get; set; }

        [StringLength(200)]
        public string RazonSocial { get; set; }

        [StringLength(300)]
        public string DireccionCliente { get; set; }

        public int? IdTipoDocumentoCliente { get; set; }

        [StringLength(15)]
        public string NroDocumentoCliente { get; set; }

        [StringLength(100)]
        public string Correo { get; set; }

        [StringLength(800)]
        public string ContratoReferencia { get; set; }

        [StringLength(8000)]
        public string Observaciones { get; set; }

        [StringLength(4)]
        public string TipoMoneda { get; set; }

        public decimal? TipoCambio { get; set; }

        public decimal? ImporteSubtotal { get; set; }

        public decimal? Impuesto { get; set; }

        public decimal? ImporteTotal { get; set; }

        [StringLength(30)]
        public string CodigoHash { get; set; }

        [StringLength(1)]
        public string EstadoEnvioCorreo { get; set; }

        public int? IdComprobanteRef { get; set; }

        [StringLength(2)]
        public string IdMotivo { get; set; }

        [StringLength(30)]
        public string MotivoDescripcion { get; set; }

        [StringLength(50)]
        public string PuertoEmbarque { get; set; }

        [StringLength(50)]
        public string PuertoDestino { get; set; }

        [StringLength(2)]
        public string IdTipoOperacion { get; set; }

        [StringLength(50)]
        public string ExpVapor { get; set; }

        [StringLength(30)]
        public string ExpFormaPago { get; set; }

        [StringLength(30)]
        public string ExpFlete { get; set; }

        [StringLength(30)]
        public string ExpSeguro { get; set; }

        [StringLength(100)]
        public string ExpNotificar { get; set; }

        [StringLength(20)]
        public string ExpPaisOrigen { get; set; }

        [StringLength(100)]
        public string ExpOtrosConceptos { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? UsuarioActualiza { get; set; }

        public int? IdEstado { get; set; }

        public int? IdEstadoProceso { get; set; }

        public int? IdComprobanteInterno { get; set; }

        public int? IdCatalogoCuentaContable { get; set; }

        [StringLength(2)]
        public string IdTipoComprobanteRef { get; set; }

        [StringLength(15)]
        public string CorrelativoRef { get; set; }

        public DateTime? FechaDocumentoRef { get; set; }

        [StringLength(50)]
        public string TipoOperacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPROBANTEVENTA_FILE> COMPROBANTEVENTA_FILE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPROBANTE_VENTA_DET> COMPROBANTE_VENTA_DET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPROBANTEVENTA_PROCESO> COMPROBANTEVENTA_PROCESO { get; set; }
    }
}
