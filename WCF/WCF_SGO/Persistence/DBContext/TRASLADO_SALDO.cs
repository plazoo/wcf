namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRASLADO_SALDO
    {
        [Key]
        public int IdTrasladoSaldo { get; set; }

        public int IdTraslado { get; set; }

        public int? IdGuia { get; set; }

        public int Cosecha { get; set; }

        public decimal KgNeto { get; set; }

        public decimal Operacion { get; set; }

        public decimal Saldo { get; set; }

        public int IdEstado { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int? IdResultado { get; set; }

        public int? IdMerma { get; set; }

        public int? IdTipoMerma { get; set; }

        public int? IdTrasladoDetalle { get; set; }
    }
}
