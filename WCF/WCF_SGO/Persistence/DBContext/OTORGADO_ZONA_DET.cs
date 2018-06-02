namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OTORGADO_ZONA_DET
    {
        [Key]
        public int IdOtorgadoDet { get; set; }

        public int IdOtorgado { get; set; }

        public int IdContrato { get; set; }

        [Required]
        [StringLength(20)]
        public string vcDocumento { get; set; }

        public int inEstado { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int? UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }
    }
}
