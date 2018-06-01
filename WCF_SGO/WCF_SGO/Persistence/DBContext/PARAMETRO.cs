namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PARAMETRO")]
    public partial class PARAMETRO
    {
        [Key]
        [Column(Order = 0)]
        public int IdParametro { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string TipoParametro { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(20)]
        public string Clave { get; set; }

        [StringLength(20)]
        public string Clave1 { get; set; }

        [StringLength(70)]
        public string Valor { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? UsuarioActualiza { get; set; }

        public int? IdEstado { get; set; }

        [StringLength(30)]
        public string Clave2 { get; set; }
    }
}
