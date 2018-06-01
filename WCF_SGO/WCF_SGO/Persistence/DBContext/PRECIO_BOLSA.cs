namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRECIO_BOLSA
    {
        [Key]
        public int IdPrecioBolsa { get; set; }

        public DateTime FechaPrecio { get; set; }

        public int? IdMesFijacion { get; set; }

        public decimal? PrecioInicio { get; set; }

        public decimal? PrecioBajo { get; set; }

        public decimal? PrecioAlto { get; set; }

        public decimal? PrecioCierre { get; set; }

        public int IdEstado { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int? UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        public decimal PrecioVolumen { get; set; }

        public int? UsuarioElim { get; set; }

        public DateTime? FechaElim { get; set; }

        public virtual TIPO_MES_FIJACION TIPO_MES_FIJACION { get; set; }
    }
}
