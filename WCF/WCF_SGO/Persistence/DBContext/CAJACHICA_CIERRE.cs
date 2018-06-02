namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAJACHICA_CIERRE
    {
        [Key]
        public int IdCajaChicaCierre { get; set; }

        public int IdGastoMovilidadPRP { get; set; }

        public int IdCajaChica { get; set; }

        public int? IdTipoGasto { get; set; }

        public int? IdEstado { get; set; }

        public int? Cierre { get; set; }

        public long? Tick { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? UsuarioActualiza { get; set; }
    }
}
