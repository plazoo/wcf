namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAJACHICA_SALDO
    {
        [Key]
        public int IdCajaChicaSaldo { get; set; }

        public decimal MontoInicial { get; set; }

        public decimal MontoOperacion { get; set; }

        public decimal Saldo { get; set; }

        [StringLength(500)]
        public string Observacion { get; set; }

        public int? IdEstado { get; set; }

        public int? Vigente { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public int IdCajaChica { get; set; }

        public int? IdGasto_PRP { get; set; }

        public int? IdMovilidadCab { get; set; }

        public int? IdCajaChicaSaldoRef { get; set; }

        public long? Tick { get; set; }

        public virtual CAJACHICA CAJACHICA { get; set; }

        public virtual GASTO_PRP_CAB GASTO_PRP_CAB { get; set; }

        public virtual GASTO_MOVILIDAD_CAB GASTO_MOVILIDAD_CAB { get; set; }
    }
}
