namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICIO_PRP_RESULTADO
    {
        [Key]
        public int IdResultado { get; set; }

        public int IdOrdenServicio { get; set; }

        public int IdTipoOperacion { get; set; }

        public int IdCalidad { get; set; }

        public decimal Rendimiento { get; set; }

        public int IdTipoCafe { get; set; }

        public int IdTipoSaco { get; set; }

        public int? NroSaco { get; set; }

        public decimal? KgBruto { get; set; }

        public decimal? Tara { get; set; }

        public decimal? KgNeto { get; set; }

        public int? IdGuiaIngreso { get; set; }

        public int? Lote { get; set; }

        public DateTime? FechaRegistro { get; set; }

        [StringLength(250)]
        public string Certificado { get; set; }

        public int ChkLiquidacion { get; set; }

        public int IdTransito { get; set; }

        public int IdProceso { get; set; }

        [StringLength(250)]
        public string IdCertificado { get; set; }

        public int? IdTipoRuma { get; set; }

        public int? inMascaraClie { get; set; }

        public int? inValidado { get; set; }

        public int? inUsuarioValida { get; set; }

        public DateTime? dtFechaValida { get; set; }

        public virtual GUIA_INGRESO_CAB GUIA_INGRESO_CAB { get; set; }

        public virtual SERVICIO_PRP_CABECERA SERVICIO_PRP_CABECERA { get; set; }
    }
}
