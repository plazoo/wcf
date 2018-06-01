namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRASLADO_EMPRESA
    {
        [Key]
        public int IdEmpresaTransporte { get; set; }

        [Required]
        [StringLength(2)]
        public string IdLocal { get; set; }

        [StringLength(20)]
        public string DocumentoIdentidad { get; set; }

        [StringLength(200)]
        public string RazonSocial { get; set; }

        [StringLength(200)]
        public string NombreComercial { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(10)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int? BlackList { get; set; }

        [StringLength(10)]
        public string UsuarioBL { get; set; }

        public DateTime? FechaBL { get; set; }

        [StringLength(250)]
        public string Comentario { get; set; }
    }
}
