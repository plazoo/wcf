namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OTORGADO_ZONA_BK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOtorgado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOtorgadoZona { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdLocal { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCliente { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdContactoCliente { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FechaEmision { get; set; }

        [StringLength(10)]
        public string IdTipoIngreso { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoModalidadOtorgado { get; set; }

        [StringLength(100)]
        public string DocumentoReferencia { get; set; }

        public int? IdTipoCajaChica { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMoneda { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal Monto { get; set; }

        public decimal? TC { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChkDiferenteMoneda { get; set; }

        public decimal? MontoPagar { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEstado { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        [Key]
        [Column(Order = 13)]
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
