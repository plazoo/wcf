namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRABAJADOR_PRP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRABAJADOR_PRP()
        {
            CBANCO_TRABAJADOR = new HashSet<CBANCO_TRABAJADOR>();
            GASTO_PRP_CAB = new HashSet<GASTO_PRP_CAB>();
        }

        [Key]
        public int IdTrabajador { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public int? IdEstado { get; set; }

        [StringLength(14)]
        public string DocumentoId { get; set; }

        [StringLength(2)]
        public string IdLocal { get; set; }

        public int? IdUsuarioSGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CBANCO_TRABAJADOR> CBANCO_TRABAJADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GASTO_PRP_CAB> GASTO_PRP_CAB { get; set; }
    }
}
