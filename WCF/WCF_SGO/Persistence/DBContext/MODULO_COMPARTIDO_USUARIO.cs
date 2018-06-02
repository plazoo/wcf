namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MODULO_COMPARTIDO_USUARIO
    {
        public int Id { get; set; }

        public int IdUsuario { get; set; }

        [Required]
        [StringLength(20)]
        public string vcModulo { get; set; }

        [Required]
        [StringLength(10)]
        public string vcMenu { get; set; }

        public int? InEstado { get; set; }

        public DateTime? dtReg { get; set; }
    }
}
