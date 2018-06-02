namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_MONEDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_MONEDA()
        {
            CLIENTE_BANCO = new HashSet<CLIENTE_BANCO>();
            CLIENTE_GARANTIA = new HashSet<CLIENTE_GARANTIA>();
            CLIENTE_GARANTIA1 = new HashSet<CLIENTE_GARANTIA>();
            TIPO_DIFERENCIAL = new HashSet<TIPO_DIFERENCIAL>();
        }

        [Key]
        public int IdMoneda { get; set; }

        [StringLength(100)]
        public string DescripcionLarga { get; set; }

        [StringLength(30)]
        public string DescripcionCorta { get; set; }

        [StringLength(5)]
        public string Simbolo { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_BANCO> CLIENTE_BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_GARANTIA> CLIENTE_GARANTIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_GARANTIA> CLIENTE_GARANTIA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIPO_DIFERENCIAL> TIPO_DIFERENCIAL { get; set; }
    }
}
