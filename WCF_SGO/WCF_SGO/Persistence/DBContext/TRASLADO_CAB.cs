namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRASLADO_CAB
    {
        [Key]
        [Column(Order = 0)]
        public int IdTraslado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTrasladoInterno { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string IdLocal { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string FechaTraslado { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrigen { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDestino { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMotivo { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoCafe { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEmpresaTransporte { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdChofer { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal GiKgBruto { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal GiTara { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal GiKgNeto { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GiSaco { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal GiRendimiento { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal GiHumedad { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal GrKgBruto { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal GrTara { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal GrKgNeto { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrSaco { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal GrRendimiento { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal GrHumedad { get; set; }

        [StringLength(100)]
        public string Certificado { get; set; }

        [Column(TypeName = "text")]
        public string Observaciones { get; set; }

        public int? IdEstado { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        [Key]
        [Column(Order = 23)]
        public DateTime FechaRegistro { get; set; }

        [StringLength(6)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        [StringLength(50)]
        public string IdCertificado { get; set; }

        [StringLength(50)]
        public string CostoMinimo { get; set; }

        [StringLength(2)]
        public string TipoGuia { get; set; }

        [StringLength(8000)]
        public string Marcas { get; set; }

        [StringLength(70)]
        public string Destino { get; set; }

        [StringLength(20)]
        public string Contenedor { get; set; }

        [StringLength(50)]
        public string Precinto { get; set; }

        [StringLength(10)]
        public string NumContrato { get; set; }

        [StringLength(50)]
        public string Vapor { get; set; }

        public decimal? TCon { get; set; }

        [StringLength(3)]
        public string Serie { get; set; }

        [StringLength(8)]
        public string Numero { get; set; }
    }
}
