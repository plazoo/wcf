namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICIO_PRP_CABECERA_BK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrdenServicio { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrdenServicioInterno { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string IdLocal { get; set; }

        [StringLength(250)]
        public string IdTipoServicio { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoCafe { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cosecha { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCliente { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InicioSaco { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal InicioTara { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal InicioKgBruto { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal InicioKgNeto { get; set; }

        public int? FinTipoSaco { get; set; }

        public int? FinSaco { get; set; }

        public decimal? FinTara { get; set; }

        public decimal? FinKgBruto { get; set; }

        public decimal? FinKgNeto { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEstado { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime FechaRegistro { get; set; }

        [StringLength(6)]
        public string UsuarioFinProceso { get; set; }

        public DateTime? FechaFinProceso { get; set; }

        [StringLength(6)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        [StringLength(250)]
        public string TipoServicioDescripcion { get; set; }
    }
}
