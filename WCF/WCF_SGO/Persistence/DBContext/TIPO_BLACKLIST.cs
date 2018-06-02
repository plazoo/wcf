namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_BLACKLIST
    {
        [Key]
        public int IdBlackList { get; set; }

        [StringLength(200)]
        public string NombreTabla { get; set; }

        public int? IdUsuario { get; set; }

        public int? IdEstado { get; set; }
    }
}
