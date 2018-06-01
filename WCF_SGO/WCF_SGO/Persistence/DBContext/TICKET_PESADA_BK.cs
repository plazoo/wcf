namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TICKET_PESADA_BK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTicketPesada { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTicketPesadaZona { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCliente { get; set; }

        public int? IdContactoCliente { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string IdLocal { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime FechaTicket { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cosecha { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdLaboratorio { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoCafe { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NroSaco { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdSaco { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal PesoSaco { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal Tara { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal KgBruto { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal KgNeto { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal DsctoAgua { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal KgSeco { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdProceso { get; set; }

        [Column(TypeName = "text")]
        public string Observaciones { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEstado { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        [Key]
        [Column(Order = 19)]
        public DateTime FechaRegistro { get; set; }

        [StringLength(6)]
        public string UsuarioModifica { get; set; }

        public DateTime? FechaModifica { get; set; }

        public int? IdGuiaIngreso { get; set; }

        [StringLength(20)]
        public string IdExcel { get; set; }

        [StringLength(100)]
        public string GiExcel { get; set; }

        [StringLength(100)]
        public string IdGuiaRemision { get; set; }

        [StringLength(200)]
        public string GuiaRemision { get; set; }
    }
}
