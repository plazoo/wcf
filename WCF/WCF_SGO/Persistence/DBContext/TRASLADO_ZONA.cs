namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRASLADO_ZONA
    {
        [Key]
        public int IdDespacho { get; set; }

        [Required]
        [StringLength(2)]
        public string IdLocal { get; set; }

        [StringLength(20)]
        public string Documento { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoEnvio { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(10)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
