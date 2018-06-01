namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GUIA_INGRESO_DET_BK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdGuiaIngresoDetalle { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdGuia { get; set; }

        public int? IdTicketPesada { get; set; }

        public int? IdOrdenServicio { get; set; }

        public int? IdResultado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NroSaco { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal KgBruto { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal Tara { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal KgNeto { get; set; }

        public int? IdEstado { get; set; }
    }
}
