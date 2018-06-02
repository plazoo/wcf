namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GUIA_INGRESO_SALDO
    {
        [Key]
        public int IdTicketPesadaSaldo { get; set; }

        public int? IdGuia { get; set; }

        public int? IdTicketPesada { get; set; }

        public int? IdCliente { get; set; }

        public int? Cosecha { get; set; }

        public int? Saco { get; set; }

        public decimal? KgBruto { get; set; }

        public decimal? Tara { get; set; }

        public decimal? KgNeto { get; set; }

        public int? SacoOperacion { get; set; }

        public decimal? KgBrutoOperacion { get; set; }

        public decimal? TaraOperacion { get; set; }

        public decimal? KgNetoOperacion { get; set; }

        public int? SacoSaldo { get; set; }

        public decimal? KgBrutoSaldo { get; set; }

        public decimal? TaraSaldo { get; set; }

        public decimal? KgNetoSaldo { get; set; }

        public int? IdEstado { get; set; }

        [StringLength(6)]
        public string UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }
    }
}
