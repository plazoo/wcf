namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODCS_HISTORICO
    {
        [Key]
        public int IdHistorico { get; set; }

        public int IdOrden { get; set; }

        public int IdEstadoProceso { get; set; }

        public int IdUsuario { get; set; }

        public DateTime dtFechaRegistro { get; set; }
    }
}
