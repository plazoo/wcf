namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIERRE_LIQUIDACION
    {
        [Key]
        public int IDDETALLE { get; set; }

        public int IDCIERRE { get; set; }

        public int? IdLiquidacion { get; set; }

        public int? IdLocal { get; set; }

        [StringLength(200)]
        public string CodigoLiquidacion { get; set; }

        public int? IdCliente { get; set; }

        [StringLength(200)]
        public string CLIENTE { get; set; }

        public int? IdContactoCliente { get; set; }

        public string PRODUCTOR { get; set; }

        public DateTime? FechaLiquidacion { get; set; }

        [StringLength(200)]
        public string IdGuiaIngreso { get; set; }

        public string DescGuiaIngreso { get; set; }

        public int? IdContratoCompra { get; set; }

        [StringLength(200)]
        public string DescContratoCompra { get; set; }

        public decimal? TotalSacoGi { get; set; }

        public decimal? TotalKgNetoGi { get; set; }

        public decimal? TotalSacoCc { get; set; }

        public decimal? TotalKgNetoCc { get; set; }

        public decimal? DiferenciaSaco { get; set; }

        public decimal? DiferenciaKg { get; set; }

        [StringLength(200)]
        public string CALIDAD { get; set; }

        public int? IDTIPORENDIMIENTO { get; set; }

        public decimal? CANTIDAD { get; set; }

        public decimal? KGLIQUIDADO { get; set; }

        public decimal? PRECIO { get; set; }

        public decimal? KGBASE { get; set; }

        public decimal? PRECIOVENTA { get; set; }

        public int? IdEstado { get; set; }

        [StringLength(200)]
        public string UsuarioRegistra { get; set; }

        public DateTime? FechaRegistro { get; set; }

        [StringLength(200)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        public int? IdEstado2 { get; set; }

        [StringLength(200)]
        public string FacturaSerie { get; set; }

        [StringLength(200)]
        public string FacturaNumero { get; set; }

        [StringLength(200)]
        public string FacturaFecha { get; set; }

        [StringLength(200)]
        public string SerieDocumento { get; set; }

        [StringLength(200)]
        public string NroDocumento { get; set; }

        [StringLength(200)]
        public string CERTIFICACION { get; set; }

        [StringLength(200)]
        public string USUARIOASIGNACIONPRECIO { get; set; }

        public DateTime? FECHAASIGNACIONPRECIO { get; set; }

        public virtual CIERRE_ANUAL CIERRE_ANUAL { get; set; }
    }
}
