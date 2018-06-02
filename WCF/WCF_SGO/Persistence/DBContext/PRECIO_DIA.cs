namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRECIO_DIA
    {
        [Key]
        public int IdPrecioDia { get; set; }

        public int IdLocal { get; set; }

        public int IdMoneda { get; set; }

        public decimal KgBase { get; set; }

        public DateTime FechaPrecio { get; set; }

        public int Defecto { get; set; }

        public int IdTipoCalidadPrecio { get; set; }

        public int IdCertificado { get; set; }

        public decimal Precio { get; set; }

        public int IdEstadoDiario { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
