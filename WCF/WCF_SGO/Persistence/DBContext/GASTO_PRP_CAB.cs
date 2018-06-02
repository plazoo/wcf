namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GASTO_PRP_CAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GASTO_PRP_CAB()
        {
            CAJACHICA_SALDO = new HashSet<CAJACHICA_SALDO>();
            GASTO_APROBACION = new HashSet<GASTO_APROBACION>();
            GASTO_PRP_DET = new HashSet<GASTO_PRP_DET>();
        }

        [Key]
        public int IdGasto_PRP { get; set; }

        public int? IdGastoInterno_PRP { get; set; }

        [StringLength(2)]
        public string IdLocal { get; set; }

        public int? IdTipoGasto { get; set; }

        public int IdTrabajador { get; set; }

        public int? IdJefatura { get; set; }

        [StringLength(3)]
        public string IdMoneda { get; set; }

        public decimal? Monto { get; set; }

        public decimal? PendienteRendir { get; set; }

        [StringLength(350)]
        public string Motivo { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? UsuarioActualiza { get; set; }

        public int? IdEstado { get; set; }

        public decimal? Vuelto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAJACHICA_SALDO> CAJACHICA_SALDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GASTO_APROBACION> GASTO_APROBACION { get; set; }

        public virtual TRABAJADOR_PRP TRABAJADOR_PRP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GASTO_PRP_DET> GASTO_PRP_DET { get; set; }
    }
}
