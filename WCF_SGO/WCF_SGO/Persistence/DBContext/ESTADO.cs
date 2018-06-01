namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ESTADO")]
    public partial class ESTADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTADO()
        {
            SOLICITUD_VISITA = new HashSet<SOLICITUD_VISITA>();
            TIPO_VISITA = new HashSet<TIPO_VISITA>();
            MOTIVO_VISITA = new HashSet<MOTIVO_VISITA>();
        }

        [Key]
        public int IdEstado { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public int? IdTipo { get; set; }

        [Column("Estado")]
        public int? Estado1 { get; set; }

        public virtual TIPO_ESTADO TIPO_ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD_VISITA> SOLICITUD_VISITA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIPO_VISITA> TIPO_VISITA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOTIVO_VISITA> MOTIVO_VISITA { get; set; }
    }
}
