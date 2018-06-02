namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GUIA_INGRESO_CAB_BK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdGuia { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdGuiaIngreso { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string IdLocal { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCliente { get; set; }

        public int? IdContactoCliente { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoCafe { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cosecha { get; set; }

        [StringLength(20)]
        public string RumaDestino { get; set; }

        public decimal? PromedioRendimiento { get; set; }

        public decimal? PromedioHumedad { get; set; }

        public decimal? PromedioTaza { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TotalSaco { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal TotalKgBruto { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal TotalTara { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal TotalDsctoAgua { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal TotalKgNeto { get; set; }

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

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Impresion { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChkLiquidacion { get; set; }

        public int? IdProceso { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTransito { get; set; }

        [StringLength(200)]
        public string IdCertificadoVSP { get; set; }

        [StringLength(200)]
        public string DescCertificacion { get; set; }

        [StringLength(10)]
        public string ModalidadIngreso { get; set; }

        public int? IdDivision { get; set; }

        public int? IdGuiaReferencia { get; set; }

        public int? IdProductor { get; set; }

        public int? IdIngresoPRP { get; set; }

        public int? IdOficinaOrigen { get; set; }

        public int? IdTraslado { get; set; }

        [StringLength(200)]
        public string GuiaRemisionExterna { get; set; }

        public int? IdClienteTrazabilidad { get; set; }

        public int? IdTrasladoFila { get; set; }
    }
}
