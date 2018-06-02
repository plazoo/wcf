namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LABORATORIO_REFERENCIA
    {
        [Key]
        public int IdReferencia { get; set; }

        public int? IdLaboratorio { get; set; }

        public int? IdLaboratorioRef { get; set; }

        public int? IdEstado { get; set; }

        public virtual LABORATORIO LABORATORIO { get; set; }
    }
}
