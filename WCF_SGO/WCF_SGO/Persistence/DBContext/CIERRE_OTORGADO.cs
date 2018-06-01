namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIERRE_OTORGADO
    {
        [Key]
        public int IDDETALLE { get; set; }

        public int IDCIERRE { get; set; }

        public int? IdOtorgado { get; set; }

        public int? IdOtorgadoZona { get; set; }

        [StringLength(200)]
        public string CodigoOtorgadoZona { get; set; }

        public int? IdLocal { get; set; }

        public int? IdCliente { get; set; }

        public int? IdContactoCliente { get; set; }

        public string CLIENTE { get; set; }

        [StringLength(200)]
        public string FechaEmision { get; set; }

        [StringLength(200)]
        public string IdTipoIngreso { get; set; }

        public int? IdTipoModalidadOtorgado { get; set; }

        [StringLength(200)]
        public string ModalidadOtorgado { get; set; }

        [StringLength(200)]
        public string DocumentoReferencia { get; set; }

        public int? IdTipoCajaChica { get; set; }

        public int? IdMoneda { get; set; }

        [StringLength(200)]
        public string SIMBOLO { get; set; }

        public decimal? MontoSoles { get; set; }

        public decimal? MontoDolares { get; set; }

        public decimal? TC { get; set; }

        public int? ChkDiferenteMoneda { get; set; }

        public decimal? MontoPagar { get; set; }

        public int? IdTipoMotivoOtorgado { get; set; }

        [StringLength(200)]
        public string MotivoOtorgado { get; set; }

        public string OBSERVACIONES { get; set; }

        public int? IdEstado { get; set; }

        public int? UsuarioRegistro { get; set; }

        [StringLength(200)]
        public string UsuarioRegistra { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? IDCUENTABANCARIA { get; set; }

        [StringLength(200)]
        public string TIPODOCUMENTO { get; set; }

        [StringLength(100)]
        public string DOCUMENTO { get; set; }

        [StringLength(200)]
        public string ContratoCompra { get; set; }

        [StringLength(200)]
        public string APROBACION { get; set; }

        [StringLength(200)]
        public string BANCO { get; set; }

        [StringLength(200)]
        public string NroOperacion { get; set; }

        [StringLength(100)]
        public string FechaTransferencia { get; set; }

        [StringLength(200)]
        public string DESCCUENTABANCARIA { get; set; }

        public int? COSECHA { get; set; }

        [StringLength(5)]
        public string IDAPROBACION { get; set; }

        public virtual CIERRE_ANUAL CIERRE_ANUAL { get; set; }
    }
}
