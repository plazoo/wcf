namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_ARCHIVO_CARGAMASIVA
    {
        public int id { get; set; }

        [StringLength(50)]
        public string vcNombreArchivo { get; set; }

        [StringLength(80)]
        public string vcRuta { get; set; }

        public int? idUsuario { get; set; }

        public DateTime? dtFechaRegistro { get; set; }
    }
}
