namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIERRE_ANUAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIERRE_ANUAL()
        {
            CIERRE_CONTRATO = new HashSet<CIERRE_CONTRATO>();
            CIERRE_GUIAINGRESO = new HashSet<CIERRE_GUIAINGRESO>();
            CIERRE_KARDEX = new HashSet<CIERRE_KARDEX>();
            CIERRE_LIQUIDACION = new HashSet<CIERRE_LIQUIDACION>();
            CIERRE_OTORGADO = new HashSet<CIERRE_OTORGADO>();
            CIERRE_SERVICIO = new HashSet<CIERRE_SERVICIO>();
        }

        [Key]
        public int IDCIERRE { get; set; }

        public int? IDCLIENTE { get; set; }

        public int? COSECHA { get; set; }

        public int? IDESTADO { get; set; }

        public int? USUARIOREGISTRO { get; set; }

        public DateTime? FECHAREGISTRO { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIERRE_CONTRATO> CIERRE_CONTRATO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIERRE_GUIAINGRESO> CIERRE_GUIAINGRESO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIERRE_KARDEX> CIERRE_KARDEX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIERRE_LIQUIDACION> CIERRE_LIQUIDACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIERRE_OTORGADO> CIERRE_OTORGADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIERRE_SERVICIO> CIERRE_SERVICIO { get; set; }
    }
}
