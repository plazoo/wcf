namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_LOG
    {
        public int id { get; set; }

        [Required]
        public string vcException { get; set; }

        public DateTime dtFecReg { get; set; }

        public int idUsuario { get; set; }
    }
}
