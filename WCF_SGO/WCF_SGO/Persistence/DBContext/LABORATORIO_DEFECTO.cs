namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LABORATORIO_DEFECTO
    {
        [Key]
        public int IdDefectoLaboratorio { get; set; }

        public int IdLaboratorio { get; set; }

        public int IdTaza { get; set; }

        public int NumDefecto { get; set; }

        public int IdEstado { get; set; }

        public virtual LABORATORIO LABORATORIO { get; set; }

        public virtual TIPO_TAZA TIPO_TAZA { get; set; }
    }
}
