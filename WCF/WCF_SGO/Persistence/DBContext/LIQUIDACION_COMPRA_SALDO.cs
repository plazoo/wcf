namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LIQUIDACION_COMPRA_SALDO
    {
        [Key]
        public int IdGuiaIngresoSaldo { get; set; }

        public int IdLiquidacion { get; set; }

        public int IdGuia { get; set; }

        public int IdCliente { get; set; }

        public int Cosecha { get; set; }

        public int IdContrato { get; set; }

        public decimal KgNeto { get; set; }

        public decimal Operacion { get; set; }

        public decimal Saldo { get; set; }

        [StringLength(2)]
        public string Documento { get; set; }

        public int IdEstado { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
