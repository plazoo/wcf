namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTRATO_COMPRA_HISTORICO
    {
        [Key]
        public int IdHistorico { get; set; }

        public int IdContrato { get; set; }

        public decimal KgActual { get; set; }

        public decimal KgEditado { get; set; }

        public int IdEstado { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }
    }
}
