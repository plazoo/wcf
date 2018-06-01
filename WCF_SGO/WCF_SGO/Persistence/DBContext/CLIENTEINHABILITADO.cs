namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTEINHABILITADO")]
    public partial class CLIENTEINHABILITADO
    {
        [Key]
        public int IdClienteInhabilitado { get; set; }

        [StringLength(10)]
        public string IdTipoCliente { get; set; }

        public int? IdTipoDocumento { get; set; }

        public int? IdCliente { get; set; }

        [StringLength(30)]
        public string DocIdentidad { get; set; }

        [StringLength(200)]
        public string RazonSocial { get; set; }

        [StringLength(200)]
        public string NombreCliente { get; set; }

        [StringLength(200)]
        public string ApellidoCliente { get; set; }

        [StringLength(800)]
        public string Descripcion { get; set; }

        public int? UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? UsuarioActualiza { get; set; }

        public DateTime? FechaActualiza { get; set; }

        [StringLength(1)]
        public string IdEstado { get; set; }
    }
}
