namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICIO_PRP_DETALLE
    {
        [Key]
        public int IdDetalle { get; set; }

        public int IdOrdenServicio { get; set; }

        public int? IdTicketPesada { get; set; }

        public int? IdServicio { get; set; }

        public int? SacoInicial { get; set; }

        public decimal? KgNetoInicial { get; set; }

        public int? SacoUsado { get; set; }

        public decimal? KgNetoUsado { get; set; }

        public int? SacoSaldo { get; set; }

        public decimal? KgNetoSaldo { get; set; }

        public int IdEstado { get; set; }

        public int? IdAnulado { get; set; }

        public virtual SERVICIO_PRP_CABECERA SERVICIO_PRP_CABECERA { get; set; }
    }
}
