namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CUENTA_BANCO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUENTA_BANCO()
        {
            CAJACHICAs = new HashSet<CAJACHICA>();
        }

        [Key]
        public int IdCuentaBanco { get; set; }

        [StringLength(30)]
        public string NroCuentaBanco { get; set; }

        [StringLength(30)]
        public string CodigoInterbancario { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [StringLength(30)]
        public string IdLocal { get; set; }

        public int? IdEstado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAJACHICA> CAJACHICAs { get; set; }
    }
}
