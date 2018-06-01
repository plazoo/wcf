namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CATALOGO_CUENTA_CONTABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATALOGO_CUENTA_CONTABLE()
        {
            CAJACHICAs = new HashSet<CAJACHICA>();
        }

        [Key]
        public int IdCatalogoCuentaContable { get; set; }

        [StringLength(12)]
        public string CuentaContable { get; set; }

        [StringLength(100)]
        public string CuentaContableDescripcion { get; set; }

        [StringLength(10)]
        public string CuentaHyperion { get; set; }

        [StringLength(100)]
        public string CuentaHyperionDescripcion { get; set; }

        public int? IdEstado { get; set; }

        public int? TipoOperacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAJACHICA> CAJACHICAs { get; set; }
    }
}
