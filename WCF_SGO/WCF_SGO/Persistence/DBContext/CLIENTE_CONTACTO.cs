namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTE_CONTACTO
    {
        [Key]
        public int IdContactoCliente { get; set; }

        public int IdCliente { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(30)]
        public string Telefono { get; set; }

        [StringLength(120)]
        public string Correo { get; set; }

        public int IdArea { get; set; }

        public int IdCargo { get; set; }

        [StringLength(250)]
        public string DireccionFactura { get; set; }

        [StringLength(250)]
        public string DireccionReferencia { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual BANCO BANCO { get; set; }

        public virtual CARGO CARGO { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }
    }
}
