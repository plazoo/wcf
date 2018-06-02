namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRASLADO_MOTIVO
    {
        [Key]
        public int IdMotivo { get; set; }

        [StringLength(200)]
        public string Descripcion { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(10)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
