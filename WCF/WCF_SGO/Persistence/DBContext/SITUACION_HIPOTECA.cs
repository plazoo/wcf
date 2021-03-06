namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SITUACION_HIPOTECA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SITUACION_HIPOTECA()
        {
            CLIENTE_GARANTIA = new HashSet<CLIENTE_GARANTIA>();
        }

        [Key]
        public int IdSituacionHipoteca { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_GARANTIA> CLIENTE_GARANTIA { get; set; }
    }
}
