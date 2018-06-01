namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTRATO_COMPRA_UNFIXED
    {
        [Key]
        public int IdContratoUnFix { get; set; }

        public int? IdContrato { get; set; }

        public DateTime? FechaFijacion { get; set; }

        public int? Sacos { get; set; }

        public int? IdMesFijacion { get; set; }

        public decimal? Precio { get; set; }

        public decimal? PrecioSoles { get; set; }

        public int IdEstado { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int? UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        public virtual CONTRATO_COMPRA CONTRATO_COMPRA { get; set; }

        public virtual TIPO_MES_FIJACION TIPO_MES_FIJACION { get; set; }
    }
}
