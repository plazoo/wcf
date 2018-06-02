namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_VISITA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_VISITA()
        {
            SOLICITUD_VISITA = new HashSet<SOLICITUD_VISITA>();
        }

        [Key]
        public int IdTipoVisita { get; set; }

        [StringLength(200)]
        public string Descripcion { get; set; }

        public int? Placa { get; set; }

        public int? IdEstado { get; set; }

        public virtual ESTADO ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD_VISITA> SOLICITUD_VISITA { get; set; }
    }
}
