namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAJACHICA")]
    public partial class CAJACHICA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAJACHICA()
        {
            CAJACHICA_SALDO = new HashSet<CAJACHICA_SALDO>();
        }

        [Key]
        public int IdCajaChica { get; set; }

        public int IdCajaChicaInterno { get; set; }

        public int IdLocal { get; set; }

        public int? IdCuentaBanco { get; set; }

        public int? IdCatalogoCuentaContable { get; set; }

        [StringLength(300)]
        public string Descripcion { get; set; }

        public decimal? MontoMinimo { get; set; }

        public decimal? Monto { get; set; }

        public decimal? MontoMaximo { get; set; }

        [StringLength(3)]
        public string IdMoneda { get; set; }

        public int? IdEstado { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? UsuarioActualiza { get; set; }

        public virtual CATALOGO_CUENTA_CONTABLE CATALOGO_CUENTA_CONTABLE { get; set; }

        public virtual CUENTA_BANCO CUENTA_BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAJACHICA_SALDO> CAJACHICA_SALDO { get; set; }
    }
}
