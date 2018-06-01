namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTE_LIMITE
    {
        [Key]
        public int IdLimite { get; set; }

        public int IdCliente { get; set; }

        public decimal PorcentajeExtra { get; set; }

        public decimal LimiteCompra { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }
    }
}
