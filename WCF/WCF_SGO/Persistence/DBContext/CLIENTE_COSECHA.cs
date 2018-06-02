namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTE_COSECHA
    {
        [Key]
        public int IdClienteCosecha { get; set; }

        public int IdCosecha { get; set; }

        public int IdCliente { get; set; }

        public int InEstado { get; set; }

        public int InVigente { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }
    }
}
