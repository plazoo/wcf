namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANCO")]
    public partial class BANCO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANCO()
        {
            CLIENTE_BANCO = new HashSet<CLIENTE_BANCO>();
            CLIENTE_CONTACTO = new HashSet<CLIENTE_CONTACTO>();
        }

        [Key]
        public int IdBanco { get; set; }

        [Required]
        [StringLength(150)]
        public string RazonSocial { get; set; }

        [Required]
        [StringLength(150)]
        public string NombreComercial { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_BANCO> CLIENTE_BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_CONTACTO> CLIENTE_CONTACTO { get; set; }
    }
}
