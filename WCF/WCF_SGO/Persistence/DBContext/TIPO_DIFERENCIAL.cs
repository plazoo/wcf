namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_DIFERENCIAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_DIFERENCIAL()
        {
            CONTRATO_COMPRA = new HashSet<CONTRATO_COMPRA>();
            CONTRATO_COMPRA_ZONA = new HashSet<CONTRATO_COMPRA_ZONA>();
        }

        [Key]
        public int IdTipoDiferencial { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public decimal? KgBase { get; set; }

        public int? IdMoneda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_COMPRA> CONTRATO_COMPRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_COMPRA_ZONA> CONTRATO_COMPRA_ZONA { get; set; }

        public virtual TIPO_MONEDA TIPO_MONEDA { get; set; }
    }
}
