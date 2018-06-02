namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OTORGADO_SALDO_INICIAL
    {
        [Key]
        public int IdOtorgado { get; set; }

        public int IdOtorgadoZona { get; set; }

        public int IdLocal { get; set; }

        public int IdCliente { get; set; }

        public int IdContactoCliente { get; set; }

        public DateTime FechaEmision { get; set; }

        [StringLength(10)]
        public string IdTipoIngreso { get; set; }

        public int IdTipoModalidadOtorgado { get; set; }

        [StringLength(100)]
        public string DocumentoReferencia { get; set; }

        public int? IdTipoCajaChica { get; set; }

        public int IdMoneda { get; set; }

        public decimal Monto { get; set; }

        public decimal? TC { get; set; }

        public int ChkDiferenteMoneda { get; set; }

        public decimal? MontoPagar { get; set; }

        public int IdTipoMotivoOtorgado { get; set; }

        public int? IdBanco { get; set; }

        [StringLength(100)]
        public string NroOperacion { get; set; }

        public DateTime? FechaTransferencia { get; set; }

        [StringLength(8000)]
        public string Observaciones { get; set; }

        public int? IdCuentaBancaria { get; set; }

        [StringLength(100)]
        public string DescCuentaBancaria { get; set; }

        [StringLength(1)]
        public string IdAprobacion { get; set; }

        [StringLength(10)]
        public string TipoDocumento { get; set; }

        [StringLength(100)]
        public string Documento { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(6)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        public int? UsuarioAnula { get; set; }

        public DateTime? FechaAnula { get; set; }

        public int? UsuarioAprobacion { get; set; }

        public DateTime? FechaAprobacion { get; set; }

        public int? cosecha { get; set; }
    }
}
