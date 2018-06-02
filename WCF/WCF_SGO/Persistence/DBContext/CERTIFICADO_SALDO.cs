namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CERTIFICADO_SALDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CERTIFICADO_SALDO()
        {
            CERTIFICADO_SALDO_HISTORY = new HashSet<CERTIFICADO_SALDO_HISTORY>();
        }

        [Key]
        public int IdCertificadoSaldo { get; set; }

        public int IdGuia { get; set; }

        public int IdCertificado { get; set; }

        public int IdCliente { get; set; }

        public int Cosecha { get; set; }

        public decimal Tope { get; set; }

        public decimal Operacion { get; set; }

        public decimal Saldo { get; set; }

        public int? IdSello { get; set; }

        public int IdEstado { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(2)]
        public string IdTipoOperacion { get; set; }

        public int? idCargar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CERTIFICADO_SALDO_HISTORY> CERTIFICADO_SALDO_HISTORY { get; set; }
    }
}
