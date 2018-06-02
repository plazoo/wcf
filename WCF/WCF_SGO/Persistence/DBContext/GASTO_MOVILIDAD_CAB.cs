namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GASTO_MOVILIDAD_CAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GASTO_MOVILIDAD_CAB()
        {
            CAJACHICA_SALDO = new HashSet<CAJACHICA_SALDO>();
            GASTO_APROBACION = new HashSet<GASTO_APROBACION>();
            GASTO_MOVILIDAD_DET = new HashSet<GASTO_MOVILIDAD_DET>();
        }

        [Key]
        public int IdMovilidadCab { get; set; }

        public int? IdMovilidadInterno { get; set; }

        [StringLength(2)]
        public string IdLocal { get; set; }

        public int? IdTipoGasto { get; set; }

        public int? IdTrabajador { get; set; }

        public int? IdJefatura { get; set; }

        public int? IdEstado { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? UsuarioActualiza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAJACHICA_SALDO> CAJACHICA_SALDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GASTO_APROBACION> GASTO_APROBACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GASTO_MOVILIDAD_DET> GASTO_MOVILIDAD_DET { get; set; }
    }
}
