namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GASTO_APROBACION
    {
        [Key]
        public int IdGastoAprobacion { get; set; }

        public int? IdGasto_PRP { get; set; }

        public int? IdGastoMovilidad { get; set; }

        [StringLength(200)]
        public string Descripcion { get; set; }

        public DateTime? FechaRegistra { get; set; }

        public int? UsuarioRegistra { get; set; }

        public int? IdEstadoAprobacion { get; set; }

        public int? IdEstado { get; set; }

        public int? TipoTransaccion { get; set; }

        [StringLength(30)]
        public string NroChequeCuentaBanco { get; set; }

        public virtual GASTO_MOVILIDAD_CAB GASTO_MOVILIDAD_CAB { get; set; }

        public virtual GASTO_PRP_CAB GASTO_PRP_CAB { get; set; }
    }
}
