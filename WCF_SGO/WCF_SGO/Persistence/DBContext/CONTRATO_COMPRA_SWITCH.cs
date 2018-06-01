namespace Persistence.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTRATO_COMPRA_SWITCH
    {
        [Key]
        public int IdSwitch { get; set; }

        public int IdContrato { get; set; }

        public int IdFijacionActual { get; set; }

        public decimal DiferencialActual { get; set; }

        public int IdTipoDiferencialActual { get; set; }

        public int IdFijacionNuevo { get; set; }

        public decimal DiferencialNuevo { get; set; }

        public int IdTipoDiferencialNuevo { get; set; }

        public int Cantidad { get; set; }

        public int IdEstado { get; set; }

        public int UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual CONTRATO_COMPRA CONTRATO_COMPRA { get; set; }
    }
}
