namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CORREO")]
    public partial class CORREO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCorreo { get; set; }

        [Required]
        [StringLength(150)]
        public string Modulo { get; set; }

        [Column("Correo")]
        [Required]
        [StringLength(200)]
        public string Correo1 { get; set; }

        public int IdEstado { get; set; }
    }
}
