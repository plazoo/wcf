namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_TRADER
    {
        [Key]
        public int IdTipoTrader { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreTrader { get; set; }

        [Required]
        [StringLength(100)]
        public string ApellidoTrader { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
