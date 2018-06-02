namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRABAJADOR_PRP_JEFATURA
    {
        [Key]
        public int IdJefaturaPRP { get; set; }

        public int? IdTrabajador { get; set; }

        public int? IdJefatura { get; set; }

        public int? IdEstado { get; set; }
    }
}
