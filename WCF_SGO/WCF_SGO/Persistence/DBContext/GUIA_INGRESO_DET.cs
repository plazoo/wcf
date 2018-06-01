namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GUIA_INGRESO_DET
    {
        [Key]
        public int IdGuiaIngresoDetalle { get; set; }

        public int IdGuia { get; set; }

        public int? IdTicketPesada { get; set; }

        public int? IdOrdenServicio { get; set; }

        public int? IdResultado { get; set; }

        public int NroSaco { get; set; }

        public decimal KgBruto { get; set; }

        public decimal Tara { get; set; }

        public decimal KgNeto { get; set; }

        public int? IdEstado { get; set; }

        public int? IdSSAsignado { get; set; }

        public virtual GUIA_INGRESO_CAB GUIA_INGRESO_CAB { get; set; }
    }
}
