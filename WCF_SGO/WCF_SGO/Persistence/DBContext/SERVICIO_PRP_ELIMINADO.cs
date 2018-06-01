namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICIO_PRP_ELIMINADO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdResultado { get; set; }

        public int? IdOrdenServicio { get; set; }

        public int? IdTipoOperacion { get; set; }

        public int? IdCalidad { get; set; }

        public decimal? Rendimiento { get; set; }

        public int? IdTipoCafe { get; set; }

        public int? IdTipoSaco { get; set; }

        public int? NroSaco { get; set; }

        public decimal? KgBruto { get; set; }

        public decimal? Tara { get; set; }

        public decimal? KgNeto { get; set; }

        public int? IdGuiaIngreso { get; set; }

        public int? Lote { get; set; }
    }
}
