namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_CAMBIO_OPERACION
    {
        [Key]
        public int ID_TipoCambio { get; set; }

        public decimal? Compra { get; set; }

        public decimal? Venta { get; set; }

        public DateTime? FechaOperacion { get; set; }

        public int? IdEstado { get; set; }

        public int? UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }
    }
}
