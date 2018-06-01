namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_COSECHA
    {
        [Key]
        public int IdCosecha { get; set; }

        [Required]
        [StringLength(30)]
        public string vcCosecha { get; set; }

        [StringLength(30)]
        public string vcComentario { get; set; }

        public int IdEstado { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int? UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }
    }
}
