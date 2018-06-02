namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_ESTADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_ESTADO()
        {
            ESTADOes = new HashSet<ESTADO>();
        }

        [Key]
        public int IdTipo { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTADO> ESTADOes { get; set; }
    }
}
