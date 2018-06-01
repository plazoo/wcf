namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODCS_ESTADOS
    {
        [Key]
        public int IdEstadoProceso { get; set; }

        public int inTipoEstado { get; set; }

        [Required]
        [StringLength(50)]
        public string vcEstadoProceso { get; set; }

        public int inEstado { get; set; }
    }
}
