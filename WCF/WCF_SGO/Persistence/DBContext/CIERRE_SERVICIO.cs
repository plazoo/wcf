namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIERRE_SERVICIO
    {
        [Key]
        public int IDDETALLE { get; set; }

        public int IDCIERRE { get; set; }

        public int? DIAS { get; set; }

        public int? IDORDENSERVICIO { get; set; }

        public string CODIGOORDENSERVICIO { get; set; }

        public int? IDLOCAL { get; set; }

        public string LOCAL { get; set; }

        public string IDTIPOSERVICIO { get; set; }

        public string TIPOSERVICIO { get; set; }

        public int? IDCLIENTE { get; set; }

        public string CLIENTE { get; set; }

        public string TIPO_CAFE { get; set; }

        public int? INICIOSACO { get; set; }

        public decimal? INICIOTARA { get; set; }

        public decimal? INICIOKGBRUTO { get; set; }

        public decimal? INICIOKGNETO { get; set; }

        public int? FINSACO { get; set; }

        public decimal? FINTARA { get; set; }

        public decimal? FINKGBRUTO { get; set; }

        public decimal? FINKGNETO { get; set; }

        public string CERTIFICADO { get; set; }

        public int? IDESTADO { get; set; }

        public string ESTADO { get; set; }

        public int? USUARIOREGISTRO { get; set; }

        public string VUSUARIO { get; set; }

        public DateTime? FECHAREGISTRO { get; set; }

        public string OBSERVACION { get; set; }

        public string CodigoLiquidacion { get; set; }

        public string CodigoTraslado { get; set; }

        public virtual CIERRE_ANUAL CIERRE_ANUAL { get; set; }
    }
}
