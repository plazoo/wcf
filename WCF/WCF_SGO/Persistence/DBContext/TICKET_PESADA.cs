namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TICKET_PESADA
    {
        [Key]
        public int IdTicketPesada { get; set; }

        public int IdTicketPesadaZona { get; set; }

        public int IdCliente { get; set; }

        public int? IdContactoCliente { get; set; }

        [Required]
        [StringLength(2)]
        public string IdLocal { get; set; }

        public DateTime FechaTicket { get; set; }

        public int Cosecha { get; set; }

        public int IdLaboratorio { get; set; }

        public int IdTipoCafe { get; set; }

        public int NroSaco { get; set; }

        public int IdSaco { get; set; }

        public decimal PesoSaco { get; set; }

        public decimal Tara { get; set; }

        public decimal KgBruto { get; set; }

        public decimal KgNeto { get; set; }

        public decimal DsctoAgua { get; set; }

        public decimal KgSeco { get; set; }

        public int IdProceso { get; set; }

        [Column(TypeName = "text")]
        public string Observaciones { get; set; }

        public int IdEstado { get; set; }

        [Required]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

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

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual TIPO_SACO TIPO_SACO { get; set; }
    }
}
