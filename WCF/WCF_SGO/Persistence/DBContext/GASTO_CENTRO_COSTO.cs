namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GASTO_CENTRO_COSTO
    {
        [Key]
        public int IdGastoCentroCosto { get; set; }

        [StringLength(3)]
        public string Codigo { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [StringLength(20)]
        public string Zona { get; set; }

        [StringLength(30)]
        public string IdLocal { get; set; }

        public int? IdEstado { get; set; }
    }
}
