namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPROBANTEVENTA_FILE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPROBANTEVENTA_FILE()
        {
            COMPROBANTEVENTA_FILE_RESPONSE = new HashSet<COMPROBANTEVENTA_FILE_RESPONSE>();
        }

        [Key]
        public int IdComprobanteFile { get; set; }

        public int IdComprobante { get; set; }

        [Required]
        [StringLength(15)]
        public string Correlativo { get; set; }

        [Required]
        [StringLength(2)]
        public string TipoComprobante { get; set; }

        [StringLength(50)]
        public string NombreArhivo { get; set; }

        [StringLength(344)]
        public string SignatureValue { get; set; }

        [StringLength(30)]
        public string DigestValue { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        [StringLength(1)]
        public string StateInvoice { get; set; }

        [StringLength(8000)]
        public string Trama { get; set; }

        public virtual COMPROBANTE_VENTA_CAB COMPROBANTE_VENTA_CAB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPROBANTEVENTA_FILE_RESPONSE> COMPROBANTEVENTA_FILE_RESPONSE { get; set; }
    }
}
