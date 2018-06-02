namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DISTRITO")]
    public partial class DISTRITO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDepartamento { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdProvincia { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDistrito { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(60)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FechaRegistro { get; set; }
    }
}
