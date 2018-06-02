namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CERTIFICADO_SALDO_HISTORY
    {
        [Key]
        public int IdCertificadoSaldoHistory { get; set; }

        public int IdCertificadoSaldo { get; set; }

        public decimal Saldo { get; set; }

        public int IdEstado { get; set; }

        public DateTime FechaRegistroRef { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int? UsuarioRegistra { get; set; }

        public virtual CERTIFICADO_SALDO CERTIFICADO_SALDO { get; set; }
    }
}
