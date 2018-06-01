namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIERRE_GUIAINGRESO
    {
        [Key]
        public int IDCIERREGI { get; set; }

        public int IDDETALLE { get; set; }

        public int? IDGUIA { get; set; }

        [StringLength(200)]
        public string GUIAINGRESO { get; set; }

        public int? IDLOCAL { get; set; }

        public int? IDCLIENTE { get; set; }

        public string CLIENTE { get; set; }

        public int? IDCONTACTOCLIENTE { get; set; }

        public string CONTACTOCLIENTE { get; set; }

        public int? RUMADESTINO { get; set; }

        public decimal? PROMEDIORENDIMIENTO { get; set; }

        public decimal? PROMEDIOHUMEDAD { get; set; }

        public decimal? PROMEDIOTAZA { get; set; }

        [StringLength(250)]
        public string DESCCERTIFICACION { get; set; }

        [StringLength(250)]
        public string IdCertificadoVSP { get; set; }

        public int? TOTALSACO { get; set; }

        public decimal? TOTALKGBRUTO { get; set; }

        public decimal? TOTALTARA { get; set; }

        public decimal? TOTALKGNETO { get; set; }

        public int? IDPROCESO { get; set; }

        [StringLength(200)]
        public string ProcesoDescripcion { get; set; }

        [StringLength(100)]
        public string ESTADO { get; set; }

        [StringLength(100)]
        public string PROPIEDAD { get; set; }

        [StringLength(100)]
        public string DESCUSUARIOREGISTRO { get; set; }

        [StringLength(100)]
        public string FECHAREGISTRO { get; set; }

        [StringLength(100)]
        public string DESCUSUARIOMODIFICA { get; set; }

        [StringLength(100)]
        public string FECHAMODIFICA { get; set; }

        public int? IMPRESION { get; set; }

        [StringLength(200)]
        public string RUMA { get; set; }

        [StringLength(200)]
        public string MODALIDADINGRESO { get; set; }

        public decimal? TOTALDSCTOAGUA { get; set; }

        public int? IdTipoCaFe { get; set; }

        [StringLength(200)]
        public string TipoCafe { get; set; }

        [StringLength(200)]
        public string ORIGEN { get; set; }

        [StringLength(200)]
        public string TRASLADO { get; set; }

        [StringLength(200)]
        public string GUIAREMISIONEXTERNA { get; set; }

        public string OBSERVACION { get; set; }

        [StringLength(200)]
        public string CONTRATOCOMPRA { get; set; }

        [StringLength(200)]
        public string LIQUIDACION { get; set; }

        public int? IDCONTRATO { get; set; }

        [StringLength(200)]
        public string SS { get; set; }

        public decimal? DIF_NETOYAGUA { get; set; }

        [StringLength(200)]
        public string CALIDAD { get; set; }

        public virtual CIERRE_ANUAL CIERRE_ANUAL { get; set; }
    }
}
