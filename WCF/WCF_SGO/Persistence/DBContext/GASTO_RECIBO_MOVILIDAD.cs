namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GASTO_RECIBO_MOVILIDAD
    {
        [Key]
        public int IdGastoPRPDetRM { get; set; }

        [StringLength(2)]
        public string IdLocal { get; set; }

        [StringLength(20)]
        public string IdCodigoInternoRM { get; set; }

        public int? IdGasto_PRPRM { get; set; }

        public int? IdTipoDocumentoRM { get; set; }

        public int? IdTipoOperacionRM { get; set; }

        public int? IdCatalogoCuentaContableRM { get; set; }

        public int? IdGastoCentroCostoRM { get; set; }

        public DateTime? DocumentoFechaRM { get; set; }

        [StringLength(4)]
        public string DocumentoSerieRM { get; set; }

        [StringLength(16)]
        public string DocumentoNumeroRM { get; set; }

        [StringLength(11)]
        public string RUCRM { get; set; }

        [StringLength(150)]
        public string ProveedorRM { get; set; }

        [StringLength(400)]
        public string DescripcionRM { get; set; }

        [StringLength(3)]
        public string IdMonedaRM { get; set; }

        public decimal? BaseImponibleRM { get; set; }

        public decimal? ImpuestoIGVRM { get; set; }

        public decimal? InafectosRM { get; set; }

        public decimal? MontoRedondeoRM { get; set; }

        public decimal? MontoTotalRM { get; set; }

        public int? IdEstado { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public DateTime? FechaActualiza { get; set; }

        public int? UsuarioActualiza { get; set; }

        public int? inMovilidadNacional { get; set; }
    }
}
