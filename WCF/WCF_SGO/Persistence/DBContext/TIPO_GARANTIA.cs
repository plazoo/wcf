namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_GARANTIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_GARANTIA()
        {
            CLIENTE_GARANTIA = new HashSet<CLIENTE_GARANTIA>();
        }

        [Key]
        public int IdTipoGarantia { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int? IdEstado { get; set; }

        [StringLength(10)]
        public string UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE_GARANTIA> CLIENTE_GARANTIA { get; set; }
    }
}
