namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRASLADO_DET
    {
        [Key]
        public int IdDetalle { get; set; }

        public int IdTraslado { get; set; }

        public int IdGuia { get; set; }

        [StringLength(10)]
        public string Lote { get; set; }

        [Required]
        [StringLength(5)]
        public string TipoDocumento { get; set; }

        public int? NroFila { get; set; }

        [StringLength(150)]
        public string Certificado { get; set; }

        public decimal GiKgBruto { get; set; }

        public decimal GiTara { get; set; }

        public decimal GiKgNeto { get; set; }

        public int GiSaco { get; set; }

        public decimal GiRendimiento { get; set; }

        public decimal GiHumedad { get; set; }

        public decimal? GrKgBruto { get; set; }

        public decimal? GrTara { get; set; }

        public decimal? GrKgNeto { get; set; }

        public int? GrSaco { get; set; }

        public decimal? GrRendimiento { get; set; }

        public decimal? GrHumedad { get; set; }

        public int? GuiaSaco { get; set; }

        public decimal? GuiaKgBruto { get; set; }

        public decimal? GuiaTara { get; set; }

        public decimal? GuiaKgNeto { get; set; }

        public int IdEstado { get; set; }

        public decimal? GrPromRendimiento { get; set; }

        public decimal? GrPromHumedad { get; set; }

        [StringLength(50)]
        public string IdCertificado { get; set; }
    }
}
