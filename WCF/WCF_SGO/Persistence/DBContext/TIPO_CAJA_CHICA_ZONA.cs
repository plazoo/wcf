namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_CAJA_CHICA_ZONA
    {
        [Key]
        public int IdTipoCajaChica { get; set; }

        public int IdLocal { get; set; }

        [StringLength(200)]
        public string Descripcion { get; set; }

        public decimal Tope { get; set; }

        public decimal Monto { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
