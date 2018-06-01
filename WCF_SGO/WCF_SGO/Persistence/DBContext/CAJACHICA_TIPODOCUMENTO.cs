namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAJACHICA_TIPODOCUMENTO
    {
        [Key]
        public int IdCajaChicaTipoDocumento { get; set; }

        public int? IdSubTipo { get; set; }

        [StringLength(5)]
        public string TipoDocumento { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        public int? IdEstado { get; set; }
    }
}
