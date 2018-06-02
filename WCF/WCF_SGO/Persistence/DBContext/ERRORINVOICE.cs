namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ERRORINVOICE")]
    public partial class ERRORINVOICE
    {
        [Key]
        [StringLength(6)]
        public string Codigo { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
