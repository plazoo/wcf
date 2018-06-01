namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPROBANTEVENTA_APROBACION
    {
        [Key]
        public int IdAprobacion { get; set; }

        public int? IdUsuarioRegistra { get; set; }

        public int? IdUsuarioAprueba { get; set; }

        [StringLength(30)]
        public string IdLocal { get; set; }

        public int? IdEstado { get; set; }
    }
}
