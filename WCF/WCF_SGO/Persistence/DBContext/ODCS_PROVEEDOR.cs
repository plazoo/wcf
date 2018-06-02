namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODCS_PROVEEDOR
    {
        [Key]
        public int IdProveedor { get; set; }

        public int IdTipoProveedor { get; set; }

        [Required]
        [StringLength(20)]
        public string vcDocIdentidad { get; set; }

        [Required]
        [StringLength(200)]
        public string vcNombreComercial { get; set; }

        [StringLength(200)]
        public string vcRazonSocial { get; set; }

        [StringLength(100)]
        public string vcNombreCliente { get; set; }

        [StringLength(100)]
        public string vcApellidoCliente { get; set; }

        [StringLength(20)]
        public string vcTelefonoPrincipal { get; set; }

        public int IdDepartamento { get; set; }

        public int IdProvincia { get; set; }

        public int IdDistrito { get; set; }

        [StringLength(300)]
        public string vcDireccion { get; set; }

        public int InEstado { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }
    }
}
